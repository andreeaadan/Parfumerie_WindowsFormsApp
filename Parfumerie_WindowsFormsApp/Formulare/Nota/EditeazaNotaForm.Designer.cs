namespace Parfumerie_WindowsFormsApp
{
    partial class EditeazaNotaForm
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
            this.btnActualizeazaNota = new System.Windows.Forms.Button();
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
            // btnActualizeazaNota
            // 
            this.btnActualizeazaNota.Location = new System.Drawing.Point(86, 248);
            this.btnActualizeazaNota.Name = "btnActualizeazaNota";
            this.btnActualizeazaNota.Size = new System.Drawing.Size(143, 26);
            this.btnActualizeazaNota.TabIndex = 53;
            this.btnActualizeazaNota.Text = "Actualizeaza nota";
            this.btnActualizeazaNota.UseVisualStyleBackColor = true;
            this.btnActualizeazaNota.Click += new System.EventHandler(this.btnActualizeazaNota_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(149, 106);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(130, 22);
            this.tbDenumire.TabIndex = 52;
            // 
            // tbPretPerMl
            // 
            this.tbPretPerMl.Location = new System.Drawing.Point(149, 151);
            this.tbPretPerMl.Name = "tbPretPerMl";
            this.tbPretPerMl.Size = new System.Drawing.Size(130, 22);
            this.tbPretPerMl.TabIndex = 51;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(149, 61);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(130, 22);
            this.tbID.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Pret per ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditeazaNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 343);
            this.Controls.Add(this.btnActualizeazaNota);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbPretPerMl);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditeazaNotaForm";
            this.Text = "EditeazaNota";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizeazaNota;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretPerMl;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}