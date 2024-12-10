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
            groupBox1 = new GroupBox();
            labelProcent = new Label();
            labelRaiting = new Label();
            labelPhone = new Label();
            labelDir = new Label();
            labelName = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelProcent);
            groupBox1.Controls.Add(labelRaiting);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelDir);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // labelProcent
            // 
            labelProcent.AutoSize = true;
            labelProcent.Location = new Point(712, 25);
            labelProcent.Name = "labelProcent";
            labelProcent.Size = new Size(52, 21);
            labelProcent.TabIndex = 4;
            labelProcent.Text = "label5";
            // 
            // labelRaiting
            // 
            labelRaiting.AutoSize = true;
            labelRaiting.Location = new Point(6, 67);
            labelRaiting.Name = "labelRaiting";
            labelRaiting.Size = new Size(52, 21);
            labelRaiting.TabIndex = 3;
            labelRaiting.Text = "label4";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(6, 46);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(52, 21);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "label3";
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Location = new Point(6, 25);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(52, 21);
            labelDir.TabIndex = 1;
            labelDir.Text = "label2";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 21);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // PartnerControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "PartnerControl";
            Size = new Size(782, 110);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelProcent;
        private Label labelRaiting;
        private Label labelPhone;
        private Label labelDir;
        private Label labelName;
    }
}
