namespace Calculator
{
    partial class CalculatorForm
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtValue.Enabled = false;
            this.txtValue.Font = new System.Drawing.Font("Courier New", 20F);
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.Location = new System.Drawing.Point(-1, 14);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(273, 38);
            this.txtValue.TabIndex = 0;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(12, 62);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(51, 44);
            this.btnN1.TabIndex = 1;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(69, 62);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(51, 44);
            this.btnN2.TabIndex = 1;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(126, 62);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(51, 44);
            this.btnN3.TabIndex = 1;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(126, 112);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(51, 44);
            this.btnN6.TabIndex = 1;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(69, 112);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(51, 44);
            this.btnN5.TabIndex = 1;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(12, 112);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(51, 44);
            this.btnN4.TabIndex = 1;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(69, 162);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(51, 44);
            this.btnN8.TabIndex = 1;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(126, 162);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(51, 44);
            this.btnN9.TabIndex = 1;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(12, 162);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(51, 44);
            this.btnN7.TabIndex = 1;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnN0.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(69, 212);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(51, 44);
            this.btnN0.TabIndex = 1;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(198, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSub.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(198, 112);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 44);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMul.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(198, 162);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(50, 44);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(127, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 44);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDecimal.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(13, 212);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(50, 44);
            this.btnDecimal.TabIndex = 2;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEqual.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(81, 262);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(68, 44);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDiv.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(198, 212);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 44);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 316);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.txtValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDiv;
    }
}

