namespace TicketSystem
{
    partial class FrmEditPerfomers
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
            this.txtNameOfPerformerToEdit = new System.Windows.Forms.TextBox();
            this.txtURLOfPerfomerToEdit = new System.Windows.Forms.TextBox();
            this.txtInfoOfPerformerToEdit = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cboListOfPerformers = new System.Windows.Forms.ComboBox();
            this.txtPerformerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameOfPerformerToEdit
            // 
            this.txtNameOfPerformerToEdit.Location = new System.Drawing.Point(12, 159);
            this.txtNameOfPerformerToEdit.Name = "txtNameOfPerformerToEdit";
            this.txtNameOfPerformerToEdit.Size = new System.Drawing.Size(100, 20);
            this.txtNameOfPerformerToEdit.TabIndex = 2;
            // 
            // txtURLOfPerfomerToEdit
            // 
            this.txtURLOfPerfomerToEdit.Location = new System.Drawing.Point(137, 159);
            this.txtURLOfPerfomerToEdit.Name = "txtURLOfPerfomerToEdit";
            this.txtURLOfPerfomerToEdit.Size = new System.Drawing.Size(100, 20);
            this.txtURLOfPerfomerToEdit.TabIndex = 3;
            // 
            // txtInfoOfPerformerToEdit
            // 
            this.txtInfoOfPerformerToEdit.Location = new System.Drawing.Point(268, 159);
            this.txtInfoOfPerformerToEdit.Name = "txtInfoOfPerformerToEdit";
            this.txtInfoOfPerformerToEdit.Size = new System.Drawing.Size(100, 20);
            this.txtInfoOfPerformerToEdit.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(167, 119);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(279, 119);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Performer Info";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(137, 213);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 37);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cboListOfPerformers
            // 
            this.cboListOfPerformers.FormattingEnabled = true;
            this.cboListOfPerformers.Location = new System.Drawing.Point(170, 35);
            this.cboListOfPerformers.Name = "cboListOfPerformers";
            this.cboListOfPerformers.Size = new System.Drawing.Size(121, 21);
            this.cboListOfPerformers.TabIndex = 9;
            this.cboListOfPerformers.SelectedIndexChanged += new System.EventHandler(this.cboListOfPerformers_SelectedIndexChanged);
            // 
            // txtPerformerID
            // 
            this.txtPerformerID.Location = new System.Drawing.Point(12, 55);
            this.txtPerformerID.Name = "txtPerformerID";
            this.txtPerformerID.Size = new System.Drawing.Size(100, 20);
            this.txtPerformerID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Performer ID";
            // 
            // FrmEditPerfomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPerformerID);
            this.Controls.Add(this.cboListOfPerformers);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtInfoOfPerformerToEdit);
            this.Controls.Add(this.txtURLOfPerfomerToEdit);
            this.Controls.Add(this.txtNameOfPerformerToEdit);
            this.Name = "FrmEditPerfomers";
            this.Text = "FrmEditPerfomers";
            this.Load += new System.EventHandler(this.FrmEditPerfomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameOfPerformerToEdit;
        private System.Windows.Forms.TextBox txtURLOfPerfomerToEdit;
        private System.Windows.Forms.TextBox txtInfoOfPerformerToEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cboListOfPerformers;
        private System.Windows.Forms.TextBox txtPerformerID;
        private System.Windows.Forms.Label label1;
    }
}