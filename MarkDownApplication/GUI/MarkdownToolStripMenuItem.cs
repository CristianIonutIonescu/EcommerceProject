using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    class MarkdownToolStripMenuItem : System.Windows.Forms.ToolStripMenuItem
    {
        public MarkdownToolStripMenuItem()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
