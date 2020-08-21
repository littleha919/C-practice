namespace Ariel_Loan
{
    partial class Form2
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
        private void InitializeComponent(string loan, string year, string rate, string month, string total)
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labLoan = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.btnMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(80, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(80, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(80, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(80, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款：";
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labLoan.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(205, 52);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(84, 23);
            this.labLoan.TabIndex = 10;
            this.labLoan.Text = loan;
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labYear.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(205, 101);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(82, 23);
            this.labYear.TabIndex = 11;
            this.labYear.Text = year;
            // 
            // labRate
            // 
            this.labRate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.labRate.AutoSize = true;
            this.labRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labRate.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(205, 145);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(79, 23);
            this.labRate.TabIndex = 12;
            this.labRate.Text = rate;
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labMonth.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMonth.Location = new System.Drawing.Point(205, 192);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(97, 23);
            this.labMonth.TabIndex = 13;
            this.labMonth.Text = month;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotal.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(205, 237);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(85, 23);
            this.labTotal.TabIndex = 14;
            this.labTotal.Text = total;
            // 
            // btnMail
            // 
            this.btnMail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMail.Location = new System.Drawing.Point(368, 263);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(136, 46);
            this.btnMail.TabIndex = 15;
            this.btnMail.Text = "Email";
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 344);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.Text = "Myhomework_10_LoanReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button btnMail;
    }
}