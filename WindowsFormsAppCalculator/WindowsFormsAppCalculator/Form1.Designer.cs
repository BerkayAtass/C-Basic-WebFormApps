namespace WindowsFormsAppCalculator
{
    partial class s
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
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.n1TxtBox = new System.Windows.Forms.TextBox();
            this.n2TxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.subtractionBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(12, 28);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(198, 38);
            this.number1.TabIndex = 0;
            this.number1.Text = "NUMBER 1 = ";
            this.number1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(12, 101);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(198, 38);
            this.number2.TabIndex = 1;
            this.number2.Text = "NUMBER 2 = ";
            // 
            // n1TxtBox
            // 
            this.n1TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1TxtBox.Location = new System.Drawing.Point(216, 30);
            this.n1TxtBox.Name = "n1TxtBox";
            this.n1TxtBox.Size = new System.Drawing.Size(110, 35);
            this.n1TxtBox.TabIndex = 2;
            this.n1TxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n2TxtBox
            // 
            this.n2TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2TxtBox.Location = new System.Drawing.Point(216, 103);
            this.n2TxtBox.Name = "n2TxtBox";
            this.n2TxtBox.Size = new System.Drawing.Size(110, 35);
            this.n2TxtBox.TabIndex = 3;
            this.n2TxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(410, 28);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(81, 56);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subtractionBtn
            // 
            this.subtractionBtn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionBtn.Location = new System.Drawing.Point(410, 90);
            this.subtractionBtn.Name = "subtractionBtn";
            this.subtractionBtn.Size = new System.Drawing.Size(81, 56);
            this.subtractionBtn.TabIndex = 5;
            this.subtractionBtn.Text = "-";
            this.subtractionBtn.UseVisualStyleBackColor = true;
            this.subtractionBtn.Click += new System.EventHandler(this.subtractionBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(410, 214);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(81, 56);
            this.divideBtn.TabIndex = 6;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationBtn.Location = new System.Drawing.Point(410, 152);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(81, 56);
            this.multiplicationBtn.TabIndex = 7;
            this.multiplicationBtn.Text = "*";
            this.multiplicationBtn.UseVisualStyleBackColor = true;
            this.multiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 214);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(154, 38);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "RESULT = ";
            // 
            // resultBox
            // 
            this.resultBox.Enabled = false;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(216, 221);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(110, 35);
            this.resultBox.TabIndex = 10;
            this.resultBox.Text = "null";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 327);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.subtractionBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.n2TxtBox);
            this.Controls.Add(this.n1TxtBox);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "s";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.TextBox n1TxtBox;
        private System.Windows.Forms.TextBox n2TxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subtractionBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultBox;
    }
}

