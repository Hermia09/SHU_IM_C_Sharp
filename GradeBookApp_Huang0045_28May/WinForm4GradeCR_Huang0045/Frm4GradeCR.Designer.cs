
namespace WinForm4GradeCR_Huang0045
{
    partial class Frm4GradeCR
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
            this.SuspendLayout();
            // 
            // btnDisplayRecordComplete
            // 
            this.btnDisplayRecordComplete.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDisplayRecordComplete.FlatAppearance.BorderSize = 3;
            this.btnDisplayRecordComplete.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayRecordComplete.Text = "Display Record (1by1)[COMPLETED]";
            this.btnDisplayRecordComplete.Click += new System.EventHandler(this.BtnFileProcess_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSaveFile.FlatAppearance.BorderSize = 3;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnFileProcess_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.Click += new System.EventHandler(this.BtnFileProcess_Click);
            // 
            // btnKeyIn
            // 
            this.btnKeyIn.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnKeyIn.FlatAppearance.BorderSize = 3;
            this.btnKeyIn.Font = new System.Drawing.Font("Centaur", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyIn.Click += new System.EventHandler(this.BtnFileProcess_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.Click += new System.EventHandler(this.BtnFileProcess_Click);
            // 
            // lblKey
            // 
            this.lblKey.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // cbKey
            // 
            this.cbKey.SelectedIndexChanged += new System.EventHandler(this.cbKey_SelectedIndexChanged_1);
            // 
            // checkedListBox_Create
            // 
            this.checkedListBox_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox_Create.Size = new System.Drawing.Size(541, 464);
            // 
            // txtBox8th
            // 
            this.txtBox8th.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox7th
            // 
            this.txtBox7th.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox6th
            // 
            this.txtBox6th.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox5th
            // 
            this.txtBox5th.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox4th
            // 
            this.txtBox4th.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox3rd
            // 
            this.txtBox3rd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox2nd
            // 
            this.txtBox2nd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtBox1st
            // 
            this.txtBox1st.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // lbl6th
            // 
            this.lbl6th.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // lbl5th
            // 
            this.lbl5th.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // lbl4th
            // 
            this.lbl4th.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // lbl3rd
            // 
            this.lbl3rd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // lbl2nd
            // 
            this.lbl2nd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // lbl1st
            // 
            this.lbl1st.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // Frm4GradeCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1084, 585);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm4GradeCR";
            this.Text = "Create/Read Grade-Book (黃婉華 Huang0045)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

