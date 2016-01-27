using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    // <summary>
    // TextProperties
    // Class which handles the text editing properties of the text
    // </summary>
    class TextProperties : System.Windows.Forms.ContextMenuStrip
    {
        // constructor
        public TextProperties()
        {
            this.InitializeComponents();
        }

        // constructor
        // /param container (System.ComponentModel.IContainer) container that hold the MenuStrip
        public TextProperties(System.ComponentModel.IContainer container) : base(container)
        {
            this.InitializeComponents();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponents()
        {
            this.Header1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Header2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Header3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Italic = new System.Windows.Forms.ToolStripMenuItem();

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
            this.Italic});
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
            this.Header1.Text = "Header1";
            this.Header1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            // 
            // Header2
            // 
            this.Header2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Header2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Header2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Header2.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(103, 26);
            this.Header2.Text = "Header2";
            this.Header2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            // 
            // Header3
            // 
            this.Header3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Header3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Header3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Header3.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Header3.Name = "Header3";
            this.Header3.Size = new System.Drawing.Size(103, 26);
            this.Header3.Text = "Header3";
            this.Header3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripSeparator1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // Bold
            // 
            this.Bold.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Bold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(103, 26);
            this.Bold.Text = "Bold";
            this.Bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // Italic
            // 
            this.Italic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Italic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Italic.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(103, 26);
            this.Italic.Text = "Italic";
            this.Italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem _Header1;

        public System.Windows.Forms.ToolStripMenuItem Header1
        {
            get { return _Header1; }
            set { _Header1 = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem _Header2;

        public System.Windows.Forms.ToolStripMenuItem Header2
        {
            get { return _Header2; }
            set { _Header2 = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem _Header3;

        public System.Windows.Forms.ToolStripMenuItem Header3
        {
            get { return _Header3; }
            set { _Header3 = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem _Bold;

        public System.Windows.Forms.ToolStripMenuItem Bold
        {
            get { return _Bold; }
            set { _Bold = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem _Italic;

        public System.Windows.Forms.ToolStripMenuItem Italic
        {
            get { return _Italic; }
            set { _Italic = value; }
        }
        
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
