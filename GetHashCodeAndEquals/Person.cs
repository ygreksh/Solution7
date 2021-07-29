using System;

namespace GetHashCodeAndEquals
{
    public class Person
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int PassportNumber { get; set; }

        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;

            Person p = (Person) obj;
            //По логике, номер паспорта - это уникальный идентификатор,
            //достаточно сравнивать только номер паспорта,
            //но для наглядности сравню все поля и свойства объекта
            return FullName == p.FullName 
                   && BirthDate == p.BirthDate
                   && BirthPlace == p.BirthPlace
                   && PassportNumber == p.PassportNumber;
        }

        public override int GetHashCode()
        {
            //По логике, номер паспорта - это уникальный идентификатор,
            //для проверки уникальности его достаточно,
            //Но для наглядности сделаю вычисление с другими полями
            return PassportNumber * 1000 + BirthDate.DayOfYear;
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}