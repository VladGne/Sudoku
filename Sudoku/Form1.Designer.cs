namespace Sudoku
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.RecordsPanel = new System.Windows.Forms.Panel();
            this.RecordsLbl = new System.Windows.Forms.Label();
            this.SettingsLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LanguagesSwitcher = new System.Windows.Forms.ComboBox();
            this.LanguageLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DifficultSwitcher = new System.Windows.Forms.ComboBox();
            this.DifficultLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MinLbl = new System.Windows.Forms.Label();
            this.TimerNUD = new System.Windows.Forms.NumericUpDown();
            this.TimerCB = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PlayerNameLbl = new System.Windows.Forms.Label();
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.TimerLbl = new System.Windows.Forms.Label();
            this.SaveResultBTN = new System.Windows.Forms.Button();
            this.CheckBTN = new System.Windows.Forms.Button();
            this.GameGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewGameLbl = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.MainMenuLbl = new System.Windows.Forms.Label();
            this.AboutBTN = new System.Windows.Forms.Button();
            this.RecordsBTN = new System.Windows.Forms.Button();
            this.SettingsBTN = new System.Windows.Forms.Button();
            this.NewGameBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RecordsGrid = new System.Windows.Forms.DataGridView();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.AboutLbl = new System.Windows.Forms.Label();
            this.AboutBox = new System.Windows.Forms.TextBox();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.RecordsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerNUD)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsGrid)).BeginInit();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GamePanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainMenuPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Controls.Add(this.SettingsPanel);
            this.GamePanel.Controls.Add(this.StatusLbl);
            this.GamePanel.Controls.Add(this.TimerLbl);
            this.GamePanel.Controls.Add(this.SaveResultBTN);
            this.GamePanel.Controls.Add(this.CheckBTN);
            this.GamePanel.Controls.Add(this.GameGrid);
            this.GamePanel.Controls.Add(this.NewGameLbl);
            this.GamePanel.Controls.Add(this.StartBTN);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(153, 3);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(428, 255);
            this.GamePanel.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.RecordsPanel);
            this.SettingsPanel.Controls.Add(this.SettingsLbl);
            this.SettingsPanel.Controls.Add(this.groupBox1);
            this.SettingsPanel.Controls.Add(this.groupBox2);
            this.SettingsPanel.Controls.Add(this.groupBox3);
            this.SettingsPanel.Controls.Add(this.groupBox4);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(426, 253);
            this.SettingsPanel.TabIndex = 6;
            this.SettingsPanel.Visible = false;
            // 
            // RecordsPanel
            // 
            this.RecordsPanel.Controls.Add(this.AboutPanel);
            this.RecordsPanel.Controls.Add(this.RecordsGrid);
            this.RecordsPanel.Controls.Add(this.RecordsLbl);
            this.RecordsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordsPanel.Location = new System.Drawing.Point(0, 0);
            this.RecordsPanel.Name = "RecordsPanel";
            this.RecordsPanel.Size = new System.Drawing.Size(426, 253);
            this.RecordsPanel.TabIndex = 8;
            this.RecordsPanel.Visible = false;
            this.RecordsPanel.VisibleChanged += new System.EventHandler(this.RecordsPanel_VisibleChanged);
            // 
            // RecordsLbl
            // 
            this.RecordsLbl.AutoSize = true;
            this.RecordsLbl.Location = new System.Drawing.Point(180, 5);
            this.RecordsLbl.Name = "RecordsLbl";
            this.RecordsLbl.Size = new System.Drawing.Size(47, 13);
            this.RecordsLbl.TabIndex = 0;
            this.RecordsLbl.Text = "Records";
            // 
            // SettingsLbl
            // 
            this.SettingsLbl.AutoSize = true;
            this.SettingsLbl.Location = new System.Drawing.Point(169, 15);
            this.SettingsLbl.Name = "SettingsLbl";
            this.SettingsLbl.Size = new System.Drawing.Size(45, 13);
            this.SettingsLbl.TabIndex = 0;
            this.SettingsLbl.Text = "Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LanguagesSwitcher);
            this.groupBox1.Controls.Add(this.LanguageLbl);
            this.groupBox1.Location = new System.Drawing.Point(56, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // LanguagesSwitcher
            // 
            this.LanguagesSwitcher.Dock = System.Windows.Forms.DockStyle.Right;
            this.LanguagesSwitcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguagesSwitcher.FormattingEnabled = true;
            this.LanguagesSwitcher.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.LanguagesSwitcher.Location = new System.Drawing.Point(156, 16);
            this.LanguagesSwitcher.Name = "LanguagesSwitcher";
            this.LanguagesSwitcher.Size = new System.Drawing.Size(121, 21);
            this.LanguagesSwitcher.TabIndex = 5;
            this.LanguagesSwitcher.SelectedIndexChanged += new System.EventHandler(this.LanguagesSwitcher_SelectedIndexChanged);
            // 
            // LanguageLbl
            // 
            this.LanguageLbl.AutoSize = true;
            this.LanguageLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LanguageLbl.Location = new System.Drawing.Point(3, 16);
            this.LanguageLbl.Name = "LanguageLbl";
            this.LanguageLbl.Size = new System.Drawing.Size(55, 13);
            this.LanguageLbl.TabIndex = 1;
            this.LanguageLbl.Text = "Language";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DifficultSwitcher);
            this.groupBox2.Controls.Add(this.DifficultLbl);
            this.groupBox2.Location = new System.Drawing.Point(56, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // DifficultSwitcher
            // 
            this.DifficultSwitcher.Dock = System.Windows.Forms.DockStyle.Right;
            this.DifficultSwitcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultSwitcher.FormattingEnabled = true;
            this.DifficultSwitcher.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Impossible"});
            this.DifficultSwitcher.Location = new System.Drawing.Point(156, 16);
            this.DifficultSwitcher.Name = "DifficultSwitcher";
            this.DifficultSwitcher.Size = new System.Drawing.Size(121, 21);
            this.DifficultSwitcher.TabIndex = 6;
            this.DifficultSwitcher.SelectedIndexChanged += new System.EventHandler(this.DifficultSwitcher_SelectedIndexChanged);
            // 
            // DifficultLbl
            // 
            this.DifficultLbl.AutoSize = true;
            this.DifficultLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.DifficultLbl.Location = new System.Drawing.Point(3, 16);
            this.DifficultLbl.Name = "DifficultLbl";
            this.DifficultLbl.Size = new System.Drawing.Size(42, 13);
            this.DifficultLbl.TabIndex = 2;
            this.DifficultLbl.Text = "Difficult";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MinLbl);
            this.groupBox3.Controls.Add(this.TimerNUD);
            this.groupBox3.Controls.Add(this.TimerCB);
            this.groupBox3.Location = new System.Drawing.Point(56, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 48);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.Location = new System.Drawing.Point(251, 23);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(23, 13);
            this.MinLbl.TabIndex = 6;
            this.MinLbl.Text = "min";
            // 
            // TimerNUD
            // 
            this.TimerNUD.DecimalPlaces = 1;
            this.TimerNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TimerNUD.Location = new System.Drawing.Point(173, 19);
            this.TimerNUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimerNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TimerNUD.Name = "TimerNUD";
            this.TimerNUD.Size = new System.Drawing.Size(72, 20);
            this.TimerNUD.TabIndex = 5;
            this.TimerNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // TimerCB
            // 
            this.TimerCB.AutoSize = true;
            this.TimerCB.Checked = true;
            this.TimerCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TimerCB.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimerCB.Location = new System.Drawing.Point(3, 16);
            this.TimerCB.Name = "TimerCB";
            this.TimerCB.Size = new System.Drawing.Size(88, 29);
            this.TimerCB.TabIndex = 4;
            this.TimerCB.Text = "Enable Timer";
            this.TimerCB.UseVisualStyleBackColor = true;
            this.TimerCB.CheckedChanged += new System.EventHandler(this.TimerCB_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PlayerNameLbl);
            this.groupBox4.Controls.Add(this.PlayerNameBox);
            this.groupBox4.Location = new System.Drawing.Point(56, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 48);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // PlayerNameLbl
            // 
            this.PlayerNameLbl.AutoSize = true;
            this.PlayerNameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayerNameLbl.Location = new System.Drawing.Point(3, 16);
            this.PlayerNameLbl.Name = "PlayerNameLbl";
            this.PlayerNameLbl.Size = new System.Drawing.Size(67, 13);
            this.PlayerNameLbl.TabIndex = 8;
            this.PlayerNameLbl.Text = "Player Name";
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlayerNameBox.Location = new System.Drawing.Point(156, 16);
            this.PlayerNameBox.MaxLength = 15;
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(121, 20);
            this.PlayerNameBox.TabIndex = 7;
            this.PlayerNameBox.Text = "Player";
            this.PlayerNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerNameBox_KeyPress);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(265, 130);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(37, 13);
            this.StatusLbl.TabIndex = 5;
            this.StatusLbl.Text = "Status";
            this.StatusLbl.DoubleClick += new System.EventHandler(this.StatusLbl_DoubleClick);
            // 
            // TimerLbl
            // 
            this.TimerLbl.AutoSize = true;
            this.TimerLbl.Location = new System.Drawing.Point(265, 102);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(33, 13);
            this.TimerLbl.TabIndex = 4;
            this.TimerLbl.Text = "Timer";
            // 
            // SaveResultBTN
            // 
            this.SaveResultBTN.Enabled = false;
            this.SaveResultBTN.Location = new System.Drawing.Point(265, 209);
            this.SaveResultBTN.Name = "SaveResultBTN";
            this.SaveResultBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveResultBTN.TabIndex = 3;
            this.SaveResultBTN.Text = "Save Result";
            this.SaveResultBTN.UseVisualStyleBackColor = true;
            this.SaveResultBTN.Click += new System.EventHandler(this.SaveResultBTN_Click);
            // 
            // CheckBTN
            // 
            this.CheckBTN.Location = new System.Drawing.Point(265, 165);
            this.CheckBTN.Name = "CheckBTN";
            this.CheckBTN.Size = new System.Drawing.Size(75, 23);
            this.CheckBTN.TabIndex = 2;
            this.CheckBTN.Text = "Check";
            this.CheckBTN.UseVisualStyleBackColor = true;
            this.CheckBTN.Click += new System.EventHandler(this.CheckBTN_Click);
            // 
            // GameGrid
            // 
            this.GameGrid.AllowUserToAddRows = false;
            this.GameGrid.AllowUserToDeleteRows = false;
            this.GameGrid.AllowUserToResizeColumns = false;
            this.GameGrid.AllowUserToResizeRows = false;
            this.GameGrid.BackgroundColor = System.Drawing.Color.Black;
            this.GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGrid.ColumnHeadersVisible = false;
            this.GameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.GameGrid.GridColor = System.Drawing.Color.DimGray;
            this.GameGrid.Location = new System.Drawing.Point(19, 31);
            this.GameGrid.MaximumSize = new System.Drawing.Size(228, 201);
            this.GameGrid.MinimumSize = new System.Drawing.Size(228, 201);
            this.GameGrid.MultiSelect = false;
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.RowHeadersVisible = false;
            this.GameGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GameGrid.Size = new System.Drawing.Size(228, 201);
            this.GameGrid.TabIndex = 1;
            this.GameGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GameGrid_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.DividerWidth = 1;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            this.Column6.DividerWidth = 1;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 25;
            // 
            // NewGameLbl
            // 
            this.NewGameLbl.AutoSize = true;
            this.NewGameLbl.Location = new System.Drawing.Point(271, 15);
            this.NewGameLbl.Name = "NewGameLbl";
            this.NewGameLbl.Size = new System.Drawing.Size(60, 13);
            this.NewGameLbl.TabIndex = 0;
            this.NewGameLbl.Text = "New Game";
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(265, 59);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(75, 23);
            this.StartBTN.TabIndex = 8;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuPanel.Controls.Add(this.ExitBTN);
            this.MainMenuPanel.Controls.Add(this.MainMenuLbl);
            this.MainMenuPanel.Controls.Add(this.AboutBTN);
            this.MainMenuPanel.Controls.Add(this.RecordsBTN);
            this.MainMenuPanel.Controls.Add(this.SettingsBTN);
            this.MainMenuPanel.Controls.Add(this.NewGameBTN);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(144, 255);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(35, 212);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 23);
            this.ExitBTN.TabIndex = 7;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // MainMenuLbl
            // 
            this.MainMenuLbl.AutoSize = true;
            this.MainMenuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuLbl.Location = new System.Drawing.Point(42, 15);
            this.MainMenuLbl.Name = "MainMenuLbl";
            this.MainMenuLbl.Size = new System.Drawing.Size(59, 13);
            this.MainMenuLbl.TabIndex = 6;
            this.MainMenuLbl.Text = "Main menu";
            // 
            // AboutBTN
            // 
            this.AboutBTN.Location = new System.Drawing.Point(35, 173);
            this.AboutBTN.Name = "AboutBTN";
            this.AboutBTN.Size = new System.Drawing.Size(75, 23);
            this.AboutBTN.TabIndex = 5;
            this.AboutBTN.Text = "About";
            this.AboutBTN.UseVisualStyleBackColor = true;
            this.AboutBTN.Click += new System.EventHandler(this.AboutBTN_Click);
            // 
            // RecordsBTN
            // 
            this.RecordsBTN.Location = new System.Drawing.Point(35, 130);
            this.RecordsBTN.Name = "RecordsBTN";
            this.RecordsBTN.Size = new System.Drawing.Size(75, 23);
            this.RecordsBTN.TabIndex = 4;
            this.RecordsBTN.Text = "Records";
            this.RecordsBTN.UseVisualStyleBackColor = true;
            this.RecordsBTN.Click += new System.EventHandler(this.RecordsBTN_Click);
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.Location = new System.Drawing.Point(35, 89);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Size = new System.Drawing.Size(75, 23);
            this.SettingsBTN.TabIndex = 3;
            this.SettingsBTN.Text = "Settings";
            this.SettingsBTN.UseVisualStyleBackColor = true;
            this.SettingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // NewGameBTN
            // 
            this.NewGameBTN.Location = new System.Drawing.Point(35, 46);
            this.NewGameBTN.Name = "NewGameBTN";
            this.NewGameBTN.Size = new System.Drawing.Size(75, 23);
            this.NewGameBTN.TabIndex = 2;
            this.NewGameBTN.Text = "New Game";
            this.NewGameBTN.UseVisualStyleBackColor = true;
            this.NewGameBTN.Click += new System.EventHandler(this.NewGameBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RecordsGrid
            // 
            this.RecordsGrid.AllowUserToAddRows = false;
            this.RecordsGrid.AllowUserToDeleteRows = false;
            this.RecordsGrid.AllowUserToResizeColumns = false;
            this.RecordsGrid.AllowUserToResizeRows = false;
            this.RecordsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RecordsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.RecordsGrid.Location = new System.Drawing.Point(0, 21);
            this.RecordsGrid.MaximumSize = new System.Drawing.Size(419, 229);
            this.RecordsGrid.MinimumSize = new System.Drawing.Size(419, 229);
            this.RecordsGrid.Name = "RecordsGrid";
            this.RecordsGrid.ReadOnly = true;
            this.RecordsGrid.RowHeadersWidth = 60;
            this.RecordsGrid.Size = new System.Drawing.Size(419, 229);
            this.RecordsGrid.TabIndex = 6;
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AboutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AboutPanel.Controls.Add(this.AboutLbl);
            this.AboutPanel.Controls.Add(this.AboutBox);
            this.AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutPanel.Location = new System.Drawing.Point(0, 0);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(426, 253);
            this.AboutPanel.TabIndex = 7;
            // 
            // AboutLbl
            // 
            this.AboutLbl.AutoSize = true;
            this.AboutLbl.Location = new System.Drawing.Point(179, 14);
            this.AboutLbl.Name = "AboutLbl";
            this.AboutLbl.Size = new System.Drawing.Size(35, 13);
            this.AboutLbl.TabIndex = 1;
            this.AboutLbl.Text = "About";
            // 
            // AboutBox
            // 
            this.AboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutBox.Location = new System.Drawing.Point(0, 40);
            this.AboutBox.Multiline = true;
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.ReadOnly = true;
            this.AboutBox.Size = new System.Drawing.Size(424, 211);
            this.AboutBox.TabIndex = 0;
            this.AboutBox.Text = resources.GetString("AboutBox.Text");
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Player";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 75;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Time";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 90;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Difficult";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.RecordsPanel.ResumeLayout(false);
            this.RecordsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerNUD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsGrid)).EndInit();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label TimerLbl;
        private System.Windows.Forms.Button SaveResultBTN;
        private System.Windows.Forms.Button CheckBTN;
        private System.Windows.Forms.DataGridView GameGrid;
        private System.Windows.Forms.Label NewGameLbl;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label MainMenuLbl;
        private System.Windows.Forms.Button AboutBTN;
        private System.Windows.Forms.Button RecordsBTN;
        private System.Windows.Forms.Button SettingsBTN;
        private System.Windows.Forms.Button NewGameBTN;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.ComboBox LanguagesSwitcher;
        private System.Windows.Forms.CheckBox TimerCB;
        private System.Windows.Forms.Label DifficultLbl;
        private System.Windows.Forms.Label LanguageLbl;
        private System.Windows.Forms.Label SettingsLbl;
        private System.Windows.Forms.ComboBox DifficultSwitcher;
        private System.Windows.Forms.TextBox PlayerNameBox;
        private System.Windows.Forms.Panel RecordsPanel;
        private System.Windows.Forms.Label RecordsLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label PlayerNameLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MinLbl;
        private System.Windows.Forms.NumericUpDown TimerNUD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label AboutLbl;
        private System.Windows.Forms.TextBox AboutBox;
        private System.Windows.Forms.DataGridView RecordsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}

