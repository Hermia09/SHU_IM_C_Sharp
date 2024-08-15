
namespace WindowsFormsApp_1A2B
{
    partial class Frm1A2B
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lbl_1A2B = new System.Windows.Forms.Label();
            this.lbl_InputNumber = new System.Windows.Forms.Label();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.txt_InputNumber = new System.Windows.Forms.TextBox();
            this.listBo_Test = new System.Windows.Forms.ListBox();
            this.txt_Test = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lbl_Test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(471, 142);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(111, 37);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(471, 251);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(111, 35);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lbl_1A2B
            // 
            this.lbl_1A2B.AutoSize = true;
            this.lbl_1A2B.Location = new System.Drawing.Point(333, 35);
            this.lbl_1A2B.Name = "lbl_1A2B";
            this.lbl_1A2B.Size = new System.Drawing.Size(40, 15);
            this.lbl_1A2B.TabIndex = 3;
            this.lbl_1A2B.Text = "1A2B";
            // 
            // lbl_InputNumber
            // 
            this.lbl_InputNumber.AutoSize = true;
            this.lbl_InputNumber.Location = new System.Drawing.Point(333, 124);
            this.lbl_InputNumber.Name = "lbl_InputNumber";
            this.lbl_InputNumber.Size = new System.Drawing.Size(87, 15);
            this.lbl_InputNumber.TabIndex = 4;
            this.lbl_InputNumber.Text = "Input Number";
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(336, 63);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(111, 36);
            this.btnGameStart.TabIndex = 5;
            this.btnGameStart.Text = "Game Start";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 15;
            this.listBox_Input.Location = new System.Drawing.Point(252, 187);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(195, 289);
            this.listBox_Input.TabIndex = 6;
            // 
            // txt_InputNumber
            // 
            this.txt_InputNumber.Location = new System.Drawing.Point(336, 142);
            this.txt_InputNumber.Name = "txt_InputNumber";
            this.txt_InputNumber.Size = new System.Drawing.Size(100, 25);
            this.txt_InputNumber.TabIndex = 7;
            // 
            // listBo_Test
            // 
            this.listBo_Test.FormattingEnabled = true;
            this.listBo_Test.ItemHeight = 15;
            this.listBo_Test.Location = new System.Drawing.Point(33, 221);
            this.listBo_Test.Name = "listBo_Test";
            this.listBo_Test.Size = new System.Drawing.Size(195, 139);
            this.listBo_Test.TabIndex = 8;
            // 
            // txt_Test
            // 
            this.txt_Test.Location = new System.Drawing.Point(33, 377);
            this.txt_Test.Name = "txt_Test";
            this.txt_Test.Size = new System.Drawing.Size(100, 25);
            this.txt_Test.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(33, 162);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(111, 36);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // lbl_Test
            // 
            this.lbl_Test.AutoSize = true;
            this.lbl_Test.Location = new System.Drawing.Point(39, 124);
            this.lbl_Test.Name = "lbl_Test";
            this.lbl_Test.Size = new System.Drawing.Size(31, 15);
            this.lbl_Test.TabIndex = 11;
            this.lbl_Test.Text = "Test";
            // 
            // Frm1A2B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 503);
            this.Controls.Add(this.lbl_Test);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txt_Test);
            this.Controls.Add(this.listBo_Test);
            this.Controls.Add(this.txt_InputNumber);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.lbl_InputNumber);
            this.Controls.Add(this.lbl_1A2B);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Name = "Frm1A2B";
            this.Text = "Form1A2B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lbl_1A2B;
        private System.Windows.Forms.Label lbl_InputNumber;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.TextBox txt_InputNumber;
        private System.Windows.Forms.ListBox listBo_Test;
        private System.Windows.Forms.TextBox txt_Test;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lbl_Test;
    }
}

