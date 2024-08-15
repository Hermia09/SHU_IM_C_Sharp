
namespace BankLibrary_huang0045
{
    partial class BankUIForm
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
            this.TxtBox_Balance = new System.Windows.Forms.TextBox();
            this.TxtBox_LastName = new System.Windows.Forms.TextBox();
            this.TxtBox_FirstName = new System.Windows.Forms.TextBox();
            this.TxtBox_Account = new System.Windows.Forms.TextBox();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Balance
            // 
            this.TxtBox_Balance.Location = new System.Drawing.Point(164, 177);
            this.TxtBox_Balance.Name = "TxtBox_Balance";
            this.TxtBox_Balance.Size = new System.Drawing.Size(153, 22);
            this.TxtBox_Balance.TabIndex = 23;
            // 
            // TxtBox_LastName
            // 
            this.TxtBox_LastName.Location = new System.Drawing.Point(164, 131);
            this.TxtBox_LastName.Name = "TxtBox_LastName";
            this.TxtBox_LastName.Size = new System.Drawing.Size(153, 22);
            this.TxtBox_LastName.TabIndex = 22;
            // 
            // TxtBox_FirstName
            // 
            this.TxtBox_FirstName.Location = new System.Drawing.Point(164, 84);
            this.TxtBox_FirstName.Name = "TxtBox_FirstName";
            this.TxtBox_FirstName.Size = new System.Drawing.Size(153, 22);
            this.TxtBox_FirstName.TabIndex = 21;
            // 
            // TxtBox_Account
            // 
            this.TxtBox_Account.Location = new System.Drawing.Point(164, 37);
            this.TxtBox_Account.Name = "TxtBox_Account";
            this.TxtBox_Account.Size = new System.Drawing.Size(153, 22);
            this.TxtBox_Account.TabIndex = 20;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(63, 177);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(57, 19);
            this.lbl_Balance.TabIndex = 19;
            this.lbl_Balance.Text = "Balance";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(63, 131);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(76, 19);
            this.lbl_LastName.TabIndex = 18;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(62, 87);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(77, 19);
            this.lbl_FirstName.TabIndex = 17;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(63, 40);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(60, 19);
            this.lbl_Account.TabIndex = 16;
            this.lbl_Account.Text = "Account";
            // 
            // BankUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(414, 318);
            this.Controls.Add(this.TxtBox_Balance);
            this.Controls.Add(this.TxtBox_LastName);
            this.Controls.Add(this.TxtBox_FirstName);
            this.Controls.Add(this.TxtBox_Account);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.lbl_Account);
            this.Name = "BankUIForm";
            this.Text = "Bank UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtBox_Balance;
        public System.Windows.Forms.TextBox TxtBox_LastName;
        public System.Windows.Forms.TextBox TxtBox_FirstName;
        public System.Windows.Forms.TextBox TxtBox_Account;
        public System.Windows.Forms.Label lbl_Balance;
        public System.Windows.Forms.Label lbl_LastName;
        public System.Windows.Forms.Label lbl_FirstName;
        public System.Windows.Forms.Label lbl_Account;
    }
}

