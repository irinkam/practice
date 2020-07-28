namespace Maps
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.mapsButton = new Telerik.WinControls.UI.RadButton();
            this.statButton = new Telerik.WinControls.UI.RadButton();
            this.exitButton = new Telerik.WinControls.UI.RadButton();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.mapsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mapsButton
            // 
            this.mapsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapsButton.Location = new System.Drawing.Point(56, 60);
            this.mapsButton.Name = "mapsButton";
            this.mapsButton.Size = new System.Drawing.Size(214, 57);
            this.mapsButton.TabIndex = 0;
            this.mapsButton.Text = "Карты";
            this.mapsButton.ThemeName = "Office2010Black";
            this.mapsButton.Click += new System.EventHandler(this.MapsButton_Click);
            // 
            // statButton
            // 
            this.statButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statButton.Location = new System.Drawing.Point(56, 159);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(214, 57);
            this.statButton.TabIndex = 1;
            this.statButton.Text = "Статистика";
            this.statButton.ThemeName = "Office2010Black";
            this.statButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(56, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(214, 57);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выход";
            this.exitButton.ThemeName = "Office2010Black";
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 368);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.mapsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Меню";
            this.ThemeName = "Office2010Black";
            ((System.ComponentModel.ISupportInitialize)(this.mapsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton mapsButton;
        private Telerik.WinControls.UI.RadButton statButton;
        private Telerik.WinControls.UI.RadButton exitButton;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}
