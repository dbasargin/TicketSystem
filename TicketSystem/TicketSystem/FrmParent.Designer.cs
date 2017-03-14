namespace TicketSystem
{
    partial class FrmParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreatePerformer = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnMenu,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 22);
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.editToolStripMenuItem});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 22);
            this.btnMenu.Text = "Menu";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCreateEvent,
            this.BtnCreateCategory,
            this.BtnCreatePerformer,
            this.BtnCreateVenue});
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createEventToolStripMenuItem.Text = "Create";
            // 
            // BtnCreateEvent
            // 
            this.BtnCreateEvent.Name = "BtnCreateEvent";
            this.BtnCreateEvent.Size = new System.Drawing.Size(127, 22);
            this.BtnCreateEvent.Text = "Event";
            this.BtnCreateEvent.Click += new System.EventHandler(this.BtnCreateEvent_Click);
            // 
            // BtnCreateCategory
            // 
            this.BtnCreateCategory.Name = "BtnCreateCategory";
            this.BtnCreateCategory.Size = new System.Drawing.Size(127, 22);
            this.BtnCreateCategory.Text = "Category";
            this.BtnCreateCategory.Click += new System.EventHandler(this.BtnCreateCategory_Click);
            // 
            // BtnCreatePerformer
            // 
            this.BtnCreatePerformer.Name = "BtnCreatePerformer";
            this.BtnCreatePerformer.Size = new System.Drawing.Size(127, 22);
            this.BtnCreatePerformer.Text = "Performer";
            this.BtnCreatePerformer.Click += new System.EventHandler(this.BtnCreatePerformer_Click);
            // 
            // BtnCreateVenue
            // 
            this.BtnCreateVenue.Name = "BtnCreateVenue";
            this.BtnCreateVenue.Size = new System.Drawing.Size(127, 22);
            this.BtnCreateVenue.Text = "Venue";
            this.BtnCreateVenue.Click += new System.EventHandler(this.BtnCreateVenue_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // performersToolStripMenuItem
            // 
            this.performersToolStripMenuItem.Name = "performersToolStripMenuItem";
            this.performersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.performersToolStripMenuItem.Text = "Performers";
            this.performersToolStripMenuItem.Click += new System.EventHandler(this.performersToolStripMenuItem_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 719);
            this.MinimumSize = new System.Drawing.Size(1000, 538);
            this.Name = "FrmParent";
            this.Text = "Derick and Dennis\'s Super Slick Ticket System ";
            this.Load += new System.EventHandler(this.FrmParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateEvent;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateCategory;
        private System.Windows.Forms.ToolStripMenuItem BtnCreatePerformer;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateVenue;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performersToolStripMenuItem;
    }
}