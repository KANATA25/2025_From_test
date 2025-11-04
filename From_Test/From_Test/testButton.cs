using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Test
{
    public class TestButton : Button
    {
        /// <summary>
        /// on の時の色
        /// </summary>
        public Color _onColor = Color.GreenYellow;

        /// <summary>
        /// off の時の色
        /// </summary>
        public Color _offColor = Color.Aqua;

        private bool _enable;
        /// <summary>
        /// 
        private Form1 _form1;
        /// <summary>
        /// 横位置 </summary>
        private int _x;
        /// <summary>
        /// 縦位置 </summary> 
        private int _y;


        /// <summary>
        /// onとoffの設定
        /// </summary>
        /// <param name="on"></param>
        public void SetEmable(bool on)
        {
            _enable = on;
           
            if (on)
            {
                BackColor = _onColor;
            }
            else 
            {
                BackColor = _offColor;
            }
        }
       

        public TestButton(Form1 form1, int x, int y, Size size, string text)
        {
            //Formの参照を保管
            _form1 = form1;
            //縦横位置保管
            _x = x;
            _y = y;

            

            Location = new Point(x * size.Width,y * size.Height);
            //ボタンのサイズ設定
            Size = size;
            //ボタンのテキスト設定
            Text = text;

            SetEmable(false);

            Click += ClickEvent;
            
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x,_y).SetEmable(true);
            //ctrl+r2で変数名一喝変更
        }

    }
}
