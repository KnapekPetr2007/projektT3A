using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Test01
{
    public partial class Form1 : Form
    {
        // --- GLOBAL GAME STATE VARIABLES ---
        // Used to select a random word from the word database
        Random rng = new Random();

        // Difficulty selection (1: Easy, 2: Medium, 3: Hard)
        int difficulty = 0;

        // Currently choosen word and underscores
        string selectedWord = "";
        string currentStatus = "";

        // Mistake counter with maximum of allowed mistakes
        int errorCount = 0;
        int maxErrors = 10;

        // Game status (1: Game is running, 0: Game is paused or ended)
        int gameActive = 0;

        // Used to hide the reset button if it is the first game played (1: Shown, 0: Hidden)
        int firstGamePlayed = 0;

        // Word storage categorized by difficulty level
        Dictionary<string, string[]> wordDatabase = new Dictionary<string, string[]>
        {
            { "Easy", new string[] {
                "APPLE", "DOG", "HOUSE", "BIRD", "SUN", "FISH", "CAT", "TREE", "MOON", "CAKE",
                "BALL", "FROG", "BOOK", "MILK", "HAND", "STAR", "BOAT", "FIRE", "DUCK", "SNOW",
                "RAIN", "COW", "SHOE", "LAMP", "DOOR", "RING", "LEAF", "BEAR", "PIG", "CUP",
                "DESK", "BIKE"
            } },
            { "Medium", new string[] {
                "COMPUTER", "KEYBOARD", "MOUNTAIN", "WINDOW", "GARDEN", "KITCHEN", "SILENCE", "JOURNEY",
                "BICYCLE", "WEATHER", "PICTURE", "HAMMER", "COUNTRY", "PENCIL", "PLASTIC", "FLOWER",
                "MORNING", "TURTLE", "BOTTLE", "ORANGE", "SCHOOL", "BRIDGE", "ROCKET", "GUITAR",
                "PLANET", "COFFEE", "TICKET", "DIAMOND", "BANANA", "FOREST", "PLAYER"
            } },
            { "Hard", new string[] {
                "ARCHITECTURE", "STRENGTH", "RHYTHM", "SYNCHRONIZE", "ABBREVIATION", "AMBIDEXTROUS", "BENEVOLENT", "CHARACTERISTIC",
                "CONNOISSEUR", "DIFFERENTIATION", "ENTHUSIASTIC", "FLUORESCENT", "HYPOTHETICAL", "IMPOSSIBLE", "JUXTAPOSITION", "KALEIDOSCOPE",
                "LABYRINTHINE", "METAMORPHOSIS", "NEIGHBORHOOD", "OSCILLATION", "PHENOMENON", "QUESTIONNAIRE", "RENAISSANCE", "SOPHISTICATED",
                "THERMODYNAMICS", "UNBELIEVABLE", "VOCABULARY", "WHIMSICAL", "XENOPHOBIA", "YESTERDAY", "ZOOLOGY", "PHILANTHROPY"
            } }
        };

        public Form1()
        {
            InitializeComponent();
            ManualEventWiring();
            resetToolStripMenuItem.Visible = false;
        }

        // Connects designer controls to their respective code logic
        private void ManualEventWiring()
        {
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            endToolStripMenuItem.Click += endToolStripMenuItem_Click;
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;

            // Automatically finds and links all alphabet buttons starting with "but"
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("but"))
                {
                    c.Click -= Hra_Click;
                    c.Click += Hra_Click;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asd.Text = "Reffer to the Help menu";
        }

        // Sets up a new game session with a random word
        private void InitializeGame()
        {
            if (difficulty == 0)
            {
                MessageBox.Show("You need to sellect the difficulty first", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            gameActive = 1;
            if (firstGamePlayed == 1) resetToolStripMenuItem.Visible = true;

            string levelKey = difficulty == 3 ? "Hard" : (difficulty == 2 ? "Medium" : "Easy");
            selectedWord = wordDatabase[levelKey][rng.Next(wordDatabase[levelKey].Length)].ToUpper();
            currentStatus = new string('_', selectedWord.Length);
            errorCount = 0;

            UpdateDisplay();
            ResetVirtualKeyboard();
            Sibenice.Invalidate();
        }

        // Refreshes the label with the current word progress
        private void UpdateDisplay()
        {
            asd.Text = string.Join(" ", currentStatus.ToCharArray());
        }

        // Logic triggered when a letter button is clicked
        private void Hra_Click(object sender, EventArgs e)
        {
            if (gameActive == 0) return;

            Button btn = sender as Button;
            if (btn == null) return;

            string letterStr = btn.Text.Trim();
            if (string.IsNullOrEmpty(letterStr) && btn.Name.Length >= 4)
                letterStr = btn.Name.Substring(3, 1);

            if (string.IsNullOrEmpty(letterStr)) return;

            char guessedLetter = letterStr.ToUpper()[0];
            btn.Enabled = false;

            // Check if the guessed letter exists in the word
            if (selectedWord.Contains(guessedLetter))
            {
                char[] statusArray = currentStatus.ToCharArray();
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guessedLetter) statusArray[i] = guessedLetter;
                }
                currentStatus = new string(statusArray);
                UpdateDisplay();

                // Win condition check
                if (!currentStatus.Contains('_'))
                {
                    gameActive = 0;
                    firstGamePlayed = 1;
                    resetToolStripMenuItem.Visible = true;
                    MessageBox.Show("Výhra! Slovo bylo: " + selectedWord, "Gratulace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Wrong guess adds to the hangman drawing
                errorCount++;
                Sibenice.Invalidate();

                // Loss condition check
                if (errorCount >= maxErrors)
                {
                    gameActive = 0;
                    firstGamePlayed = 1;
                    resetToolStripMenuItem.Visible = true;
                    MessageBox.Show("Prohra! Slovo bylo: " + selectedWord, "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        // Handles the visual rendering of the hangman character
        private void Sibenice_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 4))
            {
                int w2 = Sibenice.Width / 2;

                // Draw ground base
                e.Graphics.DrawLine(pen, w2 - 120, 240, w2 + 120, 240);

                // Draw gallows and man based on error count
                if (errorCount >= 1) e.Graphics.DrawLine(pen, w2 - 60, 240, w2 - 60, 40);
                if (errorCount >= 2) e.Graphics.DrawLine(pen, w2 - 60, 40, w2 + 40, 40);
                if (errorCount >= 3) e.Graphics.DrawLine(pen, w2 - 60, 80, w2 - 20, 40);
                if (errorCount >= 4) e.Graphics.DrawLine(pen, w2 + 40, 40, w2 + 40, 70);
                if (errorCount >= 5) e.Graphics.DrawEllipse(pen, w2 + 25, 70, 30, 30);
                if (errorCount >= 6) e.Graphics.DrawLine(pen, w2 + 40, 100, w2 + 40, 170);
                if (errorCount >= 7) e.Graphics.DrawLine(pen, w2 + 40, 115, w2 + 15, 145);
                if (errorCount >= 8) e.Graphics.DrawLine(pen, w2 + 40, 115, w2 + 65, 145);
                if (errorCount >= 9) e.Graphics.DrawLine(pen, w2 + 40, 170, w2 + 15, 210);
                if (errorCount >= 10) e.Graphics.DrawLine(pen, w2 + 40, 170, w2 + 65, 210);
            }
        }

        // Reactivates all alphabet buttons for a new round
        private void ResetVirtualKeyboard()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("but")) c.Enabled = true;
            }
        }

        // Menu item click handlers
        private void startToolStripMenuItem_Click(object sender, EventArgs e) => InitializeGame();
        private void resetToolStripMenuItem_Click(object sender, EventArgs e) => InitializeGame();
        private void endToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            SetMenuChecks(1, 0, 0);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            SetMenuChecks(0, 1, 0);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            SetMenuChecks(0, 0, 1);
        }

        // Updates the checkmarks in the difficulty menu
        private void SetMenuChecks(int e, int m, int h)
        {
            easyToolStripMenuItem.Checked = (e == 1);
            mediumToolStripMenuItem.Checked = (m == 1);
            hardToolStripMenuItem.Checked = (h == 1);
        }

        private void asd_Click(object sender, EventArgs e) { }

        // Displays game manual
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"How to Play:
-------------------------------------------------------------------------------
1. Select the difficulty level in the 'Difficulty' menu.
2. Click 'Start' in the 'Actions' menu to begin.
3. Guess letters using the on-screen keyboard.
4. If you've played at least one game, use 'Reset' in the Actions menu to play again.
5. To exit, select 'Exit' in the 'Actions' menu.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // Displays credits and version info
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Hangman v1.0.5
-------------------------------------------------------------------------------
Developed in: Visual Studio 2022
Platform: .NET 8.0
Autor: Petr Knápek
Class: T3A
Subject: PRG
School year: 2025/2026
School: SPŠEI Frenštát Pod Radhoštìm, pøízpìvková organizace


{DateTime.Now.Year} No rights reserved.", "About Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}