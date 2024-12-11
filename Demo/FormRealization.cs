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
    public partial class FormRealization : Form
    {
        private Partner partner;
        private MasterFloreDubininContext db;
        public FormRealization(Partner _partner)
        {
            InitializeComponent();
            partner = _partner;
            db = new MasterFloreDubininContext();
            List<PartnerHistory> list = db.PartnerHistories.Where(p => p.NameCompany == partner.NameCompany).ToList();
            dataGridViewHistory.DataSource = list;
            dataGridViewHistory.Columns[4].Visible = false;
            dataGridViewHistory.Columns[5].Visible = false;
            for (int i = 0; i < list.Count-2; i++)
            {
                dataGridViewHistory.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
