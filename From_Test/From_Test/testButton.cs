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

        private Form1 _form1;

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
       

        public TestButton(Form1 form1,Point position, Size size, string text)
        {

            _form1 = form1;

            Location = position;
            Size = size;
            Text = text;

            SetEmable(false);

            Click += ClickEvent;
            
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(1, 2).SetEmable(true);
            //ctrl+r2で変数名一喝変更
        }

    }
}
