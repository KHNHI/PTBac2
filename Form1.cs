using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTBac2
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtResult.Text = SolveEquation();   
        }
        private string SolveEquation()
        {
            try
            {
                double a = double.Parse(txtNumA.Text);
                double b = double.Parse(txtNumB.Text);
                double c;

                if (double.TryParse(txtNumC.Text, out c)) // Nếu có giá trị C, giải phương trình bậc hai
                {
                   return  EquationSolver.SolveEquation(a, b, c);
                }
                else // Nếu C trống hoặc không hợp lệ, giải phương trình bậc nhất
                {
                    return  EquationSolver.SolveEquation(a, b);
                }
            }
            catch (Exception ex)
            {
                return txtResult.Text = "Lỗi: " + ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumA.Clear();
            txtNumB.Clear();
            txtNumC.Clear();
            txtResult.Text = "";
        }
    }
}
