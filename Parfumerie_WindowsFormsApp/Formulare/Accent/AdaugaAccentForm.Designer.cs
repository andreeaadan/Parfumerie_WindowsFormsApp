﻿namespace Parfumerie_WindowsFormsApp
{
    partial class AdaugaAccentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaAccentForm));
            this.btnAfiseazaAccente = new System.Windows.Forms.Button();
            this.btnAdaugaAccent = new System.Windows.Forms.Button();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPretPerMl = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfiseazaAccente
            // 
            this.btnAfiseazaAccente.Location = new System.Drawing.Point(77, 302);
            this.btnAfiseazaAccente.Name = "btnAfiseazaAccente";
            this.btnAfiseazaAccente.Size = new System.Drawing.Size(191, 26);
            this.btnAfiseazaAccente.TabIndex = 54;
            this.btnAfiseazaAccente.Text = "Afiseaza toate accentele";
            this.btnAfiseazaAccente.UseVisualStyleBackColor = true;
            this.btnAfiseazaAccente.Click += new System.EventHandler(this.btnAfiseazaAccente_Click);
            // 
            // btnAdaugaAccent
            // 
            this.btnAdaugaAccent.Location = new System.Drawing.Point(77, 258);
            this.btnAdaugaAccent.Name = "btnAdaugaAccent";
            this.btnAdaugaAccent.Size = new System.Drawing.Size(191, 26);
            this.btnAdaugaAccent.TabIndex = 53;
            this.btnAdaugaAccent.Text = "Adauga accentul";
            this.btnAdaugaAccent.UseVisualStyleBackColor = true;
            this.btnAdaugaAccent.Click += new System.EventHandler(this.btnAdaugaAccent_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(170, 157);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(130, 22);
            this.tbDenumire.TabIndex = 52;
            // 
            // tbPretPerMl
            // 
            this.tbPretPerMl.Location = new System.Drawing.Point(170, 202);
            this.tbPretPerMl.Name = "tbPretPerMl";
            this.tbPretPerMl.Size = new System.Drawing.Size(130, 22);
            this.tbPretPerMl.TabIndex = 51;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(170, 112);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(130, 22);
            this.tbID.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Pret per ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdaugaAccentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 401);
            this.Controls.Add(this.btnAfiseazaAccente);
            this.Controls.Add(this.btnAdaugaAccent);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbPretPerMl);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdaugaAccentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga accent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfiseazaAccente;
        private System.Windows.Forms.Button btnAdaugaAccent;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretPerMl;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}