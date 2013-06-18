using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MarkPlatform
{
    public class ImgInfo
    {
        public string imgpath;
        public ArrayList imgscores=new ArrayList();
    }

    public class ResultInfo
    {
        public int ImgIndex;
        public int score;
        public int iMark;
    }

    public class ResultInfoAscent : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((ResultInfo)x).score.CompareTo(((ResultInfo)y).score);
        }
    }

    public class ResultInfoDescent : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((ResultInfo)y).score.CompareTo(((ResultInfo)x).score);
        }
    }

    public class MarkInfo
    {
        public string strScoreFilePath;     
        public ArrayList arrClassStrings;   
        public string strChoosedClass;      
        public int iChoosedClassID;        

        public ArrayList arrImgInfos;       

        public int iLowScore;               
        public int iHighScore;              
        public int iImgCount;               

        public int iCurrentPage;
        public int iTotalPage;
        public int imgPerPage;           

        public bool bMarkPositive;

        public ArrayList arrResultInfos;
        public string strResultFilePath;   
        

        public MarkInfo()
        {
            MarkInfoInit();
        }

        public void MarkInfoInit()
        {
            strScoreFilePath = "";
            arrClassStrings = new ArrayList();
            arrClassStrings.Clear();
            strChoosedClass = "";
            iChoosedClassID = -1;
            iLowScore = 0;
            iHighScore = 100;
            iImgCount = 0;
            iCurrentPage = 0;
            iTotalPage = 0;
            imgPerPage = 28; 
            arrImgInfos = new ArrayList();
            arrImgInfos.Clear();
            arrResultInfos = new ArrayList();
            arrResultInfos.Clear();
            bMarkPositive = true;
            strResultFilePath = "";
        }
    }
}
