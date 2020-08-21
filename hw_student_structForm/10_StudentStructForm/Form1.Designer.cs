namespace _10_StudentStructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.labCh = new System.Windows.Forms.Label();
            this.labEg = new System.Windows.Forms.Label();
            this.labMa = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEg = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupShow = new System.Windows.Forms.GroupBox();
            this.labHighLow = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.groupShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(44, 55);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCh
            // 
            this.labCh.AutoSize = true;
            this.labCh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCh.Location = new System.Drawing.Point(44, 106);
            this.labCh.Name = "labCh";
            this.labCh.Size = new System.Drawing.Size(67, 24);
            this.labCh.TabIndex = 1;
            this.labCh.Text = "國文：";
            // 
            // labEg
            // 
            this.labEg.AutoSize = true;
            this.labEg.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEg.Location = new System.Drawing.Point(44, 159);
            this.labEg.Name = "labEg";
            this.labEg.Size = new System.Drawing.Size(67, 24);
            this.labEg.TabIndex = 2;
            this.labEg.Text = "英文：";
            // 
            // labMa
            // 
            this.labMa.AutoSize = true;
            this.labMa.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMa.Location = new System.Drawing.Point(44, 207);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(67, 24);
            this.labMa.TabIndex = 3;
            this.labMa.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(117, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtEg
            // 
            this.txtEg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEg.Location = new System.Drawing.Point(117, 159);
            this.txtEg.Name = "txtEg";
            this.txtEg.Size = new System.Drawing.Size(112, 29);
            this.txtEg.TabIndex = 5;
            // 
            // txtCh
            // 
            this.txtCh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCh.Location = new System.Drawing.Point(117, 106);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(112, 29);
            this.txtCh.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMa.Location = new System.Drawing.Point(117, 207);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(112, 29);
            this.txtMa.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(26, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(144, 269);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(111, 45);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupShow
            // 
            this.groupShow.Controls.Add(this.labHighLow);
            this.groupShow.Controls.Add(this.labShow);
            this.groupShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupShow.Location = new System.Drawing.Point(286, 29);
            this.groupShow.Name = "groupShow";
            this.groupShow.Size = new System.Drawing.Size(243, 259);
            this.groupShow.TabIndex = 10;
            this.groupShow.TabStop = false;
            this.groupShow.Text = "成績";
            // 
            // labHighLow
            // 
            this.labHighLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labHighLow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHighLow.Location = new System.Drawing.Point(14, 166);
            this.labHighLow.Name = "labHighLow";
            this.labHighLow.Size = new System.Drawing.Size(213, 72);
            this.labHighLow.TabIndex = 1;
            // 
            // labShow
            // 
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(13, 29);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(214, 125);
            this.labShow.TabIndex = 0;
            // 
            // btnHighLow
            // 
            this.btnHighLow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighLow.Location = new System.Drawing.Point(338, 303);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(191, 38);
            this.btnHighLow.TabIndex = 11;
            this.btnHighLow.Text = "最高分/最低分科目";
            this.btnHighLow.UseVisualStyleBackColor = true;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 366);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.groupShow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtEg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMa);
            this.Controls.Add(this.labEg);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.labName);
            this.Name = "Form1";
            this.Text = "StudentStructForm";
            this.groupShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.Label labEg;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEg;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupShow;
        private System.Windows.Forms.Label labHighLow;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnHighLow;
    }
}

