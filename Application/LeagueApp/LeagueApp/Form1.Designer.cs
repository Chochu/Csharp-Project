namespace LeagueApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getSummonerbutton = new System.Windows.Forms.Button();
            this.SummonerNameTextbox = new System.Windows.Forms.TextBox();
            this.feebacklog = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoadChampButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FCListView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WeaklistView = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CInfotextbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WelllistView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StronglistView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ChampCombobox = new System.Windows.Forms.ComboBox();
            this.FreeChampBackWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // getSummonerbutton
            // 
            this.getSummonerbutton.Location = new System.Drawing.Point(6, 33);
            this.getSummonerbutton.Name = "getSummonerbutton";
            this.getSummonerbutton.Size = new System.Drawing.Size(104, 23);
            this.getSummonerbutton.TabIndex = 0;
            this.getSummonerbutton.Text = "Fetch Summoner";
            this.getSummonerbutton.UseVisualStyleBackColor = true;
            this.getSummonerbutton.Click += new System.EventHandler(this.getSummoner_Click);
            // 
            // SummonerNameTextbox
            // 
            this.SummonerNameTextbox.Location = new System.Drawing.Point(6, 7);
            this.SummonerNameTextbox.Name = "SummonerNameTextbox";
            this.SummonerNameTextbox.Size = new System.Drawing.Size(168, 20);
            this.SummonerNameTextbox.TabIndex = 1;
            // 
            // feebacklog
            // 
            this.feebacklog.Location = new System.Drawing.Point(12, 474);
            this.feebacklog.Multiline = true;
            this.feebacklog.Name = "feebacklog";
            this.feebacklog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.feebacklog.Size = new System.Drawing.Size(862, 96);
            this.feebacklog.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 443);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LoadChampButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.SummonerNameTextbox);
            this.tabPage1.Controls.Add(this.getSummonerbutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LoadChampButton
            // 
            this.LoadChampButton.AllowDrop = true;
            this.LoadChampButton.Location = new System.Drawing.Point(7, 63);
            this.LoadChampButton.Name = "LoadChampButton";
            this.LoadChampButton.Size = new System.Drawing.Size(103, 23);
            this.LoadChampButton.TabIndex = 3;
            this.LoadChampButton.Text = "Load Free Champion";
            this.LoadChampButton.UseVisualStyleBackColor = true;
            this.LoadChampButton.Click += new System.EventHandler(this.LoadChampButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FCListView);
            this.groupBox1.Location = new System.Drawing.Point(6, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Free Champion Rotation";
            // 
            // FCListView
            // 
            this.FCListView.Location = new System.Drawing.Point(6, 19);
            this.FCListView.Name = "FCListView";
            this.FCListView.Size = new System.Drawing.Size(698, 201);
            this.FCListView.TabIndex = 0;
            this.FCListView.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ChampCombobox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Champion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WeaklistView);
            this.groupBox2.Location = new System.Drawing.Point(5, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(263, 321);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weak Against";
            // 
            // WeaklistView
            // 
            this.WeaklistView.Location = new System.Drawing.Point(5, 17);
            this.WeaklistView.Margin = new System.Windows.Forms.Padding(2);
            this.WeaklistView.Name = "WeaklistView";
            this.WeaklistView.Size = new System.Drawing.Size(254, 304);
            this.WeaklistView.TabIndex = 0;
            this.WeaklistView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.CInfotextbox);
            this.groupBox5.Location = new System.Drawing.Point(231, 6);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(627, 82);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Counter Information";
            // 
            // CInfotextbox
            // 
            this.CInfotextbox.Location = new System.Drawing.Point(4, 13);
            this.CInfotextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CInfotextbox.Multiline = true;
            this.CInfotextbox.Name = "CInfotextbox";
            this.CInfotextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CInfotextbox.Size = new System.Drawing.Size(619, 68);
            this.CInfotextbox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WelllistView);
            this.groupBox4.Location = new System.Drawing.Point(594, 91);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(264, 321);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Good With";
            // 
            // WelllistView
            // 
            this.WelllistView.Location = new System.Drawing.Point(4, 17);
            this.WelllistView.Margin = new System.Windows.Forms.Padding(2);
            this.WelllistView.Name = "WelllistView";
            this.WelllistView.Size = new System.Drawing.Size(256, 304);
            this.WelllistView.TabIndex = 0;
            this.WelllistView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StronglistView);
            this.groupBox3.Location = new System.Drawing.Point(298, 91);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(263, 322);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Strong Against";
            // 
            // StronglistView
            // 
            this.StronglistView.Location = new System.Drawing.Point(4, 17);
            this.StronglistView.Margin = new System.Windows.Forms.Padding(2);
            this.StronglistView.Name = "StronglistView";
            this.StronglistView.Size = new System.Drawing.Size(255, 304);
            this.StronglistView.TabIndex = 1;
            this.StronglistView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Champion";
            // 
            // ChampCombobox
            // 
            this.ChampCombobox.AllowDrop = true;
            this.ChampCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Aatrox",
            "Ahri",
            "Akali",
            "Alistar",
            "Amumu",
            "Anivia",
            "Annie",
            "Ashe",
            "Azir",
            "Blitzcrank",
            "Brand",
            "Braum",
            "Caitlyn",
            "Cassiopeia",
            "Cho\'Gath",
            "Corki",
            "Darius",
            "Diana",
            "Dr. Mundo",
            "Draven",
            "Elise",
            "Evelynn",
            "Ezreal",
            "Fiddlesticks",
            "Fiora",
            "Fizz",
            "Galio",
            "Gangplank",
            "Garen",
            "Gnar",
            "Gragas",
            "Hecarim",
            "Heimerdinger",
            "Irelia",
            "Janna",
            "Jarvan IV",
            "Jax",
            "Jayce",
            "Jinx",
            "Kalista",
            "Karma",
            "Karthus",
            "Kassadin",
            "Katarina",
            "Kayle",
            "Kennen",
            "Kha\'Zix",
            "Kog\'Maw",
            "LeBlanc",
            "Lee Sin",
            "Leona",
            "Lissandra",
            "Lucian",
            "Lulu",
            "Lux",
            "Malphite",
            "Malzahar",
            "Maokai",
            "Master Yi",
            "Miss Fortune",
            "Mordekaiser",
            "Morgana",
            "Nami",
            "Nasus",
            "Nautilus",
            "Nidalee",
            "Nocturne",
            "Nunu",
            "Olaf",
            "Orianna",
            "Pantheon",
            "Poppy",
            "Quinn",
            "Rammus",
            "Rek\'Sai",
            "Renekton",
            "Rengar",
            "Riven",
            "Rumble",
            "Ryze",
            "Sejuani",
            "Shaco",
            "Shen",
            "Shyvana",
            "Singed",
            "Sion",
            "Sivir",
            "Skarner",
            "Sona",
            "Soraka",
            "Swain",
            "Syndra",
            "Talon",
            "Taric",
            "Teemo",
            "Thresh",
            "Tristana",
            "Trundle",
            "Tryndamere",
            "Twisted Fate",
            "Twitch",
            "Udyr",
            "Urgot",
            "Varus",
            "Vayne",
            "Veigar",
            "Vi",
            "Viktor",
            "Vladimir",
            "Vel\'Koz",
            "Volibear",
            "Warwick",
            "Wukong",
            "Xerath",
            "Xin Zhao",
            "Yasuo",
            "Yorick",
            "Zac",
            "Zed",
            "Ziggs",
            "Zilean",
            "Zyra",
            "Bard",
            "Ekko",
            "TahmKench",
            "kindred",
            "Illaoi",
            "Jhin"});
            this.ChampCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ChampCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ChampCombobox.FormattingEnabled = true;
            this.ChampCombobox.Items.AddRange(new object[] {
            "Aatrox",
            "Ahri",
            "Akali",
            "Alistar",
            "Amumu",
            "Anivia",
            "Annie",
            "Ashe",
            "Azir",
            "Blitzcrank",
            "Brand",
            "Braum",
            "Caitlyn",
            "Cassiopeia",
            "Cho\'Gath",
            "Corki",
            "Darius",
            "Diana",
            "Dr. Mundo",
            "Draven",
            "Elise",
            "Evelynn",
            "Ezreal",
            "Fiddlesticks",
            "Fiora",
            "Fizz",
            "Galio",
            "Gangplank",
            "Garen",
            "Gnar",
            "Gragas",
            "Hecarim",
            "Heimerdinger",
            "Irelia",
            "Janna",
            "Jarvan IV",
            "Jax",
            "Jayce",
            "Jinx",
            "Kalista",
            "Karma",
            "Karthus",
            "Kassadin",
            "Katarina",
            "Kayle",
            "Kennen",
            "Kha\'Zix",
            "Kog\'Maw",
            "LeBlanc",
            "Lee Sin",
            "Leona",
            "Lissandra",
            "Lucian",
            "Lulu",
            "Lux",
            "Malphite",
            "Malzahar",
            "Maokai",
            "Master Yi",
            "Miss Fortune",
            "Mordekaiser",
            "Morgana",
            "Nami",
            "Nasus",
            "Nautilus",
            "Nidalee",
            "Nocturne",
            "Nunu",
            "Olaf",
            "Orianna",
            "Pantheon",
            "Poppy",
            "Quinn",
            "Rammus",
            "Rek\'Sai",
            "Renekton",
            "Rengar",
            "Riven",
            "Rumble",
            "Ryze",
            "Sejuani",
            "Shaco",
            "Shen",
            "Shyvana",
            "Singed",
            "Sion",
            "Sivir",
            "Skarner",
            "Sona",
            "Soraka",
            "Swain",
            "Syndra",
            "Talon",
            "Taric",
            "Teemo",
            "Thresh",
            "Tristana",
            "Trundle",
            "Tryndamere",
            "Twisted Fate",
            "Twitch",
            "Udyr",
            "Urgot",
            "Varus",
            "Vayne",
            "Veigar",
            "Vi",
            "Viktor",
            "Vladimir",
            "Vel\'Koz",
            "Volibear",
            "Warwick",
            "Wukong",
            "Xerath",
            "Xin Zhao",
            "Yasuo",
            "Yorick",
            "Zac",
            "Zed",
            "Ziggs",
            "Zilean",
            "Zyra",
            "Bard",
            "Ekko",
            "TahmKench",
            "kindred",
            "Illaoi",
            "Jhin"});
            this.ChampCombobox.Location = new System.Drawing.Point(106, 11);
            this.ChampCombobox.Name = "ChampCombobox";
            this.ChampCombobox.Size = new System.Drawing.Size(121, 21);
            this.ChampCombobox.TabIndex = 0;
            this.ChampCombobox.SelectedIndexChanged += new System.EventHandler(this.ChampCombobox_SelectedIndexChanged);
            // 
            // FreeChampBackWorker
            // 
            this.FreeChampBackWorker.WorkerReportsProgress = true;
            this.FreeChampBackWorker.WorkerSupportsCancellation = true;
            this.FreeChampBackWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FreeChampBackWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.feebacklog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getSummonerbutton;
        private System.Windows.Forms.TextBox SummonerNameTextbox;
        private System.Windows.Forms.TextBox feebacklog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox ChampCombobox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView FCListView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CInfotextbox;
        private System.Windows.Forms.ListView WeaklistView;
        private System.Windows.Forms.ListView WelllistView;
        private System.Windows.Forms.ListView StronglistView;
        private System.Windows.Forms.Button LoadChampButton;
        private System.ComponentModel.BackgroundWorker FreeChampBackWorker;
    }
}

