using Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class PartnerControl : UserControl
    {
        private Partner partner;
        private MasterFloreDubininContext db;
        private Form1 form;
        public PartnerControl(Partner _partner, Form1 _form)
        {
            InitializeComponent();
            form = _form;
            using (db = new MasterFloreDubininContext())
            {
                partner = _partner;
                labelName.Text = partner.Type + " | " + partner.NameCompany;
                labelDir.Text = partner.Director;
                labelPhone.Text = partner.Phone;
                labelRaiting.Text = "Рейтинг:" + partner.Reiting;
                int? sum = db.PartnerHistories.Where(p => p.NameCompany == partner.NameCompany).Sum(p => p.Count);
                int procent = 0;
                if (sum < 10000) procent = 0;
                else if (sum >= 10000 && sum < 50000) procent = 5;
                else if (sum >= 50000 && sum < 300000) procent = 10;
                else if (sum > 300000) procent = 15;
                labelProcent.Text = procent.ToString() + "%";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить элемент {partner.NameCompany}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (db = new MasterFloreDubininContext())
                {
                    try
                    {
                        db.Remove(partner);
                        db.SaveChanges();
                        form.UpdateForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Невозможно удалить элемент {ex.Message}");
                    }
                }
            }
        }

        private void PartnerControl_DoubleClick(object sender, EventArgs e)
        {
            AddEditPartner window = new AddEditPartner(partner);
            if (window.ShowDialog() == DialogResult.OK)
            {
                partner.NameCompany = window.textBoxPartnerName.Text;
                partner.Type = window.comboBoxPartnerType.SelectedItem!.ToString()!;
                partner.Email = window.textBoxEmail.Text;
                partner.Director = window.textBoxFIODir.Text;
                partner.UrAddress = window.textBoxAddress.Text;
                partner.Inn = window.textBoxINN.Text;
                partner.Reiting = (int)window.numericUpDownReiting.Value;
                partner.Phone = window.textBoxPhone.Text;
                using (db = new MasterFloreDubininContext())
                {
                    db.Partners.Update(partner);
                    db.SaveChanges();
                    form.UpdateForm();
                }
            }
        }
    }
}
