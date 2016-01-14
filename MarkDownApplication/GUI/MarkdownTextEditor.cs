using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownApplication.GUI
{
    public class MarkDownTextEditor : System.Windows.Forms.RichTextBox
    {
        public MarkDownTextEditor()
        {
            InitializeComponents();
            Saved = false;
        }

        private void InitializeComponents()
        {
        // 
            // TextArea
            // 
            this.AcceptsTab = true;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoWordSelection = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnableAutoDragDrop = true;
            this.Location = new System.Drawing.Point(27, 0);
            this.Name = "TextArea";
            this.Size = new System.Drawing.Size(907, 489);
            this.TabIndex = 4;
            this.Text = "";
        }

        private Boolean saved;

        public Boolean Saved
        {
            get { return saved; }
            set { saved = value; }
        }
        
    }
}
