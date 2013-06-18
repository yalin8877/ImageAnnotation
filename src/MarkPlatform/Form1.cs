using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MarkPlatform
{
    public partial class Form1 : Form
    {
        public MarkInfo markinfo=new MarkInfo();

        public Form1()
        {
            InitializeComponent();
            FormDataInit();
        }

        public void FormDataInit()
        {
            markinfo.MarkInfoInit();

            this.comboBox_class.Items.Clear();

            this.textBox_lowscore.Text = "";
            this.textBox_highscore.Text = "";

            this.textBox_filepath.Text = "";

            this.label_imgnum.Text = "共0 张图片";

            this.listView.Clear();

            this.label_currentpage.Text = markinfo.iCurrentPage.ToString();
            this.label_totalpage.Text = markinfo.iTotalPage.ToString();

            this.label_savestatus.Text = "";
            this.label_markednum.Text = "";

            this.comboBox_marktype.Items.Clear();
            this.comboBox_marktype.Items.Add("正例");
            this.comboBox_marktype.Items.Add("负例");
            this.comboBox_marktype.SelectedIndex = 0;

            this.comboBox_itemperpage.Items.Clear();
            for (int i = 1; i <= 50; i++)
            {
                this.comboBox_itemperpage.Items.Add(i.ToString());
            }
            this.comboBox_itemperpage.SelectedIndex = markinfo.imgPerPage - 1;

            this.comboBox_page.Items.Clear();
        }

        private void button_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.InitialDirectory = "C:\\";
            filedialog.Filter = "all files|*.*";
            filedialog.RestoreDirectory = false;
            filedialog.FilterIndex = 1;
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                FormDataInit();

                markinfo.strScoreFilePath = filedialog.FileName;
                textBox_filepath.Text = markinfo.strScoreFilePath;

                this.label_status.Text = "文件加载中，请稍候...";
                FileStream fs = new FileStream(markinfo.strScoreFilePath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string strLine = "";
                try
                {
                    //读入文件第一行的n个分类名称
                    strLine = sr.ReadLine();
                    if (strLine != null)
                    {
                        string[] classes = strLine.Split();
                        for (int i = 1; i < classes.Count(); i++)
                        {
                            if(classes==null)
                                break;
                            markinfo.arrClassStrings.Add(classes[i]);
                            comboBox_class.Items.Add(classes[i]);
                            Console.WriteLine(classes[i]);
                        }
                        //Console.WriteLine("概念个数为" + markinfo.arrClassStrings.Count.ToString());

                        comboBox_class.SelectedIndex = 0;
                        markinfo.iChoosedClassID = comboBox_class.SelectedIndex;
                        markinfo.strChoosedClass = (string)comboBox_class.SelectedItem;
                        //Console.WriteLine(markinfo.strChoosedClass);
                        //Console.WriteLine(markinfo.iChoosedClassID);
                    }
                    else
                    {
                        MessageBox.Show("加载文件为空，请重新加载！");
                        return;
                    }

                    //读入一行：图片路径 第1个类别得分 ... 第n个类别的分
                    strLine = sr.ReadLine();
                    while (strLine != null)
                    {
                        string[] fileLine = strLine.Split();
                        //Console.WriteLine("fileLine中字符串个数为"+fileLine.Count().ToString());
                        ImgInfo imgInfo = new ImgInfo();
                        imgInfo.imgscores.Clear();
                        imgInfo.imgpath = fileLine[0];
                        for (int i = 1; i < markinfo.arrClassStrings.Count; i++)
                        {
                            int score = Int32.Parse(fileLine[i]);
                            imgInfo.imgscores.Add(score);
                            //Console.WriteLine(score);
                        }
                        markinfo.arrImgInfos.Add(imgInfo);
                        strLine = sr.ReadLine();
                    }
                    markinfo.iImgCount = markinfo.arrImgInfos.Count;
                    sr.Close();
                    this.label_status.Text = "文件加载完毕";
                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            markinfo.arrResultInfos.Clear();

            markinfo.iChoosedClassID = comboBox_class.SelectedIndex;
            markinfo.strChoosedClass = (string)comboBox_class.SelectedItem;
            //Console.WriteLine(markinfo.strChoosedClass);
            //Console.WriteLine(markinfo.iChoosedClassID);

            try
            {
                markinfo.iLowScore = Int32.Parse(textBox_lowscore.Text);
                markinfo.iHighScore = Int32.Parse(textBox_highscore.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("分数范围输入错误！");
            }

            for (int i = 0; i < markinfo.arrImgInfos.Count;i++ )
            {
                int score=(int)((ImgInfo)markinfo.arrImgInfos[i]).imgscores[markinfo.iChoosedClassID];
                if (score >= markinfo.iLowScore && score <= markinfo.iHighScore)
                {
                    ResultInfo temp = new ResultInfo();
                    temp.ImgIndex = i;
                    temp.iMark = 0;
                    temp.score = score;
                    markinfo.arrResultInfos.Add(temp);
                }
            }

            markinfo.bMarkPositive = (comboBox_marktype.SelectedIndex == 0) ? true : false;
            if (markinfo.bMarkPositive)
            {
                ResultInfoAscent sr = new ResultInfoAscent();
                markinfo.arrResultInfos.Sort(sr);
            }
            else
            {
                ResultInfoDescent sr = new ResultInfoDescent();
                markinfo.arrResultInfos.Sort(sr);
            }

            markinfo.iImgCount = markinfo.arrResultInfos.Count;
            this.label_imgnum.Text = "共" + markinfo.iImgCount.ToString() + " 张图片";

            //test_img_number_statistic();
            
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            string resultfile = "..\\result_file\\" + markinfo.strChoosedClass + "_" +
                markinfo.iLowScore.ToString() + "_" +
                markinfo.iHighScore.ToString() + "_" +
                (string)comboBox_marktype.SelectedItem + ".MARK";
            markinfo.strResultFilePath = resultfile;
            //Console.WriteLine(markinfo.strResultFilePath);
            if (!File.Exists(markinfo.strResultFilePath))
            {
                //生成标注文件
                File.CreateText(markinfo.strResultFilePath).Close();
                this.label_status.Text = "标注文件生成中，请稍候...";
                SaveResult2File();
                MessageBox.Show("已生成文件\n" + markinfo.strResultFilePath + " !");
                this.label_status.Text = "标注文件 " + markinfo.strResultFilePath;
            }
            else
            {
                DialogResult dr = MessageBox.Show(markinfo.strResultFilePath + "文件已存在\n加载（Yes）/覆盖（No）/取消(Cancel)？",
                    "警告！", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    //加载已有标注文件
                    if (!LoadResultFromFile())
                        return;
                }
                else if (dr == DialogResult.No)
                {
                    //覆盖以后标注文件
                    File.Delete(markinfo.strResultFilePath);
                    File.CreateText(markinfo.strResultFilePath).Close();
                    this.label_status.Text = "标注文件覆盖中，请稍候...";
                    SaveResult2File();
                    MessageBox.Show("已覆盖文件\n" + markinfo.strResultFilePath + " !");
                    this.label_status.Text = "标注文件 " + markinfo.strResultFilePath;
                }
                else
                    return;
            }

            //will lead to comboBox_page_SelectedIndexChanged() which enables RefreshListView();
            CountPageNum();

            RefreshLabelMarkedNum();
        }

        private void test_img_number_statistic()
        {
            MarkInfo mi = new MarkInfo();
            mi.arrResultInfos.Clear();
            mi.strResultFilePath = "..\\result_file\\" + markinfo.strChoosedClass + "_" +
                markinfo.iLowScore.ToString() + "_" +
                markinfo.iHighScore.ToString() + "_" +
                (string)comboBox_marktype.SelectedItem + ".MARK";

            FileStream fs = new FileStream(mi.strResultFilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            try
            {
                string strLine = "";
                strLine = sr.ReadLine();
                for (int i=0;strLine!=null;i++)
                {
                    string[] linestrs = strLine.Split();
                    ResultInfo resInfo = new ResultInfo();

                    resInfo.ImgIndex=Int32.Parse(linestrs[0]);
                    resInfo.iMark = Int32.Parse(linestrs[2]);
                    mi.arrResultInfos.Add(resInfo);
                    
                    strLine = sr.ReadLine();
                }

                sr.Close();
                fs.Close();

                //count the images number from the 1st image to the last marked image
                for (int i = mi.arrResultInfos.Count - 1; i >= 0; i--)
                {
                    if (((ResultInfo)(mi.arrResultInfos[i])).iMark == 1)
                    {
                        MessageBox.Show(i.ToString());
                        break;
                    }
                }
            }
            catch (IOException ex)
            {
                sr.Close();
                fs.Close();
                throw ex;
            }
        }

        public void CountPageNum()
        {
            markinfo.iCurrentPage = 1;
            markinfo.iTotalPage = markinfo.iImgCount / markinfo.imgPerPage;
            if (markinfo.iImgCount % markinfo.imgPerPage != 0)
                markinfo.iTotalPage++;

            this.comboBox_page.Items.Clear();
            for (int i = 1; i <= markinfo.iTotalPage;i++ )
            {
                this.comboBox_page.Items.Add(i.ToString());
            }
            this.comboBox_page.SelectedIndex = markinfo.iCurrentPage - 1;
        }

        public void RefreshLabelMarkedNum()
        {
            int markednum = 0;
            for (int i = 0; i < markinfo.arrResultInfos.Count;i++ )
            {
                if (((ResultInfo)(markinfo.arrResultInfos[i])).iMark==1)
                {
                    markednum++;
                }
            }
            this.label_markednum.Text = markednum.ToString();
        }

        public void RefreshListView()
        {
            if (markinfo.iCurrentPage == 0 || markinfo.iTotalPage==0)
                return;

            label_currentpage.Text = markinfo.iCurrentPage.ToString();
            label_totalpage.Text = markinfo.iTotalPage.ToString();

            //显示图片列表
            this.label_status.Text = "图像加载中，请稍后...";
            this.listView.Items.Clear();
            this.imageList1.Images.Clear();

            int imgnum;
            if (markinfo.iCurrentPage == markinfo.iTotalPage)
                imgnum = markinfo.iImgCount % markinfo.imgPerPage;
            else
                imgnum = markinfo.imgPerPage;

            for (int i = 0; i < imgnum; i++)
            {
                int resultindex = i + (markinfo.iCurrentPage - 1) * markinfo.imgPerPage;
                int index = ((ResultInfo)(markinfo.arrResultInfos[resultindex])).ImgIndex;
                string imgpath = ((ImgInfo)markinfo.arrImgInfos[index]).imgpath;
                int mark = ((ResultInfo)(markinfo.arrResultInfos[resultindex])).iMark;
                this.imageList1.Images.Add(Image.FromFile(imgpath));
                listView.Items.Add(imgpath);
                listView.Items[i].ImageIndex = i;
                listView.Items[i].Checked = (mark == 1);
            }
            this.listView.Refresh();
            //this.label_status.Text = "图像加载完毕";
            this.label_status.Text = "标注文件 " + markinfo.strResultFilePath;
        }

        public bool LoadResultFromFile()
        {
            FileStream fs = new FileStream(markinfo.strResultFilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            try
            {
                markinfo.arrResultInfos.Clear();
                ResultInfo resInfo;
                string strLine = "";
                strLine = sr.ReadLine();
                for (int i=0;strLine!=null;i++)
                {
                    string[] linestrs = strLine.Split();
                    resInfo = new ResultInfo();
                    resInfo.ImgIndex=Int32.Parse(linestrs[0]);
                    if (((ImgInfo)(markinfo.arrImgInfos)[resInfo.ImgIndex]).imgpath.Equals(linestrs[1]))
                    {
                        resInfo.iMark = Int32.Parse(linestrs[2]);
                        markinfo.arrResultInfos.Add(resInfo);
                    }
                    else
                    {
                        MessageBox.Show("加载文件不一致，可能有错误发生！");
                        markinfo.arrResultInfos.Clear();
                        markinfo.iImgCount=0;
                        sr.Close();
                        fs.Close();
                        return false;
                    }
                    strLine = sr.ReadLine();
                }
                markinfo.iImgCount = markinfo.arrResultInfos.Count;
                sr.Close();
                fs.Close();
                return true;
            }
            catch (IOException ex)
            {
                sr.Close();
                fs.Close();
                throw ex;
            }
        }

        public void SaveResult2File()
        {
            FileStream fs = new FileStream(markinfo.strResultFilePath, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                for (int i = 0; i < markinfo.arrResultInfos.Count; i++)
                {
                    int index = ((ResultInfo)markinfo.arrResultInfos[i]).ImgIndex;
                    string imgpath = ((ImgInfo)markinfo.arrImgInfos[index]).imgpath;
                    int mark = ((ResultInfo)markinfo.arrResultInfos[i]).iMark;
                    sw.Write(index.ToString()+" ");
                    sw.Write(imgpath + " ");
                    sw.WriteLine(mark);
                }
                sw.Close();
                fs.Close();
                RefreshLabelMarkedNum();
            }
            catch (IOException ex)
            {
                sw.Close();
                fs.Close();
                throw ex;
            }
        }

        public void SaveCurrentPage2Memory()
        {
            int imgnum;
            if (markinfo.iCurrentPage == markinfo.iTotalPage)
                imgnum = markinfo.iImgCount % markinfo.imgPerPage;
            else
                imgnum = markinfo.imgPerPage;

            for (int i = 0; i < imgnum; i++)
            {
                int imark = 0;
                if (listView.Items[i].Checked)
                    imark = 1;

                int resultIndex = i + (markinfo.iCurrentPage - 1) * markinfo.imgPerPage;
                ((ResultInfo)(markinfo.arrResultInfos)[resultIndex]).iMark = imark;
            }
        }

        private void button_frontpage_Click(object sender, EventArgs e)
        {
            this.label_savestatus.Text = "";

            if (markinfo.iCurrentPage==0)
                return;

            SaveCurrentPage2Memory();

            if (markinfo.iCurrentPage==1)
            {
                MessageBox.Show("已翻至第一页！");
                return;
            }
            
            markinfo.iCurrentPage--;
            this.comboBox_page.SelectedIndex = markinfo.iCurrentPage - 1;
            //RefreshListView();
        }

        private void button_nextpage_Click(object sender, EventArgs e)
        {
            this.label_savestatus.Text = "";

            SaveCurrentPage2Memory();

            if (markinfo.iCurrentPage == markinfo.iTotalPage)
            {
                if (File.Exists(markinfo.strResultFilePath))
                {
                    File.Delete(markinfo.strResultFilePath);
                    File.CreateText(markinfo.strResultFilePath).Close();
                    this.label_status.Text = "标注文件保存中，请稍候...";
                    SaveResult2File();
                    this.label_status.Text = "标注文件 " + markinfo.strResultFilePath;
                }
                MessageBox.Show("全部标注完! 结果保存在:\n" + markinfo.strResultFilePath);
                return;
            }
            markinfo.iCurrentPage++;
            this.comboBox_page.SelectedIndex = markinfo.iCurrentPage - 1;
            //RefreshListView();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveCurrentPage2Memory();
            if (File.Exists(markinfo.strResultFilePath))
            {
                File.Delete(markinfo.strResultFilePath);
                File.CreateText(markinfo.strResultFilePath).Close();
                this.label_status.Text = "标注文件保存中，请稍候...";
                SaveResult2File();
                this.label_savestatus.Text = "更新已保存.";
                this.label_status.Text = "标注文件 " + markinfo.strResultFilePath;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.PageUp)
            {
                button_frontpage.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.PageDown)
            {
                button_nextpage.PerformClick();
                e.Handled = true;
            }
            else if (e.Control==true && e.KeyCode == Keys.S)
            {
                button_save.PerformClick();
                e.Handled = true;
            }
        }

        private void comboBox_itemperpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (markinfo.iTotalPage == 0)
                return;
            try
            {
                markinfo.imgPerPage = this.comboBox_itemperpage.SelectedIndex + 1;
                CountPageNum();
                //RefreshListView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void comboBox_page_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (markinfo.iTotalPage == 0)
                return;
            try
            {
                this.label_savestatus.Text = "";
                //SaveCurrentPage2Memory();

                markinfo.iCurrentPage = this.comboBox_page.SelectedIndex + 1;
                RefreshListView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
