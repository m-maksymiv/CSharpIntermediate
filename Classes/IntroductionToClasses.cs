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
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();

            person.Name = str;

            return person;
        }
    }

    public static void IntroductionToClassesProgram()
    {
        Console.WriteLine("Start -> Introduction To Classes");

        //Person person = new Person();
        //person.Name = "Mykola";
        //person.Introduce("Maksymiv");

        var person = Person.Parse("Mykola");
        person.Introduce("Maksymiv");

        Console.WriteLine("Finish -> Introduction To Classes");
    }
}