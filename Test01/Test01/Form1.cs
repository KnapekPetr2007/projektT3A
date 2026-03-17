namespace Test01
{
    public partial class Form1 : Form
    {
        int difficulty = 0;

        List<string> easy = new List<string>
        {
            "myö", "kl·vesa", "monitor", "kabel", "server",
            "router", "heslo", "soubor", "sloûka", "wifi"
        };

        List<string> medium = new List<string>
        {
            "datab·ze", "program", "algoritmus", "kompilace", "firewall",
            "procesor", "pamÏù", "aplikace", "ovladaË", "protokol"
        };

        List<string> hard = new List<string>
        {
            "virtualizace", "infrastruktura", "optimalizace", "autentizace", "kryptografie",
            "synchronizace", "konfigurace", "implementace", "architektura", "komprimace"
        };

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
    }
