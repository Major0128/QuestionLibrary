using QuestionLibrary.Lgoic;
using QuestionLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionLibrary
{
    public partial class Form1 : Form
    {

        private List<Question> QuestionList;
        private int CurrentQuestionNumber = 1;
        private Question CurrentQuestion = new Question();

        public Form1()
        {
            InitializeComponent();
            Function _function = new Lgoic.Function();
            QuestionList = _function.GetQusetion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_NextQuestion_Click(object sender, EventArgs e)
        {
            string checkText = "";
            for (int i = 0; i < OptionList.Items.Count; i++)
            {
                if (OptionList.GetItemChecked(i))//先判断是否被选中
                {
                    checkText += ((Option)(OptionList.Items[i])).OptionValue + ",";//将选中的值取出
                }
            }
            if (checkText != "")
            {
                checkText = checkText.Substring(0, checkText.Length - 1);

                if (checkText == CurrentQuestion.Option_Right)
                {
                    checkAllState(false);

                    Message.Text = "";
                    CurrentQuestion = QuestionList[CurrentQuestionNumber - 1];
                    QuestionContent.Text = CurrentQuestionNumber + "、" + CurrentQuestion.QusetionContent;
                    OptionList.DataSource = CurrentQuestion.optionList;
                    OptionList.ValueMember = "OptionValue";
                    OptionList.DisplayMember = "OptionContent";

                    CurrentQuestionNumber++;
                }
                else
                {
                    Message.Text = "正确答案:" + CurrentQuestion.Option_Right + "当前答案:" + checkText;
                }
            }
            else
            {
                if (CurrentQuestionNumber != 1)
                {
                    MessageBox.Show("请选择答案！");
                }
                else
                {
                    CurrentQuestion = QuestionList[CurrentQuestionNumber - 1];
                    QuestionContent.Text = CurrentQuestionNumber + "、" + CurrentQuestion.QusetionContent;
                    OptionList.DataSource = CurrentQuestion.optionList;
                    OptionList.ValueMember = "OptionValue";
                    OptionList.DisplayMember = "OptionContent";
                    CurrentQuestionNumber++;
                }
            }
        }

        private void OptionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 单选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionList_ItemCheck(object sender, ItemCheckEventArgs e)//checkedListBox的一个事件
        {
            if (CurrentQuestion.isMultipleChoice == false)
            {
                for (int i = 0; i < OptionList.CheckedIndices.Count; i++)
                {
                    if (OptionList.CheckedIndices[i] != e.Index)
                    {
                        OptionList.SetItemChecked(OptionList.CheckedIndices[i], false);
                    }
                }

            }
        }
        /// <summary>
        /// 清除选中
        /// </summary>
        /// <param name="check"></param>
        public void checkAllState(bool check)
        {
            for (int i = 0; i < this.OptionList.Items.Count; i++)
            {
                this.OptionList.SetItemChecked(i, check);
            }
        }
    }
}
