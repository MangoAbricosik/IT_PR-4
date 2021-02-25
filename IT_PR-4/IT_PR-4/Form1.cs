using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_PR_4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      double n = Convert.ToDouble(textBox1.Text);
      double eps = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы. Сделал Гвоздков Е.Д." + Environment.NewLine;
      int m = 0;
      if (radioButton2.Checked) m = 1;
      double s = 0, p = 1, ch;
      double i = 1;
      switch (m)
      {
        case 0:
          ch = (1/2*i + Fact(i));
          while (ch>=eps)
          {
            ch = (1 / 2 * i + Fact(i));
            s += ch;
            i++;
          }
          textBox2.Text += "При esp = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
          break;
        case 1:
          for (i = 1; i <= n; i++)
          {
            ch = (Math.Sqrt(Fact(i)) + 8*i)/(3*i-2);
            p *= ch;
            textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine;
            textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine; 
          }
          break;
      }
        }
    public double Fact(double n)
    {
     if (n == 0)
      {
        return 1;
      }
      else
      {
       return n*Fact(n - 1);
      }

    }
    }
}
