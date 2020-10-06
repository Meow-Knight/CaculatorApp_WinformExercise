using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CaculatorWinform
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

        public void OnNumberClick(object sender, EventArgs eventArgs)
        {
            if (isCalculated)
            {
                tbResult.Text = "";
            }
            Button btNumber = (Button) sender;
            tbResult.Text += btNumber.Text;
            isCalculated = false;
        }

        public void OnEqualButtonClick(object sender, EventArgs eventArgs)
        {
            if (isCalculated)
            {
                tbResult.Text = "";
                isCalculated = false;
            } else
            {
                this.expression = tbResult.Text;
                double result = 0;
                try
                {
                    result = CaculateUntils.Evaluate(this.expression);
                    tbResult.Text += ("\n" + result);
                }
                catch (Exception e)
                {
                    tbResult.Text += "\nInvalid Expression!";
                }
                isCalculated = true;
            }
        }

        public void OnDeleteButtonClick(object sender, EventArgs eventArgs)
        {
            String expression = tbResult.Text;
            if(expression.Length > 0)
            {
                if (isCalculated)
                {
                    tbResult.Text = this.expression.Substring(0, this.expression.Length - 1);
                    isCalculated = false;
                } else
                {
                    tbResult.Text = expression.Substring(0, expression.Length - 1);
                }
            }

        }

        public void OnClearButtonClick(object sender, EventArgs eventArgs)
        {
            Button btClear = (Button)sender;
            tbResult.Text = "";
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonLeftParenthesis = new System.Windows.Forms.Button();
            this.buttonRightParenthesis = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(61, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(238, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(61, 283);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(149, 283);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(238, 283);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(149, 359);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 70);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(238, 359);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 70);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.OnClearButtonClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(328, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 70);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(328, 207);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(70, 70);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(328, 283);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(70, 70);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(328, 359);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(70, 70);
            this.buttonDiv.TabIndex = 14;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonLeftParenthesis
            // 
            this.buttonLeftParenthesis.Location = new System.Drawing.Point(419, 131);
            this.buttonLeftParenthesis.Name = "buttonLeftParenthesis";
            this.buttonLeftParenthesis.Size = new System.Drawing.Size(70, 70);
            this.buttonLeftParenthesis.TabIndex = 15;
            this.buttonLeftParenthesis.Text = "(";
            this.buttonLeftParenthesis.UseVisualStyleBackColor = true;
            this.buttonLeftParenthesis.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonRightParenthesis
            // 
            this.buttonRightParenthesis.Location = new System.Drawing.Point(419, 207);
            this.buttonRightParenthesis.Name = "buttonRightParenthesis";
            this.buttonRightParenthesis.Size = new System.Drawing.Size(70, 70);
            this.buttonRightParenthesis.TabIndex = 16;
            this.buttonRightParenthesis.Text = ")";
            this.buttonRightParenthesis.UseVisualStyleBackColor = true;
            this.buttonRightParenthesis.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(419, 283);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(70, 146);
            this.buttonEqual.TabIndex = 17;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.OnEqualButtonClick);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(61, 40);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(428, 64);
            this.tbResult.TabIndex = 19;
            this.tbResult.Text = "";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(61, 359);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 70);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "D";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonRightParenthesis);
            this.Controls.Add(this.buttonLeftParenthesis);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonLeftParenthesis;
        private System.Windows.Forms.Button buttonRightParenthesis;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.RichTextBox tbResult;
        private Button buttonDelete;

        // variables:
        private bool isCalculated = false;
        private string expression = "";
    }
}

