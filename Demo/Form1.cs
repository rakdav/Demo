using Demo.Model;

namespace Demo
{
    public partial class Form1 : Form
    {
        private List<Partner> list;
        private MasterFloreDubininContext db;
        public Form1()
        {
            InitializeComponent();
            db = new MasterFloreDubininContext();
            list = db.Partners.ToList();
            int Y = 0;
            for (int i = 0; i < list.Count; i++)
            {
                PartnerControl pc = new PartnerControl(list[i]);
                pc.Top = Y;
                panelPartners.Controls.Add(pc);
                Y += pc.Height;
            }
        }
    }
}
