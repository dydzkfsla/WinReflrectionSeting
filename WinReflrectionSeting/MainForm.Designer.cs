namespace WinReflrectionSeting
{
    partial class MainForm
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
            this.폼1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼1ToolStripMenuItem,
            this.폼2ToolStripMenuItem,
            this.폼3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 폼1ToolStripMenuItem
            // 
            this.폼1ToolStripMenuItem.Name = "폼1ToolStripMenuItem";
            this.폼1ToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.폼1ToolStripMenuItem.Text = "폼1";
            this.폼1ToolStripMenuItem.Click += new System.EventHandler(this.폼1ToolStripMenuItem_Click);
            // 
            // 폼2ToolStripMenuItem
            // 
            this.폼2ToolStripMenuItem.Name = "폼2ToolStripMenuItem";
            this.폼2ToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.폼2ToolStripMenuItem.Text = "폼2";
            this.폼2ToolStripMenuItem.Click += new System.EventHandler(this.폼2ToolStripMenuItem_Click);
            // 
            // 폼3ToolStripMenuItem
            // 
            this.폼3ToolStripMenuItem.Name = "폼3ToolStripMenuItem";
            this.폼3ToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.폼3ToolStripMenuItem.Text = "폼3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 548);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 폼1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼3ToolStripMenuItem;
    }
}