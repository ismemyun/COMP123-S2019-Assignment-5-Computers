using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_5_Computers.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void SelectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //OpenFileDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Program.selectForm.Hide();
        }

        private void ProductInfoOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }
        private void OpenFileDialog()
        {
            //configure the file dialog
            ProduecInfoOpenFileDialog.FileName = "Product.txt";
            ProduecInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProduecInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //open the file dialog
            var result = ProduecInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open the stream for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProduecInfoOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Program.student.id = int.Parse(inputStream.ReadLine());
                        //Program.student.StudentID = inputStream.ReadLine();
                        //Program.student.FirstName = inputStream.ReadLine();
                        //Program.student.LastName = inputStream.ReadLine();

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                    //ShowDataButton_Click(sender, e);
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR:" + exception.Message);
                    MessageBox.Show("ERROR" + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.product.productID.ToString();
            ConditionTextBox.Text = Program.product.condition;
            CostTextBox.Text = Program.product.cost.ToString();
            PlatformTextBox.Text = Program.product.platform;
            OSTextBox.Text = Program.product.OS;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;
            MemoryTextBox.Text = Program.product.RAM_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            LCDSizeTextBox.Text = Program.product.screensize;
            CPUnumberTextBox.Text = Program.product.CPU_number;
            CPUspeedTextBox.Text = Program.product.CPU_speed;
            HDDTextBox.Text = Program.product.HDD_size;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            WabcamTextBox.Text = Program.product.webcam;
        }
    }
}
