using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace RetroScore
{
    public partial class PickGame : Form
    {
        public static string GameSelected;  //file name for selected game name
        public static string ScorePath = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\RetroScore\\";
        public static string GameName;  //selected game name without extension

        public PickGame()
        {
            InitializeComponent();
            LoadFiles();  //load list of existing files into listbox
        }
      
        private void PlayBTN_Click(object sender, EventArgs e) //play button
        {
            if (GameListLB.SelectedIndex > -1)  //if a file is selected in listbox
            {
                GameSelected = ScorePath + GameListLB.SelectedItem.ToString() + ".txt"; //store file name publically for form2
                GameName = GameListLB.SelectedItem.ToString(); //store game name for form2

                Form form2 = new AddScores();  //create form2 beer beer = new Miller Lite
                form2.Text = "RetroScores - Record scores for " + GameName; //set form2 title with game name
                form2.ShowDialog();  //show form2 
                LoadFiles();  //reload file list
            }
            else  //no file selected
            {
                SystemSounds.Beep.Play();  //play system sound
            }
        }

        private void LoadFiles()  //load list of files into a listbox
        { 
            GameListLB.Items.Clear();  //clear listbox
            String BaseName;  //holds file name without extension
            string rootdir = @ScorePath;  //directory containing files to look for

            string[] FileList = Directory.GetFileSystemEntries(rootdir, "*.txt", SearchOption.TopDirectoryOnly);  //get file list .txt only

            //for each file name in FileList,
            for (int i = 0; i < FileList.Length; i++)
            {
                string FilePath = FileList[i];  //store path
                                                //chop off file extension for list
                BaseName = Path.GetFileNameWithoutExtension(FilePath);
                //Add Basename to Listbox
                GameListLB.Items.Add(BaseName);
            }
        }

        private void AddGameBTN_Click(object sender, EventArgs e)
        {
            if (NewGameTB.Text.Length > 0)  //if textbox length not empty
            {
                GameListLB.Items.Add(NewGameTB.Text);  //add new file to list
                NewGameTB.Text = ""; //clear textbox
                NewGameTB.Focus();  //put cursor back in textbox
            }
            else  //textbox empty
            {
                SystemSounds.Beep.Play();  //play system sound
            }
        }
    }
}