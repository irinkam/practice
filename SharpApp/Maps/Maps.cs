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
            string html = File.ReadAllText(@"..\..\..\..\HtmlMaps\generated\_map1.html");
            browser.DocumentText = html;

            egeComboBox.Items.Add(">80");
            egeComboBox.Items.Add("Между 60 и 80");
            egeComboBox.Items.Add("Меньше 60");
            egeComboBox.Items.Add("Без фильтра");
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
                switch (egeComboBox.SelectedIndex)
                {
                    case -1:
                        throw new Exception();
                    case 0:
                        html = File.ReadAllText(@"..\..\..\..\HtmlMaps\generated\_map2.html");
                        break;                  
                    case 1:                     
                        html = File.ReadAllText(@"..\..\..\..\HtmlMaps\generated\_map3.html");
                        break;                  
                    case 2:                     
                        html = File.ReadAllText(@"..\..\..\..\HtmlMaps\generated\_map4.html");
                        break;                  
                    default:                    
                        html = File.ReadAllText(@"..\..\..\..\HtmlMaps\generated\_map1.html");
                        break;
                }
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