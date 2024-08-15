
namespace ReadFile_huang0045
{
    partial class ReadFile_huang0045
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
            this.btn_nextRecord = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nextRecord
            // 
            this.btn_nextRecord.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_nextRecord.Enabled = false;
            this.btn_nextRecord.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextRecord.Location = new System.Drawing.Point(177, 255);
            this.btn_nextRecord.Name = "btn_nextRecord";
            this.btn_nextRecord.Size = new System.Drawing.Size(98, 39);
            this.btn_nextRecord.TabIndex = 19;
            this.btn_nextRecord.Text = "Next Record";
            this.btn_nextRecord.UseVisualStyleBackColor = false;
            this.btn_nextRecord.Click += new System.EventHandler(this.btn_nextRecord_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_openFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(52, 255);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(96, 39);
            this.btn_openFile.TabIndex = 18;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Close.Enabled = false;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(309, 255);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 39);
            this.btn_Close.TabIndex = 24;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ReadFile_huang0045
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 347);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_nextRecord);
            this.Controls.Add(this.btn_openFile);
            this.Name = "ReadFile_huang0045";
            this.Text = "Reading a Sequential File";
            this.Controls.SetChildIndex(this.btn_openFile, 0);
            this.Controls.SetChildIndex(this.btn_nextRecord, 0);
            this.Controls.SetChildIndex(this.lbl_Account, 0);
            this.Controls.SetChildIndex(this.lbl_FirstName, 0);
            this.Controls.SetChildIndex(this.lbl_LastName, 0);
            this.Controls.SetChildIndex(this.lbl_Balance, 0);
            this.Controls.SetChildIndex(this.TxtBox_Account, 0);
            this.Controls.SetChildIndex(this.TxtBox_FirstName, 0);
            this.Controls.SetChildIndex(this.TxtBox_LastName, 0);
            this.Controls.SetChildIndex(this.TxtBox_Balance, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nextRecord;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_Close;
    }
}

