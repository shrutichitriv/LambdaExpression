using System;
namespace LambdaExpression_244
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lambda Expression Program");

            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);

        }

        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("2324244", "John", "12 Main street", 15));
            listPersonInCity.Add(new Person("2324245", "Sam", "13 Main street", 25));
            listPersonInCity.Add(new Person("2324246", "Elan", "14 Main street", 35));
            listPersonInCity.Add(new Person("2324256", "SAM", "15 Main street", 45));
            listPersonInCity.Add(new Person("2324288", "Sue", "16 Main street", 55));
            listPersonInCity.Add(new Person("2324234", "Winston", "17 Main street", 65));
            listPersonInCity.Add(new Person("2324223", "Mac", "18 Main street", 65));
            listPersonInCity.Add(new Person("2324212", "Rita", "19 Main street", 85));
        }

    }
}