namespace zad_1
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.BT1 = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(12, 12);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 0;
            this.TB1.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(159, 12);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(75, 23);
            this.BT1.TabIndex = 1;
            this.BT1.Text = "button1";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Location = new System.Drawing.Point(12, 74);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(481, 225);
            this.LB1.TabIndex = 2;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.LB1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 358);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.TB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.ListBox LB1;
    }
}

