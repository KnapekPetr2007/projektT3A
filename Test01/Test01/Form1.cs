namespace Test01
{
    public partial class Form1 : Form
    {
        random

        int difficulty = 1;

        // The database of words categorized by difficulty
        Dictionary<string, string[]> wordDatabase = new Dictionary<string, string[]>
        {
            { "Easy", new string[] { "APPLE", "DOG", "HOUSE", "BIRD", "SUN" } },
            { "Medium", new string[] { "COMPUTER", "KEYBOARD", "MOUNTAIN", "WINDOW" } },
            { "Hard", new string[] { "ARCHITECTURE", "STRENGTH", "RHYTHM", "SYNCHRONIZE" } }
        };

        // Global variables to track the current game state
        string selectedWord = "";    // The actual word (e.g., "DOG")
        string currentStatus = "";   // What the player sees (e.g., "_ _ _")
        int errorCount = 0;          // How many wrong guesses the player has made

        private void InitializeGame()
        {
            // 1. Map the number (1,2,3) to the dictionary key
            string levelKey = "Easy";
            if (difficulty == 2) levelKey = "Medium";
            else if (difficulty == 3) levelKey = "Hard";

            // 2. Get the list of words for that difficulty
            string[] potentialWords = wordDatabase[levelKey];

            // 3. Pick one random word
            selectedWord = potentialWords[rng.Next(potentialWords.Length)].ToUpper();

            // 4. Create the dashes string (e.g., "____")
            currentStatus = new string('_', selectedWord.Length);

            // 5. Show it in your label 'textIn' with spaces for readability
            textIn.Text = string.Join(" ", currentStatus.ToCharArray());

            // 6. Reset the mistake counter and enable all buttons
            errorCount = 0;
            ResetVirtualKeyboard();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 3;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 2;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 1;
        }

        private void asd_Click(object sender, EventArgs e)
        {

        }
    }
}
