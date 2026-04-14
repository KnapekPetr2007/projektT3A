namespace Test01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            obtížnostToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem = new ToolStripMenuItem();
            hardToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            easyToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            endToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            butQ = new Button();
            asd = new Label();
            Sibenice = new PictureBox();
            butW = new Button();
            butE = new Button();
            butR = new Button();
            butT = new Button();
            butY = new Button();
            butU = new Button();
            butI = new Button();
            butO = new Button();
            butP = new Button();
            butA = new Button();
            butS = new Button();
            butD = new Button();
            butF = new Button();
            butG = new Button();
            butH = new Button();
            butJ = new Button();
            butK = new Button();
            butL = new Button();
            butZ = new Button();
            butX = new Button();
            butC = new Button();
            butV = new Button();
            butB = new Button();
            butN = new Button();
            butM = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Sibenice).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { obtížnostToolStripMenuItem, dToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(780, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // obtížnostToolStripMenuItem
            // 
            obtížnostToolStripMenuItem.Name = "obtížnostToolStripMenuItem";
            obtížnostToolStripMenuItem.Size = new Size(12, 20);
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hardToolStripMenuItem, mediumToolStripMenuItem, easyToolStripMenuItem });
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(67, 20);
            dToolStripMenuItem.Text = "Difficulty";
            // 
            // hardToolStripMenuItem
            // 
            hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            hardToolStripMenuItem.Size = new Size(119, 22);
            hardToolStripMenuItem.Text = "Hard";
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(119, 22);
            mediumToolStripMenuItem.Text = "Medium";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(119, 22);
            easyToolStripMenuItem.Text = "Easy";
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, endToolStripMenuItem, resetToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(102, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // endToolStripMenuItem
            // 
            endToolStripMenuItem.Name = "endToolStripMenuItem";
            endToolStripMenuItem.Size = new Size(102, 22);
            endToolStripMenuItem.Text = "End";
            endToolStripMenuItem.Click += endToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(102, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // butQ
            // 
            butQ.FlatStyle = FlatStyle.System;
            butQ.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butQ.Location = new Point(160, 401);
            butQ.Name = "butQ";
            butQ.Size = new Size(42, 42);
            butQ.TabIndex = 1;
            butQ.Text = "Q";
            butQ.UseVisualStyleBackColor = true;
            butQ.Click += Hra_Click;
            // 
            // asd
            // 
            asd.FlatStyle = FlatStyle.System;
            asd.Font = new Font("Tahoma", 36F, FontStyle.Bold);
            asd.Location = new Point(12, 319);
            asd.Name = "asd";
            asd.Size = new Size(756, 79);
            asd.TabIndex = 27;
            asd.TextAlign = ContentAlignment.MiddleCenter;
            asd.Click += asd_Click;
            // 
            // Sibenice
            // 
            Sibenice.BackColor = Color.White;
            Sibenice.BorderStyle = BorderStyle.Fixed3D;
            Sibenice.Location = new Point(163, 40);
            Sibenice.Name = "Sibenice";
            Sibenice.Size = new Size(500, 275);
            Sibenice.TabIndex = 28;
            Sibenice.TabStop = false;
            Sibenice.Paint += Sibenice_Paint;
            // 
            // butW
            // 
            butW.FlatStyle = FlatStyle.System;
            butW.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butW.ImeMode = ImeMode.NoControl;
            butW.Location = new Point(208, 401);
            butW.Name = "butW";
            butW.Size = new Size(42, 42);
            butW.TabIndex = 29;
            butW.Text = "W";
            butW.UseVisualStyleBackColor = true;
            // 
            // butE
            // 
            butE.FlatStyle = FlatStyle.System;
            butE.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butE.ImeMode = ImeMode.NoControl;
            butE.Location = new Point(256, 401);
            butE.Name = "butE";
            butE.Size = new Size(42, 42);
            butE.TabIndex = 30;
            butE.Text = "E";
            butE.UseVisualStyleBackColor = true;
            // 
            // butR
            // 
            butR.FlatStyle = FlatStyle.System;
            butR.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butR.ImeMode = ImeMode.NoControl;
            butR.Location = new Point(304, 401);
            butR.Name = "butR";
            butR.Size = new Size(42, 42);
            butR.TabIndex = 31;
            butR.Text = "R";
            butR.UseVisualStyleBackColor = true;
            // 
            // butT
            // 
            butT.FlatStyle = FlatStyle.System;
            butT.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butT.ImeMode = ImeMode.NoControl;
            butT.Location = new Point(352, 401);
            butT.Name = "butT";
            butT.Size = new Size(42, 42);
            butT.TabIndex = 32;
            butT.Text = "T";
            butT.UseVisualStyleBackColor = true;
            // 
            // butY
            // 
            butY.FlatStyle = FlatStyle.System;
            butY.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butY.ImeMode = ImeMode.NoControl;
            butY.Location = new Point(400, 401);
            butY.Name = "butY";
            butY.Size = new Size(42, 42);
            butY.TabIndex = 33;
            butY.Text = "Y";
            butY.UseVisualStyleBackColor = true;
            // 
            // butU
            // 
            butU.FlatStyle = FlatStyle.System;
            butU.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butU.ImeMode = ImeMode.NoControl;
            butU.Location = new Point(448, 401);
            butU.Name = "butU";
            butU.Size = new Size(42, 42);
            butU.TabIndex = 34;
            butU.Text = "U";
            butU.UseVisualStyleBackColor = true;
            // 
            // butI
            // 
            butI.FlatStyle = FlatStyle.System;
            butI.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butI.ImeMode = ImeMode.NoControl;
            butI.Location = new Point(496, 401);
            butI.Name = "butI";
            butI.Size = new Size(42, 42);
            butI.TabIndex = 35;
            butI.Text = "I";
            butI.UseVisualStyleBackColor = true;
            // 
            // butO
            // 
            butO.FlatStyle = FlatStyle.System;
            butO.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butO.ImeMode = ImeMode.NoControl;
            butO.Location = new Point(544, 401);
            butO.Name = "butO";
            butO.Size = new Size(42, 42);
            butO.TabIndex = 36;
            butO.Text = "O";
            butO.UseVisualStyleBackColor = true;
            // 
            // butP
            // 
            butP.FlatStyle = FlatStyle.System;
            butP.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butP.ImeMode = ImeMode.NoControl;
            butP.Location = new Point(592, 401);
            butP.Name = "butP";
            butP.Size = new Size(42, 42);
            butP.TabIndex = 37;
            butP.Text = "P";
            butP.UseVisualStyleBackColor = true;
            // 
            // butA
            // 
            butA.FlatStyle = FlatStyle.System;
            butA.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butA.ImeMode = ImeMode.NoControl;
            butA.Location = new Point(178, 449);
            butA.Name = "butA";
            butA.Size = new Size(42, 42);
            butA.TabIndex = 38;
            butA.Text = "A";
            butA.UseVisualStyleBackColor = true;
            // 
            // butS
            // 
            butS.FlatStyle = FlatStyle.System;
            butS.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butS.ImeMode = ImeMode.NoControl;
            butS.Location = new Point(226, 449);
            butS.Name = "butS";
            butS.Size = new Size(42, 42);
            butS.TabIndex = 39;
            butS.Text = "S";
            butS.UseVisualStyleBackColor = true;
            // 
            // butD
            // 
            butD.FlatStyle = FlatStyle.System;
            butD.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butD.ImeMode = ImeMode.NoControl;
            butD.Location = new Point(274, 449);
            butD.Name = "butD";
            butD.Size = new Size(42, 42);
            butD.TabIndex = 40;
            butD.Text = "D";
            butD.UseVisualStyleBackColor = true;
            // 
            // butF
            // 
            butF.FlatStyle = FlatStyle.System;
            butF.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butF.ImeMode = ImeMode.NoControl;
            butF.Location = new Point(322, 449);
            butF.Name = "butF";
            butF.Size = new Size(42, 42);
            butF.TabIndex = 41;
            butF.Text = "F";
            butF.UseVisualStyleBackColor = true;
            // 
            // butG
            // 
            butG.FlatStyle = FlatStyle.System;
            butG.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butG.ImeMode = ImeMode.NoControl;
            butG.Location = new Point(370, 449);
            butG.Name = "butG";
            butG.Size = new Size(42, 42);
            butG.TabIndex = 42;
            butG.Text = "G";
            butG.UseVisualStyleBackColor = true;
            // 
            // butH
            // 
            butH.FlatStyle = FlatStyle.System;
            butH.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butH.ImeMode = ImeMode.NoControl;
            butH.Location = new Point(418, 449);
            butH.Name = "butH";
            butH.Size = new Size(42, 42);
            butH.TabIndex = 43;
            butH.Text = "H";
            butH.UseVisualStyleBackColor = true;
            // 
            // butJ
            // 
            butJ.FlatStyle = FlatStyle.System;
            butJ.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butJ.ImeMode = ImeMode.NoControl;
            butJ.Location = new Point(466, 449);
            butJ.Name = "butJ";
            butJ.Size = new Size(42, 42);
            butJ.TabIndex = 44;
            butJ.Text = "J";
            butJ.UseVisualStyleBackColor = true;
            // 
            // butK
            // 
            butK.FlatStyle = FlatStyle.System;
            butK.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butK.ImeMode = ImeMode.NoControl;
            butK.Location = new Point(514, 449);
            butK.Name = "butK";
            butK.Size = new Size(42, 42);
            butK.TabIndex = 45;
            butK.Text = "K";
            butK.UseVisualStyleBackColor = true;
            // 
            // butL
            // 
            butL.FlatStyle = FlatStyle.System;
            butL.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butL.ImeMode = ImeMode.NoControl;
            butL.Location = new Point(562, 449);
            butL.Name = "butL";
            butL.Size = new Size(42, 42);
            butL.TabIndex = 46;
            butL.Text = "L";
            butL.UseVisualStyleBackColor = true;
            // 
            // butZ
            // 
            butZ.FlatStyle = FlatStyle.System;
            butZ.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butZ.ImeMode = ImeMode.NoControl;
            butZ.Location = new Point(198, 497);
            butZ.Name = "butZ";
            butZ.Size = new Size(42, 42);
            butZ.TabIndex = 47;
            butZ.Text = "Z";
            butZ.UseVisualStyleBackColor = true;
            // 
            // butX
            // 
            butX.FlatStyle = FlatStyle.System;
            butX.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butX.ImeMode = ImeMode.NoControl;
            butX.Location = new Point(246, 497);
            butX.Name = "butX";
            butX.Size = new Size(42, 42);
            butX.TabIndex = 48;
            butX.Text = "X";
            butX.UseVisualStyleBackColor = true;
            // 
            // butC
            // 
            butC.FlatStyle = FlatStyle.System;
            butC.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butC.ImeMode = ImeMode.NoControl;
            butC.Location = new Point(294, 497);
            butC.Name = "butC";
            butC.Size = new Size(42, 42);
            butC.TabIndex = 49;
            butC.Text = "C";
            butC.UseVisualStyleBackColor = true;
            // 
            // butV
            // 
            butV.FlatStyle = FlatStyle.System;
            butV.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butV.ImeMode = ImeMode.NoControl;
            butV.Location = new Point(342, 497);
            butV.Name = "butV";
            butV.Size = new Size(42, 42);
            butV.TabIndex = 50;
            butV.Text = "V";
            butV.UseVisualStyleBackColor = true;
            // 
            // butB
            // 
            butB.FlatStyle = FlatStyle.System;
            butB.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butB.ImeMode = ImeMode.NoControl;
            butB.Location = new Point(390, 497);
            butB.Name = "butB";
            butB.Size = new Size(42, 42);
            butB.TabIndex = 51;
            butB.Text = "B";
            butB.UseVisualStyleBackColor = true;
            // 
            // butN
            // 
            butN.FlatStyle = FlatStyle.System;
            butN.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butN.ImeMode = ImeMode.NoControl;
            butN.Location = new Point(438, 497);
            butN.Name = "butN";
            butN.Size = new Size(42, 42);
            butN.TabIndex = 52;
            butN.Text = "N";
            butN.UseVisualStyleBackColor = true;
            // 
            // butM
            // 
            butM.FlatStyle = FlatStyle.System;
            butM.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            butM.ImeMode = ImeMode.NoControl;
            butM.Location = new Point(486, 497);
            butM.Name = "butM";
            butM.Size = new Size(42, 42);
            butM.TabIndex = 53;
            butM.Text = "M";
            butM.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(236, 233, 216);
            ClientSize = new Size(780, 557);
            Controls.Add(butM);
            Controls.Add(butN);
            Controls.Add(butB);
            Controls.Add(butV);
            Controls.Add(butC);
            Controls.Add(butX);
            Controls.Add(butZ);
            Controls.Add(butL);
            Controls.Add(butK);
            Controls.Add(butJ);
            Controls.Add(butH);
            Controls.Add(butG);
            Controls.Add(butF);
            Controls.Add(butD);
            Controls.Add(butS);
            Controls.Add(butA);
            Controls.Add(butP);
            Controls.Add(butO);
            Controls.Add(butI);
            Controls.Add(butU);
            Controls.Add(butY);
            Controls.Add(butT);
            Controls.Add(butR);
            Controls.Add(butE);
            Controls.Add(butW);
            Controls.Add(Sibenice);
            Controls.Add(asd);
            Controls.Add(butQ);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Šibenice";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Sibenice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem obtížnostToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem endToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private Button butQ;
        private Label asd;
        private PictureBox Sibenice;
        private Button butW;
        private Button butE;
        private Button butR;
        private Button butT;
        private Button butY;
        private Button butU;
        private Button butI;
        private Button butO;
        private Button butP;
        private Button butA;
        private Button butS;
        private Button butD;
        private Button butF;
        private Button butG;
        private Button butH;
        private Button butJ;
        private Button butK;
        private Button butL;
        private Button butZ;
        private Button butX;
        private Button butC;
        private Button butV;
        private Button butB;
        private Button butN;
        private Button butM;
    }
}
