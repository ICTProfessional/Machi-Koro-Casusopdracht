namespace Machi_Koro_Casusopdracht
{
    partial class SpelerChecken
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
            this.lb_SpelerLijst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CheckGegevens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_SpelerLijst
            // 
            this.lb_SpelerLijst.FormattingEnabled = true;
            this.lb_SpelerLijst.ItemHeight = 16;
            this.lb_SpelerLijst.Location = new System.Drawing.Point(58, 74);
            this.lb_SpelerLijst.Name = "lb_SpelerLijst";
            this.lb_SpelerLijst.Size = new System.Drawing.Size(185, 260);
            this.lb_SpelerLijst.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer speler:";
            // 
            // btn_CheckGegevens
            // 
            this.btn_CheckGegevens.Location = new System.Drawing.Point(76, 356);
            this.btn_CheckGegevens.Name = "btn_CheckGegevens";
            this.btn_CheckGegevens.Size = new System.Drawing.Size(153, 36);
            this.btn_CheckGegevens.TabIndex = 2;
            this.btn_CheckGegevens.Text = "Check gegevens";
            this.btn_CheckGegevens.UseVisualStyleBackColor = true;
            // 
            // SpelerChecken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 404);
            this.Controls.Add(this.btn_CheckGegevens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_SpelerLijst);
            this.Name = "SpelerChecken";
            this.Text = "SpelerChecken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_SpelerLijst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CheckGegevens;
    }
}