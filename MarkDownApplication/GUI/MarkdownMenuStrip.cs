using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    //<summary>
    //MarkdownMenuStrip
    //Container for ToolStripMenuItems
    //</summary>
    class MarkdownMenuStrip : System.Windows.Forms.MenuStrip
    {
        //Constructor
        public MarkdownMenuStrip()
        {
            InitializeComponents();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponents()
        {
            fileToolStripMenuItem = new FileToolStripMenuItem();

            this.BackColor = System.Drawing.Color.Transparent;
            this.Dock = System.Windows.Forms.DockStyle.None;
            this.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainContainer";
            this.Size = new System.Drawing.Size(102, 25);
            this.TabIndex = 1;
            this.Text = "menuStrip1";
        }

        #endregion

        private FileToolStripMenuItem fileToolStripMenuItem;

        public FileToolStripMenuItem FileToolStripMenuItem
        {
            get { return fileToolStripMenuItem; }
            set { fileToolStripMenuItem = value; }
        }
    }
}
