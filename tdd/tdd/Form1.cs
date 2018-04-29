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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ifVisible(true);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ifVisible(false);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ifVisible(true);
        }
    }
}
