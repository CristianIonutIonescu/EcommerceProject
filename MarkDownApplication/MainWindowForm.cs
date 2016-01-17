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

namespace MarkDownApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|Markdown (*.md)|*md|All files (*.*)|*.*";
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFile(true);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.SelectAll();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextArea.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFile(false);
        }

        private void saveFile(Boolean cameFromSave)
        {
            if (!cameFromSave || !this.TextArea.Saved)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "*.txt";
                saveFileDialog1.Filter = "Text File|*.txt|Markdown |*.md|HTML|*.html";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    string extension = Path.GetExtension(saveFileDialog1.FileName);
                    if (extension == ".html" || extension == "html")
                    {
                        Markdown compiler = new Markdown(true);

                        string output = compiler.Transform(this.TextArea.Text);
                        System.IO.File.WriteAllText(@"" + saveFileDialog1.FileName, output);
                    }
                    else
                    {
                        System.IO.File.WriteAllText(@"" + saveFileDialog1.FileName, this.TextArea.Text);
                        this.TextArea.Saved = true;
                        this.TextArea.FileName = saveFileDialog1.FileName;
                    }
                }
            }
            else
            {
                System.IO.File.WriteAllText(@"" + this.TextArea.FileName, this.TextArea.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
