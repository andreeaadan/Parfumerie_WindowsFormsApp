namespace Parfumerie_WindowsFormsApp
{
    partial class AdaugaNotaForm
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
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPretPerMl = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAfiseazaNote = new System.Windows.Forms.Button();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(169, 132);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(130, 22);
            this.tbDenumire.TabIndex = 44;
            // 
            // tbPretPerMl
            // 
            this.tbPretPerMl.Location = new System.Drawing.Point(169, 177);
            this.tbPretPerMl.Name = "tbPretPerMl";
            this.tbPretPerMl.Size = new System.Drawing.Size(130, 22);
            this.tbPretPerMl.TabIndex = 43;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(169, 87);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(130, 22);
            this.tbID.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pret per ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // btnAfiseazaNote
            // 
            this.btnAfiseazaNote.Location = new System.Drawing.Point(88, 310);
            this.btnAfiseazaNote.Name = "btnAfiseazaNote";
            this.btnAfiseazaNote.Size = new System.Drawing.Size(171, 26);
            this.btnAfiseazaNote.TabIndex = 46;
            this.btnAfiseazaNote.Text = "Afiseaza toate notele";
            this.btnAfiseazaNote.UseVisualStyleBackColor = true;
            this.btnAfiseazaNote.Click += new System.EventHandler(this.btnAfiseazaNote_Click);
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.Location = new System.Drawing.Point(88, 266);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(171, 26);
            this.btnAdaugaNota.TabIndex = 45;
            this.btnAdaugaNota.Text = "Adauga nota";
            this.btnAdaugaNota.UseVisualStyleBackColor = true;
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdaugaNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 393);
            this.Controls.Add(this.btnAfiseazaNote);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbPretPerMl);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaNotaForm";
            this.Text = "AdaugaNota";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretPerMl;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAfiseazaNote;
        private System.Windows.Forms.Button btnAdaugaNota;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}