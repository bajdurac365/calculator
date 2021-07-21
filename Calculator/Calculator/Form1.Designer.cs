
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberSeven = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.numberNine = new System.Windows.Forms.Button();
            this.signDivision = new System.Windows.Forms.Button();
            this.signCe = new System.Windows.Forms.Button();
            this.signC = new System.Windows.Forms.Button();
            this.signMultiply = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.signMinus = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.numberOne = new System.Windows.Forms.Button();
            this.signEqual = new System.Windows.Forms.Button();
            this.signPlus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberSeven
            // 
            this.numberSeven.Location = new System.Drawing.Point(18, 100);
            this.numberSeven.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(56, 60);
            this.numberSeven.TabIndex = 0;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = true;
            this.numberSeven.Click += new System.EventHandler(this.button_click);
            // 
            // numberEight
            // 
            this.numberEight.Location = new System.Drawing.Point(82, 100);
            this.numberEight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(56, 60);
            this.numberEight.TabIndex = 1;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = true;
            this.numberEight.Click += new System.EventHandler(this.button_click);
            // 
            // numberNine
            // 
            this.numberNine.Location = new System.Drawing.Point(146, 100);
            this.numberNine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberNine.Name = "numberNine";
            this.numberNine.Size = new System.Drawing.Size(56, 60);
            this.numberNine.TabIndex = 2;
            this.numberNine.Text = "9";
            this.numberNine.UseVisualStyleBackColor = true;
            this.numberNine.Click += new System.EventHandler(this.button_click);
            // 
            // signDivision
            // 
            this.signDivision.Location = new System.Drawing.Point(210, 100);
            this.signDivision.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signDivision.Name = "signDivision";
            this.signDivision.Size = new System.Drawing.Size(56, 60);
            this.signDivision.TabIndex = 3;
            this.signDivision.Text = "/";
            this.signDivision.UseVisualStyleBackColor = true;
            this.signDivision.Click += new System.EventHandler(this.operator_click);
            // 
            // signCe
            // 
            this.signCe.Location = new System.Drawing.Point(274, 100);
            this.signCe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signCe.Name = "signCe";
            this.signCe.Size = new System.Drawing.Size(56, 60);
            this.signCe.TabIndex = 4;
            this.signCe.Text = "CE";
            this.signCe.UseVisualStyleBackColor = true;
            this.signCe.Click += new System.EventHandler(this.signCe_Click);
            // 
            // signC
            // 
            this.signC.Location = new System.Drawing.Point(274, 168);
            this.signC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signC.Name = "signC";
            this.signC.Size = new System.Drawing.Size(56, 60);
            this.signC.TabIndex = 9;
            this.signC.Text = "C";
            this.signC.UseVisualStyleBackColor = true;
            this.signC.Click += new System.EventHandler(this.signC_Click);
            // 
            // signMultiply
            // 
            this.signMultiply.Location = new System.Drawing.Point(210, 168);
            this.signMultiply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signMultiply.Name = "signMultiply";
            this.signMultiply.Size = new System.Drawing.Size(56, 60);
            this.signMultiply.TabIndex = 8;
            this.signMultiply.Text = "*";
            this.signMultiply.UseVisualStyleBackColor = true;
            this.signMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // numberSix
            // 
            this.numberSix.Location = new System.Drawing.Point(146, 168);
            this.numberSix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(56, 60);
            this.numberSix.TabIndex = 7;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = true;
            this.numberSix.Click += new System.EventHandler(this.button_click);
            // 
            // numberFive
            // 
            this.numberFive.Location = new System.Drawing.Point(82, 168);
            this.numberFive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(56, 60);
            this.numberFive.TabIndex = 6;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = true;
            this.numberFive.Click += new System.EventHandler(this.button_click);
            // 
            // numberFour
            // 
            this.numberFour.Location = new System.Drawing.Point(18, 168);
            this.numberFour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(56, 60);
            this.numberFour.TabIndex = 5;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = true;
            this.numberFour.Click += new System.EventHandler(this.button_click);
            // 
            // signMinus
            // 
            this.signMinus.Location = new System.Drawing.Point(210, 237);
            this.signMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signMinus.Name = "signMinus";
            this.signMinus.Size = new System.Drawing.Size(56, 60);
            this.signMinus.TabIndex = 13;
            this.signMinus.Text = "-";
            this.signMinus.UseVisualStyleBackColor = true;
            this.signMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // numberThree
            // 
            this.numberThree.Location = new System.Drawing.Point(146, 237);
            this.numberThree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(56, 60);
            this.numberThree.TabIndex = 12;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = true;
            this.numberThree.Click += new System.EventHandler(this.button_click);
            // 
            // numberTwo
            // 
            this.numberTwo.Location = new System.Drawing.Point(82, 237);
            this.numberTwo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(56, 60);
            this.numberTwo.TabIndex = 11;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = true;
            this.numberTwo.Click += new System.EventHandler(this.button_click);
            // 
            // numberOne
            // 
            this.numberOne.Location = new System.Drawing.Point(18, 237);
            this.numberOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(56, 60);
            this.numberOne.TabIndex = 10;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = true;
            this.numberOne.Click += new System.EventHandler(this.button_click);
            // 
            // signEqual
            // 
            this.signEqual.Location = new System.Drawing.Point(274, 237);
            this.signEqual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signEqual.Name = "signEqual";
            this.signEqual.Size = new System.Drawing.Size(56, 130);
            this.signEqual.TabIndex = 19;
            this.signEqual.Text = "=";
            this.signEqual.UseVisualStyleBackColor = true;
            this.signEqual.Click += new System.EventHandler(this.signEqual_Click);
            // 
            // signPlus
            // 
            this.signPlus.Location = new System.Drawing.Point(210, 305);
            this.signPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signPlus.Name = "signPlus";
            this.signPlus.Size = new System.Drawing.Size(56, 60);
            this.signPlus.TabIndex = 18;
            this.signPlus.Text = "+";
            this.signPlus.UseVisualStyleBackColor = true;
            this.signPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(146, 305);
            this.dot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(56, 60);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.button_click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(18, 305);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(120, 60);
            this.buttonZero.TabIndex = 15;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(18, 41);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(310, 26);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(18, 14);
            this.labelCurrentOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 19);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.signEqual);
            this.Controls.Add(this.signPlus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.signMinus);
            this.Controls.Add(this.numberThree);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.signC);
            this.Controls.Add(this.signMultiply);
            this.Controls.Add(this.numberSix);
            this.Controls.Add(this.numberFive);
            this.Controls.Add(this.numberFour);
            this.Controls.Add(this.signCe);
            this.Controls.Add(this.signDivision);
            this.Controls.Add(this.numberNine);
            this.Controls.Add(this.numberEight);
            this.Controls.Add(this.numberSeven);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Bajdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button numberNine;
        private System.Windows.Forms.Button signDivision;
        private System.Windows.Forms.Button signCe;
        private System.Windows.Forms.Button signC;
        private System.Windows.Forms.Button signMultiply;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button signMinus;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.Button signEqual;
        private System.Windows.Forms.Button signPlus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

