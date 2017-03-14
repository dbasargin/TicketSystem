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
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();

        }

        //This is The Active ChildForm of The Parent Form that contains the Menu strip.
        public static Form ChildForm;

        private void FrmParent_Load(object sender, EventArgs e)
        {
            //set initial size of parent Form
            this.Size = new System.Drawing.Size(1900, 1400);

            //Create initialForm
            this.IsMdiContainer = true;
            Form f = new TicketSystem();
            ChangeChildForm(f);

        }
        /// <summary>
        /// This method is called to activate a child form after its been changed.
        /// </summary>
        public void ActivateNewChildForm()
        {
            ChildForm.MdiParent = this;
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        /// <summary>
        /// Accepts any form then sets it to be the Child Form after closing the current active form.
        /// Call this method ((FrmParent)this.MdiParent).ChangeChildForm(YOur new created form) to
        /// Change forms from other forms outside toolstrip;
        /// </summary>
        /// <param name="F">Form to be activated on parent form</param>
        public void ChangeChildForm(Form F)
        {
            if (ChildForm != null)
            {
                ChildForm.Close(); //Close last open Form
            }
            ChildForm = F;      //Assign new Form
            ActivateNewChildForm(); //Display new form.


        }

        /// <summary>
        /// This button creates new Form to create event then
        /// activates the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateEvent_Click(object sender, EventArgs e)
        {
            FrmCreateEvent newFrmCreateEvent = new FrmCreateEvent();
            ChangeChildForm(newFrmCreateEvent);

        }

        /// <summary>
        /// This button creates new Form to create Category then
        /// activates the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateCategory_Click(object sender, EventArgs e)
        {
            FrmCreateCategory newFrmCreateCategory = new FrmCreateCategory();
            ChangeChildForm(newFrmCreateCategory);
        }

        /// <summary>
        /// This button creates new Form to create Performer then
        /// activates the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreatePerformer_Click(object sender, EventArgs e)
        {
            FrmCreatePerformer newFrmCreateCategory = new FrmCreatePerformer();
            ChangeChildForm(newFrmCreateCategory);
        }

        /// <summary>
        /// This button creates new Form to create Venue then
        /// activates the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateVenue_Click(object sender, EventArgs e)
        {
            FrmCreateVenue newCreateVenueForm = new FrmCreateVenue();
            ChangeChildForm(newCreateVenueForm);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketSystem newHomePage = new TicketSystem();
            ChangeChildForm(newHomePage);
        }

        private void performersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditPerfomers editPerformers = new FrmEditPerfomers();
            editPerformers.Show();
           
        }
    }
}