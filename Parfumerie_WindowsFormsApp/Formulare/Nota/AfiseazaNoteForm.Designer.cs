namespace Parfumerie_WindowsFormsApp
{
    partial class AfiseazaNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfiseazaNoteForm));
            this.lvNote = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pretPerMl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNote
            // 
            this.lvNote.BackColor = System.Drawing.SystemColors.Window;
            this.lvNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.denumire,
            this.pretPerMl});
            this.lvNote.ContextMenuStrip = this.contextMenuStrip;
            this.lvNote.FullRowSelect = true;
            this.lvNote.GridLines = true;
            this.lvNote.HideSelection = false;
            this.lvNote.Location = new System.Drawing.Point(39, 26);
            this.lvNote.Margin = new System.Windows.Forms.Padding(4);
            this.lvNote.Name = "lvNote";
            this.lvNote.Size = new System.Drawing.Size(373, 306);
            this.lvNote.TabIndex = 2;
            this.lvNote.UseCompatibleStateImageBehavior = false;
            this.lvNote.View = System.Windows.Forms.View.Details;
            this.lvNote.DoubleClick += new System.EventHandler(this.lvNote_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 37;
            // 
            // denumire
            // 
            this.denumire.Text = "Denumire";
            this.denumire.Width = 120;
            // 
            // pretPerMl
            // 
            this.pretPerMl.Text = "Pret per ml";
            this.pretPerMl.Width = 134;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(156, 28);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.deleteToolStripMenuItem.Text = "Sterge nota";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AfiseazaNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parfumerie_WindowsFormsApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 388);
            this.Controls.Add(this.lvNote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AfiseazaNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfiseazaNoteForm_FormClosed);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvNote;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader denumire;
        private System.Windows.Forms.ColumnHeader pretPerMl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}