using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chezz_Puzzler
{
    internal class Settings
    {
        public Settings() 
        {
            DefaultWhiteSquareColor = Color.WhiteSmoke;
            DefaultBlackSquareColor = Color.LightGray;
            DefaultSquareHoverColor = Color.LightCyan;
            DefaultSquareLastMoveColor = Color.FromArgb(223, 228, 235);
            DefaultSelectSquareColor = Color.LightBlue;
            //-------------------------------------
            Color_White_Current = DefaultWhiteSquareColor;
            Color_Black_Current = DefaultBlackSquareColor;
            Color_Selected_Current = DefaultSelectSquareColor;
            Color_LastMove_Current = DefaultSquareLastMoveColor;
            Color_Hover_Current = DefaultSquareHoverColor;
            //-------------------------------------
            Color_Hightlight_Normal = Color.Red;
            Color_Hightlight_Ctrl = Color.Orange;
            Color_Hightlight_Alt = Color.Blue;
            Color_Hightlight_Shift = Color.LightGreen;
            Color_Hightlight_Normal_Default = Color.Red;
            Color_Hightlight_Ctrl_Default = Color.Orange;
            Color_Hightlight_Alt_Default = Color.Blue;
            Color_Hightlight_Shift_Default = Color.LightGreen;
            Player2ResponseTime = 300;
            AutoCountdown = 0;
        }
        //colors
        public Color Color_White_Current;
        public Color Color_Black_Current;
        public Color Color_Selected_Current;
        public Color Color_LastMove_Current;
        public Color Color_Hover_Current;
        public Color Color_Hightlight_Normal;
        public Color Color_Hightlight_Ctrl;
        public Color Color_Hightlight_Alt;
        public Color Color_Hightlight_Shift;
        public Color Color_Hightlight_Normal_Default;
        public Color Color_Hightlight_Ctrl_Default;
        public Color Color_Hightlight_Alt_Default;
        public Color Color_Hightlight_Shift_Default;
        //----------------------------------------------------------
        public Color DefaultWhiteSquareColor;
        public Color DefaultBlackSquareColor;
        public Color DefaultSquareHoverColor;
        public Color DefaultSquareLastMoveColor;
        public Color DefaultSelectSquareColor;
        // other
        public int AutoCountdown;
        public int Player2ResponseTime;
    }
}
