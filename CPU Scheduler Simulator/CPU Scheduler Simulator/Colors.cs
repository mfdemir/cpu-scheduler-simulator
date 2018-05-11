using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public class Colors
    {
        public static Colors instance;
        Color[] colors;
        int currentColorIndex = -1;
        public static Colors Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Colors();
                }
                return instance;
            }
        }
        public Colors()
        {
            colors = new Color[] {
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Turquoise,
                Color.Purple,
                Color.Orange,
                Color.Teal,
                Color.Black,
                Color.DarkGray
            };
        }
        public Color NextColor()
        {
            if (currentColorIndex == colors.Length - 1)
                currentColorIndex = -1;
            return colors[++currentColorIndex];
        }

    }
}
