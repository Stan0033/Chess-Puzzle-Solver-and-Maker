namespace Chezz_Puzzler
{
    partial class Form_base
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_base));
            this.icon_solved = new System.Windows.Forms.PictureBox();
            this.icon_notSolved = new System.Windows.Forms.PictureBox();
            this.panel_solver = new System.Windows.Forms.Panel();
            this.panel_composer = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_dummy_EL = new System.Windows.Forms.Panel();
            this.menuPuzzles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listofPuzzles = new System.Windows.Forms.ListBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_PuzleEditContainer = new System.Windows.Forms.Panel();
            this.panel_ComposePuzzleContainer = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_reverseFiles = new System.Windows.Forms.Button();
            this.labelTBOX_Name = new System.Windows.Forms.Label();
            this.labelTBOX_Hint = new System.Windows.Forms.Label();
            this.labelTBOX_Wrong = new System.Windows.Forms.Label();
            this.labelTBOX_Righht = new System.Windows.Forms.Label();
            this.checkbox_smartAdd = new System.Windows.Forms.CheckBox();
            this.button_swapPlayers = new System.Windows.Forms.Button();
            this.button_swapColors = new System.Windows.Forms.Button();
            this.labelTXB_Descr = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.contextMenu_TextBoxes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAndPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_LastPlayedOptional = new System.Windows.Forms.CheckBox();
            this.comboBox_num2_om = new System.Windows.Forms.ComboBox();
            this.comboBox_letter2_om = new System.Windows.Forms.ComboBox();
            this.label_TakesToOriginal = new System.Windows.Forms.Label();
            this.comboBox_num1_om = new System.Windows.Forms.ComboBox();
            this.comboBox_letter1_om = new System.Windows.Forms.ComboBox();
            this.labelTXB_Event = new System.Windows.Forms.Label();
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.textBox_Right = new System.Windows.Forms.TextBox();
            this.textbox_Wrong = new System.Windows.Forms.TextBox();
            this.label_Puzzles = new System.Windows.Forms.Label();
            this.listbox_Puzzles_Rush = new System.Windows.Forms.ListBox();
            this.contextRushMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Solutions = new System.Windows.Forms.Label();
            this.linkLabel_SCN = new System.Windows.Forms.LinkLabel();
            this.button_import_local = new System.Windows.Forms.Button();
            this.label_SCNImport = new System.Windows.Forms.Label();
            this.textBox_SCN = new System.Windows.Forms.TextBox();
            this.linkLabel_FEN = new System.Windows.Forms.LinkLabel();
            this.label_FENImportLabel = new System.Windows.Forms.Label();
            this.textBox_FEN = new System.Windows.Forms.TextBox();
            this.button_ImprtFEN = new System.Windows.Forms.Button();
            this.checkBox_AT = new System.Windows.Forms.CheckBox();
            this.button_Transition = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_hint = new System.Windows.Forms.TextBox();
            this.listbox_Puzzle_Fragments = new System.Windows.Forms.ListBox();
            this.contextChaptersList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editChapterWithCurrentFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.removeLastChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Add = new System.Windows.Forms.Button();
            this.c_number2 = new System.Windows.Forms.ComboBox();
            this.c_letter2 = new System.Windows.Forms.ComboBox();
            this.label_Takesto = new System.Windows.Forms.Label();
            this.c_number1 = new System.Windows.Forms.ComboBox();
            this.c_letter1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.panel_generate = new System.Windows.Forms.Panel();
            this.linkLabel_Dif = new System.Windows.Forms.LinkLabel();
            this.checkBox_Making_PR = new System.Windows.Forms.CheckBox();
            this.button_Generate_P = new System.Windows.Forms.Button();
            this.button_generate_PR = new System.Windows.Forms.Button();
            this.button_hint = new System.Windows.Forms.Button();
            this.label_solution_chapter = new System.Windows.Forms.Label();
            this.menuChangeSquare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitePawnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteRookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteQueenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteKingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteBishopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteKnightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackPawnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackRookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackQueenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackKingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackBishopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackKnightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eMPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.thisIsAttackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsAttackedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.thisIsPrepuzzleStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsPrePuzzleEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_chapterCounter = new System.Windows.Forms.Label();
            this.label_hint = new System.Windows.Forms.Label();
            this.label_square_displayer = new System.Windows.Forms.Label();
            this.label_Action_Response = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.checkBox_AU_Reset = new System.Windows.Forms.CheckBox();
            this.checkBox_UseBG = new System.Windows.Forms.CheckBox();
            this.checkBox_autoPR = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_hotkeys = new System.Windows.Forms.CheckBox();
            this.context_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorOfWhiteSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorOfBlackSquaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeHightlightedSquareColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLastMoveHightlightColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setCountdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeResponseTimeOfPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_show_solution = new System.Windows.Forms.Button();
            this.label_show_solution = new System.Windows.Forms.Label();
            this.button_export_Local = new System.Windows.Forms.Button();
            this.button_export_FEN = new System.Windows.Forms.Button();
            this.colorDialog_decideColorSquares = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.label_h = new System.Windows.Forms.Label();
            this.label_g = new System.Windows.Forms.Label();
            this.label_f = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label_8 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.menu_Timer_Puzzle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_move_wrong = new System.Windows.Forms.Label();
            this.label_move_right = new System.Windows.Forms.Label();
            this.panel_cd_event_toMove = new System.Windows.Forms.Panel();
            this.label_event = new System.Windows.Forms.Label();
            this.label_Countdown_Puzzle = new System.Windows.Forms.Label();
            this.label_Countdown_Global = new System.Windows.Forms.Label();
            this.menu_global = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_GenerateStartingChessPosition = new System.Windows.Forms.Button();
            this.button_reset_puzzle = new System.Windows.Forms.Button();
            this.button_clear_Board = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_gotoNextPuzzle = new System.Windows.Forms.Button();
            this.button_Autoplay = new System.Windows.Forms.Button();
            this.imageList_ForPRList = new System.Windows.Forms.ImageList(this.components);
            this.context_help = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.howToSolvePuzzlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PuzzlesDisplay = new System.Windows.Forms.Panel();
            this.panel_setttings = new System.Windows.Forms.Panel();
            this.Button_StopPuzzleTimer = new System.Windows.Forms.Button();
            this.Button_StopGlobalTimer = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label_logo_settings = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_SetPieceTheme = new System.Windows.Forms.Button();
            this.comboBox_Psets = new System.Windows.Forms.ComboBox();
            this.button_hColor4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button_setResponseTimePL = new System.Windows.Forms.Button();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.button_setPuzzleCountdown = new System.Windows.Forms.Button();
            this.button_SetGlobalCountdown = new System.Windows.Forms.Button();
            this.numF_Sec_Puzzle = new System.Windows.Forms.NumericUpDown();
            this.numF_Min_Puzzle = new System.Windows.Forms.NumericUpDown();
            this.numF_Hour_Puzzle = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numF_Sec_Global = new System.Windows.Forms.NumericUpDown();
            this.numF_Min_Global = new System.Windows.Forms.NumericUpDown();
            this.numF_Hour_Global = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.button_resetAllSettings_Panel = new System.Windows.Forms.Button();
            this.button_hColor3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_hColor2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_hColor1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_stHoverColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_setLastMoveColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_setSElectedSquare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_blackSqSetColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_setwhiteSqColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_solved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_notSolved)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuPuzzles.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_PuzleEditContainer.SuspendLayout();
            this.panel_ComposePuzzleContainer.SuspendLayout();
            this.contextMenu_TextBoxes.SuspendLayout();
            this.contextRushMenu.SuspendLayout();
            this.contextChaptersList.SuspendLayout();
            this.panel_generate.SuspendLayout();
            this.menuChangeSquare.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.context_options.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu_Timer_Puzzle.SuspendLayout();
            this.panel_cd_event_toMove.SuspendLayout();
            this.menu_global.SuspendLayout();
            this.context_help.SuspendLayout();
            this.panel_setttings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Sec_Puzzle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Min_Puzzle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Hour_Puzzle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Sec_Global)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Min_Global)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Hour_Global)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_solved
            // 
            this.icon_solved.BackColor = System.Drawing.Color.Transparent;
            this.icon_solved.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.tick;
            this.icon_solved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_solved.Location = new System.Drawing.Point(553, 232);
            this.icon_solved.Name = "icon_solved";
            this.icon_solved.Size = new System.Drawing.Size(50, 50);
            this.icon_solved.TabIndex = 34;
            this.icon_solved.TabStop = false;
            this.icon_solved.Visible = false;
            // 
            // icon_notSolved
            // 
            this.icon_notSolved.BackColor = System.Drawing.Color.Transparent;
            this.icon_notSolved.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.cross;
            this.icon_notSolved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_notSolved.Location = new System.Drawing.Point(553, 176);
            this.icon_notSolved.Name = "icon_notSolved";
            this.icon_notSolved.Size = new System.Drawing.Size(50, 50);
            this.icon_notSolved.TabIndex = 35;
            this.icon_notSolved.TabStop = false;
            this.icon_notSolved.Visible = false;
            // 
            // panel_solver
            // 
            this.panel_solver.Location = new System.Drawing.Point(21, 12);
            this.panel_solver.Name = "panel_solver";
            this.panel_solver.Size = new System.Drawing.Size(520, 520);
            this.panel_solver.TabIndex = 37;
            // 
            // panel_composer
            // 
            this.panel_composer.Location = new System.Drawing.Point(843, 11);
            this.panel_composer.Name = "panel_composer";
            this.panel_composer.Size = new System.Drawing.Size(520, 520);
            this.panel_composer.TabIndex = 38;
            this.panel_composer.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(1031, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 733);
            this.tabControl1.TabIndex = 38;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_dummy_EL);
            this.tabPage1.Controls.Add(this.listofPuzzles);
            this.tabPage1.Controls.Add(this.richTextBox_description);
            this.tabPage1.Controls.Add(this.button_solve);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Solve";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_dummy_EL
            // 
            this.panel_dummy_EL.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.empty_list;
            this.panel_dummy_EL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_dummy_EL.ContextMenuStrip = this.menuPuzzles;
            this.panel_dummy_EL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dummy_EL.Location = new System.Drawing.Point(3, 54);
            this.panel_dummy_EL.Name = "panel_dummy_EL";
            this.panel_dummy_EL.Size = new System.Drawing.Size(359, 593);
            this.panel_dummy_EL.TabIndex = 83;
            // 
            // menuPuzzles
            // 
            this.menuPuzzles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator3,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuPuzzles.Name = "menuPuzzles";
            this.menuPuzzles.Size = new System.Drawing.Size(131, 88);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // listofPuzzles
            // 
            this.listofPuzzles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listofPuzzles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listofPuzzles.ContextMenuStrip = this.menuPuzzles;
            this.listofPuzzles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listofPuzzles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listofPuzzles.ForeColor = System.Drawing.Color.White;
            this.listofPuzzles.FormattingEnabled = true;
            this.listofPuzzles.ItemHeight = 21;
            this.listofPuzzles.Location = new System.Drawing.Point(3, 54);
            this.listofPuzzles.Name = "listofPuzzles";
            this.listofPuzzles.Size = new System.Drawing.Size(359, 593);
            this.listofPuzzles.TabIndex = 2;
            this.listofPuzzles.SelectedIndexChanged += new System.EventHandler(this.ListofPuzzles_SelectedIndexChanged);
            this.listofPuzzles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListofPuzzles_MouseDoubleClick);
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_description.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_description.ForeColor = System.Drawing.Color.White;
            this.richTextBox_description.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ReadOnly = true;
            this.richTextBox_description.Size = new System.Drawing.Size(359, 51);
            this.richTextBox_description.TabIndex = 0;
            this.richTextBox_description.Text = "";
            // 
            // button_solve
            // 
            this.button_solve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_solve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_solve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_solve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_solve.Location = new System.Drawing.Point(3, 647);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(359, 55);
            this.button_solve.TabIndex = 1;
            this.button_solve.Text = "(S)olve";
            this.button_solve.UseVisualStyleBackColor = false;
            this.button_solve.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.panel_PuzleEditContainer);
            this.tabPage2.Controls.Add(this.panel_generate);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create";
            // 
            // panel_PuzleEditContainer
            // 
            this.panel_PuzleEditContainer.Controls.Add(this.panel_ComposePuzzleContainer);
            this.panel_PuzleEditContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PuzleEditContainer.Location = new System.Drawing.Point(3, 3);
            this.panel_PuzleEditContainer.Name = "panel_PuzleEditContainer";
            this.panel_PuzleEditContainer.Size = new System.Drawing.Size(359, 599);
            this.panel_PuzleEditContainer.TabIndex = 102;
            // 
            // panel_ComposePuzzleContainer
            // 
            this.panel_ComposePuzzleContainer.AutoScroll = true;
            this.panel_ComposePuzzleContainer.Controls.Add(this.button2);
            this.panel_ComposePuzzleContainer.Controls.Add(this.btn_reverseFiles);
            this.panel_ComposePuzzleContainer.Controls.Add(this.labelTBOX_Name);
            this.panel_ComposePuzzleContainer.Controls.Add(this.labelTBOX_Hint);
            this.panel_ComposePuzzleContainer.Controls.Add(this.labelTBOX_Wrong);
            this.panel_ComposePuzzleContainer.Controls.Add(this.labelTBOX_Righht);
            this.panel_ComposePuzzleContainer.Controls.Add(this.checkbox_smartAdd);
            this.panel_ComposePuzzleContainer.Controls.Add(this.button_swapPlayers);
            this.panel_ComposePuzzleContainer.Controls.Add(this.button_swapColors);
            this.panel_ComposePuzzleContainer.Controls.Add(this.labelTXB_Descr);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_description);
            this.panel_ComposePuzzleContainer.Controls.Add(this.checkBox_LastPlayedOptional);
            this.panel_ComposePuzzleContainer.Controls.Add(this.comboBox_num2_om);
            this.panel_ComposePuzzleContainer.Controls.Add(this.comboBox_letter2_om);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_TakesToOriginal);
            this.panel_ComposePuzzleContainer.Controls.Add(this.comboBox_num1_om);
            this.panel_ComposePuzzleContainer.Controls.Add(this.comboBox_letter1_om);
            this.panel_ComposePuzzleContainer.Controls.Add(this.labelTXB_Event);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_event);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_Right);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textbox_Wrong);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_Puzzles);
            this.panel_ComposePuzzleContainer.Controls.Add(this.listbox_Puzzles_Rush);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_Solutions);
            this.panel_ComposePuzzleContainer.Controls.Add(this.linkLabel_SCN);
            this.panel_ComposePuzzleContainer.Controls.Add(this.button_import_local);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_SCNImport);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_SCN);
            this.panel_ComposePuzzleContainer.Controls.Add(this.linkLabel_FEN);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_FENImportLabel);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_FEN);
            this.panel_ComposePuzzleContainer.Controls.Add(this.button_ImprtFEN);
            this.panel_ComposePuzzleContainer.Controls.Add(this.checkBox_AT);
            this.panel_ComposePuzzleContainer.Controls.Add(this.button_Transition);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label6);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_hint);
            this.panel_ComposePuzzleContainer.Controls.Add(this.listbox_Puzzle_Fragments);
            this.panel_ComposePuzzleContainer.Controls.Add(this.button_Add);
            this.panel_ComposePuzzleContainer.Controls.Add(this.c_number2);
            this.panel_ComposePuzzleContainer.Controls.Add(this.c_letter2);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_Takesto);
            this.panel_ComposePuzzleContainer.Controls.Add(this.c_number1);
            this.panel_ComposePuzzleContainer.Controls.Add(this.c_letter1);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label2);
            this.panel_ComposePuzzleContainer.Controls.Add(this.label_name);
            this.panel_ComposePuzzleContainer.Controls.Add(this.textBox_name);
            this.panel_ComposePuzzleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ComposePuzzleContainer.Location = new System.Drawing.Point(0, 0);
            this.panel_ComposePuzzleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ComposePuzzleContainer.Name = "panel_ComposePuzzleContainer";
            this.panel_ComposePuzzleContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel_ComposePuzzleContainer.Size = new System.Drawing.Size(359, 599);
            this.panel_ComposePuzzleContainer.TabIndex = 103;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 875);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 32);
            this.button2.TabIndex = 126;
            this.button2.Text = "Reverse Ranks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SwapAllRanks);
            // 
            // btn_reverseFiles
            // 
            this.btn_reverseFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reverseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reverseFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reverseFiles.Location = new System.Drawing.Point(12, 838);
            this.btn_reverseFiles.Name = "btn_reverseFiles";
            this.btn_reverseFiles.Size = new System.Drawing.Size(236, 32);
            this.btn_reverseFiles.TabIndex = 125;
            this.btn_reverseFiles.Text = "Reverse Files";
            this.btn_reverseFiles.UseVisualStyleBackColor = true;
            this.btn_reverseFiles.Click += new System.EventHandler(this.SwapAllFiles);
            // 
            // labelTBOX_Name
            // 
            this.labelTBOX_Name.AutoSize = true;
            this.labelTBOX_Name.Location = new System.Drawing.Point(10, 19);
            this.labelTBOX_Name.Name = "labelTBOX_Name";
            this.labelTBOX_Name.Size = new System.Drawing.Size(39, 15);
            this.labelTBOX_Name.TabIndex = 124;
            this.labelTBOX_Name.Text = "Name";
            this.toolTip1.SetToolTip(this.labelTBOX_Name, "Applied to the whole puzzle or PR");
            // 
            // labelTBOX_Hint
            // 
            this.labelTBOX_Hint.AutoSize = true;
            this.labelTBOX_Hint.Location = new System.Drawing.Point(13, 54);
            this.labelTBOX_Hint.Name = "labelTBOX_Hint";
            this.labelTBOX_Hint.Size = new System.Drawing.Size(30, 15);
            this.labelTBOX_Hint.TabIndex = 123;
            this.labelTBOX_Hint.Text = "Hint";
            this.toolTip1.SetToolTip(this.labelTBOX_Hint, "Applieed to a single chapter");
            // 
            // labelTBOX_Wrong
            // 
            this.labelTBOX_Wrong.AutoSize = true;
            this.labelTBOX_Wrong.Location = new System.Drawing.Point(5, 89);
            this.labelTBOX_Wrong.Name = "labelTBOX_Wrong";
            this.labelTBOX_Wrong.Size = new System.Drawing.Size(43, 15);
            this.labelTBOX_Wrong.TabIndex = 122;
            this.labelTBOX_Wrong.Text = "Wrong";
            this.toolTip1.SetToolTip(this.labelTBOX_Wrong, "Applieed to a single chapter");
            // 
            // labelTBOX_Righht
            // 
            this.labelTBOX_Righht.AutoSize = true;
            this.labelTBOX_Righht.Location = new System.Drawing.Point(10, 124);
            this.labelTBOX_Righht.Name = "labelTBOX_Righht";
            this.labelTBOX_Righht.Size = new System.Drawing.Size(35, 15);
            this.labelTBOX_Righht.TabIndex = 121;
            this.labelTBOX_Righht.Text = "Right";
            this.toolTip1.SetToolTip(this.labelTBOX_Righht, "Applieed to a single chapter");
            // 
            // checkbox_smartAdd
            // 
            this.checkbox_smartAdd.AutoSize = true;
            this.checkbox_smartAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_smartAdd.Location = new System.Drawing.Point(3, 455);
            this.checkbox_smartAdd.Name = "checkbox_smartAdd";
            this.checkbox_smartAdd.Size = new System.Drawing.Size(291, 64);
            this.checkbox_smartAdd.TabIndex = 120;
            this.checkbox_smartAdd.Text = "Holding \"ctrl\" while moving a piece will add it as a\r\n proposed solution.\r\nHoldin" +
    "g \"ctrl\"+\"alt\" while moving a piece will add\r\n it as a proposed solution and add" +
    " it as chapter";
            this.checkbox_smartAdd.UseVisualStyleBackColor = true;
            this.checkbox_smartAdd.CheckedChanged += new System.EventHandler(this.Checkbox_smartAdd_CheckedChanged);
            // 
            // button_swapPlayers
            // 
            this.button_swapPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_swapPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_swapPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_swapPlayers.Location = new System.Drawing.Point(133, 803);
            this.button_swapPlayers.Name = "button_swapPlayers";
            this.button_swapPlayers.Size = new System.Drawing.Size(115, 32);
            this.button_swapPlayers.TabIndex = 119;
            this.button_swapPlayers.Text = "Swap Players";
            this.button_swapPlayers.UseVisualStyleBackColor = true;
            this.button_swapPlayers.Click += new System.EventHandler(this.SwapPlayers_Click);
            // 
            // button_swapColors
            // 
            this.button_swapColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_swapColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_swapColors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_swapColors.Location = new System.Drawing.Point(12, 803);
            this.button_swapColors.Name = "button_swapColors";
            this.button_swapColors.Size = new System.Drawing.Size(115, 32);
            this.button_swapColors.TabIndex = 118;
            this.button_swapColors.Text = "Swap Colors";
            this.button_swapColors.UseVisualStyleBackColor = true;
            this.button_swapColors.Click += new System.EventHandler(this.Button_swapColors_click);
            // 
            // labelTXB_Descr
            // 
            this.labelTXB_Descr.AutoSize = true;
            this.labelTXB_Descr.Location = new System.Drawing.Point(9, 196);
            this.labelTXB_Descr.Name = "labelTXB_Descr";
            this.labelTXB_Descr.Size = new System.Drawing.Size(39, 15);
            this.labelTXB_Descr.TabIndex = 117;
            this.labelTXB_Descr.Text = "Descr:";
            this.toolTip1.SetToolTip(this.labelTXB_Descr, "Applied to the whole puzzle");
            // 
            // textBox_description
            // 
            this.textBox_description.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_description.Location = new System.Drawing.Point(54, 188);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(270, 29);
            this.textBox_description.TabIndex = 116;
            this.toolTip1.SetToolTip(this.textBox_description, "Applied to the whole puzzle");
            // 
            // contextMenu_TextBoxes
            // 
            this.contextMenu_TextBoxes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearAndPasteToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.contextMenu_TextBoxes.Name = "contextMenu_TextBoxes";
            this.contextMenu_TextBoxes.Size = new System.Drawing.Size(158, 114);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.CopyAllToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // clearAndPasteToolStripMenuItem
            // 
            this.clearAndPasteToolStripMenuItem.Name = "clearAndPasteToolStripMenuItem";
            this.clearAndPasteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clearAndPasteToolStripMenuItem.Text = "Clear And Paste";
            this.clearAndPasteToolStripMenuItem.Click += new System.EventHandler(this.ClearAndPasteToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.ClearToolStripMenuItem1_Click);
            // 
            // checkBox_LastPlayedOptional
            // 
            this.checkBox_LastPlayedOptional.AutoSize = true;
            this.checkBox_LastPlayedOptional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_LastPlayedOptional.Location = new System.Drawing.Point(4, 536);
            this.checkBox_LastPlayedOptional.Name = "checkBox_LastPlayedOptional";
            this.checkBox_LastPlayedOptional.Size = new System.Drawing.Size(306, 19);
            this.checkBox_LastPlayedOptional.TabIndex = 115;
            this.checkBox_LastPlayedOptional.Text = "Last move played, before the puzzle starts (optional) :";
            this.checkBox_LastPlayedOptional.UseVisualStyleBackColor = true;
            // 
            // comboBox_num2_om
            // 
            this.comboBox_num2_om.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_num2_om.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_num2_om.FormattingEnabled = true;
            this.comboBox_num2_om.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_num2_om.Location = new System.Drawing.Point(203, 563);
            this.comboBox_num2_om.Name = "comboBox_num2_om";
            this.comboBox_num2_om.Size = new System.Drawing.Size(31, 23);
            this.comboBox_num2_om.TabIndex = 114;
            // 
            // comboBox_letter2_om
            // 
            this.comboBox_letter2_om.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_letter2_om.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_letter2_om.FormattingEnabled = true;
            this.comboBox_letter2_om.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.comboBox_letter2_om.Location = new System.Drawing.Point(166, 563);
            this.comboBox_letter2_om.Name = "comboBox_letter2_om";
            this.comboBox_letter2_om.Size = new System.Drawing.Size(31, 23);
            this.comboBox_letter2_om.TabIndex = 113;
            // 
            // label_TakesToOriginal
            // 
            this.label_TakesToOriginal.AutoSize = true;
            this.label_TakesToOriginal.Location = new System.Drawing.Point(114, 566);
            this.label_TakesToOriginal.Name = "label_TakesToOriginal";
            this.label_TakesToOriginal.Size = new System.Drawing.Size(50, 15);
            this.label_TakesToOriginal.TabIndex = 112;
            this.label_TakesToOriginal.Text = "takes/to";
            // 
            // comboBox_num1_om
            // 
            this.comboBox_num1_om.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_num1_om.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_num1_om.FormattingEnabled = true;
            this.comboBox_num1_om.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_num1_om.Location = new System.Drawing.Point(77, 563);
            this.comboBox_num1_om.Name = "comboBox_num1_om";
            this.comboBox_num1_om.Size = new System.Drawing.Size(31, 23);
            this.comboBox_num1_om.TabIndex = 111;
            // 
            // comboBox_letter1_om
            // 
            this.comboBox_letter1_om.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_letter1_om.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_letter1_om.FormattingEnabled = true;
            this.comboBox_letter1_om.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.comboBox_letter1_om.Location = new System.Drawing.Point(40, 563);
            this.comboBox_letter1_om.Name = "comboBox_letter1_om";
            this.comboBox_letter1_om.Size = new System.Drawing.Size(31, 23);
            this.comboBox_letter1_om.TabIndex = 110;
            // 
            // labelTXB_Event
            // 
            this.labelTXB_Event.AutoSize = true;
            this.labelTXB_Event.Location = new System.Drawing.Point(13, 161);
            this.labelTXB_Event.Name = "labelTXB_Event";
            this.labelTXB_Event.Size = new System.Drawing.Size(36, 15);
            this.labelTXB_Event.TabIndex = 109;
            this.labelTXB_Event.Text = "Event";
            this.toolTip1.SetToolTip(this.labelTXB_Event, "Applied to the whole puxzle");
            // 
            // textBox_event
            // 
            this.textBox_event.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_event.Location = new System.Drawing.Point(54, 153);
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.Size = new System.Drawing.Size(270, 29);
            this.textBox_event.TabIndex = 108;
            this.toolTip1.SetToolTip(this.textBox_event, "Who vs who? ratings? when and where happened?");
            // 
            // textBox_Right
            // 
            this.textBox_Right.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_Right.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Right.Location = new System.Drawing.Point(53, 116);
            this.textBox_Right.Name = "textBox_Right";
            this.textBox_Right.Size = new System.Drawing.Size(270, 29);
            this.textBox_Right.TabIndex = 106;
            this.toolTip1.SetToolTip(this.textBox_Right, "ex.: If the answer is right, you can explain why");
            // 
            // textbox_Wrong
            // 
            this.textbox_Wrong.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textbox_Wrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_Wrong.Location = new System.Drawing.Point(52, 81);
            this.textbox_Wrong.Name = "textbox_Wrong";
            this.textbox_Wrong.Size = new System.Drawing.Size(270, 29);
            this.textbox_Wrong.TabIndex = 104;
            this.toolTip1.SetToolTip(this.textbox_Wrong, "ex.: If the answer is wrong you can explain why");
            // 
            // label_Puzzles
            // 
            this.label_Puzzles.AutoSize = true;
            this.label_Puzzles.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Puzzles.Location = new System.Drawing.Point(14, 302);
            this.label_Puzzles.Name = "label_Puzzles";
            this.label_Puzzles.Size = new System.Drawing.Size(34, 12);
            this.label_Puzzles.TabIndex = 103;
            this.label_Puzzles.Text = "Puzzles";
            // 
            // listbox_Puzzles_Rush
            // 
            this.listbox_Puzzles_Rush.ContextMenuStrip = this.contextRushMenu;
            this.listbox_Puzzles_Rush.FormattingEnabled = true;
            this.listbox_Puzzles_Rush.ItemHeight = 15;
            this.listbox_Puzzles_Rush.Location = new System.Drawing.Point(15, 317);
            this.listbox_Puzzles_Rush.Name = "listbox_Puzzles_Rush";
            this.listbox_Puzzles_Rush.Size = new System.Drawing.Size(311, 49);
            this.listbox_Puzzles_Rush.TabIndex = 102;
            this.listbox_Puzzles_Rush.SelectedIndexChanged += new System.EventHandler(this.Listbox_Puzzles_Rush_SelectedIndexChanged);
            // 
            // contextRushMenu
            // 
            this.contextRushMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextRushMenu.Name = "contextChaptersList";
            this.contextRushMenu.Size = new System.Drawing.Size(245, 56);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(244, 26);
            this.toolStripMenuItem4.Text = "Remove Selected Puzzle";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(244, 26);
            this.toolStripMenuItem5.Text = "Clear";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // label_Solutions
            // 
            this.label_Solutions.AutoSize = true;
            this.label_Solutions.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Solutions.Location = new System.Drawing.Point(13, 235);
            this.label_Solutions.Name = "label_Solutions";
            this.label_Solutions.Size = new System.Drawing.Size(43, 12);
            this.label_Solutions.TabIndex = 100;
            this.label_Solutions.Text = "Solutions:";
            // 
            // linkLabel_SCN
            // 
            this.linkLabel_SCN.AutoSize = true;
            this.linkLabel_SCN.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel_SCN.Location = new System.Drawing.Point(244, 595);
            this.linkLabel_SCN.Name = "linkLabel_SCN";
            this.linkLabel_SCN.Size = new System.Drawing.Size(77, 15);
            this.linkLabel_SCN.TabIndex = 99;
            this.linkLabel_SCN.TabStop = true;
            this.linkLabel_SCN.Text = "What is SCN?";
            this.linkLabel_SCN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // button_import_local
            // 
            this.button_import_local.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_import_local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_import_local.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_import_local.Location = new System.Drawing.Point(205, 650);
            this.button_import_local.Name = "button_import_local";
            this.button_import_local.Size = new System.Drawing.Size(117, 32);
            this.button_import_local.TabIndex = 98;
            this.button_import_local.Text = "Import SCN";
            this.button_import_local.UseVisualStyleBackColor = true;
            this.button_import_local.Click += new System.EventHandler(this.ImportSCN_Cllick);
            // 
            // label_SCNImport
            // 
            this.label_SCNImport.AutoSize = true;
            this.label_SCNImport.Location = new System.Drawing.Point(15, 598);
            this.label_SCNImport.Name = "label_SCNImport";
            this.label_SCNImport.Size = new System.Drawing.Size(178, 15);
            this.label_SCNImport.TabIndex = 97;
            this.label_SCNImport.Text = "position based on SCN notation:";
            // 
            // textBox_SCN
            // 
            this.textBox_SCN.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_SCN.Location = new System.Drawing.Point(15, 621);
            this.textBox_SCN.MaxLength = 64;
            this.textBox_SCN.Name = "textBox_SCN";
            this.textBox_SCN.Size = new System.Drawing.Size(306, 23);
            this.textBox_SCN.TabIndex = 96;
            // 
            // linkLabel_FEN
            // 
            this.linkLabel_FEN.AutoSize = true;
            this.linkLabel_FEN.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel_FEN.Location = new System.Drawing.Point(246, 694);
            this.linkLabel_FEN.Name = "linkLabel_FEN";
            this.linkLabel_FEN.Size = new System.Drawing.Size(75, 15);
            this.linkLabel_FEN.TabIndex = 95;
            this.linkLabel_FEN.TabStop = true;
            this.linkLabel_FEN.Text = "What is FEN?";
            this.linkLabel_FEN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label_FENImportLabel
            // 
            this.label_FENImportLabel.AutoSize = true;
            this.label_FENImportLabel.Location = new System.Drawing.Point(15, 685);
            this.label_FENImportLabel.Name = "label_FENImportLabel";
            this.label_FENImportLabel.Size = new System.Drawing.Size(176, 15);
            this.label_FENImportLabel.TabIndex = 94;
            this.label_FENImportLabel.Text = "position based on FEN notation:";
            // 
            // textBox_FEN
            // 
            this.textBox_FEN.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_FEN.Location = new System.Drawing.Point(12, 712);
            this.textBox_FEN.MaxLength = 80;
            this.textBox_FEN.Name = "textBox_FEN";
            this.textBox_FEN.Size = new System.Drawing.Size(309, 23);
            this.textBox_FEN.TabIndex = 93;
            // 
            // button_ImprtFEN
            // 
            this.button_ImprtFEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ImprtFEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ImprtFEN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ImprtFEN.Location = new System.Drawing.Point(206, 734);
            this.button_ImprtFEN.Name = "button_ImprtFEN";
            this.button_ImprtFEN.Size = new System.Drawing.Size(115, 32);
            this.button_ImprtFEN.TabIndex = 92;
            this.button_ImprtFEN.Text = "Import FEN";
            this.button_ImprtFEN.UseVisualStyleBackColor = true;
            this.button_ImprtFEN.Click += new System.EventHandler(this.ImportFEN_Click);
            // 
            // checkBox_AT
            // 
            this.checkBox_AT.AutoSize = true;
            this.checkBox_AT.Checked = true;
            this.checkBox_AT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_AT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_AT.Location = new System.Drawing.Point(4, 422);
            this.checkBox_AT.Name = "checkBox_AT";
            this.checkBox_AT.Size = new System.Drawing.Size(136, 19);
            this.checkBox_AT.TabIndex = 91;
            this.checkBox_AT.Text = "Automatic Transition";
            this.checkBox_AT.UseVisualStyleBackColor = true;
            // 
            // button_Transition
            // 
            this.button_Transition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Transition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Transition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Transition.Location = new System.Drawing.Point(170, 414);
            this.button_Transition.Name = "button_Transition";
            this.button_Transition.Size = new System.Drawing.Size(102, 30);
            this.button_Transition.TabIndex = 90;
            this.button_Transition.Text = "(T)ransition To";
            this.toolTip1.SetToolTip(this.button_Transition, "Create a chess position from given [square x square] string");
            this.button_Transition.UseVisualStyleBackColor = true;
            this.button_Transition.Click += new System.EventHandler(this.TransitionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, -104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 89;
            this.label6.Text = "Hint:";
            // 
            // textBox_hint
            // 
            this.textBox_hint.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_hint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_hint.Location = new System.Drawing.Point(52, 46);
            this.textBox_hint.Name = "textBox_hint";
            this.textBox_hint.Size = new System.Drawing.Size(270, 29);
            this.textBox_hint.TabIndex = 88;
            // 
            // listbox_Puzzle_Fragments
            // 
            this.listbox_Puzzle_Fragments.ContextMenuStrip = this.contextChaptersList;
            this.listbox_Puzzle_Fragments.FormattingEnabled = true;
            this.listbox_Puzzle_Fragments.ItemHeight = 15;
            this.listbox_Puzzle_Fragments.Location = new System.Drawing.Point(14, 250);
            this.listbox_Puzzle_Fragments.Name = "listbox_Puzzle_Fragments";
            this.listbox_Puzzle_Fragments.Size = new System.Drawing.Size(311, 49);
            this.listbox_Puzzle_Fragments.TabIndex = 87;
            // 
            // contextChaptersList
            // 
            this.contextChaptersList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadChapterToolStripMenuItem,
            this.editChapterWithCurrentFieldsToolStripMenuItem,
            this.toolStripSeparator6,
            this.removeLastChapterToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.clearPuzzleToolStripMenuItem});
            this.contextChaptersList.Name = "contextChaptersList";
            this.contextChaptersList.Size = new System.Drawing.Size(438, 140);
            // 
            // loadChapterToolStripMenuItem
            // 
            this.loadChapterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadChapterToolStripMenuItem.Name = "loadChapterToolStripMenuItem";
            this.loadChapterToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.loadChapterToolStripMenuItem.Text = "Load This Chapter";
            this.loadChapterToolStripMenuItem.Click += new System.EventHandler(this.LoadChapterToolStripMenuItem_Click);
            // 
            // editChapterWithCurrentFieldsToolStripMenuItem
            // 
            this.editChapterWithCurrentFieldsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editChapterWithCurrentFieldsToolStripMenuItem.Name = "editChapterWithCurrentFieldsToolStripMenuItem";
            this.editChapterWithCurrentFieldsToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.editChapterWithCurrentFieldsToolStripMenuItem.Text = "Change This Chapter With The Current Composition";
            this.editChapterWithCurrentFieldsToolStripMenuItem.Click += new System.EventHandler(this.ChangeChhapterWithCurrenctComposition_click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(434, 6);
            // 
            // removeLastChapterToolStripMenuItem
            // 
            this.removeLastChapterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeLastChapterToolStripMenuItem.Name = "removeLastChapterToolStripMenuItem";
            this.removeLastChapterToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.removeLastChapterToolStripMenuItem.Text = "Remove Last Chapter";
            this.removeLastChapterToolStripMenuItem.Click += new System.EventHandler(this.RemoveLastChapterToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.clearToolStripMenuItem.Text = "Clear Puzzle";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // clearPuzzleToolStripMenuItem
            // 
            this.clearPuzzleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearPuzzleToolStripMenuItem.Name = "clearPuzzleToolStripMenuItem";
            this.clearPuzzleToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.clearPuzzleToolStripMenuItem.Text = "Clear List Only";
            this.clearPuzzleToolStripMenuItem.Click += new System.EventHandler(this.ClearPuzzleToolStripMenuItem_Click);
            // 
            // button_Add
            // 
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(255, 385);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(68, 23);
            this.button_Add.TabIndex = 86;
            this.button_Add.Text = "(A)dd";
            this.toolTip1.SetToolTip(this.button_Add, "Add new chapter");
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            this.button_Add.MouseEnter += new System.EventHandler(this.Button_Add_MouseEnter);
            this.button_Add.MouseLeave += new System.EventHandler(this.Button_Add_MouseLeave);
            // 
            // c_number2
            // 
            this.c_number2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_number2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_number2.FormattingEnabled = true;
            this.c_number2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.c_number2.Location = new System.Drawing.Point(220, 385);
            this.c_number2.Name = "c_number2";
            this.c_number2.Size = new System.Drawing.Size(31, 23);
            this.c_number2.TabIndex = 85;
            // 
            // c_letter2
            // 
            this.c_letter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_letter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_letter2.FormattingEnabled = true;
            this.c_letter2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.c_letter2.Location = new System.Drawing.Point(183, 385);
            this.c_letter2.Name = "c_letter2";
            this.c_letter2.Size = new System.Drawing.Size(31, 23);
            this.c_letter2.TabIndex = 84;
            // 
            // label_Takesto
            // 
            this.label_Takesto.AutoSize = true;
            this.label_Takesto.Location = new System.Drawing.Point(131, 388);
            this.label_Takesto.Name = "label_Takesto";
            this.label_Takesto.Size = new System.Drawing.Size(50, 15);
            this.label_Takesto.TabIndex = 83;
            this.label_Takesto.Text = "takes/to";
            // 
            // c_number1
            // 
            this.c_number1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_number1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_number1.FormattingEnabled = true;
            this.c_number1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.c_number1.Location = new System.Drawing.Point(94, 385);
            this.c_number1.Name = "c_number1";
            this.c_number1.Size = new System.Drawing.Size(31, 23);
            this.c_number1.TabIndex = 82;
            // 
            // c_letter1
            // 
            this.c_letter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_letter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_letter1.FormattingEnabled = true;
            this.c_letter1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.c_letter1.Location = new System.Drawing.Point(57, 385);
            this.c_letter1.Name = "c_letter1";
            this.c_letter1.Size = new System.Drawing.Size(31, 23);
            this.c_letter1.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 30);
            this.label2.TabIndex = 80;
            this.label2.Text = "Given\r\nSolution:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(18, -140);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(42, 15);
            this.label_name.TabIndex = 79;
            this.label_name.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.ContextMenuStrip = this.contextMenu_TextBoxes;
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(52, 11);
            this.textBox_name.MaxLength = 50;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(270, 29);
            this.textBox_name.TabIndex = 78;
            this.toolTip1.SetToolTip(this.textBox_name, "Every puzzle or puzzle rush has to have a name");
            // 
            // panel_generate
            // 
            this.panel_generate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_generate.Controls.Add(this.linkLabel_Dif);
            this.panel_generate.Controls.Add(this.checkBox_Making_PR);
            this.panel_generate.Controls.Add(this.button_Generate_P);
            this.panel_generate.Controls.Add(this.button_generate_PR);
            this.panel_generate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_generate.Location = new System.Drawing.Point(3, 602);
            this.panel_generate.Name = "panel_generate";
            this.panel_generate.Size = new System.Drawing.Size(359, 100);
            this.panel_generate.TabIndex = 101;
            // 
            // linkLabel_Dif
            // 
            this.linkLabel_Dif.AutoSize = true;
            this.linkLabel_Dif.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel_Dif.Location = new System.Drawing.Point(2, 34);
            this.linkLabel_Dif.Name = "linkLabel_Dif";
            this.linkLabel_Dif.Size = new System.Drawing.Size(124, 15);
            this.linkLabel_Dif.TabIndex = 61;
            this.linkLabel_Dif.TabStop = true;
            this.linkLabel_Dif.Text = "What\'s the difference?";
            this.linkLabel_Dif.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Diffenrence_click);
            // 
            // checkBox_Making_PR
            // 
            this.checkBox_Making_PR.AutoSize = true;
            this.checkBox_Making_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Making_PR.Location = new System.Drawing.Point(2, 3);
            this.checkBox_Making_PR.Name = "checkBox_Making_PR";
            this.checkBox_Making_PR.Size = new System.Drawing.Size(166, 19);
            this.checkBox_Making_PR.TabIndex = 60;
            this.checkBox_Making_PR.Text = "I am making a Puzzle Rush";
            this.checkBox_Making_PR.UseVisualStyleBackColor = true;
            this.checkBox_Making_PR.CheckedChanged += new System.EventHandler(this.CheckBox_Making_PR_CheckedChanged);
            // 
            // button_Generate_P
            // 
            this.button_Generate_P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Generate_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Generate_P.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Generate_P.Location = new System.Drawing.Point(198, 3);
            this.button_Generate_P.Name = "button_Generate_P";
            this.button_Generate_P.Size = new System.Drawing.Size(155, 32);
            this.button_Generate_P.TabIndex = 3;
            this.button_Generate_P.Text = "(G)enerate Puzzle";
            this.button_Generate_P.UseVisualStyleBackColor = true;
            this.button_Generate_P.Click += new System.EventHandler(this.GeneratePuzzle_Click);
            this.button_Generate_P.MouseEnter += new System.EventHandler(this.Button_Generate_P_MouseEnter);
            this.button_Generate_P.MouseLeave += new System.EventHandler(this.Button_Generate_P_MouseLeave);
            // 
            // button_generate_PR
            // 
            this.button_generate_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_generate_PR.Enabled = false;
            this.button_generate_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate_PR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_generate_PR.Location = new System.Drawing.Point(138, 63);
            this.button_generate_PR.Name = "button_generate_PR";
            this.button_generate_PR.Size = new System.Drawing.Size(215, 32);
            this.button_generate_PR.TabIndex = 59;
            this.button_generate_PR.Text = "Generate Puz(z)le Rush";
            this.button_generate_PR.UseVisualStyleBackColor = true;
            this.button_generate_PR.Click += new System.EventHandler(this.Button_generate_PR_Click);
            this.button_generate_PR.MouseEnter += new System.EventHandler(this.Button_generate_PR_MouseEnter);
            this.button_generate_PR.MouseLeave += new System.EventHandler(this.Button_generate_PR_MouseLeave);
            // 
            // button_hint
            // 
            this.button_hint.BackColor = System.Drawing.Color.Transparent;
            this.button_hint.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.dol;
            this.button_hint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_hint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hint.FlatAppearance.BorderSize = 0;
            this.button_hint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hint.Location = new System.Drawing.Point(555, 14);
            this.button_hint.Name = "button_hint";
            this.button_hint.Size = new System.Drawing.Size(50, 50);
            this.button_hint.TabIndex = 39;
            this.toolTip1.SetToolTip(this.button_hint, "Hint");
            this.button_hint.UseVisualStyleBackColor = false;
            this.button_hint.Click += new System.EventHandler(this.Button_hint_Click);
            // 
            // label_solution_chapter
            // 
            this.label_solution_chapter.AutoSize = true;
            this.label_solution_chapter.BackColor = System.Drawing.Color.Transparent;
            this.label_solution_chapter.Location = new System.Drawing.Point(427, 12);
            this.label_solution_chapter.Name = "label_solution_chapter";
            this.label_solution_chapter.Size = new System.Drawing.Size(0, 15);
            this.label_solution_chapter.TabIndex = 40;
            // 
            // menuChangeSquare
            // 
            this.menuChangeSquare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.eMPYToolStripMenuItem,
            this.toolStripSeparator4,
            this.thisIsAttackerToolStripMenuItem,
            this.thisIsAttackedToolStripMenuItem,
            this.toolStripSeparator5,
            this.thisIsPrepuzzleStartToolStripMenuItem,
            this.thisIsPrePuzzleEndToolStripMenuItem});
            this.menuChangeSquare.Name = "menuChangeSquare";
            this.menuChangeSquare.Size = new System.Drawing.Size(280, 210);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whitePawnToolStripMenuItem,
            this.whiteRookToolStripMenuItem,
            this.whiteQueenToolStripMenuItem,
            this.whiteKingToolStripMenuItem1,
            this.whiteBishopToolStripMenuItem1,
            this.whiteKnightToolStripMenuItem1});
            this.whiteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whiteToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.white;
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.whiteToolStripMenuItem.Text = "White";
            // 
            // whitePawnToolStripMenuItem
            // 
            this.whitePawnToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.pawn_white;
            this.whitePawnToolStripMenuItem.Name = "whitePawnToolStripMenuItem";
            this.whitePawnToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+1";
            this.whitePawnToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.whitePawnToolStripMenuItem.Text = "White Pawn";
            this.whitePawnToolStripMenuItem.Click += new System.EventHandler(this.WhitePawnToolStripMenuItem_Click);
            // 
            // whiteRookToolStripMenuItem
            // 
            this.whiteRookToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.rook_white;
            this.whiteRookToolStripMenuItem.Name = "whiteRookToolStripMenuItem";
            this.whiteRookToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+2";
            this.whiteRookToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.whiteRookToolStripMenuItem.Text = "White Rook";
            this.whiteRookToolStripMenuItem.Click += new System.EventHandler(this.WhiteRookToolStripMenuItem_Click);
            // 
            // whiteQueenToolStripMenuItem
            // 
            this.whiteQueenToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.queen_white;
            this.whiteQueenToolStripMenuItem.Name = "whiteQueenToolStripMenuItem";
            this.whiteQueenToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+3";
            this.whiteQueenToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.whiteQueenToolStripMenuItem.Text = "White Queen";
            this.whiteQueenToolStripMenuItem.Click += new System.EventHandler(this.WhiteQueenToolStripMenuItem_Click);
            // 
            // whiteKingToolStripMenuItem1
            // 
            this.whiteKingToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.king_white;
            this.whiteKingToolStripMenuItem1.Name = "whiteKingToolStripMenuItem1";
            this.whiteKingToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+4";
            this.whiteKingToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.whiteKingToolStripMenuItem1.Text = "White King";
            this.whiteKingToolStripMenuItem1.Click += new System.EventHandler(this.WhiteKingToolStripMenuItem1_Click);
            // 
            // whiteBishopToolStripMenuItem1
            // 
            this.whiteBishopToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.bishop_white;
            this.whiteBishopToolStripMenuItem1.Name = "whiteBishopToolStripMenuItem1";
            this.whiteBishopToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+5";
            this.whiteBishopToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.whiteBishopToolStripMenuItem1.Text = "White Bishop";
            this.whiteBishopToolStripMenuItem1.Click += new System.EventHandler(this.WhiteBishopToolStripMenuItem1_Click);
            // 
            // whiteKnightToolStripMenuItem1
            // 
            this.whiteKnightToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.knight_white;
            this.whiteKnightToolStripMenuItem1.Name = "whiteKnightToolStripMenuItem1";
            this.whiteKnightToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+6";
            this.whiteKnightToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.whiteKnightToolStripMenuItem1.Text = "White Knight";
            this.whiteKnightToolStripMenuItem1.Click += new System.EventHandler(this.WhiteKnightToolStripMenuItem1_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackPawnToolStripMenuItem1,
            this.blackRookToolStripMenuItem1,
            this.blackQueenToolStripMenuItem1,
            this.blackKingToolStripMenuItem1,
            this.blackBishopToolStripMenuItem1,
            this.blackKnightToolStripMenuItem1});
            this.blackToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blackToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.pitchBlack;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // blackPawnToolStripMenuItem1
            // 
            this.blackPawnToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.pawn_black;
            this.blackPawnToolStripMenuItem1.Name = "blackPawnToolStripMenuItem1";
            this.blackPawnToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+1";
            this.blackPawnToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.blackPawnToolStripMenuItem1.Text = "Black Pawn";
            this.blackPawnToolStripMenuItem1.Click += new System.EventHandler(this.BlackPawnToolStripMenuItem1_Click);
            // 
            // blackRookToolStripMenuItem1
            // 
            this.blackRookToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.rook_black;
            this.blackRookToolStripMenuItem1.Name = "blackRookToolStripMenuItem1";
            this.blackRookToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+2";
            this.blackRookToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.blackRookToolStripMenuItem1.Text = "Black Rook";
            this.blackRookToolStripMenuItem1.Click += new System.EventHandler(this.BlackRookToolStripMenuItem1_Click);
            // 
            // blackQueenToolStripMenuItem1
            // 
            this.blackQueenToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.queen_black;
            this.blackQueenToolStripMenuItem1.Name = "blackQueenToolStripMenuItem1";
            this.blackQueenToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+3";
            this.blackQueenToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.blackQueenToolStripMenuItem1.Text = "Black Queen";
            this.blackQueenToolStripMenuItem1.Click += new System.EventHandler(this.BlackQueenToolStripMenuItem1_Click);
            // 
            // blackKingToolStripMenuItem1
            // 
            this.blackKingToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.king_black;
            this.blackKingToolStripMenuItem1.Name = "blackKingToolStripMenuItem1";
            this.blackKingToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+4";
            this.blackKingToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.blackKingToolStripMenuItem1.Text = "Black King";
            this.blackKingToolStripMenuItem1.Click += new System.EventHandler(this.BlackKingToolStripMenuItem1_Click);
            // 
            // blackBishopToolStripMenuItem1
            // 
            this.blackBishopToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.bishop_black;
            this.blackBishopToolStripMenuItem1.Name = "blackBishopToolStripMenuItem1";
            this.blackBishopToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+5";
            this.blackBishopToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.blackBishopToolStripMenuItem1.Text = "Black Bishop";
            this.blackBishopToolStripMenuItem1.Click += new System.EventHandler(this.BlackBishopToolStripMenuItem1_Click);
            // 
            // blackKnightToolStripMenuItem1
            // 
            this.blackKnightToolStripMenuItem1.Image = global::Chezz_Puzzler.Properties.Resources.king_black;
            this.blackKnightToolStripMenuItem1.Name = "blackKnightToolStripMenuItem1";
            this.blackKnightToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+6";
            this.blackKnightToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.blackKnightToolStripMenuItem1.Text = "Black Knight";
            this.blackKnightToolStripMenuItem1.Click += new System.EventHandler(this.BlBckKnightToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(276, 6);
            // 
            // eMPYToolStripMenuItem
            // 
            this.eMPYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eMPYToolStripMenuItem.Name = "eMPYToolStripMenuItem";
            this.eMPYToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.eMPYToolStripMenuItem.Text = "EMPY";
            this.eMPYToolStripMenuItem.Click += new System.EventHandler(this.EMPYToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(276, 6);
            // 
            // thisIsAttackerToolStripMenuItem
            // 
            this.thisIsAttackerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thisIsAttackerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thisIsAttackerToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.tosquare1;
            this.thisIsAttackerToolStripMenuItem.Name = "thisIsAttackerToolStripMenuItem";
            this.thisIsAttackerToolStripMenuItem.ShortcutKeyDisplayString = "1";
            this.thisIsAttackerToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.thisIsAttackerToolStripMenuItem.Text = "This is Attacker";
            this.thisIsAttackerToolStripMenuItem.Click += new System.EventHandler(this.ThisIsAttackerToolStripMenuItem_Click);
            // 
            // thisIsAttackedToolStripMenuItem
            // 
            this.thisIsAttackedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thisIsAttackedToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.tosquare1;
            this.thisIsAttackedToolStripMenuItem.Name = "thisIsAttackedToolStripMenuItem";
            this.thisIsAttackedToolStripMenuItem.ShortcutKeyDisplayString = "2";
            this.thisIsAttackedToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.thisIsAttackedToolStripMenuItem.Text = "This is Attacked";
            this.thisIsAttackedToolStripMenuItem.Click += new System.EventHandler(this.ThisIsAttackedToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(276, 6);
            // 
            // thisIsPrepuzzleStartToolStripMenuItem
            // 
            this.thisIsPrepuzzleStartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thisIsPrepuzzleStartToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.go_to;
            this.thisIsPrepuzzleStartToolStripMenuItem.Name = "thisIsPrepuzzleStartToolStripMenuItem";
            this.thisIsPrepuzzleStartToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.thisIsPrepuzzleStartToolStripMenuItem.Text = "This is last move played, start";
            this.thisIsPrepuzzleStartToolStripMenuItem.Click += new System.EventHandler(this.ThisIsPrepuzzleStartToolStripMenuItem_Click);
            // 
            // thisIsPrePuzzleEndToolStripMenuItem
            // 
            this.thisIsPrePuzzleEndToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thisIsPrePuzzleEndToolStripMenuItem.Image = global::Chezz_Puzzler.Properties.Resources.go_to;
            this.thisIsPrePuzzleEndToolStripMenuItem.Name = "thisIsPrePuzzleEndToolStripMenuItem";
            this.thisIsPrePuzzleEndToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.thisIsPrePuzzleEndToolStripMenuItem.Text = "This is last move played, end";
            this.thisIsPrePuzzleEndToolStripMenuItem.Click += new System.EventHandler(this.ThisIsPrePuzzleEndToolStripMenuItem_Click);
            // 
            // label_chapterCounter
            // 
            this.label_chapterCounter.BackColor = System.Drawing.Color.Transparent;
            this.label_chapterCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_chapterCounter.Location = new System.Drawing.Point(547, 287);
            this.label_chapterCounter.Name = "label_chapterCounter";
            this.label_chapterCounter.Size = new System.Drawing.Size(67, 21);
            this.label_chapterCounter.TabIndex = 45;
            this.label_chapterCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_chapterCounter.Visible = false;
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.BackColor = System.Drawing.Color.Transparent;
            this.label_hint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_hint.Location = new System.Drawing.Point(614, 31);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(0, 15);
            this.label_hint.TabIndex = 46;
            this.label_hint.Visible = false;
            // 
            // label_square_displayer
            // 
            this.label_square_displayer.AutoSize = true;
            this.label_square_displayer.BackColor = System.Drawing.Color.Transparent;
            this.label_square_displayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_square_displayer.Location = new System.Drawing.Point(552, 15);
            this.label_square_displayer.Name = "label_square_displayer";
            this.label_square_displayer.Size = new System.Drawing.Size(20, 25);
            this.label_square_displayer.TabIndex = 47;
            this.label_square_displayer.Text = "_";
            this.label_square_displayer.Visible = false;
            // 
            // label_Action_Response
            // 
            this.label_Action_Response.BackColor = System.Drawing.Color.Transparent;
            this.label_Action_Response.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Action_Response.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Action_Response.Location = new System.Drawing.Point(0, 95);
            this.label_Action_Response.Name = "label_Action_Response";
            this.label_Action_Response.Size = new System.Drawing.Size(520, 25);
            this.label_Action_Response.TabIndex = 48;
            this.label_Action_Response.Text = "To move: player";
            this.label_Action_Response.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Action_Response.Visible = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bottom.Controls.Add(this.button_settings);
            this.panel_bottom.Controls.Add(this.checkBox_AU_Reset);
            this.panel_bottom.Controls.Add(this.checkBox_UseBG);
            this.panel_bottom.Controls.Add(this.checkBox_autoPR);
            this.panel_bottom.Controls.Add(this.button1);
            this.panel_bottom.Controls.Add(this.checkBox_hotkeys);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 733);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1404, 58);
            this.panel_bottom.TabIndex = 49;
            // 
            // button_settings
            // 
            this.button_settings.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.cog;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Location = new System.Drawing.Point(617, 15);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(30, 30);
            this.button_settings.TabIndex = 54;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.Button9_Click);
            // 
            // checkBox_AU_Reset
            // 
            this.checkBox_AU_Reset.AutoSize = true;
            this.checkBox_AU_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_AU_Reset.Location = new System.Drawing.Point(321, 32);
            this.checkBox_AU_Reset.Name = "checkBox_AU_Reset";
            this.checkBox_AU_Reset.Size = new System.Drawing.Size(279, 19);
            this.checkBox_AU_Reset.TabIndex = 58;
            this.checkBox_AU_Reset.Text = "Automatically restart the currently solved puzzle\r\n";
            this.checkBox_AU_Reset.UseVisualStyleBackColor = true;
            this.checkBox_AU_Reset.CheckedChanged += new System.EventHandler(this.CheckBox_AU_Reset_CheckedChanged);
            // 
            // checkBox_UseBG
            // 
            this.checkBox_UseBG.AutoSize = true;
            this.checkBox_UseBG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_UseBG.Location = new System.Drawing.Point(108, 7);
            this.checkBox_UseBG.Name = "checkBox_UseBG";
            this.checkBox_UseBG.Size = new System.Drawing.Size(148, 19);
            this.checkBox_UseBG.TabIndex = 57;
            this.checkBox_UseBG.Text = "Use background Image";
            this.checkBox_UseBG.UseVisualStyleBackColor = true;
            this.checkBox_UseBG.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox_autoPR
            // 
            this.checkBox_autoPR.AutoSize = true;
            this.checkBox_autoPR.Checked = true;
            this.checkBox_autoPR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_autoPR.Location = new System.Drawing.Point(11, 32);
            this.checkBox_autoPR.Name = "checkBox_autoPR";
            this.checkBox_autoPR.Size = new System.Drawing.Size(297, 19);
            this.checkBox_autoPR.TabIndex = 56;
            this.checkBox_autoPR.Text = "Automatically go to the next puzzle in a puzzle rush";
            this.checkBox_autoPR.UseVisualStyleBackColor = true;
            this.checkBox_autoPR.CheckedChanged += new System.EventHandler(this.CheckBox_autoPR_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.help;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1366, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // checkBox_hotkeys
            // 
            this.checkBox_hotkeys.AutoSize = true;
            this.checkBox_hotkeys.Checked = true;
            this.checkBox_hotkeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_hotkeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_hotkeys.Location = new System.Drawing.Point(11, 7);
            this.checkBox_hotkeys.Name = "checkBox_hotkeys";
            this.checkBox_hotkeys.Size = new System.Drawing.Size(91, 19);
            this.checkBox_hotkeys.TabIndex = 50;
            this.checkBox_hotkeys.Text = "Use Hotkeys";
            this.checkBox_hotkeys.UseVisualStyleBackColor = true;
            this.checkBox_hotkeys.CheckedChanged += new System.EventHandler(this.CheckBox_hotkeys_CheckedChanged);
            // 
            // context_options
            // 
            this.context_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorOfWhiteSquareToolStripMenuItem,
            this.changeColorOfBlackSquaresToolStripMenuItem,
            this.changeHightlightedSquareColorToolStripMenuItem,
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem,
            this.changeLastMoveHightlightColorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setCountdownToolStripMenuItem,
            this.changeResponseTimeOfPlayer2ToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.context_options.Name = "context_options";
            this.context_options.Size = new System.Drawing.Size(367, 238);
            // 
            // changeColorOfWhiteSquareToolStripMenuItem
            // 
            this.changeColorOfWhiteSquareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeColorOfWhiteSquareToolStripMenuItem.Name = "changeColorOfWhiteSquareToolStripMenuItem";
            this.changeColorOfWhiteSquareToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.changeColorOfWhiteSquareToolStripMenuItem.Text = "Change Color of White Squares...";
            this.changeColorOfWhiteSquareToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorOfWhiteSquareToolStripMenuItem_Click);
            // 
            // changeColorOfBlackSquaresToolStripMenuItem
            // 
            this.changeColorOfBlackSquaresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeColorOfBlackSquaresToolStripMenuItem.Name = "changeColorOfBlackSquaresToolStripMenuItem";
            this.changeColorOfBlackSquaresToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.changeColorOfBlackSquaresToolStripMenuItem.Text = "Change Color of Black Squares...";
            this.changeColorOfBlackSquaresToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorOfBlackSquaresToolStripMenuItem_Click);
            // 
            // changeHightlightedSquareColorToolStripMenuItem
            // 
            this.changeHightlightedSquareColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeHightlightedSquareColorToolStripMenuItem.Name = "changeHightlightedSquareColorToolStripMenuItem";
            this.changeHightlightedSquareColorToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.changeHightlightedSquareColorToolStripMenuItem.Text = "Change Selected Square\'s Color...";
            this.changeHightlightedSquareColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeHightlightedSquareColorToolStripMenuItem_Click);
            // 
            // changeTheHoverColorOfTheSquaresToolStripMenuItem
            // 
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem.Name = "changeTheHoverColorOfTheSquaresToolStripMenuItem";
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem.Text = "Change The Hover Color Of The Squares...";
            this.changeTheHoverColorOfTheSquaresToolStripMenuItem.Click += new System.EventHandler(this.ChangeTheHoverColorOfTheSquaresToolStripMenuItem_Click);
            // 
            // changeLastMoveHightlightColorToolStripMenuItem
            // 
            this.changeLastMoveHightlightColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeLastMoveHightlightColorToolStripMenuItem.Name = "changeLastMoveHightlightColorToolStripMenuItem";
            this.changeLastMoveHightlightColorToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.changeLastMoveHightlightColorToolStripMenuItem.Text = "Change Last Move Hightlight\'s Color...";
            this.changeLastMoveHightlightColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeLastMoveHightlightColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(366, 26);
            this.toolStripMenuItem1.Text = "Set Current Countdown...";
            // 
            // setCountdownToolStripMenuItem
            // 
            this.setCountdownToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setCountdownToolStripMenuItem.Name = "setCountdownToolStripMenuItem";
            this.setCountdownToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.setCountdownToolStripMenuItem.Text = "Set Default Countdown...";
            // 
            // changeResponseTimeOfPlayer2ToolStripMenuItem
            // 
            this.changeResponseTimeOfPlayer2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeResponseTimeOfPlayer2ToolStripMenuItem.Name = "changeResponseTimeOfPlayer2ToolStripMenuItem";
            this.changeResponseTimeOfPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.changeResponseTimeOfPlayer2ToolStripMenuItem.Text = "Change response time of player 2...";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.ResetAllToolStripMenuItem_Click);
            // 
            // button_show_solution
            // 
            this.button_show_solution.BackColor = System.Drawing.Color.Transparent;
            this.button_show_solution.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.solution1;
            this.button_show_solution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_show_solution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_show_solution.FlatAppearance.BorderSize = 0;
            this.button_show_solution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_solution.Location = new System.Drawing.Point(555, 70);
            this.button_show_solution.Name = "button_show_solution";
            this.button_show_solution.Size = new System.Drawing.Size(50, 50);
            this.button_show_solution.TabIndex = 50;
            this.toolTip1.SetToolTip(this.button_show_solution, "Show solution");
            this.button_show_solution.UseVisualStyleBackColor = false;
            this.button_show_solution.Click += new System.EventHandler(this.Showsolution_Click);
            // 
            // label_show_solution
            // 
            this.label_show_solution.AutoSize = true;
            this.label_show_solution.Location = new System.Drawing.Point(611, 86);
            this.label_show_solution.Name = "label_show_solution";
            this.label_show_solution.Size = new System.Drawing.Size(0, 15);
            this.label_show_solution.TabIndex = 51;
            // 
            // button_export_Local
            // 
            this.button_export_Local.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_export_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export_Local.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_export_Local.Location = new System.Drawing.Point(3, 3);
            this.button_export_Local.Name = "button_export_Local";
            this.button_export_Local.Size = new System.Drawing.Size(180, 32);
            this.button_export_Local.TabIndex = 52;
            this.button_export_Local.Text = "Export position as SCN";
            this.button_export_Local.UseVisualStyleBackColor = true;
            this.button_export_Local.Click += new System.EventHandler(this.DisplaySCNCopyDialog);
            this.button_export_Local.MouseEnter += new System.EventHandler(this.Button_export_Local_MouseEnter);
            this.button_export_Local.MouseLeave += new System.EventHandler(this.Button_export_Local_MouseLeave);
            // 
            // button_export_FEN
            // 
            this.button_export_FEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_export_FEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export_FEN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_export_FEN.Location = new System.Drawing.Point(189, 3);
            this.button_export_FEN.Name = "button_export_FEN";
            this.button_export_FEN.Size = new System.Drawing.Size(167, 32);
            this.button_export_FEN.TabIndex = 53;
            this.button_export_FEN.Text = "Export position as FEN";
            this.button_export_FEN.UseVisualStyleBackColor = true;
            this.button_export_FEN.Click += new System.EventHandler(this.ExportAsFEN_Click);
            this.button_export_FEN.MouseEnter += new System.EventHandler(this.Button_export_FEN_MouseEnter);
            this.button_export_FEN.MouseLeave += new System.EventHandler(this.Button_export_FEN_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_export_Local);
            this.panel1.Controls.Add(this.button_export_FEN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 680);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 53);
            this.panel1.TabIndex = 54;
            // 
            // label_a
            // 
            this.label_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_a.Location = new System.Drawing.Point(21, 533);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(66, 18);
            this.label_a.TabIndex = 56;
            this.label_a.Text = "a";
            this.label_a.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_b
            // 
            this.label_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_b.Location = new System.Drawing.Point(87, 533);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(66, 18);
            this.label_b.TabIndex = 57;
            this.label_b.Text = "b";
            this.label_b.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_d
            // 
            this.label_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_d.Location = new System.Drawing.Point(219, 533);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(66, 18);
            this.label_d.TabIndex = 59;
            this.label_d.Text = "d";
            this.label_d.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_c
            // 
            this.label_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_c.Location = new System.Drawing.Point(153, 533);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(66, 18);
            this.label_c.TabIndex = 58;
            this.label_c.Text = "c";
            this.label_c.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_h
            // 
            this.label_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_h.Location = new System.Drawing.Point(475, 533);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(66, 18);
            this.label_h.TabIndex = 63;
            this.label_h.Text = "h";
            this.label_h.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_g
            // 
            this.label_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_g.Location = new System.Drawing.Point(409, 533);
            this.label_g.Name = "label_g";
            this.label_g.Size = new System.Drawing.Size(66, 18);
            this.label_g.TabIndex = 62;
            this.label_g.Text = "g";
            this.label_g.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_f
            // 
            this.label_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_f.Location = new System.Drawing.Point(343, 533);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(66, 18);
            this.label_f.TabIndex = 61;
            this.label_f.Text = "f";
            this.label_f.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_e
            // 
            this.label_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_e.Location = new System.Drawing.Point(277, 533);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(66, 18);
            this.label_e.TabIndex = 60;
            this.label_e.Text = "e";
            this.label_e.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_8
            // 
            this.label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_8.Location = new System.Drawing.Point(3, 12);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(18, 66);
            this.label_8.TabIndex = 64;
            this.label_8.Text = "8";
            this.label_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_7
            // 
            this.label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_7.Location = new System.Drawing.Point(3, 73);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(18, 66);
            this.label_7.TabIndex = 65;
            this.label_7.Text = "7";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_5
            // 
            this.label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_5.Location = new System.Drawing.Point(3, 200);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(18, 66);
            this.label_5.TabIndex = 67;
            this.label_5.Text = "5";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_6
            // 
            this.label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_6.Location = new System.Drawing.Point(3, 139);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(18, 66);
            this.label_6.TabIndex = 66;
            this.label_6.Text = "6";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_1
            // 
            this.label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_1.Location = new System.Drawing.Point(3, 465);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(18, 66);
            this.label_1.TabIndex = 71;
            this.label_1.Text = "1";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_2
            // 
            this.label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_2.Location = new System.Drawing.Point(3, 399);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(18, 66);
            this.label_2.TabIndex = 70;
            this.label_2.Text = "2";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_3
            // 
            this.label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_3.Location = new System.Drawing.Point(3, 333);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(18, 66);
            this.label_3.TabIndex = 69;
            this.label_3.Text = "3";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_4
            // 
            this.label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_4.Location = new System.Drawing.Point(3, 266);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(18, 66);
            this.label_4.TabIndex = 68;
            this.label_4.Text = "4";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_Timer_Puzzle
            // 
            this.menu_Timer_Puzzle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.menu_Timer_Puzzle.Name = "contextMenuStripTimerLabel";
            this.menu_Timer_Puzzle.Size = new System.Drawing.Size(134, 108);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.ResumeToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // label_move_wrong
            // 
            this.label_move_wrong.AutoSize = true;
            this.label_move_wrong.BackColor = System.Drawing.Color.Transparent;
            this.label_move_wrong.Location = new System.Drawing.Point(611, 200);
            this.label_move_wrong.Name = "label_move_wrong";
            this.label_move_wrong.Size = new System.Drawing.Size(0, 15);
            this.label_move_wrong.TabIndex = 74;
            // 
            // label_move_right
            // 
            this.label_move_right.AutoSize = true;
            this.label_move_right.BackColor = System.Drawing.Color.Transparent;
            this.label_move_right.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_move_right.Location = new System.Drawing.Point(603, 262);
            this.label_move_right.Name = "label_move_right";
            this.label_move_right.Size = new System.Drawing.Size(0, 15);
            this.label_move_right.TabIndex = 75;
            // 
            // panel_cd_event_toMove
            // 
            this.panel_cd_event_toMove.BackColor = System.Drawing.Color.Transparent;
            this.panel_cd_event_toMove.Controls.Add(this.label_event);
            this.panel_cd_event_toMove.Controls.Add(this.label_Countdown_Puzzle);
            this.panel_cd_event_toMove.Controls.Add(this.label_Countdown_Global);
            this.panel_cd_event_toMove.Controls.Add(this.label_Action_Response);
            this.panel_cd_event_toMove.Location = new System.Drawing.Point(27, 556);
            this.panel_cd_event_toMove.Name = "panel_cd_event_toMove";
            this.panel_cd_event_toMove.Size = new System.Drawing.Size(520, 120);
            this.panel_cd_event_toMove.TabIndex = 78;
            // 
            // label_event
            // 
            this.label_event.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_event.Location = new System.Drawing.Point(0, 0);
            this.label_event.Name = "label_event";
            this.label_event.Size = new System.Drawing.Size(520, 35);
            this.label_event.TabIndex = 80;
            this.label_event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Countdown_Puzzle
            // 
            this.label_Countdown_Puzzle.ContextMenuStrip = this.menu_Timer_Puzzle;
            this.label_Countdown_Puzzle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Countdown_Puzzle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Countdown_Puzzle.Location = new System.Drawing.Point(0, 35);
            this.label_Countdown_Puzzle.Name = "label_Countdown_Puzzle";
            this.label_Countdown_Puzzle.Size = new System.Drawing.Size(520, 30);
            this.label_Countdown_Puzzle.TabIndex = 79;
            this.label_Countdown_Puzzle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Countdown_Global
            // 
            this.label_Countdown_Global.ContextMenuStrip = this.menu_global;
            this.label_Countdown_Global.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Countdown_Global.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Countdown_Global.Location = new System.Drawing.Point(0, 65);
            this.label_Countdown_Global.Name = "label_Countdown_Global";
            this.label_Countdown_Global.Size = new System.Drawing.Size(520, 30);
            this.label_Countdown_Global.TabIndex = 78;
            this.label_Countdown_Global.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_global
            // 
            this.menu_global.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.menu_global.Name = "contextMenuStripTimerLabel";
            this.menu_global.Size = new System.Drawing.Size(134, 108);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItem2.Text = "Pause";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItem3.Text = "Resume";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItem6.Text = "Stop";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItem7.Text = "Restart";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
            // 
            // button_GenerateStartingChessPosition
            // 
            this.button_GenerateStartingChessPosition.BackColor = System.Drawing.Color.Transparent;
            this.button_GenerateStartingChessPosition.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.chess_set4;
            this.button_GenerateStartingChessPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GenerateStartingChessPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GenerateStartingChessPosition.FlatAppearance.BorderSize = 0;
            this.button_GenerateStartingChessPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GenerateStartingChessPosition.Location = new System.Drawing.Point(547, 503);
            this.button_GenerateStartingChessPosition.Name = "button_GenerateStartingChessPosition";
            this.button_GenerateStartingChessPosition.Size = new System.Drawing.Size(50, 50);
            this.button_GenerateStartingChessPosition.TabIndex = 44;
            this.toolTip1.SetToolTip(this.button_GenerateStartingChessPosition, "Generate starting chess position");
            this.button_GenerateStartingChessPosition.UseVisualStyleBackColor = false;
            this.button_GenerateStartingChessPosition.Visible = false;
            this.button_GenerateStartingChessPosition.Click += new System.EventHandler(this.GenerateStartingChessPosition_Click);
            // 
            // button_reset_puzzle
            // 
            this.button_reset_puzzle.BackColor = System.Drawing.Color.Transparent;
            this.button_reset_puzzle.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.restart;
            this.button_reset_puzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_reset_puzzle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset_puzzle.FlatAppearance.BorderSize = 0;
            this.button_reset_puzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset_puzzle.Location = new System.Drawing.Point(549, 391);
            this.button_reset_puzzle.Name = "button_reset_puzzle";
            this.button_reset_puzzle.Size = new System.Drawing.Size(50, 50);
            this.button_reset_puzzle.TabIndex = 36;
            this.toolTip1.SetToolTip(this.button_reset_puzzle, "Restart");
            this.button_reset_puzzle.UseVisualStyleBackColor = false;
            this.button_reset_puzzle.Visible = false;
            this.button_reset_puzzle.Click += new System.EventHandler(this.Button_reset_puzzle_click);
            // 
            // button_clear_Board
            // 
            this.button_clear_Board.BackColor = System.Drawing.Color.Transparent;
            this.button_clear_Board.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.clear;
            this.button_clear_Board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_clear_Board.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear_Board.FlatAppearance.BorderSize = 0;
            this.button_clear_Board.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear_Board.Location = new System.Drawing.Point(549, 448);
            this.button_clear_Board.Name = "button_clear_Board";
            this.button_clear_Board.Size = new System.Drawing.Size(50, 50);
            this.button_clear_Board.TabIndex = 43;
            this.toolTip1.SetToolTip(this.button_clear_Board, "Clear Board");
            this.button_clear_Board.UseVisualStyleBackColor = false;
            this.button_clear_Board.Visible = false;
            this.button_clear_Board.Click += new System.EventHandler(this.ClearComposerBoard_Click);
            // 
            // button_gotoNextPuzzle
            // 
            this.button_gotoNextPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.button_gotoNextPuzzle.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.next;
            this.button_gotoNextPuzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_gotoNextPuzzle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_gotoNextPuzzle.FlatAppearance.BorderSize = 0;
            this.button_gotoNextPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gotoNextPuzzle.Location = new System.Drawing.Point(549, 392);
            this.button_gotoNextPuzzle.Name = "button_gotoNextPuzzle";
            this.button_gotoNextPuzzle.Size = new System.Drawing.Size(50, 50);
            this.button_gotoNextPuzzle.TabIndex = 81;
            this.toolTip1.SetToolTip(this.button_gotoNextPuzzle, "Go to the next puzzle in the puzzle rush");
            this.button_gotoNextPuzzle.UseVisualStyleBackColor = false;
            this.button_gotoNextPuzzle.Visible = false;
            this.button_gotoNextPuzzle.Click += new System.EventHandler(this.Button_gotoNextPuzzle_Click);
            // 
            // button_Autoplay
            // 
            this.button_Autoplay.BackColor = System.Drawing.Color.Transparent;
            this.button_Autoplay.BackgroundImage = global::Chezz_Puzzler.Properties.Resources.play1;
            this.button_Autoplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Autoplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Autoplay.FlatAppearance.BorderSize = 0;
            this.button_Autoplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Autoplay.Location = new System.Drawing.Point(549, 448);
            this.button_Autoplay.Name = "button_Autoplay";
            this.button_Autoplay.Size = new System.Drawing.Size(50, 50);
            this.button_Autoplay.TabIndex = 85;
            this.toolTip1.SetToolTip(this.button_Autoplay, "autoplay the opened puzzle or puzzle rush");
            this.button_Autoplay.UseVisualStyleBackColor = false;
            this.button_Autoplay.Visible = false;
            this.button_Autoplay.Click += new System.EventHandler(this.Button_Autoplay_Click);
            // 
            // imageList_ForPRList
            // 
            this.imageList_ForPRList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_ForPRList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_ForPRList.ImageStream")));
            this.imageList_ForPRList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_ForPRList.Images.SetKeyName(0, "help.png");
            this.imageList_ForPRList.Images.SetKeyName(1, "tick.png");
            this.imageList_ForPRList.Images.SetKeyName(2, "cross.png");
            // 
            // context_help
            // 
            this.context_help.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToSolvePuzzlesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.context_help.Name = "contextMenu_help";
            this.context_help.Size = new System.Drawing.Size(151, 48);
            // 
            // howToSolvePuzzlesToolStripMenuItem
            // 
            this.howToSolvePuzzlesToolStripMenuItem.Name = "howToSolvePuzzlesToolStripMenuItem";
            this.howToSolvePuzzlesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.howToSolvePuzzlesToolStripMenuItem.Text = "Tutorials";
            this.howToSolvePuzzlesToolStripMenuItem.Click += new System.EventHandler(this.HowToSolvePuzzlesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About the app";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // PuzzlesDisplay
            // 
            this.PuzzlesDisplay.BackColor = System.Drawing.Color.Transparent;
            this.PuzzlesDisplay.Location = new System.Drawing.Point(627, 413);
            this.PuzzlesDisplay.Name = "PuzzlesDisplay";
            this.PuzzlesDisplay.Size = new System.Drawing.Size(398, 319);
            this.PuzzlesDisplay.TabIndex = 82;
            this.PuzzlesDisplay.Visible = false;
            // 
            // panel_setttings
            // 
            this.panel_setttings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_setttings.Controls.Add(this.Button_StopPuzzleTimer);
            this.panel_setttings.Controls.Add(this.Button_StopGlobalTimer);
            this.panel_setttings.Controls.Add(this.button15);
            this.panel_setttings.Controls.Add(this.label_logo_settings);
            this.panel_setttings.Controls.Add(this.label15);
            this.panel_setttings.Controls.Add(this.button_SetPieceTheme);
            this.panel_setttings.Controls.Add(this.comboBox_Psets);
            this.panel_setttings.Controls.Add(this.button_hColor4);
            this.panel_setttings.Controls.Add(this.label14);
            this.panel_setttings.Controls.Add(this.button_setResponseTimePL);
            this.panel_setttings.Controls.Add(this.numericUpDown7);
            this.panel_setttings.Controls.Add(this.label13);
            this.panel_setttings.Controls.Add(this.button_setPuzzleCountdown);
            this.panel_setttings.Controls.Add(this.button_SetGlobalCountdown);
            this.panel_setttings.Controls.Add(this.numF_Sec_Puzzle);
            this.panel_setttings.Controls.Add(this.numF_Min_Puzzle);
            this.panel_setttings.Controls.Add(this.numF_Hour_Puzzle);
            this.panel_setttings.Controls.Add(this.label12);
            this.panel_setttings.Controls.Add(this.numF_Sec_Global);
            this.panel_setttings.Controls.Add(this.numF_Min_Global);
            this.panel_setttings.Controls.Add(this.numF_Hour_Global);
            this.panel_setttings.Controls.Add(this.label11);
            this.panel_setttings.Controls.Add(this.button_resetAllSettings_Panel);
            this.panel_setttings.Controls.Add(this.button_hColor3);
            this.panel_setttings.Controls.Add(this.label8);
            this.panel_setttings.Controls.Add(this.button_hColor2);
            this.panel_setttings.Controls.Add(this.label9);
            this.panel_setttings.Controls.Add(this.button_hColor1);
            this.panel_setttings.Controls.Add(this.label10);
            this.panel_setttings.Controls.Add(this.button_stHoverColor);
            this.panel_setttings.Controls.Add(this.label7);
            this.panel_setttings.Controls.Add(this.button_setLastMoveColor);
            this.panel_setttings.Controls.Add(this.label5);
            this.panel_setttings.Controls.Add(this.button_setSElectedSquare);
            this.panel_setttings.Controls.Add(this.label4);
            this.panel_setttings.Controls.Add(this.button_blackSqSetColor);
            this.panel_setttings.Controls.Add(this.label3);
            this.panel_setttings.Controls.Add(this.button_setwhiteSqColor);
            this.panel_setttings.Controls.Add(this.label1);
            this.panel_setttings.Location = new System.Drawing.Point(673, 230);
            this.panel_setttings.Name = "panel_setttings";
            this.panel_setttings.Size = new System.Drawing.Size(352, 504);
            this.panel_setttings.TabIndex = 84;
            this.panel_setttings.Visible = false;
            // 
            // Button_StopPuzzleTimer
            // 
            this.Button_StopPuzzleTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_StopPuzzleTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StopPuzzleTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_StopPuzzleTimer.Location = new System.Drawing.Point(313, 352);
            this.Button_StopPuzzleTimer.Name = "Button_StopPuzzleTimer";
            this.Button_StopPuzzleTimer.Size = new System.Drawing.Size(26, 25);
            this.Button_StopPuzzleTimer.TabIndex = 132;
            this.Button_StopPuzzleTimer.Text = "⏹";
            this.Button_StopPuzzleTimer.UseVisualStyleBackColor = false;
            this.Button_StopPuzzleTimer.Click += new System.EventHandler(this.Button_StopPuzzleTimer_Click);
            // 
            // Button_StopGlobalTimer
            // 
            this.Button_StopGlobalTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_StopGlobalTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StopGlobalTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_StopGlobalTimer.Location = new System.Drawing.Point(313, 324);
            this.Button_StopGlobalTimer.Name = "Button_StopGlobalTimer";
            this.Button_StopGlobalTimer.Size = new System.Drawing.Size(26, 25);
            this.Button_StopGlobalTimer.TabIndex = 131;
            this.Button_StopGlobalTimer.Text = "⏹";
            this.Button_StopGlobalTimer.UseVisualStyleBackColor = false;
            this.Button_StopGlobalTimer.Click += new System.EventHandler(this.Button_StopGlobalTimer_Click);
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(322, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(25, 25);
            this.button15.TabIndex = 30;
            this.button15.Text = "x";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label_logo_settings
            // 
            this.label_logo_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_logo_settings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_logo_settings.Location = new System.Drawing.Point(0, 0);
            this.label_logo_settings.Name = "label_logo_settings";
            this.label_logo_settings.Size = new System.Drawing.Size(350, 27);
            this.label_logo_settings.TabIndex = 130;
            this.label_logo_settings.Text = "Settings";
            this.label_logo_settings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 423);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 129;
            this.label15.Text = "Piece Set:";
            // 
            // button_SetPieceTheme
            // 
            this.button_SetPieceTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SetPieceTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SetPieceTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SetPieceTheme.Location = new System.Drawing.Point(294, 418);
            this.button_SetPieceTheme.Name = "button_SetPieceTheme";
            this.button_SetPieceTheme.Size = new System.Drawing.Size(45, 25);
            this.button_SetPieceTheme.TabIndex = 128;
            this.button_SetPieceTheme.Text = "Set";
            this.button_SetPieceTheme.UseVisualStyleBackColor = false;
            this.button_SetPieceTheme.Click += new System.EventHandler(this.Button_SetPieceTheme_Click);
            // 
            // comboBox_Psets
            // 
            this.comboBox_Psets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Psets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Psets.FormattingEnabled = true;
            this.comboBox_Psets.Location = new System.Drawing.Point(76, 418);
            this.comboBox_Psets.Name = "comboBox_Psets";
            this.comboBox_Psets.Size = new System.Drawing.Size(212, 23);
            this.comboBox_Psets.TabIndex = 127;
            // 
            // button_hColor4
            // 
            this.button_hColor4.BackColor = System.Drawing.Color.White;
            this.button_hColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hColor4.Location = new System.Drawing.Point(219, 290);
            this.button_hColor4.Name = "button_hColor4";
            this.button_hColor4.Size = new System.Drawing.Size(25, 25);
            this.button_hColor4.TabIndex = 32;
            this.button_hColor4.UseVisualStyleBackColor = false;
            this.button_hColor4.Click += new System.EventHandler(this.ChangeHLColor_SHIFT);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Color - [Shift+Right-Click] Highlight";
            // 
            // button_setResponseTimePL
            // 
            this.button_setResponseTimePL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setResponseTimePL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setResponseTimePL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_setResponseTimePL.Location = new System.Drawing.Point(294, 387);
            this.button_setResponseTimePL.Name = "button_setResponseTimePL";
            this.button_setResponseTimePL.Size = new System.Drawing.Size(45, 25);
            this.button_setResponseTimePL.TabIndex = 29;
            this.button_setResponseTimePL.Text = "Set";
            this.button_setResponseTimePL.UseVisualStyleBackColor = false;
            this.button_setResponseTimePL.Click += new System.EventHandler(this.Button_setResponseTimePL_Click);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(238, 387);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown7.TabIndex = 28;
            this.numericUpDown7.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Response Time of Puzzle (milliseconds)";
            // 
            // button_setPuzzleCountdown
            // 
            this.button_setPuzzleCountdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setPuzzleCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setPuzzleCountdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_setPuzzleCountdown.Location = new System.Drawing.Point(264, 353);
            this.button_setPuzzleCountdown.Name = "button_setPuzzleCountdown";
            this.button_setPuzzleCountdown.Size = new System.Drawing.Size(45, 25);
            this.button_setPuzzleCountdown.TabIndex = 26;
            this.button_setPuzzleCountdown.Text = "Set";
            this.button_setPuzzleCountdown.UseVisualStyleBackColor = false;
            this.button_setPuzzleCountdown.Click += new System.EventHandler(this.Button_setDefaultCountdown_Panel_Click);
            // 
            // button_SetGlobalCountdown
            // 
            this.button_SetGlobalCountdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SetGlobalCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SetGlobalCountdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SetGlobalCountdown.Location = new System.Drawing.Point(264, 324);
            this.button_SetGlobalCountdown.Name = "button_SetGlobalCountdown";
            this.button_SetGlobalCountdown.Size = new System.Drawing.Size(45, 25);
            this.button_SetGlobalCountdown.TabIndex = 25;
            this.button_SetGlobalCountdown.Text = "Set";
            this.button_SetGlobalCountdown.UseVisualStyleBackColor = false;
            this.button_SetGlobalCountdown.Click += new System.EventHandler(this.SetGlobalTimer);
            // 
            // numF_Sec_Puzzle
            // 
            this.numF_Sec_Puzzle.Location = new System.Drawing.Point(223, 355);
            this.numF_Sec_Puzzle.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numF_Sec_Puzzle.Name = "numF_Sec_Puzzle";
            this.numF_Sec_Puzzle.Size = new System.Drawing.Size(35, 23);
            this.numF_Sec_Puzzle.TabIndex = 24;
            // 
            // numF_Min_Puzzle
            // 
            this.numF_Min_Puzzle.Location = new System.Drawing.Point(182, 355);
            this.numF_Min_Puzzle.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numF_Min_Puzzle.Name = "numF_Min_Puzzle";
            this.numF_Min_Puzzle.Size = new System.Drawing.Size(35, 23);
            this.numF_Min_Puzzle.TabIndex = 23;
            // 
            // numF_Hour_Puzzle
            // 
            this.numF_Hour_Puzzle.Location = new System.Drawing.Point(126, 355);
            this.numF_Hour_Puzzle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numF_Hour_Puzzle.Name = "numF_Hour_Puzzle";
            this.numF_Hour_Puzzle.Size = new System.Drawing.Size(50, 23);
            this.numF_Hour_Puzzle.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Puzzle Countdown";
            // 
            // numF_Sec_Global
            // 
            this.numF_Sec_Global.Location = new System.Drawing.Point(223, 326);
            this.numF_Sec_Global.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numF_Sec_Global.Name = "numF_Sec_Global";
            this.numF_Sec_Global.Size = new System.Drawing.Size(35, 23);
            this.numF_Sec_Global.TabIndex = 20;
            // 
            // numF_Min_Global
            // 
            this.numF_Min_Global.Location = new System.Drawing.Point(182, 326);
            this.numF_Min_Global.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numF_Min_Global.Name = "numF_Min_Global";
            this.numF_Min_Global.Size = new System.Drawing.Size(35, 23);
            this.numF_Min_Global.TabIndex = 19;
            // 
            // numF_Hour_Global
            // 
            this.numF_Hour_Global.Location = new System.Drawing.Point(126, 326);
            this.numF_Hour_Global.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numF_Hour_Global.Name = "numF_Hour_Global";
            this.numF_Hour_Global.Size = new System.Drawing.Size(50, 23);
            this.numF_Hour_Global.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Global Countdown";
            // 
            // button_resetAllSettings_Panel
            // 
            this.button_resetAllSettings_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetAllSettings_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetAllSettings_Panel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_resetAllSettings_Panel.Location = new System.Drawing.Point(245, 473);
            this.button_resetAllSettings_Panel.Name = "button_resetAllSettings_Panel";
            this.button_resetAllSettings_Panel.Size = new System.Drawing.Size(94, 25);
            this.button_resetAllSettings_Panel.TabIndex = 16;
            this.button_resetAllSettings_Panel.Text = "Reset All";
            this.button_resetAllSettings_Panel.UseVisualStyleBackColor = false;
            this.button_resetAllSettings_Panel.Click += new System.EventHandler(this.ResetAllSettings_Panel_Click);
            // 
            // button_hColor3
            // 
            this.button_hColor3.BackColor = System.Drawing.Color.White;
            this.button_hColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hColor3.Location = new System.Drawing.Point(219, 259);
            this.button_hColor3.Name = "button_hColor3";
            this.button_hColor3.Size = new System.Drawing.Size(25, 25);
            this.button_hColor3.TabIndex = 15;
            this.button_hColor3.UseVisualStyleBackColor = false;
            this.button_hColor3.Click += new System.EventHandler(this.ChangeHLColor_ALT);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Color - [Alt+Right-Click] Highlight";
            // 
            // button_hColor2
            // 
            this.button_hColor2.BackColor = System.Drawing.Color.White;
            this.button_hColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hColor2.Location = new System.Drawing.Point(219, 228);
            this.button_hColor2.Name = "button_hColor2";
            this.button_hColor2.Size = new System.Drawing.Size(25, 25);
            this.button_hColor2.TabIndex = 13;
            this.button_hColor2.UseVisualStyleBackColor = false;
            this.button_hColor2.Click += new System.EventHandler(this.ChangeHLColor_CTRL);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Color - [Ctrl+Right-Click] Highlight";
            // 
            // button_hColor1
            // 
            this.button_hColor1.BackColor = System.Drawing.Color.White;
            this.button_hColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hColor1.Location = new System.Drawing.Point(219, 197);
            this.button_hColor1.Name = "button_hColor1";
            this.button_hColor1.Size = new System.Drawing.Size(25, 25);
            this.button_hColor1.TabIndex = 11;
            this.button_hColor1.UseVisualStyleBackColor = false;
            this.button_hColor1.Click += new System.EventHandler(this.ChangeHLColor_Normal);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Color - [Right-Click] Highlight";
            // 
            // button_stHoverColor
            // 
            this.button_stHoverColor.BackColor = System.Drawing.Color.White;
            this.button_stHoverColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stHoverColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stHoverColor.Location = new System.Drawing.Point(219, 166);
            this.button_stHoverColor.Name = "button_stHoverColor";
            this.button_stHoverColor.Size = new System.Drawing.Size(25, 25);
            this.button_stHoverColor.TabIndex = 9;
            this.button_stHoverColor.UseVisualStyleBackColor = false;
            this.button_stHoverColor.Click += new System.EventHandler(this.Button_stHoverColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Color - Hover";
            // 
            // button_setLastMoveColor
            // 
            this.button_setLastMoveColor.BackColor = System.Drawing.Color.White;
            this.button_setLastMoveColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setLastMoveColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setLastMoveColor.Location = new System.Drawing.Point(219, 136);
            this.button_setLastMoveColor.Name = "button_setLastMoveColor";
            this.button_setLastMoveColor.Size = new System.Drawing.Size(25, 25);
            this.button_setLastMoveColor.TabIndex = 7;
            this.button_setLastMoveColor.UseVisualStyleBackColor = false;
            this.button_setLastMoveColor.Click += new System.EventHandler(this.Button_setLastMoveColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Color - Last Move";
            // 
            // button_setSElectedSquare
            // 
            this.button_setSElectedSquare.BackColor = System.Drawing.Color.White;
            this.button_setSElectedSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setSElectedSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setSElectedSquare.Location = new System.Drawing.Point(219, 105);
            this.button_setSElectedSquare.Name = "button_setSElectedSquare";
            this.button_setSElectedSquare.Size = new System.Drawing.Size(25, 25);
            this.button_setSElectedSquare.TabIndex = 5;
            this.button_setSElectedSquare.UseVisualStyleBackColor = false;
            this.button_setSElectedSquare.Click += new System.EventHandler(this.Button_setSElectedSquare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color - Selected Square";
            // 
            // button_blackSqSetColor
            // 
            this.button_blackSqSetColor.BackColor = System.Drawing.Color.White;
            this.button_blackSqSetColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_blackSqSetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_blackSqSetColor.Location = new System.Drawing.Point(219, 74);
            this.button_blackSqSetColor.Name = "button_blackSqSetColor";
            this.button_blackSqSetColor.Size = new System.Drawing.Size(25, 25);
            this.button_blackSqSetColor.TabIndex = 3;
            this.button_blackSqSetColor.UseVisualStyleBackColor = false;
            this.button_blackSqSetColor.Click += new System.EventHandler(this.Button_blackSqSetColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color - Black Square";
            // 
            // button_setwhiteSqColor
            // 
            this.button_setwhiteSqColor.BackColor = System.Drawing.Color.White;
            this.button_setwhiteSqColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setwhiteSqColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setwhiteSqColor.Location = new System.Drawing.Point(219, 42);
            this.button_setwhiteSqColor.Name = "button_setwhiteSqColor";
            this.button_setwhiteSqColor.Size = new System.Drawing.Size(25, 25);
            this.button_setwhiteSqColor.TabIndex = 1;
            this.button_setwhiteSqColor.UseVisualStyleBackColor = false;
            this.button_setwhiteSqColor.Click += new System.EventHandler(this.Button_setwhiteSqColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color - White Square";
            // 
            // Form_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 791);
            this.Controls.Add(this.panel_setttings);
            this.Controls.Add(this.button_Autoplay);
            this.Controls.Add(this.PuzzlesDisplay);
            this.Controls.Add(this.button_gotoNextPuzzle);
            this.Controls.Add(this.button_clear_Board);
            this.Controls.Add(this.button_reset_puzzle);
            this.Controls.Add(this.button_GenerateStartingChessPosition);
            this.Controls.Add(this.panel_cd_event_toMove);
            this.Controls.Add(this.label_move_right);
            this.Controls.Add(this.label_move_wrong);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_7);
            this.Controls.Add(this.label_8);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.label_g);
            this.Controls.Add(this.label_f);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_show_solution);
            this.Controls.Add(this.button_show_solution);
            this.Controls.Add(this.label_square_displayer);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.label_chapterCounter);
            this.Controls.Add(this.label_solution_chapter);
            this.Controls.Add(this.button_hint);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_solver);
            this.Controls.Add(this.icon_notSolved);
            this.Controls.Add(this.icon_solved);
            this.Controls.Add(this.panel_composer);
            this.Controls.Add(this.panel_bottom);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess Puzzle Maker And Solver 1.7.12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.icon_solved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_notSolved)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuPuzzles.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_PuzleEditContainer.ResumeLayout(false);
            this.panel_ComposePuzzleContainer.ResumeLayout(false);
            this.panel_ComposePuzzleContainer.PerformLayout();
            this.contextMenu_TextBoxes.ResumeLayout(false);
            this.contextRushMenu.ResumeLayout(false);
            this.contextChaptersList.ResumeLayout(false);
            this.panel_generate.ResumeLayout(false);
            this.panel_generate.PerformLayout();
            this.menuChangeSquare.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.context_options.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menu_Timer_Puzzle.ResumeLayout(false);
            this.panel_cd_event_toMove.ResumeLayout(false);
            this.menu_global.ResumeLayout(false);
            this.context_help.ResumeLayout(false);
            this.panel_setttings.ResumeLayout(false);
            this.panel_setttings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Sec_Puzzle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Min_Puzzle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Hour_Puzzle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Sec_Global)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Min_Global)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF_Hour_Global)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private PictureBox icon_solved;
        private PictureBox icon_notSolved;
        private Panel panel_solver;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button_solve;
        private ContextMenuStrip menuPuzzles;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private TabPage tabPage2;
        private Button button_hint;
        private Label label_solution_chapter;
        private Panel panel_composer;
        private ContextMenuStrip menuChangeSquare;
        private ToolStripMenuItem eMPYToolStripMenuItem;
        private Label label_chapterCounter;
        private Label label_hint;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private Label label_square_displayer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label_Action_Response;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem thisIsAttackerToolStripMenuItem;
        private ToolStripMenuItem thisIsAttackedToolStripMenuItem;
        private Panel panel_bottom;
        private CheckBox checkBox_hotkeys;
        private Button button_show_solution;
        private Label label_show_solution;
        private Button button_export_Local;
        private Button button_export_FEN;
        private Button button_settings;
        private ColorDialog colorDialog_decideColorSquares;
        private ContextMenuStrip context_options;
        private ToolStripMenuItem changeColorOfWhiteSquareToolStripMenuItem;
        private ToolStripMenuItem changeColorOfBlackSquaresToolStripMenuItem;
        private Panel panel1;
        private Label label_a;
        private Label label_b;
        private Label label_d;
        private Label label_c;
        private Label label_h;
        private Label label_g;
        private Label label_f;
        private Label label_e;
        private Label label_8;
        private Label label_7;
        private Label label_5;
        private Label label_6;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem setCountdownToolStripMenuItem;
        private ContextMenuStrip menu_Timer_Puzzle;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem resumeToolStripMenuItem;
        private ContextMenuStrip contextChaptersList;
        private ContextMenuStrip contextRushMenu;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem removeLastChapterToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ContextMenuStrip contextMenu_TextBoxes;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyAllToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem clearAndPasteToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem changeResponseTimeOfPlayer2ToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private Label label_move_wrong;
        private Label label_move_right;
        private ToolStripMenuItem clearPuzzleToolStripMenuItem;
        private ToolStripMenuItem changeHightlightedSquareColorToolStripMenuItem;
        private ToolStripMenuItem changeLastMoveHightlightColorToolStripMenuItem;
        private Panel panel_cd_event_toMove;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem whitePawnToolStripMenuItem;
        private ToolStripMenuItem whiteRookToolStripMenuItem;
        private ToolStripMenuItem whiteQueenToolStripMenuItem;
        private ToolStripMenuItem whiteKingToolStripMenuItem1;
        private ToolStripMenuItem whiteBishopToolStripMenuItem1;
        private ToolStripMenuItem whiteKnightToolStripMenuItem1;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem blackPawnToolStripMenuItem1;
        private ToolStripMenuItem blackRookToolStripMenuItem1;
        private ToolStripMenuItem blackQueenToolStripMenuItem1;
        private ToolStripMenuItem blackKingToolStripMenuItem1;
        private ToolStripMenuItem blackBishopToolStripMenuItem1;
        private ToolStripMenuItem blackKnightToolStripMenuItem1;
        private Button button_GenerateStartingChessPosition;
        private Button button_reset_puzzle;
        private Button button_clear_Board;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem thisIsPrepuzzleStartToolStripMenuItem;
        private ToolStripMenuItem thisIsPrePuzzleEndToolStripMenuItem;
        private ToolTip toolTip1;
        private ImageList imageList_ForPRList;
        private Button button1;
        private ContextMenuStrip context_help;
        private ToolStripMenuItem howToSolvePuzzlesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem loadChapterToolStripMenuItem;
        private ToolStripMenuItem editChapterWithCurrentFieldsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private CheckBox checkBox_autoPR;
        private Button button_gotoNextPuzzle;
        private RichTextBox richTextBox_description;
        private ListBox listofPuzzles;
        private Panel panel_dummy_EL;
        private Panel panel_generate;
        private LinkLabel linkLabel_Dif;
        private CheckBox checkBox_Making_PR;
        private Button button_Generate_P;
        private Button button_generate_PR;
        private Panel panel_ComposePuzzleContainer;
        private Button button_swapPlayers;
        private Button button_swapColors;
        private Label labelTXB_Descr;
        private TextBox textBox_description;
        private CheckBox checkBox_LastPlayedOptional;
        private ComboBox comboBox_num2_om;
        private ComboBox comboBox_letter2_om;
        private Label label_TakesToOriginal;
        private ComboBox comboBox_num1_om;
        private ComboBox comboBox_letter1_om;
        private Label labelTXB_Event;
        private TextBox textBox_event;
        private TextBox textBox_Right;
        private TextBox textbox_Wrong;
        private Label label_Puzzles;
        private ListBox listbox_Puzzles_Rush;
        private Label label_Solutions;
        private LinkLabel linkLabel_SCN;
        private Button button_import_local;
        private Label label_SCNImport;
        private TextBox textBox_SCN;
        private LinkLabel linkLabel_FEN;
        private Label label_FENImportLabel;
        private TextBox textBox_FEN;
        private Button button_ImprtFEN;
        private CheckBox checkBox_AT;
        private Button button_Transition;
        private Label label6;
        private TextBox textBox_hint;
        private ListBox listbox_Puzzle_Fragments;
        private Button button_Add;
        private ComboBox c_number2;
        private ComboBox c_letter2;
        private Label label_Takesto;
        private ComboBox c_number1;
        private ComboBox c_letter1;
        private Label label2;
        private Label label_name;
        private TextBox textBox_name;
        private ToolStripMenuItem changeTheHoverColorOfTheSquaresToolStripMenuItem;
        private CheckBox checkBox_UseBG;
        private CheckBox checkbox_smartAdd;
        private Label labelTBOX_Name;
        private Label labelTBOX_Hint;
        private Label labelTBOX_Wrong;
        private Label labelTBOX_Righht;
        private Panel panel_PuzleEditContainer;
        private Panel PuzzlesDisplay;
        private Button btn_reverseFiles;
        private Button button2;
        
        private CheckBox checkBox_AU_Reset;
        private Panel panel_setttings;
        private Button button_setPuzzleCountdown;
        private Button button_SetGlobalCountdown;
        private NumericUpDown numF_Sec_Puzzle;
        private NumericUpDown numF_Min_Puzzle;
        private NumericUpDown numF_Hour_Puzzle;
        private Label label12;
        private NumericUpDown numF_Sec_Global;
        private NumericUpDown numF_Min_Global;
        private NumericUpDown numF_Hour_Global;
        private Label label11;
         
        private Button button_hColor3;
        private Label label8;
        private Button button_hColor2;
        private Label label9;
        private Button button_hColor1;
        private Label label10;
        private Button button_stHoverColor;
        private Label label7;
        private Button button_setLastMoveColor;
        private Label label5;
        private Button button_setSElectedSquare;
        private Label label4;
        private Button button_blackSqSetColor;
        private Label label3;
        private Button button_setwhiteSqColor;
        private Label label1;
        private Button button15;
        private Button button_setResponseTimePL;
        private NumericUpDown numericUpDown7;
        private Label label13;
        private Button button_hColor4;
        private Label label14;
        private Button button_resetAllSettings_Panel;
        private Button button_Autoplay;
        
         
        private Label label15;
        private Button button_SetPieceTheme;
        private ComboBox comboBox_Psets;
        private Label label_logo_settings;
        private Label label_Countdown_Puzzle;
        private Label label_Countdown_Global;
        private Button Button_StopGlobalTimer;
        private Button Button_StopPuzzleTimer;
        private Label label_event;
        private ContextMenuStrip menu_global;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
         
    }
}