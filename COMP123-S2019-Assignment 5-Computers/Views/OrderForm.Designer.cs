namespace COMP123_S2019_Assignment_5_Computers.Views
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BackButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.WabcamLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUspeedLabel = new System.Windows.Forms.Label();
            this.CPUnumberLabel = new System.Windows.Forms.Label();
            this.CPUTpyeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TatalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.YourPriceGroupBox.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.OrderMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "&FIle";
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.backToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 5;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 5;
            this.TotalLine.X2 = 333;
            this.TotalLine.Y1 = 107;
            this.TotalLine.Y2 = 107;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.BackButton.Location = new System.Drawing.Point(7, 16);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(95, 41);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.textBox1);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WabcamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUspeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUnumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTpyeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(20, 41);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(385, 494);
            this.SystemComponentsGroupBox.TabIndex = 6;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 351);
            this.textBox1.TabIndex = 13;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(78, 456);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(30, 18);
            this.OSLabel.TabIndex = 12;
            this.OSLabel.Text = "OS";
            // 
            // WabcamLabel
            // 
            this.WabcamLabel.Location = new System.Drawing.Point(41, 420);
            this.WabcamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WabcamLabel.Name = "WabcamLabel";
            this.WabcamLabel.Size = new System.Drawing.Size(67, 18);
            this.WabcamLabel.TabIndex = 11;
            this.WabcamLabel.Text = "Wabcam";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(33, 383);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(75, 18);
            this.CPUTypeLabel.TabIndex = 10;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(68, 350);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(40, 18);
            this.HDDLabel.TabIndex = 9;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUspeedLabel
            // 
            this.CPUspeedLabel.Location = new System.Drawing.Point(24, 312);
            this.CPUspeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUspeedLabel.Name = "CPUspeedLabel";
            this.CPUspeedLabel.Size = new System.Drawing.Size(84, 18);
            this.CPUspeedLabel.TabIndex = 8;
            this.CPUspeedLabel.Text = "CPU speed";
            // 
            // CPUnumberLabel
            // 
            this.CPUnumberLabel.Location = new System.Drawing.Point(11, 276);
            this.CPUnumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUnumberLabel.Name = "CPUnumberLabel";
            this.CPUnumberLabel.Size = new System.Drawing.Size(97, 18);
            this.CPUnumberLabel.TabIndex = 7;
            this.CPUnumberLabel.Text = "CPU number";
            // 
            // CPUTpyeLabel
            // 
            this.CPUTpyeLabel.Location = new System.Drawing.Point(31, 237);
            this.CPUTpyeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUTpyeLabel.Name = "CPUTpyeLabel";
            this.CPUTpyeLabel.Size = new System.Drawing.Size(77, 18);
            this.CPUTpyeLabel.TabIndex = 6;
            this.CPUTpyeLabel.Text = "CPU Tpye";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(25, 200);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(83, 18);
            this.CPUBrandLabel.TabIndex = 5;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(45, 166);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(63, 18);
            this.MemoryLabel.TabIndex = 4;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(36, 133);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(72, 18);
            this.LCDSizeLabel.TabIndex = 3;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(277, 73);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(80, 24);
            this.ModelTextBox.TabIndex = 2;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(277, 36);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(80, 24);
            this.PlatformTextBox.TabIndex = 2;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(108, 73);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(80, 24);
            this.ManufacturerTextBox.TabIndex = 2;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(108, 36);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(80, 24);
            this.ConditionTextBox.TabIndex = 2;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(225, 76);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(48, 17);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(193, 39);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(66, 17);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(8, 76);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(100, 17);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(33, 39);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(75, 17);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.Location = new System.Drawing.Point(432, 51);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(183, 141);
            this.ComputerPictureBox.TabIndex = 7;
            this.ComputerPictureBox.TabStop = false;
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TatalTextBox);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourPriceGroupBox.Controls.Add(this.PriceTextBox);
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Controls.Add(this.shapeContainer2);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(429, 212);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(352, 197);
            this.YourPriceGroupBox.TabIndex = 8;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // TatalTextBox
            // 
            this.TatalTextBox.Location = new System.Drawing.Point(198, 149);
            this.TatalTextBox.Name = "TatalTextBox";
            this.TatalTextBox.ReadOnly = true;
            this.TatalTextBox.Size = new System.Drawing.Size(139, 24);
            this.TatalTextBox.TabIndex = 2;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(198, 81);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(139, 24);
            this.SalesTaxTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(198, 46);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(139, 24);
            this.PriceTextBox.TabIndex = 2;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(6, 152);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(41, 17);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(6, 84);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(119, 17);
            this.SalesTaxLabel.TabIndex = 0;
            this.SalesTaxLabel.Text = "Sales Tax(13%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(6, 49);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(40, 17);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 20);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer2.Size = new System.Drawing.Size(346, 174);
            this.shapeContainer2.TabIndex = 1;
            this.shapeContainer2.TabStop = false;
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.Controls.Add(this.FinishButton);
            this.ButtonGroupBox.Controls.Add(this.button1);
            this.ButtonGroupBox.Controls.Add(this.BackButton);
            this.ButtonGroupBox.Location = new System.Drawing.Point(429, 467);
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.Size = new System.Drawing.Size(344, 68);
            this.ButtonGroupBox.TabIndex = 9;
            this.ButtonGroupBox.TabStop = false;
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.FinishButton.Location = new System.Drawing.Point(237, 16);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(95, 41);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10F);
            this.button1.Location = new System.Drawing.Point(122, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonGroupBox);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderMenuStrip);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTpyeLabel;
        private System.Windows.Forms.Label CPUnumberLabel;
        private System.Windows.Forms.Label CPUspeedLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label WabcamLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TatalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}