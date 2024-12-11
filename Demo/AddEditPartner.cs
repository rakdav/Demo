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
    public partial class AddEditPartner : Form
    {
        private Partner partner;
        public AddEditPartner()
        {
            InitializeComponent();
        }
        public AddEditPartner(Partner _partner)
        {
            InitializeComponent();
            partner = _partner;
            textBoxPartnerName.Text = partner.NameCompany;
            textBoxEmail.Text = partner.Email;
            textBoxINN.Text = partner.Inn;
            textBoxFIODir.Text = partner.Director;
            textBoxPhone.Text = partner.Phone;
            numericUpDownReiting.Value = partner.Reiting;
            comboBoxPartnerType.Text = partner.Type;
            textBoxAddress.Text = partner.UrAddress;
        }
    }
}
