namespace Parfumerie_WindowsFormsApp
{
    partial class AfiseazaClientiForm
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
            this.lvClienti = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvClienti
            // 
            this.lvClienti.BackColor = System.Drawing.SystemColors.Window;
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nume,
            this.prenume,
            this.telefon,
            this.email});
            this.lvClienti.ContextMenuStrip = this.contextMenuStrip1;
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.GridLines = true;
            this.lvClienti.HideSelection = false;
            this.lvClienti.Location = new System.Drawing.Point(77, 39);
            this.lvClienti.Margin = new System.Windows.Forms.Padding(4);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(647, 373);
            this.lvClienti.TabIndex = 2;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            this.lvClienti.DoubleClick += new System.EventHandler(this.lvClienti_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 37;
            // 
            // nume
            // 
            this.nume.Text = "Nume";
            this.nume.Width = 120;
            // 
            // prenume
            // 
            this.prenume.Text = "Prenume";
            this.prenume.Width = 134;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            this.telefon.Width = 132;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 126;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Sterge client";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AfiseazaClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvClienti);
            this.Name = "AfiseazaClientiForm";
            this.Text = "AfiseazaClientiForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader prenume;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}