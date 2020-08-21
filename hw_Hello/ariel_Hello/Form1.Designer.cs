namespace ariel_Hello
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.txtEgName = new System.Windows.Forms.TextBox();
            this.labEgName = new System.Windows.Forms.Label();
            this.txtConst = new System.Windows.Forms.TextBox();
            this.labConst = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labName.Location = new System.Drawing.Point(25, 34);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 26);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(194, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 33);
            this.txtName.TabIndex = 1;
            // 
            // btnHello
            // 
            this.btnHello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHello.BackgroundImage")));
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(30, 266);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(166, 46);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHi.BackgroundImage")));
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(225, 266);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(155, 46);
            this.btnHi.TabIndex = 3;
            this.btnHi.Text = "Say HI!";
            this.btnHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // txtEgName
            // 
            this.txtEgName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEgName.Location = new System.Drawing.Point(194, 81);
            this.txtEgName.Name = "txtEgName";
            this.txtEgName.Size = new System.Drawing.Size(126, 33);
            this.txtEgName.TabIndex = 9;
            // 
            // labEgName
            // 
            this.labEgName.AutoSize = true;
            this.labEgName.BackColor = System.Drawing.Color.Transparent;
            this.labEgName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEgName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labEgName.Location = new System.Drawing.Point(25, 81);
            this.labEgName.Name = "labEgName";
            this.labEgName.Size = new System.Drawing.Size(173, 26);
            this.labEgName.TabIndex = 8;
            this.labEgName.Text = "English Name：";
            // 
            // txtConst
            // 
            this.txtConst.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtConst.Location = new System.Drawing.Point(194, 177);
            this.txtConst.Name = "txtConst";
            this.txtConst.Size = new System.Drawing.Size(126, 33);
            this.txtConst.TabIndex = 13;
            // 
            // labConst
            // 
            this.labConst.AutoSize = true;
            this.labConst.BackColor = System.Drawing.Color.Transparent;
            this.labConst.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labConst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labConst.Location = new System.Drawing.Point(25, 177);
            this.labConst.Name = "labConst";
            this.labConst.Size = new System.Drawing.Size(75, 26);
            this.labConst.TabIndex = 12;
            this.labConst.Text = "星座：";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(194, 129);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(126, 33);
            this.txtGender.TabIndex = 11;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labGender.Location = new System.Drawing.Point(25, 130);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(75, 26);
            this.labGender.TabIndex = 10;
            this.labGender.Text = "性別：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(565, 354);
            this.Controls.Add(this.txtConst);
            this.Controls.Add(this.labConst);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.txtEgName);
            this.Controls.Add(this.labEgName);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.TextBox txtEgName;
        private System.Windows.Forms.Label labEgName;
        private System.Windows.Forms.TextBox txtConst;
        private System.Windows.Forms.Label labConst;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label labGender;
    }
}

