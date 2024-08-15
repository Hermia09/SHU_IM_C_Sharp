
namespace MDIForms4AnyBook_Huang0045
{
    partial class MDIForms4AnyBook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquiryTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquiryBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.windowToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTextToolStripMenuItem,
            this.readTextToolStripMenuItem,
            this.inquiryTextToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // createTextToolStripMenuItem
            // 
            this.createTextToolStripMenuItem.Name = "createTextToolStripMenuItem";
            this.createTextToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.createTextToolStripMenuItem.Text = "Create (Text)";
            this.createTextToolStripMenuItem.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // readTextToolStripMenuItem
            // 
            this.readTextToolStripMenuItem.Name = "readTextToolStripMenuItem";
            this.readTextToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.readTextToolStripMenuItem.Text = "Read (Text)";
            this.readTextToolStripMenuItem.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // inquiryTextToolStripMenuItem
            // 
            this.inquiryTextToolStripMenuItem.Name = "inquiryTextToolStripMenuItem";
            this.inquiryTextToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.inquiryTextToolStripMenuItem.Text = "Inquiry (Text)";
            this.inquiryTextToolStripMenuItem.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBinaryToolStripMenuItem,
            this.readBinaryToolStripMenuItem,
            this.inquiryBinaryToolStripMenuItem});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.binaryToolStripMenuItem.Text = "Binary";
            // 
            // createBinaryToolStripMenuItem
            // 
            this.createBinaryToolStripMenuItem.Name = "createBinaryToolStripMenuItem";
            this.createBinaryToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.createBinaryToolStripMenuItem.Text = "Create (Binary)";
            this.createBinaryToolStripMenuItem.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // readBinaryToolStripMenuItem
            // 
            this.readBinaryToolStripMenuItem.Name = "readBinaryToolStripMenuItem";
            this.readBinaryToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.readBinaryToolStripMenuItem.Text = "Read (Binary)";
            this.readBinaryToolStripMenuItem.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // inquiryBinaryToolStripMenuItem
            // 
            this.inquiryBinaryToolStripMenuItem.Name = "inquiryBinaryToolStripMenuItem";
            this.inquiryBinaryToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.inquiryBinaryToolStripMenuItem.Text = "Inquiry (Binary)";
            this.inquiryBinaryToolStripMenuItem.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // windowToolStripMenuItem1
            // 
            this.windowToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem1,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.windowToolStripMenuItem1.Name = "windowToolStripMenuItem1";
            this.windowToolStripMenuItem1.Size = new System.Drawing.Size(82, 23);
            this.windowToolStripMenuItem1.Text = "Window";
            // 
            // cascadeToolStripMenuItem1
            // 
            this.cascadeToolStripMenuItem1.Name = "cascadeToolStripMenuItem1";
            this.cascadeToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.cascadeToolStripMenuItem1.Text = "Cascade";
            this.cascadeToolStripMenuItem1.Click += new System.EventHandler(this.LayoutToolStripMenuItem1_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.LayoutToolStripMenuItem1_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.LayoutToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.BankAppToolStripMenuItem);
            // 
            // MDIForms4AnyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDIForms4AnyBook";
            this.Text = "MDI Form for Any-Book App ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquiryTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquiryBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

