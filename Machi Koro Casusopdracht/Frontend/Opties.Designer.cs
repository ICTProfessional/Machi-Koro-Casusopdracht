namespace Machi_Koro_Casusopdracht
{
    partial class Opties
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
            this.btn_Spelregels = new System.Windows.Forms.Button();
            this.btn_Handleiding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Spelregels
            // 
            this.btn_Spelregels.Location = new System.Drawing.Point(30, 74);
            this.btn_Spelregels.Name = "btn_Spelregels";
            this.btn_Spelregels.Size = new System.Drawing.Size(96, 37);
            this.btn_Spelregels.TabIndex = 0;
            this.btn_Spelregels.Text = "Spelregels";
            this.btn_Spelregels.UseVisualStyleBackColor = true;
            // 
            // btn_Handleiding
            // 
            this.btn_Handleiding.Location = new System.Drawing.Point(185, 74);
            this.btn_Handleiding.Name = "btn_Handleiding";
            this.btn_Handleiding.Size = new System.Drawing.Size(105, 37);
            this.btn_Handleiding.TabIndex = 1;
            this.btn_Handleiding.Text = "Handleiding";
            this.btn_Handleiding.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opties";
            // 
            // Opties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Handleiding);
            this.Controls.Add(this.btn_Spelregels);
            this.Name = "Opties";
            this.Text = "Opties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Spelregels;
        private System.Windows.Forms.Button btn_Handleiding;
        private System.Windows.Forms.Label label1;
    }
}