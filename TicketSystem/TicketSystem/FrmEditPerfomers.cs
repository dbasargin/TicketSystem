using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem
{
    public partial class FrmEditPerfomers : Form
    {
        public FrmEditPerfomers()
        {
            InitializeComponent();
        }
        BindingSource bindingPerformers;
        private void FrmEditPerfomers_Load(object sender, EventArgs e)
        {
            List<Performer> performers = GetAllPerformers();
            bindingPerformers = new BindingSource();
            bindingPerformers.DataSource = performers;
            cboListOfPerformers.DataSource = bindingPerformers;
            cboListOfPerformers.DisplayMember = nameof(Performer.PerformerName);
        }

        private List<Performer> GetAllPerformers()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Performer> perfs = (from p in db.Performers
                                     select p).ToList();
            
            return perfs;

        }

        private void cboListOfPerformers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Performer p = cboListOfPerformers.SelectedItem as Performer;
            txtNameOfPerformerToEdit.Text = p.PerformerName;
            txtURLOfPerfomerToEdit.Text = p.PerformerURL;
            txtInfoOfPerformerToEdit.Text = p.PerformerInfo;
            txtPerformerID.Text = Convert.ToString(p.PerformerID);       
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (cboListOfPerformers.SelectedIndex >= 0)
            {
                int selected = cboListOfPerformers.SelectedIndex;
                Performer p = new Performer()
                {
                    PerformerID = Convert.ToInt32(txtPerformerID.Text),
                    PerformerName = txtNameOfPerformerToEdit.Text,
                    PerformerURL = txtURLOfPerfomerToEdit.Text,
                    PerformerInfo = txtInfoOfPerformerToEdit.Text
                };
                bindingPerformers[selected] = p;
                TicketSystemDBEntities db = new TicketSystemDBEntities();
            db.SaveChanges(); //TODO need to do a query in order to save changes in the database
                MessageBox.Show("Your changes have been made");
                
            }
            
        }
    }
}
