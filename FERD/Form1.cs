using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERD
{
    public partial class Form1 : Form
    {
        int E阿塔蘭忒, E高文, E弗拉德三世, E間桐櫻, E言峰綺禮 = 0;

        private void Btimer_Tick(object sender, EventArgs e)
        {
            #region B1
            //B阿塔蘭忒
            if ((E阿塔蘭忒 >= 5) & (E高文 >= 1) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 3) & (E言峰綺禮 >= 1))
            {
                C李書文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C李書文.ForeColor = System.Drawing.Color.Black;
            }
            //B阿塔蘭忒
            //B吉爾伽美甚
            //B年輕的Emiya
            //B童謠
            //B安徒生
            //B玉藻前
            //B玉藻前泳裝
            //B玉藻前春季服飾
            //B高文
            //B鈴鹿御前
            #endregion

            #region B2
            //B阿爾托利亞
            //B黑化阿爾托利亞
            //B尼祿 克勞狄烏斯
            //B阿提拉
            //B美杜莎
            //B弗朗西斯 德雷克
            //B伊斯坎達爾
            //B貞德
            //B李書文
            //B兩儀式
            //B弗拉德三世
            #endregion

            #region B3
            //B伊麗莎白 巴托里
            //B庫丘林
            //B迦爾納
            //B呂布奉先
            //B愛爾奎特·布倫史塔德
            //B間桐櫻
            //BPassionlip
            //BBB
            //B遠坂凜
            //B言峰綺禮
            #endregion

        }

        private void Ctimer_Tick(object sender, EventArgs e)
        {
            #region C1
            //C阿塔蘭忒
            if ((E阿塔蘭忒 >= 3) & (E高文 >= 1) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 1) & (E言峰綺禮 >= 0))
            {
                C阿塔蘭忒.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C阿塔蘭忒.ForeColor = System.Drawing.Color.Black;
            }
            //C0MODEL
            if ((E阿塔蘭忒 >= 2) & (E高文 >= 0) & (E弗拉德三世 >= 2) & (E間桐櫻 >= 1) & (E言峰綺禮 >= 0))
            {
                C0MODEL.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C0MODEL.ForeColor = System.Drawing.Color.Black;
            }
            //C年輕的Emiya
            if ((E阿塔蘭忒 >= 2) & (E高文 >= 0) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 1))
            {
                C年輕的Emiya.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C年輕的Emiya.ForeColor = System.Drawing.Color.Black;
            }
            //C童謠
            if ((E阿塔蘭忒 >= 3) & (E高文 >= 0) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 0))
            {
                C童謠.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C童謠.ForeColor = System.Drawing.Color.Black;
            }
            //C安徒生
            if ((E阿塔蘭忒 >= 1) & (E高文 >= 2) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 1) & (E言峰綺禮 >= 1))
            {
                C安徒生.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C安徒生.ForeColor = System.Drawing.Color.Black;
            }
            //C玉藻前
            if ((E阿塔蘭忒 >= 2) & (E高文 >= 0) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 3) & (E言峰綺禮 >= 0))
            {
                C玉藻前.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C玉藻前.ForeColor = System.Drawing.Color.Black;
            }
            //C高文
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 3) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 2))
            {
                C高文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C高文.ForeColor = System.Drawing.Color.Black;
            }
            //C阿爾托利亞
            if ((E阿塔蘭忒 >= 2) & (E高文 >= 2) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 0))
            {
                C阿爾托利亞.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C阿爾托利亞.ForeColor = System.Drawing.Color.Black;
            }
            //C尼祿克勞狄烏斯
            if ((E阿塔蘭忒 >= 1) & (E高文 >= 2) & (E弗拉德三世 >= 2) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 0))
            {
                C尼祿克勞狄烏斯.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C尼祿克勞狄烏斯.ForeColor = System.Drawing.Color.Black;
            }
            //C美杜莎
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 1) & (E弗拉德三世 >= 1) & (E間桐櫻 >= 1) & (E言峰綺禮 >= 2))
            {
                C美杜莎.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C美杜莎.ForeColor = System.Drawing.Color.Black;
            }
            //C伊斯坎達爾
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 2) & (E弗拉德三世 >= 1) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 1))
            {
                C伊斯坎達爾.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C伊斯坎達爾.ForeColor = System.Drawing.Color.Black;
            }
            #endregion

            #region C2
            //C李書文=======
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 3) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 2))
            {
                C李書文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C李書文.ForeColor = System.Drawing.Color.Black;
            }
            //C兩儀式
            if ((E阿塔蘭忒 >= 1) & (E高文 >= 1) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 1) & (E言峰綺禮 >= 2))
            {
                C兩儀式.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C兩儀式.ForeColor = System.Drawing.Color.Black;
            }
            //C弗拉德三世
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 2) & (E弗拉德三世 >= 3) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 0))
            {
                C弗拉德三世.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C弗拉德三世.ForeColor = System.Drawing.Color.Black;
            }
            //C庫丘林
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 0) & (E弗拉德三世 >= 4) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 1))
            {
                C庫丘林.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C庫丘林.ForeColor = System.Drawing.Color.Black;
            }
            //C迦爾納
            if ((E阿塔蘭忒 >= 2) & (E高文 >= 1) & (E弗拉德三世 >= 2) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 0))
            {
                C迦爾納.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C迦爾納.ForeColor = System.Drawing.Color.Black;
            }
            //C呂布奉先
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 1) & (E弗拉德三世 >= 2) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 2))
            {
                C呂布奉先.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C呂布奉先.ForeColor = System.Drawing.Color.Black;
            }
            //C愛爾奎特
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 2) & (E弗拉德三世 >= 1) & (E間桐櫻 >= 1) & (E言峰綺禮 >= 1))
            {
                C愛爾奎特.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C愛爾奎特.ForeColor = System.Drawing.Color.Black;
            }
            //C間桐櫻
            if ((E阿塔蘭忒 >= 1) & (E高文 >= 0) & (E弗拉德三世 >= 1) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 1))
            {
                C間桐櫻.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C間桐櫻.ForeColor = System.Drawing.Color.Black;
            }
            //CPassionlip
            if ((E阿塔蘭忒 >= 2) & (E高文 >= 0) & (E弗拉德三世 >= 1) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 0))
            {
                CPassionlip.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                CPassionlip.ForeColor = System.Drawing.Color.Black;
            }
            //C遠坂凜
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 1) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 2) & (E言峰綺禮 >= 2))
            {
                C李書文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C李書文.ForeColor = System.Drawing.Color.Black;
            }
            //C言峰綺禮
            if ((E阿塔蘭忒 >= 0) & (E高文 >= 1) & (E弗拉德三世 >= 0) & (E間桐櫻 >= 0) & (E言峰綺禮 >= 4))
            {
                C李書文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                C李書文.ForeColor = System.Drawing.Color.Black;
            }
            #endregion
        }

        private void Dtimer_Tick(object sender, EventArgs e)
        {
            #region D1
            //D阿塔蘭忒
            if (E阿塔蘭忒 >= 2)
            {
                D阿塔蘭忒.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D阿塔蘭忒.ForeColor = System.Drawing.Color.Black;
            }
            //D童謠
            if (E阿塔蘭忒 >= 1 & E間桐櫻 >= 1)
            {
                D童謠.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D童謠.ForeColor = System.Drawing.Color.Black;
            }
            //D高文
            if (E高文 >= 2)
            {
                D高文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D高文.ForeColor = System.Drawing.Color.Black;
            }
            //D美杜莎
            if (E高文 >= 1 & E間桐櫻 >= 1)
            {
                D美杜莎.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D美杜莎.ForeColor = System.Drawing.Color.Black;
            }
            //D李書文
            if (E高文 >= 1 & E言峰綺禮 >= 1)
            {
                D李書文.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D李書文.ForeColor = System.Drawing.Color.Black;
            }
            //D弗拉德三世
            if (E弗拉德三世 >= 2)
            {
                D弗拉德三世.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D弗拉德三世.ForeColor = System.Drawing.Color.Black;
            }
            //D呂布奉先
            if (E弗拉德三世 >= 1 & E言峰綺禮 >= 1)
            {
                D呂布奉先.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D呂布奉先.ForeColor = System.Drawing.Color.Black;
            }
            //間桐櫻
            if (E間桐櫻 >= 2)
            {
                D間桐櫻.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D間桐櫻.ForeColor = System.Drawing.Color.Black;
            }
            //言峰綺禮
            if (E言峰綺禮 >= 2)
            {
                D言峰綺禮.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                D言峰綺禮.ForeColor = System.Drawing.Color.Black;
            }
            #endregion
        }


        private void button1_Click(object sender, EventArgs e)
        {
            E阿塔蘭忒 = Int32.Parse(textBox1.Text);
            E高文 = Int32.Parse(textBox2.Text);
            E弗拉德三世 = Int32.Parse(textBox3.Text);
            E間桐櫻 = Int32.Parse(textBox4.Text);
            E言峰綺禮 = Int32.Parse(textBox5.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
