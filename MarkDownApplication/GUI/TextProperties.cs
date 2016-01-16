using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    class TextProperties : System.Windows.Forms.ContextMenuStrip
    {
        public TextProperties()
        {
            this.InitializeComponents();
        }

        public TextProperties(System.ComponentModel.IContainer container) : base(container)
        {
            this.InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Header1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Header2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Header3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.StrikeOut = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // TextProperties
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.toolStripSeparator1,
            this.Bold,
            this.Italic,
            this.Underline,
            this.StrikeOut});
            this.Name = "TextProperties";
            this.Size = new System.Drawing.Size(104, 192);
            // 
            // Header1
            // 
            this.Header1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Header1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Header1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Header1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Header1.Name = "Header1";
            this.Header1.Size = new System.Drawing.Size(103, 26);
            this.Header1.Text = "H1";
            // 
            // Header2
            // 
            this.Header2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(103, 26);
            this.Header2.Text = "H2";
            // 
            // Header3
            // 
            this.Header3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Header3.Name = "Header3";
            this.Header3.Size = new System.Drawing.Size(103, 26);
            this.Header3.Text = "H3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(103, 26);
            this.Bold.Text = "B";
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(103, 26);
            this.Italic.Text = "I";
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Underline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(103, 26);
            this.Underline.Text = "U";
            // 
            // StrikeOut
            // 
            this.StrikeOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StrikeOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.StrikeOut.Name = "StrikeOut";
            this.StrikeOut.Size = new System.Drawing.Size(103, 26);
            this.StrikeOut.Text = "S";
        }

        private System.Windows.Forms.ToolStripMenuItem Header1;
        private System.Windows.Forms.ToolStripMenuItem Header2;
        private System.Windows.Forms.ToolStripMenuItem Header3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Bold;
        private System.Windows.Forms.ToolStripMenuItem Italic;
        private System.Windows.Forms.ToolStripMenuItem Underline;
        private System.Windows.Forms.ToolStripMenuItem StrikeOut;
    }
}
