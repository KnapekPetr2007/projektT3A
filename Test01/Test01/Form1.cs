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
        private int difficulty = 1;
        private string selectedWord = "";
        private string currentStatus = "";
        private int errorCount = 0;
        private const int maxErrors = 6;

        private Dictionary<string, string[]> wordDatabase = new Dictionary<string, string[]>
        {
            { "Easy", new string[] { "APPLE", "DOG", "HOUSE", "BIRD", "SUN" } },
            { "Medium", new string[] { "COMPUTER", "KEYBOARD", "MOUNTAIN", "WINDOW" } },
            { "Hard", new string[] { "ARCHITECTURE", "STRENGTH", "RHYTHM", "SYNCHRONIZE" } }
        };

        public Form1()
        {
            InitializeComponent();
            ManualEventWiring(); // Tady to všechno ruènì propojíme
        }

        private void ManualEventWiring()
        {
            // Propojení Menu Actions
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            endToolStripMenuItem.Click += endToolStripMenuItem_Click;

            // Propojení Menu Obtížnost
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;

            // Propojení VŠECH tlaèítek s písmeny
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("but"))
                {
                    c.Click -= Hra_Click; // Nejdøív odebrat (pro jistotu)
                    c.Click += Hra_Click; // Pak pøidat
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
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
            Button? btn = sender as Button;
            if (btn == null) return;

            // Získání písmene z Textu, nebo z názvu (butA -> A)
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
                    MessageBox.Show("Výhra! Slovo bylo: " + selectedWord);
                    InitializeGame();
                }
            }
            else
            {
                errorCount++;
                Sibenice.Invalidate();
                if (errorCount >= maxErrors)
                {
                    MessageBox.Show("Prohra! Slovo bylo: " + selectedWord);
                    InitializeGame();
                }
            }
        }

        private void Sibenice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Black, 3))
            {
                if (errorCount >= 1) { g.DrawLine(pen, 20, 180, 120, 180); g.DrawLine(pen, 40, 180, 40, 20); g.DrawLine(pen, 40, 20, 140, 20); g.DrawLine(pen, 40, 50, 70, 20); }
                if (errorCount >= 2) { g.DrawLine(pen, 140, 20, 140, 40); g.DrawEllipse(pen, 125, 40, 30, 30); }
                if (errorCount >= 3) g.DrawLine(pen, 140, 70, 140, 120);
                if (errorCount >= 4) { g.DrawLine(pen, 140, 80, 120, 100); g.DrawLine(pen, 140, 80, 160, 100); }
                if (errorCount >= 5) g.DrawLine(pen, 140, 120, 120, 150);
                if (errorCount >= 6) g.DrawLine(pen, 140, 120, 160, 150);
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
        private void startToolStripMenuItem_Click(object sender, EventArgs e) { InitializeGame(); }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e) { InitializeGame(); }
        private void endToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }
        private void easyToolStripMenuItem_Click(object sender, EventArgs e) { difficulty = 1; InitializeGame(); }
        private void mediumToolStripMenuItem_Click(object sender, EventArgs e) { difficulty = 2; InitializeGame(); }
        private void hardToolStripMenuItem_Click(object sender, EventArgs e) { difficulty = 3; InitializeGame(); }
        private void asd_Click(object sender, EventArgs e) { }
    }
}