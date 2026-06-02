using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        // Ticket prices
        private const decimal PRICE_A = 15m;
        private const decimal PRICE_B = 12m;
        private const decimal PRICE_C = 9m;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            // Read input values
            int qtyA = int.Parse(classAinput.Text);
            int qtyB = int.Parse(classBinput.Text);
            int qtyC = int.Parse(classCinput.Text);

            // Calculate revenue
            decimal revenueA = qtyA * PRICE_A;
            decimal revenueB = qtyB * PRICE_B;
            decimal revenueC = qtyC * PRICE_C;

            decimal totalRevenue = revenueA + revenueB + revenueC;

            // Display results
            classAoutput.Text = revenueA.ToString("c");
            classBoutput.Text = revenueB.ToString("c");
            classCoutput.Text = revenueC.ToString("c");
            totalOutput.Text = totalRevenue.ToString("c");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            classAinput.Clear();
            classBinput.Clear();
            classCinput.Clear();

            classAoutput.Text = "";
            classBoutput.Text = "";
            classCoutput.Text = "";
            totalOutput.Text = "";

            classAinput.Focus();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
