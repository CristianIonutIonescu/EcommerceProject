namespace MarkDownApplication
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
            this.components = new System.ComponentModel.Container();
            this.TextArea = new MarkDownApplication.GUI.MarkDownTextEditor();
            this.TextProperties = new MarkDownApplication.GUI.TextProperties(this.components);

            this.MainContainer = new MarkDownApplication.GUI.MarkdownMenuStrip();
            this.TextProperties.SuspendLayout();
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
            this.TextArea.ContextMenuStrip = this.TextProperties;
            this.TextArea.EnableAutoDragDrop = true;
            this.TextArea.Location = new System.Drawing.Point(27, 28);
            this.TextArea.Name = "TextArea";
            this.TextArea.Saved = false;
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
            this.MainContainer.Size = new System.Drawing.Size(102, 25);
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
            this.TextProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarkDownApplication.GUI.MarkDownTextEditor TextArea;
        private MarkDownApplication.GUI.MarkdownMenuStrip MainContainer;
        private MarkDownApplication.GUI.TextProperties TextProperties;

    }
}

