using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chezz_Puzzler
{
    public class ChessButton : Button
    {
        public ChessButton()
        {
            pieceName = "-";
            squareName = "-";
            belongsToLastMove = false;
            isHovered = false;
            isSelected = false;

            color_select = Color.LightBlue;
            color_hover = Color.LightCyan;
            Color_BelongsToLastMove = Color.LightYellow;
            SolutionMarkColor = Color.LightGreen;
            WaitingPaste = false;
            isMarked = false;
            CanInteract = true;
            markColor = Color.Empty;
            Width = 65;
            Height = 65;
            AutoSize = false;
            FlatStyle = FlatStyle.Flat;
            PieceName = "-";
            PlayertoMove = "None";


        }
        public Panel? belongsToWhichPanel;
        //----------------------------------------------------------
        private string pieceName;
        private string squareName;
        private string? squareColorAsChar;
        //----------------------------------------------------------
        private bool isHovered;
        private bool belongsToLastMove;
        private bool isSelected;
        private bool isWhiteSquare;
        private bool waitingPaste;
        public bool CanInteract;
        private string? PlayertoMove;
        public bool SolverIsMoving;
        private bool isMarked;
        private bool isMarkedAsSolution;
        //----------------------------------------------------------
        private Color CurrentColor_White;
        private Color CurrentColor_Black;
        private Color defaultBackColor;
        private Color color_select;
        private Color color_hover;
        private Color color_BelongsToLastMove;
        private Color markColor;
        private Color solutionMarkColor;
        public string ToMove { get => PlayertoMove ?? ""; set => PlayertoMove = value; }
        public bool IsMarkedAsSolution
        {
            get => isMarkedAsSolution;
            set
            {
                isMarkedAsSolution = value;
                if (isMarkedAsSolution == true)
                {
                    BackColor = SolutionMarkColor;

                }
                else
                {
                    SetDefaultBackColor();
                }

            }

        }
        public bool WaitingPaste
        {
            get => waitingPaste;
            set => waitingPaste = value;
        }
        // we have select color, hover color, last move color, and the default square color
        public bool IsWhiteSquare
        {
            get => isWhiteSquare;
            set => isWhiteSquare = value;
        }
        public void Mark(Color newColor)
        {
            if (isMarked)
            {
                if (markColor == newColor) // if the same color is given, un-mark
                {
                    isMarked = false;
                    SetDefaultBackColor();
                }
                else
                {
                    BackColor = newColor;
                    markColor = newColor;
                }
            }
            else
            {
                IsMarked = true;
                BackColor = newColor;
                markColor = newColor;
            }
        }
        public override Image? BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        public bool IsMarked { get => isMarked; set { isMarked = value; if (value == false) { SetDefaultBackColor(); } } }
        public string PieceName { get => pieceName; set => pieceName = value; }
        public string SquareName { get => squareName; set => squareName = value; }
        public string SquareColor { get { return squareColorAsChar ?? ""; } set { this.BackColor = value == "b" ? CurrentColor_Black : CurrentColor_White; squareColorAsChar = value; } }
        public Color DefaultColors_Black { get => CurrentColor_Black; set => CurrentColor_Black = value; }
        public Color DefaultColors_White { get => CurrentColor_White; set => CurrentColor_White = value; }
        public new Color DefaultBackColor { get => defaultBackColor; set => defaultBackColor = value; }
        public Color SolutionMarkColor { get => solutionMarkColor; set => solutionMarkColor = value; }
        public void SetDefaultBackColor()
        {
            if (!belongsToLastMove && !isSelected && !IsMarkedAsSolution)
            {
                BackColor = DefaultBackColor;
                return;
            }
            if (isSelected) { BackColor = color_select; return; }
            if (belongsToLastMove) { BackColor = color_BelongsToLastMove; return; }
            if (IsMarkedAsSolution) { BackColor = solutionMarkColor; return; }
        }
        //---------------------------------------------------------------------
        public bool IsHovered
        {
            get => isHovered;
            set
            {
                isHovered = value;
                if (CanInteract == false)
                {
                    Cursor = Cursors.Arrow;
                }
                else
                {

                    bool ThisPieceIs_White = char.IsUpper(pieceName[0]);
                    bool ThisPieceIs_Black = char.IsLower(pieceName[0]);
                    bool thisSquareHasImage = pieceName != "-";


                    if (isHovered) // if hovered
                    {
                        BackColor = color_hover;


                        if (thisSquareHasImage)  // if hovered and has an image
                        {
                            if (PlayertoMove == "None" || PlayertoMove == string.Empty)
                            {
                                if (waitingPaste && IsSelected) { Cursor = Cursors.Arrow; return; }
                                if (waitingPaste && !IsSelected) { Cursor = Cursors.No; return; }
                                if (!waitingPaste) { Cursor = Cursors.Hand; return; }

                            }
                            if (PlayertoMove == "Any")
                            {
                                if (waitingPaste && IsSelected) { Cursor = Cursors.Hand; return; }
                                if (waitingPaste && !IsSelected) { Cursor = Cursors.Cross; return; }
                                if (!waitingPaste) { Cursor = Cursors.Hand; return; }

                            }
                            if (PlayertoMove == "White to move") // if white is to move 
                            {
                                // if targeted a white piece
                                if (ThisPieceIs_White && waitingPaste && isSelected) { Cursor = Cursors.Hand; return; }
                                if (ThisPieceIs_White && waitingPaste && !isSelected) { Cursor = Cursor = Cursors.No; return; }
                                if (ThisPieceIs_White && !waitingPaste) { Cursor = Cursors.Hand; return; }
                                // if targeted a black piece
                                if (ThisPieceIs_Black && waitingPaste) { Cursor = Cursors.Cross; return; }
                                if (ThisPieceIs_Black && !waitingPaste) { Cursor = Cursors.No; return; }
                            }
                            else if (PlayertoMove == "Black to move") // if black is the move
                            {
                                // if targeted a black piece
                                if (ThisPieceIs_Black && waitingPaste && isSelected) { Cursor = Cursors.Hand; return; }
                                if (ThisPieceIs_Black && waitingPaste && !isSelected) { Cursor = Cursor = Cursors.No; return; }
                                if (ThisPieceIs_Black && !waitingPaste) { Cursor = Cursors.Hand; return; }
                                // if targeted a white piece
                                if (ThisPieceIs_White && waitingPaste) { Cursor = Cursors.Cross; return; }
                                if (ThisPieceIs_White && !waitingPaste) { Cursor = Cursors.No; return; }
                            }



                        }
                        else // if doesnt have an image
                        {
                            if (waitingPaste) { Cursor = Cursors.Cross; return; } else { Cursor = Cursors.Arrow; return; }
                        }
                    }
                    else // if it's not hovered
                    {
                        Cursor = Cursors.Arrow;
                        if (isMarked)
                        {
                            BackColor = markColor;
                        }
                        else
                        {
                            SetDefaultBackColor();

                        }
                    }


                }
            }
        }
        public Color Color_Select { get => color_select; set => color_select = value; }
        public Color Color_Hover { get => color_hover; set => color_hover = value; }
        public Color Color_BelongsToLastMove { get => color_BelongsToLastMove; set => color_BelongsToLastMove = value; }
        public bool IsSelected { get => isSelected; set { isSelected = value; if (value == true) { BackColor = color_select; } else { SetDefaultBackColor(); } } }
        public bool BelongsToLastMove
        {
            get => belongsToLastMove;
            set
            {
                belongsToLastMove = value;
                if (belongsToLastMove == true)
                {
                    BackColor = color_BelongsToLastMove;
                    return;
                }
                 if (belongsToLastMove == false)

                {
                   SetDefaultBackColor();

                }

            }
        }

        public void SetColors(Color SelectColor, Color Hover, Color BlackColor, Color WhiteColor, Color lastSquares)
        {
            Color_Select = SelectColor;
            Color_Hover = Hover;
            DefaultColors_Black = BlackColor;
            DefaultColors_White = WhiteColor;
            color_BelongsToLastMove = lastSquares;
            SetDefaultBackColor();
        }
    }
}
