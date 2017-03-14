namespace TicketSystem
{
    partial class TicketSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxEvents = new System.Windows.Forms.ListBox();
            this.lstSelectGenres = new System.Windows.Forms.ListBox();
            this.txtSearchPerformer = new System.Windows.Forms.TextBox();
            this.txtSearchVenue = new System.Windows.Forms.TextBox();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.btnSearchPerformer = new System.Windows.Forms.Button();
            this.btnSearchVenue = new System.Windows.Forms.Button();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEventDetails = new System.Windows.Forms.Button();
            this.txtSearchEventName = new System.Windows.Forms.TextBox();
            this.btnSearchEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxEvents
            // 
            this.lstBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxEvents.FormattingEnabled = true;
            this.lstBoxEvents.ItemHeight = 16;
            this.lstBoxEvents.Location = new System.Drawing.Point(22, 84);
            this.lstBoxEvents.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxEvents.Name = "lstBoxEvents";
            this.lstBoxEvents.Size = new System.Drawing.Size(486, 452);
            this.lstBoxEvents.TabIndex = 0;
            // 
            // lstSelectGenres
            // 
            this.lstSelectGenres.AllowDrop = true;
            this.lstSelectGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectGenres.FormattingEnabled = true;
            this.lstSelectGenres.ItemHeight = 16;
            this.lstSelectGenres.Location = new System.Drawing.Point(546, 74);
            this.lstSelectGenres.Margin = new System.Windows.Forms.Padding(2);
            this.lstSelectGenres.Name = "lstSelectGenres";
            this.lstSelectGenres.Size = new System.Drawing.Size(194, 100);
            this.lstSelectGenres.TabIndex = 1;
            // 
            // txtSearchPerformer
            // 
            this.txtSearchPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPerformer.Location = new System.Drawing.Point(546, 291);
            this.txtSearchPerformer.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPerformer.Name = "txtSearchPerformer";
            this.txtSearchPerformer.Size = new System.Drawing.Size(194, 23);
            this.txtSearchPerformer.TabIndex = 2;
            this.txtSearchPerformer.Text = "Search by performer";
            // 
            // txtSearchVenue
            // 
            this.txtSearchVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVenue.Location = new System.Drawing.Point(546, 344);
            this.txtSearchVenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchVenue.Name = "txtSearchVenue";
            this.txtSearchVenue.Size = new System.Drawing.Size(194, 23);
            this.txtSearchVenue.TabIndex = 3;
            this.txtSearchVenue.Text = "Search by venue";
            // 
            // dtSearchDate
            // 
            this.dtSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearchDate.Location = new System.Drawing.Point(544, 392);
            this.dtSearchDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtSearchDate.Name = "dtSearchDate";
            this.dtSearchDate.Size = new System.Drawing.Size(196, 20);
            this.dtSearchDate.TabIndex = 4;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchCategory.Location = new System.Drawing.Point(772, 74);
            this.btnSearchCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(86, 23);
            this.btnSearchCategory.TabIndex = 5;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnSearchPerformer
            // 
            this.btnSearchPerformer.Location = new System.Drawing.Point(772, 288);
            this.btnSearchPerformer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPerformer.Name = "btnSearchPerformer";
            this.btnSearchPerformer.Size = new System.Drawing.Size(86, 23);
            this.btnSearchPerformer.TabIndex = 6;
            this.btnSearchPerformer.Text = "Search";
            this.btnSearchPerformer.UseVisualStyleBackColor = true;
            this.btnSearchPerformer.Click += new System.EventHandler(this.btnSearchPerformer_Click);
            // 
            // btnSearchVenue
            // 
            this.btnSearchVenue.Location = new System.Drawing.Point(772, 344);
            this.btnSearchVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchVenue.Name = "btnSearchVenue";
            this.btnSearchVenue.Size = new System.Drawing.Size(86, 23);
            this.btnSearchVenue.TabIndex = 7;
            this.btnSearchVenue.Text = "Search";
            this.btnSearchVenue.UseVisualStyleBackColor = true;
            this.btnSearchVenue.Click += new System.EventHandler(this.btnSearchVenue_Click);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(772, 392);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(86, 23);
            this.btnSearchDate.TabIndex = 8;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 25.125F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(146, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event Search";
            // 
            // btnEventDetails
            // 
            this.btnEventDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEventDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventDetails.Location = new System.Drawing.Point(546, 441);
            this.btnEventDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventDetails.Name = "btnEventDetails";
            this.btnEventDetails.Size = new System.Drawing.Size(312, 41);
            this.btnEventDetails.TabIndex = 10;
            this.btnEventDetails.Text = "Event Details";
            this.btnEventDetails.UseVisualStyleBackColor = true;
            this.btnEventDetails.Click += new System.EventHandler(this.btnEventDetails_Click);
            // 
            // txtSearchEventName
            // 
            this.txtSearchEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEventName.Location = new System.Drawing.Point(544, 228);
            this.txtSearchEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchEventName.Name = "txtSearchEventName";
            this.txtSearchEventName.Size = new System.Drawing.Size(194, 23);
            this.txtSearchEventName.TabIndex = 11;
            this.txtSearchEventName.Text = "Search by Event Name";
            // 
            // btnSearchEvent
            // 
            this.btnSearchEvent.Location = new System.Drawing.Point(772, 224);
            this.btnSearchEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchEvent.Name = "btnSearchEvent";
            this.btnSearchEvent.Size = new System.Drawing.Size(86, 21);
            this.btnSearchEvent.TabIndex = 12;
            this.btnSearchEvent.Text = "Search";
            this.btnSearchEvent.UseVisualStyleBackColor = true;
            this.btnSearchEvent.Click += new System.EventHandler(this.btnSearchEvent_Click);
            // 
            // TicketSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 552);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearchEvent);
            this.Controls.Add(this.txtSearchEventName);
            this.Controls.Add(this.btnEventDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearchVenue);
            this.Controls.Add(this.btnSearchPerformer);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.dtSearchDate);
            this.Controls.Add(this.txtSearchVenue);
            this.Controls.Add(this.txtSearchPerformer);
            this.Controls.Add(this.lstSelectGenres);
            this.Controls.Add(this.lstBoxEvents);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TicketSystem";
            this.Load += new System.EventHandler(this.TicketSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxEvents;
        private System.Windows.Forms.ListBox lstSelectGenres;
        private System.Windows.Forms.TextBox txtSearchPerformer;
        private System.Windows.Forms.TextBox txtSearchVenue;
        private System.Windows.Forms.DateTimePicker dtSearchDate;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnSearchPerformer;
        private System.Windows.Forms.Button btnSearchVenue;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEventDetails;
        private System.Windows.Forms.TextBox txtSearchEventName;
        private System.Windows.Forms.Button btnSearchEvent;
    }
}

