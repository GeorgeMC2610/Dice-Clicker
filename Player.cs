using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_vathomologoumeni_1
{
    class Player
    {
        public string Name { get; set; }
        private int score;

        public int Score
        {
            get 
            {
                return this.score;
            }

            set
            {
                score = (value > 0) ? value : score;
            }
        }

        public static void SortHighScores()
        {
            //first, try to open the file
            StreamReader sr = new StreamReader("highscores.txt");
            string Reader = sr.ReadToEnd();

            //if the file opens, but there are barely any data inside it, don't do anything
            if (Reader.Length < 3)
                return;

            //otherwise we split the words by the line change and try to store it in this array.
            string[] allScores = Reader.Split('\n');

            //then we set three different arrays. One for the name of the score holder, one for the difficulty they played and one for their score.
            string[] name = new string[allScores.Length];
            string[] difficulty = new string[allScores.Length];
            int[] points = new int[allScores.Length];

            //to split the attributes, we use the '|' character inside the notepad, for easy extraction.
            for (int i = 0; i < allScores.Length; i++)
            {
                //each position of the arrays corresponds to the same person who played.
                string[] attributes = allScores[i].Split('|');

                name[i]       = attributes[0];
                difficulty[i] = attributes[1];
                points[i]     = int.Parse(attributes[2]);
            }


        }
    }
}
