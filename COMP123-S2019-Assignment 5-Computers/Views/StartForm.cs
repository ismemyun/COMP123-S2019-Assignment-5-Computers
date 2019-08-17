using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name : Chuyun Yang
 * Student : 301038102
 * Date : 2019/08/02
 * Description : This is a StartForm for entering the system.
 */
namespace COMP123_S2019_Assignment_5_Computers.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //This is a event handler for ExitButton Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is a event StartOrderButton Click event.
        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        //This is a event for LoadOrderButton Click event.
        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
            Program.productInfoForm.OpenFileDialog();
            

        }
    }
}
