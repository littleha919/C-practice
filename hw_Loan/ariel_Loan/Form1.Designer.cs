namespace Ariel_Loan
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labHouse = new System.Windows.Forms.Label();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.labRate = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.labPeriod = new System.Windows.Forms.Label();
            this.txtDownPay = new System.Windows.Forms.TextBox();
            this.labAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labHouse
            // 
            this.labHouse.AutoSize = true;
            this.labHouse.BackColor = System.Drawing.Color.Transparent;
            this.labHouse.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHouse.Location = new System.Drawing.Point(112, 37);
            this.labHouse.Name = "labHouse";
            this.labHouse.Size = new System.Drawing.Size(75, 24);
            this.labHouse.TabIndex = 0;
            this.labHouse.Text = "總價($):";
            this.labHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHouse
            // 
            this.txtHouse.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHouse.Location = new System.Drawing.Point(193, 34);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(166, 33);
            this.txtHouse.TabIndex = 1;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(193, 135);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(166, 33);
            this.txtRate.TabIndex = 3;
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.Transparent;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(106, 138);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(81, 24);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%):";
            this.labRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPeriod.Location = new System.Drawing.Point(193, 85);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(166, 33);
            this.txtPeriod.TabIndex = 5;
            // 
            // labPeriod
            // 
            this.labPeriod.AutoSize = true;
            this.labPeriod.BackColor = System.Drawing.Color.Transparent;
            this.labPeriod.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPeriod.Location = new System.Drawing.Point(104, 88);
            this.labPeriod.Name = "labPeriod";
            this.labPeriod.Size = new System.Drawing.Size(83, 24);
            this.labPeriod.TabIndex = 4;
            this.labPeriod.Text = "期限(年):";
            this.labPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDownPay
            // 
            this.txtDownPay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPay.Location = new System.Drawing.Point(193, 183);
            this.txtDownPay.Name = "txtDownPay";
            this.txtDownPay.Size = new System.Drawing.Size(166, 33);
            this.txtDownPay.TabIndex = 7;
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.BackColor = System.Drawing.Color.Transparent;
            this.labAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAmount.Location = new System.Drawing.Point(93, 186);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(94, 24);
            this.labAmount.TabIndex = 6;
            this.labAmount.Text = "頭期款($):";
            this.labAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPay.Location = new System.Drawing.Point(105, 257);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(106, 37);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "PMT(月付";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(236, 257);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(110, 37);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(368, 257);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 37);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(597, 337);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtDownPay);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.labPeriod);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.labHouse);
            this.Name = "Form1";
            this.Text = "本金平均攤還試算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHouse;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label labPeriod;
        private System.Windows.Forms.TextBox txtDownPay;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}

