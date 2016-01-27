using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    // <summary>
    // Name FileTooStripMenuItem
    // Class which contains application properties:
    // New
    // Save
    // Save as
    // Open
    // Exit
    // <summary>
    class FileToolStripMenuItem : MarkdownToolStripMenuItem
    {
        //Constructor
        public FileToolStripMenuItem()
        {
            this.InitializeComponent();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.Name = "fileToolStripMenuItem";
            this.Size = new System.Drawing.Size(46, 21);
            this.Text = "&File";

            this.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});

            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.openToolStripMenuItem.Text = "&Open";
            
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem
        {
            get { return newToolStripMenuItem; }
            set { newToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem
        {
            get { return openToolStripMenuItem; }
            set { openToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem
        {
            get { return saveToolStripMenuItem; }
            set { saveToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem
        {
            get { return saveAsToolStripMenuItem; }
            set { saveAsToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem
        {
            get { return exitToolStripMenuItem; }
            set { exitToolStripMenuItem = value; }
        }
        
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
