
namespace CreatFile4Text_huang0045
{
    partial class CreatFile4Form
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_SaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Exit.Location = new System.Drawing.Point(260, 226);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(86, 31);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Enter.Enabled = false;
            this.btn_Enter.Location = new System.Drawing.Point(164, 226);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(86, 31);
            this.btn_Enter.TabIndex = 25;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            // 
            // btn_SaveAs
            // 
            this.btn_SaveAs.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_SaveAs.Location = new System.Drawing.Point(65, 226);
            this.btn_SaveAs.Name = "btn_SaveAs";
            this.btn_SaveAs.Size = new System.Drawing.Size(86, 31);
            this.btn_SaveAs.TabIndex = 24;
            this.btn_SaveAs.Text = "Save As";
            this.btn_SaveAs.UseVisualStyleBackColor = false;
            // 
            // CreatFile4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(406, 302);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_SaveAs);
            this.Name = "CreatFile4Form";
            this.Text = "Create File";
            this.Controls.SetChildIndex(this.lbl_Account, 0);
            this.Controls.SetChildIndex(this.lbl_FirstName, 0);
            this.Controls.SetChildIndex(this.lbl_LastName, 0);
            this.Controls.SetChildIndex(this.lbl_Balance, 0);
            this.Controls.SetChildIndex(this.TxtBox_Account, 0);
            this.Controls.SetChildIndex(this.TxtBox_FirstName, 0);
            this.Controls.SetChildIndex(this.TxtBox_LastName, 0);
            this.Controls.SetChildIndex(this.TxtBox_Balance, 0);
            this.Controls.SetChildIndex(this.btn_SaveAs, 0);
            this.Controls.SetChildIndex(this.btn_Enter, 0);
            this.Controls.SetChildIndex(this.btn_Exit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_SaveAs;
    }
}

