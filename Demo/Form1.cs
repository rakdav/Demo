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
            UpdateForm();
        }
        public void UpdateForm()
        {
            panelPartners.Controls.Clear();

            list = db.Partners.ToList();
            int Y = 0;
            for (int i = 0; i < list.Count; i++)
            {
               PartnerControl pc = new PartnerControl(list[i],this);
               pc.Top = Y;
               panelPartners.Controls.Add(pc);
               Y += pc.Height;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditPartner window = new AddEditPartner();
            if (window.ShowDialog() == DialogResult.OK)
            {
                Partner partner = new Partner();
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
                    db.Partners.Add(partner);
                    db.SaveChanges();
                    UpdateForm();
                }
            }
        }
    }
}
