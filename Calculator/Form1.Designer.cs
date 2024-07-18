namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Seven = new Button();
            TextBox = new TextBox();
            Eight = new Button();
            Nine = new Button();
            Divide = new Button();
            Multiply = new Button();
            Six = new Button();
            Five = new Button();
            Four = new Button();
            Subtract = new Button();
            Three = new Button();
            Two = new Button();
            One = new Button();
            Add = new Button();
            Clear = new Button();
            Decimal = new Button();
            Zero = new Button();
            Equal = new Button();
            SuspendLayout();
            // 
            // Seven
            // 
            Seven.BackColor = SystemColors.ControlDark;
            Seven.Font = new Font("Segoe UI", 20F);
            Seven.ForeColor = SystemColors.ButtonHighlight;
            Seven.Location = new Point(12, 132);
            Seven.Name = "Seven";
            Seven.Size = new Size(152, 92);
            Seven.TabIndex = 1;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += Seven_Click;
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 40F);
            TextBox.Location = new Point(12, 12);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(648, 103);
            TextBox.TabIndex = 2;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // Eight
            // 
            Eight.BackColor = SystemColors.ControlDark;
            Eight.Font = new Font("Segoe UI", 20F);
            Eight.ForeColor = SystemColors.ButtonFace;
            Eight.Location = new Point(170, 132);
            Eight.Name = "Eight";
            Eight.Size = new Size(152, 92);
            Eight.TabIndex = 3;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.BackColor = SystemColors.ControlDark;
            Nine.Font = new Font("Segoe UI", 20F);
            Nine.ForeColor = SystemColors.ButtonFace;
            Nine.Location = new Point(328, 132);
            Nine.Name = "Nine";
            Nine.Size = new Size(152, 92);
            Nine.TabIndex = 4;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = false;
            Nine.Click += Nine_Click;
            // 
            // Divide
            // 
            Divide.BackColor = SystemColors.ControlDark;
            Divide.Font = new Font("Segoe UI", 20F);
            Divide.ForeColor = Color.Lime;
            Divide.Location = new Point(508, 132);
            Divide.Name = "Divide";
            Divide.Size = new Size(152, 92);
            Divide.TabIndex = 5;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = SystemColors.ControlDark;
            Multiply.Font = new Font("Segoe UI", 20F);
            Multiply.ForeColor = Color.Lime;
            Multiply.Location = new Point(508, 256);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(152, 92);
            Multiply.TabIndex = 9;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Click;
            // 
            // Six
            // 
            Six.BackColor = SystemColors.ControlDark;
            Six.Font = new Font("Segoe UI", 20F);
            Six.ForeColor = SystemColors.ButtonFace;
            Six.Location = new Point(328, 256);
            Six.Name = "Six";
            Six.Size = new Size(152, 92);
            Six.TabIndex = 8;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = false;
            Six.Click += Six_Click;
            // 
            // Five
            // 
            Five.BackColor = SystemColors.ControlDark;
            Five.Font = new Font("Segoe UI", 20F);
            Five.ForeColor = SystemColors.ButtonFace;
            Five.Location = new Point(170, 256);
            Five.Name = "Five";
            Five.Size = new Size(152, 92);
            Five.TabIndex = 7;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = false;
            Five.Click += Five_Click;
            // 
            // Four
            // 
            Four.BackColor = SystemColors.ControlDark;
            Four.Font = new Font("Segoe UI", 20F);
            Four.ForeColor = SystemColors.ButtonFace;
            Four.Location = new Point(12, 256);
            Four.Name = "Four";
            Four.Size = new Size(152, 92);
            Four.TabIndex = 6;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = false;
            Four.Click += Four_Click;
            // 
            // Subtract
            // 
            Subtract.BackColor = SystemColors.ControlDark;
            Subtract.Font = new Font("Segoe UI", 20F);
            Subtract.ForeColor = Color.Lime;
            Subtract.Location = new Point(508, 384);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(152, 92);
            Subtract.TabIndex = 13;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += Subtract_Click;
            // 
            // Three
            // 
            Three.BackColor = SystemColors.ControlDark;
            Three.Font = new Font("Segoe UI", 20F);
            Three.ForeColor = SystemColors.ButtonFace;
            Three.Location = new Point(328, 384);
            Three.Name = "Three";
            Three.Size = new Size(152, 92);
            Three.TabIndex = 12;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = false;
            Three.Click += Three_Click;
            // 
            // Two
            // 
            Two.BackColor = SystemColors.ControlDark;
            Two.Font = new Font("Segoe UI", 20F);
            Two.ForeColor = SystemColors.ButtonFace;
            Two.Location = new Point(170, 384);
            Two.Name = "Two";
            Two.Size = new Size(152, 92);
            Two.TabIndex = 11;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = false;
            Two.Click += Two_Click;
            // 
            // One
            // 
            One.BackColor = SystemColors.ControlDark;
            One.Font = new Font("Segoe UI", 20F);
            One.ForeColor = SystemColors.ButtonFace;
            One.Location = new Point(12, 384);
            One.Name = "One";
            One.Size = new Size(152, 92);
            One.TabIndex = 10;
            One.Text = "1";
            One.UseVisualStyleBackColor = false;
            One.Click += One_Click;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ControlDark;
            Add.Font = new Font("Segoe UI", 20F);
            Add.ForeColor = Color.Lime;
            Add.Location = new Point(508, 508);
            Add.Name = "Add";
            Add.Size = new Size(152, 92);
            Add.TabIndex = 17;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ControlDark;
            Clear.Font = new Font("Segoe UI", 20F);
            Clear.ForeColor = Color.Red;
            Clear.Location = new Point(328, 508);
            Clear.Name = "Clear";
            Clear.Size = new Size(152, 92);
            Clear.TabIndex = 16;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Decimal
            // 
            Decimal.BackColor = SystemColors.ControlDark;
            Decimal.Font = new Font("Segoe UI", 20F);
            Decimal.ForeColor = SystemColors.ButtonHighlight;
            Decimal.Location = new Point(170, 508);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(152, 92);
            Decimal.TabIndex = 15;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = false;
            Decimal.Click += Decimal_Click;
            // 
            // Zero
            // 
            Zero.BackColor = SystemColors.ControlDark;
            Zero.Font = new Font("Segoe UI", 20F);
            Zero.ForeColor = SystemColors.ButtonFace;
            Zero.Location = new Point(12, 508);
            Zero.Name = "Zero";
            Zero.Size = new Size(152, 92);
            Zero.TabIndex = 14;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = false;
            Zero.Click += Zero_Click;
            // 
            // Equal
            // 
            Equal.BackColor = Color.FromArgb(0, 192, 0);
            Equal.Font = new Font("Segoe UI", 20F);
            Equal.Location = new Point(12, 635);
            Equal.Name = "Equal";
            Equal.Size = new Size(648, 92);
            Equal.TabIndex = 18;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = false;
            Equal.Click += Equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(672, 746);
            Controls.Add(Equal);
            Controls.Add(Add);
            Controls.Add(Clear);
            Controls.Add(Decimal);
            Controls.Add(Zero);
            Controls.Add(Subtract);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(Multiply);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Divide);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(TextBox);
            Controls.Add(Seven);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Seven;
        private TextBox TextBox;
        private Button Eight;
        private Button Nine;
        private Button Divide;
        private Button Multiply;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button Subtract;
        private Button Three;
        private Button Two;
        private Button One;
        private Button Add;
        private Button Clear;
        private Button Decimal;
        private Button Zero;
        private Button Equal;
    }
}
