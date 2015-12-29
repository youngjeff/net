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
            this.btnGetLocation = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.latLabel = new System.Windows.Forms.Label();
            this.lngLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenDistance = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNoDraw = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.mylngLabel = new System.Windows.Forms.Label();
            this.mylatLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetBrower = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 473);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(575, 482);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnGetLocation
            // 
            this.btnGetLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetLocation.Location = new System.Drawing.Point(629, 39);
            this.btnGetLocation.Name = "btnGetLocation";
            this.btnGetLocation.Size = new System.Drawing.Size(101, 23);
            this.btnGetLocation.TabIndex = 1;
            this.btnGetLocation.Text = "开启实时坐标";
            this.btnGetLocation.UseVisualStyleBackColor = true;
            this.btnGetLocation.Click += new System.EventHandler(this.btnGetLocation_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(292, 497);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(0, 12);
            this.latLabel.TabIndex = 2;
            // 
            // lngLabel
            // 
            this.lngLabel.AutoSize = true;
            this.lngLabel.Location = new System.Drawing.Point(55, 497);
            this.lngLabel.Name = "lngLabel";
            this.lngLabel.Size = new System.Drawing.Size(0, 12);
            this.lngLabel.TabIndex = 2;
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
            // btnOpenDistance
            // 
            this.btnOpenDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDistance.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenDistance.Location = new System.Drawing.Point(629, 104);
            this.btnOpenDistance.Name = "btnOpenDistance";
            this.btnOpenDistance.Size = new System.Drawing.Size(101, 23);
            this.btnOpenDistance.TabIndex = 3;
            this.btnOpenDistance.Text = "开启测距工具";
            this.btnOpenDistance.UseVisualStyleBackColor = false;
            this.btnOpenDistance.Click += new System.EventHandler(this.btnOpenDistance_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(0, 20);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(101, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "绘制点线面";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(0, 121);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(101, 23);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "获取结果";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(125, 126);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 12);
            this.resultLabel.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(0, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除界面";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // btnNoDraw
            // 
            this.btnNoDraw.Location = new System.Drawing.Point(0, 69);
            this.btnNoDraw.Name = "btnNoDraw";
            this.btnNoDraw.Size = new System.Drawing.Size(101, 23);
            this.btnNoDraw.TabIndex = 8;
            this.btnNoDraw.Text = "关闭绘制点线面";
            this.btnNoDraw.UseVisualStyleBackColor = true;
            this.btnNoDraw.Click += new System.EventHandler(this.btnNoDraw_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPosition.Location = new System.Drawing.Point(629, 405);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(101, 23);
            this.btnGetPosition.TabIndex = 9;
            this.btnGetPosition.Text = "获取当前坐标";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // mylngLabel
            // 
            this.mylngLabel.AutoSize = true;
            this.mylngLabel.Location = new System.Drawing.Point(754, 473);
            this.mylngLabel.Name = "mylngLabel";
            this.mylngLabel.Size = new System.Drawing.Size(0, 12);
            this.mylngLabel.TabIndex = 10;
            // 
            // mylatLabel
            // 
            this.mylatLabel.AutoSize = true;
            this.mylatLabel.Location = new System.Drawing.Point(868, 473);
            this.mylatLabel.Name = "mylatLabel";
            this.mylatLabel.Size = new System.Drawing.Size(0, 12);
            this.mylatLabel.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnNoDraw);
            this.groupBox1.Controls.Add(this.btnDraw);
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Location = new System.Drawing.Point(629, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 209);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绘制点的控件";
            // 
            // btnGetBrower
            // 
            this.btnGetBrower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetBrower.Location = new System.Drawing.Point(629, 462);
            this.btnGetBrower.Name = "btnGetBrower";
            this.btnGetBrower.Size = new System.Drawing.Size(101, 23);
            this.btnGetBrower.TabIndex = 13;
            this.btnGetBrower.Text = "获取浏览器IP";
            this.btnGetBrower.UseVisualStyleBackColor = true;
            this.btnGetBrower.Click += new System.EventHandler(this.btnGetBrower_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(808, 38);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(122, 24);
            this.btnInformation.TabIndex = 14;
            this.btnInformation.Text = "坐标信息范例";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(808, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 167);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnGetBrower);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mylatLabel);
            this.Controls.Add(this.mylngLabel);
            this.Controls.Add(this.btnGetPosition);
            this.Controls.Add(this.btnOpenDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lngLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.btnGetLocation);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnGetLocation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lngLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenDistance;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNoDraw;
        private System.Windows.Forms.Button btnGetPosition;
        private System.Windows.Forms.Label mylngLabel;
        private System.Windows.Forms.Label mylatLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetBrower;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

