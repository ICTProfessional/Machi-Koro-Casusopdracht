﻿namespace Machi_Koro_Casusopdracht
{
    partial class Main
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
            this.btn_StartSpel = new System.Windows.Forms.Button();
            this.btn_Toernooi = new System.Windows.Forms.Button();
            this.btn_Instellingen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_SpelerLijst = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SpelerVerwijderen = new System.Windows.Forms.Button();
            this.btn_SpelerToevoegen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartSpel
            // 
            this.btn_StartSpel.Location = new System.Drawing.Point(598, 118);
            this.btn_StartSpel.Name = "btn_StartSpel";
            this.btn_StartSpel.Size = new System.Drawing.Size(122, 39);
            this.btn_StartSpel.TabIndex = 0;
            this.btn_StartSpel.Text = "Start spel";
            this.btn_StartSpel.UseVisualStyleBackColor = true;
            // 
            // btn_Toernooi
            // 
            this.btn_Toernooi.Location = new System.Drawing.Point(598, 189);
            this.btn_Toernooi.Name = "btn_Toernooi";
            this.btn_Toernooi.Size = new System.Drawing.Size(122, 39);
            this.btn_Toernooi.TabIndex = 1;
            this.btn_Toernooi.Text = "Start toernooi";
            this.btn_Toernooi.UseVisualStyleBackColor = true;
            // 
            // btn_Instellingen
            // 
            this.btn_Instellingen.Location = new System.Drawing.Point(598, 262);
            this.btn_Instellingen.Name = "btn_Instellingen";
            this.btn_Instellingen.Size = new System.Drawing.Size(122, 39);
            this.btn_Instellingen.TabIndex = 2;
            this.btn_Instellingen.Text = "Instellingen";
            this.btn_Instellingen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Machi Koro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_SpelerLijst
            // 
            this.lb_SpelerLijst.FormattingEnabled = true;
            this.lb_SpelerLijst.ItemHeight = 16;
            this.lb_SpelerLijst.Location = new System.Drawing.Point(41, 104);
            this.lb_SpelerLijst.Name = "lb_SpelerLijst";
            this.lb_SpelerLijst.Size = new System.Drawing.Size(207, 244);
            this.lb_SpelerLijst.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Spelers:";
            // 
            // btn_SpelerVerwijderen
            // 
            this.btn_SpelerVerwijderen.Location = new System.Drawing.Point(155, 370);
            this.btn_SpelerVerwijderen.Name = "btn_SpelerVerwijderen";
            this.btn_SpelerVerwijderen.Size = new System.Drawing.Size(93, 40);
            this.btn_SpelerVerwijderen.TabIndex = 6;
            this.btn_SpelerVerwijderen.Text = "Verwijder speler";
            this.btn_SpelerVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_SpelerToevoegen
            // 
            this.btn_SpelerToevoegen.Location = new System.Drawing.Point(41, 370);
            this.btn_SpelerToevoegen.Name = "btn_SpelerToevoegen";
            this.btn_SpelerToevoegen.Size = new System.Drawing.Size(93, 40);
            this.btn_SpelerToevoegen.TabIndex = 8;
            this.btn_SpelerToevoegen.Text = "Voeg speler toe";
            this.btn_SpelerToevoegen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Limburg";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SpelerToevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SpelerVerwijderen);
            this.Controls.Add(this.lb_SpelerLijst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Instellingen);
            this.Controls.Add(this.btn_Toernooi);
            this.Controls.Add(this.btn_StartSpel);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartSpel;
        private System.Windows.Forms.Button btn_Toernooi;
        private System.Windows.Forms.Button btn_Instellingen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_SpelerLijst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SpelerVerwijderen;
        private System.Windows.Forms.Button btn_SpelerToevoegen;
        private System.Windows.Forms.Label label3;
    }
}