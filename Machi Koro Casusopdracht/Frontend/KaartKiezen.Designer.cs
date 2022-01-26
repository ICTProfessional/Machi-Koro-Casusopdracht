namespace Machi_Koro_Casusopdracht
{
    partial class KaartKiezen
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
            this.lb_Kaarten = new System.Windows.Forms.ListBox();
            this.lbl_SpelerAnnouncement = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Kaarten
            // 
            this.lb_Kaarten.FormattingEnabled = true;
            this.lb_Kaarten.ItemHeight = 16;
            this.lb_Kaarten.Location = new System.Drawing.Point(42, 68);
            this.lb_Kaarten.Name = "lb_Kaarten";
            this.lb_Kaarten.Size = new System.Drawing.Size(262, 244);
            this.lb_Kaarten.TabIndex = 0;
            this.lb_Kaarten.SelectedIndexChanged += new System.EventHandler(this.lb_Kaarten_SelectedIndexChanged);
            // 
            // lbl_SpelerAnnouncement
            // 
            this.lbl_SpelerAnnouncement.AutoSize = true;
            this.lbl_SpelerAnnouncement.Location = new System.Drawing.Point(68, 33);
            this.lbl_SpelerAnnouncement.Name = "lbl_SpelerAnnouncement";
            this.lbl_SpelerAnnouncement.Size = new System.Drawing.Size(204, 16);
            this.lbl_SpelerAnnouncement.TabIndex = 1;
            this.lbl_SpelerAnnouncement.Text = "Selecteer een kaart van <speler>\r\n";
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(134, 347);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // KaartKiezen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.lbl_SpelerAnnouncement);
            this.Controls.Add(this.lb_Kaarten);
            this.Name = "KaartKiezen";
            this.Text = "KaartKiezen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Kaarten;
        private System.Windows.Forms.Label lbl_SpelerAnnouncement;
        private System.Windows.Forms.Button OK;
    }
}