namespace Machi_Koro_Casusopdracht
{
    partial class ToernooiScherm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Spelergroepen = new System.Windows.Forms.ListBox();
            this.btn_BeginToernooi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "De volgende groepen zijn gemaakt:";
            // 
            // lb_Spelergroepen
            // 
            this.lb_Spelergroepen.FormattingEnabled = true;
            this.lb_Spelergroepen.ItemHeight = 16;
            this.lb_Spelergroepen.Location = new System.Drawing.Point(42, 73);
            this.lb_Spelergroepen.Name = "lb_Spelergroepen";
            this.lb_Spelergroepen.Size = new System.Drawing.Size(217, 180);
            this.lb_Spelergroepen.TabIndex = 1;
            this.lb_Spelergroepen.SelectedIndexChanged += new System.EventHandler(this.lb_Spelergroepen_SelectedIndexChanged);
            // 
            // btn_BeginToernooi
            // 
            this.btn_BeginToernooi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_BeginToernooi.Location = new System.Drawing.Point(107, 278);
            this.btn_BeginToernooi.Name = "btn_BeginToernooi";
            this.btn_BeginToernooi.Size = new System.Drawing.Size(75, 23);
            this.btn_BeginToernooi.TabIndex = 2;
            this.btn_BeginToernooi.Text = "Begin";
            this.btn_BeginToernooi.UseVisualStyleBackColor = true;
            this.btn_BeginToernooi.Click += new System.EventHandler(this.btn_BeginToernooi_Click);
            // 
            // ToernooiScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 340);
            this.Controls.Add(this.btn_BeginToernooi);
            this.Controls.Add(this.lb_Spelergroepen);
            this.Controls.Add(this.label1);
            this.Name = "ToernooiScherm";
            this.Text = "ToernooiScherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_Spelergroepen;
        private System.Windows.Forms.Button btn_BeginToernooi;
    }
}