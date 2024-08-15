
namespace WinForm4GradeQuery_Huang0045
{
    partial class Frm4GradeQuery
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
            this.dataGridView = new System.Windows.Forms.TabControl();
            this.dataGridView_BeforeProcess = new System.Windows.Forms.TabPage();
            this.checkedListBox_Create = new System.Windows.Forms.CheckedListBox();
            this.dataGridView_Completed = new System.Windows.Forms.TabPage();
            this.dataGridView_Read = new System.Windows.Forms.DataGridView();
            this.grpBox_BasicsProfile = new System.Windows.Forms.GroupBox();
            this.txtBox8th = new System.Windows.Forms.TextBox();
            this.txtBox7th = new System.Windows.Forms.TextBox();
            this.txtBox6th = new System.Windows.Forms.TextBox();
            this.txtBox5th = new System.Windows.Forms.TextBox();
            this.txtBox4th = new System.Windows.Forms.TextBox();
            this.txtBox3rd = new System.Windows.Forms.TextBox();
            this.txtBox2nd = new System.Windows.Forms.TextBox();
            this.txtBox1st = new System.Windows.Forms.TextBox();
            this.lbl8th = new System.Windows.Forms.Label();
            this.lbl7th = new System.Windows.Forms.Label();
            this.lbl6th = new System.Windows.Forms.Label();
            this.lbl5th = new System.Windows.Forms.Label();
            this.lbl4th = new System.Windows.Forms.Label();
            this.lbl3rd = new System.Windows.Forms.Label();
            this.lbl2nd = new System.Windows.Forms.Label();
            this.lbl1st = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDrawCharts = new System.Windows.Forms.Button();
            this.btnOpenOrComputer = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.dataGridView.SuspendLayout();
            this.dataGridView_BeforeProcess.SuspendLayout();
            this.dataGridView_Completed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Read)).BeginInit();
            this.grpBox_BasicsProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Controls.Add(this.dataGridView_BeforeProcess);
            this.dataGridView.Controls.Add(this.dataGridView_Completed);
            this.dataGridView.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.Location = new System.Drawing.Point(343, 44);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectedIndex = 0;
            this.dataGridView.Size = new System.Drawing.Size(707, 504);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.Tag = "";
            // 
            // dataGridView_BeforeProcess
            // 
            this.dataGridView_BeforeProcess.BackColor = System.Drawing.Color.Silver;
            this.dataGridView_BeforeProcess.Controls.Add(this.checkedListBox_Create);
            this.dataGridView_BeforeProcess.Location = new System.Drawing.Point(4, 30);
            this.dataGridView_BeforeProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_BeforeProcess.Name = "dataGridView_BeforeProcess";
            this.dataGridView_BeforeProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_BeforeProcess.Size = new System.Drawing.Size(699, 444);
            this.dataGridView_BeforeProcess.TabIndex = 0;
            this.dataGridView_BeforeProcess.Text = "Page (No Semester)";
            this.dataGridView_BeforeProcess.ToolTipText = "Page Without Semester";
            // 
            // checkedListBox_Create
            // 
            this.checkedListBox_Create.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox_Create.FormattingEnabled = true;
            this.checkedListBox_Create.Location = new System.Drawing.Point(-2, -4);
            this.checkedListBox_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox_Create.Name = "checkedListBox_Create";
            this.checkedListBox_Create.Size = new System.Drawing.Size(701, 464);
            this.checkedListBox_Create.TabIndex = 9;
            // 
            // dataGridView_Completed
            // 
            this.dataGridView_Completed.Controls.Add(this.dataGridView_Read);
            this.dataGridView_Completed.Location = new System.Drawing.Point(4, 30);
            this.dataGridView_Completed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Completed.Name = "dataGridView_Completed";
            this.dataGridView_Completed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Completed.Size = new System.Drawing.Size(699, 470);
            this.dataGridView_Completed.TabIndex = 1;
            this.dataGridView_Completed.Text = "Records (Completed)";
            this.dataGridView_Completed.ToolTipText = "Records With Semester";
            this.dataGridView_Completed.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Read
            // 
            this.dataGridView_Read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Read.Location = new System.Drawing.Point(-110, 4);
            this.dataGridView_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Read.Name = "dataGridView_Read";
            this.dataGridView_Read.RowHeadersWidth = 51;
            this.dataGridView_Read.RowTemplate.Height = 27;
            this.dataGridView_Read.Size = new System.Drawing.Size(775, 474);
            this.dataGridView_Read.TabIndex = 0;
            // 
            // grpBox_BasicsProfile
            // 
            this.grpBox_BasicsProfile.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox8th);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox7th);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox6th);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox5th);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox4th);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox3rd);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox2nd);
            this.grpBox_BasicsProfile.Controls.Add(this.txtBox1st);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl8th);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl7th);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl6th);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl5th);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl4th);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl3rd);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl2nd);
            this.grpBox_BasicsProfile.Controls.Add(this.lbl1st);
            this.grpBox_BasicsProfile.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_BasicsProfile.Location = new System.Drawing.Point(13, 44);
            this.grpBox_BasicsProfile.Margin = new System.Windows.Forms.Padding(4);
            this.grpBox_BasicsProfile.Name = "grpBox_BasicsProfile";
            this.grpBox_BasicsProfile.Padding = new System.Windows.Forms.Padding(4);
            this.grpBox_BasicsProfile.Size = new System.Drawing.Size(297, 478);
            this.grpBox_BasicsProfile.TabIndex = 22;
            this.grpBox_BasicsProfile.TabStop = false;
            this.grpBox_BasicsProfile.Text = "Basics Profile";
            // 
            // txtBox8th
            // 
            this.txtBox8th.Location = new System.Drawing.Point(132, 418);
            this.txtBox8th.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox8th.Name = "txtBox8th";
            this.txtBox8th.Size = new System.Drawing.Size(113, 28);
            this.txtBox8th.TabIndex = 16;
            // 
            // txtBox7th
            // 
            this.txtBox7th.Location = new System.Drawing.Point(132, 372);
            this.txtBox7th.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox7th.Name = "txtBox7th";
            this.txtBox7th.Size = new System.Drawing.Size(113, 28);
            this.txtBox7th.TabIndex = 15;
            // 
            // txtBox6th
            // 
            this.txtBox6th.Location = new System.Drawing.Point(132, 325);
            this.txtBox6th.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox6th.Name = "txtBox6th";
            this.txtBox6th.Size = new System.Drawing.Size(113, 28);
            this.txtBox6th.TabIndex = 14;
            // 
            // txtBox5th
            // 
            this.txtBox5th.Location = new System.Drawing.Point(132, 278);
            this.txtBox5th.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox5th.Name = "txtBox5th";
            this.txtBox5th.Size = new System.Drawing.Size(113, 28);
            this.txtBox5th.TabIndex = 13;
            // 
            // txtBox4th
            // 
            this.txtBox4th.Location = new System.Drawing.Point(132, 232);
            this.txtBox4th.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox4th.Name = "txtBox4th";
            this.txtBox4th.Size = new System.Drawing.Size(113, 28);
            this.txtBox4th.TabIndex = 12;
            // 
            // txtBox3rd
            // 
            this.txtBox3rd.Location = new System.Drawing.Point(132, 188);
            this.txtBox3rd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox3rd.Name = "txtBox3rd";
            this.txtBox3rd.Size = new System.Drawing.Size(113, 28);
            this.txtBox3rd.TabIndex = 11;
            // 
            // txtBox2nd
            // 
            this.txtBox2nd.Location = new System.Drawing.Point(132, 142);
            this.txtBox2nd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox2nd.Name = "txtBox2nd";
            this.txtBox2nd.Size = new System.Drawing.Size(113, 28);
            this.txtBox2nd.TabIndex = 10;
            // 
            // txtBox1st
            // 
            this.txtBox1st.Location = new System.Drawing.Point(132, 100);
            this.txtBox1st.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox1st.Name = "txtBox1st";
            this.txtBox1st.Size = new System.Drawing.Size(113, 28);
            this.txtBox1st.TabIndex = 9;
            // 
            // lbl8th
            // 
            this.lbl8th.AutoSize = true;
            this.lbl8th.Location = new System.Drawing.Point(23, 425);
            this.lbl8th.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8th.Name = "lbl8th";
            this.lbl8th.Size = new System.Drawing.Size(75, 21);
            this.lbl8th.TabIndex = 8;
            this.lbl8th.Text = "8th. Field";
            // 
            // lbl7th
            // 
            this.lbl7th.AutoSize = true;
            this.lbl7th.Location = new System.Drawing.Point(23, 380);
            this.lbl7th.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl7th.Name = "lbl7th";
            this.lbl7th.Size = new System.Drawing.Size(75, 21);
            this.lbl7th.TabIndex = 7;
            this.lbl7th.Text = "7th. Field";
            // 
            // lbl6th
            // 
            this.lbl6th.AutoSize = true;
            this.lbl6th.Location = new System.Drawing.Point(24, 331);
            this.lbl6th.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6th.Name = "lbl6th";
            this.lbl6th.Size = new System.Drawing.Size(75, 21);
            this.lbl6th.TabIndex = 6;
            this.lbl6th.Text = "6th. Field";
            // 
            // lbl5th
            // 
            this.lbl5th.AutoSize = true;
            this.lbl5th.Location = new System.Drawing.Point(23, 286);
            this.lbl5th.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5th.Name = "lbl5th";
            this.lbl5th.Size = new System.Drawing.Size(75, 21);
            this.lbl5th.TabIndex = 5;
            this.lbl5th.Text = "5th. Field";
            // 
            // lbl4th
            // 
            this.lbl4th.AutoSize = true;
            this.lbl4th.Location = new System.Drawing.Point(23, 240);
            this.lbl4th.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4th.Name = "lbl4th";
            this.lbl4th.Size = new System.Drawing.Size(75, 21);
            this.lbl4th.TabIndex = 4;
            this.lbl4th.Text = "4th. Field";
            // 
            // lbl3rd
            // 
            this.lbl3rd.AutoSize = true;
            this.lbl3rd.Location = new System.Drawing.Point(23, 195);
            this.lbl3rd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3rd.Name = "lbl3rd";
            this.lbl3rd.Size = new System.Drawing.Size(75, 21);
            this.lbl3rd.TabIndex = 3;
            this.lbl3rd.Text = "3rd. Field";
            // 
            // lbl2nd
            // 
            this.lbl2nd.AutoSize = true;
            this.lbl2nd.Location = new System.Drawing.Point(23, 149);
            this.lbl2nd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2nd.Name = "lbl2nd";
            this.lbl2nd.Size = new System.Drawing.Size(78, 21);
            this.lbl2nd.TabIndex = 2;
            this.lbl2nd.Text = "2nd. Field";
            // 
            // lbl1st
            // 
            this.lbl1st.AutoSize = true;
            this.lbl1st.Location = new System.Drawing.Point(25, 108);
            this.lbl1st.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1st.Name = "lbl1st";
            this.lbl1st.Size = new System.Drawing.Size(77, 21);
            this.lbl1st.TabIndex = 1;
            this.lbl1st.Text = "1st.  Field";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "fileChooserCompleteRecord";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(869, 26);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 36);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDrawCharts
            // 
            this.btnDrawCharts.BackColor = System.Drawing.Color.LightCyan;
            this.btnDrawCharts.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDrawCharts.FlatAppearance.BorderSize = 3;
            this.btnDrawCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawCharts.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawCharts.Location = new System.Drawing.Point(553, 554);
            this.btnDrawCharts.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawCharts.Name = "btnDrawCharts";
            this.btnDrawCharts.Size = new System.Drawing.Size(347, 54);
            this.btnDrawCharts.TabIndex = 28;
            this.btnDrawCharts.Text = "Draw Pie-Chart/Line-Plot/Bar-Graph";
            this.btnDrawCharts.UseVisualStyleBackColor = false;
            // 
            // btnOpenOrComputer
            // 
            this.btnOpenOrComputer.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOpenOrComputer.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnOpenOrComputer.FlatAppearance.BorderSize = 3;
            this.btnOpenOrComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenOrComputer.Font = new System.Drawing.Font("Centaur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOrComputer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenOrComputer.Location = new System.Drawing.Point(3, 545);
            this.btnOpenOrComputer.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenOrComputer.Name = "btnOpenOrComputer";
            this.btnOpenOrComputer.Size = new System.Drawing.Size(325, 38);
            this.btnOpenOrComputer.TabIndex = 27;
            this.btnOpenOrComputer.Text = "Open (Compute and Show)";
            this.btnOpenOrComputer.UseVisualStyleBackColor = false;
            this.btnOpenOrComputer.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.LightCyan;
            this.btnSwap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSwap.FlatAppearance.BorderSize = 3;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwap.Location = new System.Drawing.Point(3, 602);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(325, 43);
            this.btnSwap.TabIndex = 30;
            this.btnSwap.Text = "Click to Swap(OPEN or COMPUTER)";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // Frm4GradeQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 662);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDrawCharts);
            this.Controls.Add(this.btnOpenOrComputer);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.grpBox_BasicsProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm4GradeQuery";
            this.Text = "Query of Grade-Book";
            this.dataGridView.ResumeLayout(false);
            this.dataGridView_BeforeProcess.ResumeLayout(false);
            this.dataGridView_Completed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Read)).EndInit();
            this.grpBox_BasicsProfile.ResumeLayout(false);
            this.grpBox_BasicsProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl dataGridView;
        private System.Windows.Forms.TabPage dataGridView_BeforeProcess;
        public System.Windows.Forms.CheckedListBox checkedListBox_Create;
        private System.Windows.Forms.TabPage dataGridView_Completed;
        private System.Windows.Forms.DataGridView dataGridView_Read;
        private System.Windows.Forms.GroupBox grpBox_BasicsProfile;
        public System.Windows.Forms.TextBox txtBox8th;
        public System.Windows.Forms.TextBox txtBox7th;
        public System.Windows.Forms.TextBox txtBox6th;
        public System.Windows.Forms.TextBox txtBox5th;
        public System.Windows.Forms.TextBox txtBox4th;
        public System.Windows.Forms.TextBox txtBox3rd;
        public System.Windows.Forms.TextBox txtBox2nd;
        public System.Windows.Forms.TextBox txtBox1st;
        public System.Windows.Forms.Label lbl8th;
        public System.Windows.Forms.Label lbl7th;
        public System.Windows.Forms.Label lbl6th;
        public System.Windows.Forms.Label lbl5th;
        public System.Windows.Forms.Label lbl4th;
        public System.Windows.Forms.Label lbl3rd;
        public System.Windows.Forms.Label lbl2nd;
        public System.Windows.Forms.Label lbl1st;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnDrawCharts;
        public System.Windows.Forms.Button btnOpenOrComputer;
        public System.Windows.Forms.Button btnSwap;
    }
}

