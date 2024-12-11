namespace Demo
{
    partial class AddEditPartner
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
            textBoxPartnerName = new TextBox();
            comboBoxPartnerType = new ComboBox();
            label1 = new Label();
            numericUpDownReiting = new NumericUpDown();
            label2 = new Label();
            textBoxAddress = new TextBox();
            textBoxFIODir = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxINN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReiting).BeginInit();
            SuspendLayout();
            // 
            // textBoxPartnerName
            // 
            textBoxPartnerName.Location = new Point(12, 12);
            textBoxPartnerName.Name = "textBoxPartnerName";
            textBoxPartnerName.PlaceholderText = "Наименование";
            textBoxPartnerName.Size = new Size(310, 23);
            textBoxPartnerName.TabIndex = 0;
            // 
            // comboBoxPartnerType
            // 
            comboBoxPartnerType.FormattingEnabled = true;
            comboBoxPartnerType.Items.AddRange(new object[] { "ЗАО", "ООО", "ОАО", "ПАО" });
            comboBoxPartnerType.Location = new Point(12, 62);
            comboBoxPartnerType.Name = "comboBoxPartnerType";
            comboBoxPartnerType.Size = new Size(138, 23);
            comboBoxPartnerType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Тип партнера";
            // 
            // numericUpDownReiting
            // 
            numericUpDownReiting.Location = new Point(170, 62);
            numericUpDownReiting.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownReiting.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownReiting.Name = "numericUpDownReiting";
            numericUpDownReiting.Size = new Size(152, 23);
            numericUpDownReiting.TabIndex = 3;
            numericUpDownReiting.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Рейтинг";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 100);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Адрес";
            textBoxAddress.Size = new Size(307, 23);
            textBoxAddress.TabIndex = 5;
            // 
            // textBoxFIODir
            // 
            textBoxFIODir.Location = new Point(12, 141);
            textBoxFIODir.Name = "textBoxFIODir";
            textBoxFIODir.PlaceholderText = "ФИО директора";
            textBoxFIODir.Size = new Size(307, 23);
            textBoxFIODir.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 187);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.PlaceholderText = "Телефон";
            textBoxPhone.Size = new Size(307, 23);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 233);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "email";
            textBoxEmail.Size = new Size(307, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(12, 314);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(138, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(170, 314);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(149, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxINN
            // 
            textBoxINN.Location = new Point(12, 274);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.PlaceholderText = "ИНН";
            textBoxINN.Size = new Size(307, 23);
            textBoxINN.TabIndex = 11;
            // 
            // AddEditPartner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 354);
            Controls.Add(textBoxINN);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxFIODir);
            Controls.Add(textBoxAddress);
            Controls.Add(label2);
            Controls.Add(numericUpDownReiting);
            Controls.Add(label1);
            Controls.Add(comboBoxPartnerType);
            Controls.Add(textBoxPartnerName);
            Name = "AddEditPartner";
            Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)numericUpDownReiting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public TextBox textBoxPartnerName;
        public ComboBox comboBoxPartnerType;
        public NumericUpDown numericUpDownReiting;
        public TextBox textBoxAddress;
        public TextBox textBoxFIODir;
        public TextBox textBoxPhone;
        public TextBox textBoxEmail;
        private Button buttonSave;
        private Button buttonCancel;
        public TextBox textBoxINN;
    }
}