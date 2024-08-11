namespace Practice
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            RoomSizeGB = new GroupBox();
            RoomHeightNUD = new NumericUpDown();
            RoomAreaNUD = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            WindowsGB = new GroupBox();
            WindowCountNUD = new NumericUpDown();
            label4 = new Label();
            WindowGridView = new DataGridView();
            groupBox1 = new GroupBox();
            WindowTypeCB = new ComboBox();
            groupBox2 = new GroupBox();
            OuterWallCountCB = new ComboBox();
            groupBox3 = new GroupBox();
            OuterWallTypeCB = new ComboBox();
            groupBox4 = new GroupBox();
            RoomAboveTypeCB = new ComboBox();
            groupBox5 = new GroupBox();
            label5 = new Label();
            MinStreetTempNUD = new NumericUpDown();
            CalculateButton = new Button();
            AnswerLabel = new Label();
            RoomSizeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomHeightNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomAreaNUD).BeginInit();
            WindowsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WindowCountNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WindowGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinStreetTempNUD).BeginInit();
            SuspendLayout();
            // 
            // RoomSizeGB
            // 
            RoomSizeGB.Controls.Add(RoomHeightNUD);
            RoomSizeGB.Controls.Add(RoomAreaNUD);
            RoomSizeGB.Controls.Add(label3);
            RoomSizeGB.Controls.Add(label1);
            RoomSizeGB.Location = new Point(12, 12);
            RoomSizeGB.Name = "RoomSizeGB";
            RoomSizeGB.Size = new Size(397, 67);
            RoomSizeGB.TabIndex = 0;
            RoomSizeGB.TabStop = false;
            RoomSizeGB.Text = "Размеры Помещения";
            // 
            // RoomHeightNUD
            // 
            RoomHeightNUD.DecimalPlaces = 2;
            RoomHeightNUD.Location = new Point(294, 21);
            RoomHeightNUD.Name = "RoomHeightNUD";
            RoomHeightNUD.Size = new Size(36, 23);
            RoomHeightNUD.TabIndex = 5;
            // 
            // RoomAreaNUD
            // 
            RoomAreaNUD.DecimalPlaces = 2;
            RoomAreaNUD.Location = new Point(97, 21);
            RoomAreaNUD.Name = "RoomAreaNUD";
            RoomAreaNUD.Size = new Size(36, 23);
            RoomAreaNUD.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 23);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Высота (м)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Площадь (м2)";
            // 
            // WindowsGB
            // 
            WindowsGB.Controls.Add(WindowCountNUD);
            WindowsGB.Controls.Add(label4);
            WindowsGB.Controls.Add(WindowGridView);
            WindowsGB.Location = new Point(12, 85);
            WindowsGB.Name = "WindowsGB";
            WindowsGB.Size = new Size(397, 286);
            WindowsGB.TabIndex = 1;
            WindowsGB.TabStop = false;
            WindowsGB.Text = "Окна Помещения";
            // 
            // WindowCountNUD
            // 
            WindowCountNUD.Location = new Point(114, 17);
            WindowCountNUD.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            WindowCountNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WindowCountNUD.Name = "WindowCountNUD";
            WindowCountNUD.Size = new Size(36, 23);
            WindowCountNUD.TabIndex = 6;
            WindowCountNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            WindowCountNUD.ValueChanged += WindowCountNUD_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 6;
            label4.Text = "Количество окон";
            // 
            // WindowGridView
            // 
            WindowGridView.AllowUserToAddRows = false;
            WindowGridView.AllowUserToDeleteRows = false;
            WindowGridView.AllowUserToResizeColumns = false;
            WindowGridView.AllowUserToResizeRows = false;
            WindowGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            WindowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            WindowGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            WindowGridView.DefaultCellStyle = dataGridViewCellStyle2;
            WindowGridView.Location = new Point(6, 51);
            WindowGridView.Name = "WindowGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            WindowGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            WindowGridView.Size = new Size(385, 229);
            WindowGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WindowTypeCB);
            groupBox1.Location = new Point(415, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 67);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип Окон";
            // 
            // WindowTypeCB
            // 
            WindowTypeCB.DisplayMember = "0";
            WindowTypeCB.FormattingEnabled = true;
            WindowTypeCB.Items.AddRange(new object[] { "Обычное окно", "Двойной стеклопакет", "Тройной стеклопакет" });
            WindowTypeCB.Location = new Point(6, 21);
            WindowTypeCB.Name = "WindowTypeCB";
            WindowTypeCB.Size = new Size(247, 23);
            WindowTypeCB.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OuterWallCountCB);
            groupBox2.Location = new Point(415, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 67);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Количество Внешних Стен";
            // 
            // OuterWallCountCB
            // 
            OuterWallCountCB.DisplayMember = "0";
            OuterWallCountCB.FormattingEnabled = true;
            OuterWallCountCB.Items.AddRange(new object[] { "Одна", "Две", "Три", "Четыре" });
            OuterWallCountCB.Location = new Point(6, 21);
            OuterWallCountCB.Name = "OuterWallCountCB";
            OuterWallCountCB.Size = new Size(247, 23);
            OuterWallCountCB.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(OuterWallTypeCB);
            groupBox3.Location = new Point(415, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 67);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Тип Внешней Стены";
            // 
            // OuterWallTypeCB
            // 
            OuterWallTypeCB.DisplayMember = "0";
            OuterWallTypeCB.FormattingEnabled = true;
            OuterWallTypeCB.Items.AddRange(new object[] { "Панельный дом", "Два кирпича", "Три кирпича или с дополнительным утеплением" });
            OuterWallTypeCB.Location = new Point(6, 21);
            OuterWallTypeCB.Name = "OuterWallTypeCB";
            OuterWallTypeCB.Size = new Size(247, 23);
            OuterWallTypeCB.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RoomAboveTypeCB);
            groupBox4.Location = new Point(415, 231);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(259, 67);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Тип Помещения Сверху";
            // 
            // RoomAboveTypeCB
            // 
            RoomAboveTypeCB.DisplayMember = "0";
            RoomAboveTypeCB.FormattingEnabled = true;
            RoomAboveTypeCB.Items.AddRange(new object[] { "Обогреваемое помещение", "Обогреваемый чердак", "Холодный чердак", "Помещение отсутствует" });
            RoomAboveTypeCB.Location = new Point(6, 21);
            RoomAboveTypeCB.Name = "RoomAboveTypeCB";
            RoomAboveTypeCB.Size = new Size(247, 23);
            RoomAboveTypeCB.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(MinStreetTempNUD);
            groupBox5.Location = new Point(415, 304);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(259, 67);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Минимальная Температура На Улице";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 24);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 7;
            label5.Text = "Градусов C°";
            // 
            // MinStreetTempNUD
            // 
            MinStreetTempNUD.Location = new Point(6, 22);
            MinStreetTempNUD.Maximum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            MinStreetTempNUD.Minimum = new decimal(new int[] { 45, 0, 0, int.MinValue });
            MinStreetTempNUD.Name = "MinStreetTempNUD";
            MinStreetTempNUD.Size = new Size(36, 23);
            MinStreetTempNUD.TabIndex = 6;
            MinStreetTempNUD.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(18, 386);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(89, 23);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.Location = new Point(126, 390);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(35, 15);
            AnswerLabel.TabIndex = 8;
            AnswerLabel.Text = "temp";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 434);
            Controls.Add(AnswerLabel);
            Controls.Add(CalculateButton);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(WindowsGB);
            Controls.Add(RoomSizeGB);
            Name = "FormMain";
            Text = "Расчет Тепловой Мощности Радиатора Отопления";
            RoomSizeGB.ResumeLayout(false);
            RoomSizeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomHeightNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomAreaNUD).EndInit();
            WindowsGB.ResumeLayout(false);
            WindowsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WindowCountNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)WindowGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinStreetTempNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox RoomSizeGB;
        private Label label3;
        private Label label1;
        private NumericUpDown RoomHeightNUD;
        private NumericUpDown RoomAreaNUD;
        private GroupBox WindowsGB;
        private DataGridView WindowGridView;
        private NumericUpDown WindowCountNUD;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox WindowTypeCB;
        private GroupBox groupBox2;
        private ComboBox OuterWallCountCB;
        private GroupBox groupBox3;
        private ComboBox OuterWallTypeCB;
        private GroupBox groupBox4;
        private ComboBox RoomAboveTypeCB;
        private GroupBox groupBox5;
        private NumericUpDown MinStreetTempNUD;
        private Label label5;
        private Button CalculateButton;
        private Label AnswerLabel;
    }
}
