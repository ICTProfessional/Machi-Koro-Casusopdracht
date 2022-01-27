namespace Machi_Koro_Casusopdracht
{
    partial class KaartVoorbeeld
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
            this.img_KaartVoorbeeld = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_KaartVoorbeeld)).BeginInit();
            this.SuspendLayout();
            // 
            // img_KaartVoorbeeld
            // 
            this.img_KaartVoorbeeld.Image = global::Machi_Koro_Casusopdracht.Properties.Resources.Kaart1;
            this.img_KaartVoorbeeld.Location = new System.Drawing.Point(122, 79);
            this.img_KaartVoorbeeld.Name = "img_KaartVoorbeeld";
            this.img_KaartVoorbeeld.Size = new System.Drawing.Size(551, 615);
            this.img_KaartVoorbeeld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_KaartVoorbeeld.TabIndex = 0;
            this.img_KaartVoorbeeld.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(297, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voorbeeld:";
            // 
            // KaartVoorbeeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img_KaartVoorbeeld);
            this.Name = "KaartVoorbeeld";
            this.Text = "KaartVoorbeeld";
            ((System.ComponentModel.ISupportInitialize)(this.img_KaartVoorbeeld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_KaartVoorbeeld;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}