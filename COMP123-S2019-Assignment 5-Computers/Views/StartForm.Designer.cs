namespace COMP123_S2019_Assignment_5_Computers.Views
{
    partial class StartForm
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
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderComputerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.Font = new System.Drawing.Font("Verdana", 20F);
            this.StartOrderButton.Location = new System.Drawing.Point(29, 261);
            this.StartOrderButton.Margin = new System.Windows.Forms.Padding(7);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(328, 50);
            this.StartOrderButton.TabIndex = 0;
            this.StartOrderButton.Text = "start a new order";
            this.StartOrderButton.UseVisualStyleBackColor = true;
            this.StartOrderButton.Click += new System.EventHandler(this.StartOrderButton_Click);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.Font = new System.Drawing.Font("Verdana", 20F);
            this.LoadOrderButton.Location = new System.Drawing.Point(29, 325);
            this.LoadOrderButton.Margin = new System.Windows.Forms.Padding(7);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(328, 50);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "load a saved order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            this.LoadOrderButton.Click += new System.EventHandler(this.LoadOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 20F);
            this.ExitButton.Location = new System.Drawing.Point(29, 389);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(328, 50);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit the program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP123_S2019_Assignment_5_Computers.Properties.Resources.computer_logo21;
            this.LogoPictureBox.Location = new System.Drawing.Point(95, 72);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(7);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(191, 186);
            this.LogoPictureBox.TabIndex = 2;
            this.LogoPictureBox.TabStop = false;
            // 
            // OrderComputerLabel
            // 
            this.OrderComputerLabel.AutoSize = true;
            this.OrderComputerLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComputerLabel.Location = new System.Drawing.Point(35, 29);
            this.OrderComputerLabel.Name = "OrderComputerLabel";
            this.OrderComputerLabel.Size = new System.Drawing.Size(307, 32);
            this.OrderComputerLabel.TabIndex = 3;
            this.OrderComputerLabel.Text = "Order Your Computer";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.OrderComputerLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.StartOrderButton);
            this.Font = new System.Drawing.Font("新細明體", 20F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to FiY";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label OrderComputerLabel;
    }
}