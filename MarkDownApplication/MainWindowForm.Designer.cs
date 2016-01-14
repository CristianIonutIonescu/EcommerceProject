﻿namespace MarkDownApplication
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextArea = new MarkDownApplication.GUI.MarkDownTextEditor();
            this.MainContainer = new MarkDownApplication.GUI.MarkdownMenuStrip();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.AcceptsTab = true;
            this.TextArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextArea.AutoWordSelection = true;
            this.TextArea.BackColor = System.Drawing.Color.LightGray;
            this.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextArea.EnableAutoDragDrop = true;
            this.TextArea.Location = new System.Drawing.Point(27, 28);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(909, 461);
            this.TextArea.TabIndex = 4;
            this.TextArea.Text = "";
            // 
            // MainContainer
            // 
            this.MainContainer.BackColor = System.Drawing.Color.Transparent;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.None;
            this.MainContainer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(100, 25);
            this.MainContainer.TabIndex = 1;
            this.MainContainer.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.TextArea);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MainMenuStrip = this.MainContainer;
            this.Name = "MainWindow";
            this.Text = "MarkDown";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.MainContainer.FileToolStripMenuItem.NewToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            this.MainContainer.FileToolStripMenuItem.OpenToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.MainContainer.FileToolStripMenuItem.SaveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.MainContainer.FileToolStripMenuItem.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            this.MainContainer.FileToolStripMenuItem.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            this.MainContainer.EditToolStripMenuItem.UndoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            this.MainContainer.EditToolStripMenuItem.RedoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            this.MainContainer.EditToolStripMenuItem.CopyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            this.MainContainer.EditToolStripMenuItem.CutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            this.MainContainer.EditToolStripMenuItem.PasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            this.MainContainer.EditToolStripMenuItem.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
        }

        #endregion

        private MarkDownApplication.GUI.MarkDownTextEditor TextArea;
        private MarkDownApplication.GUI.MarkdownMenuStrip MainContainer;
    }
}

