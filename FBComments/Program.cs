using System.Xml.Linq;
using Humanizer;

namespace FBComments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<FBComments> comments = new List<FBComments>()
            {
                new FBComments
                {
                    Owner = "Ehap Azazi",
                    Comment = "I Think ASP NET Core is the most powerful Web Framework",
                    CreatedAt = new DateTime (2021, 01, 01, 10, 30, 00)
                },
                new FBComments {
                    Owner = "Ali Azazi",
                    Comment = "Personally, I prefer using C# with it.",
                    CreatedAt = new DateTime(2022, 04, 01, 10, 30, 00)
                },
                new FBComments {
                    Owner = "Saber Mohammed",
                    Comment = "Have you tried using Blazor?",
                    CreatedAt = new DateTime(2022, 07, 01, 10, 30, 00)
                },
                new FBComments {
                    Owner = "Kareem Mohammed",
                    Comment = "Have you tried using Python(Flask)?",
                    CreatedAt = new DateTime(2022, 08, 28, 10, 30, 00)
                },
                new FBComments {
                    Owner = "Mahmoud Azazi",
                    Comment = "I prefer VB over C#.",
                    CreatedAt = new DateTime(2022, 09, 11, 10, 30, 00)
                },
                new FBComments {
                    Owner = "Ahmed Khalil",
                    Comment = "VB is not from C family languages, It's hard for me",
                    CreatedAt = DateTime.Now.AddMinutes(-5)
                }
            };
            foreach (var comment in comments)
            {
                Console.WriteLine(comment);
            }
            Console.ReadLine();
        }
    }
    class FBComments
    {
        public string? Owner { get; set; }  
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"{this.Owner} Commented: \n\t\"{this.Comment}\"\n\t\t\t\t\t\t\t {CreatedAt.Humanize()}";
        }
    }
}