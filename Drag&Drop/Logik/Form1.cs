using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_Presne.Visible = false;
            lb_Objevuje.Visible = false;
            nud_Objevuje.Visible = false;
            nud_Presne.Visible = false;
            bt_Budiz.Visible = false;
            bt_Hodnot.Visible = false;
            foreach (DataGridViewColumn column in dGv_Guess.Columns)
            {
                column.Width = 47;
            }
        }
        int[] input = new int[5]; //nastavím si nové pole se vstupem
        int[,] moznosti = new int[5, 7776]; //vytvořím si pole všech možností

        // Použití sender as Lable umožní stejnou funkci použít pro libovolný Label = sdílení více Labely

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((sender as Label).BackColor, DragDropEffects.All);   //Nebo také move – move je součástí All (ovlivňuje to tvar kurzoru)
        }

        private void label2_DragEnter(object sender, DragEventArgs e)       //label2 má nastaveno AllowDrop na true – 1. stupeň kontroly
        {
            if (e.Data.GetDataPresent(typeof(Color)))
               e.Effect = DragDropEffects.Move;
        }

        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            (sender as Label).BackColor = (Color)e.Data.GetData(typeof(Color));
            input[0] = funkce.barva(lb_Guess1.BackColor);
            
        }

        private void lb_Blue_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((sender as Label).BackColor, DragDropEffects.All);   //Nebo také move – move je součástí All (ovlivňuje to tvar kurzoru)
        }

        private void lb_Guess2_DragDrop(object sender, DragEventArgs e)
        {
            (sender as Label).BackColor = (Color)e.Data.GetData(typeof(Color));
            input[1] = funkce.barva(lb_Guess2.BackColor);
        }

        private void lb_Guess2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Move;
        }

        private void lb_Guess3_DragDrop(object sender, DragEventArgs e)
        {
            (sender as Label).BackColor = (Color)e.Data.GetData(typeof(Color));
            input[2] = funkce.barva(lb_Guess3.BackColor);
        }

        private void lb_Guess3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Move;
        }

        private void lb_Guess4_DragDrop(object sender, DragEventArgs e)
        {
            (sender as Label).BackColor = (Color)e.Data.GetData(typeof(Color));
            input[3] = funkce.barva(lb_Guess4.BackColor);
        }

        private void lb_Guess4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Move;
        }

        private void lb_Guess5_DragDrop(object sender, DragEventArgs e)
        {
            (sender as Label).BackColor = (Color)e.Data.GetData(typeof(Color));
            input[4] = funkce.barva(lb_Guess5.BackColor);
        }

        private void lb_Guess5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Move;
        }

        private void lb_Green_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((sender as Label).BackColor, DragDropEffects.All);   //Nebo také move – move je součástí All (ovlivňuje to tvar kurzoru)
        }

        private void lb_Black_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((sender as Label).BackColor, DragDropEffects.All);   //Nebo také move – move je součástí All (ovlivňuje to tvar kurzoru)
        }

        private void lb_Yeallow_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((sender as Label).BackColor, DragDropEffects.All);   //Nebo také move – move je součástí All (ovlivňuje to tvar kurzoru)
        }

        private void lb_Purple_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop((sender as Label).BackColor, DragDropEffects.All);   //Nebo také move – move je součástí All (ovlivňuje to tvar kurzoru)
        }
        int[] guess = new int[5]; //můj aktuální tip
        int aktualnirow = 0; //pozice aktuálního řádku kam vypisuji
        private void bt_Start_Click(object sender, EventArgs e)
        {
            aktualnirow = 0;
            dGv_Guess.ColumnCount = 5; //nastavím si velikost gridu
            dGv_Guess.RowCount = 10;
            bt_Start.Visible = false;
            lb_Presne.Visible = true;
            lb_Objevuje.Visible = true;
            nud_Objevuje.Visible = true;
            nud_Presne.Visible = true;
            bt_Start.Visible = false;
            bt_Budiz.Visible = true;
            bt_Hodnot.Visible = true;
            int i = 0;
            for (int a = 0; a < 6; a++) //nastavím si všechny možnosti
            {
                for (int b = 0; b < 6; b++)
                {
                    for (int c = 0; c < 6; c++)
                    {
                        for (int d = 0; d < 6; d++)
                        {
                            for (int f = 0; f < 6; f++)
                            {
                                moznosti[0, i] = a;
                                moznosti[1, i] = b;
                                moznosti[2, i] = c;
                                moznosti[3, i] = d;
                                moznosti[4, i] = f;
                                i++;
                            }
                        }
                    }
                }
            }
            Random rnd = new Random();
            int random = rnd.Next(7776);
            for (int x = 0; x < 5; x++)
            {
                guess[x] = moznosti[x, random];
            }
            for (int j = 0; j < 5; j++)
            {
                dGv_Guess.Rows[aktualnirow].Cells[j].Style.BackColor = funkce.kresli(guess[j]);
            }
        }
        int konec = 7776; //maximum pro správné
        int posun = 0;
        private void bt_Budiz_Click(object sender, EventArgs e)
        {
            aktualnirow++;
            if (nud_Presne.Value == 5)
            {
                MessageBox.Show("Vyhrál jsem");
                dGv_Guess.Rows.Clear();
                bt_Start.Visible = true;
            }
            else
            {
                if (posun > -1) //pokud si nedělá hráč srandu
                {
                    for (int i = 0; i < konec; i++) //projdu vhodné možnosti
                    {
                        int[] aktualni = new int[5];
                        for (int x = 0; x < 5; x++) //načtu si aktulní možnost
                        {
                            aktualni[x] = moznosti[x, i];
                        }
                        bile = (int)nud_Objevuje.Value;
                        cerne = (int)nud_Presne.Value;
                        if (funkce.sedi(bile, cerne, aktualni, guess) == true) //srovnám s výsledkem
                        {
                            for (int j = 0; j < 5; j++) //prohodím hodnoty správného pole a posledního špatného
                            {
                                int mezivysledek;
                                mezivysledek = moznosti[j, posun];
                                moznosti[j, posun] = moznosti[j, i];
                                moznosti[j, i] = mezivysledek;
                            }
                            posun++;
                        }
                    }
                    konec = posun - 1;
                    for (int j = 0; j < 5; j++) //nakreslím můj aktuální guess
                    {
                        Random rnd = new Random();
                        int random = rnd.Next(konec);
                        guess[j] = moznosti[j, konec];
                        dGv_Guess.Rows[aktualnirow].Cells[j].Style.BackColor = funkce.kresli(guess[j]);
                    }
                }
                else
                {
                    MessageBox.Show("Nepodváděj!");
                    dGv_Guess.Rows.Clear();
                    bt_Start.Visible = true;
                }
            }
        }
        int cerne = 0;
        int bile = 0;

        private void bt_Hodnot_Click(object sender, EventArgs e)
        {
            funkce.hodnot(input, guess,out cerne,out  bile);
            nud_Presne.Value = cerne;
            nud_Objevuje.Value = bile;
        }

        private void dGv_Guess_SelectionChanged(object sender, EventArgs e) 
        {
            dGv_Guess.ClearSelection();
        }
    }
}
