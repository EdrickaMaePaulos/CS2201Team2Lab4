namespace Calculator
{
    partial class frmCalculator
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(211)))));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(298, 55);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "0";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(20, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5);
            this.btnClear.Size = new System.Drawing.Size(70, 70);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCE.Location = new System.Drawing.Point(96, 115);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(70, 70);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnModulo.FlatAppearance.BorderSize = 0;
            this.btnModulo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModulo.Location = new System.Drawing.Point(172, 115);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Padding = new System.Windows.Forms.Padding(5);
            this.btnModulo.Size = new System.Drawing.Size(70, 70);
            this.btnModulo.TabIndex = 3;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMultiply.Location = new System.Drawing.Point(248, 191);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Padding = new System.Windows.Forms.Padding(5);
            this.btnMultiply.Size = new System.Drawing.Size(70, 70);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Snow;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.Location = new System.Drawing.Point(172, 191);
            this.btn9.Name = "btn9";
            this.btn9.Padding = new System.Windows.Forms.Padding(5);
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Snow;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.Location = new System.Drawing.Point(96, 191);
            this.btn8.Name = "btn8";
            this.btn8.Padding = new System.Windows.Forms.Padding(5);
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Snow;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.Location = new System.Drawing.Point(20, 191);
            this.btn7.Name = "btn7";
            this.btn7.Padding = new System.Windows.Forms.Padding(5);
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinus.Location = new System.Drawing.Point(248, 267);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Padding = new System.Windows.Forms.Padding(5);
            this.btnMinus.Size = new System.Drawing.Size(70, 70);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Snow;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.Location = new System.Drawing.Point(172, 267);
            this.btn6.Name = "btn6";
            this.btn6.Padding = new System.Windows.Forms.Padding(5);
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Snow;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.Location = new System.Drawing.Point(96, 267);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(5);
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Snow;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.Location = new System.Drawing.Point(20, 267);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(5);
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(248, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(70, 70);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Snow;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.Location = new System.Drawing.Point(172, 343);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(5);
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Snow;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.Location = new System.Drawing.Point(96, 343);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(5);
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Snow;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.Location = new System.Drawing.Point(20, 343);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(5);
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEqual.Location = new System.Drawing.Point(172, 419);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Padding = new System.Windows.Forms.Padding(5);
            this.btnEqual.Size = new System.Drawing.Size(146, 70);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Snow;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.Location = new System.Drawing.Point(96, 419);
            this.btn0.Name = "btn0";
            this.btn0.Padding = new System.Windows.Forms.Padding(5);
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Snow;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPoint.Location = new System.Drawing.Point(20, 419);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Padding = new System.Windows.Forms.Padding(5);
            this.btnPoint.Size = new System.Drawing.Size(70, 70);
            this.btnPoint.TabIndex = 17;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(211)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(20, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 28);
            this.button8.TabIndex = 20;
            this.button8.Text = "Scientific \r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivide.Location = new System.Drawing.Point(248, 115);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Padding = new System.Windows.Forms.Padding(5);
            this.btnDivide.Size = new System.Drawing.Size(70, 70);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(332, 503);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button button8;
    }
}

