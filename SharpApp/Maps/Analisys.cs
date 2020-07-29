using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Maps
{
    public partial class Analisys_cs : Telerik.WinControls.UI.RadForm
    {
        public Analisys_cs()
        {
            InitializeComponent();

            //this.FormClosing += Form_Closing;

            disciplineComboBox.Items.Add("Физика");
            disciplineComboBox.Items.Add("Русский язык");
            disciplineComboBox.Items.Add("Математика");
            disciplineComboBox.Items.Add("Информатика и ИКТ");
            disciplineComboBox.Items.Add("Обществознание");
            disciplineComboBox.Items.Add("Химия");
            disciplineComboBox.Items.Add("Творческий конкурс");
            disciplineComboBox.Items.Add("География");

            dataGridView1.Visible = false;
        }

        private void LoadData(string discipline)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "IRINAMESH";
                builder.InitialCatalog = "bigData2020";
                builder.IntegratedSecurity = true;

                List<string[]> data = new List<string[]>();
                List<string[]> coord = new List<string[]>();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select * ");
                    sb.Append("from (select top 5000 Учебное_Заведение, Поступающие.Город, count(Поступающие.ID) as [Число_поступающих], avg(Балл) as [Средний балл], Широта, Долгота ");
                    sb.Append("from Оценки ");
                    sb.Append("inner join Поступающие on Оценки.ID = Поступающие.ID ");
                    sb.Append("inner join Города on Города.Город = Поступающие.Город ");
                    sb.Append("where Оценки.Предмет = '");
                    sb.Append(discipline + "' ");
                    sb.Append("group by Учебное_Заведение, Поступающие.Город, Широта, Долгота ");
                    sb.Append("order by Город, Учебное_Заведение desc) as Таблица ");
                    sb.Append("order by Таблица.[Средний балл] desc;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Add(new string[6]);

                                data[data.Count - 1][0] = reader[0].ToString(); // школа
                                data[data.Count - 1][1] = reader[1].ToString(); // город
                                data[data.Count - 1][2] = reader[2].ToString(); // число поступающих
                                data[data.Count - 1][3] = reader[3].ToString(); // балл
                                data[data.Count - 1][4] = reader[4].ToString(); // широта
                                data[data.Count - 1][5] = reader[5].ToString(); // долгота
                            }

                            reader.Close();
                        }
                    }
                }

                FillDataGrid(data);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void FillDataGrid(List<string[]> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = data[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = data[i][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = DistanceCount(data[i][4], data[i][5], i).ToString();
                dataGridView1.Rows[i].Cells[3].Value = data[i][2].ToString();
                dataGridView1.Rows[i].Cells[4].Value = data[i][3].ToString();
            }
        }

        private double DistanceCount(string l, string w, int i)
        {
            double c1 = Convert.ToDouble(l);
            double c2 = Convert.ToDouble(w);
            return Math.Round(
                   GeoCalculate.CalcDistance(c1, c2, 56.4847036, 84.9481737, GeoCodeCalcMeasurement.Kilometers));
        }

        private void ColoredDistance()
        {
            Color distColor = new Color();
            double distance;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                distance = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (distance <= 500) distColor = Color.LightGreen;
                    else if (distance > 500 && distance <= 1500) distColor = Color.LemonChiffon;
                    else if (distance > 1500) distColor = Color.PaleVioletRed;

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = distColor;
                }
            }
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            try
            {
                string discipline = disciplineComboBox.SelectedItem.ToString();

                dataGridView1.Visible = true;
                dataGridView1.Rows.Clear();
                LoadData(discipline);
                ColoredDistance();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран предмет", "Ошибка");
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        //private void Form_Closing(object sender, FormClosingEventArgs e)
        //{
        //    //base.OnFormClosing(e);
        //    if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        Dispose(true);
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}

        //private DialogResult PreClosingConfirmation()
        //{
        //    DialogResult res = System.Windows.Forms.MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    return res;
        //}
    }
}