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

        //This is a event hanlder for OrderForm Activated event.
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            DisplayProductOrder();
        }

        //This is a method for Displaying Product Order.
        private void DisplayProductOrder()
        {

            var ProductSpec = string.Empty;
            ProductSpec = Program.product.screensize + Environment.NewLine + Environment.NewLine +
                Program.product.RAM_size + Environment.NewLine + Environment.NewLine +
                Program.product.CPU_brand + Environment.NewLine + Environment.NewLine +
                Program.product.CPU_type + Environment.NewLine + Environment.NewLine +
                Program.product.CPU_number + Environment.NewLine + Environment.NewLine +
                Program.product.CPU_speed + Environment.NewLine + Environment.NewLine +
                Program.product.HDD_size + Environment.NewLine + Environment.NewLine +
                Program.product.GPU_Type + Environment.NewLine + Environment.NewLine +
                Program.product.webcam + Environment.NewLine + Environment.NewLine +
                Program.product.OS;

            //calculate the price for order.
            double cost = (double)Program.product.cost;
            double tax = cost * 0.13;
            double total = cost + tax;

            //display the order detail
            ProductSpecTextBox.Text = ProductSpec;
            ConditionTextBox.Text = Program.product.condition;
            PriceTextBox.Text = cost.ToString("$###,###.##");
            SalesTaxTextBox.Text = tax.ToString("$###,###.##");
            TatalTextBox.Text = total.ToString("$###,###.##");
            PlatformTextBox.Text = Program.product.platform;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Thank you for your business." + "\n\n" + "Your order will be processed in 7-10 business days.", "Thank You",
MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void OrderPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            //ProductPrintForm.Print();
            MessageBox.Show("The order is printing!", "Printing...",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OrderExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Program.orderForm.Hide();
        }

        private void OrderAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
    }
}
