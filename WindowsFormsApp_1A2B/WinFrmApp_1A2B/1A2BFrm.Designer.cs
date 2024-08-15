
namespace WinFrmApp_1A2B
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
            this.lbl_SeverIP = new System.Windows.Forms.Label();
            this.LB_msg = new System.Windows.Forms.ListBox();
            this.txt_InputNumber = new System.Windows.Forms.TextBox();
            this.LB_input = new System.Windows.Forms.ListBox();
            this.lbl_InputNumber = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lbl_Nickname = new System.Windows.Forms.Label();
            this.txtBox_SeverIP = new System.Windows.Forms.TextBox();
            this.txtBox_Nickname = new System.Windows.Forms.TextBox();
            this.txtBox_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_1A2B = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SeverIP
            // 
            this.lbl_SeverIP.AutoSize = true;
            this.lbl_SeverIP.Location = new System.Drawing.Point(18, 40);
            this.lbl_SeverIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SeverIP.Name = "lbl_SeverIP";
            this.lbl_SeverIP.Size = new System.Drawing.Size(50, 12);
            this.lbl_SeverIP.TabIndex = 23;
            this.lbl_SeverIP.Text = "Sever IP :";
            // 
            // LB_msg
            // 
            this.LB_msg.FormattingEnabled = true;
            this.LB_msg.ItemHeight = 12;
            this.LB_msg.Location = new System.Drawing.Point(28, 159);
            this.LB_msg.Margin = new System.Windows.Forms.Padding(2);
            this.LB_msg.Name = "LB_msg";
            this.LB_msg.Size = new System.Drawing.Size(284, 232);
            this.LB_msg.TabIndex = 20;
            // 
            // txt_InputNumber
            // 
            this.txt_InputNumber.Location = new System.Drawing.Point(373, 95);
            this.txt_InputNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_InputNumber.Name = "txt_InputNumber";
            this.txt_InputNumber.Size = new System.Drawing.Size(119, 22);
            this.txt_InputNumber.TabIndex = 19;
            // 
            // LB_input
            // 
            this.LB_input.FormattingEnabled = true;
            this.LB_input.ItemHeight = 12;
            this.LB_input.Location = new System.Drawing.Point(363, 159);
            this.LB_input.Margin = new System.Windows.Forms.Padding(2);
            this.LB_input.Name = "LB_input";
            this.LB_input.Size = new System.Drawing.Size(226, 232);
            this.LB_input.TabIndex = 18;
            // 
            // lbl_InputNumber
            // 
            this.lbl_InputNumber.AutoSize = true;
            this.lbl_InputNumber.Location = new System.Drawing.Point(438, 67);
            this.lbl_InputNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_InputNumber.Name = "lbl_InputNumber";
            this.lbl_InputNumber.Size = new System.Drawing.Size(71, 12);
            this.lbl_InputNumber.TabIndex = 16;
            this.lbl_InputNumber.Text = "Input Number";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(202, 40);
            this.lbl_Port.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(30, 12);
            this.lbl_Port.TabIndex = 15;
            this.lbl_Port.Text = "Port :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Honeydew;
            this.btnExit.Location = new System.Drawing.Point(506, 91);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEnter.Location = new System.Drawing.Point(250, 77);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(83, 30);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lbl_Nickname
            // 
            this.lbl_Nickname.AutoSize = true;
            this.lbl_Nickname.Location = new System.Drawing.Point(10, 86);
            this.lbl_Nickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nickname.Name = "lbl_Nickname";
            this.lbl_Nickname.Size = new System.Drawing.Size(58, 12);
            this.lbl_Nickname.TabIndex = 24;
            this.lbl_Nickname.Text = "Nickname :";
            // 
            // txtBox_SeverIP
            // 
            this.txtBox_SeverIP.Location = new System.Drawing.Point(80, 37);
            this.txtBox_SeverIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_SeverIP.Name = "txtBox_SeverIP";
            this.txtBox_SeverIP.Size = new System.Drawing.Size(95, 22);
            this.txtBox_SeverIP.TabIndex = 25;
            // 
            // txtBox_Nickname
            // 
            this.txtBox_Nickname.Location = new System.Drawing.Point(80, 83);
            this.txtBox_Nickname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Nickname.Name = "txtBox_Nickname";
            this.txtBox_Nickname.Size = new System.Drawing.Size(95, 22);
            this.txtBox_Nickname.TabIndex = 26;
            // 
            // txtBox_Port
            // 
            this.txtBox_Port.Location = new System.Drawing.Point(236, 36);
            this.txtBox_Port.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Port.Name = "txtBox_Port";
            this.txtBox_Port.Size = new System.Drawing.Size(97, 22);
            this.txtBox_Port.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "Online List ";
            // 
            // lbl_1A2B
            // 
            this.lbl_1A2B.AutoSize = true;
            this.lbl_1A2B.Location = new System.Drawing.Point(438, 38);
            this.lbl_1A2B.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_1A2B.Name = "lbl_1A2B";
            this.lbl_1A2B.Size = new System.Drawing.Size(33, 12);
            this.lbl_1A2B.TabIndex = 29;
            this.lbl_1A2B.Text = "1A2B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(612, 408);
            this.Controls.Add(this.lbl_1A2B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Port);
            this.Controls.Add(this.txtBox_Nickname);
            this.Controls.Add(this.txtBox_SeverIP);
            this.Controls.Add(this.lbl_Nickname);
            this.Controls.Add(this.lbl_SeverIP);
            this.Controls.Add(this.LB_msg);
            this.Controls.Add(this.txt_InputNumber);
            this.Controls.Add(this.LB_input);
            this.Controls.Add(this.lbl_InputNumber);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "1A2B Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SeverIP;
        private System.Windows.Forms.ListBox LB_msg;
        private System.Windows.Forms.TextBox txt_InputNumber;
        private System.Windows.Forms.ListBox LB_input;
        private System.Windows.Forms.Label lbl_InputNumber;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lbl_Nickname;
        private System.Windows.Forms.TextBox txtBox_SeverIP;
        private System.Windows.Forms.TextBox txtBox_Nickname;
        private System.Windows.Forms.TextBox txtBox_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_1A2B;
    }
}

