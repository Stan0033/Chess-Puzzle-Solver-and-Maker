using System.Diagnostics;
using System.Media;
using System.Text.RegularExpressions;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;
using TextBox = System.Windows.Forms.TextBox;
using Timer = System.Windows.Forms.Timer;
namespace Chezz_Puzzler
{
    public partial class Form_base : Form
    {
        bool Key_Pressed_Alt;
        bool Key_Pressed_Ctrl;
        bool Key_Pressed_Shift;
        readonly int CurrentlyEditedPuzzleNumber;
        readonly string path_puzzles;
        readonly string path_tutorials;
        readonly string path_pieces;
        TextBox FocusedTextBox;
        readonly List<Color> colors;
        const int sizeOfSquare = 65;//px
        readonly Settings settings;
        //---------------------------------
        readonly Timer Timer_Puzzle;
        readonly Timer Timer_Global;
        readonly Timer Autoplay_Timer;
        int Time_Puzzle_SecondsLeft;
        int Time_Global_SecondsLeft;
        int Time_Puzzle_SecondsTotal;
        readonly List<string> CurrentPuzzle_rightAnswers;
        readonly List<string> CurrentPuzzle_wrongAnswers;
        //---------------------------------
        readonly Dictionary<string, Image> pieces_pics;
        bool Selected_A_Piece;
        bool UserToMove;
        bool APuzzleIsLoaded;
        bool PR_Paused;
        string fix_one;
        string fix_two;
        readonly List<char> InvalidWindowsFilenameCharactes;
        readonly Timer Fixer_q;
        //----------------------------------------------------------
        readonly List<Color> DefaultButtonColors;
        Dictionary<char, Image> CharactersAsPieceImages;
        //currently
        string currentProposedSquareStart;
        string currentProposedSquareEnd;
        string PathOfCurrentlyUsedChessSet;
        string FolderOfCurrentlyUsedChessSet;
        int CurrentlySolvedPuzzleNumber;
        bool CurrentlySolvingAPuzzleRush;
        bool Composer_Mode_Select;
        ChessButton  LastSelectedToMoveComposerSquare;
        bool CurrentPuzzleIsSolved;
        string CurrentlyOpenedPuzzleFilename;
        ChessButton  SelectedSquare_Start;
        ChessButton  SelectedSquare_End;
        int CurrentlySolvedPuzzleChapterStep;
        ChessButton Currently_Hovered_Button;
        readonly List<string> CurrentPuzzle_Hints;
        readonly List<string> CurrentPuzzle_Solutions;
        readonly List<string> CurrentPuzzle_Positions;
        readonly List<string> CurrentPuzzle_ToMove;
        private readonly List<int> CurrentPuzzles_Lengths;
        readonly List<string> CurrentEvents;
        readonly List<List<ChessButton>> Board_Solver;
        readonly List<List<ChessButton>> Board_Composer;
        readonly List<List<string>> AllPuzzles_of_PuzzleRush;
        int CurrenltOpenedPuzzleChaptersCount;
        string ProposedSolution;
        string LastMovePlayedBeforeThePuzzleStarts;
        int CurrenlyOpenedPuzzle_ChaptersSolved;
        readonly Timer PuzzleResponse;
        readonly List<Label> RightWrongAnswersInPR;
        List<string[]> CurrentPuzzleComposition_List;
        int currentDistanceOfLabelsForPRDisplay;
        readonly List<List<string[]>> PuzzleRushPuzzles_Composed;
        readonly Dictionary<char, string> PieceNameToImagePath;
        readonly List<string> DescriptionsForPR_Puzzles;
        readonly List<List<Color>> ColorsOfSquaresFilebyFile;
        readonly ToMoveIndicatorLabel ToMoveLabel;
        bool LastMoveWasDoneByClicks;
        readonly Image EmptySquare;
        public Form_base()
        {
            
            try
            {
                EmptySquare = Image.FromFile(Application.StartupPath + "Pieces\\Empty.png");
            }
            catch { MessageBox.Show("Missing 'pieces\\empty.png'");Environment.Exit(0); };
            ToMoveLabel = new ToMoveIndicatorLabel();
            LastSelectedToMoveComposerSquare = new();
            Currently_Hovered_Button = new();
            FocusedTextBox = new TextBox();
            CurrentlyOpenedPuzzleFilename = string.Empty;
            fix_one = string.Empty;
            fix_two= string.Empty;
            SelectedSquare_Start = new();
            SelectedSquare_End = new();
             Time_Puzzle_SecondsTotal = 0;
            Time_Global_SecondsLeft = 0;
            pieces_pics = new();
            settings = new Settings();
            CharactersAsPieceImages = new();
            Key_Pressed_Alt = false;
            Key_Pressed_Ctrl = false;
            Key_Pressed_Shift = false;
            currentProposedSquareStart = "";
            currentProposedSquareEnd = "";
            LastMoveWasDoneByClicks = false;
            Board_Solver = new List<List<ChessButton>>();// one file contains 8 rank squares (buttons)
            Board_Composer = new List<List<ChessButton>>();
            for (int i = 0; i < 8; i++) //added empty lists
            {
                Board_Solver.Add(new List<ChessButton>());
                Board_Composer.Add(new List<ChessButton>());
            }
            ColorsOfSquaresFilebyFile = new List<List<Color>>();
            DefaultButtonColors = new List<Color>(64);
            CurrentlyEditedPuzzleNumber = 0;
            DescriptionsForPR_Puzzles = new List<string>();
            PieceNameToImagePath = new Dictionary<char, string>();
            //------------------------------------
            path_puzzles = Application.StartupPath + "Puzzles\\";
            path_tutorials = Application.StartupPath + "Tutorials\\";
            path_pieces = Application.StartupPath + "Pieces\\";
            PathOfCurrentlyUsedChessSet = path_pieces + "\\" + "Standard";
            FolderOfCurrentlyUsedChessSet = "Standard";
            //------------------------------------
            PR_Paused = false;
            RightWrongAnswersInPR = new List<Label>();
            PuzzleRushPuzzles_Composed = new List<List<string[]>>();
            currentDistanceOfLabelsForPRDisplay = 0;
            LastMovePlayedBeforeThePuzzleStarts = string.Empty;
            AllPuzzles_of_PuzzleRush = new List<List<string>>();
            CurrentlySolvingAPuzzleRush = false;
            CurrentlySolvedPuzzleNumber = 0;
            //-------------------------------------------------------
            Timer_Puzzle = new Timer();
            Timer_Puzzle.Tick += SetPuzzleCountdownLabelTexts;
            Timer_Puzzle.Interval = 1000;
            Timer_Global = new Timer();
            Timer_Global.Tick += SetGlobalCountdownLabelTexts;
            Timer_Global.Interval = 1000;
            //-------------------------------------------------------
            Autoplay_Timer = new Timer();
            Autoplay_Timer.Tick += AutoPlayCurrentGame;
            Autoplay_Timer.Interval = 300;
            //-------------------------------------------------------
            Time_Puzzle_SecondsLeft = 0;
            Fixer_q = new Timer();
            Fixer_q.Tick += Quickfix;
            Fixer_q.Interval = 200;
            Composer_Mode_Select = true;
            UserToMove = true;
            PuzzleResponse = new Timer
            {
                Interval = settings.Player2ResponseTime,
                Enabled = false
            };
            PuzzleResponse.Tick += ExecuteResponseMoveInPuzzle;
            CurrentPuzzleIsSolved = false;
            ProposedSolution = string.Empty;
            CurrenlyOpenedPuzzle_ChaptersSolved = 0;
            //-------------------------------------
            CurrentPuzzle_Hints = new List<string>();
            CurrentPuzzle_Solutions = new List<string>();
            CurrentPuzzle_Positions = new List<string>();
            CurrentPuzzle_ToMove = new List<string>();
            CurrentPuzzle_rightAnswers = new List<string>();
            CurrentPuzzle_wrongAnswers = new List<string>();
            CurrentPuzzleComposition_List = new List<string[]>();
            CurrentEvents = new List<string>();
            CurrentPuzzles_Lengths = new List<int>();
            InitializeComponent();
            CreateToMoveLabel();
            Selected_A_Piece = false;
            colors = new List<Color>();
            //-----------------------
            //-----------------------
            // edit the colors
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        if (x % 2 == 0)
                        {
                            colors.Add(settings.Color_White_Current);
                        }
                        else
                        {
                            colors.Add(settings.Color_Black_Current);
                        }
                    }
                }
                else
                {
                    for (int x = 0; x < 8; x++)
                    {
                        if (x % 2 == 0)
                        {
                            colors.Add(settings.Color_Black_Current);
                        }
                        else
                        {
                            colors.Add(settings.Color_White_Current);
                        }
                    }
                }
            }
            // add also the colors for rank by rank colors
            bool ReverseOrder = false;
            for (int file = 1; file <= 8; file++)
            {
                List<Color> templist = new();
                for (int rank = 1; rank <= 8; rank++)
                {
                    templist.Add(rank % 2 == 0 ? settings.Color_Black_Current : settings.Color_White_Current);
                }
                if (ReverseOrder) { templist.Reverse(); ReverseOrder = false; } else { ReverseOrder = true; }
                ColorsOfSquaresFilebyFile.Add(templist.ToList());
            }
            APuzzleIsLoaded = false;
            CheckAndLoadAllPieceImages();
            // here add an event that will not allow hotkeys to work in textboxes
            InvalidWindowsFilenameCharactes = new List<char>
            {
                '<',
                '>',
                '*',
                '?',
                '/',
                '|',
                '\\',
                ':'
            };
            // add the paths for the piece names
            PieceNameToImagePath.Add('K', "king_white.png");
            PieceNameToImagePath.Add('k', "king_black.png");
            PieceNameToImagePath.Add('Q', "queen_white.png");
            PieceNameToImagePath.Add('q', "queen_black.png");
            PieceNameToImagePath.Add('B', "bishop_white.png");
            PieceNameToImagePath.Add('b', "bishop_black.png");
            PieceNameToImagePath.Add('N', "knight_white.png");
            PieceNameToImagePath.Add('n', "knight_black.png");
            PieceNameToImagePath.Add('R', "rook_white.png");
            PieceNameToImagePath.Add('r', "rook_black.png");
            PieceNameToImagePath.Add('P', "pawn_white.png");
            PieceNameToImagePath.Add('p', "pawn_black.png");
        }
        public void CreateToMoveLabel()
        {
            ToMoveLabel.Location = new Point(547, 359);
            ToMoveLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            ToMoveLabel.AutoSize = true;
            Controls.Add(ToMoveLabel);


        }
        public void AutoPlayCurrentGame(object? sender, EventArgs e)
        {
            /* when a puzzle is finished stop the timer and hide the button and the icons and the label = ""
             * else
             * when starting hide the button and the icons and the label = ""
            //if the puzzle or puzzle rush reaches its final position or puzzle stop the puzzle
             * if it is and the end of the puzzle when hitting the button, restart the puzzle and restart the autoplay
             */
        }
        public static void SetColorsOfAllButtons()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    // Board_Solver[i][x].SetColors();
                }
            }
        }
        public static void UnhightlightAllSquares(List<List<ChessButton>> whichBoard)
        {
            for (int i = 0; i < whichBoard.Count; i++)
            {
                for (int x = 0; x < whichBoard[i].Count; x++)
                {
                    whichBoard[i][x].BelongsToLastMove = false;
                }
            }
        }
        public void GenerateRightWrongLabelsForPRDisplay(int numOfPuzzles)
        {
            PuzzlesDisplay.Controls.Clear();
            // RightWrongAnswersInPR.Clear();
            currentDistanceOfLabelsForPRDisplay = 0;
            Color black = Color.Black;
            Color Y = Color.LightGray;
            for (int i = 1; i <= numOfPuzzles; i++)
            {
                Label l = new()
                {
                    Text = $"Puzzle {i}",
                    AutoSize = false,
                    Width = PuzzlesDisplay.Width,
                    Height = 21,
                    BackColor = Y,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = black,
                    Location = new Point(0, currentDistanceOfLabelsForPRDisplay),
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };
                // l.Dock = DockStyle.Bottom;
                // RightWrongAnswersInPR.Add(l);
                PuzzlesDisplay.Controls.Add(l);
                currentDistanceOfLabelsForPRDisplay += 21;
            }
            //RightWrongAnswersInPR  
            currentDistanceOfLabelsForPRDisplay = 0;
        }
        public void WriteSettingsFile()
        {
            string SettingsPath = Application.StartupPath + "settings.txt";
            List<string> settingsData = new()
            {
                $"ColorWhite={settings.Color_White_Current.R},{settings.Color_White_Current.G},{settings.Color_White_Current.B}",
                $"ColorBlack={settings.Color_Black_Current.R},{settings.Color_Black_Current.G},{settings.Color_Black_Current.B}",
                $"SelectedSquareColor={settings.Color_Selected_Current.R},{settings.Color_Selected_Current.G},{settings.Color_Selected_Current.B}",
                $"LastMoveHightlightedSquaresColor={settings.Color_LastMove_Current.R},{settings.Color_LastMove_Current.G},{settings.Color_LastMove_Current.B}",
                $"HoverSquareColor={settings.Color_Hover_Current.R},{settings.Color_Hover_Current.G},{settings.Color_Hover_Current.B}",
                $"MarkColor_Normal={settings.Color_Hightlight_Normal.R},{settings.Color_Hightlight_Normal.G},{settings.Color_Hightlight_Normal.B}",
                $"MarkColor_Ctrl={settings.Color_Hightlight_Ctrl.R},{settings.Color_Hightlight_Ctrl.G},{settings.Color_Hightlight_Ctrl.B}",
                $"MarkColor_Alt={settings.Color_Hightlight_Alt.R} , {settings.Color_Hightlight_Alt.G},{ settings.Color_Hightlight_Alt.B}",
                $"MarkColor_Shift={settings.Color_Hightlight_Shift.R},{settings.Color_Hightlight_Shift.G},{settings.Color_Hightlight_Shift.B}",
                $"AutoCountdown={settings.AutoCountdown}",
                $"HotkeysOn={checkBox_hotkeys.Checked}",
                $"Player2ResponseTime={settings.Player2ResponseTime}",
                $"AutoNextPuzzle={checkBox_autoPR.Checked}",
                $"UseBackgroundImage={checkBox_UseBG.Checked}",
                $"AutomaticallyRestartSolvedPuzzle={checkBox_AU_Reset.Checked}",
                $"PathOfCurrentlyUsedChessSet={FolderOfCurrentlyUsedChessSet}"
            };
            File.WriteAllLines(SettingsPath, settingsData);
        }
        public void ReadSettingsFile()
        {
            string SettingsPath = Application.StartupPath + "settings.txt";
            if (File.Exists(SettingsPath))
            {
                try
                {
                    List<string> lines = File.ReadAllLines(SettingsPath).ToList();
                    foreach (string line in lines)
                    {
                        string name = line.Split("=")[0];
                        string value = line.Split("=")[1];
                        string[] rgb = value.Split(",").ToArray();
                        Color tempColor = new();
                        switch (name)
                        {
                            case "ColorWhite":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                for (int i = 0; i <= 7; i++)
                                {
                                    for (int x = 0; x <= 7; x++)
                                    {
                                        Board_Composer[i][x].DefaultColors_White = tempColor;
                                        if (Board_Composer[i][x].IsWhiteSquare) { Board_Composer[i][x].DefaultBackColor = tempColor; Board_Composer[i][x].BackColor = tempColor; }
                                        Board_Solver[i][x].DefaultColors_White = tempColor;
                                        if (Board_Solver[i][x].IsWhiteSquare) { Board_Solver[i][x].DefaultBackColor = tempColor; Board_Solver[i][x].BackColor = tempColor; }
                                        button_setwhiteSqColor.BackColor = tempColor;
                                    }
                                }
                                settings.Color_White_Current = tempColor;
                                break;
                            case "ColorBlack":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                for (int i = 0; i <= 7; i++)
                                {
                                    for (int x = 0; x <= 7; x++)
                                    {
                                        Board_Composer[i][x].DefaultColors_Black = tempColor;
                                        if (!Board_Composer[i][x].IsWhiteSquare) { Board_Composer[i][x].DefaultBackColor = tempColor; Board_Composer[i][x].BackColor = tempColor; }
                                        Board_Solver[i][x].DefaultColors_Black = tempColor;
                                        if (!Board_Solver[i][x].IsWhiteSquare) { Board_Solver[i][x].DefaultBackColor = tempColor; Board_Solver[i][x].BackColor = tempColor; }
                                        button_blackSqSetColor.BackColor = tempColor;
                                    }
                                }
                                settings.Color_Black_Current = tempColor;
                                break;
                            case "HoverSquareColor":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_Hover_Current = tempColor;
                                button_stHoverColor.BackColor = tempColor;
                                for (int rank = 0; rank < 8; rank++)
                                {
                                    for (int file = 0; file < 8; file++)
                                    {
                                        Board_Composer[rank][file].Color_Hover = tempColor; Board_Solver[rank][file].Color_Hover = tempColor;
                                    }
                                }
                                break;
                            case "SelectedSquareColor":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_Selected_Current = tempColor;
                                button_setSElectedSquare.BackColor = tempColor;
                                break;
                            case "LastMoveHightlightedSquaresColor":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_LastMove_Current = tempColor;
                                button_setLastMoveColor.BackColor = tempColor;
                                break;
                            case "AutoNextPuzzle":
                                bool onAP = bool.Parse(value); checkBox_autoPR.Checked = onAP; break;
                            case "AutoCountdown":
                                settings.AutoCountdown = int.Parse(value);
                                TimeSpan t = TimeSpan.FromSeconds(settings.AutoCountdown);
                                numF_Hour_Puzzle.Value = t.Hours;
                                numF_Min_Puzzle.Value = t.Minutes;
                                numF_Sec_Puzzle.Value = t.Seconds;
                                break;
                            case "HotkeysOn": bool on = bool.Parse(value); checkBox_hotkeys.Checked = on; break;
                            case "UseBackgroundImage":
                                bool useBG = bool.Parse(value); checkBox_UseBG.Checked = useBG;
                                if (checkBox_UseBG.Checked)
                                {
                                    try
                                    {
                                        BackgroundImage = Image.FromFile(Application.StartupPath + "Background.jpg");
                                    }
                                    catch { MessageBox.Show("Background.jpg was not found."); }
                                }
                                break;
                            case "AutomaticallyRestartSolvedPuzzle":
                                bool AUR_On = bool.Parse(value); checkBox_AU_Reset.Checked = AUR_On; break;
                            case "MarkColor_Normal":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_Hightlight_Normal = tempColor; button_hColor1.BackColor = tempColor;
                                break;
                            case "MarkColor_Ctrl":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_Hightlight_Ctrl = tempColor; button_hColor2.BackColor = tempColor;
                                break;
                            case "MarkColor_Alt":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_Hightlight_Alt = tempColor; button_hColor3.BackColor = tempColor;
                                break;
                            case "MarkColor_Shift":
                                tempColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                                settings.Color_Hightlight_Shift = tempColor; button_hColor4.BackColor = tempColor;
                                break;
                            case "Player2ResponseTime":
                                settings.Player2ResponseTime = int.Parse(value) < 100 || int.Parse(value) > 10000 ? 300 : int.Parse(value);
                                Autoplay_Timer.Interval = settings.Player2ResponseTime;
                                numericUpDown7.Value = settings.Player2ResponseTime;
                                break;
                            case "PathOfCurrentlyUsedChessSet":
                                if (Directory.Exists(path_pieces + value))
                                {
                                    PathOfCurrentlyUsedChessSet = path_pieces + value;
                                    FolderOfCurrentlyUsedChessSet = value;
                                    comboBox_Psets.Text = FolderOfCurrentlyUsedChessSet;
                                }
                                LoadRequiredPieceImages();
                                break;
                        }
                        if (lines.Contains("PathOfCurrentlyUsedChessSet") == false)
                        {
                            LoadRequiredPieceImages();
                            comboBox_Psets.Text = FolderOfCurrentlyUsedChessSet;
                        }
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            Board_Solver[i][x].SetColors(settings.Color_Selected_Current, settings.Color_Hover_Current, settings.Color_Black_Current, settings.Color_White_Current, settings.Color_LastMove_Current);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error reading the settings file. One or more of the values are not in the accepted range, missing, or not properly formatted."); SetInitialColorsToButtons();
                }
            }
            else
            {
                SetInitialColorsToButtons();
            }
        }
        public void SetInitialColorsToButtons()
        {
            button_setwhiteSqColor.BackColor = settings.Color_White_Current;
            button_blackSqSetColor.BackColor = settings.Color_Black_Current;
            button_setSElectedSquare.BackColor = settings.Color_Selected_Current;
            button_setLastMoveColor.BackColor = settings.Color_LastMove_Current;
            button_stHoverColor.BackColor = settings.Color_Hover_Current;
            button_hColor1.BackColor = settings.Color_Hightlight_Normal;
            button_hColor2.BackColor = settings.Color_Hightlight_Ctrl;
            button_hColor3.BackColor = settings.Color_Hightlight_Alt;
            button_hColor4.BackColor = settings.Color_Hightlight_Shift;
        }
        public void SetPuzzleCountdownLabelTexts(object? sender, EventArgs e)
        {
            Time_Puzzle_SecondsLeft--;
            if (Time_Puzzle_SecondsLeft <= 0)
            {
                label_Countdown_Puzzle.Text = "00:00:00";
                APuzzleIsLoaded = false;
                icon_solved.Visible = false;
                icon_notSolved.Visible = true;
                label_move_right.Text = string.Empty;
                label_move_wrong.Text = "Timeout";
                PlaySoundFile("timeout.wav");
                Timer_Puzzle.Stop();
                return;
            }
            else
            {
                TimeSpan t = TimeSpan.FromSeconds(Time_Puzzle_SecondsLeft);
                label_Countdown_Puzzle.Text = string.Format($"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}");
                if (Time_Puzzle_SecondsLeft == settings.AutoCountdown / 5) { PlaySoundFile("low_time.wav"); label_Countdown_Puzzle.ForeColor = Color.Red; }
            }
        }
        public void SetGlobalCountdownLabelTexts(object? sender, EventArgs e)
        {
            Time_Global_SecondsLeft--;
            if (Time_Global_SecondsLeft <= 0)
            {
                label_Countdown_Global.Text = "00:00:00";
                Timer_Global.Stop();
            }
            else
            {
                TimeSpan t = TimeSpan.FromSeconds(Time_Global_SecondsLeft);
                label_Countdown_Global.Text = string.Format($"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}");
                if (Time_Global_SecondsLeft == Time_Puzzle_SecondsTotal / 5) { PlaySoundFile("low_time.wav"); label_Countdown_Global.ForeColor = Color.Red; }
            }
        }
        public bool PuzzleNameContainsInvalidCharacters(string name)
        {
            bool state = false;
            foreach (char c in InvalidWindowsFilenameCharactes)
            {
                if (name.Contains(c))
                {
                    state = true;
                    break;
                }
            }
            return state;
        }
        public void ExecuteResponseMoveInPuzzle(object? sender, EventArgs e)
        {
            if (CurrentlySolvedPuzzleChapterStep < CurrentPuzzle_Solutions.Count)
            {
                TransitionToPositionFromGivenActionSquareXSquare(CurrentPuzzle_Solutions[CurrentlySolvedPuzzleChapterStep - 1], panel_solver);
                HightlightLastMoveSquares(CurrentPuzzle_Solutions[CurrentlySolvedPuzzleChapterStep - 1]);
            }
            UserToMove = true;
            PuzzleResponse.Enabled = false;
        }
        public void UnhightlightAllSolverSqures()
        {
            for (int i = 0; i < 8; i++)//clear last
            {
                for (int x = 0; x < 8; x++)
                {
                    Board_Solver[i][x].BelongsToLastMove = false;
                }
            }
        }
        public void HightlightLastMoveSquares(string solution)
        {
            if (solution.Length != 5) { return; }
            string square1 = solution.Split("x")[0];
            string square2 = solution.Split("x")[1];
            for (int i = 0; i < 8; i++)//clear last
            {
                for (int x = 0; x < 8; x++)
                {
                    Board_Solver[i][x].BelongsToLastMove = false;
                }
            }
            for (int i = 0; i < 8; i++)//hightlight new
            {
                for (int x = 0; x < 8; x++)
                {
                    if (Board_Solver[i][x].SquareName == square1 || Board_Solver[i][x].SquareName == square2)
                    {
                        Board_Solver[i][x].BelongsToLastMove = true;
                    }
                }
            }
        }
        public void CreateButton(bool isWhite, int SelectedFile, string name, int[] coordinate, Color GivenColor, Panel whichPanel)
        {
            // square name
            // piece name
            // square color
            ChessButton squareChessButton = new();
            squareChessButton.FlatAppearance.BorderSize = 0;
            squareChessButton.DefaultColors_Black = settings.Color_Black_Current;
            squareChessButton.DefaultColors_White = settings.Color_White_Current;
            squareChessButton.belongsToWhichPanel = whichPanel;
            squareChessButton.BackgroundImage = EmptySquare;
            squareChessButton.IsWhiteSquare = isWhite;
            squareChessButton.SquareColor = GivenColor == settings.Color_White_Current ? "w" : "b";
            DefaultButtonColors.Add(GivenColor);
            squareChessButton.Location = new Point(coordinate[0], coordinate[1]);
            squareChessButton.SquareName = name;
            squareChessButton.DefaultBackColor = GivenColor;
            squareChessButton.BackgroundImageLayout = ImageLayout.Stretch;
            squareChessButton.MouseEnter += HoverEnterChessSquare;
            squareChessButton.MouseLeave += HoverLEaveChessSquare;
            if (whichPanel == panel_composer)
            {
                squareChessButton.ContextMenuStrip = menuChangeSquare;
                squareChessButton.MouseDown += UserClicksComposerSquare;
                squareChessButton.ToMove = "Any";
                Board_Composer[SelectedFile - 1].Add(squareChessButton);
            }
            else
            {
                Board_Solver[SelectedFile - 1].Add(squareChessButton);
                squareChessButton.MouseDown += UserClicksSolverSquare;
            }
            whichPanel.Controls.Add(squareChessButton);
            //Board_Composer.Reverse();
        }
        public void HoverEnterChessSquare(object? sender, EventArgs e)
        {
            if (sender == null){ return; }
            ChessButton ourB = (ChessButton)sender;
            Currently_Hovered_Button = ourB;
            ourB.IsHovered = true;
            if (ourB.belongsToWhichPanel == panel_composer) { label_square_displayer.Text = ourB.SquareName; }
            //test
          }
        public void HoverLEaveChessSquare(object? sender, EventArgs e)
        {
            if (sender==null) return;
            ChessButton ourB = (ChessButton)sender;
            ourB.IsHovered = false;
            if (ourB.belongsToWhichPanel == panel_composer) { label_square_displayer.Text = ""; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string vs = Environment.Version.ToString().Split(".")[0];
            double versionofApp = double.Parse(vs);
            if (versionofApp < 6) { MessageBox.Show("Sorry, you need .NET version 6 or above to run this app."); Environment.Exit(0); }
            //--------------------------------------------------
            label_square_displayer.Text = "";
            c_letter1.Text = "a";
            c_letter2.Text = "b";
            c_number1.Text = "1";
            c_number2.Text = "2";
            ToMoveLabel.ToMove = "None";
            //--------------------------------------------------
            //--------------------------------------------------
            RegisterWriteBoxesForHoverEvent();
            //--------------------------------------------------
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox_name.PlaceholderText = "Required";
            textBox_hint.PlaceholderText = "Hint when asked (optional)";
            textbox_Wrong.PlaceholderText = "When the move is wrong (optional)";
            textBox_Right.PlaceholderText = "When the move is right (optional)";
            textBox_event.PlaceholderText = "Who/When/Where was played? (optional)";
            textBox_description.PlaceholderText = "Any details about the puzzzle/PR ? (optional)";
            comboBox_letter1_om.Text = "a";
            comboBox_letter2_om.Text = "a";
            comboBox_num1_om.Text = "1";
            comboBox_num2_om.Text = "2";
            PutAllTextboxesForMEnterEvent();
            //--------------------------------------------------
            Point BoardPoint = new(panel_solver.Location.X, panel_solver.Location.Y);
            panel_composer.Location = BoardPoint;
            //--------------------------------------------------
            // PRODUCE ALL BOARDS WITH TOP-TO-BOTTOM FILE-BY-FILE 
            //--------------------------------------------------
            string[] fileChar = { "a", "b", "c", "d", "e", "f", "g", "h" };
            _ = fileChar.Reverse();
            int coord_Y = 0;
            int coord_X = 0;
            int[] rankChar = { 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int file = 1; file <= 8; file++)
            {
                for (int rank = 1; rank <= 8; rank++)
                {
                    Color currentColor = ColorsOfSquaresFilebyFile[file - 1][rank - 1];
                    // square name | piece on square | color
                    string square_Name = $"{fileChar[rank - 1]}{rankChar[file - 1]}";
                    //------------------------------------------------------------------
                    int[] currentCoords = { coord_X, coord_Y };
                    bool isWhite = currentColor != settings.Color_Black_Current;
                    //------------------------------------------------------------------
                    int SelectedFile = Convert.ToInt32(rankChar[file - 1]); // this is for adding in the dictioanry for easier going through files and ranks
                    //------------------------------------------------------------------
                    CreateButton(isWhite, SelectedFile, square_Name, currentCoords, currentColor, panel_composer);
                    CreateButton(isWhite, SelectedFile, square_Name, currentCoords, currentColor, panel_solver);
                    coord_X += sizeOfSquare;
                }
                coord_X = 0; //reset for next file
                coord_Y += sizeOfSquare;
            }
            Board_Composer.Reverse();
            Board_Solver.Reverse();
            //--------------------------------------------------
            panel_composer.Location = new Point(12, 12);
            ReadSettingsFile();
        }
        public void GeneratePuzzle()
        {
            string name = textBox_name.Text.Trim();
            string errors = string.Empty;
            //--------------------------------------------------------------------------
            //--------------------------------------------------------------------------
            if (name == string.Empty) { if (checkBox_Making_PR.Checked == false) errors += $"- No name given.\n"; }
            else { if (PuzzleNameContainsInvalidCharacters(name)) { errors += $"- The given puzzle name contains characters not supported by windows filenames. Do not use {string.Join(" ", InvalidWindowsFilenameCharactes)}\n"; } }
            if (CurrentPuzzleComposition_List.Count == 0) { errors += "- No puzzle chapters are created.\n"; }
            //--------------------------------------------------------------------------
            else { if (CurrentPuzzleComposition_List.Count % 2 == 0) { errors += "- The count of the chapters in a puzzle must be an odd number.\n"; } }
            //--------------------------------------------------------------------------
            string description = textBox_description.Text.Trim() == string.Empty ? "No description." : textBox_description.Text;
            if (errors.Length > 0) { MessageBox.Show(errors); return; }
            if (File.Exists(path_puzzles + name + ".txt"))
            {
                DialogResult dr = MessageBox.Show($"{path_puzzles} already exists. Overwrite?",
                  $"Existing puzzle", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        return;
                }
            }
            if (checkBox_Making_PR.Checked == false) // if not making a puzzle rush
            {
                //-------------------------------------------------------------------------
                if (checkBox_LastPlayedOptional.Checked)
                {
                    string LastMoveBeforePuzzleStarts = $"{comboBox_letter1_om.Text}{comboBox_num1_om.Text}x{comboBox_letter2_om.Text}{comboBox_num2_om.Text}";
                    CurrentPuzzleComposition_List[0][7] = LastMoveBeforePuzzleStarts;
                }
                string savePath = $"{path_puzzles}\\{name}.txt";
                List<string> composedLines = new()
                {
                    $"<{description}>"
                };
                foreach (string[] line in CurrentPuzzleComposition_List)
                {
                    string joined_line_fields = string.Empty;
                    foreach (string field in line)
                    {
                        joined_line_fields += $"[{field}]";
                    }
                    composedLines.Add(joined_line_fields);
                }
                composedLines = composedLines.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
                File.WriteAllLines(savePath, composedLines);
                PlaySoundFile("create_puzzle.wav");
                MessageBox.Show($"Generated the puzzle, with {CurrentPuzzleComposition_List.Count} chapter/s, as:\n{savePath}");
                ClearTextBoxes(textBox_name, textBox_hint, textbox_Wrong, textBox_Right, textBox_event, textBox_description);
                label_Action_Response.Text = "To move: player";
                //-------------------------------------------------------------------------
            }
            else // if making a puzzle rush - add to puzzle rush collection
            {
                // put in the list of puzzles
                PuzzleRushPuzzles_Composed.Add(CurrentPuzzleComposition_List.ToList()); // CurrentPuzzleComposition_s_Chapters has NO problems [<]
                // put in the listbox
                listbox_Puzzles_Rush.Items.Add(textBox_description.Text.Trim() == string.Empty ? $"unnamed {PuzzleRushPuzzles_Composed.Count}" : textBox_name);
                // put its description for later writing of the file
                DescriptionsForPR_Puzzles.Add(textBox_description.Text.Trim() == string.Empty ? "No description." : textBox_description.Text);
                PlaySoundFile("create_puzzle.wav");
                ClearTextBoxes(textBox_hint, textbox_Wrong, textBox_Right, textBox_event, textBox_description);
                MessageBox.Show("Added the puzzle to the puzzle rush composition.");
            }
            listbox_Puzzle_Fragments.Items.Clear();
            CurrentPuzzleComposition_List.Clear();
        }
        private void GeneratePuzzle_Click(object sender, EventArgs e)
        {
            GeneratePuzzle();
        }
        public static void HideSelectedControls(params Control[] controls) { foreach (Control c in controls) { c.Visible = false; } }
        public static void ShowSelectedControls(params Control[] controls) { foreach (Control c in controls) { c.Visible = true; } }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // if solving
            {
                ShowSelectedControls(label_event, label_Countdown_Puzzle, label_Countdown_Global, label_move_wrong, label_move_right, panel_solver, button_hint, label_chapterCounter, button_show_solution, ToMoveLabel, label_event);
                HideSelectedControls(panel_composer, button_clear_Board, button_GenerateStartingChessPosition, icon_notSolved, icon_solved, label_square_displayer, label_Action_Response);
                if (CurrentlySolvingAPuzzleRush) { PuzzlesDisplay.Visible = true; }
                if (PR_Paused) { button_gotoNextPuzzle.Visible = true; }
            }
            else // if composing
            {
                HideSelectedControls(button_Autoplay, button_gotoNextPuzzle, PuzzlesDisplay, label_event, label_Countdown_Puzzle, label_Countdown_Global, ToMoveLabel, label_move_wrong, label_move_right, label_hint, button_reset_puzzle, button_show_solution, label_show_solution, label_event, panel_solver, button_hint, icon_notSolved, icon_solved, label_chapterCounter);
                ShowSelectedControls(panel_composer, button_clear_Board, label_square_displayer, label_Action_Response, button_GenerateStartingChessPosition);
                Point BoardPoint = new(panel_solver.Location.X, panel_solver.Location.Y);
                panel_composer.Location = BoardPoint;
            }
        }
        public void RemoveLastChapter()
        {
            if (CurrentPuzzleComposition_List.Count > 0)
            {
                CurrentPuzzleComposition_List.RemoveAt(CurrentPuzzleComposition_List.Count - 1);
                listbox_Puzzle_Fragments.Items.RemoveAt(listbox_Puzzle_Fragments.Items.Count - 1);
            }
        }
        public string GeneratePositionAsString(List<List<ChessButton>> WhichList)
        {
            List<List<ChessButton>> localList = WhichList.ToList();
            string result = string.Empty;
            if (checkbox_smartAdd.Checked)
            {
                // if checked, check if a move was done with mouse
                if (LastMoveWasDoneByClicks)
                {
                    string startSq = $"{comboBox_letter1_om.Text}{comboBox_num1_om.Text}";
                    string endSq = $"{comboBox_letter1_om.Text}{comboBox_num1_om.Text}";
                    string pieceNameStart = string.Empty;
                    string pieceNameEnd = string.Empty;
                    List<int> startSqCoords = new();
                    List<int> endSqCoords = new();
                    // and then take second square's piece name and use it as first square's name
                    // by creating a copy of the board_solver and changing the squares there 
                    for (int i = 0; i < localList.Count; i++)
                    {
                        for (int x = 0; x < localList[i].Count; x++)
                        {
                            if (localList[i][x].SquareName == startSq)
                            {
                                startSqCoords.Add(i);
                                startSqCoords.Add(x);
                                pieceNameStart = localList[i][x].PieceName;
                            }
                            if (localList[i][x].SquareName == endSq)
                            {
                                endSqCoords.Add(i);
                                endSqCoords.Add(x);
                                pieceNameEnd = localList[i][x].PieceName;
                            }
                        }
                    }
                    localList[startSqCoords[0]][startSqCoords[1]].PieceName = pieceNameEnd;
                    localList[endSqCoords[0]][endSqCoords[1]].PieceName = pieceNameStart;
                }
            }
            for (int i = 0; i < WhichList.Count; i++)
            {
                for (int x = 0; x < WhichList[i].Count; x++)
                {
                    result += WhichList[i][x].PieceName;
                }
            }
            return result;
        }
        public char GetPieceTypeOfSquare(string whichSquare)
        {
            _ = Convert.ToInt32(whichSquare[1]);
            _ = whichSquare[0];

            char result = 'k';
            for (int rank=0; rank<8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    if (Board_Solver[rank][file].SquareName == whichSquare)
                    {
                        result = (Board_Composer[rank][file].PieceName[0]);
                    }
                }
            }

            return result;
        }
        public void AddArrangedChapter()
        {
            string Proposed_solution = $"{c_letter1.Text}{c_number1.Text}x{c_letter2.Text}{c_number2.Text}";
            //---------------------------------------------------------------------------------------------------------------------------
            if ($"{c_letter1.Text}{c_number1.Text}" == $"{c_letter2.Text}{c_number2.Text}") { MessageBox.Show("The starting square and the ending square cannot be the same."); return; }
            //---------------------------------------------------------------------------------------------------------------------------
            if (CheckForKings() == false) { MessageBox.Show("There must be exactly one white king and exactly one black king and minimum one other piece-type"); return; }
            //---------------------------------------------------------------------------------------------------------------------------
            if (CurrentPuzzleComposition_List.Count > 0 && CurrentPuzzleComposition_List[^1][1] == Proposed_solution) { MessageBox.Show("the next move cannot be the same."); return; }
            //---------------------------------------------------------------------------------------------------------------------------
            string startSq = $"{c_letter1.Text}{c_number1.Text}";
             
             
            char PieceTypeOfAttackingSquare = GetPieceTypeOfSquare(startSq);
          
            //---------------------------------------------------------------------------------------------------------------------------    
            string position = GeneratePositionAsString(Board_Composer);
            string hint = textBox_hint.Text.Trim() == string.Empty ? "No hints" : textBox_hint.Text;
            string wrong = textbox_Wrong.Text.Trim() == string.Empty ? " " : textbox_Wrong.Text;
            string right = textBox_Right.Text.Trim() == string.Empty ? " " : textBox_Right.Text;
            string toMove = char.IsUpper(PieceTypeOfAttackingSquare) ? "White to move" : "Black to move";
            string event_ = label_event.Text == string.Empty ? " " : label_event.Text;
            //---------------------------------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------------
            if (PuzzleRushPuzzles_Composed.Count < CurrentlyEditedPuzzleNumber) { PuzzleRushPuzzles_Composed.Add(new List<string[]>()); }
            string[] ChapterData = { position, Proposed_solution, hint, wrong, right, toMove, event_, "" };
            CurrentPuzzleComposition_List.Add(ChapterData);
            listbox_Puzzle_Fragments.Items.Add(Proposed_solution);
            ClearTextBoxes(textBox_hint, textbox_Wrong, textBox_Right, textBox_event);
            label_Action_Response.Text = label_Action_Response.Text == "To move: player" ? "To move: response" : "To move: player";
            PlaySoundFile("newChapter.wav");
            if (checkBox_AT.Checked)
            {
                if (checkbox_smartAdd.Checked)
                {
                    if (!SquareIsOccupied($"{c_letter2.Text}{c_number2.Text}"))
                    {
                        TransitionToPositionFromGivenActionSquareXSquare(c_letter1.Text + c_number1.Text + "x" + c_letter2.Text + c_number2.Text, panel_composer);
                    }
                }
                else
                {
                    TransitionToPositionFromGivenActionSquareXSquare(c_letter1.Text + c_number1.Text + "x" + c_letter2.Text + c_number2.Text, panel_composer);
                }
            }
        }
        public bool SquareIsOccupied(string squareNameStart)
        {
            bool result = false;
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (Board_Composer[i][x].SquareName == squareNameStart)
                    {
                        result = true; break;
                    }
                }
            }
            return result;
        }
        public static void ClearTextBoxes(params TextBox[] ts) { foreach (TextBox t in ts) { t.Text = string.Empty; } }
        private void AddPuzzleFragment_Click(object sender, EventArgs e)
        {
            AddArrangedChapter();
        }
        public void ClearChaptersOfCurrentlyComposedPuzzle()
        {
            CurrentPuzzleComposition_List.Clear();
            listbox_Puzzle_Fragments.Items.Clear();
        }
        private void PawnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["pawn_white"];
            Currently_Hovered_Button.PieceName = "P";
        }
        private void EMPYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = EmptySquare;
            Currently_Hovered_Button.PieceName = "-";
        }
        public void ClearComposerBoard()
        {
            foreach (ChessButton b in panel_composer.Controls)
            {
                b.BackgroundImage = EmptySquare;
                b.PieceName = "-";
            }
        }
        public void ClearBoardPuzler()
        {
            foreach (ChessButton b in panel_solver.Controls)
            {
                b.BackgroundImage = EmptySquare;
                b.PieceName = "-";
            }
        }
        private void ClearComposerBoard_Click(object sender, EventArgs e) { ClearComposerBoard(); }
        private void GenerateStartingChessPosition_Click(object sender, EventArgs e)
        {
            ClearComposerBoard();
            PlaySoundFile("NEWGAME.wav");
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    switch (Board_Composer[rank][file].SquareName)
                    {
                        case "a1": Board_Composer[rank][file].BackgroundImage = pieces_pics["rook_white"]; Board_Composer[rank][file].PieceName = "R"; break;
                        case "b1": Board_Composer[rank][file].BackgroundImage = pieces_pics["knight_white"]; Board_Composer[rank][file].PieceName = "N"; break;
                        case "c1": Board_Composer[rank][file].BackgroundImage = pieces_pics["bishop_white"]; Board_Composer[rank][file].PieceName = "B"; break;
                        case "d1": Board_Composer[rank][file].BackgroundImage = pieces_pics["queen_white"]; Board_Composer[rank][file].PieceName = "Q"; break;
                        case "e1": Board_Composer[rank][file].BackgroundImage = pieces_pics["king_white"]; Board_Composer[rank][file].PieceName = "K"; break;
                        case "f1": Board_Composer[rank][file].BackgroundImage = pieces_pics["bishop_white"]; Board_Composer[rank][file].PieceName = "B"; break;
                        case "g1": Board_Composer[rank][file].BackgroundImage = pieces_pics["knight_white"]; Board_Composer[rank][file].PieceName = "N"; break;
                        case "h1": Board_Composer[rank][file].BackgroundImage = pieces_pics["rook_white"]; Board_Composer[rank][file].PieceName = "R"; break;
                        case "a2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "b2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "c2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "d2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "e2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "f2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "g2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "h2": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_white"]; Board_Composer[rank][file].PieceName = "P"; break;
                        case "a8": Board_Composer[rank][file].BackgroundImage = pieces_pics["rook_black"]; Board_Composer[rank][file].PieceName = "r"; break;
                        case "b8": Board_Composer[rank][file].BackgroundImage = pieces_pics["knight_black"]; Board_Composer[rank][file].PieceName = "n"; break;
                        case "c8": Board_Composer[rank][file].BackgroundImage = pieces_pics["bishop_black"]; Board_Composer[rank][file].PieceName = "b"; break;
                        case "d8": Board_Composer[rank][file].BackgroundImage = pieces_pics["queen_black"]; Board_Composer[rank][file].PieceName = "q"; break;
                        case "e8": Board_Composer[rank][file].BackgroundImage = pieces_pics["king_black"]; Board_Composer[rank][file].PieceName = "k"; break;
                        case "f8": Board_Composer[rank][file].BackgroundImage = pieces_pics["bishop_black"]; Board_Composer[rank][file].PieceName = "b"; break;
                        case "g8": Board_Composer[rank][file].BackgroundImage = pieces_pics["knight_black"]; Board_Composer[rank][file].PieceName = "n"; break;
                        case "h8": Board_Composer[rank][file].BackgroundImage = pieces_pics["rook_black"]; Board_Composer[rank][file].PieceName = "r"; break;
                        case "a7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "b7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "c7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "d7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "e7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "f7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "g7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                        case "h7": Board_Composer[rank][file].BackgroundImage = pieces_pics["pawn_black"]; Board_Composer[rank][file].PieceName = "p"; break;
                    }
                }
            }
        }
        public static void ClearLists(params List<string>[] lists)
        {
            foreach (List<string> list in lists) { list.Clear(); }
        }
        public void LightCurrentlySolvedPRPuzzle(int index) { PuzzlesDisplay.Controls[index].BackColor = Color.LightBlue; }
        public void ChangeColorForTargetPuzzleRush_InList(int index, Color newColor) { var c = PuzzlesDisplay.Controls; if (c.Count == 0) { return; } if (c[index].BackColor == Color.LightBlue) { c[index].BackColor = newColor; } }
        public void LoadPuzzleRush(List<string> lines)
        {
            AllPuzzles_of_PuzzleRush.Clear();
            // = the initial, 0 solve states, of the solving of puzzles
            List<string> puzzleLines = new();
            // put each puzzle in the list
            int toDo = 0;
            lines.RemoveAt(0);
            int countPuzzles = lines.Count(f => f.Contains('<')) + 1;
            for (int i = 0; i < countPuzzles; i++) { AllPuzzles_of_PuzzleRush.Add(new List<string>()); } // add X null collections to the megacollection
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains('<'))
                {
                    toDo++; // if the tag is met, skip and go to adding the next puzzle
                }
                else
                {
                    AllPuzzles_of_PuzzleRush[toDo].Add(lines[i]);
                }
            }
        }
        public void MessageWholeColelction()
        {
            string all = string.Empty;
            foreach (List<string> list in AllPuzzles_of_PuzzleRush)
            {
                foreach (string line in list)
                {
                    all += $"{line}\n";
                }
                all += "\n";
            }
        }
        public void SolveSelectedPuzzle()
        {
            if (listofPuzzles.SelectedItems.Count == 1) // if an item is selected
            {
                string name = (string)listofPuzzles.SelectedItems[0] + ".txt";
                CurrentlyOpenedPuzzleFilename = $"{path_puzzles}\\{name}";
                if (File.Exists(CurrentlyOpenedPuzzleFilename))
                {
                    MakeLabelsEmpty(label_show_solution, label_hint, label_move_right, label_move_wrong);
                    CurrentPuzzles_Lengths.Clear();
                    CurrentlySolvedPuzzleNumber = 0;
                    HideSelectedControls(button_reset_puzzle, icon_solved, icon_notSolved);
                    CurrentPuzzleIsSolved = false;
                    CurrenltOpenedPuzzleChaptersCount = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).Length;
                    CurrenlyOpenedPuzzle_ChaptersSolved = 0;
                    CurrentlySolvedPuzzleChapterStep = 0;
                    ClearLists(CurrentPuzzle_Hints, CurrentPuzzle_Positions, CurrentPuzzle_Solutions, CurrentPuzzle_ToMove);
                    //------------------------------------------------------------------------
                    int countPuzzles = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).Count(f => f.Contains('<'));
                    //-----------------------
                    // if it's a puzzle rush
                    //-----------------------
                    if (countPuzzles > 1)
                    {
                        List<string> fileLines = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).ToList();
                        LoadPuzzleRush(fileLines);
                        if (AllPuzzles_of_PuzzleRush.Count <= 1) { MessageBox.Show("The selected puzzle rush file contains less than 2 puzzles."); return; }
                        // after adding all puzzles to the puzzle collection, load the first */
                        LoadTargetPuzzle(AllPuzzles_of_PuzzleRush[0]);
                        // feed the puzzles to the listview
                        GenerateRightWrongLabelsForPRDisplay(AllPuzzles_of_PuzzleRush.Count);
                        PuzzlesDisplay.Visible = true;
                        LightCurrentlySolvedPRPuzzle(0);
                        CurrentlySolvingAPuzzleRush = true;
                    }
                    //-----------------------
                    // if it's a NOT puzzle rush
                    //-----------------------
                    if (countPuzzles <= 1)
                    {
                        ClearPRDisplay(true);
                        List<string> PuzzleFileName = File.ReadLines(CurrentlyOpenedPuzzleFilename).ToList();
                        LoadTargetPuzzle(PuzzleFileName);
                        PuzzlesDisplay.Visible = false;
                    }
                    APuzzleIsLoaded = true;
                    CurrentPuzzleIsSolved = false;
                    UserToMove = true;
                    ToMoveLabel.ToMove = CurrentPuzzle_ToMove[0]; SetToMoveInButtons(ToMoveLabel.Text);
                    label_Countdown_Puzzle.ForeColor = Color.White;
                    if (settings.AutoCountdown > 0) { Time_Puzzle_SecondsLeft = settings.AutoCountdown; Timer_Puzzle.Start(); }
                    EnableChessBoard();
                }
                else
                {
                    MessageBox.Show("The selected puzzle no longer exists.");
                    RefreshPuzzleList();
                    CurrentlyOpenedPuzzleFilename = "";
                }
            }
        }
        public void ClearPRDisplay(bool ifFilled)
        {
            if (ifFilled)
            {
                if (PuzzlesDisplay.Controls.Count > 0)
                {
                    PuzzlesDisplay.Controls.Clear();
                    RightWrongAnswersInPR.Clear();
                    currentDistanceOfLabelsForPRDisplay = 0;
                }
            }
            else
            {
                PuzzlesDisplay.Controls.Clear();
                RightWrongAnswersInPR.Clear();
                currentDistanceOfLabelsForPRDisplay = 0;
            }
        }
        public static List<char[]> SplitGivenSCN(string input)
        {
            List<char> allChars = input.ToCharArray().ToList();
            List<char[]> result = new();
            for (int i = 0; i < 8; i++)
            {
                List<char> current8chars = new();
                for (int x = 0; x < 8; x++)
                {
                    current8chars.Add(allChars[0]);
                    allChars.RemoveAt(0);
                }
                result.Add(current8chars.ToArray());
            }
            return result;
        }
        private void SolveButton_Click(object sender, EventArgs e) { SolveSelectedPuzzle(); }
        public void RecreatePuzzleFromSCN(string SCN, Panel WhichPanel) // solution is given instead of position
        {
            List<List<ChessButton>> ourBoard = WhichPanel == panel_solver ? Board_Solver.ToList() : Board_Composer.ToList();
            ClearBoardPuzler();
            List<char[]> FilesofChars = SplitGivenSCN(SCN);
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    ourBoard[i][x].PieceName = FilesofChars[i][x].ToString(); //set char
                    ourBoard[i][x].BackgroundImage = CharactersAsPieceImages[FilesofChars[i][x]]; // set image
                }
            }
        }
        public static void SetWaitingPaste(bool isPasting, List<List<ChessButton>> whichList)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    whichList[i][x].WaitingPaste = isPasting;
                }
            }
        }
        public void SetToMoveInButtons(string whoMoves)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Board_Solver[i][x].ToMove = whoMoves;
                }
            }
        }
        public void ClearAllMarks()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Board_Solver[i][x].IsMarked = false;
                }
            }
        }
        public void DisableChessBoard()
        {
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file=0; file<8; file++)
                {
                    Board_Solver[rank][file].CanInteract = false;
                }
            }
        }
        public void EnableChessBoard()
        {
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    Board_Solver[rank][file].CanInteract = true;
                }
            }
        }
        public void UserClicksSolverSquare(object? sender, MouseEventArgs e)
        {
            if (sender == null) {return; }
            ChessButton thisButton = (ChessButton)sender;
            if (thisButton.CanInteract == false) { return; }
            if (e.Button.ToString() == "Left")
            {
                ClearAllMarks();
                if (APuzzleIsLoaded == true && CurrentPuzzleIsSolved == false && UserToMove == true)
                {
                    if (Selected_A_Piece == false) // if you click the starting square
                    {
                        //----------------------------------------------------------------------
                        SelectedSquare_Start = (ChessButton)sender;
                        //----------------------------------------------------------------------
                        //// you cannot select an empty square
                        //----------------------------------------------------------------------
                        if (SelectedSquare_Start.PieceName == "-") { return; }
                        //----------------------------------------------------------------------
                        //----------------------------------------------------------------------
                        //// you cannot select a piece color that is NOT to move
                        //----------------------------------------------------------------------
                        if (char.IsUpper(SelectedSquare_Start.PieceName[0]) && ToMoveLabel.Text == "Black to move") { return; }
                        if (char.IsLower(SelectedSquare_Start.PieceName[0]) && ToMoveLabel.Text == "White to move") { return; }
                        //----------------------------------------------------------------------
                        Selected_A_Piece = true;
                        SelectedSquare_Start.IsSelected = true;
                        SetWaitingPaste(true, Board_Solver);
                    }
                    else // if you click the ending square
                    {
                        SelectedSquare_End = (ChessButton)sender;
                        string  sqname1 = SelectedSquare_Start.SquareName;
                        string  sqname2 = SelectedSquare_End.SquareName;
                        ProposedSolution = sqname1 + "x" + sqname2;
                        //----------------------------------------------------------------------
                        // if starting square's color is the ending square's color (the same!), deselect the square
                        //----------------------------------------------------------------------
                        if (sqname1 == sqname2) { Selected_A_Piece = false; SelectedSquare_Start.IsSelected = false; ProposedSolution = string.Empty; SetWaitingPaste(false, Board_Solver); return; }
                        //----------------------------------------------------------------------
                        Selected_A_Piece = false;
                        SelectedSquare_Start.IsSelected = false;
                        SetWaitingPaste(false, Board_Solver);
                        //----------------------------------------------------------------------
                        if (CurrentPuzzleIsSolved == false)
                        {
                            if (CurrentlySolvedPuzzleChapterStep == CurrentPuzzle_Solutions.Count) { MessageBox.Show("Error with the puzzle."); return; }
                            icon_solved.Visible = true;
                            icon_notSolved.Visible = false;
                            if (ProposedSolution == CurrentPuzzle_Solutions[CurrentlySolvedPuzzleChapterStep])
                            {
                                CurrentlySolvedPuzzleChapterStep++;
                                if (CurrentlySolvedPuzzleChapterStep == CurrentPuzzle_Solutions.Count) // if the puzzle is completed
                                {
                                    CurrenlyOpenedPuzzle_ChaptersSolved++;
                                    PlaySoundFile("success.wav");
                                    label_chapterCounter.Text = "Solved!";
                                 
                                    button_reset_puzzle.Visible = !CurrentlySolvingAPuzzleRush;
                                    TransitionToPositionFromGivenActionSquareXSquare(CurrentPuzzle_Solutions[CurrentlySolvedPuzzleChapterStep - 1], panel_solver);
                                    label_move_right.Text = CurrentPuzzle_rightAnswers[CurrenlyOpenedPuzzle_ChaptersSolved - 1];
                                    label_event.Text = CurrentEvents[CurrenlyOpenedPuzzle_ChaptersSolved - 1];
                                    label_move_wrong.Text = string.Empty;
                                    
                                    HightlightLastMoveSquares(CurrentPuzzle_Solutions[^1]);
                                    ToMoveLabel.ToMove = "None"; SetToMoveInButtons(ToMoveLabel.Text);
                                    CurrenlyOpenedPuzzle_ChaptersSolved = 0;
                                    //------------------------------------------------------------------------------------------------------------------
                                    //------------------------------------------------------------------------------------------------------------------
                                    if (AllPuzzles_of_PuzzleRush.Count > 0)
                                    {
                                        ChangeColorForTargetPuzzleRush_InList(CurrentlySolvedPuzzleNumber, Color.Green);
                                    }
                                    else
                                    {
                                        if (checkBox_AU_Reset.Checked)
                                        {
                                            RestartCurrentPuzzle();
                                        }
                                        else
                                        {
                                            CurrentPuzzleIsSolved = true;
                                            UserToMove = false;
                                            DisableChessBoard();
                                        }
                                    }
                                    if (Time_Puzzle_SecondsLeft > 0) Timer_Puzzle.Stop();
                                    if (CurrentlySolvingAPuzzleRush)
                                    {
                                        CurrentlySolvedPuzzleNumber++;
                                        CurrenlyOpenedPuzzle_ChaptersSolved = 0;
                                        if (CurrentlySolvedPuzzleNumber == AllPuzzles_of_PuzzleRush.Count) // if all puzzles are solved in a puzzle rush
                                        {
                                            if (checkBox_AU_Reset.Checked)
                                            {
                                                RestartCurrentPuzzle();
                                            }
                                            else
                                            {
                                                CurrentPuzzleIsSolved = true;
                                                UserToMove = false;
                                                CurrentlySolvingAPuzzleRush = false;
                                                ToMoveLabel.ToMove = "None"; SetToMoveInButtons(ToMoveLabel.Text);
                                                DisableChessBoard();
                                            }
                                        }
                                        else
                                        {
                                            if (checkBox_autoPR.Checked == false)
                                            {
                                                UserToMove = false;
                                                PR_Paused = true;
                                                button_gotoNextPuzzle.Visible = true;
                                            }
                                            else
                                            {
                                                LightCurrentlySolvedPRPuzzle(CurrentlySolvedPuzzleNumber);
                                                LoadTargetPuzzle(AllPuzzles_of_PuzzleRush[CurrentlySolvedPuzzleNumber]);
                                                ToMoveLabel.ToMove = CurrentPuzzle_ToMove[CurrentlySolvedPuzzleChapterStep]; SetToMoveInButtons(ToMoveLabel.Text);
                                            }
                                        }
                                    }
                                    //------------------------------------------------------------------------------------------------------------------
                                    //------------------------------------------------------------------------------------------------------------------
                                    else
                                    {
                                        ToMoveLabel.Text = "";
                                    }
                                }
                                else // if the  the answer is correct
                                {
                                    CurrenlyOpenedPuzzle_ChaptersSolved++;
                                    PlaySoundFile("correct.wav");
                                    ToMoveLabel.ToMove = CurrentPuzzle_ToMove[CurrentlySolvedPuzzleChapterStep - 1]; SetToMoveInButtons(ToMoveLabel.Text);
                                    label_chapterCounter.Text = $"{CurrenlyOpenedPuzzle_ChaptersSolved}/{CountRealMoves(CurrentPuzzles_Lengths[CurrentlySolvedPuzzleNumber])}";
                                    RecreatePuzzleFromSCN(CurrentPuzzle_Positions[CurrentlySolvedPuzzleChapterStep], panel_solver);
                                    button_reset_puzzle.Visible = !CurrentlySolvingAPuzzleRush;
                                    UserToMove = false; MoveAutomaticallyResponseMove();
                                    label_move_right.Text = CurrentPuzzle_rightAnswers[CurrenlyOpenedPuzzle_ChaptersSolved - 1];
                                    label_move_wrong.Text = string.Empty;
                                    HightlightLastMoveSquares(CurrentPuzzle_Solutions[CurrenlyOpenedPuzzle_ChaptersSolved - 1]);
                                }
                            }
                            else // if the answer is wrong
                            {
                                PlaySoundFile("wrong.wav");
                                icon_notSolved.Visible = true;
                                icon_solved.Visible = false;
                                label_move_wrong.Text = CurrentPuzzle_wrongAnswers[CurrentlySolvedPuzzleChapterStep];
                                if (AllPuzzles_of_PuzzleRush.Count > 0) ChangeColorForTargetPuzzleRush_InList(CurrentlySolvedPuzzleNumber, Color.Red);
                            }
                            ProposedSolution = string.Empty;
                            SelectedSquare_End.IsHovered = true;
                        }
                    }
                }
            }
            else // if mouse right-click
            {
                if (thisButton.IsMarked) { thisButton.IsMarked = false; return; }
                if (Key_Pressed_Alt && !Key_Pressed_Ctrl && !Key_Pressed_Shift) //alt
                {
                    thisButton.Mark(settings.Color_Hightlight_Alt);
                    return;
                }
                if (!Key_Pressed_Alt && Key_Pressed_Ctrl && !Key_Pressed_Shift) //ctrl
                {
                    thisButton.Mark(settings.Color_Hightlight_Ctrl);
                    return;
                }
                if (!Key_Pressed_Alt && !Key_Pressed_Ctrl && Key_Pressed_Shift) //shift
                {
                    thisButton.Mark(settings.Color_Hightlight_Shift);
                    return;
                }
                if (!Key_Pressed_Alt && !Key_Pressed_Ctrl && !Key_Pressed_Shift) //none
                {
                    thisButton.Mark(settings.Color_Hightlight_Normal);
                    return;
                }
            }
        }
        public void LoadTargetPuzzle(List<string> PuzzleData)
        {
            try
            {
                LastMovePlayedBeforeThePuzzleStarts = string.Empty;
                // clear before re-doing
                ClearLists(CurrentPuzzle_wrongAnswers, CurrentPuzzle_rightAnswers, CurrentPuzzle_Positions, CurrentPuzzle_Solutions, CurrentPuzzle_Hints, CurrentPuzzle_ToMove);
                CurrenlyOpenedPuzzle_ChaptersSolved = 0;
                //Load the puzzle------------------------------------------------
                if (PuzzleData[0].Contains('<')) { PuzzleData.RemoveAt(0); }
                foreach (string line in PuzzleData)
                {
                    Regex pattern = new(@"(?<=\[)[^\[\]]+(?=\])", // Define a regular expression for content in brackets
                    RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection matches = pattern.Matches(line); // Find matches.
                    CurrentPuzzle_Positions.Add(matches[0].Value);//position
                    CurrentPuzzle_Solutions.Add(matches[1].Value);//solution
                    CurrentPuzzle_Hints.Add(matches[2].Value);//hint
                    CurrentPuzzle_wrongAnswers.Add(matches.Count >= 4 ? matches[3].Value : "");//right
                    CurrentPuzzle_rightAnswers.Add(matches.Count >= 5 ? matches[4].Value : "");//wrong
                    CurrentPuzzle_ToMove.Add(matches.Count >= 6 ? matches[5].Value : "");//To move
                    CurrentEvents.Add(matches.Count >= 7 ? matches[6].Value : "");//event
                    LastMovePlayedBeforeThePuzzleStarts = LastMovePlayedBeforeThePuzzleStarts == string.Empty ? matches.Count >= 8 ? matches[7].Value : "" : LastMovePlayedBeforeThePuzzleStarts; //last played move
                }
                CurrentPuzzles_Lengths.Add(PuzzleData.Count);
                //--------------------------------------------
                CurrentlySolvedPuzzleChapterStep = 0;
                RecreatePuzzleFromSCN(CurrentPuzzle_Positions[0], panel_solver);
                label_chapterCounter.Visible = true;
                label_chapterCounter.Text = $"0/{CountRealMoves(PuzzleData.Count)}";
                StartAutoCountdown();
                PlaySoundFile("open.wav");
                HightlightLastMoveSquares(LastMovePlayedBeforeThePuzzleStarts);
                ToMoveLabel.ToMove = CurrentPuzzle_ToMove[0]; SetToMoveInButtons(ToMoveLabel.Text);
                icon_notSolved.Visible = false;
                icon_solved.Visible = false;
            }
            catch
            {
                MessageBox.Show("error parsing the puzzle");
            }
        }
        public int CountRealMoves()
        {
            return CurrentPuzzle_Solutions.Count % 2 == 0 ? CurrenltOpenedPuzzleChaptersCount / 2 : CurrentPuzzle_Solutions.Count / 2 + 1;
        }
        public static int CountRealMoves(int count)
        {
            return count % 2 == 0 ? count / 2 : count / 2 + 1;
        }
        public int SolvedPairs()
        {
            if (CurrentlySolvedPuzzleChapterStep == 1) { return 1; }
            else
            {
                double half = CurrentlySolvedPuzzleChapterStep / 2;
                int halfAsInt = (int)half;
                if (half - halfAsInt == 0)
                {
                    return CurrentlySolvedPuzzleChapterStep / 2;
                }
                else
                {
                    return (CurrentlySolvedPuzzleChapterStep - 1) / 2;
                }
            }
        }
        public void MoveAutomaticallyResponseMove()
        {
            CurrentlySolvedPuzzleChapterStep++;
            PuzzleResponse.Enabled = true;
        }
        public static void PlaySoundFile(string name)
        {
            string path_sounds = Application.StartupPath + "Sounds\\";
            string fullName = path_sounds + name;
            if (File.Exists(fullName) == true)
            {
                using var soundPlayer = new SoundPlayer(fullName);
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        public void UserClicksComposerSquare(object? sender, MouseEventArgs e)
        {
            if (sender == null){ return; }
            ChessButton TargetButton = (ChessButton)sender;
            if (e.Button.ToString() == "Left")
            {
                if (Composer_Mode_Select == true) // select to move
                {
                    if (TargetButton.BackgroundImage == EmptySquare) { return; } // if no piece is there
                    LastSelectedToMoveComposerSquare = TargetButton;
                    LastSelectedToMoveComposerSquare.IsSelected = true;
                    Composer_Mode_Select = false;
                    currentProposedSquareStart = LastSelectedToMoveComposerSquare.SquareName;
                    SetWaitingPaste(true, Board_Composer);
                    if (checkbox_smartAdd.Checked)
                    {
                        if (Key_Pressed_Ctrl)
                        {
                            c_letter1.Text = currentProposedSquareStart[0].ToString();
                            c_number1.Text = currentProposedSquareStart[1].ToString();
                        }
                    }
                }
                else
                { // proceed to move
                    if (TargetButton == LastSelectedToMoveComposerSquare)  // if they are the same square return
                    {
                        LastSelectedToMoveComposerSquare.IsSelected = false;
                        Composer_Mode_Select = true;
                        SetWaitingPaste(false, Board_Composer);
                        return;
                    }
                    //----------------------------------------------------
                    currentProposedSquareEnd = TargetButton.SquareName;
                    if (checkbox_smartAdd.Checked)
                    {
                        if (Key_Pressed_Ctrl)
                        {
                            c_letter2.Text = currentProposedSquareEnd[0].ToString();
                            c_number2.Text = currentProposedSquareEnd[1].ToString();
                        }
                        if (Key_Pressed_Alt)
                        {
                            AddArrangedChapter();
                        }
                    }
                    SetWaitingPaste(false, Board_Composer);
                    Image? ImageToSwap = LastSelectedToMoveComposerSquare.BackgroundImage ?? EmptySquare;
                    LastSelectedToMoveComposerSquare.BackgroundImage = EmptySquare;
                    string previousButtonName = LastSelectedToMoveComposerSquare.PieceName;
                    //----------------------------------------------------
                    LastSelectedToMoveComposerSquare.PieceName = "-";
                    LastSelectedToMoveComposerSquare.IsSelected = false;
                    TargetButton.BackgroundImage = ImageToSwap;
                    TargetButton.PieceName = previousButtonName;
                    LastSelectedToMoveComposerSquare = new();
                    Composer_Mode_Select = true;
                    TargetButton.IsHovered = true;
                }
            }
        }
        public void RefreshPuzzleList()
        {
            string?  lastSelectedPuzzleName = listofPuzzles.SelectedItems.Count == 1 ? listofPuzzles.SelectedItems[0].ToString() : string.Empty;
            int currentlySelectedIndex = listofPuzzles.SelectedIndex;
            listofPuzzles.Items.Clear();
            // refres hthe list of local puzzles;
            if (Directory.Exists(path_puzzles))
            {
                List<string> filenames = Directory.GetFiles(path_puzzles, "*.txt").ToList();
                if (filenames.Count > 0)
                {
                    panel_dummy_EL.Visible = false;
                    foreach (string filename in Directory.GetFiles(path_puzzles))
                    {
                        string ext = Path.GetExtension(filename);
                        if (ext == ".txt")
                        {
                            listofPuzzles.Items.Add(Path.GetFileNameWithoutExtension(filename));
                        }
                    }
                }
                else
                {
                    panel_dummy_EL.Visible = true;
                }
                if (listofPuzzles.Items.Contains(lastSelectedPuzzleName??"/898")) { listofPuzzles.SetSelected(currentlySelectedIndex, true); }
                if (listofPuzzles.Items.Count > 0) { PlaySoundFile("open_files.wav"); }
            }
            else
            {
                MessageBox.Show("The directory \"" + path_puzzles + " was not found");
                panel_dummy_EL.Visible = true;
            }
        }
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshPuzzleList();
        }
        public void Hint()
        {
            if (CurrentPuzzle_Hints.Count > 0)
            {
                if (CurrentPuzzleIsSolved == false)
                {
                    string hint = CurrentPuzzle_Hints[CurrentlySolvedPuzzleChapterStep];
                    label_hint.Text = hint;
                    label_hint.Visible = true;
                    if (AllPuzzles_of_PuzzleRush.Count > 0) ChangeColorForTargetPuzzleRush_InList(CurrentlySolvedPuzzleNumber, Color.Red);
                }
            }
        }
        private void Button_hint_Click(object sender, EventArgs e) { Hint(); }
        public static void MakeLabelsEmpty(params Label[] labels) { foreach (Label label in labels) label.Text = string.Empty; }
        public void RestartCurrentPuzzle()
        {
            if (File.Exists(CurrentlyOpenedPuzzleFilename))
            {
                MakeLabelsEmpty(label_show_solution, label_hint, label_move_right, label_move_wrong);
                CurrentPuzzles_Lengths.Clear();
                CurrentlySolvedPuzzleNumber = 0;
                HideSelectedControls(button_reset_puzzle, icon_solved, icon_notSolved);
                CurrentPuzzleIsSolved = false;
                CurrenltOpenedPuzzleChaptersCount = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).Length;
                CurrenlyOpenedPuzzle_ChaptersSolved = 0;
                CurrentlySolvedPuzzleChapterStep = 0;
                ClearLists(CurrentPuzzle_Hints, CurrentPuzzle_Positions, CurrentPuzzle_Solutions, CurrentPuzzle_ToMove);
                //------------------------------------------------------------------------
                int countPuzzles = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).Count(f => f.Contains('<'));
                //-----------------------
                // if it's a puzzle rush
                //-----------------------
                if (countPuzzles > 1)
                {
                    List<string> fileLines = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).ToList();
                    LoadPuzzleRush(fileLines);
                    if (AllPuzzles_of_PuzzleRush.Count <= 1) { MessageBox.Show("The selected puzzle rush file contains less than 2 puzzles."); return; }
                    // after adding all puzzles to the puzzle collection, load the first */
                    LoadTargetPuzzle(AllPuzzles_of_PuzzleRush[0]);
                    // feed the puzzles to the listview
                    GenerateRightWrongLabelsForPRDisplay(AllPuzzles_of_PuzzleRush.Count);
                    LightCurrentlySolvedPRPuzzle(0);
                    CurrentlySolvingAPuzzleRush = true;
                }
                //-----------------------
                // if it's a NOT puzzle rush
                //-----------------------
                if (countPuzzles <= 1)
                {
                    ClearPRDisplay(true);
                    List<string> PuzzleFileName = File.ReadLines(CurrentlyOpenedPuzzleFilename).ToList();
                    LoadTargetPuzzle(PuzzleFileName);
                    PuzzlesDisplay.Visible = false;
                }
                APuzzleIsLoaded = true;
                CurrentPuzzleIsSolved = false;
                UserToMove = true;
                EnableChessBoard();
            }
            else
            {
                MessageBox.Show("The selected puzzle no longer exists.");
                RefreshPuzzleList();
            }
            RestartTimer();
        }
        private void Button_reset_puzzle_click(object sender, EventArgs e) { RestartCurrentPuzzle(); }
        public void TransitionToPositionFromGivenActionSquareXSquare(string action_SquareXSquare, Panel WhichPanel)
        {
            string from = action_SquareXSquare.Split("x")[0];
            string to = action_SquareXSquare.Split("x")[1];
            Image? transferedImage = null;
            string transferedPieceName = "";
            List<List<ChessButton>> tempList = WhichPanel == panel_solver ? Board_Solver : Board_Composer;
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (tempList[x][i].SquareName == from)
                    {
                        transferedImage = tempList[x][i].BackgroundImage;
                        tempList[x][i].BackgroundImage = EmptySquare;
                        transferedPieceName = tempList[x][i].PieceName;
                        tempList[x][i].PieceName = "-";
                        break;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (tempList[x][i].SquareName == to)
                    {
                        if (tempList[x][i].PieceName == "-")
                        {
                            if (label_chapterCounter.Text != "Solved!")
                            {
                                PlaySoundFile("MOVE.wav");
                            }
                        }
                        else
                        {
                            if (label_chapterCounter.Text != "Solved!")
                            {
                                PlaySoundFile("CAPTURE.wav");
                            }
                        }
                        tempList[x][i].BackgroundImage = transferedImage;
                        tempList[x][i].PieceName = transferedPieceName;
                        break;
                    }
                }
            }
        }
        private void TransitionButton_Click(object sender, EventArgs e)
        {
            TransitionToPositionFromGivenActionSquareXSquare(c_letter1.Text + c_number1.Text + "x" + c_letter2.Text + c_number2.Text, panel_composer);
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listofPuzzles.SelectedItems.Count == 1)
            {
                string filename = (string)listofPuzzles.SelectedItems[0];
                filename += ".txt";
                string pathh = $"{path_puzzles}\\{filename}";
                if (File.Exists(pathh))
                {
                    File.Delete(pathh);
                }
                RefreshPuzzleList();
            }
            else { MessageBox.Show("Nothing is selected."); }
        }
        private void ThisIsAttackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string startSquare = Currently_Hovered_Button.SquareName;
            if (Currently_Hovered_Button.BackgroundImage == null) { MessageBox.Show("No piece is on that square."); return; }
            c_letter1.Text = startSquare[0].ToString();
            c_number1.Text = startSquare[1].ToString();
            LastMoveWasDoneByClicks = false;
        }
        private void ThisIsAttackedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string startSquare = Currently_Hovered_Button.SquareName;
            c_letter2.Text = startSquare[0].ToString();
            c_number2.Text = startSquare[1].ToString();
            LastMoveWasDoneByClicks = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Menu") { Key_Pressed_Alt = true; }
            if (e.KeyCode.ToString() == "ShiftKey") { Key_Pressed_Shift = true; }
            if (e.KeyCode.ToString() == "ControlKey") { Key_Pressed_Ctrl = true; }
            if (checkBox_hotkeys.Checked == false) { return; }
            if (ActiveControl is TextBox == true) { return; }
            if (e.KeyCode == Keys.T) TransitionToPositionFromGivenActionSquareXSquare(c_letter1.Text + c_number1.Text + "x" + c_letter2.Text + c_number2.Text, panel_composer);
            if (e.KeyCode == Keys.R) { RemoveLastChapter(); }
            if (e.KeyCode == Keys.G) GeneratePuzzle();
            if (e.KeyCode == Keys.A) AddArrangedChapter();
            if (e.KeyCode == Keys.S) SolveSelectedPuzzle();
            if (e.KeyCode == Keys.H) Hint();
            if (e.KeyCode == Keys.Z) GeneratePuzzleRush();
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Up) MessageBox.Show("My message");
            if (e.KeyCode == Keys.D1)
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["pawn_white"];
                        Currently_Hovered_Button.PieceName = "P";
                    }
                }
                if (e.Modifiers == Keys.Alt)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["pawn_black"];
                        Currently_Hovered_Button.PieceName = "p";
                    }
                }
                if (e.Modifiers == Keys.None)
                {
                    fix_one = c_letter2.Text;
                    fix_two = c_number2.Text;
                    string startSquare = Currently_Hovered_Button.SquareName;
                    c_letter1.Text = startSquare[0].ToString();
                    c_number1.Text = startSquare[1].ToString();
                    Fixer_q.Start();
                    return;
                }
            }
            if (e.KeyCode == Keys.D2)
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["rook_white"];
                        Currently_Hovered_Button.PieceName = "R";
                    }
                }
                if (e.Modifiers == Keys.Alt)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["rook_black"];
                        Currently_Hovered_Button.PieceName = "r";
                    }
                }
                if (e.Modifiers == Keys.None)
                {
                    string startSquare = Currently_Hovered_Button.SquareName;
                    c_letter2.Text = startSquare[0].ToString();
                    c_number2.Text = startSquare[1].ToString();
                    return;
                }
            }
            if (e.KeyCode == Keys.D3)
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["queen_white"];
                        Currently_Hovered_Button.PieceName = "Q";
                    }
                }
                if (e.Modifiers == Keys.Alt)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["queen_black"];
                        Currently_Hovered_Button.PieceName = "q";
                    }
                }
            }
            if (e.KeyCode == Keys.D4)
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["king_white"];
                        Currently_Hovered_Button.PieceName = "K";
                    }
                }
                if (e.Modifiers == Keys.Alt)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["king_black"];
                        Currently_Hovered_Button.PieceName = "P";
                    }
                }
            }
            if (e.KeyCode == Keys.D5)
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["bishop_white"];
                        Currently_Hovered_Button.PieceName = "B";
                    }
                }
                if (e.Modifiers == Keys.Alt)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["bishop_black"];
                        Currently_Hovered_Button.PieceName = "b";
                    }
                }
            }
            if (e.KeyCode == Keys.D6)
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["knight_white"];
                        Currently_Hovered_Button.PieceName = "N";
                    }
                }
                if (e.Modifiers == Keys.Alt)
                {
                    if (panel_composer.Controls.Contains(Currently_Hovered_Button))
                    {
                        Currently_Hovered_Button.BackgroundImage = pieces_pics["knight_black"];
                        Currently_Hovered_Button.PieceName = "n";
                    }
                }
            }
        }
        public void Quickfix(object? sender, EventArgs e)
        {
            c_letter2.Text = fix_one;
            c_number2.Text = fix_two;
            Fixer_q.Stop();
        }
        public void ShowSolution()
        {
            label_show_solution.Visible = true;
            if (CurrentlySolvedPuzzleChapterStep >= CurrentPuzzle_Solutions.Count) { return; }
            if (CurrentPuzzle_Solutions.Count == 0) { MessageBox.Show("Empty solution list"); return; }
            label_show_solution.Text = CurrentPuzzle_Solutions[CurrentlySolvedPuzzleChapterStep];
            if (AllPuzzles_of_PuzzleRush.Count > 0) { ChangeColorForTargetPuzzleRush_InList(CurrentlySolvedPuzzleNumber, Color.Red); }
        }
        private void Showsolution_Click(object sender, EventArgs e) { ShowSolution(); }
        public bool CheckForKings()
        {
            int whiteKings = 0;
            int blackKings = 0;
            int otherPiece = 0;
            foreach (Control c in panel_composer.Controls)
            {
                ChessButton b = (ChessButton)c;
                if (b.PieceName == "K") { whiteKings++; }
                if (b.PieceName == "k") { blackKings++; }
                if (b.PieceName != "K" && b.PieceName != "k" && b.PieceName != "-") { otherPiece++; }
            }
            return whiteKings + blackKings + otherPiece >= 3;
        }
        private void ImportFEN_Click(object sender, EventArgs e)
        {
            if (textBox_FEN.Text.Trim() != string.Empty)
            {
                string result = ConvertFENToSCN(textBox_FEN.Text);
                RecreatePuzzleFromSCN(result, panel_composer);
            }
            else
            { MessageBox.Show("Empty string for FEN notation was provided."); }
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show($"This will open a webpage in your default browser. Prcoceed?",
                      $"Ecisting puzzle", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Process.Start(new ProcessStartInfo { FileName = @"https://www.chess.com/terms/fen-chess", UseShellExecute = true }); break;
                case DialogResult.No:
                    break;
            }
        }
        public void LoadRequiredPieceImages()
        {
            CharactersAsPieceImages.Clear();
            pieces_pics.Clear();
            CharactersAsPieceImages = new Dictionary<char, Image>();
            Image WhiteKing = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "king_white.png");
            CharactersAsPieceImages.Add('K', WhiteKing);
            pieces_pics.Add("king_white", WhiteKing);
            Image WhiteQueen = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "queen_white.png");
            CharactersAsPieceImages.Add('Q', WhiteQueen);
            pieces_pics.Add("queen_white", WhiteQueen);
            Image WhiteBishop = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "bishop_white.png");
            CharactersAsPieceImages.Add('B', WhiteBishop);
            pieces_pics.Add("bishop_white", WhiteBishop);
            Image WhiteRook = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "rook_white.png");
            CharactersAsPieceImages.Add('R', WhiteRook);
            pieces_pics.Add("rook_white", WhiteRook);
            Image WhiteKnight = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "knight_white.png");
            CharactersAsPieceImages.Add('N', WhiteKnight);
            pieces_pics.Add("knight_white", WhiteKnight);
            Image WhitePawn = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "pawn_white.png");
            CharactersAsPieceImages.Add('P', WhitePawn);
            pieces_pics.Add("pawn_white", WhitePawn);
            Image BlackKing = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "king_black.png");
            CharactersAsPieceImages.Add('k', BlackKing);
            pieces_pics.Add("king_black", BlackKing);
            Image BlackQueen = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "queen_black.png");
            CharactersAsPieceImages.Add('q', BlackQueen);
            pieces_pics.Add("queen_black", BlackQueen);
            Image BlackBishop = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "bishop_black.png");
            CharactersAsPieceImages.Add('b', BlackBishop);
            pieces_pics.Add("bishop_black", BlackBishop);
            Image BlackRook = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "rook_black.png");
            CharactersAsPieceImages.Add('r', BlackRook);
            pieces_pics.Add("rook_black", BlackRook);
            Image BlackKnight = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "knight_black.png");
            CharactersAsPieceImages.Add('n', BlackKnight);
            pieces_pics.Add("knight_black", BlackKnight);
            Image BlackPawn = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + "pawn_black.png");
            CharactersAsPieceImages.Add('p', BlackPawn);
            pieces_pics.Add("pawn_black", BlackPawn);
            CharactersAsPieceImages.Add('-', EmptySquare);
        }
        public void CheckAndLoadAllPieceImages()
        {
            //----------------------------------------------------------
            //HERE FIND ALL FOLDERS FOR PIECE SETS AND INCLUDE THEM IN THE COMBOBOX FOR SETTINGS
            //----------------------------------------------------------
            comboBox_Psets.Items.Clear();
            string[] ImageFileNames = { "bishop_black.png", "bishop_white.png", "king_black.png", "king_white.png", "knight_black.png", "knight_white.png", "pawn_black.png", "pawn_white.png", "queen_black.png", "queen_white.png", "rook_black.png", "rook_white.png" };
            if (Directory.Exists(path_pieces))
            {
                // get all folders inside the folder
                int missedFolders = 0;
                List<string> directories = Directory.GetDirectories(path_pieces).ToList();
                if (directories.Count == 0) { MessageBox.Show("Sorry, couldn't find any piece images, to operate the app. Fix the issue and start the app again."); Environment.Exit(0); }
                foreach (string directory in directories)
                {
                    bool hasAll = true;
                    foreach (string fileName in ImageFileNames)
                    {
                        if (File.Exists(directory + "\\" + fileName) == false) { hasAll = false; missedFolders++; break; }
                    }
                    if (hasAll)
                    {
                        string[] split = directory.Split("\\").ToArray();
                        string pathName = split[^1];
                        comboBox_Psets.Items.Add(pathName);
                    }
                    if (missedFolders > 0) { MessageBox.Show($"{missedFolders} folder/s were not added as available piece set/s, because they have 1 or more missing images or images with wrong filenames."); }
                }
                //----------------------------------------------------------
            }
            else
            {
                MessageBox.Show(path_pieces + "is a required folder that does not exist"); Environment.Exit(0);
            }
        }
        private void ImportSCN_Cllick(object sender, EventArgs e)
        {
            string code = textBox_SCN.Text;
            if (code.Length != 64) { MessageBox.Show("The length must be exactly 64"); return; }
            bool allCharactersInStringAreDigits = code.Any(char.IsDigit);
            if (allCharactersInStringAreDigits) { MessageBox.Show("Invalid SCN"); return; }
            RecreatePuzzleFromSCN(code, panel_composer);
        }
        private void DisplaySCNCopyDialog(object sender, EventArgs e)
        {
            string SCN = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    SCN += tabControl1.SelectedIndex == 0 ? Board_Solver[i][x].PieceName : Board_Composer[i][x].PieceName;
                }
            }
            var v = new CopyDialog();
            v.textBox1.Text = SCN;
            v.ShowDialog();
            v.Dispose();
        }
        public static string SCNToFEN(List<List<ChessButton>> whichBoard)
        {
            int countEmpty = 0;
            List<string> ranks = new();
            for (int i = 0; i < 8; i++) { ranks.Add(""); }
            //-----------------------------------------------
            //-----------------------------------------------
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    if (whichBoard[rank][file].PieceName == "-") // if it's empty square
                    {
                        countEmpty++;
                        if (countEmpty == 8)
                        {
                            ranks[rank] += countEmpty.ToString();
                            break;
                        } // empty squares are 8 finish the file
                    }
                    else // if NOT empty square
                    {
                        if (countEmpty != 0)
                        {
                            ranks[rank] += countEmpty.ToString();
                        }
                        ranks[rank] += whichBoard[rank][file].PieceName;
                        countEmpty = 0;
                    }
                    if (file == 7)
                    {
                        if (countEmpty != 0)
                        {
                            ranks[rank] += countEmpty.ToString();
                        }
                    }
                }
                countEmpty = 0;
            }
            return string.Join("/", ranks); ;
        }
        private void ExportAsFEN_Click(object sender, EventArgs e)
        {
            string FEN;
            if (tabControl1.SelectedIndex == 0) //if exporting puzzle
            {
                FEN = SCNToFEN(Board_Solver);
            }
            else // if exporting composition
            {
                FEN = SCNToFEN(Board_Composer);
            }
            var v = new CopyDialog();
            v.textBox1.Text = FEN;
            v.ShowDialog();
            v.Dispose();
        }
        private void ChangeColorOfWhiteSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].DefaultColors_White = takenColor;
                        if (Board_Composer[i][x].IsWhiteSquare) { Board_Composer[i][x].DefaultBackColor = Board_Composer[i][x].DefaultColors_White; Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].DefaultColors_White = takenColor;
                        if (Board_Solver[i][x].IsWhiteSquare) { Board_Solver[i][x].DefaultBackColor = Board_Solver[i][x].DefaultColors_White; Board_Solver[i][x].BackColor = takenColor; }
                    }
                }
                button_setwhiteSqColor.BackColor = takenColor;
                settings.Color_White_Current = takenColor;
                WriteSettingsFile();
            }
        }
        private void ChangeColorOfBlackSquaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].DefaultColors_Black = takenColor;
                        if (!Board_Composer[i][x].IsWhiteSquare) { Board_Composer[i][x].DefaultBackColor = Board_Composer[i][x].DefaultColors_Black; Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].DefaultColors_Black = takenColor;
                        if (!Board_Solver[i][x].IsWhiteSquare) { Board_Solver[i][x].DefaultBackColor = Board_Solver[i][x].DefaultColors_Black; Board_Solver[i][x].BackColor = takenColor; }
                    }
                }
                button_blackSqSetColor.BackColor = takenColor;
                settings.Color_Black_Current = takenColor;
                WriteSettingsFile();
            }
        }
        public static string MultiplyString(string input, int times)
        {
            string output = string.Empty;
            for (int i = 0; i < times; i++) { output += input; }
            return output;
        }
        public static string ConvertFENToSCN(string FEN)
        {
            string result;
            result = FEN.Replace("/", "");
            result = result.Split(" ")[0];
            for (int i = 1; i <= 8; i++) { result = result.Replace(i.ToString(), MultiplyString("-", i)); }
            return result;
        }
        public static string ConvertRankBasedSFFCPNTo_FileBased(string input)
        {
            List<char> SCN = input.ToCharArray().ToList();
            List<string> Files = new();
            List<string> Ranks = new();
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    string next = string.Empty;
                    for (int x = 0; x < 8; x++) //  extract the files
                    {
                        next += SCN[0];
                        SCN.RemoveAt(0);
                    }
                    Files.Add(next);
                }
                for (int i = 0; i < Files.Count; i++)
                {
                    // take one element from each file and add it to rank that will be added to the list of ranks
                    string rank = string.Empty;
                    for (int x = 0; x < 8; x++)
                    {
                        rank += Files[x][i];
                    }
                    Ranks.Add(rank);
                }
            }
            catch { MessageBox.Show("Error with parsing"); }
            return string.Join("", Ranks);
        }
        public static string ConvertRankBasedSFFCPNToFEN(string input)
        {
            string result = string.Empty;
            int EmptyLineCounting = 0;
            int FileCounter = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-')
                {
                    EmptyLineCounting++;
                }
                else
                {
                    if (EmptyLineCounting != 0) { result += EmptyLineCounting.ToString(); EmptyLineCounting = 0; }
                    result += input[i];
                }
                FileCounter++;
                if (FileCounter == 8) { result += "/"; FileCounter = 0; }
            }
            //  result += " w KQkq - 0 1";
            return result;
        }
        public void RegisterWriteBoxesForHoverEvent()
        {
            foreach (Control c in panel_ComposePuzzleContainer.Controls)
            {
                if (c is TextBox)
                {
                    c.MouseEnter += HoverOnTextField;
                }
            }
        }
        public void HoverOnTextField(object? sender, EventArgs e)
        {
            if (sender == null) { return; }
            FocusedTextBox = (TextBox)sender;
        }
        private void PauseToolStripMenuItem_Click(object sender, EventArgs e) { if (Time_Puzzle_SecondsLeft > 0) Timer_Puzzle.Stop(); }
        private void ResumeToolStripMenuItem_Click(object sender, EventArgs e) { if (Time_Puzzle_SecondsLeft > 0) Timer_Puzzle.Start(); }
        private void Link_Diffenrence_click(object sender, LinkLabelLinkClickedEventArgs e) { MessageBox.Show("Puzzle Rush is a collection of puzzles, solved cosequently. If \"I am making a puzzle rush\" is checked, when you click on \"Create Puzzle\" it wil add that puzzle into the collection of puzzles, instead of generating a puzzle file. To finish the puzzle rush click \"Generate Puzzle Rush\"."); }
        private void RemoveLastChapterToolStripMenuItem_Click(object sender, EventArgs e) { RemoveLastChapter(); }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e) { ClearChaptersOfCurrentlyComposedPuzzle(); }
        public void PutAllTextboxesForMEnterEvent()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox) c.MouseEnter += SetTextBoxAsFocusedForTheMenu;
            }
        }
        public void SetTextBoxAsFocusedForTheMenu(object? sender, EventArgs e) { if (sender is TextBox box) FocusedTextBox = box; }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) { if (FocusedTextBox.Text.Trim() != string.Empty) Clipboard.SetText(FocusedTextBox.SelectedText); }
        private void CopyAllToolStripMenuItem_Click(object sender, EventArgs e) { if (FocusedTextBox.Text.Trim() != string.Empty) Clipboard.SetText(FocusedTextBox.Text); }
        private void ClearAndPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FocusedTextBox.Clear();
            string pst = Clipboard.GetText();
            if (pst.Length <= FocusedTextBox.MaxLength) FocusedTextBox.Text = Clipboard.GetText();
        }
        private void ClearToolStripMenuItem1_Click(object sender, EventArgs e) { FocusedTextBox.Clear(); }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pst = Clipboard.GetText();
            int ttll = pst.Length + FocusedTextBox.Text.Length;
            if (ttll <= FocusedTextBox.MaxLength)
            {
                FocusedTextBox.Text = FocusedTextBox.Text.Insert(FocusedTextBox.SelectionStart, pst);
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            panel_setttings.Visible = true;
            // ContextMenuStrip m = context_options;
            //  m.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_Countdown_Puzzle.Text = string.Empty;
            Time_Puzzle_SecondsLeft = 0;
            Timer_Puzzle.Stop();

        }
        public void RestartTimer()
        {
            Time_Puzzle_SecondsLeft = settings.AutoCountdown;
            if (Time_Puzzle_SecondsLeft > 0)
            {
                Timer_Puzzle.Stop();
                Timer_Puzzle.Start();
            }
        }
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e) { RestartTimer(); }
        private void CheckBox_hotkeys_CheckedChanged(object sender, EventArgs e) { WriteSettingsFile(); }
        public void StartAutoCountdown()
        {
            if (settings.AutoCountdown > 0)
            {
                Time_Puzzle_SecondsLeft = settings.AutoCountdown;
                Timer_Puzzle.Start();
            }
            else { label_Countdown_Puzzle.Text = string.Empty; }
        }
        private void ResetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Color_White_Current = settings.Default_WhiteSquareColor;
            settings.Color_Black_Current = settings.Default_BlackSquareColor;
            settings.Color_Selected_Current = settings.Default_SelectSquareColor;
            settings.Color_LastMove_Current = settings.Default_SquareLastMoveColor;
            settings.Color_Hover_Current = settings.Default_SquareHoverColor;
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    Board_Solver[rank][file].Color_Hover = settings.Default_SquareHoverColor;
                    Board_Solver[rank][file].Color_Select = settings.Default_BlackSquareColor;
                    Board_Solver[rank][file].Color_BelongsToLastMove = settings.Default_SquareLastMoveColor;
                    Board_Solver[rank][file].DefaultColors_White = settings.Default_WhiteSquareColor;
                    Board_Solver[rank][file].DefaultColors_Black = settings.Default_WhiteSquareColor;
                    Board_Solver[rank][file].DefaultBackColor = Board_Solver[rank][file].IsWhiteSquare ? settings.Default_WhiteSquareColor : settings.Default_BlackSquareColor;
                    Board_Solver[rank][file].SetDefaultBackColor();
                    Board_Composer[rank][file].Color_Hover = settings.Default_SquareHoverColor;
                    Board_Composer[rank][file].Color_Select = settings.Default_BlackSquareColor;
                    Board_Composer[rank][file].Color_BelongsToLastMove = settings.Default_SquareLastMoveColor;
                    Board_Composer[rank][file].DefaultColors_White = settings.Default_WhiteSquareColor;
                    Board_Composer[rank][file].DefaultColors_Black = settings.Default_WhiteSquareColor;
                    Board_Composer[rank][file].DefaultBackColor = Board_Composer[rank][file].IsWhiteSquare ? settings.Default_WhiteSquareColor : settings.Default_BlackSquareColor;
                    Board_Composer[rank][file].SetDefaultBackColor();
                }
            }
            
            WriteSettingsFile();
        }
        private void Textbox_Warning_MouseEnter(object sender, EventArgs e) { FocusedTextBox = textBox_name; }
        private void TextBox1_MouseEnter(object sender, EventArgs e) { FocusedTextBox = textBox_name; }
        public static string StringJoinBothSides(string one, string two, string[] target)
        {
            string result = string.Empty;
            foreach (string s in target) { result += $"{one}{s}{two}"; }
            return result;
        }
        public void GeneratePuzzleRush()
        {
            //------------------------------------------------------------------
            string name = textBox_name.Text;
            //----error checking---------------------------------------------------------------------------------------------------------------------
            if (name.Trim() == string.Empty) { MessageBox.Show("A name must be specified."); return; }
            if (PuzzleNameContainsInvalidCharacters(name)) { MessageBox.Show($"The given puzzle name contains characters not supported by windows filenames.\nDo not use {string.Join(" ", InvalidWindowsFilenameCharactes)}"); return; }
            if (PuzzleRushPuzzles_Composed.Count <= 1) { MessageBox.Show("A puzzle collection must consist of at least 2 puzzles."); return; }
            //---------------------------------------------------------------------------------------------------------------------------------------
            List<string> PuzzleRush = new();
            for (int i = 0; i < PuzzleRushPuzzles_Composed.Count; i++)
            {
                PuzzleRush.Add($"<{DescriptionsForPR_Puzzles[i]}>");
                for (int x = 0; x < PuzzleRushPuzzles_Composed[i].Count; x++)
                {
                    PuzzleRush.Add($"{StringJoinBothSides("[", "]", PuzzleRushPuzzles_Composed[i][x])}");
                }
            }
            //---------------------------------------------
            string savePath = $"{path_puzzles}\\[PR]{name}.txt";
            File.WriteAllLines(savePath, PuzzleRush);
            MessageBox.Show($"Generated the puzzle rush, with {PuzzleRushPuzzles_Composed.Count} puzzles, as:\n {savePath}.");
            PuzzleRushPuzzles_Composed.Clear();
            listbox_Puzzles_Rush.Items.Clear();
            DescriptionsForPR_Puzzles.Clear();
            listbox_Puzzle_Fragments.Items.Clear();
            ClearChaptersOfCurrentlyComposedPuzzle();
        }
        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            listbox_Puzzles_Rush.Items.Clear();
            PuzzleRushPuzzles_Composed.Clear();
        }
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (listbox_Puzzles_Rush.SelectedItems.Count == 0) { return; }
            int puzzleIndex = listbox_Puzzles_Rush.SelectedIndex;
            listbox_Puzzles_Rush.Items.RemoveAt(puzzleIndex);
        }
        private void Listbox_Puzzles_Rush_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_Puzzle_Fragments.Items.Clear();
            int selectedIndex = listbox_Puzzles_Rush.SelectedIndex;
            // todo
            // load the target puzzle as the currently edited and load his chapters in the chapter menu
            CurrentPuzzleComposition_List.Clear();
            CurrentPuzzleComposition_List = PuzzleRushPuzzles_Composed[selectedIndex];
            foreach (string[] data in CurrentPuzzleComposition_List)
            {
                listbox_Puzzle_Fragments.Items.Add(data[1]);
            }
        }
        private void ClearPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listbox_Puzzle_Fragments.Items.Clear();
        }
        private void ChangeHightlightedSquareColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Select = takenColor;
                        if (Board_Composer[i][x].IsSelected) { Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].Color_Select = takenColor;
                        if (Board_Solver[i][x].IsSelected) { Board_Composer[i][x].BackColor = takenColor; }
                    }
                }
                settings.Color_Selected_Current = takenColor;
                button_setSElectedSquare.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void ChangeLastMoveHightlightColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_BelongsToLastMove = takenColor;
                        if (Board_Composer[i][x].BelongsToLastMove) { Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].Color_BelongsToLastMove = takenColor;
                        if (Board_Solver[i][x].BelongsToLastMove) { Board_Composer[i][x].BackColor = takenColor; }
                    }
                }
                settings.Color_LastMove_Current = takenColor;
                button_setLastMoveColor.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void WhitePawnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["pawn_white"];
            Currently_Hovered_Button.PieceName = "P";
        }
        private void WhiteRookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["rook_white"];
            Currently_Hovered_Button.PieceName = "R";
        }
        private void WhiteQueenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["queen_white"];
            Currently_Hovered_Button.PieceName = "Q";
        }
        private void WhiteKingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["king_white"];
            Currently_Hovered_Button.PieceName = "K";
        }
        private void WhiteBishopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["bishop_white"];
            Currently_Hovered_Button.PieceName = "B";
        }
        private void WhiteKnightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["knight_white"];
            Currently_Hovered_Button.PieceName = "N";
        }
        private void BlackPawnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["pawn_black"];
            Currently_Hovered_Button.PieceName = "p";
        }
        private void BlackRookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["rook_black"];
            Currently_Hovered_Button.PieceName = "r";
        }
        private void BlackQueenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["queen_black"];
            Currently_Hovered_Button.PieceName = "q";
        }
        private void BlackKingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["king_black"];
            Currently_Hovered_Button.PieceName = "k";
        }
        private void BlackBishopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["bishop_black"];
            Currently_Hovered_Button.PieceName = "b";
        }
        private void BlBckKnightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Currently_Hovered_Button.BackgroundImage = pieces_pics["knight_black"];
            Currently_Hovered_Button.PieceName = "n";
        }
        private void ThisIsPrepuzzleStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string startSquare = Currently_Hovered_Button.SquareName;
            comboBox_letter1_om.Text = startSquare[0].ToString();
            comboBox_num1_om.Text = startSquare[1].ToString();
        }
        private void ThisIsPrePuzzleEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currently_Hovered_Button.BackgroundImage == null) { MessageBox.Show("No piece is on that square."); return; }
            string startSquare = Currently_Hovered_Button.SquareName;
            comboBox_letter2_om.Text = startSquare[0].ToString();
            comboBox_num2_om.Text = startSquare[1].ToString();
        }
        private void Button_generate_PR_Click(object sender, EventArgs e) { GeneratePuzzleRush(); }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Menu") { Key_Pressed_Alt = false; }
            if (e.KeyCode.ToString() == "ShiftKey") { Key_Pressed_Shift = false; }
            if (e.KeyCode.ToString() == "ControlKey") { Key_Pressed_Ctrl = false; }
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show($"{Text} by Stanislav Vladev, january 2023. With Visual Studio and C#. for issues: stan0033@abv.bg"); }
        private void HowToSolvePuzzlesToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show($"You can find the tutorials at {path_tutorials}"); }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip m = context_help;
            m.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listofPuzzles.SelectedItems.Count == 1) // if an item is selected
            {
                //------------------------------------------------------------------
                ClearTextBoxes(textBox_name, textBox_hint, textbox_Wrong, textBox_Right, textBox_event);
                listbox_Puzzles_Rush.Items.Clear();
                listbox_Puzzle_Fragments.Items.Clear();
                CurrentPuzzleComposition_List.Clear();
                string? name = listofPuzzles.SelectedItems[0].ToString();
                string nameFile = name + ".txt";
                CurrentlyOpenedPuzzleFilename = path_puzzles + "\\" + nameFile;
                //------------------------------------------------------------------
                if (File.Exists(CurrentlyOpenedPuzzleFilename))
                {
                    List<string> fileLines = File.ReadAllLines(CurrentlyOpenedPuzzleFilename).ToList();
                    int namesCount = File.ReadAllText(CurrentlyOpenedPuzzleFilename).Count(x => x == '>');
                    if (namesCount > 1) // if it's a puzzle rush
                    {
                        List<string[]> CurrentlyFilledPuzzle = new();
                        // puzzle>chapters
                        for (int i = 0; i < fileLines.Count; i++)
                        {
                            if (fileLines[i].Contains('<'))
                            {
                                PuzzleRushPuzzles_Composed.Add(CurrentlyFilledPuzzle); // if the tag is met, skip and go to adding the next puzzle
                                CurrentlyFilledPuzzle.Clear();
                                listbox_Puzzles_Rush.Items.Add(fileLines[i]);
                            }
                            else
                            {
                                // take the whole line and make it into a string[]
                                //add the string to CurrentlyFilledPuzzle
                                Regex pattern = new(@"(?<=\[)[^\[\]]+(?=\])", // Define a regular expression for content in brackets
                                RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                MatchCollection matches = pattern.Matches(fileLines[i]);
                                List<string> data = new();
                                data.AddRange(from Match m in matches
                                              select m.Value);
                                CurrentlyFilledPuzzle.Add(data.ToArray());
                            }
                        }
                    }
                    else// if it is not a puzzle rush
                    {
                        if (fileLines[0].Contains('<')) { fileLines.RemoveAt(0); }
                        // have to convert every line into string[] and add it to currenly composed puzzle list
                        foreach (string line in fileLines)
                        {
                            Regex pattern = new(@"(?<=\[)[^\[\]]+(?=\])", // Define a regular expression for content in brackets
                             RegexOptions.Compiled | RegexOptions.IgnoreCase);
                            MatchCollection matches = pattern.Matches(line);
                            List<string> data = new(); ;
                            data.AddRange(from Match m in matches
                                          select m.Value);
                            CurrentPuzzleComposition_List.Add(data.ToArray());
                        }
                        // then fill all chapters by solution in the list of chapters
                        foreach (string[] data in CurrentPuzzleComposition_List)
                        {
                            string solution = data[1];
                            listbox_Puzzle_Fragments.Items.Add(solution);
                        }
                        // then load the LAST chapter with its fields and SELECT IT
                        string[] lastChapter = CurrentPuzzleComposition_List[^1];
                        RecreatePuzzleFromSCN(lastChapter[0], panel_composer);
                        FillSolutionFromRawString(lastChapter[1]);
                        textBox_hint.Text = lastChapter[2];
                        textbox_Wrong.Text = lastChapter[3];
                        textBox_Right.Text = lastChapter[4];
                        textBox_event.Text = lastChapter[6];
                        if (CurrentPuzzleComposition_List[0][7].Length == 5) FillFirstMoveromRawString(CurrentPuzzleComposition_List[0][7]);
                        listbox_Puzzle_Fragments.SelectedIndex = listbox_Puzzle_Fragments.Items.Count - 1;
                    }
                    tabControl1.SelectedIndex = 1; // swutch to tab
                    textBox_name.Text = name; // enter the name
                                              //-------------------------------------------------------------------------------
                                              //whehn switching to tab hide what has to be hidden
                                              //-------------------------------------------------------------------------------
                    HideSelectedControls(button_gotoNextPuzzle, panel_cd_event_toMove, ToMoveLabel, label_move_wrong, label_move_right, label_hint, button_reset_puzzle, button_show_solution, label_show_solution, label_event, panel_solver, button_hint, icon_notSolved, icon_solved, label_chapterCounter);
                    ShowSelectedControls(panel_composer, button_clear_Board, label_square_displayer, label_Action_Response, button_GenerateStartingChessPosition);
                    Point BoardPoint = new(panel_solver.Location.X, panel_solver.Location.Y);
                    panel_composer.Location = BoardPoint;
                }
                else
                {
                    MessageBox.Show("The selected puzzle no longer exists.");
                }
            }
            else { MessageBox.Show("Nothing is selected."); }
        }
        public void FillSolutionFromRawString(string raw)
        {
            c_letter1.Text = raw[0].ToString();
            c_number1.Text = raw[1].ToString();
            c_letter2.Text = raw[3].ToString();
            c_number2.Text = raw[4].ToString();
        }
        public void FillFirstMoveromRawString(string raw)
        {
            comboBox_letter1_om.Text = raw[0].ToString();
            comboBox_num1_om.Text = raw[1].ToString();
            comboBox_letter2_om.Text = raw[3].ToString();
            comboBox_num2_om.Text = raw[4].ToString();
        }
        private void LoadChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listbox_Puzzle_Fragments.SelectedIndex;
            if (listbox_Puzzle_Fragments.Items.Count == 0) { return; }
            string[] chapterData = CurrentPuzzleComposition_List[index];
            // { position, solution, hint, wrong, right, toMove, event_, lastM };
            RecreatePuzzleFromSCN(chapterData[0], panel_composer);
            FillSolutionFromRawString(chapterData[1]);
            textBox_hint.Text = chapterData[2];
            textbox_Wrong.Text = chapterData[3];
            textBox_Right.Text = chapterData[4];
            textBox_event.Text = chapterData[6];
            if (chapterData[7].Length == 5) FillFirstMoveromRawString(chapterData[7]);
        }
        private void ChangeChhapterWithCurrenctComposition_click(object sender, EventArgs e)
        {
            int index = listbox_Puzzle_Fragments.SelectedIndex;
            if (listbox_Puzzle_Fragments.Items.Count == 0) { return; }
            List<string> ChapterData = new();
            string Start_Square = $"{c_letter1.Text}{c_number1.Text}";
            char Start_Square_Piece_Name = 'k';
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    if (Board_Composer[rank][file].SquareName == Start_Square)
                    {
                        Start_Square_Piece_Name = Board_Composer[rank][file].SquareName[0];
                    }
                }
            }
            string solution = $"{c_letter1.Text}{c_number1.Text}x{c_letter2.Text}{c_number2.Text}";
            string LastMoveBeforePuzzleStarts = $"{comboBox_letter1_om.Text}{comboBox_num1_om.Text}x{comboBox_letter2_om.Text}{comboBox_num2_om.Text}"; ;
            string position = GeneratePositionAsString(Board_Composer);
            string hint = textBox_hint.Text.Trim() == string.Empty ? "No hints" : textBox_hint.Text;
            string wrong = textbox_Wrong.Text.Trim() == string.Empty ? " " : textbox_Wrong.Text;
            string right = textBox_Right.Text.Trim() == string.Empty ? " " : textBox_Right.Text;
            string toMove = char.IsUpper(Start_Square_Piece_Name) ? "White to move" : "Black to move";
            string event_ = label_event.Text == string.Empty ? " " : label_event.Text;
            ChapterData.Add(position);
            ChapterData.Add(solution);
            ChapterData.Add(hint);
            ChapterData.Add(wrong);
            ChapterData.Add(right);
            ChapterData.Add(toMove);
            ChapterData.Add(event_);
            if (checkBox_LastPlayedOptional.Checked)
            {
                ChapterData.Add(LastMoveBeforePuzzleStarts);
            }
            CurrentPuzzleComposition_List[index] = ChapterData.ToArray();
        }
        private void CheckBox_autoPR_CheckedChanged(object sender, EventArgs e) { WriteSettingsFile(); }
        private void Button_gotoNextPuzzle_Click(object sender, EventArgs e)
        {
            UserToMove = true;
            button_gotoNextPuzzle.Visible = false;
            LightCurrentlySolvedPRPuzzle(CurrentlySolvedPuzzleNumber);
            LoadTargetPuzzle(AllPuzzles_of_PuzzleRush[CurrentlySolvedPuzzleNumber]);
            PR_Paused = true;
            icon_notSolved.Visible = false;
            icon_solved.Visible = false;
        }
        private void TextBox_description_MouseEnter(object sender, EventArgs e) { FocusedTextBox = textBox_description; }
        private void TextBox_event_MouseEnter(object sender, EventArgs e) { FocusedTextBox = textBox_event; }
        private void ListofPuzzles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string? selectedName = listofPuzzles.SelectedItems[0].ToString();
                string path = path_puzzles + "\\" + selectedName + ".txt";
                if (File.ReadAllLines(path)[0].Contains('<'))
                {
                    richTextBox_description.Text = File.ReadAllLines(path)[0].Replace("<", "").Replace(">", "");
                }
            }
            catch { MessageBox.Show("Cannot read the description of this puzzle"); }
        }
        private void Button_swapColors_click(object sender, EventArgs e)
        {
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    if (Board_Composer[rank][file].PieceName == "-") { continue; }
                    else
                    {
                        try
                        {
                            string newPieceName = char.IsUpper(Board_Composer[rank][file].PieceName[0]) ? Board_Composer[rank][file].PieceName.ToLower() : Board_Composer[rank][file].PieceName.ToUpper();
                            Board_Composer[rank][file].PieceName = newPieceName;
                            Board_Composer[rank][file].BackgroundImage = Image.FromFile(PathOfCurrentlyUsedChessSet + "\\" + PieceNameToImagePath[newPieceName[0]]);
                            // change its letter and then based on the letter  change image
                        }
                        catch { MessageBox.Show($"Cannot find a required chess piece image."); }
                    }
                }
            }
        }
        private void Button_Add_Click(object sender, EventArgs e) { AddArrangedChapter(); }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { MessageBox.Show("It is similar to FEN, but only the squares are listed, and the empty squares are not squished into numbers. The length of the notation is always 64. \r\nWhite pieces are with capital letters, black with miniscule. Empty square are marked as \"-\"."); }
        public void Swap2Files(int LeftFile, int RightFile)
        {
            for (int rank = 0; rank <= 7; rank++)
            {
                Image? RightImage = Board_Composer[rank][RightFile].BackgroundImage;
                Image? LeftImage = Board_Composer[rank][LeftFile].BackgroundImage;
                string RightPieceName = Board_Composer[rank][RightFile].PieceName;
                string LeftPieceName = Board_Composer[rank][LeftFile].PieceName;
                //----------------------------------------------------------------------------------
                Board_Composer[rank][LeftFile].BackgroundImage = RightImage;
                Board_Composer[rank][LeftFile].PieceName = RightPieceName;
                //----------------------------------------------------------------------------------
                Board_Composer[rank][RightFile].BackgroundImage = LeftImage;
                Board_Composer[rank][RightFile].PieceName = LeftPieceName;
            }
        }
        public void Swap2Ranks(int topRank, int bottomRank)
        {
            List<Image> TopPieceImages = new();
            List<string> TopPieceNames = new();
            // the top is not changed in the actual list of lists
            for (int file = 0; file < 8; file++) // put top's data in temporary lists
            {
                Image? topRankImage = Board_Composer[topRank][file].BackgroundImage;
                string? topRankPName = Board_Composer[topRank][file].PieceName;
                TopPieceImages.Add(topRankImage?? EmptySquare);
                TopPieceNames.Add(topRankPName);
                 
            }
            for (int file = 0; file < 8; file++) // change bottom with unchanged top
            {
                Board_Composer[topRank][file].BackgroundImage = Board_Composer[bottomRank][file].BackgroundImage;
                Board_Composer[topRank][file].PieceName = Board_Composer[bottomRank][file].PieceName;
            }
            for (int file = 0; file < 8; file++) // change bottom with temp lists data
            {
                Board_Composer[bottomRank][file].BackgroundImage = TopPieceImages[file];
                Board_Composer[bottomRank][file].PieceName = TopPieceNames[file];
            }
        }
        private void SwapPlayers_Click(object sender, EventArgs e) // SWAP RANKS AND SWAP FILES
        {
            Swap2Ranks(0, 7);
            Swap2Ranks(1, 6);
            Swap2Ranks(2, 5);
            Swap2Ranks(3, 4);
            //------------------
            Swap2Files(0, 7);
            Swap2Files(1, 6);
            Swap2Files(2, 5);
            Swap2Files(3, 4);
        }
        private void ChangeTheHoverColorOfTheSquaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Hover = takenColor;
                        Board_Solver[i][x].Color_Hover = takenColor;
                    }
                }
                settings.Color_Hover_Current = takenColor;
                button_stHoverColor.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UseBG.Checked)
            {
                try
                {
                    BackgroundImage = Image.FromFile(Application.StartupPath + "Background.jpg");
                }
                catch { MessageBox.Show("Background.jpg was not found."); checkBox_UseBG.Checked = false; }
            }
            else
            {
                BackgroundImage = EmptySquare;
            }
            WriteSettingsFile();
        }
        private void SwapAllFiles(object sender, EventArgs e)
        {
            Swap2Files(0, 7);
            Swap2Files(1, 6);
            Swap2Files(2, 5);
            Swap2Files(3, 4);
        }
        private void SwapAllRanks(object sender, EventArgs e)
        {
            Swap2Ranks(0, 7);
            Swap2Ranks(1, 6);
            Swap2Ranks(2, 5);
            Swap2Ranks(3, 4);
        }
        private void CheckBox_AU_Reset_CheckedChanged(object sender, EventArgs e)
        {
            WriteSettingsFile();
        }
        private void Button_Add_MouseEnter(object sender, EventArgs e)
        {
            textBox_hint.BackColor = textBox_hint.Text.Trim() == string.Empty ? Color.Yellow : Color.Green;
            textbox_Wrong.BackColor = textbox_Wrong.Text.Trim() == string.Empty ? Color.Yellow : Color.Green;
            textBox_Right.BackColor = textBox_Right.Text.Trim() == string.Empty ? Color.Yellow : Color.Green;
            textBox_event.BackColor = textBox_event.Text.Trim() == string.Empty ? Color.Yellow : Color.Green;
            textBox_description.BackColor = textBox_description.Text.Trim() == string.Empty ? Color.Yellow : Color.Green;
        }
        private void Button_Add_MouseLeave(object sender, EventArgs e)
        {
            textBox_hint.BackColor = Color.White;
            textbox_Wrong.BackColor = Color.White;
            textBox_Right.BackColor = Color.White;
            textBox_event.BackColor = Color.White;
            textBox_description.BackColor = Color.White;
        }
        private void Button_generate_PR_MouseEnter(object sender, EventArgs e)
        {
            textBox_name.BackColor = textBox_name.Text.Trim() == string.Empty ? Color.Red : Color.Green;
            listbox_Puzzles_Rush.BackColor = listbox_Puzzles_Rush.Items.Count < 2 ? Color.Red : Color.Green;
        }
        private void Button_generate_PR_MouseLeave(object sender, EventArgs e)
        {
            textBox_name.BackColor = Color.White;
            listbox_Puzzles_Rush.BackColor = Color.White;
        }
        private void Button_Generate_P_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox_Making_PR.Checked == false)
            {
                textBox_name.BackColor = textBox_name.Text.Trim() == string.Empty ? Color.Red : Color.Green;
                listbox_Puzzle_Fragments.BackColor = listbox_Puzzle_Fragments.Items.Count == 0 ? Color.Red : Color.Green;
            }
        }
        private void Button_Generate_P_MouseLeave(object sender, EventArgs e)
        {
            textBox_name.BackColor = Color.White;
            listbox_Puzzle_Fragments.BackColor = Color.White;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            panel_setttings.Visible = false;
        }
        private void Button_setwhiteSqColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].DefaultColors_White = takenColor;
                        if (Board_Composer[i][x].IsWhiteSquare) { Board_Composer[i][x].DefaultBackColor = Board_Composer[i][x].DefaultColors_White; Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].DefaultColors_White = takenColor;
                        if (Board_Solver[i][x].IsWhiteSquare) { Board_Solver[i][x].DefaultBackColor = Board_Solver[i][x].DefaultColors_White; Board_Solver[i][x].BackColor = takenColor; }
                    }
                }
                button_setwhiteSqColor.BackColor = takenColor;
                settings.Color_White_Current = takenColor;
                WriteSettingsFile();
            }
        }
        private void Button_blackSqSetColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].DefaultColors_Black = takenColor;
                        if (!Board_Composer[i][x].IsWhiteSquare) { Board_Composer[i][x].DefaultBackColor = Board_Composer[i][x].DefaultColors_Black; Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].DefaultColors_Black = takenColor;
                        if (!Board_Solver[i][x].IsWhiteSquare) { Board_Solver[i][x].DefaultBackColor = Board_Solver[i][x].DefaultColors_Black; Board_Solver[i][x].BackColor = takenColor; }
                    }
                }
                button_blackSqSetColor.BackColor = takenColor;
                settings.Color_Black_Current = takenColor;
                WriteSettingsFile();
            }
        }
        private void Button_setSElectedSquare_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Select = takenColor;
                        if (Board_Composer[i][x].IsSelected) { Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].Color_Select = takenColor;
                        if (Board_Solver[i][x].IsSelected) { Board_Composer[i][x].BackColor = takenColor; }
                    }
                }
                settings.Color_Selected_Current = takenColor;
                button_setSElectedSquare.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void Button_setLastMoveColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_BelongsToLastMove = takenColor;
                        if (Board_Composer[i][x].BelongsToLastMove) { Board_Composer[i][x].BackColor = takenColor; }
                        Board_Solver[i][x].Color_BelongsToLastMove = takenColor;
                        if (Board_Solver[i][x].BelongsToLastMove) { Board_Composer[i][x].BackColor = takenColor; }
                    }
                }
                settings.Color_LastMove_Current = takenColor;
                button_setLastMoveColor.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void Button_stHoverColor_Click(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Hover = takenColor;
                        Board_Solver[i][x].Color_Hover = takenColor;
                    }
                }
                settings.Color_Hover_Current = takenColor;
                button_stHoverColor.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void ChangeHLColor_Normal(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Hover = takenColor;
                        Board_Solver[i][x].Color_Hover = takenColor;
                    }
                }
                settings.Color_Hightlight_Normal = takenColor;
                button_hColor1.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void ChangeHLColor_CTRL(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Hover = takenColor;
                        Board_Solver[i][x].Color_Hover = takenColor;
                    }
                }
                settings.Color_Hightlight_Ctrl = takenColor;
                button_hColor2.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void ChangeHLColor_ALT(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Hover = takenColor;
                        Board_Solver[i][x].Color_Hover = takenColor;
                    }
                }
                settings.Color_Hightlight_Alt = takenColor;
                button_hColor3.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void ChangeHLColor_SHIFT(object sender, EventArgs e)
        {
            if (colorDialog_decideColorSquares.ShowDialog() == DialogResult.OK)
            {
                Color takenColor = colorDialog_decideColorSquares.Color;
                for (int i = 0; i <= 7; i++)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        Board_Composer[i][x].Color_Hover = takenColor;
                        Board_Solver[i][x].Color_Hover = takenColor;
                    }
                }
                settings.Color_Hightlight_Shift = takenColor;
                button_hColor4.BackColor = takenColor;
                WriteSettingsFile();
            }
        }
        private void SetGlobalTimer(object sender, EventArgs e)
        {
            int hours = (int)numF_Hour_Global.Value * 60 * 60;
            int mins = (int)numF_Min_Global.Value * 60;
            int secs = (int)numF_Sec_Global.Value;
            int sum = hours + mins + secs;
            if (sum > 0)
            {
                Time_Puzzle_SecondsTotal = sum;
                Time_Global_SecondsLeft = sum;
                Timer_Global.Start();
                label_Countdown_Global.ForeColor = Color.White;
            }
        }
        private void ResetAllSettings_Panel_Click(object sender, EventArgs e)
        {
            settings.Color_White_Current = settings.Default_WhiteSquareColor;
            settings.Color_Black_Current = settings.Default_BlackSquareColor;
            settings.Color_Selected_Current = settings.Default_SelectSquareColor;
            settings.Color_LastMove_Current = settings.Default_SquareLastMoveColor;
            settings.Color_Hover_Current = settings.Default_SquareHoverColor;
            settings.Color_Hightlight_Normal = settings.Default_Color_Hightlight_Normal;
            settings.Color_Hightlight_Ctrl = settings.Default_Color_Hightlight_Ctrl;
            settings.Color_Hightlight_Alt = settings.Default_Color_Hightlight_Ctrl;
            settings.Color_Hightlight_Shift = settings.DefaultColor_Hightlight_Shift;
            settings.Player2ResponseTime = 300;
            numericUpDown7.Value = 300;
            numF_Hour_Global.Value = 0;
            numF_Min_Global.Value = 0;
            numF_Sec_Global.Value = 0;
            numF_Sec_Puzzle.Value = 0;
            numF_Min_Puzzle.Value = 0;
            numF_Hour_Puzzle.Value = 0;
            settings.AutoCountdown = 0;
            Time_Global_SecondsLeft = 0;
            Time_Puzzle_SecondsLeft = 0;
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    Board_Solver[rank][file].Color_Hover = settings.Default_SquareHoverColor;
                    Board_Solver[rank][file].Color_Select = settings.Default_BlackSquareColor;
                    Board_Solver[rank][file].Color_BelongsToLastMove = settings.Default_SquareLastMoveColor;
                    Board_Solver[rank][file].DefaultColors_White = settings.Default_WhiteSquareColor;
                    Board_Solver[rank][file].DefaultColors_Black = settings.Default_WhiteSquareColor;
                    Board_Solver[rank][file].DefaultBackColor = Board_Solver[rank][file].IsWhiteSquare ? settings.Default_WhiteSquareColor : settings.Default_BlackSquareColor;
                    Board_Solver[rank][file].SetDefaultBackColor();
                    Board_Composer[rank][file].Color_Hover = settings.Default_SquareHoverColor;
                    Board_Composer[rank][file].Color_Select = settings.Default_BlackSquareColor;
                    Board_Composer[rank][file].Color_BelongsToLastMove = settings.Default_SquareLastMoveColor;
                    Board_Composer[rank][file].DefaultColors_White = settings.Default_WhiteSquareColor;
                    Board_Composer[rank][file].DefaultColors_Black = settings.Default_WhiteSquareColor;
                    Board_Composer[rank][file].DefaultBackColor = Board_Composer[rank][file].IsWhiteSquare ? settings.Default_WhiteSquareColor : settings.Default_BlackSquareColor;
                    Board_Composer[rank][file].SetDefaultBackColor();
                }
            }
            WriteSettingsFile();
        }
        private void Button_setResponseTimePL_Click(object sender, EventArgs e)
        {
            int milliseconds = (int)numericUpDown7.Value;
            settings.Player2ResponseTime = milliseconds;
            WriteSettingsFile();
        }
        private void ListofPuzzles_MouseDoubleClick(object sender, MouseEventArgs e)
        { SolveSelectedPuzzle(); }
        private void Button_Autoplay_Click(object sender, EventArgs e)
        {
            if (CurrentlyOpenedPuzzleFilename.Length == 0)
            {
                MessageBox.Show("No puzzle is opened or the last opened was solved.");
            }
            else
            {
                if (Autoplay_Timer.Enabled == false)
                {
                    CurrentlySolvedPuzzleChapterStep = 0;
                    RecreatePuzzleFromSCN(CurrentPuzzle_Solutions[0], panel_solver);
                    for (int i = 0; i < 8; i++)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            Board_Solver[i][x].CanInteract = false;
                        }
                    }
                    Autoplay_Timer.Start();
                }
            }
        }
        private void CheckBox_Making_PR_CheckedChanged(object sender, EventArgs e) { button_generate_PR.Enabled = checkBox_Making_PR.Checked; }
        private void Button_SetPieceTheme_Click(object sender, EventArgs e)
        {
            string targetFolder = path_pieces + comboBox_Psets.Text;
            // MessageBox.Show(targetFolder); return;
            if (!Directory.Exists(targetFolder)) { MessageBox.Show("The selected directory for that piece set no longer exists."); CheckAndLoadAllPieceImages(); return; }
            PathOfCurrentlyUsedChessSet = targetFolder;
            // change all images
            CheckAndLoadAllPieceImages();
            LoadRequiredPieceImages();
            Re_Set_Current_PieceImages();
            string[] parts = PathOfCurrentlyUsedChessSet.Split("\\").ToArray();
            FolderOfCurrentlyUsedChessSet = parts[^1];
            comboBox_Psets.Text = FolderOfCurrentlyUsedChessSet;
            WriteSettingsFile();
        }
        public void Re_Set_Current_PieceImages()
        {
            for (int rank = 0; rank < 8; rank++)
            {
                for (int file = 0; file < 8; file++)
                {
                    if (Board_Solver[rank][file].BackgroundImage != null)
                    {
                        Board_Solver[rank][file].BackgroundImage = CharactersAsPieceImages[Board_Solver[rank][file].PieceName[0]];
                    }
                    if (Board_Composer[rank][file].BackgroundImage != null)
                    {
                        Board_Composer[rank][file].BackgroundImage = CharactersAsPieceImages[Board_Composer[rank][file].PieceName[0]];
                    }
                }
            }
        }
        private void Button_setDefaultCountdown_Panel_Click(object sender, EventArgs e)
        {
            int hours = (int)numF_Hour_Puzzle.Value * 60 * 60;
            int mins = (int)numF_Min_Puzzle.Value * 60;
            int secs = (int)numF_Sec_Puzzle.Value;
            Time_Puzzle_SecondsLeft = hours + mins + secs;
            settings.AutoCountdown = Time_Puzzle_SecondsLeft;
            WriteSettingsFile();
        }
        private void Button_StopGlobalTimer_Click(object sender, EventArgs e)
        {
            Timer_Global.Stop();
            label_Countdown_Global.Text = "";
            Time_Global_SecondsLeft = 0;
        }
        private void Button_StopPuzzleTimer_Click(object sender, EventArgs e)
        {
            Timer_Puzzle.Stop();
            label_Countdown_Puzzle.Text = "";
        }
        private void Button_export_FEN_MouseEnter(object sender, EventArgs e)  { button_export_FEN.ForeColor = Color.Black; }
        private void Button_export_FEN_MouseLeave(object sender, EventArgs e)  {  button_export_FEN.ForeColor = Color.White; }
        private void Button_export_Local_MouseEnter(object sender, EventArgs e) { button_export_Local.ForeColor = Color.Black; }
         private void Button_export_Local_MouseLeave(object sender, EventArgs e)  {  button_export_Local.ForeColor = Color.White;  }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Time_Global_SecondsLeft > 0)
            {
                Timer_Global.Stop();
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Time_Global_SecondsLeft > 0 && !Timer_Global.Enabled)
            {
                Timer_Global.Start();
            }
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Time_Global_SecondsLeft > 0  )
            {
                Timer_Global.Stop();
                Time_Global_SecondsLeft = 0;
                label_Countdown_Global.Text = "";
                
            }
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Time_Puzzle_SecondsTotal >0 && label_Countdown_Global.Text != "") {
                Time_Global_SecondsLeft = Time_Puzzle_SecondsTotal;
                Timer_Global.Stop();
                Timer_Global.Start();
            }
        }

        private void Checkbox_smartAdd_CheckedChanged(object sender, EventArgs e)
        {
            button_Add.Enabled = !checkbox_smartAdd.Checked;
            button_Transition.Enabled = !checkbox_smartAdd.Checked;
            
        }
    }
}