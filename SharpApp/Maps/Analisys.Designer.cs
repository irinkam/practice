namespace Maps
{
    partial class Analisys_cs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisys_cs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceFromTomsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abiturientCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.statButton = new Telerik.WinControls.UI.RadButton();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.MenuButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schoolColumn,
            this.cityColumn,
            this.distanceFromTomsk,
            this.abiturientCount,
            this.markColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1308, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolColumn
            // 
            this.schoolColumn.HeaderText = "Школа";
            this.schoolColumn.Name = "schoolColumn";
            // 
            // cityColumn
            // 
            this.cityColumn.HeaderText = "Город";
            this.cityColumn.Name = "cityColumn";
            // 
            // distanceFromTomsk
            // 
            this.distanceFromTomsk.HeaderText = "Расстояние от Томска";
            this.distanceFromTomsk.Name = "distanceFromTomsk";
            // 
            // abiturientCount
            // 
            this.abiturientCount.HeaderText = "Число поступающих";
            this.abiturientCount.Name = "abiturientCount";
            // 
            // markColumn
            // 
            this.markColumn.HeaderText = "Средний балл";
            this.markColumn.Name = "markColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предмет";
            // 
            // statButton
            // 
            this.statButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statButton.Location = new System.Drawing.Point(12, 110);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(208, 44);
            this.statButton.TabIndex = 2;
            this.statButton.Text = "Показать статистику";
            this.statButton.ThemeName = "Office2010Black";
            this.statButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.disciplineComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(12, 51);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(208, 33);
            this.disciplineComboBox.TabIndex = 3;
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.Location = new System.Drawing.Point(244, 110);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(208, 44);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "Выход в меню";
            this.MenuButton.ThemeName = "Office2010Black";
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Analisys_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 672);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Analisys_cs";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Статистика";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.Analisys_cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton statButton;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private Telerik.WinControls.UI.RadButton MenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceFromTomsk;
        private System.Windows.Forms.DataGridViewTextBoxColumn abiturientCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn markColumn;
    }
}
