namespace POJAR_GUI2
{
    partial class ResultsForm_date
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
            button_Recognize = new Button();
            label_Title = new Label();
            label1 = new Label();
            button_back = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            par5_box = new ComboBox();
            par7_box = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            par6_box = new ComboBox();
            par8_box = new ComboBox();
            result_box = new TextBox();
            label7 = new Label();
            label10 = new Label();
            par2_box = new NumericUpDown();
            par1_box = new NumericUpDown();
            par4_box = new NumericUpDown();
            par3_box = new NumericUpDown();
            lbl_wait = new Label();
            ((System.ComponentModel.ISupportInitialize)par2_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)par1_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)par4_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)par3_box).BeginInit();
            SuspendLayout();
            // 
            // button_Recognize
            // 
            button_Recognize.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Recognize.Location = new Point(12, 472);
            button_Recognize.Name = "button_Recognize";
            button_Recognize.Size = new Size(200, 72);
            button_Recognize.TabIndex = 6;
            button_Recognize.Text = "Предсказать";
            button_Recognize.UseVisualStyleBackColor = true;
            button_Recognize.Click += button_Predict_Click;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.Location = new Point(19, 9);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(635, 34);
            label_Title.TabIndex = 8;
            label_Title.Text = "Предсказание продолжительности пожаров";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 9;
            label1.Text = "Широта:";
            // 
            // button_back
            // 
            button_back.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.Location = new Point(495, 475);
            button_back.Name = "button_back";
            button_back.Size = new Size(138, 71);
            button_back.TabIndex = 10;
            button_back.Text = "Назад";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(292, 57);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 11;
            label2.Text = "Долгота:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 12;
            label3.Text = "Месяц начала:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 13;
            label4.Text = "Регион:";
            // 
            // par5_box
            // 
            par5_box.DropDownStyle = ComboBoxStyle.DropDownList;
            par5_box.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            par5_box.FormattingEnabled = true;
            par5_box.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            par5_box.Location = new Point(180, 197);
            par5_box.Name = "par5_box";
            par5_box.Size = new Size(150, 30);
            par5_box.TabIndex = 19;
            // 
            // par7_box
            // 
            par7_box.DropDownStyle = ComboBoxStyle.DropDownList;
            par7_box.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            par7_box.FormattingEnabled = true;
            par7_box.Items.AddRange(new object[] { "Агинский Бурятский автономный округ", "Алтайский край", "Амурская область", "Архангельская область", "Астраханская область", "Белгородская область", "Брянская область", "Владимирская область", "Волгоградская область", "Вологодская область", "Воронежская область", "Донецкая Народная Республика", "Еврейская автономная область", "Забайкальский край", "Запорожская область", "Ивановская область", "Иркутская область", "Кабардино-Балкарская Республика", "Калининградская область", "Калужская область", "Камчатский край", "Карачаево-Черкесская Республика", "Кемеровская область", "Кировская область", "Костромская область", "Краснодарский край", "Красноярский край", "Курганская область", "Курская область", "Ленинградская область", "Липецкая область", "Луганская Народная Республика", "Магаданская область", "Москва", "Московская область", "Мурманская область", "Ненецкий автономный округ", "Нижегородская область", "Новгородская область", "Новосибирская область", "Омская область", "Оренбургская область", "Орловская область", "Пензенская область", "Пермский край", "Приморский край", "Псковская область", "Республика Адыгея", "Республика Алтай", "Республика Башкортостан", "Республика Бурятия", "Республика Дагестан", "Республика Ингушетия", "Республика Калмыкия", "Республика Карелия", "Республика Коми", "Республика Крым", "Республика Марий Эл", "Республика Мордовия", "Республика Саха (Якутия)", "Республика Северная Осетия — Алания", "Республика Татарстан", "Республика Тыва", "Республика Хакасия", "Ростовская область", "Рязанская область", "Самарская область", "Санкт-Петербург", "Саратовская область", "Сахалинская область", "Свердловская область", "Севастополь", "Смоленская область", "Ставропольский край", "Тамбовская область", "Тверская область", "Томская область", "Тульская область", "Тюменская область", "Удмуртская Республика", "Ульяновская область", "Усть-Ордынский Бурятский автономный округ", "Хабаровский край", "Ханты-Мансийский автономный округ — Югра", "Херсонская область", "Челябинская область", "Чеченская Республика", "Читинская область", "Чувашская Республика", "Чукотский автономный округ", "Ямало-Ненецкий автономный округ", "Ярославская область" });
            par7_box.Location = new Point(104, 235);
            par7_box.Name = "par7_box";
            par7_box.Size = new Size(226, 30);
            par7_box.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 319);
            label5.Name = "label5";
            label5.Size = new Size(146, 28);
            label5.TabIndex = 21;
            label5.Text = "Тип пожара:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 275);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 22;
            label6.Text = "Год пожара:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 157);
            label8.Name = "label8";
            label8.Size = new Size(432, 28);
            label8.TabIndex = 24;
            label8.Text = "Территория пожара при обнаружении:";
            // 
            // par6_box
            // 
            par6_box.DropDownStyle = ComboBoxStyle.DropDownList;
            par6_box.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            par6_box.FormattingEnabled = true;
            par6_box.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            par6_box.Location = new Point(151, 277);
            par6_box.Name = "par6_box";
            par6_box.Size = new Size(179, 30);
            par6_box.TabIndex = 27;
            // 
            // par8_box
            // 
            par8_box.DropDownStyle = ComboBoxStyle.DropDownList;
            par8_box.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            par8_box.FormattingEnabled = true;
            par8_box.Items.AddRange(new object[] { "Лесной", "Не лесной" });
            par8_box.Location = new Point(154, 319);
            par8_box.Name = "par8_box";
            par8_box.Size = new Size(176, 30);
            par8_box.TabIndex = 28;
            // 
            // result_box
            // 
            result_box.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            result_box.Location = new Point(256, 426);
            result_box.Name = "result_box";
            result_box.ReadOnly = true;
            result_box.Size = new Size(263, 30);
            result_box.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 92);
            label7.Name = "label7";
            label7.Size = new Size(312, 56);
            label7.TabIndex = 30;
            label7.Text = "Расстояние до ближайшего\r\nнаселенного пункта:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 426);
            label10.Name = "label10";
            label10.Size = new Size(240, 28);
            label10.TabIndex = 32;
            label10.Text = "Продолжительность:";
            // 
            // par2_box
            // 
            par2_box.Location = new Point(399, 62);
            par2_box.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            par2_box.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            par2_box.Name = "par2_box";
            par2_box.Size = new Size(120, 23);
            par2_box.TabIndex = 34;
            par2_box.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // par1_box
            // 
            par1_box.Location = new Point(116, 62);
            par1_box.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            par1_box.Name = "par1_box";
            par1_box.Size = new Size(120, 23);
            par1_box.TabIndex = 35;
            par1_box.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // par4_box
            // 
            par4_box.Location = new Point(440, 162);
            par4_box.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            par4_box.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            par4_box.Name = "par4_box";
            par4_box.Size = new Size(120, 23);
            par4_box.TabIndex = 36;
            par4_box.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // par3_box
            // 
            par3_box.Location = new Point(245, 125);
            par3_box.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            par3_box.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            par3_box.Name = "par3_box";
            par3_box.Size = new Size(120, 23);
            par3_box.TabIndex = 37;
            par3_box.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_wait
            // 
            lbl_wait.AutoSize = true;
            lbl_wait.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_wait.Location = new Point(256, 407);
            lbl_wait.Name = "lbl_wait";
            lbl_wait.Size = new Size(170, 16);
            lbl_wait.TabIndex = 38;
            lbl_wait.Text = "Ожидание результатов...";
            lbl_wait.Visible = false;
            // 
            // ResultsForm_date
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(666, 577);
            Controls.Add(lbl_wait);
            Controls.Add(par3_box);
            Controls.Add(par4_box);
            Controls.Add(par1_box);
            Controls.Add(par2_box);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(result_box);
            Controls.Add(par8_box);
            Controls.Add(par6_box);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(par7_box);
            Controls.Add(par5_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_back);
            Controls.Add(label1);
            Controls.Add(label_Title);
            Controls.Add(button_Recognize);
            Name = "ResultsForm_date";
            Text = "Предзаказание пожаров";
            ((System.ComponentModel.ISupportInitialize)par2_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)par1_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)par4_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)par3_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Recognize;
        private Label label_Title;
        private Label label1;
        private Button button_back;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox par5_box;
        private ComboBox par7_box;
        private Label label5;
        private Label label6;
        private Label label8;
        private ComboBox par6_box;
        private ComboBox par8_box;
        private TextBox result_box;
        private Label label7;
        private Label label10;
        private NumericUpDown par2_box;
        private NumericUpDown par1_box;
        private NumericUpDown par4_box;
        private NumericUpDown par3_box;
        private Label lbl_wait;
    }
}