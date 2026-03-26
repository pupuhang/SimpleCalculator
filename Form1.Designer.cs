namespace SimpleCalculator
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
            txtDisplay = new TextBox();
            txtResult = new TextBox();
            lblCalculator = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnEqual = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 40);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(476, 27);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 73);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(476, 27);
            txtResult.TabIndex = 1;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCalculator
            // 
            lblCalculator.AutoSize = true;
            lblCalculator.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblCalculator.Location = new Point(12, 9);
            lblCalculator.Name = "lblCalculator";
            lblCalculator.Size = new Size(177, 28);
            lblCalculator.TabIndex = 2;
            lblCalculator.Text = "Simple Calculator";
            // 
            // btn1
            // 
            btn1.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn1.Location = new Point(12, 196);
            btn1.Name = "btn1";
            btn1.Size = new Size(111, 67);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn2.Location = new Point(129, 196);
            btn2.Name = "btn2";
            btn2.Size = new Size(111, 67);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn3.Location = new Point(246, 196);
            btn3.Name = "btn3";
            btn3.Size = new Size(111, 67);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btnEqual.Location = new Point(377, 415);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(111, 67);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn4.Location = new Point(12, 269);
            btn4.Name = "btn4";
            btn4.Size = new Size(111, 67);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn5.Location = new Point(129, 269);
            btn5.Name = "btn5";
            btn5.Size = new Size(111, 67);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn6.Location = new Point(246, 269);
            btn6.Name = "btn6";
            btn6.Size = new Size(111, 67);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn7.Location = new Point(12, 342);
            btn7.Name = "btn7";
            btn7.Size = new Size(111, 67);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn8.Location = new Point(129, 342);
            btn8.Name = "btn8";
            btn8.Size = new Size(111, 67);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn9.Location = new Point(246, 342);
            btn9.Name = "btn9";
            btn9.Size = new Size(111, 67);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btn0.Location = new Point(129, 415);
            btn0.Name = "btn0";
            btn0.Size = new Size(111, 67);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btnAdd.Location = new Point(377, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 67);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperator_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btnSub.Location = new Point(377, 269);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(111, 67);
            btnSub.TabIndex = 17;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnOperator_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btnMul.Location = new Point(377, 196);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(111, 67);
            btnMul.TabIndex = 18;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnOperator_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold);
            btnDiv.Location = new Point(377, 123);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(111, 67);
            btnDiv.TabIndex = 19;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnOperator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 543);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnEqual);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblCalculator);
            Controls.Add(txtResult);
            Controls.Add(txtDisplay);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private TextBox txtResult;
        private Label lblCalculator;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnEqual;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}
