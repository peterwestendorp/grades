using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
  class Program
  {
    static void Main(string[] args)
    {
      GradeBook g1 = new GradeBook();
      GradeBook g2 = g1;
      SpeechSynthesizer synth = new SpeechSynthesizer();
//      synth.Speak("Yuri, did you know C# can talk?");

      GradeBook book = new GradeBook();

      book.NameChanged += new NameChangedDelegate(OnNameChanged);
      book.Name = "Peters grade book";
      book.Name = "Grade book";
      book.Name = null;
      book.AddGrade(91);
      book.AddGrade(89.5f);
      book.AddGrade(75);

      GradeStatistics stats = book.ComputeStatistics();
      Console.WriteLine(book.Name);
      Console.WriteLine(stats.AverageGrade);
      Console.WriteLine(stats.HigestGrade);
      Console.WriteLine(stats.LowestGrade);
    }

    static void OnNameChanged(string existingName, string newName)
    {
      Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
    }
  }
}
