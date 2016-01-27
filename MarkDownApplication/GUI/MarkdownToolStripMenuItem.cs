using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    // <summary>
    // MarkdownToolStripMenuItem
    // Base Class for ToolStripMenuItem
    // </summary>
    class MarkdownToolStripMenuItem : System.Windows.Forms.ToolStripMenuItem
    {
        public MarkdownToolStripMenuItem()
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
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        #endregion
    }
}
