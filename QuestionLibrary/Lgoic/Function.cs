using QuestionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionLibrary.Lgoic
{
    public class Function
    {

        public List<Question> GetQusetion()
        {

            List<Question> Result = new List<Question>();
            string filepath = @"../../Res/安装质量监督人员考试题库.xls";
            var data = ExcelHelper.ReadExcel(filepath);

            int[] QuestionNumbers = getRandomNum(100, 1, data.Rows.Count);
            QuestionNumbers = QuestionNumbers.OrderBy(it => it).ToArray();
            foreach (var item in QuestionNumbers)
            {
                DataRow datarow = data.Rows[item];
                Result.Add(new Question(
                    datarow["A"].ToString(),
                    datarow["B"].ToString(),
                    datarow["C"].ToString(),
                    datarow["D"].ToString(),
                    datarow["答案5"].ToString(),
                    datarow["答案6"].ToString()
                    )
                {
                    QusetionContent = datarow["题目内容"].ToString(),
                    Option_Right = datarow["正确答案"].ToString()
                });
            }
            return Result;
        }


        /// <summary>
        /// Desc:生成一个随机数
        /// </summary>
        /// <param name="arrNum"></param>
        /// <param name="tmp"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="ra"></param>
        /// <returns></returns>
        public int getNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            int n = 0;
            while (n <= arrNum.Length - 1)
            {
                if (arrNum[n] == tmp) //利用循环判断是否有重复
                {
                    tmp = ra.Next(minValue, maxValue); //重新随机获取。
                    getNum(arrNum, tmp, minValue, maxValue, ra);//递归:如果取出来的数字和已取得的数字有重复就重新随机获取。
                }
                n++;
            }
            return tmp;
        }

        /// <summary>
        /// Desc:生成一组随机数
        /// </summary>
        /// <param name="num"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public int[] getRandomNum(int num, int minValue, int maxValue)
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int[] arrNum = new int[num];
            int tmp = 0;
            for (int i = 0; i <= num - 1; i++)
            {
                tmp = ra.Next(minValue, maxValue); //随机取数
                arrNum[i] = getNum(arrNum, tmp, minValue, maxValue, ra); //取出值赋到数组中
            }
            return arrNum;
        }
    }


}
