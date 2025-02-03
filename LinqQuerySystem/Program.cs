using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuerySystem
{
    public class Program
    {
        public static void Main()
        {
            // Sample data
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "Simran", Age = 25 },
                new Person { Id = 2, Name = "Harsh", Age = 30 },
                new Person { Id = 3, Name = "Ravi", Age = 22 },
                new Person { Id = 4, Name = "Priya", Age = 28 }
            };

            // LINQ Query to filter people aged 25 or older
            var filteredPeople = from person in people
                                 where person.Age >= 25
                                 select person;

            // Displaying the results
            Console.WriteLine("People aged 25 or older:");
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

    // Person class
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
