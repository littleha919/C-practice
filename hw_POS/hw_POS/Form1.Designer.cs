namespace hw_POS
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.btnShrimp = new System.Windows.Forms.Button();
            this.btnPork = new System.Windows.Forms.Button();
            this.btnBeef = new System.Windows.Forms.Button();
            this.btnCrab = new System.Windows.Forms.Button();
            this.groupPrice = new System.Windows.Forms.GroupBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.labDiscount = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.labList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupOrder.SuspendLayout();
            this.groupPrice.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.groupList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOrder
            // 
            this.groupOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupOrder.AutoSize = true;
            this.groupOrder.Controls.Add(this.btnCrab);
            this.groupOrder.Controls.Add(this.btnBeef);
            this.groupOrder.Controls.Add(this.btnPork);
            this.groupOrder.Controls.Add(this.btnShrimp);
            this.groupOrder.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupOrder.Location = new System.Drawing.Point(12, 11);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Padding = new System.Windows.Forms.Padding(5);
            this.groupOrder.Size = new System.Drawing.Size(291, 307);
            this.groupOrder.TabIndex = 0;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "菜單Menu";
            // 
            // btnShrimp
            // 
            this.btnShrimp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShrimp.BackgroundImage")));
            this.btnShrimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShrimp.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShrimp.ForeColor = System.Drawing.Color.White;
            this.btnShrimp.Location = new System.Drawing.Point(15, 37);
            this.btnShrimp.Name = "btnShrimp";
            this.btnShrimp.Size = new System.Drawing.Size(100, 101);
            this.btnShrimp.TabIndex = 1;
            this.btnShrimp.Text = "泰國蝦  600克 NT400";
            this.btnShrimp.UseVisualStyleBackColor = true;
            this.btnShrimp.Click += new System.EventHandler(this.btnShrimp_Click);
            // 
            // btnPork
            // 
            this.btnPork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPork.BackgroundImage")));
            this.btnPork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPork.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPork.ForeColor = System.Drawing.Color.Gray;
            this.btnPork.Location = new System.Drawing.Point(155, 37);
            this.btnPork.Name = "btnPork";
            this.btnPork.Size = new System.Drawing.Size(100, 101);
            this.btnPork.TabIndex = 2;
            this.btnPork.Text = "松阪豬  600克 NT500";
            this.btnPork.UseVisualStyleBackColor = true;
            this.btnPork.Click += new System.EventHandler(this.btnPork_Click);
            // 
            // btnBeef
            // 
            this.btnBeef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeef.BackgroundImage")));
            this.btnBeef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeef.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeef.ForeColor = System.Drawing.Color.White;
            this.btnBeef.Location = new System.Drawing.Point(155, 165);
            this.btnBeef.Name = "btnBeef";
            this.btnBeef.Size = new System.Drawing.Size(100, 108);
            this.btnBeef.TabIndex = 3;
            this.btnBeef.Text = "神戶牛   300克  NT3200";
            this.btnBeef.UseVisualStyleBackColor = true;
            this.btnBeef.Click += new System.EventHandler(this.btnBeef_Click);
            // 
            // btnCrab
            // 
            this.btnCrab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrab.BackgroundImage")));
            this.btnCrab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrab.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCrab.ForeColor = System.Drawing.Color.White;
            this.btnCrab.Location = new System.Drawing.Point(15, 165);
            this.btnCrab.Name = "btnCrab";
            this.btnCrab.Size = new System.Drawing.Size(100, 108);
            this.btnCrab.TabIndex = 4;
            this.btnCrab.Text = "松葉蟹   600克 NT1300";
            this.btnCrab.UseVisualStyleBackColor = true;
            this.btnCrab.Click += new System.EventHandler(this.btnCrab_Click);
            // 
            // groupPrice
            // 
            this.groupPrice.Controls.Add(this.labPrice);
            this.groupPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupPrice.Location = new System.Drawing.Point(327, 12);
            this.groupPrice.Name = "groupPrice";
            this.groupPrice.Size = new System.Drawing.Size(251, 123);
            this.groupPrice.TabIndex = 1;
            this.groupPrice.TabStop = false;
            this.groupPrice.Text = "總金額 Total Price";
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labPrice.Location = new System.Drawing.Point(21, 50);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(211, 36);
            this.labPrice.TabIndex = 0;
            this.labPrice.Text = "NT$ 0";
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupPay
            // 
            this.groupPay.Controls.Add(this.labDiscount);
            this.groupPay.Controls.Add(this.btnCredit);
            this.groupPay.Controls.Add(this.btnCash);
            this.groupPay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupPay.Location = new System.Drawing.Point(332, 150);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(246, 168);
            this.groupPay.TabIndex = 2;
            this.groupPay.TabStop = false;
            this.groupPay.Text = "付款方式";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(20, 51);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(94, 40);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(130, 51);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(94, 40);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.Location = new System.Drawing.Point(106, 115);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(134, 19);
            this.labDiscount.TabIndex = 2;
            this.labDiscount.Text = "信用卡結帳享九折!";
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.btnClear);
            this.groupList.Controls.Add(this.labList);
            this.groupList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupList.Location = new System.Drawing.Point(597, 12);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(227, 306);
            this.groupList.TabIndex = 3;
            this.groupList.TabStop = false;
            this.groupList.Text = "購物清單 List";
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.White;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(18, 30);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(192, 208);
            this.labList.TabIndex = 0;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 36);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 328);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupPay);
            this.Controls.Add(this.groupPrice);
            this.Controls.Add(this.groupOrder);
            this.Name = "POS";
            this.Text = "Form1";
            this.groupOrder.ResumeLayout(false);
            this.groupPrice.ResumeLayout(false);
            this.groupPay.ResumeLayout(false);
            this.groupPay.PerformLayout();
            this.groupList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.Button btnCrab;
        private System.Windows.Forms.Button btnBeef;
        private System.Windows.Forms.Button btnPork;
        private System.Windows.Forms.Button btnShrimp;
        private System.Windows.Forms.GroupBox groupPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.GroupBox groupPay;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labList;
    }
}

