using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Test01
{
    public partial class Form1 : Form
    {
        private Random rng = new Random();
        private int difficulty = 0; // 0 znamená, že ještì nebylo vybráno
        private string selectedWord = "";
        private string currentStatus = "";
        private int errorCount = 0;
        private const int maxErrors = 10;

        // Stavové promìnné pro logiku menu
        private bool gameActive = false;
        private bool firstGamePlayed = false;

        private Dictionary<string, string[]> wordDatabase = new Dictionary<string, string[]>
        {
            { "Easy", new string[] { "APPLE", "DOG", "HOUSE", "BIRD", "SUN" } },
            { "Medium", new string[] { "COMPUTER", "KEYBOARD", "MOUNTAIN", "WINDOW" } },
            { "Hard", new string[] { "ARCHITECTURE", "STRENGTH", "RHYTHM", "SYNCHRONIZE" } }
        };

        public Form1()
        {
            InitializeComponent();
            ManualEventWiring();

            // Na úplném zaèátku skryjeme Reset
            resetToolStripMenuItem.Visible = false;
        }

        private void ManualEventWiring()
        {
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            endToolStripMenuItem.Click += endToolStripMenuItem_Click;

            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;

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
            // Pøi startu nevyvoláváme InitializeGame, aby se nezaèalo bez obtížnosti
            asd.Text = "Vyberte obtížnost a Start";
        }

        private void InitializeGame()
        {
            // Kontrola, zda je vybrána obtížnost
            if (difficulty == 0)
            {
                MessageBox.Show("Nejdøíve musíte vybrat obtížnost v menu!", "Windows XP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            gameActive = true;

            // Pokud už se nìkdy hrálo, ukážeme Reset pro pøíštì
            if (firstGamePlayed)
            {
                resetToolStripMenuItem.Visible = true;
            }

            string levelKey = difficulty == 3 ? "Hard" : (difficulty == 2 ? "Medium" : "Easy");
            selectedWord = wordDatabase[levelKey][rng.Next(wordDatabase[levelKey].Length)].ToUpper();
            currentStatus = new string('_', selectedWord.Length);
            errorCount = 0;

            UpdateDisplay();
            ResetVirtualKeyboard();
            Sibenice.Invalidate();
        }

        private void UpdateDisplay()
        {
            asd.Text = string.Join(" ", currentStatus.ToCharArray());
        }

        private void Hra_Click(object sender, EventArgs e)
        {
            // Pokud hra nebìží (nebyl stisknut Start), tlaèítka nic nedìlají
            if (!gameActive) return;

            Button? btn = sender as Button;
            if (btn == null) return;

            string letterStr = btn.Text.Trim();
            if (string.IsNullOrEmpty(letterStr) && btn.Name.Length >= 4)
                letterStr = btn.Name.Substring(3, 1);

            if (string.IsNullOrEmpty(letterStr)) return;

            char guessedLetter = letterStr.ToUpper()[0];
            btn.Enabled = false;

            if (selectedWord.Contains(guessedLetter))
            {
                char[] statusArray = currentStatus.ToCharArray();
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guessedLetter) statusArray[i] = guessedLetter;
                }
                currentStatus = new string(statusArray);
                UpdateDisplay();

                if (!currentStatus.Contains('_'))
                {
                    gameActive = false;
                    firstGamePlayed = true;
                    resetToolStripMenuItem.Visible = true;
                    MessageBox.Show("Výhra! Slovo bylo: " + selectedWord, "Gratulace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                errorCount++;
                Sibenice.Invalidate();

                if (errorCount >= maxErrors)
                {
                    gameActive = false;
                    firstGamePlayed = true;
                    resetToolStripMenuItem.Visible = true;
                    MessageBox.Show("Prohra! Slovo bylo: " + selectedWord, "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Sibenice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = Sibenice.Width / 2;
            int groundY = 240;
            int topY = 40;
            int gallowsX = centerX - 60;
            int ropeX = centerX + 40;

            using (Pen pen = new Pen(Color.Black, 4))
            {
                // ZÁKLADNA
                g.DrawLine(pen, centerX - 120, groundY, centerX + 120, groundY);

                if (errorCount >= 1) g.DrawLine(pen, gallowsX, groundY, gallowsX, topY);
                if (errorCount >= 2) g.DrawLine(pen, gallowsX, topY, ropeX, topY);
                if (errorCount >= 3) g.DrawLine(pen, gallowsX, topY + 40, gallowsX + 40, topY);
                if (errorCount >= 4) g.DrawLine(pen, ropeX, topY, ropeX, topY + 30);

                if (errorCount >= 5) g.DrawEllipse(pen, ropeX - 15, topY + 30, 30, 30);
                if (errorCount >= 6) g.DrawLine(pen, ropeX, topY + 60, ropeX, topY + 130);
                if (errorCount >= 7) g.DrawLine(pen, ropeX, topY + 75, ropeX - 25, topY + 105);
                if (errorCount >= 8) g.DrawLine(pen, ropeX, topY + 75, ropeX + 25, topY + 105);
                if (errorCount >= 9) g.DrawLine(pen, ropeX, topY + 130, ropeX - 25, topY + 170);
                if (errorCount >= 10) g.DrawLine(pen, ropeX, topY + 130, ropeX + 25, topY + 170);
            }
        }

        private void ResetVirtualKeyboard()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("but")) c.Enabled = true;
            }
        }

        // --- MENU EVENTY ---
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            SetMenuChecks(true, false, false);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            SetMenuChecks(false, true, false);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            SetMenuChecks(false, false, true);
        }

        // Pomocná metoda pro vizuální kontrolu v menu (XP styl)
        private void SetMenuChecks(bool e, bool m, bool h)
        {
            easyToolStripMenuItem.Checked = e;
            mediumToolStripMenuItem.Checked = m;
            hardToolStripMenuItem.Checked = h;
        }

        private void asd_Click(object sender, EventArgs e) { }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"How to Play:
-------------------------------------------------------------------------------
1. Select the difficulty level in the 'Difficulty' menu.
2. Click 'Start' in the 'Actions' menu to begin.
3. Guess letters using the on-screen keyboard.
4. If you've played at least one game, use 'Reset' in the Actions menu to play again.
5. To exit, select 'Exit' in the 'Actions' menu.",
"Instructions",
MessageBoxButtons.OK,
MessageBoxIcon.Question);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Hangman v1.0
-------------------------------------------------------------------------------
Developed in: Visual Studio 2022
Platform: .NET 8.0

© {DateTime.Now.Year} All rights reserved.",
"About Hangman",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
        }
    }
}