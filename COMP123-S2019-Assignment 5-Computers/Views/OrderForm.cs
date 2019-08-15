using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace COMP123_S2019_Assignment_5_Computers.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }



        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Program.orderForm.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
