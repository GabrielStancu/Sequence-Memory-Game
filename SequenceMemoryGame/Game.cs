using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequenceMemoryGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            foreach (var bt in this.Controls.OfType<Button>()) { bt.Visible = true; bt.Enabled = false; }
            btStart.Visible = false;
            btExit.Enabled = true;
            txtSecvGen.Text = string.Empty;
            txtSecvJuc.Text = string.Empty;
            lbLv.Text = "1";
            timerMutari.Start();
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "1";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt11);
            verificare(pozitie);
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "2";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt12);
            verificare(pozitie);
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "3";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt13);
            verificare(pozitie);
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "4";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt21);
            verificare(pozitie);
        }

        private void bt22_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "5";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt22);
            verificare(pozitie);
        }

        private void bt23_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "6";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt23);
            verificare(pozitie);
        }

        private void bt31_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "7";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt31);
            verificare(pozitie);
        }

        private void bt32_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "8";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt32);
            verificare(pozitie);
        }

        private void bt33_Click(object sender, EventArgs e)
        {
            txtSecvJuc.Text = txtSecvJuc.Text + "9";
            int pozitie = txtSecvJuc.Text.Length;
            redimensionare_la_click(bt33);
            verificare(pozitie);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Main f2 = new Main();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void timerMutari_Tick(object sender, EventArgs e)
        {
            int lv = int.Parse(lbLv.Text);
            if(lv==1)
            {
                if(txtSecvGen.Text.Length<=4)
                {
                    Random bt_nou = new Random();
                    int index_bt_nou = bt_nou.Next(1, 10);
                    txtSecvGen.Text = txtSecvGen.Text + index_bt_nou.ToString();
                    if (txtSecvGen.Text.Length <5) dimensionare_activ(index_bt_nou);
                    if (txtSecvGen.Text.Length >= 2)
                        redimensionare(int.Parse(txtSecvGen.Text[txtSecvGen.Text.Length - 2].ToString()));
                    if (txtSecvGen.Text.Length == 5)
                    {
                        txtSecvGen.Text = txtSecvGen.Text.Substring(0, txtSecvGen.Text.Length - 1);
                        timerMutari.Stop();
                        foreach (var bt in this.Controls.OfType<Button>()) bt.Enabled = true;
                    }
                }
            }
            else
            {                
                if (txtSecvGen.Text.Length < lv + 3)
                {
                    Random bt_nou = new Random();
                    int index_bt_nou = bt_nou.Next(1, 10);
                    txtSecvGen.Text = txtSecvGen.Text + index_bt_nou.ToString() + "0";
                }

                int nr_buton_activ = int.Parse(lbIndexBt.Text);
                if (nr_buton_activ <= txtSecvGen.Text.Length)
                {
                    if (nr_buton_activ < txtSecvGen.Text.Length)
                        dimensionare_activ(int.Parse(txtSecvGen.Text[nr_buton_activ].ToString()));
                    if (nr_buton_activ >= 1) redimensionare(int.Parse(txtSecvGen.Text[nr_buton_activ - 1].ToString()));
                    nr_buton_activ++;
                    lbIndexBt.Text = nr_buton_activ.ToString();
                    if (nr_buton_activ == txtSecvGen.Text.Length) txtSecvGen.Text = txtSecvGen.Text.Substring(0, txtSecvGen.Text.Length - 1);
                }
            }
        }
        
        private void dimensionare_activ(int nr)
        {
            if (nr == 1) { bt11.Width = bt11.Height = 140; bt11.Left = bt11.Left + 5; bt11.Top = bt11.Top + 5; }
            if (nr == 2) { bt12.Width = bt12.Height = 140; bt12.Left = bt12.Left + 5; bt12.Top = bt12.Top + 5; }
            if (nr == 3) { bt13.Width = bt13.Height = 140; bt13.Left = bt13.Left + 5; bt13.Top = bt13.Top + 5; }
            if (nr == 4) { bt21.Width = bt21.Height = 140; bt21.Left = bt21.Left + 5; bt21.Top = bt21.Top + 5; }
            if (nr == 5) { bt22.Width = bt22.Height = 140; bt22.Left = bt22.Left + 5; bt22.Top = bt22.Top + 5; }
            if (nr == 6) { bt23.Width = bt23.Height = 140; bt23.Left = bt23.Left + 5; bt23.Top = bt23.Top + 5; }
            if (nr == 7) { bt31.Width = bt31.Height = 140; bt31.Left = bt31.Left + 5; bt31.Top = bt31.Top + 5; }
            if (nr == 8) { bt32.Width = bt32.Height = 140; bt32.Left = bt32.Left + 5; bt32.Top = bt32.Top + 5; }
            if (nr == 9) { bt33.Width = bt33.Height = 140; bt33.Left = bt33.Left + 5; bt33.Top = bt33.Top + 5; }
        }

        private void redimensionare(int bt_prev)
        {
            if (bt_prev == 1) { bt11.Width = bt11.Height = 150; bt11.Left = bt11.Left - 5; bt11.Top = bt11.Top - 5; }
            if (bt_prev == 2) { bt12.Width = bt12.Height = 150; bt12.Left = bt12.Left - 5; bt12.Top = bt12.Top - 5; }
            if (bt_prev == 3) { bt13.Width = bt13.Height = 150; bt13.Left = bt13.Left - 5; bt13.Top = bt13.Top - 5; }
            if (bt_prev == 4) { bt21.Width = bt21.Height = 150; bt21.Left = bt21.Left - 5; bt21.Top = bt21.Top - 5; }
            if (bt_prev == 5) { bt22.Width = bt22.Height = 150; bt22.Left = bt22.Left - 5; bt22.Top = bt22.Top - 5; }
            if (bt_prev == 6) { bt23.Width = bt23.Height = 150; bt23.Left = bt23.Left - 5; bt23.Top = bt23.Top - 5; }
            if (bt_prev == 7) { bt31.Width = bt31.Height = 150; bt31.Left = bt31.Left - 5; bt31.Top = bt31.Top - 5; }
            if (bt_prev == 8) { bt32.Width = bt32.Height = 150; bt32.Left = bt32.Left - 5; bt32.Top = bt32.Top - 5; }
            if (bt_prev == 9) { bt33.Width = bt33.Height = 150; bt33.Left = bt33.Left - 5; bt33.Top = bt33.Top - 5; }
        }

        private void redimensionare_la_click(Button bt)
        {
            foreach (var btn in this.Controls.OfType<Button>())
                if (btn != btStart && btn != btExit) if (btn.Width == 140) { btn.Width = btn.Height = 150; btn.Left = btn.Left - 5; btn.Top = btn.Top - 5; }
            bt.Width = bt.Height = 140; bt.Left = bt.Left + 5; bt.Top = bt.Top + 5;
        }

        private void verificare(int pozitie)
        {
            char c1 = txtSecvGen.Text[pozitie - 1];

            char c2 = txtSecvJuc.Text[pozitie - 1];
            if (c1 != c2)
            {
                foreach (var bt in this.Controls.OfType<Button>()) bt.Visible = false;
                btStart.Visible = true;
                btExit.Visible = true;
                MessageBox.Show("You lost, try again!");
            }
            else if (c1 == c2 && pozitie == txtSecvGen.Text.Length)
            {
                if (lbLv.Text == "5")
                {
                    btStart.Visible = true;
                    MessageBox.Show("Congratulations, you won the game!");
                }
                else
                {
                    MessageBox.Show("Congratulations, you finished the level!");
                    redimensionare(int.Parse(txtSecvGen.Text[txtSecvGen.Text.Length - 1].ToString()));
                    txtSecvJuc.Text = string.Empty;
                    lbIndexBt.Text = "0";
                    int lv_actual = int.Parse(lbLv.Text);
                    lv_actual++;
                    lbLv.Text = lv_actual.ToString();
                    timerMutari.Start();
                }
            }
        }
    }
}
