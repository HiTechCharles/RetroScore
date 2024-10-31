using System;
using System.IO;                 //file access
using System.Media;              //play system sounds
using System.Windows.Forms;     

namespace RetroScore
{
    public partial class AddScores : Form
    {
        public String GameToLoad = PickGame.GameSelected;  //file name for selected game
        
        public AddScores()
        {
            InitializeComponent();
            ScoreListLBL.Text = PickGame.GameName;  //put game name as text above listbox
            ReadFile();  //read file into listbox
        }

        private void AddScoreBTN_Click(object sender, EventArgs e)  //add button 
        {
            if (NewScoreTB.Text.Length > 0)  //if textbox length > 0
            {
                ScoreListLB.Items.Add(NewScoreTB.Text);  //add item to listbox
                NewScoreTB.Text = "";  //clear textbox, then
                NewScoreTB.Focus();  //put cursor back in textbox
            }
            else   //textbox length 0
            {
                SystemSounds.Beep.Play();  //play system sound
            }
        }

        private void DoneBTN_Click(object sender, EventArgs e)  //done button 
        {
            int TotalItems = ScoreListLB.Items.Count; //total listbox items
            int[] Scores = new int[TotalItems];  //array for sorting scores 
                    
            for (int i = 0; i < TotalItems; i++) //for each listbox item
            {
                Scores[i] = int.Parse((string)ScoreListLB.Items[i]);  //add each item to array
            }

            Array.Sort(Scores);  //sort scores
            Array.Reverse(Scores);  //high to low

            StreamWriter ScoreStore = new StreamWriter(GameToLoad);  //open score file

            for (int i=0; i<Scores.Length; i++)   //for each element
            
            {
                ScoreStore.WriteLine(Scores[i]); //write score to file
            }
            ScoreStore.Flush();  //ensure all file operation complete
            ScoreStore.Close();  //close file 
            DialogResult = DialogResult.OK;  //close the form
        }

        private void ReadFile ()  //read scores from file 
        {
            ScoreListLB.Items.Clear();  //clear listbox
            String Line;  //used for reading lines from file
            
            if ( File.Exists(GameToLoad) )   //if file exists
            {
                StreamReader ScoreRip = new StreamReader(GameToLoad);  //open score file

                while (!ScoreRip.EndOfStream)  //loop until end of file
                {
                    Line = ScoreRip.ReadLine();  //read a line from file
                    ScoreListLB.Items.Add(Line);  //add score to listbox
                }
                ScoreRip.Close();  //close file
            }
            else   //file does not exist, create one
            {
                StreamWriter ScoreStore = new StreamWriter(GameToLoad);  //open file
                ScoreStore.Close();  //close file, it will be empty for now
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)  //delete buttton
        {
            if ( ScoreListLB.SelectedIndex > -1 )   //if an item is selected in listbox
            { 
                ScoreListLB.Items.RemoveAt(ScoreListLB.SelectedIndex);  //remove selected score
                ScoreListLB.SelectedIndex = -1;  
            }
        else  //no item selected in listbox
            {
                SystemSounds.Beep.Play();  //play system sound
            }
        }
    }
}