using System;
using System.IO;
using System.Windows.Forms;

namespace Maps
{
    public partial class Plots : Telerik.WinControls.UI.RadForm
    {
        public Plots()
        {
            InitializeComponent();

            disciplineComboBox.Items.Add("Физика");
            disciplineComboBox.Items.Add("Математика");
            disciplineComboBox.Items.Add("Русский язык");
            disciplineComboBox.Items.Add("Информатика и ИКТ");
            disciplineComboBox.Items.Add("Химия");
            disciplineComboBox.Items.Add("Обществознание");
            disciplineComboBox.Items.Add("Творческий конкурс");
            disciplineComboBox.Items.Add("География");

            browser.Visible = false;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                string html = "";
                string selectedDiscipline = "";

                switch (disciplineComboBox.SelectedIndex)
                {
                    case -1:
                        throw new Exception();
                    case 0:
                        selectedDiscipline = "phys_new";
                        break;
                    case 1:
                        selectedDiscipline = "math_new";
                        break;
                    case 2:
                        selectedDiscipline = "rus_new";
                        break;
                    case 3:
                        selectedDiscipline = "ikt_new";
                        break;
                    case 4:
                        selectedDiscipline = "chemistry_new";
                        break;
                    case 5:
                        selectedDiscipline = "social_new";
                        break;
                    case 6:
                        selectedDiscipline = "creation_new";
                        break;
                    case 7:
                        selectedDiscipline = "geo_new";
                        break;
                    default:
                        selectedDiscipline = "phys_new";
                        break;
                }

                html = File.ReadAllText(@"..\..\..\..\Charts\Scatters_new\" + selectedDiscipline + ".html");

                browser.Visible = true;
                browser.DocumentText = html;
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран фильтр", "Ошибка");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Visible = false;
        }
    }
}
