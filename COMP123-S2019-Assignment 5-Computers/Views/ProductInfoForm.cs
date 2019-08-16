﻿using System;
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
            //OpenFileDialog(sender,e);
        }
        private void OpenFileDialog()
        {
            //configure the file dialog
            ProductInfoOpenFileDialog.FileName = "Product.txt";
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //open the file dialog
            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open the stream for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Open)))
                    {

                        Program.product.productID=short.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                    //NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR:" + exception.Message);
                    MessageBox.Show("ERROR" + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            DisplayProductInfo();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            DisplayProductInfo();
        }

        private void DisplayProductInfo()
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

        private void ProductInfoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            ProductInfoSaveFileDialog.FileName = "Product.txt";
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //open the file dialog
            var result = ProductInfoSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open a stream to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductInfoSaveFileDialog.FileName, FileMode.Create)))

                {
                    //write stuff to the file
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.webcam);


                    //cleeanup
                    outputStream.Close();
                    outputStream.Dispose();

                }
                MessageBox.Show("File Saved SuccessFully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
