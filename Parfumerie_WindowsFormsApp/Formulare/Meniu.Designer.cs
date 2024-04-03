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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.btnAdaugaAccent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdaugaComanda.Location = new System.Drawing.Point(95, 59);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaComanda.TabIndex = 0;
            this.btnAdaugaComanda.Text = "Adauga o comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = false;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // btnAdaugaClient
            // 
            this.btnAdaugaClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdaugaClient.Location = new System.Drawing.Point(95, 139);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaClient.TabIndex = 1;
            this.btnAdaugaClient.Text = "Adauga un client";
            this.btnAdaugaClient.UseVisualStyleBackColor = false;
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdaugaNota.Location = new System.Drawing.Point(95, 220);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaNota.TabIndex = 2;
            this.btnAdaugaNota.Text = "Adauga o nota";
            this.btnAdaugaNota.UseVisualStyleBackColor = false;
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // btnAdaugaAccent
            // 
            this.btnAdaugaAccent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdaugaAccent.Location = new System.Drawing.Point(95, 304);
            this.btnAdaugaAccent.Name = "btnAdaugaAccent";
            this.btnAdaugaAccent.Size = new System.Drawing.Size(171, 46);
            this.btnAdaugaAccent.TabIndex = 3;
            this.btnAdaugaAccent.Text = "Adauga un accent";
            this.btnAdaugaAccent.UseVisualStyleBackColor = false;
            this.btnAdaugaAccent.Click += new System.EventHandler(this.btnAdaugaAccent_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 422);
            this.Controls.Add(this.btnAdaugaAccent);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.btnAdaugaClient);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

