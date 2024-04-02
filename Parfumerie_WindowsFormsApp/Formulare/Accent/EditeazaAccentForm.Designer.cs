namespace Parfumerie_WindowsFormsApp
{
    partial class EditeazaAccentForm
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
            this.btnActualizeazaAccent = new System.Windows.Forms.Button();
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
            // btnActualizeazaAccent
            // 
            this.btnActualizeazaAccent.Location = new System.Drawing.Point(86, 258);
            this.btnActualizeazaAccent.Name = "btnActualizeazaAccent";
            this.btnActualizeazaAccent.Size = new System.Drawing.Size(143, 26);
            this.btnActualizeazaAccent.TabIndex = 60;
            this.btnActualizeazaAccent.Text = "Actualizeaza nota";
            this.btnActualizeazaAccent.UseVisualStyleBackColor = true;
            this.btnActualizeazaAccent.Click += new System.EventHandler(this.btnActualizeazaAccent_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(149, 116);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(130, 22);
            this.tbDenumire.TabIndex = 59;
            // 
            // tbPretPerMl
            // 
            this.tbPretPerMl.Location = new System.Drawing.Point(149, 161);
            this.tbPretPerMl.Name = "tbPretPerMl";
            this.tbPretPerMl.Size = new System.Drawing.Size(130, 22);
            this.tbPretPerMl.TabIndex = 58;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(149, 71);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(130, 22);
            this.tbID.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Pret per ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditeazaAccentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 387);
            this.Controls.Add(this.btnActualizeazaAccent);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbPretPerMl);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditeazaAccentForm";
            this.Text = "EditeazaAccentForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizeazaAccent;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretPerMl;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}