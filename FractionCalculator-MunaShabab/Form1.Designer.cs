namespace FractionCalculator_MunaShabab
{
    partial class Form1
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
            this.numerator1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.denominator1TextBox = new System.Windows.Forms.TextBox();
            this.denominator2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numerator2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.functionListBox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultNumeratorLable = new System.Windows.Forms.Label();
            this.resultDenominatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numerator1TextBox
            // 
            this.numerator1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerator1TextBox.Location = new System.Drawing.Point(93, 84);
            this.numerator1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerator1TextBox.Name = "numerator1TextBox";
            this.numerator1TextBox.Size = new System.Drawing.Size(48, 22);
            this.numerator1TextBox.TabIndex = 0;
            this.numerator1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 10);
            this.label1.TabIndex = 1;
            // 
            // denominator1TextBox
            // 
            this.denominator1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominator1TextBox.Location = new System.Drawing.Point(93, 140);
            this.denominator1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denominator1TextBox.Name = "denominator1TextBox";
            this.denominator1TextBox.Size = new System.Drawing.Size(48, 22);
            this.denominator1TextBox.TabIndex = 2;
            this.denominator1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // denominator2TextBox
            // 
            this.denominator2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominator2TextBox.Location = new System.Drawing.Point(259, 140);
            this.denominator2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denominator2TextBox.Name = "denominator2TextBox";
            this.denominator2TextBox.Size = new System.Drawing.Size(47, 22);
            this.denominator2TextBox.TabIndex = 5;
            this.denominator2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 10);
            this.label2.TabIndex = 4;
            // 
            // numerator2TextBox
            // 
            this.numerator2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerator2TextBox.Location = new System.Drawing.Point(259, 84);
            this.numerator2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerator2TextBox.Name = "numerator2TextBox";
            this.numerator2TextBox.Size = new System.Drawing.Size(47, 22);
            this.numerator2TextBox.TabIndex = 3;
            this.numerator2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 10);
            this.label3.TabIndex = 7;
            // 
            // functionListBox
            // 
            this.functionListBox.AllowDrop = true;
            this.functionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionListBox.FormattingEnabled = true;
            this.functionListBox.ItemHeight = 20;
            this.functionListBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.functionListBox.Location = new System.Drawing.Point(177, 101);
            this.functionListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionListBox.Name = "functionListBox";
            this.functionListBox.ScrollAlwaysVisible = true;
            this.functionListBox.Size = new System.Drawing.Size(47, 24);
            this.functionListBox.TabIndex = 9;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(348, 101);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(42, 42);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "=";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(473, 213);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 47);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // equalsLabel
            // 
            this.equalsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel.Location = new System.Drawing.Point(502, 101);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(36, 42);
            this.equalsLabel.TabIndex = 12;
            this.equalsLabel.Text = "=";
            this.equalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(558, 101);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 42);
            this.resultLabel.TabIndex = 13;
            // 
            // resultNumeratorLable
            // 
            this.resultNumeratorLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultNumeratorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNumeratorLable.Location = new System.Drawing.Point(428, 86);
            this.resultNumeratorLable.Name = "resultNumeratorLable";
            this.resultNumeratorLable.Size = new System.Drawing.Size(46, 22);
            this.resultNumeratorLable.TabIndex = 14;
            // 
            // resultDenominatorLabel
            // 
            this.resultDenominatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultDenominatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDenominatorLabel.Location = new System.Drawing.Point(428, 137);
            this.resultDenominatorLabel.Name = "resultDenominatorLabel";
            this.resultDenominatorLabel.Size = new System.Drawing.Size(46, 22);
            this.resultDenominatorLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 285);
            this.Controls.Add(this.resultDenominatorLabel);
            this.Controls.Add(this.resultNumeratorLable);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.functionListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.denominator2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numerator2TextBox);
            this.Controls.Add(this.denominator1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numerator1TextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "FractionCalculator-MunaShabab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numerator1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox denominator1TextBox;
        private System.Windows.Forms.TextBox denominator2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numerator2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox functionListBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label equalsLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultNumeratorLable;
        private System.Windows.Forms.Label resultDenominatorLabel;
    }
}

