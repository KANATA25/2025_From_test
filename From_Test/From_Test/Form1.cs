using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Test
{


    public partial class Form1 : Form
    {
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private TestButton[,] _buttonArrey;

        public Form1()
        {


            InitializeComponent();
            _buttonArrey = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int s = 0; s < BOARD_SIZE_Y; s++)
                {
                    TestButton testButton = new TestButton( this, new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * s), new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "押すなよその二");

                    _buttonArrey[s, i] = testButton;
                    //コントロールにボタンの追加
                    Controls.Add(testButton);

                }

            }
            //_buttonArrey[0, 0].SetEmable(true);




        }
        public TestButton GetTestButton(int x, int y)
        {
            return _buttonArrey[y, x];
        }


        private void hogehogeClick(object sender, EventArgs e)
        {
            MessageBox.Show("え、何ですか？");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("押すなって言ったのに。まぁ、別に何にも無いけどね");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
