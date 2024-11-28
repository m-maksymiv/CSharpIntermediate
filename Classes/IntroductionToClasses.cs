#region Introduction to Classes
/// Class -> A building block of an application
/// Anatomy of a Class :
///     -> Data (represented by fields)
///     -> Behaviour (represented by methods/functions)
/// Object -> An instance of a class
#endregion

namespace Classes;

public static class IntroductionToClasses
{
    public class Persone
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Persone Parse(string str)
        {
            var persone = new Persone();

            persone.Name = str;

            return persone;
        }
    }

    public static void IntroductionToClassesProgram()
    {
        Console.WriteLine("Start -> Introduction To Classes");

        //Persone persone = new Persone();
        //persone.Name = "Mykola";
        //persone.Introduce("Maksymiv");

        var persone = Persone.Parse("Mykola");
        persone.Introduce("Maksymiv");

        Console.WriteLine("Finish -> Introduction To Classes");
    }
}