using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkdownSharp;

namespace MarkDownApplication.GUI
{

    public class TextOptions
    {
        public TextOptions()
        {
        }

        private Boolean bold;

        public Boolean Bold
        {
            get { return bold; }
            set { bold = value; }
        }

        private Boolean italic;

        public Boolean Italic
        {
            get { return italic; }
            set { italic = value; }
        }

        private Boolean underLine;

        public Boolean UnderLine
        {
            get { return underLine; }
            set { underLine = value; }
        }

        private Boolean strikeOut;

        public Boolean StrikeOut
        {
            get { return strikeOut; }
            set { strikeOut = value; }
        }

        private Boolean heading1;

        public Boolean Heading1
        {
            get { return heading1; }
            set { heading1 = value; }
        }

        private Boolean heading2;

        public Boolean Heading2
        {
            get { return heading2; }
            set { heading2 = value; }
        }

        private Boolean heading3;

        public Boolean Heading3
        {
            get { return heading3; }
            set { heading3 = value; }
        }

        public void Clear()
        {
            Bold = false;
            Italic = false;
            UnderLine = false;
            StrikeOut = false;
            Heading1 = false;
            Heading2 = false;
            heading3 = false;
        }
    }

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

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private TextOptions currentTextOptions;

        public TextOptions CurrentTextOptions
        {
            get { return currentTextOptions; }
            set { currentTextOptions = value; }
        }


        
    }
}
