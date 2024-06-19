using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType : JobField
	{
        public PositionType(string value) : base(value)
     {
     }

        // DONE | TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
            Id == employer.Id;
        }

    }
}

