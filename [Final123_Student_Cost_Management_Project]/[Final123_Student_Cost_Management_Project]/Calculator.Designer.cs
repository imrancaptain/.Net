﻿
namespace _Final123_Student_Cost_Management_Project_
{
    partial class Calculator
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
            this.button20 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.btnequal = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(712, 12);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(63, 46);
            this.button20.TabIndex = 64;
            this.button20.Text = "Exit";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Location = new System.Drawing.Point(376, 107);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentOperation.TabIndex = 63;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(81, 123);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(339, 42);
            this.textBox_Result.TabIndex = 62;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(357, 275);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(63, 98);
            this.btnequal.TabIndex = 61;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(288, 327);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 46);
            this.button15.TabIndex = 60;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.operator_click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(219, 327);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 46);
            this.button16.TabIndex = 59;
            this.button16.Text = ".";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(81, 327);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(132, 46);
            this.button18.TabIndex = 58;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(288, 275);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 46);
            this.button11.TabIndex = 57;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(219, 275);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 46);
            this.button12.TabIndex = 56;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(150, 275);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 46);
            this.button13.TabIndex = 55;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(81, 275);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(63, 46);
            this.button14.TabIndex = 54;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(357, 223);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(63, 46);
            this.btnclear.TabIndex = 53;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(288, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 46);
            this.button7.TabIndex = 52;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.operator_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(219, 223);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 46);
            this.button8.TabIndex = 51;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(150, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 46);
            this.button9.TabIndex = 50;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(81, 223);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 46);
            this.button10.TabIndex = 49;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // btnce
            // 
            this.btnce.Location = new System.Drawing.Point(357, 171);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(63, 46);
            this.btnce.TabIndex = 48;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 47;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.operator_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 46);
            this.button3.TabIndex = 46;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 46);
            this.button2.TabIndex = 45;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 46);
            this.button1.TabIndex = 44;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}