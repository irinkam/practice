using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maps
{
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();

            //browser.Url = new Uri((@"C:\Users\IrinaMesh\PycharmProjects\untitled2\HtmlMaps\generated\_map1.html"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string fullPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string html = File.ReadAllText(@"..\..\..\..\HtmlMaps\map1.html");
            browser.DocumentText = html;

            egeComboBox.Items.Add(">80");
            egeComboBox.Items.Add("Между 60 и 80");
            egeComboBox.Items.Add("Меньше 60");
            egeComboBox.Items.Add("Без фильтра");

            disciplineComboBox.Items.Add("Физика");
            disciplineComboBox.Items.Add("Математика");
            disciplineComboBox.Items.Add("Русский язык");
            disciplineComboBox.Items.Add("Информатика и ИКТ");
            disciplineComboBox.Items.Add("Химия");
            disciplineComboBox.Items.Add("Обществознание");
            disciplineComboBox.Items.Add("Творческий конкурс");
            disciplineComboBox.Items.Add("География");
            disciplineComboBox.Items.Add("Без фильтра");
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            newMenu.Show();
            this.Visible = false;
        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string html = "";
                string index = "";
                string selectedDiscipline = "";
                switch (egeComboBox.SelectedIndex)
                {
                    case -1:
                        throw new Exception();
                    case 0:
                        index = "2";
                        break;                  
                    case 1:
                        index = "3";
                        break;                  
                    case 2:
                        index = "4";
                        break;                  
                    default:
                        index = "1";
                        break;
                }

                switch (disciplineComboBox.SelectedIndex)
                {
                    case -1:
                        throw new Exception();
                    case 0:
                        selectedDiscipline = "phys_cities";
                        break;
                    case 1:
                        selectedDiscipline = "math_cities";
                        break;
                    case 2:
                        selectedDiscipline = "rus_cities";
                        break;
                    case 3:
                        selectedDiscipline = "ikt_cities";
                        break;
                    case 4:
                        selectedDiscipline = "chemistry_cities";
                        break;
                    case 5:
                        selectedDiscipline = "social_cities";
                        break;
                    case 6:
                        selectedDiscipline = "creation_cities";
                        break;
                    case 7:
                        selectedDiscipline = "geo_cities";
                        break;
                    default:
                        selectedDiscipline = "map";
                        break;
                }

                html = File.ReadAllText(@"..\..\..\..\HtmlMaps\" + selectedDiscipline + index + ".html");

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

        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}