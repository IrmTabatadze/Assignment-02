using System.Data.SqlTypes;
using System.IO;
using System.Text;
using Task1;


var path = @"C:\\Users\\IrmTabatadze\\Desktop\\Irma\\Assignment-02\\ttt2.txt";

Console.WriteLine("Choose R (Shevseba) or W (Shedgena)");
var Operation = Console.ReadLine();


if (Operation == "W")
    {
        Console.WriteLine("gasuftavdes kitxvari? Y/N");
        var Answer = Console.ReadLine();

        try
        {
            if (Answer == "Y")
            {
                AddQuestions(path, "Create");
            }
            else
                AddQuestions(path, "Add");
            } 
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);       
        }
        finally 
        {
            //Console.WriteLine("try different file "); //Executing
        }
    }

    else
    {
        ReadFile(path);
    }

void ReadFile(string path)
{
    var ReadQuestions = new ReadQuestion();
    var Result = ReadQuestion.ReadQuestions(path);
    if (Result == null)
    {
        Console.WriteLine("result is null"); 
    }
    else
        Console.WriteLine(Result);
}

void AddQuestions(string path, string QuestionType)
{
    var AddQuestions = new AddQuestions();
    var Operation = AddQuestions.FoundOperation(QuestionType);

    using (var sw = new StreamWriter(path, Operation))
    {
        Console.WriteLine("Sheikvanet kiTxva: ");
        var Question = Console.ReadLine();
        if ((Question == null) || (Question == ""))
        {
            Console.WriteLine("pasuxi ar sheidzleba ikos carieli!");
            return;
        }
        else
        { 
            var ReturndAnswer = AddQuestions.WriteQuestions(Question, sw);
        }

        Console.WriteLine("kitxvis qula: ");
        var Point = Console.ReadLine();
        if ((Point == null) || (Question == ""))
        {
            Console.WriteLine("pasuxi ar sheidzleba ikos carieli!");
            return;
        }
        else
        {
            var PointResult = AddQuestions.WritePoint(Convert.ToInt32(Point), sw);
        }
     
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("savaraudo pasuxi " + i);
            var Answer = Console.ReadLine();
            if (Answer == null)
            {
                Console.WriteLine("pasuxi ar sheidzleba ikos carieli!");
                return;
            }
            else
            {
                var Result = AddQuestions.WriteAnswer(Answer, sw, i);
            }               
        }

        Console.WriteLine("swori pasuxi: ");
        var WinAnswer = Console.ReadLine();
        
        if ((WinAnswer == null) || (Question == ""))
        {
            Console.WriteLine("pasuxi ar sheidzleba ikos carieli!");
            return;
        }
        else
        {
            var WinCorectAnswer = AddQuestions.WriteCorectAnswer(WinAnswer, sw);
        }
        sw.Close();

    }
}

void ClearFile(string path)
{
    TextWriter tw = new StreamWriter(path, false);
    tw.Write(string.Empty);
    tw.Close();
}