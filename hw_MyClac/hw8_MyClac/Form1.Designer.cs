namespace hw8_MyClac
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
            this.labN1 = new System.Windows.Forms.Label();
            this.labN2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labAns = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labN1
            // 
            this.labN1.AutoSize = true;
            this.labN1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labN1.Location = new System.Drawing.Point(24, 29);
            this.labN1.Name = "labN1";
            this.labN1.Size = new System.Drawing.Size(70, 24);
            this.labN1.TabIndex = 0;
            this.labN1.Text = "Num1:";
            // 
            // labN2
            // 
            this.labN2.AutoSize = true;
            this.labN2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labN2.Location = new System.Drawing.Point(24, 70);
            this.labN2.Name = "labN2";
            this.labN2.Size = new System.Drawing.Size(70, 24);
            this.labN2.TabIndex = 1;
            this.labN2.Text = "Num2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "===============";
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAns.Location = new System.Drawing.Point(13, 139);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(81, 24);
            this.labAns.TabIndex = 3;
            this.labAns.Text = "Answer:";
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtN1.Location = new System.Drawing.Point(100, 29);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(117, 29);
            this.txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtN2.Location = new System.Drawing.Point(100, 70);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(117, 29);
            this.txtN2.TabIndex = 5;
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAns.Location = new System.Drawing.Point(100, 139);
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.Size = new System.Drawing.Size(117, 29);
            this.txtAns.TabIndex = 6;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(256, 19);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(34, 34);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiv.Location = new System.Drawing.Point(256, 140);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(34, 34);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTim.Location = new System.Drawing.Point(256, 100);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(34, 34);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "*";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMin.Location = new System.Drawing.Point(256, 60);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 34);
            this.btnMin.TabIndex = 10;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 193);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labN2);
            this.Controls.Add(this.labN1);
            this.Name = "Form1";
            this.Text = "Myhomework_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labN1;
        private System.Windows.Forms.Label labN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnMin;
    }
}

