using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Maps
{
    public partial class Menu : Telerik.WinControls.UI.RadForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MapsButton_Click(object sender, EventArgs e)
        {
            Maps maps = new Maps();
            maps.Show();
            this.Visible = false;
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            Analisys_cs stat = new Analisys_cs();
            stat.Show();
            this.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
