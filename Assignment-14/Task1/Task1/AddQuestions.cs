using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AddQuestions
    {
        public AddQuestions() 
        {
        }

        public static bool WriteQuestions(string Questions, StreamWriter sw)
        {
            try
            { 
                sw.WriteLine("\n--------------------------");
                sw.WriteLine("kiTxva: " + Questions);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);
                return false;
            }
            finally 
            { 
                //sw.Close();
            }
            
        }
        public static bool WritePoint(int Point, StreamWriter sw)
        {
            try
            { 
            sw.WriteLine("kitxvis qula: " + Point);

            return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);
                return false;
            }
            finally 
            { 

            }

        }
        public static bool WriteAnswer(string Answer, StreamWriter sw, int AnswerCount)
        {
            try
            { 
                sw.WriteLine("savaraudo pasuxi " + AnswerCount + ": " +  Answer);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);
                return false;
            }
            finally
            {
               // sw.Close();
            }
        }

        public static bool WriteCorectAnswer(string Answer, StreamWriter sw)
        {
            try
            {
                sw.WriteLine("swori pasuxi:" + Answer);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);
                return false;
            }
            finally 
            { 
                //sw.Close();
            }
        }

        public static bool FoundOperation(string QuestionType)
        {
            if ((QuestionType != "") && (QuestionType == "Create"))
            {
                return false;           }
            else if (QuestionType == "Add")
            {
                return true;
            }
            else
                return false;
        }

    }
}
