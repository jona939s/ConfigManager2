using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BepInExConfigEditor
{
    public partial class BepInExConfigManagerMain : Form
    {
        internal string path = @"";
        internal string startPath = Application.StartupPath;

        public BepInExConfigManagerMain()
        {
            InitializeComponent();
            loadPath();
            loadGuide();
        }

        private void loadGuide()
        {
            richTextBox.Text = "--=== How to use ===--\n\nPress the browse button to find your .cfg files I.e.  steamapps\\common\\Gorilla Tag\\BepInEx\\config" +
                "\n\nPress the reload button to load every config file in" +
                "\n\nPress a file in the left hierarchy and edit the text in the right window" +
                "\n\nRemember to save when you are done" +
                "\n\nThis text will go away when you open a file or delete it";
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                path = browser.SelectedPath;
                pathText.Text = path;

                savePath(path);
            }
            else
            {
                pathText.Text = "";
            }
        }

        private void fillListBox(ListBox lbs, string folder, string filetype)
        {
            DirectoryInfo dinfo = new DirectoryInfo(folder);
            FileInfo[] files = dinfo.GetFiles(filetype);
            foreach (FileInfo fi in files)
            {
                lbs.Items.Add(fi.Name);
            }
        }

        internal void loadPath()
        {
            try
            {
                StreamReader reader = new StreamReader(Application.StartupPath + "\\savedPath\\" + "Saved_path.txt");
                path = reader.ReadLine();
                pathText.Text = path;
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                path = e.Message;
                pathText.Text = "Please select a path using the browse button";
            }
        }

        internal void savePath(string pathToSave)
        {
            StreamWriter sw = new StreamWriter(startPath + "\\savedPath\\" + "Saved_path.txt");
            sw.WriteLine(pathToSave);
            sw.Close();
        }

        private void fillRichTextBox(ListBox lbs)
        {
            richTextBox.Text = File.ReadAllText(path + $"\\{lbs.SelectedItem}");
        }

        private void pathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            FileListMenu.Items.Clear();
            fillListBox(FileListMenu, path, "*.cfg"); 
        }

        private void FileListMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileListMenu.SelectedItems != null)
                fillRichTextBox(FileListMenu);
            else return;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String saveTxt = richTextBox.Text;
            StreamWriter sw = new StreamWriter(Path.Combine(path, $"{FileListMenu.SelectedItem}"));
            sw.Write(saveTxt);
            sw.Close();

            MessageBox.Show($"{FileListMenu.SelectedItem} has now been saved");
        }
    }
}