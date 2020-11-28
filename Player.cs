using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp_vathomologoumeni_1
{
    class Player
    {
        public static void SortHighScores()
        {
            //first, try to open the file
            StreamReader sr = new StreamReader("highscores.txt");
            string Reader = sr.ReadToEnd();
            sr.Close();

            //if the file opens, but there are barely any data inside it, don't do anything
            if (Reader.Length < 5)
                return;

            //otherwise we split the words by the line change and try to store it in this array.
            string[] allScores = Reader.Split('\n');

            //then we set three different arrays. One for the name of the score holder, one for the difficulty they played and one for their score.
            string[] name       = new string[allScores.Length];
            string[] difficulty = new string[allScores.Length];
            int[] points        = new int[allScores.Length];

            if (allScores.Length == 0)
                return;

            //to split the attributes, we use the '|' character inside the notepad, for easy extraction.
            for (int i = 0; i < allScores.Length; i++)
            {
                //each position of the arrays corresponds to the same person who played.
                try
                {
                    string[] attributes = allScores[i].Split('|');

                    name[i] = attributes[0];
                    difficulty[i] = attributes[1];
                    points[i] = int.Parse(attributes[2]);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Invalid attributes were given in a highscore.\n\n" +
                        "Highscore value: " + string.Join(", ", allScores) + "\n\nException Message: " + ex.Message +
                        "\n\nCheck if there is a bare change of line or too many attributes somewhere in the textfile. \n\nGame will proceed without counting highscores.", "Invalid Highscore");

                    return;
                }
            }

            //then we sort the arrays by descending score
            //the sorting algorithm (Bubble Sort) has to be hardcoded, since we want to sort multiple arrays.
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = 0; j < points.Length - i - 1; j++)
                {
                    if (points[j] < points[j + 1])
                    {
                        int temp0     = points[j];
                        points[j]     = points[j + 1];
                        points[j + 1] = temp0;

                        string temp1  = name[j];
                        name[j]       = name[j + 1];
                        name[j + 1]   = temp1;

                        string temp2      = difficulty[j];
                        difficulty[j]     = difficulty[j + 1];
                        difficulty[j + 1] = temp2;
                    }
                }
            }

            //first we create a variable for each possible difficulty we encounter
            int easy_counter   = 0;
            int normal_counter = 0;
            int hard_counter   = 0;
            int expert_counter = 0;

            //in order to display the data to the other form, we need to use this loop
            for (int i = 0; i < name.Length; i++)
            {
                //and then we display the first five of each difficulty.
                //if there are less than five high score holders, the default value is three dashes ("---").
                if (difficulty[i].Equals("EASY") && easy_counter < 5)
                {
                    MainMenu.EasyHI[easy_counter] = name[i] + ", " + points[i].ToString() + " points";
                    easy_counter++;
                }

                else if (difficulty[i].Equals("NORMAL") && normal_counter < 5)
                {
                    MainMenu.NormalHI[normal_counter] = name[i] + ", " + points[i].ToString() + " points";
                    normal_counter++;
                }

                else if (difficulty[i].Equals("HARD") && hard_counter < 5)
                {
                    MainMenu.HardHI[hard_counter] = name[i] + ", " + points[i].ToString() + " points";
                    hard_counter++;
                }

                else if (difficulty[i].Equals("EXPERT") && expert_counter < 5)
                {
                    MainMenu.ExpertHI[expert_counter] = name[i] + ", " + points[i].ToString() + " points";
                    expert_counter++;
                }
            }
        }
    }
}
