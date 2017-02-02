﻿using System;
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
            this.Size = new System.Drawing.Size(1000, 700);
            populateListBoxWithAllEvents();
        }

        public void populateListBoxWithAllEvents()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Event> listEvents = db.Events.ToList();
            lstBoxEvents.DataSource = listEvents;
            lstBoxEvents.DisplayMember = nameof(Event.EventNameAndDates);
            lstBoxEvents.ValueMember = nameof(Event.EventID);

           
        }
    }
}
