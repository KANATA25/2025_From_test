using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Test
{
    internal class TestButton : Button
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

        public TestButton(Point position, Size size, string text)
        {
            Location = position;
            Size = size;
            Text = text;

            SetEmable(false);

            Click += ClickEvent;
            
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            SetEmable(!_enable);
        }

    }
}
