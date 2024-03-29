﻿using COMP123_S2019_Assignment_5_Computers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name : Chuyun Yang
 * Student : 301038102
 * Date : 2019/08/02
 * Description : This is a selectform for listing products.
 */
namespace COMP123_S2019_Assignment_5_Computers.Views
{
    public partial class SelectForm : Form
    {            
        public SelectForm()
        {
            InitializeComponent();
        }

        //This is a event handler for SelectForm Load event.
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList(); 
            }
            //select nothing as defalut
            var rows = ProductDataGridView.Rows;
            rows[0].Selected = true;
            //NextButton is desabled before selecting a product.
            NextButton.Enabled = false;
        }

        //This is a event handler for CancelButton Click event.
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //This is a event handler for NextButton Click event.
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
        

        //This is a event handler for ProductDataGridView SelectionChanged event.
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectProduct();
            NextButton.Enabled = true;
        }
        //This is a method for displaying the selection of product.
        private void SelectProduct()
        {
            //local scope aliases
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            string outputString = string.Empty;

            outputString = cells[(int)ProductField.MANUFACTURER].Value.ToString() +
                           " " +
                           cells[(int)ProductField.MODEL].Value.ToString() +
                           " Priced at: " +
                           decimal.Parse(cells[(int)ProductField.COST].Value.ToString()).ToString("$###,###.##");

            SelectionTextBox.Text = outputString;

            // assign value to product class.
            Program.product.productID = short.Parse(cells[(int)ProductField.PRODUCT_ID].Value.ToString());
            Program.product.condition = cells[(int)ProductField.CONDITION].Value.ToString();
            Program.product.cost = decimal.Parse(cells[(int)ProductField.COST].Value.ToString());
            Program.product.platform = cells[(int)ProductField.PLATFORM].Value.ToString();
            Program.product.OS = cells[(int)ProductField.OS].Value.ToString();
            Program.product.manufacturer = cells[(int)ProductField.MANUFACTURER].Value.ToString();
            Program.product.model = cells[(int)ProductField.MODEL].Value.ToString();
            Program.product.RAM_size = cells[(int)ProductField.RAM_SIZE].Value.ToString();
            Program.product.CPU_brand = cells[(int)ProductField.CPU_BRAND].Value.ToString();
            Program.product.CPU_type = cells[(int)ProductField.CPU_TYPE].Value.ToString();
            Program.product.screensize = cells[(int)ProductField.SCREENSIZE].Value.ToString();
            Program.product.CPU_number = cells[(int)ProductField.CPU_NUMBER].Value.ToString();
            Program.product.CPU_speed = cells[(int)ProductField.CPU_SPEED].Value.ToString();
            Program.product.HDD_size = cells[(int)ProductField.HDD_SIZE].Value.ToString();
            Program.product.GPU_Type = cells[(int)ProductField.GPU_TYPE].Value.ToString();
            Program.product.webcam = cells[(int)ProductField.WEBCAM].Value.ToString();

            Program.product.RAM_type = cells[(int)ProductField.RAM_TYPE].Value.ToString();
            Program.product.displaytype = cells[(int)ProductField.DISPLAYTYPE].Value.ToString();
            Program.product.resolution = cells[(int)ProductField.RESOLUTION].Value.ToString();
            Program.product.CPU_Class = cells[(int)ProductField.CPU_CLASS].Value.ToString();
            Program.product.HDD_speed = cells[(int)ProductField.HDD_SPEED].Value.ToString();
            Program.product.optical_drive = cells[(int)ProductField.OPTICAL_DRIVE].Value.ToString();
            Program.product.Audio_type = cells[(int)ProductField.AUDIO_TYPE].Value.ToString();
            Program.product.LAN = cells[(int)ProductField.LAN].Value.ToString();
            Program.product.WIFI = cells[(int)ProductField.WIFI].Value.ToString();
            Program.product.weight = cells[(int)ProductField.WEIGHT].Value.ToString();
            Program.product.height = cells[(int)ProductField.HEIGHT].Value.ToString();
            Program.product.depth = cells[(int)ProductField.DEPTH].Value.ToString();
            Program.product.width = cells[(int)ProductField.WIDTH].Value.ToString();
            Program.product.moust_type = cells[(int)ProductField.MOUST_TYPE].Value.ToString();
            Program.product.power = cells[(int)ProductField.POWER].Value.ToString();

        }

        
    }
}
