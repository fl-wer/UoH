namespace UoH
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.errorIndicator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceAddressTextBox = new System.Windows.Forms.TextBox();
            this.minusAddressTextBox = new System.Windows.Forms.TextBox();
            this.rangeTextBox = new System.Windows.Forms.TextBox();
            this.plusAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // errorIndicator
            // 
            this.errorIndicator.BackColor = System.Drawing.Color.LimeGreen;
            this.errorIndicator.Location = new System.Drawing.Point(12, 40);
            this.errorIndicator.Name = "errorIndicator";
            this.errorIndicator.Size = new System.Drawing.Size(201, 15);
            this.errorIndicator.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Range";
            // 
            // sourceAddressTextBox
            // 
            this.sourceAddressTextBox.Location = new System.Drawing.Point(12, 12);
            this.sourceAddressTextBox.Name = "sourceAddressTextBox";
            this.sourceAddressTextBox.Size = new System.Drawing.Size(201, 20);
            this.sourceAddressTextBox.TabIndex = 15;
            this.sourceAddressTextBox.TextChanged += new System.EventHandler(this.sourceAddressTextBox_TextChanged);
            // 
            // minusAddressTextBox
            // 
            this.minusAddressTextBox.Location = new System.Drawing.Point(12, 65);
            this.minusAddressTextBox.Name = "minusAddressTextBox";
            this.minusAddressTextBox.ReadOnly = true;
            this.minusAddressTextBox.Size = new System.Drawing.Size(201, 20);
            this.minusAddressTextBox.TabIndex = 14;
            this.minusAddressTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusAddressTextBox_MouseDown);
            // 
            // rangeTextBox
            // 
            this.rangeTextBox.Location = new System.Drawing.Point(113, 116);
            this.rangeTextBox.Name = "rangeTextBox";
            this.rangeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rangeTextBox.TabIndex = 13;
            this.rangeTextBox.Text = "1000";
            this.rangeTextBox.TextChanged += new System.EventHandler(this.sourceAddressTextBox_TextChanged);
            // 
            // plusAddressTextBox
            // 
            this.plusAddressTextBox.Location = new System.Drawing.Point(12, 90);
            this.plusAddressTextBox.Name = "plusAddressTextBox";
            this.plusAddressTextBox.ReadOnly = true;
            this.plusAddressTextBox.Size = new System.Drawing.Size(201, 20);
            this.plusAddressTextBox.TabIndex = 12;
            this.plusAddressTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusAddressTextBox_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 148);
            this.Controls.Add(this.errorIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceAddressTextBox);
            this.Controls.Add(this.minusAddressTextBox);
            this.Controls.Add(this.rangeTextBox);
            this.Controls.Add(this.plusAddressTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UoH";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceAddressTextBox;
        private System.Windows.Forms.TextBox minusAddressTextBox;
        private System.Windows.Forms.TextBox rangeTextBox;
        private System.Windows.Forms.TextBox plusAddressTextBox;
    }
}

