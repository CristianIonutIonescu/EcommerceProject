using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarkdownSharp;
using SelectPdf;


namespace MarkDownApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Handlers

        // <summary>
        // openToolStripMenuItem_Click
        // Handler for Opening a file
        // </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Markdown (*.md)|*md|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            this.TextArea.Text = new StreamReader(myStream).ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        // <summary>
        // saveToolStripMenuItem_Click
        // Handler for Saving a file
        // </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFile(true);
        }

        // <summary>
        // newToolStripMenuItem_Click
        // Handler for creating a new file
        // </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Clear();
        }

        // <summary>
        // saveAsToolStripMenuItem_Click
        // Handler for saving as a specific format
        // </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFile(false);
        }

        // <summary>
        // saveFile
        // Function that saves the existing content
        // /param cameFromSave (Boolean): parameters which specifies if the save command came from save or save as handler
        // </summary>
        private void saveFile(Boolean cameFromSave)
        {
            // if the command didn't came from save or the file has not been saved yet open save dialog
            if (!cameFromSave || !this.TextArea.Saved)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "*.txt";
                saveFileDialog1.Filter = "Markdown |*.md|HTML |*.html|PDF |*.pdf|Text File |*.txt";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    string extension = Path.GetExtension(saveFileDialog1.FileName);

                    // if the desired extension is "html" compile the code with markdown
                    if (extension == ".html" || extension == "html")
                    {
                        Markdown compiler = new Markdown(true);

                        string output = compiler.Transform(this.TextArea.Text);
                        System.IO.File.WriteAllText(@"" + saveFileDialog1.FileName, output);
                    }
                    else if(extension == ".pdf" || extension == "pdf")
                    {
                        Markdown compiler = new Markdown(true);
                        string output = compiler.Transform(this.TextArea.Text);
                        PdfWrite(output, saveFileDialog1.FileName);
                    }
                    // else save the file in the desired format - .md or .txt
                    else
                    {
                        System.IO.File.WriteAllText(@"" + saveFileDialog1.FileName, this.TextArea.Text);
                        this.TextArea.Saved = true;
                        this.TextArea.FileName = saveFileDialog1.FileName;
                    }

                    if(extension != ".md")
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = saveFileDialog1.FileName,
                            UseShellExecute = true,
                            Verb = "open"
                        });
                    }
                }
            }
            // command came from save and the file was already saved
            else
            {
                System.IO.File.WriteAllText(@"" + this.TextArea.FileName, this.TextArea.Text);
            }
        }

        // <summary>
        // exitToolStripMenuItem_Click
        // Handler for exiting the application
        // </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // <summary>
        // Headings1ToolStripMenuItem_Click
        // Handler for formating the text with Headings1
        // </summary>
        private void Headings1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.HandleHeadings(MarkDownApplication.GUI.TextOptions.Heading1);
        }

        // <summary>
        // Headings2ToolStripMenuItem_Click
        // Handler for formating the text with Headings2
        // </summary>
        private void Headings2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.HandleHeadings(MarkDownApplication.GUI.TextOptions.Heading2);
        }

        // <summary>
        // Headings3ToolStripMenuItem_Click
        // Handler for formating the text with Headings3
        // </summary>
        private void Headings3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.HandleHeadings(MarkDownApplication.GUI.TextOptions.Heading3);
        }

        // <summary>
        // BoldToolStripMenuItem_Click
        // Handler for formating the text with bold
        // </summary>
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.HandleBoldAndItalic(MarkDownApplication.GUI.TextOptions.Bold);
        }

        // <summary>
        // ItalicToolStripMenuItem_Click
        // Handler for formating the text with italic
        // </summary>
        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.HandleBoldAndItalic(MarkDownApplication.GUI.TextOptions.Italic);
        }

        private void PdfWrite(string HtmlStream, string FileName)
        {
            // instantiate the html to pdf converter 
            HtmlToPdf converter = new HtmlToPdf();
            SelectPdf.GlobalProperties.HtmlEngineFullPath = "D:\\Visual studio 2013 projects\\EcommerceProject\\MarkDownApplication\\Dependicies\\Select.Html.dep";

            // convert the url to pdf 
            PdfDocument doc = converter.ConvertHtmlString(HtmlStream);

            // save pdf document 
            doc.Save(FileName);

            // close pdf document 
            doc.Close();
        }

        #endregion
    }
}
