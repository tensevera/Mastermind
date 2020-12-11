using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logik
{
    class funkce
    {
        public static void hodnot(int[] input, int[] tip, out int cerne, out int bile)
        {
            int[] barvy = new int[6]; //vytvořím si pole pro kontrolu bílích
            cerne = 0;
            bile = 0;
            for (int i = 0; i < 5; i++) //začnu procházet pole
            {
                if(input[i] == tip[i])
                {
                    cerne++;
                }
                else
                {
                    if (barvy[input[i]] < 0) //pokud mám bílou
                    {
                        bile++;
                    }
                    barvy[input[i]]++;
                    if (barvy[tip[i]] > 0) //pokud mám bílou
                    {
                        bile++;
                    }
                    barvy[tip[i]]--;
                }
            }
        }
        public static int barva(Color vstup) //vrátím příslušné hodnoty pro dané barvy
        {
            if (vstup == Color.Red)
                return 0;
            else if (vstup == Color.MidnightBlue)
                return 1;
            else if (vstup == Color.Lime)
                return 2;
            else if (vstup == Color.Black)
                return 3;
            else if (vstup == Color.Gold)
                return 4;
            else 
                return 5;
        }
        public static Color kresli(int vstup) //funkce pro vykreslování na grid
        {
            if (vstup == 0)
                return Color.Red;
            if (vstup == 1)
                return Color.MidnightBlue;
            if (vstup == 2)
                return Color.Lime;
            if (vstup == 3)
                return Color.Black;
            if (vstup == 4)
                return Color.Gold;
            return Color.Purple;
        }
    }
}
