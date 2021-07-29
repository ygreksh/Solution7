using System;

namespace GetHashCodeAndEquals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person {FullName = "Ivanov Ivan Ivanovich", BirthDate = new DateTime(1990,12,12), BirthPlace = "Tiraspol", PassportNumber = 123456};
            Person person2 = new Person {FullName = "Petrov Petr Petrovich", BirthDate = new DateTime(1991,1,1), BirthPlace = "Slobodzea", PassportNumber = 112233};
            Person person3 = new Person {FullName = "Sidorova Ekaterina Mikhailovna", BirthDate = new DateTime(1992,2,2), BirthPlace = "Bendery", PassportNumber = 445566};
            Person person4 = new Person {FullName = "Ivanov Ivan Ivanovich", BirthDate = new DateTime(1990,12,12), BirthPlace = "Tiraspol", PassportNumber = 123456};

            if (person1 == person2)
                Console.WriteLine(person1.FullName + " равен " + person2.FullName );
            else
                Console.WriteLine(person1.FullName + " НЕ равен " + person2.FullName );
            
            if (person1 == person3)
                Console.WriteLine(person1.FullName + " равен " + person3.FullName );
            else
                Console.WriteLine(person1.FullName + " НЕ равен " + person3.FullName );

            if (person1 == person4)
                Console.WriteLine(person1.FullName + " равен " + person4.FullName );
            else
                Console.WriteLine(person1.FullName + " НЕ равен " + person2.FullName );

        }
    }
}