namespace TicketSystem
{
    partial class FrmCreatePerformer
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
            this.txtPerformerName = new System.Windows.Forms.TextBox();
            this.txtPerformerUrl = new System.Windows.Forms.TextBox();
            this.txtPerformerInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Perf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSubmitPerformer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPerformerName
            // 
            this.txtPerformerName.Location = new System.Drawing.Point(27, 79);
            this.txtPerformerName.Name = "txtPerformerName";
            this.txtPerformerName.Size = new System.Drawing.Size(379, 20);
            this.txtPerformerName.TabIndex = 0;
            // 
            // txtPerformerUrl
            // 
            this.txtPerformerUrl.Location = new System.Drawing.Point(27, 142);
            this.txtPerformerUrl.Name = "txtPerformerUrl";
            this.txtPerformerUrl.Size = new System.Drawing.Size(379, 20);
            this.txtPerformerUrl.TabIndex = 1;
            // 
            // txtPerformerInfo
            // 
            this.txtPerformerInfo.Location = new System.Drawing.Point(74, 257);
            this.txtPerformerInfo.Multiline = true;
            this.txtPerformerInfo.Name = "txtPerformerInfo";
            this.txtPerformerInfo.Size = new System.Drawing.Size(608, 225);
            this.txtPerformerInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create A New Performer";
            // 
            // Perf
            // 
            this.Perf.AutoSize = true;
            this.Perf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perf.Location = new System.Drawing.Point(464, 86);
            this.Perf.Name = "Perf";
            this.Perf.Size = new System.Drawing.Size(121, 16);
            this.Perf.TabIndex = 4;
            this.Perf.Text = "Performer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Performer Website URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Performer Information";
            // 
            // BtnSubmitPerformer
            // 
            this.BtnSubmitPerformer.Location = new System.Drawing.Point(737, 257);
            this.BtnSubmitPerformer.Name = "BtnSubmitPerformer";
            this.BtnSubmitPerformer.Size = new System.Drawing.Size(147, 45);
            this.BtnSubmitPerformer.TabIndex = 7;
            this.BtnSubmitPerformer.Text = "Submit";
            this.BtnSubmitPerformer.UseVisualStyleBackColor = true;
            this.BtnSubmitPerformer.Click += new System.EventHandler(this.BtnSubmitPerformer_Click);
            // 
            // FrmCreatePerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 552);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSubmitPerformer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Perf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPerformerInfo);
            this.Controls.Add(this.txtPerformerUrl);
            this.Controls.Add(this.txtPerformerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreatePerformer";
            this.Text = "Create A Performer";
            this.Load += new System.EventHandler(this.FrmCreatePerformer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerformerName;
        private System.Windows.Forms.TextBox txtPerformerUrl;
        private System.Windows.Forms.TextBox txtPerformerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Perf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSubmitPerformer;
    }
}