namespace DockingToolbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtn2 = new System.Windows.Forms.ToolStripButton();
            this.tsbtn3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtMessage);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(560, 512);
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 12);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(560, 537);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn1,
            this.tsbtn2,
            this.tsbtn3,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(5, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(134, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn1
            // 
            this.tsbtn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn1.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn1.Image")));
            this.tsbtn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn1.Name = "tsbtn1";
            this.tsbtn1.Size = new System.Drawing.Size(23, 22);
            this.tsbtn1.Text = "toolStripButton1";
            this.tsbtn1.Click += new System.EventHandler(this.tsbtn1_Click);
            // 
            // tsbtn2
            // 
            this.tsbtn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn2.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn2.Image")));
            this.tsbtn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn2.Name = "tsbtn2";
            this.tsbtn2.Size = new System.Drawing.Size(23, 22);
            this.tsbtn2.Text = "toolStripButton2";
            this.tsbtn2.Click += new System.EventHandler(this.tsbtn2_Click);
            // 
            // tsbtn3
            // 
            this.tsbtn3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn3.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn3.Image")));
            this.tsbtn3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn3.Name = "tsbtn3";
            this.tsbtn3.Size = new System.Drawing.Size(23, 22);
            this.tsbtn3.Click += new System.EventHandler(this.tsbtn3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel1.Text = "lbl";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(36, 14);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(217, 21);
            this.txtMessage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn1;
        private System.Windows.Forms.ToolStripButton tsbtn2;
        private System.Windows.Forms.ToolStripButton tsbtn3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txtMessage;

    }
}

