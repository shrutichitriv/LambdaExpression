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
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonInCity);
            Retrieving_Record_ForAgeIs_LessThanEighteenAndGreaterThanThirteen(listPersonInCity);
            Retrieving_AverageAge(listPersonInCity);
            CheckNameIsPresent(listPersonInCity);
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

        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2))
            {
                Console.WriteLine("Name : " + person.Name + "Age : " + person.Age);
            }
        }

        private static void Retrieving_Record_ForAgeIs_LessThanEighteenAndGreaterThanThirteen(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 18 && e.Age > 13)))
            {
                Console.WriteLine("Name : " + person.Name + "Age : " + person.Age);
            }
        }

        private static void Retrieving_AverageAge(List<Person> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(x => x.Age);

            Console.WriteLine(avgAge);
        }

        private static void CheckNameIsPresent(List<Person> listPersonInCity)
        {
            bool check = listPersonInCity.Any(x => x.Name == "SAM");
            if (check)
            {
                Console.WriteLine("Name is present");
            }
            else
            {
                Console.WriteLine("Name is not present");
            }
        }


    }
}