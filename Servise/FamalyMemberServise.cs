using System;
using FamalyTree.Model;

namespace FamalyTree.Sevice
{
	internal class FamalyMemberServise
	{
		public List<FamalyMember> Famaly { get; private set; }
		public FamalyMemberServise()
		{
			Famaly = new List<FamalyMember>();
		}

		public void AddFamalyMember(params FamalyMember[] persons)
		{
			if(persons != null)
			{
				Famaly.AddRange(persons);
			}
		}
        

        public List<FamalyMember> GetGarandFathers(FamalyMember person)
        {
            List<FamalyMember> grandFathers = new List<FamalyMember>();
            grandFathers.Add(person.Father.Father);
            grandFathers.Add(person.Mother.Father);
            return grandFathers;
        }

        public List<FamalyMember> GetGarandMOthers(FamalyMember person)
        {
            List<FamalyMember> grandMothers = new List<FamalyMember>();
            grandMothers.Add(person.Father.Mother);
            grandMothers.Add(person.Mother.Mother);
            return grandMothers;
        }

        public FamalyMember GetOldestMember()
        {
            
            var date = Famaly.Min(x => x.DateOfBirth);
            return Famaly.FirstOrDefault(x => x.DateOfBirth == date);
        }
        public void GetMarried(FamalyMember person1, FamalyMember person2)
        {
            person1.Spouse = person2;
            person2.Spouse = person1;
        }

        public List<FamalyMember> GetSpouseAndHimParents(FamalyMember person)
        {
            List<FamalyMember> spouseAndHimParents = new List<FamalyMember>();
            spouseAndHimParents.Add(person);
            spouseAndHimParents.Add(person.Father);
            spouseAndHimParents.Add(person.Mother);
            return spouseAndHimParents;
        }






    }
    


}

