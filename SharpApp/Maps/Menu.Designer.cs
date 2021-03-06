﻿namespace Maps
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
            this.graphButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.mapsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mapsButton
            // 
            this.mapsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapsButton.Location = new System.Drawing.Point(56, 48);
            this.mapsButton.Name = "mapsButton";
            this.mapsButton.Size = new System.Drawing.Size(214, 57);
            this.mapsButton.TabIndex = 0;
            this.mapsButton.Text = "Карты";
            this.mapsButton.ThemeName = "Office2010Black";
            this.mapsButton.Click += new System.EventHandler(this.MapsButton_Click);
            // 
            // statButton
            // 
            this.statButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statButton.Location = new System.Drawing.Point(56, 147);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(214, 57);
            this.statButton.TabIndex = 1;
            this.statButton.Text = "Статистика";
            this.statButton.ThemeName = "Office2010Black";
            this.statButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(56, 340);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(214, 57);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выход";
            this.exitButton.ThemeName = "Office2010Black";
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphButton.Location = new System.Drawing.Point(56, 246);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(214, 57);
            this.graphButton.TabIndex = 2;
            this.graphButton.Text = "Графики";
            this.graphButton.ThemeName = "Office2010Black";
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 449);
            this.Controls.Add(this.graphButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.graphButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton mapsButton;
        private Telerik.WinControls.UI.RadButton statButton;
        private Telerik.WinControls.UI.RadButton exitButton;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadButton graphButton;
    }
}
