namespace baiduApi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lngLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mylngLabel = new System.Windows.Forms.Label();
            this.mylatsLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.地图功能空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawPointToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getReultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPositonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browerIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resultLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.positonlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(1, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 457);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(575, 463);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lngLabel
            // 
            this.lngLabel.AutoSize = true;
            this.lngLabel.Location = new System.Drawing.Point(275, 497);
            this.lngLabel.Name = "lngLabel";
            this.lngLabel.Size = new System.Drawing.Size(0, 12);
            this.lngLabel.TabIndex = 2;
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(55, 497);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(0, 12);
            this.latLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "经度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "维度：";
            // 
            // mylngLabel
            // 
            this.mylngLabel.AutoSize = true;
            this.mylngLabel.Location = new System.Drawing.Point(547, 497);
            this.mylngLabel.Name = "mylngLabel";
            this.mylngLabel.Size = new System.Drawing.Size(0, 12);
            this.mylngLabel.TabIndex = 10;
            // 
            // mylatsLabel
            // 
            this.mylatsLabel.AutoSize = true;
            this.mylatsLabel.Location = new System.Drawing.Point(486, 497);
            this.mylatsLabel.Name = "mylatsLabel";
            this.mylatsLabel.Size = new System.Drawing.Size(0, 12);
            this.mylatsLabel.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(606, 373);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 112);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // 地图功能空间ToolStripMenuItem
            // 
            this.地图功能空间ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.地图功能空间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getLocationToolStripMenuItem,
            this.openDistanceToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.getPositonToolStripMenuItem,
            this.browerIPToolStripMenuItem});
            this.地图功能空间ToolStripMenuItem.Name = "地图功能空间ToolStripMenuItem";
            this.地图功能空间ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.地图功能空间ToolStripMenuItem.Text = "地图功能控件";
            // 
            // getLocationToolStripMenuItem
            // 
            this.getLocationToolStripMenuItem.Name = "getLocationToolStripMenuItem";
            this.getLocationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.getLocationToolStripMenuItem.Text = "开启实时坐标";
            this.getLocationToolStripMenuItem.Click += new System.EventHandler(this.getLocationToolStripMenuItem_Click);
            // 
            // openDistanceToolStripMenuItem
            // 
            this.openDistanceToolStripMenuItem.Name = "openDistanceToolStripMenuItem";
            this.openDistanceToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openDistanceToolStripMenuItem.Text = "开启测距工具";
            this.openDistanceToolStripMenuItem.Click += new System.EventHandler(this.openDistanceToolStripMenuItem_Click);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawPointToolStripMenuItem1,
            this.closeDrawToolStripMenuItem,
            this.getReultToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.drawToolStripMenuItem.Text = "绘制点线面";
            // 
            // drawPointToolStripMenuItem1
            // 
            this.drawPointToolStripMenuItem1.Name = "drawPointToolStripMenuItem1";
            this.drawPointToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.drawPointToolStripMenuItem1.Text = "绘制点线面";
            this.drawPointToolStripMenuItem1.Click += new System.EventHandler(this.drawPointToolStripMenuItem1_Click);
            // 
            // closeDrawToolStripMenuItem
            // 
            this.closeDrawToolStripMenuItem.Name = "closeDrawToolStripMenuItem";
            this.closeDrawToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closeDrawToolStripMenuItem.Text = "关闭绘制";
            this.closeDrawToolStripMenuItem.Click += new System.EventHandler(this.closeDrawToolStripMenuItem_Click);
            // 
            // getReultToolStripMenuItem
            // 
            this.getReultToolStripMenuItem.Name = "getReultToolStripMenuItem";
            this.getReultToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.getReultToolStripMenuItem.Text = "获取结果";
            this.getReultToolStripMenuItem.Click += new System.EventHandler(this.getReultToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clearToolStripMenuItem.Text = "清除界面";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // getPositonToolStripMenuItem
            // 
            this.getPositonToolStripMenuItem.Name = "getPositonToolStripMenuItem";
            this.getPositonToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.getPositonToolStripMenuItem.Text = "获取当前坐标";
            this.getPositonToolStripMenuItem.Click += new System.EventHandler(this.getPositonToolStripMenuItem_Click);
            // 
            // browerIPToolStripMenuItem
            // 
            this.browerIPToolStripMenuItem.Name = "browerIPToolStripMenuItem";
            this.browerIPToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.browerIPToolStripMenuItem.Text = "获取浏览器IP";
            this.browerIPToolStripMenuItem.Click += new System.EventHandler(this.browerIPToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.informationToolStripMenuItem.Text = "坐标信息范例";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.地图功能空间ToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(405, 488);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 12);
            this.resultLabel.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(606, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // positonlabel
            // 
            this.positonlabel.AutoSize = true;
            this.positonlabel.Location = new System.Drawing.Point(606, 38);
            this.positonlabel.Name = "positonlabel";
            this.positonlabel.Size = new System.Drawing.Size(71, 12);
            this.positonlabel.TabIndex = 20;
            this.positonlabel.Text = "请选择地点:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.positonlabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.mylatsLabel);
            this.Controls.Add(this.mylngLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lngLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lngLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mylngLabel;
        private System.Windows.Forms.Label mylatsLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawPointToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getReultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPositonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browerIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openDistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图功能空间ToolStripMenuItem;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label positonlabel;
    }
}

