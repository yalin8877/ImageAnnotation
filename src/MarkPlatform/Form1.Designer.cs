namespace MarkPlatform
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.textBox_lowscore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_highscore = new System.Windows.Forms.TextBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_nextpage = new System.Windows.Forms.Button();
            this.button_frontpage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_marktype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_imgnum = new System.Windows.Forms.Label();
            this.button_openfile = new System.Windows.Forms.Button();
            this.textBox_filepath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_page = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_currentpage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_totalpage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.label_savestatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_markednum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_itemperpage = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.CheckBoxes = true;
            this.listView.LargeImageList = this.imageList1;
            this.listView.Location = new System.Drawing.Point(10, 16);
            this.listView.Name = "listView";
            this.listView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView.RightToLeftLayout = true;
            this.listView.Size = new System.Drawing.Size(937, 465);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(131, 131);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(405, 38);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(78, 20);
            this.comboBox_class.TabIndex = 1;
            // 
            // textBox_lowscore
            // 
            this.textBox_lowscore.Location = new System.Drawing.Point(500, 39);
            this.textBox_lowscore.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_lowscore.Name = "textBox_lowscore";
            this.textBox_lowscore.Size = new System.Drawing.Size(43, 21);
            this.textBox_lowscore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // textBox_highscore
            // 
            this.textBox_highscore.Location = new System.Drawing.Point(561, 39);
            this.textBox_highscore.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_highscore.Name = "textBox_highscore";
            this.textBox_highscore.Size = new System.Drawing.Size(43, 21);
            this.textBox_highscore.TabIndex = 4;
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(716, 38);
            this.button_filter.Margin = new System.Windows.Forms.Padding(2);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(56, 20);
            this.button_filter.TabIndex = 5;
            this.button_filter.Text = "筛选";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // button_nextpage
            // 
            this.button_nextpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nextpage.Location = new System.Drawing.Point(654, 586);
            this.button_nextpage.Margin = new System.Windows.Forms.Padding(2);
            this.button_nextpage.Name = "button_nextpage";
            this.button_nextpage.Size = new System.Drawing.Size(56, 20);
            this.button_nextpage.TabIndex = 6;
            this.button_nextpage.Text = "下一页";
            this.button_nextpage.UseVisualStyleBackColor = true;
            this.button_nextpage.Click += new System.EventHandler(this.button_nextpage_Click);
            // 
            // button_frontpage
            // 
            this.button_frontpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_frontpage.Location = new System.Drawing.Point(593, 586);
            this.button_frontpage.Margin = new System.Windows.Forms.Padding(2);
            this.button_frontpage.Name = "button_frontpage";
            this.button_frontpage.Size = new System.Drawing.Size(56, 20);
            this.button_frontpage.TabIndex = 7;
            this.button_frontpage.Text = "上一页";
            this.button_frontpage.UseVisualStyleBackColor = true;
            this.button_frontpage.Click += new System.EventHandler(this.button_frontpage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_marktype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_imgnum);
            this.groupBox1.Controls.Add(this.button_openfile);
            this.groupBox1.Controls.Add(this.button_filter);
            this.groupBox1.Controls.Add(this.textBox_highscore);
            this.groupBox1.Controls.Add(this.textBox_filepath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_class);
            this.groupBox1.Controls.Add(this.textBox_lowscore);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(951, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(866, 37);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(72, 20);
            this.button_start.TabIndex = 15;
            this.button_start.Text = "开始标注";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "记录图片在多个概念上得分的文件:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "选择标记类型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "分数区间:";
            // 
            // comboBox_marktype
            // 
            this.comboBox_marktype.FormattingEnabled = true;
            this.comboBox_marktype.Location = new System.Drawing.Point(618, 39);
            this.comboBox_marktype.Name = "comboBox_marktype";
            this.comboBox_marktype.Size = new System.Drawing.Size(81, 20);
            this.comboBox_marktype.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "选择概念:";
            // 
            // label_imgnum
            // 
            this.label_imgnum.AutoSize = true;
            this.label_imgnum.Location = new System.Drawing.Point(781, 41);
            this.label_imgnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_imgnum.Name = "label_imgnum";
            this.label_imgnum.Size = new System.Drawing.Size(65, 12);
            this.label_imgnum.TabIndex = 11;
            this.label_imgnum.Text = "共0 张图片";
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(338, 37);
            this.button_openfile.Margin = new System.Windows.Forms.Padding(2);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(62, 20);
            this.button_openfile.TabIndex = 10;
            this.button_openfile.Text = "打开文件";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.Location = new System.Drawing.Point(10, 40);
            this.textBox_filepath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.Size = new System.Drawing.Size(324, 21);
            this.textBox_filepath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Location = new System.Drawing.Point(10, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(951, 494);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // comboBox_page
            // 
            this.comboBox_page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_page.FormattingEnabled = true;
            this.comboBox_page.Location = new System.Drawing.Point(514, 585);
            this.comboBox_page.Name = "comboBox_page";
            this.comboBox_page.Size = new System.Drawing.Size(46, 20);
            this.comboBox_page.TabIndex = 25;
            this.comboBox_page.SelectedIndexChanged += new System.EventHandler(this.comboBox_page_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 590);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "页";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 589);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "第";
            // 
            // label_currentpage
            // 
            this.label_currentpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_currentpage.AutoSize = true;
            this.label_currentpage.Location = new System.Drawing.Point(18, 589);
            this.label_currentpage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentpage.Name = "label_currentpage";
            this.label_currentpage.Size = new System.Drawing.Size(11, 12);
            this.label_currentpage.TabIndex = 10;
            this.label_currentpage.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 589);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // label_totalpage
            // 
            this.label_totalpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalpage.AutoSize = true;
            this.label_totalpage.Location = new System.Drawing.Point(57, 590);
            this.label_totalpage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalpage.Name = "label_totalpage";
            this.label_totalpage.Size = new System.Drawing.Size(11, 12);
            this.label_totalpage.TabIndex = 12;
            this.label_totalpage.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 590);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "状态:";
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(270, 590);
            this.label_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 12);
            this.label_status.TabIndex = 16;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(885, 585);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(72, 20);
            this.button_save.TabIndex = 17;
            this.button_save.Text = "保存更新";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_savestatus
            // 
            this.label_savestatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_savestatus.AutoSize = true;
            this.label_savestatus.Location = new System.Drawing.Point(814, 590);
            this.label_savestatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_savestatus.Name = "label_savestatus";
            this.label_savestatus.Size = new System.Drawing.Size(0, 12);
            this.label_savestatus.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(734, 590);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "已选:";
            // 
            // label_markednum
            // 
            this.label_markednum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_markednum.AutoSize = true;
            this.label_markednum.Location = new System.Drawing.Point(766, 590);
            this.label_markednum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_markednum.Name = "label_markednum";
            this.label_markednum.Size = new System.Drawing.Size(0, 12);
            this.label_markednum.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 590);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "每页显示         个";
            // 
            // comboBox_itemperpage
            // 
            this.comboBox_itemperpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_itemperpage.FormattingEnabled = true;
            this.comboBox_itemperpage.Location = new System.Drawing.Point(141, 586);
            this.comboBox_itemperpage.Name = "comboBox_itemperpage";
            this.comboBox_itemperpage.Size = new System.Drawing.Size(46, 20);
            this.comboBox_itemperpage.TabIndex = 17;
            this.comboBox_itemperpage.SelectedIndexChanged += new System.EventHandler(this.comboBox_itemperpage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 614);
            this.Controls.Add(this.label_currentpage);
            this.Controls.Add(this.comboBox_page);
            this.Controls.Add(this.comboBox_itemperpage);
            this.Controls.Add(this.label_markednum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_savestatus);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_totalpage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_frontpage);
            this.Controls.Add(this.button_nextpage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标注平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.TextBox textBox_lowscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_highscore;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_nextpage;
        private System.Windows.Forms.Button button_frontpage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.TextBox textBox_filepath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_imgnum;
        private System.Windows.Forms.Label label_currentpage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_totalpage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_savestatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_markednum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_marktype;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_itemperpage;
        private System.Windows.Forms.ComboBox comboBox_page;
    }
}

