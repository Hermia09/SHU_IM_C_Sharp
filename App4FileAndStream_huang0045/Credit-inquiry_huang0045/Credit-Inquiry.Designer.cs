
namespace Credit_inquiry_huang0045
{
    partial class CreditInquiryForm
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
            this.Btn_zero = new System.Windows.Forms.Button();
            this.Btn_done = new System.Windows.Forms.Button();
            this.Btn_debit = new System.Windows.Forms.Button();
            this.Btn_credit = new System.Windows.Forms.Button();
            this.Btn_open = new System.Windows.Forms.Button();
            this.txtBox_display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_zero
            // 
            this.Btn_zero.BackColor = System.Drawing.Color.Honeydew;
            this.Btn_zero.Enabled = false;
            this.Btn_zero.Location = new System.Drawing.Point(374, 177);
            this.Btn_zero.Name = "Btn_zero";
            this.Btn_zero.Size = new System.Drawing.Size(93, 31);
            this.Btn_zero.TabIndex = 17;
            this.Btn_zero.Text = "Zero Balances";
            this.Btn_zero.UseVisualStyleBackColor = false;
            this.Btn_zero.Click += new System.EventHandler(this.Btn_GetBalance_Click);
            // 
            // Btn_done
            // 
            this.Btn_done.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_done.Location = new System.Drawing.Point(486, 177);
            this.Btn_done.Name = "Btn_done";
            this.Btn_done.Size = new System.Drawing.Size(93, 31);
            this.Btn_done.TabIndex = 16;
            this.Btn_done.Text = "Done";
            this.Btn_done.UseVisualStyleBackColor = false;
            this.Btn_done.Click += new System.EventHandler(this.Btn_done_Click);
            // 
            // Btn_debit
            // 
            this.Btn_debit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Btn_debit.Enabled = false;
            this.Btn_debit.Location = new System.Drawing.Point(259, 177);
            this.Btn_debit.Name = "Btn_debit";
            this.Btn_debit.Size = new System.Drawing.Size(93, 31);
            this.Btn_debit.TabIndex = 15;
            this.Btn_debit.Text = "Debit Balances";
            this.Btn_debit.UseVisualStyleBackColor = false;
            this.Btn_debit.Click += new System.EventHandler(this.Btn_GetBalance_Click);
            // 
            // Btn_credit
            // 
            this.Btn_credit.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_credit.Enabled = false;
            this.Btn_credit.Location = new System.Drawing.Point(144, 177);
            this.Btn_credit.Name = "Btn_credit";
            this.Btn_credit.Size = new System.Drawing.Size(97, 31);
            this.Btn_credit.TabIndex = 14;
            this.Btn_credit.Text = "Credit Balances";
            this.Btn_credit.UseVisualStyleBackColor = false;
            this.Btn_credit.Click += new System.EventHandler(this.Btn_GetBalance_Click);
            // 
            // Btn_open
            // 
            this.Btn_open.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_open.Location = new System.Drawing.Point(22, 177);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Size = new System.Drawing.Size(104, 31);
            this.Btn_open.TabIndex = 13;
            this.Btn_open.Text = "Open File";
            this.Btn_open.UseVisualStyleBackColor = false;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // txtBox_display
            // 
            this.txtBox_display.Location = new System.Drawing.Point(22, 32);
            this.txtBox_display.Name = "txtBox_display";
            this.txtBox_display.Size = new System.Drawing.Size(557, 120);
            this.txtBox_display.TabIndex = 12;
            this.txtBox_display.Text = "";
            // 
            // CreditInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(604, 226);
            this.Controls.Add(this.Btn_zero);
            this.Controls.Add(this.Btn_done);
            this.Controls.Add(this.Btn_debit);
            this.Controls.Add(this.Btn_credit);
            this.Controls.Add(this.Btn_open);
            this.Controls.Add(this.txtBox_display);
            this.Name = "CreditInquiryForm";
            this.Text = "Credit Inquiry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_zero;
        private System.Windows.Forms.Button Btn_done;
        private System.Windows.Forms.Button Btn_debit;
        private System.Windows.Forms.Button Btn_credit;
        private System.Windows.Forms.Button Btn_open;
        private System.Windows.Forms.RichTextBox txtBox_display;
    }
}

