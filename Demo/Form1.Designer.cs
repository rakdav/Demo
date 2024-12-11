namespace Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelPartners = new Panel();
            pictureBoxLogo = new PictureBox();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelPartners
            // 
            panelPartners.AutoScroll = true;
            panelPartners.Location = new Point(8, 7);
            panelPartners.Name = "panelPartners";
            panelPartners.Size = new Size(774, 350);
            panelPartners.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Мастер_пол;
            pictureBoxLogo.Location = new Point(801, 7);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(801, 127);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 38);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 367);
            Controls.Add(buttonAdd);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panelPartners);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Партнеры";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPartners;
        private PictureBox pictureBoxLogo;
        private Button buttonAdd;
    }
}
