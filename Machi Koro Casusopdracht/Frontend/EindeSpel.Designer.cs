namespace Machi_Koro_Casusopdracht
{
    partial class EindeSpel
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
            this.lbl_Winnaar = new System.Windows.Forms.Label();
            this.btn_StartScherm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Winnaar
            // 
            this.lbl_Winnaar.AutoSize = true;
            this.lbl_Winnaar.Location = new System.Drawing.Point(169, 36);
            this.lbl_Winnaar.Name = "lbl_Winnaar";
            this.lbl_Winnaar.Size = new System.Drawing.Size(159, 16);
            this.lbl_Winnaar.TabIndex = 0;
            this.lbl_Winnaar.Text = "<speler> heeft gewonnen!";
            // 
            // btn_StartScherm
            // 
            this.btn_StartScherm.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_StartScherm.Location = new System.Drawing.Point(172, 110);
            this.btn_StartScherm.Name = "btn_StartScherm";
            this.btn_StartScherm.Size = new System.Drawing.Size(154, 42);
            this.btn_StartScherm.TabIndex = 2;
            this.btn_StartScherm.Text = "Terug naar start scherm";
            this.btn_StartScherm.UseVisualStyleBackColor = true;
            // 
            // EindeSpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 202);
            this.Controls.Add(this.btn_StartScherm);
            this.Controls.Add(this.lbl_Winnaar);
            this.Name = "EindeSpel";
            this.Text = "EindeSpel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Winnaar;
        private System.Windows.Forms.Button btn_StartScherm;
    }
}