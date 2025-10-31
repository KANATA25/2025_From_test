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
            const int BOTTON_SIZE_X = 100;
            const int BOTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        public Form1()
        {


            InitializeComponent();
            for (int i = 1; i <= BOARD_SIZE_X; i++)
            {
                for (int s = 1; s <= BOARD_SIZE_Y; s++)
                {
                    TestButton testButton = new TestButton(new Point(BOTTON_SIZE_X * i, BOTTON_SIZE_Y * s), new Size(BOTTON_SIZE_X, BOTTON_SIZE_Y), "押すなよその二");

               
                    //コントロールにボタンの追加
                    Controls.Add(testButton);

                }

            }





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
