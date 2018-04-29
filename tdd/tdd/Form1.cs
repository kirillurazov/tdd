using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GameHandler game;
        public void ifVisible(bool visible)
        {
            textBoxName1.Visible = visible;
            textBoxName2.Visible = visible;
            label1.Visible = visible;
            label3.Visible = visible;
            buttonStart.Visible = visible;
            buttonRefresh.Visible = !visible;
            button1.Visible = !visible;
            button2.Visible = !visible;
            button3.Visible = !visible;
            button4.Visible = !visible;
            button5.Visible = !visible;
            button6.Visible = !visible;
            button7.Visible = !visible;
            button8.Visible = !visible;
            button9.Visible = !visible;
            labelTurn.Visible = !visible;
            label4.Visible = !visible;
            label5.Visible = !visible;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ifVisible(true);
        }

        public void start()
        {
            ifVisible(false);
            game = new GameHandler(textBoxName1.Text, textBoxName2.Text);
            labelTurn.Text = "Ходит " + game.player1.getName();
            label4.Text = game.player1.points.ToString();
            label5.Text = game.player2.points.ToString();
        }
        public void refreshPoints()
        {
            label4.Text = game.player1.points.ToString();
            label5.Text = game.player2.points.ToString();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName1.Text) || String.IsNullOrWhiteSpace(textBoxName2.Text))
                return;
            start();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ifVisible(true);
            refreshButtons();
            textBoxName1.Text = "";
            textBoxName2.Text = "";
        }
        public void refreshButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        public void refresh()
        {
            game = new GameHandler(game.player1.getName(), game.player2.getName(), !game.turn, game.player1.points, game.player2.points);
            refreshPoints();
            refreshButtons();
            if(game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button1_click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (game.turn)
            {
                button1.Text = "X";
                game.positionsX[0] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }                    
            }
            else
            {
                button1.Text = "O";
                game.positionsY[0] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button2_click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (game.turn)
            {
                button2.Text = "X";
                game.positionsX[1] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button2.Text = "O";
                game.positionsY[1] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button3_click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (game.turn)
            {
                button3.Text = "X";
                game.positionsX[2] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button3.Text = "O";
                game.positionsY[2] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button4_click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (game.turn)
            {
                button4.Text = "X";
                game.positionsX[3] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button4.Text = "O";
                game.positionsY[3] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button5_click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (game.turn)
            {
                button5.Text = "X";
                game.positionsX[4] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button5.Text = "O";
                game.positionsY[4] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button6_click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (game.turn)
            {
                button6.Text = "X";
                game.positionsX[5] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button6.Text = "O";
                game.positionsY[5] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button7_click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (game.turn)
            {
                button7.Text = "X";
                game.positionsX[6] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button7.Text = "O";
                game.positionsY[6] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;            
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button8_click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (game.turn)
            {
                button8.Text = "X";
                game.positionsX[7] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button8.Text = "O";
                game.positionsY[7] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }

        private void button9_click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (game.turn)
            {
                button9.Text = "X";
                game.positionsX[8] = true;
                if (game.ifWinner(game.positionsX))
                {
                    MessageBox.Show("Победил Игрок 1");
                    game.player1.points++;
                    refresh();
                    return;
                }
            }
            else
            {
                button9.Text = "O";
                game.positionsY[8] = true;
                if (game.ifWinner(game.positionsY))
                {
                    MessageBox.Show("Победил Игрок 2");
                    game.player2.points++;
                    refresh();
                    return;
                }
            }
            if (++game.stroke >= 9)
            {
                MessageBox.Show("Ничья");
                refresh();
                return;
            }
            game.turn = !game.turn;
            if (game.turn)
                labelTurn.Text = "Ходит " + game.player1.getName();
            else
                labelTurn.Text = "Ходит " + game.player2.getName();
        }
    }
}
