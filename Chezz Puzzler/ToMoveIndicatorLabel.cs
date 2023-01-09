using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chezz_Puzzler
{
    public class ToMoveIndicatorLabel : Label
    {
        public ToMoveIndicatorLabel()
        {
            ToMove = "None";
        }
        private string toMove;
        public string ToMove
        {
            get => toMove;
            set
            {
                toMove = value;
                if (value.Contains("Black"))
                {
                    BackColor = Color.FromArgb(38, 37, 33);
                    ForeColor = Color.WhiteSmoke;
                    Text = "Black to move";
                }
                if (value.Contains("White"))
                {
                    BackColor = Color.WhiteSmoke;
                    ForeColor = Color.FromArgb(38, 37, 33);
                    Text = "White to move";
                }
                if (value == "None")
                {
                    Text = string.Empty;
                }
            }
        }
    }
}
