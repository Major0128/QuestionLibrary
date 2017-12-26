using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLibrary.Models
{
    public class Question
    {

        public string QusetionContent { get; set; }
        public string Option_A { get; set; }
        public string Option_B { get; set; }
        public string Option_C { get; set; }
        public string Option_D { get; set; }
        public string Option_E { get; set; }
        public string Option_F { get; set; }
        public string Option_Right { get; set; }

        public bool isMultipleChoice { get; set; }

        public List<Option> optionList = new List<Option>();

        public Question()
        {

        }

        public Question(string a, string b, string c, string d, string e = "", string f = "")
        {

            Option_A = a;
            optionList.Add(new Option()
            {
                OptionContent = a,
                OptionValue = "A"
            });
            Option_B = b;
            optionList.Add(new Option()
            {
                OptionContent = b,
                OptionValue = "B"
            });
            Option_C = c;
            optionList.Add(new Option()
            {
                OptionContent = c,
                OptionValue = "C"
            });
            Option_D = d;
            optionList.Add(new Option()
            {
                OptionContent = d,
                OptionValue = "D"
            });
            if (e != "")
            {
                Option_E = e;
                optionList.Add(new Option()
                {
                    OptionContent = e,
                    OptionValue = "E"
                });
            }
            if (f != "")
            {
                Option_F = f;
                optionList.Add(new Option()
                {
                    OptionContent = f,
                    OptionValue = "F"
                });

            }


        }
    }
}
