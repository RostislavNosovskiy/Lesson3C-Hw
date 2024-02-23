namespace FamalyTree;

using System;
using FamalyTree.Model;
using FamalyTree.Sevice;

class Program
{
    public static void Main(string[] args)
    {
        FamalyMember person5 = new FamalyMember()
        { Name = "Виктор", Gender = Gender.Male, DateOfBirth = new DateTime(1964, 03, 15) };// дедушка отца
        FamalyMember person6 = new FamalyMember()
        { Name = "Валентина", Gender = Gender.Female, DateOfBirth = new DateTime(1967, 07, 27) }; // бабушка отца
        FamalyMember person7 = new FamalyMember()
        { Name = "Вадим", Gender = Gender.Male, DateOfBirth = new DateTime(1960, 04, 11) }; // дедушка матери
        FamalyMember person8 = new FamalyMember()
        { Name = "Галина", Gender = Gender.Female, DateOfBirth = new DateTime(1963, 09, 11) }; // бабушка матери
        FamalyMember person1 = new FamalyMember()
        {Name = "Алексей", Gender = Gender.Male, DateOfBirth = new DateTime(1990,12,12), Mother = person6, Father = person5 }; // отец
        FamalyMember person2 = new FamalyMember()
        { Name = "Алёна", Gender = Gender.Female, DateOfBirth = new DateTime(1992, 05, 17), Mother = person8, Father = person7 }; // мать
        FamalyMember person3 = new FamalyMember()
        { Name = "Олег", Gender = Gender.Male, DateOfBirth = new DateTime(2021, 10, 23), Mother = person2, Father = person1 }; // сын
        FamalyMember person4 = new FamalyMember()
        { Name = "Анна", Gender = Gender.Female, DateOfBirth = new DateTime(2023, 11, 07), Mother = person2, Father = person1 }; // дочь
        

        var famaly = new FamalyMemberServise();
        famaly.AddFamalyMember(person1, person2, person3, person4, person4, person5, person6, person7, person8);

        //foreach(var person in famaly.GetGarandFathers(person4))
        //{
        //    Console.WriteLine(person);
        //}
        //Console.WriteLine(famaly.GetOldestMember());

        famaly.GetMarried(person2, person1);
        Console.WriteLine();
        foreach (var person in famaly.GetSpouseAndHimParents(person1))
        {
            Console.WriteLine(person);
        }
     
        Console.WriteLine();
        foreach (var person in famaly.GetSpouseAndHimParents(person2))
        {
            Console.WriteLine(person);
        }

    }
}
