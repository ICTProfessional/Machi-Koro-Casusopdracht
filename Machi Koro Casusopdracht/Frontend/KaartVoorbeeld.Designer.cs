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
            ((System.ComponentModel.ISupportInitialize)(this.img_KaartVoorbeeld)).BeginInit();
            this.SuspendLayout();
            // 
            // img_KaartVoorbeeld
            // 
            this.img_KaartVoorbeeld.Image = global::Machi_Koro_Casusopdracht.Properties.Resources.Kaart1;
            this.img_KaartVoorbeeld.Location = new System.Drawing.Point(114, 12);
            this.img_KaartVoorbeeld.Name = "img_KaartVoorbeeld";
            this.img_KaartVoorbeeld.Size = new System.Drawing.Size(551, 615);
            this.img_KaartVoorbeeld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_KaartVoorbeeld.TabIndex = 0;
            this.img_KaartVoorbeeld.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(289, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // KaartVoorbeeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img_KaartVoorbeeld);
            this.Name = "KaartVoorbeeld";
            this.Text = "KaartVoorbeeld";
            ((System.ComponentModel.ISupportInitialize)(this.img_KaartVoorbeeld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_KaartVoorbeeld;
        private System.Windows.Forms.Button button1;
    }
}