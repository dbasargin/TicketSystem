using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TicketSystem
{
    public partial class TicketSystem : Form
    {
        
        public TicketSystem()
        {
            InitializeComponent();
        }

        private void TicketSystem_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(1000, 700);
            this.Dock = DockStyle.Fill;
            
            //ToDo: CHANge this to upcoming events
            populateListBoxWithAllEvents(); //initial populate Events listbox with all events
            PopulateGenres();               // initial Populate genres listbox
        }

        /// <summary>
        /// /populates events listbox with all events
        /// </summary>
        public void populateListBoxWithAllEvents()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Event> listEvents = db.Events.ToList();
            lstBoxEvents.DataSource = listEvents;
            lstBoxEvents.DisplayMember = nameof(Event.EventNameAndDates);
            lstBoxEvents.ValueMember = nameof(Event.EventID);


        }

        /// <summary>
        /// Populates Genre list box with all genres.
        /// </summary>
        public void PopulateGenres()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Genre> listGenres = db.Genres.ToList();
            lstSelectGenres.DataSource = listGenres;
            lstSelectGenres.DisplayMember = nameof(Genre.GenreName);
            lstSelectGenres.ValueMember = nameof(Genre.GenreID);
        }

        /// <summary>
        /// calls method to populate list by event name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            PopulateByEventName();
        }

        /// <summary>
        /// Populates event list box where data/text inside txtSearchEventName  
        /// substring matches the EventName.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateByEventName()
        {
            if (!String.IsNullOrWhiteSpace(txtSearchEventName.Text))
            {
                string eventSearch = txtSearchEventName.Text.Trim();
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.EventName.Contains(eventSearch)).ToList();

                lstBoxEvents.DataSource = listOfEvents;
            }
            else
            {
                MessageBox.Show("Enter a Event Name");
            }
        }

        private void btnSearchPerformer_Click(object sender, EventArgs e)
        {
            PopulateByPerformer();
        }

        /// <summary>
        /// Populates event list box where data/text inside performer textbox as 
        /// substring matches the string name of Event.PerformerName. 
        /// </summary>
        private void PopulateByPerformer()
        {
            if (!String.IsNullOrWhiteSpace(txtSearchPerformer.Text)) {
                string performerSearch = txtSearchPerformer.Text.Trim();
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.Performer.PerformerName.Contains(performerSearch)).ToList();

                lstBoxEvents.DataSource = listOfEvents;
            }
            else
            {
                MessageBox.Show("Enter a performer");
            }
        }

        private void btnSearchVenue_Click(object sender, EventArgs e)
        {
            PopulateByVenue();
        }

        /// <summary>
        /// Populates event list box where data/text inside Venue textbox as
        /// substring matches the string name of the Event.VenueName. 
        /// </summary>
        private void PopulateByVenue()
        {
            if (!String.IsNullOrWhiteSpace(txtSearchVenue.Text))
            {
                string venueSearch = txtSearchVenue.Text.Trim();
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.Venue.VenueName.Contains(venueSearch)).ToList();

                lstBoxEvents.DataSource = listOfEvents;
            }
            else
            {
                MessageBox.Show("Enter a venue name");
            }
        }

        /// <summary>
        /// calls  method to populate list of events with genre that corresponds with
        /// the selected genre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            PopulateByGenre();
        }

        /// <summary>
        /// if there is selected genre, this method populates the list of events with 
        /// events that have a corresponding genreID.
        /// </summary>
        private void PopulateByGenre()
        {
            if(lstSelectGenres.SelectedIndex >= 0)
            {

                Genre g = (Genre)lstSelectGenres.SelectedItem;
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.Genre.GenreID == g.GenreID).ToList();
                lstBoxEvents.DataSource = listOfEvents;

            }
            else
            {
                MessageBox.Show("Please select a genre");
            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            PopulateByDate();
        }

        private void PopulateByDate()
        {
            DateTime d = dtSearchDate.Value.Date;//make sure we ignore time for comparisons.

            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Event> listOfEvents = db.Events.Where(e => d >= e.EventStartDate && d <= e.EventEndDate).ToList();
            lstBoxEvents.DataSource = listOfEvents;
        }

        /// <summary>
        /// Open Event details if an event is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            if (lstBoxEvents.SelectedIndex >= 0)
            {
                //pass Selected event to Frm Event details
                Form FrmEventDetails = new FrmEventDetails((Event)lstBoxEvents.SelectedItem);
                ((FrmParent)this.MdiParent).ChangeChildForm(FrmEventDetails);//Access Parent Form and change active form
            }
            else
            {
                MessageBox.Show("Please select an event.");
            }
        }

      
    }
}
