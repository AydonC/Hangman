
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Hangman
{
    public partial class MainGamescreen : Form
    {
        public MainGamescreen()
        {
           
            InitializeComponent();
            
            
        }
        
        string word = ""; 
        List<Label> labels = new List<Label>(); // creating list for labels
        int amount = 0;
        

        enum hangmanparts //initializing parts for the hangman
        {
            bottompost,
            verticlepost,
            toppost,
            downpost,
            head,
            body,
            armOne,
            armTwo,
            legOne,
            legTwo
        }

        void displayHangman() //displayig bodyparts for hangman
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            drawingParts(hangmanparts.bottompost);
            drawingParts(hangmanparts.verticlepost);
            drawingParts(hangmanparts.toppost);
            drawingParts(hangmanparts.downpost);
            drawingParts(hangmanparts.head);
            drawingParts(hangmanparts.body);
            drawingParts(hangmanparts.armOne);
            drawingParts(hangmanparts.armTwo);
            drawingParts(hangmanparts.legOne);
            drawingParts(hangmanparts.legTwo);
            




        }

        void drawingParts(hangmanparts dp) //drawing the hangman parts
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            if (dp == hangmanparts.bottompost)
                g.DrawLine(p, new Point(50, 218), new Point(130, 218));
            else if (dp == hangmanparts.verticlepost)
                g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            else if (dp == hangmanparts.toppost)
                g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            else if (dp == hangmanparts.downpost)
                g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            else if (dp == hangmanparts.head)
                g.DrawEllipse(p, 40, 50, 40, 40);
            else if (dp == hangmanparts.body)
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            else if (dp == hangmanparts.armOne)
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            else if (dp == hangmanparts.armTwo)
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            else if (dp == hangmanparts.legOne)
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            else if (dp == hangmanparts.legTwo)
                g.DrawLine(p, new Point(60, 170), new Point(90,190));
        }

        void makeLabels() // making labels for words
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray();
            int between = 440 / chars.Length ;
            for (int i = 0; i < chars.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 80);
                labels[i].Text = "_";
                labels[i].Parent = groupBoxMain;
                labels[i].BringToFront();
                labels[i].CreateControl();

                Length.Text = "Word Length: " + (chars.Length ).ToString();
            }
        }


        string GetRandomWord() //getting a random word to display
        { 
            WebClient wc = new WebClient(); //adding webclient to retrieve list of words
            string wordlist = wc.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
            string[] words = wordlist.Split('\n');
            Random ran = new Random();
            return words[ran.Next(0,words.Length)]; // gives random words

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
          displayHangman();
          makeLabels();
            

        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            char letter = Letters.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("You can only submit letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //making sure user only types in letters
                return;
            }
            if (word.Contains(letter))
            { 
                char[] letters = word.ToCharArray();
                CorrectLetters.Text += " " + letter.ToString() + ",";
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                        labels[i].Text = letter.ToString();
                }
                foreach (Label l in labels)
                    if (l.Text == "_") return;
                
                MessageBox.Show("You have Won!");
                ResetGame(); //resets game
                

            }
            
            else
            {
                
                MissedLetters.Text += " " + letter.ToString() + ",";
                drawingParts((hangmanparts)amount);
                amount++;
                if (amount == 10) // amount of times a user can guess
                {
                    MessageBox.Show("You Lost! The Word was " + word);
                    ResetGame2();
                }
            }


            
        } 
        void ResetGame() // resets the game
         {
            Scoreboard.Items.Add(word + " " + amount); //adding scores with amount of guesses to list
            
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            amount = 0;
            GetRandomWord();
            makeLabels();
            MissedLetters.Text = "Missed: ";
            CorrectLetters.Text = "Correct: ";
            Letters.Text = "";
            
        }

        void ResetGame2() // resets the game
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            amount = 0;
            GetRandomWord();
            makeLabels();
            MissedLetters.Text = "Missed: ";
            CorrectLetters.Text = "Correct: ";
            Letters.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Scoreboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] amounts = new int[amount];

            var tempList = new List<int>(amounts);
            int newScore = 0;
            tempList.Add(newScore);

            amounts = tempList.OrderByDescending(x => x) //sorting scores from high to low
                             .Take(5)
                             .ToArray();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the application
        }
    }

  


      
    }

