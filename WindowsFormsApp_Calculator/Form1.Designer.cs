namespace WindowsFormsApp_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.buttonequalto = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.buttondivision = new System.Windows.Forms.Button();
            this.buttonmultiplication = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(12, 9);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(318, 68);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekranLabel.UseMnemonic = false;
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number1.Location = new System.Drawing.Point(12, 80);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(75, 75);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number2.Location = new System.Drawing.Point(93, 80);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(75, 75);
            this.number2.TabIndex = 2;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number3.Location = new System.Drawing.Point(174, 80);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(75, 75);
            this.number3.TabIndex = 3;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number6.Location = new System.Drawing.Point(174, 161);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(75, 75);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number5.Location = new System.Drawing.Point(93, 161);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(75, 75);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number4.Location = new System.Drawing.Point(12, 161);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(75, 75);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // buttonequalto
            // 
            this.buttonequalto.BackColor = System.Drawing.Color.HotPink;
            this.buttonequalto.Location = new System.Drawing.Point(174, 323);
            this.buttonequalto.Name = "buttonequalto";
            this.buttonequalto.Size = new System.Drawing.Size(75, 75);
            this.buttonequalto.TabIndex = 12;
            this.buttonequalto.Text = "=";
            this.buttonequalto.UseVisualStyleBackColor = false;
            this.buttonequalto.Click += new System.EventHandler(this.buttonequalto_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number0.Location = new System.Drawing.Point(93, 323);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(75, 75);
            this.number0.TabIndex = 11;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonclear.ForeColor = System.Drawing.Color.White;
            this.buttonclear.Location = new System.Drawing.Point(12, 323);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 75);
            this.buttonclear.TabIndex = 10;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number9.Location = new System.Drawing.Point(174, 242);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(75, 75);
            this.number9.TabIndex = 9;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number8.Location = new System.Drawing.Point(93, 242);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(75, 75);
            this.number8.TabIndex = 8;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.number7.Location = new System.Drawing.Point(12, 242);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(75, 75);
            this.number7.TabIndex = 7;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // buttondivision
            // 
            this.buttondivision.BackColor = System.Drawing.Color.MediumPurple;
            this.buttondivision.Location = new System.Drawing.Point(255, 323);
            this.buttondivision.Name = "buttondivision";
            this.buttondivision.Size = new System.Drawing.Size(75, 75);
            this.buttondivision.TabIndex = 16;
            this.buttondivision.Text = "/";
            this.buttondivision.UseVisualStyleBackColor = false;
            this.buttondivision.Click += new System.EventHandler(this.buttondivision_Click);
            // 
            // buttonmultiplication
            // 
            this.buttonmultiplication.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonmultiplication.Location = new System.Drawing.Point(255, 242);
            this.buttonmultiplication.Name = "buttonmultiplication";
            this.buttonmultiplication.Size = new System.Drawing.Size(75, 75);
            this.buttonmultiplication.TabIndex = 15;
            this.buttonmultiplication.Text = "X";
            this.buttonmultiplication.UseVisualStyleBackColor = false;
            this.buttonmultiplication.Click += new System.EventHandler(this.buttonmultiplication_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonminus.Location = new System.Drawing.Point(255, 161);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(75, 75);
            this.buttonminus.TabIndex = 14;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = false;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttonlus
            // 
            this.buttonlus.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonlus.Location = new System.Drawing.Point(255, 80);
            this.buttonlus.Name = "buttonlus";
            this.buttonlus.Size = new System.Drawing.Size(75, 75);
            this.buttonlus.TabIndex = 13;
            this.buttonlus.Text = "+";
            this.buttonlus.UseVisualStyleBackColor = false;
            this.buttonlus.Click += new System.EventHandler(this.buttonlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(343, 412);
            this.Controls.Add(this.buttondivision);
            this.Controls.Add(this.buttonmultiplication);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.buttonlus);
            this.Controls.Add(this.buttonequalto);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button buttonequalto;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button buttondivision;
        private System.Windows.Forms.Button buttonmultiplication;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonlus;
    }
}

