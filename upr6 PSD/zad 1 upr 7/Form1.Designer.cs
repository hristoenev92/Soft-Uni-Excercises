namespace zad_1_upr_7
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dobavqneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spravkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyrseneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvoditel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nalichnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobavqneToolStripMenuItem,
            this.spravkaToolStripMenuItem,
            this.tyrseneToolStripMenuItem,
            this.izhodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dobavqneToolStripMenuItem
            // 
            this.dobavqneToolStripMenuItem.Name = "dobavqneToolStripMenuItem";
            this.dobavqneToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.dobavqneToolStripMenuItem.Text = "dobavqne";
            this.dobavqneToolStripMenuItem.Click += new System.EventHandler(this.dobavqneToolStripMenuItem_Click);
            // 
            // spravkaToolStripMenuItem
            // 
            this.spravkaToolStripMenuItem.Name = "spravkaToolStripMenuItem";
            this.spravkaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.spravkaToolStripMenuItem.Text = "spravka";
            // 
            // tyrseneToolStripMenuItem
            // 
            this.tyrseneToolStripMenuItem.Name = "tyrseneToolStripMenuItem";
            this.tyrseneToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tyrseneToolStripMenuItem.Text = "tyrsene";
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.izhodToolStripMenuItem.Text = "izhod";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Group,
            this.Proizvoditel,
            this.Price,
            this.Nalichnost});
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Proizvoditel
            // 
            this.Proizvoditel.HeaderText = "Proizvoditel";
            this.Proizvoditel.Name = "Proizvoditel";
            this.Proizvoditel.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Nalichnost
            // 
            this.Nalichnost.HeaderText = "Nalichnost";
            this.Nalichnost.Name = "Nalichnost";
            this.Nalichnost.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dobavqneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spravkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyrseneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvoditel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nalichnost;
    }
}

