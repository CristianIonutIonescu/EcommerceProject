using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkdownSharp;

namespace MarkDownApplication.GUI
{
    //<Summary>
    //Text options
    // Enum in which available text options are set
    public enum TextOptions
    {
        Heading1,
        Heading2,
        Heading3,
        Bold,
        Italic,
        NoOption
    }

    //<summary>
    //MarkDownTextEditor
    //The TextBox where the user writes
    //</summary>
    public class MarkDownTextEditor : System.Windows.Forms.RichTextBox
    {
        // Constructor
        public MarkDownTextEditor()
        {
            InitializeComponents();
            Saved = false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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

        #endregion

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

        // <summary>
        // HandleHeadings
        // Function that handles Heading Options for the text
        // </summary>
        // \param headingOption(TextOptions)
        // \return void
        public void HandleHeadings(TextOptions headingOption)
        {
            string headingType = "";
            // find the appropiate header
            switch(headingOption)
            {
                case TextOptions.Heading1:
                    headingType = "#";
                    break;
                case TextOptions.Heading2:
                    headingType = "##";
                    break;
                case TextOptions.Heading3:
                    headingType = "###";
                    break;
            }

            // check if the user wants to add the header to an existing text
            // this.SelectedText.Length > 0: true  -- adding to an existing(selected) text
            //                               false -- no text is selected
            if (this.SelectedText.Length > 0)
            {
                TextOptions headingFound = new TextOptions();

                // clean the current headers from the existing text
                string selectedText = CleanHeaders(this.SelectedText,ref headingFound);
                string newText = "";

                // check if the user wants to remove the header or replace it
                if(headingFound == headingOption)
                {
                    newText = selectedText;
                }
                else
                {
                    newText = headingType + selectedText;
                }

                // replace the text with the appropiate option
                this.SelectedText = this.SelectedText.Replace(this.SelectedText, newText);
            }
            else
            {
                //simply add the apropiate header option
                this.SelectedText = headingType;
            }
        }

        // <summary>
        // HandleBoldAndItalic
        // Function that handles Bold and Italic Options for the text
        // </summary>
        // \param textOption(TextOptions)
        // \return void
        public void HandleBoldAndItalic(TextOptions textOption)
        {
            // switch to the chosen option
            switch(textOption)
            {
                case TextOptions.Bold:
                    HandleBold();
                    break;
                case TextOptions.Italic:
                    HandleItalic();
                    break;
            }
        }

        // <summary>
        // HandleBold
        // Function that handles Bold Options for the text
        // </summary>
        // \return void
        private void HandleBold()
        {
            // check if the user wants to add the header to an existing text
            // this.SelectedText.Length > 0: true  -- adding to an existing(selected) text
            //                               false -- no text is selected
            if (this.SelectedText.Length > 0)
            {
                string selectedText = this.SelectedText;
                string newText = "";

                // check if already bolded
                // if true : remove bold
                // else add bold
                if (selectedText.Length > 1 && selectedText.Substring(0, 2) == "**")
                {
                    newText = CleanBold(this.SelectedText);
                }
                else
                {
                    newText = "**" + selectedText + "**";
                }
                this.SelectedText = this.SelectedText.Replace(this.SelectedText, newText);
            }
            else
            {
                // no text is selected, add bold
                this.SelectedText = "****";
                // place the caret in the middle so that the user can start writing immidiatly
                this.SelectionStart -= 2;
            }
        }

        // <summary>
        // HandleItalic
        // Function that handles Italic Options for the text
        // </summary>
        // \return void
         private void HandleItalic()
        {
            // check if the user wants to add the header to an existing text
            // this.SelectedText.Length > 0: true  -- adding to an existing(selected) text
            //                               false -- no text is selected
            if (this.SelectedText.Length > 0)
            {
                string selectedText = this.SelectedText;
                string newText = "";
                // check if already italic
                // if true : remove italic
                // else add italic
                if (selectedText.Substring(0, 1) == "*")
                {
                    newText = CleanItalic(this.SelectedText);
                }
                else
                {
                    newText = "*" + selectedText + "*";
                }

                this.SelectedText = this.SelectedText.Replace(this.SelectedText, newText);
            }
            else
            {
                // no text is selected, add italic
                this.SelectedText = "**";
                // place the caret in the middle so that the user can start writing immidiatly
                this.SelectionStart -= 1;
            }
        }

         // <summary>
         // CleanHeaders
         // Function that removes all existing headers from text
         // </summary>
         // \param currentString: the string that needs to be cleanead
         // \param headingFound: the heading that will be found during cleaning
         // \return string : selected text without heading format
        private string CleanHeaders(string currentString, ref TextOptions headingFound)
        {
            //counts how many "#" are removed to determine the heading type
            int numberRemovals = 0;

            // while there are headings in the selected text remove them
            while (currentString.Substring(0, 1) == "#")
            {
                currentString = currentString.Remove(0, 1);
                numberRemovals++;

            }

            //set the appropiate heading option
            switch(numberRemovals)
            {
                case 0:
                    headingFound = TextOptions.NoOption;
                    break;
                case 1:
                    headingFound = TextOptions.Heading1;
                    break;
                case 2:
                    headingFound = TextOptions.Heading2;
                    break;
                case 3:
                    headingFound = TextOptions.Heading3;
                    break;
            }
            return currentString;
        }

        // <summary>
        // CleanItalic
        // Function that removes the italic format from it
        // </summary>
        // \param currentString: the string that needs to be cleanead
        // \return string: selected text without italic format
        private string CleanItalic(string currentString)
        {
            // remove any occurance of * in the text
            string newString = currentString.Remove(0, 1);
            newString = newString.Remove(newString.Length - 1);
            return newString;
        }

        // <summary>
        // CleanBold
        // Function that removes the bold format from it
        // </summary>
        // \param currentString: the string that needs to be cleanead
        // \return string: selected text without bold format
        private string CleanBold(string currentString)
        {
            string newString = currentString.Remove(0, 2);
            newString = newString.Remove(newString.Length - 2);
            return newString;
        }
        
    }
}
