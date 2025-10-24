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
        public Form1()
        {

           
            InitializeComponent();
            for (int i = 1; i<= 6; i++)
            {
                for (int s = 1; s <= 4; s++)
                {
                    TestButton testButton = new TestButton();

                    //ボタンの位置
                    testButton.Location = new Point(100 * i, 50 * s);


                    //サイズ設定
                    testButton.Size = new Size(100, 100);

                    testButton.Text = "押すなよその二";

                    //コントロールにボタンの追加
                    Controls.Add(testButton);

                }

            }
            
            



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
