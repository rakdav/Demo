namespace Demo
{
    partial class PartnerControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            labelProcent = new Label();
            labelRaiting = new Label();
            labelPhone = new Label();
            labelDir = new Label();
            labelName = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(745, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelProcent
            // 
            labelProcent.AutoSize = true;
            labelProcent.Location = new Point(702, 51);
            labelProcent.Name = "labelProcent";
            labelProcent.Size = new Size(52, 21);
            labelProcent.TabIndex = 4;
            labelProcent.Text = "label5";
            // 
            // labelRaiting
            // 
            labelRaiting.AutoSize = true;
            labelRaiting.Location = new Point(1, 75);
            labelRaiting.Name = "labelRaiting";
            labelRaiting.Size = new Size(52, 21);
            labelRaiting.TabIndex = 3;
            labelRaiting.Text = "label4";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(3, 51);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(52, 21);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "label3";
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Location = new Point(3, 28);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(52, 21);
            labelDir.TabIndex = 1;
            labelDir.Text = "label2";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 5);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 21);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.realiz;
            pictureBox2.Location = new Point(577, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PartnerControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(labelProcent);
            Controls.Add(pictureBox1);
            Controls.Add(labelName);
            Controls.Add(labelRaiting);
            Controls.Add(labelDir);
            Controls.Add(labelPhone);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "PartnerControl";
            Size = new Size(782, 110);
            DoubleClick += PartnerControl_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelProcent;
        private Label labelRaiting;
        private Label labelPhone;
        private Label labelDir;
        private Label labelName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
