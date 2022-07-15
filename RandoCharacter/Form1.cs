using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
line = streamReader.ReadLine();
name.Text = line;
*/


namespace RandoCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*StreamReader firstReader = new StreamReader("D:\\firstNames.txt");
                StreamReader middleReader = new StreamReader("D:\\middleNames.txt");
                StreamReader lastReader = new StreamReader("D:\\lastNames.txt");
                StreamReader abilitiesReader = new StreamReader("D:\\abilities.txt");*/

                System.Random rnd = new System.Random();
                int number = rnd.Next(0, 77);
                string line = File.ReadLines("D:\\firstNames.txt").Skip(number).Take(1).First();
                firstName.Text = line;

                //Random rnd = new Random();
                number = rnd.Next(0, 115);
                line = File.ReadLines("D:\\middleNames.txt").Skip(number).Take(1).First();
                middleName.Text = line;

                number = rnd.Next(0, 98);
                line = File.ReadLines("D:\\lastNames.txt").Skip(number).Take(1).First();
                lastName.Text = line;

                //abilities
                int holder = rnd.Next(1, 6);
                int numAbilities = holder;
                string[] abilitiesArray = new string[holder];

                for (int i = 0; i < holder; i++)
                {
                    number = rnd.Next(0, 663);
                    line = File.ReadLines("D:\\abilitiesWithGort.txt").Skip(number).Take(1).First();
                    abilitiesArray[i] = line;
                }

                string abilitiesString = string.Join("\n", abilitiesArray);
                abilities.Text = abilitiesString;

                //strengths
                holder = rnd.Next(1, 6);
                int numStrengths = holder;
                string[] strengthsArray = new string[holder];

                for (int i = 0; i < holder; i++)
                {
                    number = rnd.Next(0, 89);
                    line = File.ReadLines("D:\\strengths.txt").Skip(number).Take(1).First();
                    strengthsArray[i] = line;
                }

                string strengthsString = string.Join("\n", strengthsArray);
                strengths.Text = strengthsString;

                //weaknesses
                holder = rnd.Next(1, 6);
                int numWeaknesses = holder;
                string[] weaknessesArray = new string[holder];

                for (int i = 0; i < holder; i++)
                {
                    number = rnd.Next(0, 89);
                    line = File.ReadLines("D:\\weaknesses.txt").Skip(number).Take(1).First();
                    weaknessesArray[i] = line;
                }

                string weaknessesString = string.Join("\n", weaknessesArray);
                weaknesses.Text = weaknessesString;

                rating.Text = "Overall Rating: " + ((numAbilities + numStrengths) / numWeaknesses) + "/10";

                holder = rnd.Next(0, 500);

                if (holder == 1)
                {
                    Console.WriteLine("You got gort");
                    firstName.Text = "Gort (SUPER RARE)";
                    middleName.Text = "";
                    lastName.Text = "";

                    abilities.Text = "Created The Universe \nFour Counts of Homicide \nIs Probably in Your House as We Speak\nLust for Blood\nImmortal\nLiterally Gort";
                    strengths.Text = "Still Literally Gort\nPassionate Lover\nReligious\nNice Smile\nYou Lord and Saviour\nIn Gort We Trust";
                    weaknesses.Text = "There are None... \nGort has no Weaknesses";
                    rating.Text = "Overall Rating: 1000000000/10";
                }


            }
            catch
            {

            }
            finally
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
