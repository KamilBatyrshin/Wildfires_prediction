namespace POJAR_GUI2
{
    partial class MainForm
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
            button_area = new Button();
            openFileDialog_OpenPhoto = new OpenFileDialog();
            label_Title = new Label();
            button_Exit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_area
            // 
            button_area.BackColor = Color.LightSteelBlue;
            button_area.FlatAppearance.BorderSize = 0;
            button_area.FlatStyle = FlatStyle.Flat;
            button_area.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_area.ForeColor = SystemColors.ControlText;
            button_area.Location = new Point(74, 155);
            button_area.Name = "button_area";
            button_area.Size = new Size(277, 89);
            button_area.TabIndex = 0;
            button_area.Text = "Предсказать площадь";
            button_area.UseVisualStyleBackColor = false;
            button_area.Click += button_area_Click;
            // 
            // openFileDialog_OpenPhoto
            // 
            openFileDialog_OpenPhoto.DefaultExt = "jpg";
            openFileDialog_OpenPhoto.FileName = ".";
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.BackColor = Color.Transparent;
            label_Title.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.Location = new Point(12, 18);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(419, 114);
            label_Title.TabIndex = 3;
            label_Title.Text = "Предсказывание\r\n     пожаров";
            label_Title.Click += label_Title_Click;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.DarkGray;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Exit.Location = new Point(74, 375);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(278, 72);
            button_Exit.TabIndex = 4;
            button_Exit.Text = "Выход";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Close_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(75, 250);
            button1.Name = "button1";
            button1.Size = new Size(277, 89);
            button1.TabIndex = 5;
            button1.Text = "Предсказать дату";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_date_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 528);
            Controls.Add(button1);
            Controls.Add(button_Exit);
            Controls.Add(label_Title);
            Controls.Add(button_area);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Предсказывание пожаров";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_area;
        private OpenFileDialog openFileDialog_OpenPhoto;
        private Label label_Title;
        private Button button_Exit;
        private Button button1;
    }
}