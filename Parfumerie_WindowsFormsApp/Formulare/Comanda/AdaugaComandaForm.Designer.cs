namespace Parfumerie_WindowsFormsApp
{
    partial class AdaugaComandaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaComandaForm));
            this.btnAfiseazaComenzi = new System.Windows.Forms.Button();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbNota = new System.Windows.Forms.ComboBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfiseazaComenzi
            // 
            this.btnAfiseazaComenzi.Location = new System.Drawing.Point(127, 449);
            this.btnAfiseazaComenzi.Name = "btnAfiseazaComenzi";
            this.btnAfiseazaComenzi.Size = new System.Drawing.Size(185, 26);
            this.btnAfiseazaComenzi.TabIndex = 35;
            this.btnAfiseazaComenzi.Text = "Afiseaza toate comenzile";
            this.btnAfiseazaComenzi.UseVisualStyleBackColor = true;
            this.btnAfiseazaComenzi.Click += new System.EventHandler(this.btnAfiseazaComenzi_Click);
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.Location = new System.Drawing.Point(127, 404);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(185, 26);
            this.btnAdaugaComanda.TabIndex = 30;
            this.btnAdaugaComanda.Text = "Adauga comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = true;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(169, 58);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(204, 22);
            this.tbID.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nota de baza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(170, 330);
            this.tbPret.Name = "tbPret";
            this.tbPret.ReadOnly = true;
            this.tbPret.Size = new System.Drawing.Size(203, 22);
            this.tbPret.TabIndex = 41;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(169, 285);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(204, 22);
            this.tbCantitate.TabIndex = 40;
            this.tbCantitate.TextChanged += new System.EventHandler(this.tbCantitate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Pret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Cantitate in ml";
            // 
            // cbClient
            // 
            this.cbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(169, 100);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(204, 24);
            this.cbClient.TabIndex = 42;
            // 
            // cbNota
            // 
            this.cbNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNota.FormattingEnabled = true;
            this.cbNota.Location = new System.Drawing.Point(169, 194);
            this.cbNota.Name = "cbNota";
            this.cbNota.Size = new System.Drawing.Size(204, 24);
            this.cbNota.TabIndex = 44;
            this.cbNota.SelectedIndexChanged += new System.EventHandler(this.cbNota_SelectedIndexChanged);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(169, 146);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(204, 24);
            this.cbCategorie.TabIndex = 45;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Accente";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(190, 24);
            this.toolStripDropDownButton1.Text = "Alege cel putin un accent";
            this.toolStripDropDownButton1.ToolTipText = "Alege cel putin un accent";
            this.toolStripDropDownButton1.DropDownClosed += new System.EventHandler(this.toolStripDropDownButton1_DropDownClosed_1);
            this.toolStripDropDownButton1.DropDownOpening += new System.EventHandler(this.toolStripDropDownButton1_DropDownOpening);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(169, 240);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(193, 27);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 180;
            this.errorProvider1.ContainerControl = this;
            // 
            // AdaugaComandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.cbNota);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAfiseazaComenzi);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaComandaForm";
            this.Text = "AdaugaComanda";
            this.Load += new System.EventHandler(this.AdaugaComandaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfiseazaComenzi;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbNota;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}