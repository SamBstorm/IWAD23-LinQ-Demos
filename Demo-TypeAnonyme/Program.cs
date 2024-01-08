namespace Demo_TypeAnonyme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = new { content = "Hello world!", color = ConsoleColor.Red, background = ConsoleColor.White };

            Console.ForegroundColor = message.color;
            Console.BackgroundColor = message.background;
            Console.WriteLine(message.content);
            Console.ResetColor();

            List<Student> students = new List<Student>()
            {
                new Student { LastName = "Beurive" , FirstName = "Aude", IsFemale = true},
                new Student { LastName = "Legrain" , FirstName = "Samuel", IsFemale = false},
                new Student { LastName = "Gérard" , FirstName = "Dominique"}
            };

            foreach (Student student in students)
            {
                //var person = new { Nom = student.LastName, Prenom = student.FirstName, DateAjout = DateTime.Now };
                //Console.WriteLine($"{person.DateAjout.ToString("dd/MM/yyyy")} : {person.Nom} {person.Prenom}");

                var eleve = new { student.LastName, student.FirstName, student.IsFemale, AddedDate = DateTime.Now };
                if(eleve.IsFemale == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if(eleve.IsFemale == false)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine($"{eleve.AddedDate.ToString("dd/MM/yyyy")} : {eleve.FirstName} {eleve.LastName}");
            }
        }
    }
}
