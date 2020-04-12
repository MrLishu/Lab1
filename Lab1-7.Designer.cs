namespace Test1
{
    partial class Lab1_7
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
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTheMinimumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTheMaximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.countToolStripMenuItem,
            this.finishToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateRandomDataToolStripMenuItem,
            this.deleteTheMinimumToolStripMenuItem,
            this.deleteTheMaximumToolStripMenuItem,
            this.addDataToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // generateRandomDataToolStripMenuItem
            // 
            this.generateRandomDataToolStripMenuItem.Name = "generateRandomDataToolStripMenuItem";
            this.generateRandomDataToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.generateRandomDataToolStripMenuItem.Text = "Generate random data";
            this.generateRandomDataToolStripMenuItem.Click += new System.EventHandler(this.GenerateRandomDataToolStripMenuItem_Click);
            // 
            // deleteTheMinimumToolStripMenuItem
            // 
            this.deleteTheMinimumToolStripMenuItem.Name = "deleteTheMinimumToolStripMenuItem";
            this.deleteTheMinimumToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.deleteTheMinimumToolStripMenuItem.Text = "Delete the minimum";
            this.deleteTheMinimumToolStripMenuItem.Click += new System.EventHandler(this.DeleteTheMinimumToolStripMenuItem_Click);
            // 
            // deleteTheMaximumToolStripMenuItem
            // 
            this.deleteTheMaximumToolStripMenuItem.Name = "deleteTheMaximumToolStripMenuItem";
            this.deleteTheMaximumToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.deleteTheMaximumToolStripMenuItem.Text = "Delete the maximum";
            this.deleteTheMaximumToolStripMenuItem.Click += new System.EventHandler(this.DeleteTheMaximumToolStripMenuItem_Click);
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.addDataToolStripMenuItem.Text = "Add data";
            this.addDataToolStripMenuItem.Click += new System.EventHandler(this.AddDataToolStripMenuItem_Click);
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.countToolStripMenuItem.Text = "Count";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.CountToolStripMenuItem_Click);
            // 
            // finishToolStripMenuItem
            // 
            this.finishToolStripMenuItem.Name = "finishToolStripMenuItem";
            this.finishToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.finishToolStripMenuItem.Text = "Finish";
            this.finishToolStripMenuItem.Click += new System.EventHandler(this.FinishToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(400, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 334);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Lab1_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab1_7";
            this.Text = "Lab1-7-Form-1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTheMinimumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTheMaximumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}