using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarionTimeConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertDate()
        {
            if (string.IsNullOrEmpty(gDate.Text) == false && string.IsNullOrEmpty(cDate.Text) == false)
            {
                MessageBox.Show("두 날짜 중 하나만 입력되어야 합니다.");
                return;
            }

            if (string.IsNullOrEmpty(gDate.Text) && string.IsNullOrEmpty(cDate.Text))
            {
                MessageBox.Show("두 날짜 중 하나는 반드시 입력되어야 합니다.");
                return;
            }

            gDate.EditValueChanging -= gDate_EditValueChanging;
            cDate.EditValueChanging -= cDate_EditValueChanging;

            if (string.IsNullOrEmpty(gDate.Text) && string.IsNullOrEmpty(cDate.Text) == false)
            {//클라리온을 일반날짜로
                int intTemp = 0;
                int.TryParse(cDate.Text, out intTemp);
                if (intTemp == 0)
                {
                    MessageBox.Show("클라리온 날짜는 숫자만 입력하세요");
                }
                else
                {
                    DateTime temp = new DateTime(1800, 12, 28).AddDays(Convert.ToInt64(cDate.Text));
                    gDate.DateTime = temp;
                }
            }
            else if (string.IsNullOrEmpty(gDate.Text) == false && string.IsNullOrEmpty(cDate.Text))
            {//일반날짜를 클라리온으로
                DateTime cldate = new DateTime(1800, 12, 28);
                cDate.Text = Math.Abs((gDate.DateTime - cldate).TotalDays).ToString();
            }

            gDate.EditValueChanging += gDate_EditValueChanging;
            cDate.EditValueChanging += cDate_EditValueChanging;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gDate.EditValueChanging -= gDate_EditValueChanging;
            gDate.Text = "";
            gDate.EditValueChanging += gDate_EditValueChanging;
        }

        private void gDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            cDate.EditValueChanging -= cDate_EditValueChanging;
            cDate.Text = "";
            cDate.EditValueChanging += cDate_EditValueChanging;
        }

        bool 키다운 = false;
        private void cDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                키다운 = true;
                ConvertDate();
                키다운 = false;
            }
        }

        private void gDate_DateTimeChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gDate.Text))
                return;
            if (키다운)
                return;
            ConvertDate();
        }

    }
}
