namespace BepInExConfigEditor
{
    partial class BepInExConfigManagerMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BepInExConfigManagerMain));
            this.pathText = new System.Windows.Forms.TextBox();
            this.BrowseButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReloadButton = new FontAwesome.Sharp.IconButton();
            this.FileListMenu = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathText
            // 
            resources.ApplyResources(this.pathText, "pathText");
            this.pathText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(67)))));
            this.pathText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathText.ForeColor = System.Drawing.Color.Black;
            this.pathText.Name = "pathText";
            this.pathText.TextChanged += new System.EventHandler(this.pathText_TextChanged);
            // 
            // BrowseButton
            // 
            resources.ApplyResources(this.BrowseButton, "BrowseButton");
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(247)))));
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.BrowseButton.IconColor = System.Drawing.Color.White;
            this.BrowseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BrowseButton.IconSize = 20;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.TabStop = false;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Controls.Add(this.FileListMenu);
            this.panel1.Name = "panel1";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(247)))));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveButton.IconColor = System.Drawing.Color.White;
            this.SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Name = "panel3";
            // 
            // ReloadButton
            // 
            resources.ApplyResources(this.ReloadButton, "ReloadButton");
            this.ReloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(247)))));
            this.ReloadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReloadButton.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.ReloadButton.IconColor = System.Drawing.Color.White;
            this.ReloadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // FileListMenu
            // 
            resources.ApplyResources(this.FileListMenu, "FileListMenu");
            this.FileListMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(193)))));
            this.FileListMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileListMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.FileListMenu.FormattingEnabled = true;
            this.FileListMenu.Name = "FileListMenu";
            this.FileListMenu.SelectedIndexChanged += new System.EventHandler(this.FileListMenu_SelectedIndexChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.richTextBox);
            this.panel2.Name = "panel2";
            // 
            // richTextBox
            // 
            resources.ApplyResources(this.richTextBox, "richTextBox");
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(67)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // BepInExConfigManagerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.pathText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BepInExConfigManagerMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pathText;
        private FontAwesome.Sharp.IconButton BrowseButton;
        private Panel panel1;
        private Panel panel2;
        private ListBox FileListMenu;
        private FontAwesome.Sharp.IconButton ReloadButton;
        private RichTextBox richTextBox;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton SaveButton;
    }
}