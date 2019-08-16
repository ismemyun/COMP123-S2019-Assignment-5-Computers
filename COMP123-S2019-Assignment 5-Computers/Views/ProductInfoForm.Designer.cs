namespace COMP123_S2019_Assignment_5_Computers.Views
{
    partial class ProductInfoForm
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
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProduectInfoExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WabcamTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.CPUspeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUnumberTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.WabcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUspeedLabel = new System.Windows.Forms.Label();
            this.CPUnumberLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUTpyeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ConfirmSelectionLabel = new System.Windows.Forms.Label();
            this.SelectAnotherButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(884, 25);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductInfoOpenToolStripMenuItem,
            this.ProductInfoSaveToolStripMenuItem,
            this.ProduectInfoExitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ProductInfoOpenToolStripMenuItem
            // 
            this.ProductInfoOpenToolStripMenuItem.Name = "ProductInfoOpenToolStripMenuItem";
            this.ProductInfoOpenToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ProductInfoOpenToolStripMenuItem.Text = "&Open";
            this.ProductInfoOpenToolStripMenuItem.Click += new System.EventHandler(this.ProductInfoOpenToolStripMenuItem_Click);
            // 
            // ProductInfoSaveToolStripMenuItem
            // 
            this.ProductInfoSaveToolStripMenuItem.Name = "ProductInfoSaveToolStripMenuItem";
            this.ProductInfoSaveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ProductInfoSaveToolStripMenuItem.Text = "&Save";
            this.ProductInfoSaveToolStripMenuItem.Click += new System.EventHandler(this.ProductInfoSaveToolStripMenuItem_Click);
            // 
            // ProduectInfoExitToolStripMenuItem
            // 
            this.ProduectInfoExitToolStripMenuItem.Name = "ProduectInfoExitToolStripMenuItem";
            this.ProduectInfoExitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ProduectInfoExitToolStripMenuItem.Text = "&Exit";
            this.ProduectInfoExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // SelectAnotherProductToolStripMenuItem
            // 
            this.SelectAnotherProductToolStripMenuItem.Name = "SelectAnotherProductToolStripMenuItem";
            this.SelectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.SelectAnotherProductToolStripMenuItem.Text = "&Select Another Product";
            this.SelectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductToolStripMenuItem_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Location = new System.Drawing.Point(64, 62);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(95, 18);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(23, 107);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(830, 153);
            this.ProductInfoGroupBox.TabIndex = 2;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(388, 95);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(430, 27);
            this.ModelTextBox.TabIndex = 3;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(388, 42);
            this.OSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(430, 27);
            this.OSTextBox.TabIndex = 3;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(139, 95);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(124, 27);
            this.ManufacturerTextBox.TabIndex = 3;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(139, 42);
            this.PlatformTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(124, 27);
            this.PlatformTextBox.TabIndex = 3;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(324, 101);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(56, 18);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(347, 45);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(33, 18);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(19, 101);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(117, 18);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(58, 45);
            this.PlatformLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(78, 18);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(162, 59);
            this.ProductIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(124, 27);
            this.ProductIDTextBox.TabIndex = 3;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(316, 62);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(91, 18);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(411, 59);
            this.ConditionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(124, 27);
            this.ConditionTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(565, 62);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(45, 18);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(618, 59);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(124, 27);
            this.CostTextBox.TabIndex = 3;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WabcamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUspeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUnumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WabcamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUspeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUnumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTpyeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(23, 276);
            this.TechSpecsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(830, 211);
            this.TechSpecsGroupBox.TabIndex = 2;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WabcamTextBox
            // 
            this.WabcamTextBox.Location = new System.Drawing.Point(619, 147);
            this.WabcamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WabcamTextBox.Name = "WabcamTextBox";
            this.WabcamTextBox.ReadOnly = true;
            this.WabcamTextBox.Size = new System.Drawing.Size(199, 27);
            this.WabcamTextBox.TabIndex = 3;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Location = new System.Drawing.Point(619, 95);
            this.GPUTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(199, 27);
            this.GPUTypeTextBox.TabIndex = 3;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(619, 42);
            this.HDDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(199, 27);
            this.HDDTextBox.TabIndex = 3;
            // 
            // CPUspeedTextBox
            // 
            this.CPUspeedTextBox.Location = new System.Drawing.Point(393, 147);
            this.CPUspeedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CPUspeedTextBox.Name = "CPUspeedTextBox";
            this.CPUspeedTextBox.ReadOnly = true;
            this.CPUspeedTextBox.Size = new System.Drawing.Size(124, 27);
            this.CPUspeedTextBox.TabIndex = 3;
            // 
            // CPUnumberTextBox
            // 
            this.CPUnumberTextBox.Location = new System.Drawing.Point(393, 95);
            this.CPUnumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CPUnumberTextBox.Name = "CPUnumberTextBox";
            this.CPUnumberTextBox.ReadOnly = true;
            this.CPUnumberTextBox.Size = new System.Drawing.Size(124, 27);
            this.CPUnumberTextBox.TabIndex = 3;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Location = new System.Drawing.Point(393, 42);
            this.LCDSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(124, 27);
            this.LCDSizeTextBox.TabIndex = 3;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Location = new System.Drawing.Point(139, 147);
            this.CPUTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(124, 27);
            this.CPUTypeTextBox.TabIndex = 3;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(139, 95);
            this.CPUBrandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(124, 27);
            this.CPUBrandTextBox.TabIndex = 3;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(139, 42);
            this.MemoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(124, 27);
            this.MemoryTextBox.TabIndex = 3;
            // 
            // WabcamLabel
            // 
            this.WabcamLabel.Location = new System.Drawing.Point(539, 153);
            this.WabcamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WabcamLabel.Name = "WabcamLabel";
            this.WabcamLabel.Size = new System.Drawing.Size(78, 18);
            this.WabcamLabel.TabIndex = 1;
            this.WabcamLabel.Text = "Wabcam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Location = new System.Drawing.Point(530, 101);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(88, 18);
            this.GPUTypeLabel.TabIndex = 1;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // CPUspeedLabel
            // 
            this.CPUspeedLabel.Location = new System.Drawing.Point(292, 153);
            this.CPUspeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUspeedLabel.Name = "CPUspeedLabel";
            this.CPUspeedLabel.Size = new System.Drawing.Size(96, 18);
            this.CPUspeedLabel.TabIndex = 1;
            this.CPUspeedLabel.Text = "CPU speed";
            // 
            // CPUnumberLabel
            // 
            this.CPUnumberLabel.Location = new System.Drawing.Point(278, 101);
            this.CPUnumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUnumberLabel.Name = "CPUnumberLabel";
            this.CPUnumberLabel.Size = new System.Drawing.Size(111, 18);
            this.CPUnumberLabel.TabIndex = 1;
            this.CPUnumberLabel.Text = "CPU number";
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(570, 45);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(47, 18);
            this.HDDLabel.TabIndex = 1;
            this.HDDLabel.Text = "HDD";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(307, 45);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(82, 18);
            this.LCDSizeLabel.TabIndex = 1;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUTpyeLabel
            // 
            this.CPUTpyeLabel.Location = new System.Drawing.Point(47, 153);
            this.CPUTpyeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUTpyeLabel.Name = "CPUTpyeLabel";
            this.CPUTpyeLabel.Size = new System.Drawing.Size(89, 18);
            this.CPUTpyeLabel.TabIndex = 1;
            this.CPUTpyeLabel.Text = "CPU Tpye";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(35, 101);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(98, 18);
            this.CPUBrandLabel.TabIndex = 1;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(58, 45);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(78, 18);
            this.MemoryLabel.TabIndex = 1;
            this.MemoryLabel.Text = "Memory";
            // 
            // ConfirmSelectionLabel
            // 
            this.ConfirmSelectionLabel.AutoSize = true;
            this.ConfirmSelectionLabel.Location = new System.Drawing.Point(20, 513);
            this.ConfirmSelectionLabel.Name = "ConfirmSelectionLabel";
            this.ConfirmSelectionLabel.Size = new System.Drawing.Size(305, 18);
            this.ConfirmSelectionLabel.TabIndex = 4;
            this.ConfirmSelectionLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // SelectAnotherButton
            // 
            this.SelectAnotherButton.Location = new System.Drawing.Point(491, 503);
            this.SelectAnotherButton.Name = "SelectAnotherButton";
            this.SelectAnotherButton.Size = new System.Drawing.Size(202, 35);
            this.SelectAnotherButton.TabIndex = 5;
            this.SelectAnotherButton.Text = "Select Anothe Product";
            this.SelectAnotherButton.UseVisualStyleBackColor = true;
            this.SelectAnotherButton.Click += new System.EventHandler(this.SelectAnotherProductToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(714, 503);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 35);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(795, 503);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 35);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoOpenFileDialog
            // 
            this.ProductInfoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherButton);
            this.Controls.Add(this.ConfirmSelectionLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductInfoOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductInfoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProduectInfoExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox CPUnumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.Label CPUnumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.TextBox WabcamTextBox;
        private System.Windows.Forms.TextBox CPUspeedTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label WabcamLabel;
        private System.Windows.Forms.Label CPUspeedLabel;
        private System.Windows.Forms.Label CPUTpyeLabel;
        private System.Windows.Forms.Label ConfirmSelectionLabel;
        private System.Windows.Forms.Button SelectAnotherButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductInfoSaveFileDialog;
    }
}