using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindtheMin_andAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lb_numbers.Items.Add(tb_num1.Text);
            tb_num1.Clear();
            tb_num1.Focus();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            int index;
            index = lb_numbers.SelectedIndex;
            if (index > -1)
                lb_numbers.Items.RemoveAt(index);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_numbers.Items.Clear();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            int min, num2;
            min = 0;
            for (int x=0;x<lb_numbers.Items.Count; x++)
            {
                num2 = int.Parse(lb_numbers.Items[x].ToString());
                if (x == 0)
                    min = num2;
                else if (num2 < min)
                    min = num2;
                
            }
            lb_min1.Text = min.ToString();
        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            double avg, sum;
            avg = 0;
            sum = 0;
            double count = lb_numbers.Items.Count;
            for (int x=0;x< count; x++)
            {
                sum += Convert.ToDouble(lb_numbers.Items[x]);
            }
            avg = sum / count;
            lb_avg.Text = avg.ToString();
        }
    }
}
