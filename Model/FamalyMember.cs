using System;
namespace FamalyTree.Model
{
	public class FamalyMember
	{
		public string Name { get; set; }
		public Gender Gender {get; set;}
		public FamalyMember Mother { get; set; }
        public FamalyMember Father { get; set; }
        public FamalyMember Spouse { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        
        

        public override string ToString()
        {
            string memberInfo = new string($"|Имя: { Name} | Пол: { Gender} | Дата рождения: { DateOfBirth.ToShortDateString()}");
            memberInfo = memberInfo.PadRight(99,' ');
            string frame = new string('-', 100);
            string frame1 = "|";
            return $"{frame}\n{memberInfo}|\n{frame}";
        }
    }

    
}

