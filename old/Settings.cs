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
            //-------------------------------------
            Default_WhiteSquareColor = Color.WhiteSmoke;
            Default_BlackSquareColor = Color.LightGray;
            Default_SquareHoverColor = Color.LightCyan;
            Default_SquareLastMoveColor = Color.FromArgb(223, 228, 235);
            Default_SelectSquareColor = Color.LightBlue;
            //-------------------------------------
            Color_White_Current = Default_WhiteSquareColor;
            Color_Black_Current = Default_BlackSquareColor;
            Color_Selected_Current = Default_SelectSquareColor;
            Color_LastMove_Current = Default_SquareLastMoveColor;
            Color_Hover_Current = Default_SquareHoverColor;
            //-------------------------------------
            Color_Hightlight_Normal = Color.Red;
            Color_Hightlight_Ctrl = Color.Orange;
            Color_Hightlight_Alt = Color.Blue;
            Color_Hightlight_Shift = Color.LightGreen;
            //-------------------------------------
            Default_Color_Hightlight_Normal = Color.Red;
            Default_Color_Hightlight_Ctrl = Color.Orange;
            Default_Color_Hightlight_Alt = Color.Blue;
            DefaultColor_Hightlight_Shift = Color.LightGreen;
            DefaultColor_Solution = Color.LawnGreen;
            //-------------------------------------
            Player2ResponseTime = 300;
            AutoCountdown = 0;
        }
        //colors
        public Color Color_White_Current;
        public Color Color_Black_Current;
        public Color Color_Selected_Current;
        public Color Color_LastMove_Current;
        public Color Color_Hover_Current;
        public Color DefaultColor_Solution;
        //----------------------------------------------------------
        public Color Color_Hightlight_Normal;
        public Color Color_Hightlight_Ctrl;
        public Color Color_Hightlight_Alt;
        public Color Color_Hightlight_Shift;
        //----------------------------------------------------------
        public readonly Color Default_Color_Hightlight_Normal;
        public readonly Color Default_Color_Hightlight_Ctrl;
        public readonly Color Default_Color_Hightlight_Alt;
        public readonly Color DefaultColor_Hightlight_Shift;
        //----------------------------------------------------------
        public readonly Color Default_WhiteSquareColor;
        public readonly Color Default_BlackSquareColor;
        public readonly Color Default_SquareHoverColor;
        public readonly Color Default_SquareLastMoveColor;
        public readonly Color Default_SelectSquareColor;
        //----------------------------------------------------------
        // other
        public int AutoCountdown;
        public int Player2ResponseTime;
    }
}
