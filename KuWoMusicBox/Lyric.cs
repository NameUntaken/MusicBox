using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuWoMusicBox
{
    //歌词文件
    class LyricFiles
    {
        public List<Lyric> lstLyric = new List<Lyric>();
        public void LoadLyric(string fileName)
        {
            //打开文件
            Encoding encode = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs, encode);

            string line;
            //循环读出所有歌词
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "")
                    continue;
                // = sr.ReadLine()
                //line.Substring(10);
                //line.Replace(" ", "");//去除字符串的空白
                Lyric lyric = new Lyric();

                lyric.minute = int.Parse(line.Substring(1, 2));//?????
                lyric.second = float.Parse(line.Substring(4, 5));
                lyric.strLyric = line.Substring(10);

                lyric.currenttime = lyric.minute * 60 + lyric.second;

                lstLyric.Add(lyric);
            }

            sr.Close();
            fs.Close();
        }
    }
    //一行歌词
    class Lyric
    {
        public int minute;//分
        public float second;//秒
        public string strLyric;//歌词

        public float currenttime;
    }
}
