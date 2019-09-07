using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTipper
{
    class GlobalVar
    {
        public static int widthAdder = 0;
        public static int formSize = 0;
        public static int heightDiff = 0;

        public static void setBounds()
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen s in Screen.AllScreens)
            {
                if (Screen.AllScreens.Count() == 3)
                {
                    if (s.Bounds.Width == 1024)
                    {
                        continue;
                    }
                }
                if (s == screens[Screen.AllScreens.Count() - 1])
                {
                    GlobalVar.widthAdder += (s.Bounds.Width / 2);
                }
                else GlobalVar.widthAdder += s.Bounds.Width;
            }
            GlobalVar.heightDiff = screens[Screen.AllScreens.Length - 1].WorkingArea.Top;
        }
        public static void setCentered(Screen screen, Form obj)
        {
            int heightDiff = screen.Bounds.Top+20;
            int widthAdder;
            if(screen.Bounds.Left > 0)
                widthAdder = screen.Bounds.Left + ((Math.Abs(screen.Bounds.Right) - Math.Abs(screen.Bounds.Left)) / 2) - (obj.Size.Width / 2);
            else
                widthAdder = ((Math.Abs(screen.Bounds.Right) - Math.Abs(screen.Bounds.Left)) / 2) - (obj.Size.Width / 2);

            obj.Top = heightDiff;
            obj.Left = widthAdder;

            obj.Location = new System.Drawing.Point(widthAdder, 1 + heightDiff);
            Console.WriteLine("Top bound: " + heightDiff);
        }
    }
}
