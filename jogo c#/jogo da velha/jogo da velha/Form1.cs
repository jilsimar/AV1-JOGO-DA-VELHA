using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class global
        {

            public static bool turn, button_disable;
            public static int player1_wins = 0, player2_wins = 0, tie = 0, ronud = 0, A = 0, B = 0, C = 0, D = 0, E = 0,
            F = 0, G = 0, H = 0, I = 0, p1, rounds;
        }
        private void checkingWinner()
        {
            // Verificações de vitórias do jogador 1(X) nas horizontais:
            if (global.A == 1 && global.B == 1 && global.C == 1)
            {
                global.player1_wins++;
                label4.Text = Convert.ToString(global.player1_wins);
                MessageBox.Show("Jogador 1 venceu!");
                global.button_disable = true;
            }

            if (global.D == 1 && global.E == 1 && global.F == 1)
            {
                global.player1_wins++;
                label4.Text = Convert.ToString(global.player1_wins);
                MessageBox.Show("Jogador 1 venceu!");
                global.button_disable = true;
            }

            if (global.G == 1 && global.H == 1 && global.I == 1)
            {
                global.player1_wins++;
                label4.Text = Convert.ToString(global.player1_wins);
                MessageBox.Show("Jogador 1 venceu!");
                global.button_disable = true;

            }
            // Verificações de vitórias do jogador 1(X) nas verticais:
            if (global.A == 1 && global.B == 1 && global.C == 1)
            {
                global.p1 = 1;
                wins();
            }

            if (global.D == 1 && global.E == 1 && global.F == 1)
            {
                global.p1 = 1;
                wins();
            }

            if (global.G == 1 && global.H == 1 && global.I == 1)
            {
                global.p1 = 1;
                wins();
            }

            // Verificações de vitórias do jogador 1(X) nas diagonais:
            if (global.A == 1 && global.D == 1 && global.G == 1)
            {
                global.p1 = 1;
                wins();
            }

            if (global.B == 1 && global.E == 1 && global.H == 1)
            {
                global.p1 = 1;
                wins();
            }

            if (global.C == 1 && global.F == 1 && global.I == 1)
            {
                global.p1 = 1;
                wins();
            }

            // Verificações de vitórias do jogador 1(X) nas hori:
            if (global.A == 1 && global.E == 1 && global.I == 1)
            {
                global.p1 = 1;
                wins();
            }

            if (global.C == 1 && global.E == 1 && global.G == 1)
            {
                global.p1 = 1;
                wins();
            }

            // Verificações de vitórias do jogador 2(O) nas horizontais:
            if (global.A == 2 && global.B == 2 && global.C == 2)
            {
                global.p1 = 2;
                wins();
            }

            if (global.D == 2 && global.E == 2 && global.F == 2)
            {
                global.p1 = 2;
                wins();
            }

            if (global.G == 2 && global.H == 2 && global.I == 2)
            {
                global.p1 = 2;
                wins();
            }

            // Verificações de vitórias do jogador 2(O) nas verticais:
            if (global.A == 2 && global.D == 2 && global.G == 2)
            {
                global.p1 = 2;
                wins();
            }

            if (global.B == 2 && global.E == 2 && global.H == 2)
            {
                global.p1 = 2;
                wins();
            }

            if (global.C == 2 && global.F == 2 && global.I == 2)
            {
                global.p1 = 2;
                wins();
            }

            // Verificações de vitórias do jogador 2(O) nas diagonais:
            if (global.A == 2 && global.E == 2 && global.I == 2)
            {
                global.p1 = 2;
                wins();
            }

            if (global.C == 2 && global.E == 2 && global.G == 2)
            {
                global.p1 = 2;
                wins();
            }
            if (global.p1 == 0 && global.rounds == 9)
            {
                global.tie++;
                label6.Text = Convert.ToString(global.tie);
                MessageBox.Show("Empate");
                global.button_disable = true;

            }
        }
        private void wins()
        {
            if (global.p1 == 1)
            {
                global.player1_wins++;
                label4.Text = Convert.ToString(global.player1_wins);
                MessageBox.Show("Jogador 1 venceu!");
                global.button_disable = true;
            }
            else if (global.p1 == 2)
            {
                global.player2_wins++;
                label5.Text = Convert.ToString(global.player2_wins);
                MessageBox.Show("Jogador 2 venceu!");
                global.button_disable = true;
            }
            

        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.A == 0)
            {
                button1.Text = "X";
                global.A = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == false && global.button_disable == false && global.A == 0)
            {
                button1.Text = "O";
                global.A = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do player 1(X):
            if (global.turn == false && global.button_disable == false && global.B == 0)
            {
                button2.Text = "X";
                global.B = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            // Verificação da jogada do player 2(O):
            if (global.turn == true && global.button_disable == false && global.B == 0)
            {
                button2.Text = "O";
                global.B = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.C == 0)
            {
                button3.Text = "X";
                global.C = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == true && global.button_disable == false && global.C == 0)
            {
                button3.Text = "O";
                global.C = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.D == 0)
            {
                button6.Text = "X";
                global.D = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == true && global.button_disable == false && global.D == 0)
            {
                button6.Text = "O";
                global.D = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.E == 0)
            {
                button5.Text = "X";
                global.E = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == true && global.button_disable == false && global.E == 0)
            {
                button5.Text = "O";
                global.E = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.F == 0)
            {
                button4.Text = "X";
                global.F = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == true && global.button_disable == false && global.F == 0)
            {
                button4.Text = "O";
                global.F = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.G == 0)
            {
                button7.Text = "X";
                global.G = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == true && global.button_disable == false && global.G == 0)
            {
                button7.Text = "O";
                global.G = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.H == 0)
            {
                button8.Text = "X";
                global.H = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn ==true && global.button_disable == false && global.H == 0)
            {
                button8.Text = "O";
                global.H = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (global.turn == false && global.button_disable == false && global.I == 0)
            {
                button9.Text = "X";
                global.I = 1;
                global.ronud++;
                checkingWinner();
                global.turn = true;
            }
            if (global.turn == true && global.button_disable == false && global.I == 0)
            {
                button9.Text = "O";
                global.I = 2;
                global.ronud++;
                checkingWinner();
                global.turn = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.A = 0;
            global.B = 0;
            global.C = 0;
            global.D = 0;
            global.E = 0;
            global.F = 0;
            global.G = 0;
            global.H = 0;
            global.I = 0;
            global.rounds = 0;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            global.button_disable = false;

            if (global.p1 == 1 || global.p1 == 0)
            {
                global.turn = false;
                global.p1 = 0;
            }
            else if (global.p1 == 2)
            {
                global.turn = true;
                global.p1 = 0;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
