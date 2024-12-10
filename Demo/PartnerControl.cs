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
        private Partner parnter;
        private MasterFloreDubininContext db;
        public PartnerControl(Partner _partner)
        {
            InitializeComponent();
            db = new MasterFloreDubininContext();
            parnter = _partner;
            labelName.Text = parnter.Type + " | " + parnter.NameCompany;
            labelDir.Text = parnter.Director;
            labelPhone.Text = parnter.Phone;
            labelRaiting.Text = "Рейтинг:" + parnter.Reiting;
            int? sum = db.PartnerHistories.Where(p=>p.NameCompany==parnter.NameCompany).Sum(p=>p.Count);
            int procent = 0;
            if (sum < 10000) procent = 0;
            else if (sum >= 10000 && sum < 50000) procent = 5;
            else if (sum >= 50000 && sum < 300000) procent = 10;
            else if (sum > 300000) procent = 15;
            labelProcent.Text = procent.ToString()+"%";
        }
    }
}
