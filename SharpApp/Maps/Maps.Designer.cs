namespace Maps
{
    partial class Maps
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maps));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.egeComboBox = new System.Windows.Forms.ComboBox();
            this.egeLabel = new System.Windows.Forms.Label();
            this.showButton = new Telerik.WinControls.UI.RadButton();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.exitButton = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.showButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(12, 12);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(815, 623);
            this.browser.TabIndex = 0;
            // 
            // egeComboBox
            // 
            this.egeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egeComboBox.FormattingEnabled = true;
            this.egeComboBox.Location = new System.Drawing.Point(875, 68);
            this.egeComboBox.Name = "egeComboBox";
            this.egeComboBox.Size = new System.Drawing.Size(258, 32);
            this.egeComboBox.TabIndex = 2;
            // 
            // egeLabel
            // 
            this.egeLabel.AutoSize = true;
            this.egeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egeLabel.Location = new System.Drawing.Point(871, 34);
            this.egeLabel.Name = "egeLabel";
            this.egeLabel.Size = new System.Drawing.Size(171, 20);
            this.egeLabel.TabIndex = 3;
            this.egeLabel.Text = "Выбор числа баллов:";
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(875, 223);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(258, 47);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Показать";
            this.showButton.ThemeName = "Office2010Black";
            this.showButton.Click += new System.EventHandler(this.showButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(875, 589);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(258, 46);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выход в меню";
            this.exitButton.ThemeName = "Office2010Black";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(871, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбор предмета:";
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(875, 155);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(258, 32);
            this.disciplineComboBox.TabIndex = 9;
            this.disciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.disciplineComboBox_SelectedIndexChanged);
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1166, 647);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.egeLabel);
            this.Controls.Add(this.egeComboBox);
            this.Controls.Add(this.browser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Maps";
            this.Text = "Карты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ComboBox egeComboBox;
        private System.Windows.Forms.Label egeLabel;
        private Telerik.WinControls.UI.RadButton showButton;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadButton exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox disciplineComboBox;
    }
}

