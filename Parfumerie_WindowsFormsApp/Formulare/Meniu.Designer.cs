namespace Parfumerie_WindowsFormsApp
{
    partial class Meniu
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
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.btnAdaugaAccent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.Location = new System.Drawing.Point(117, 96);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaComanda.TabIndex = 0;
            this.btnAdaugaComanda.Text = "Adauga o comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = true;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // btnAdaugaClient
            // 
            this.btnAdaugaClient.Location = new System.Drawing.Point(117, 176);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaClient.TabIndex = 1;
            this.btnAdaugaClient.Text = "Adauga un client";
            this.btnAdaugaClient.UseVisualStyleBackColor = true;
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.Location = new System.Drawing.Point(117, 257);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaNota.TabIndex = 2;
            this.btnAdaugaNota.Text = "Adauga o nota";
            this.btnAdaugaNota.UseVisualStyleBackColor = true;
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // btnAdaugaAccent
            // 
            this.btnAdaugaAccent.Location = new System.Drawing.Point(117, 341);
            this.btnAdaugaAccent.Name = "btnAdaugaAccent";
            this.btnAdaugaAccent.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaAccent.TabIndex = 3;
            this.btnAdaugaAccent.Text = "Adauga un accent";
            this.btnAdaugaAccent.UseVisualStyleBackColor = true;
            this.btnAdaugaAccent.Click += new System.EventHandler(this.btnAdaugaAccent_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 430);
            this.Controls.Add(this.btnAdaugaAccent);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.btnAdaugaClient);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.Button btnAdaugaNota;
        private System.Windows.Forms.Button btnAdaugaAccent;
    }
}

