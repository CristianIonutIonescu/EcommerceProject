using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    class EditToolStripMenuItem : MarkdownToolStripMenuItem
    {
        public EditToolStripMenuItem()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.Name = "editToolStripMenuItem";
            this.Size = new System.Drawing.Size(46, 21);
            this.Text = "&Edit";

            this.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});

            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // openToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.cutToolStripMenuItem.Text = "&Cut";
            // 
            // saveAsToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.copyToolStripMenuItem.Text = "&Copy";

            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Text = "&Select All";
        }


        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem
        {
            get { return undoToolStripMenuItem; }
            set { undoToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem
        {
            get { return redoToolStripMenuItem; }
            set { redoToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem
        {
            get { return cutToolStripMenuItem; }
            set { cutToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem
        {
            get { return copyToolStripMenuItem; }
            set { copyToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem
        {
            get { return pasteToolStripMenuItem; }
            set { pasteToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem
        {
            get { return selectAllToolStripMenuItem; }
            set { selectAllToolStripMenuItem = value; }
        }
        
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
