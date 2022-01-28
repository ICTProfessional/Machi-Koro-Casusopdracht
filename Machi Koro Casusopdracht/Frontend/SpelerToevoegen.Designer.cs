namespace Machi_Koro_Casusopdracht
{
    partial class SpelerToevoegen
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
            this.txtbox_NaamSpeler = new System.Windows.Forms.TextBox();
            this.check_IsRobot = new System.Windows.Forms.CheckBox();
            this.btn_OkKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voer de naam van de speler in:";
            // 
            // txtbox_NaamSpeler
            // 
            this.txtbox_NaamSpeler.Location = new System.Drawing.Point(124, 55);
            this.txtbox_NaamSpeler.Name = "txtbox_NaamSpeler";
            this.txtbox_NaamSpeler.Size = new System.Drawing.Size(177, 22);
            this.txtbox_NaamSpeler.TabIndex = 1;
            this.txtbox_NaamSpeler.TextChanged += new System.EventHandler(this.txtbox_NaamSpeler_TextChanged);
            // 
            // check_IsRobot
            // 
            this.check_IsRobot.AutoSize = true;
            this.check_IsRobot.Location = new System.Drawing.Point(174, 83);
            this.check_IsRobot.Name = "check_IsRobot";
            this.check_IsRobot.Size = new System.Drawing.Size(73, 20);
            this.check_IsRobot.TabIndex = 2;
            this.check_IsRobot.Text = "Is robot";
            this.check_IsRobot.UseVisualStyleBackColor = true;
            this.check_IsRobot.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_OkKnop
            // 
            this.btn_OkKnop.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OkKnop.Location = new System.Drawing.Point(155, 131);
            this.btn_OkKnop.Name = "btn_OkKnop";
            this.btn_OkKnop.Size = new System.Drawing.Size(112, 31);
            this.btn_OkKnop.TabIndex = 3;
            this.btn_OkKnop.Text = "OK";
            this.btn_OkKnop.UseVisualStyleBackColor = true;
            // 
            // SpelerToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 174);
            this.Controls.Add(this.btn_OkKnop);
            this.Controls.Add(this.check_IsRobot);
            this.Controls.Add(this.txtbox_NaamSpeler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SpelerToevoegen";
            this.Text = "SpelerToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_NaamSpeler;
        private System.Windows.Forms.CheckBox check_IsRobot;
        private System.Windows.Forms.Button btn_OkKnop;
    }
}