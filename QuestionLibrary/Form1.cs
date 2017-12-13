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

            Question CurrentQuestion = QuestionList[CurrentQuestionNumber];
            QuestionContent.Text = CurrentQuestionNumber+"、"+ CurrentQuestion.QusetionContent;
            OptionList.DataSource = CurrentQuestion.optionList;
            OptionList.ValueMember = "OptionValue";
            OptionList.DisplayMember = "OptionContent";
            CurrentQuestionNumber++;


        }
    }
}
