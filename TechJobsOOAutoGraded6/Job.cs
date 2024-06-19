using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
            Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        
          public override string ToString()
        {
            // return Environment.NewLine;
            string newLine = Environment.NewLine;
            string emptyFieldMessage = "Data not available";

        string jobLabels =  
        $"{newLine}ID: {Id}{newLine}" +
        $"Name: {(string.IsNullOrEmpty(Name) ? emptyFieldMessage : Name)}{newLine}" +
        $"Employer: {(EmployerName == null || string.IsNullOrEmpty(EmployerName.Value) ? emptyFieldMessage : EmployerName.Value)}{newLine}" +
        $"Location: {(EmployerLocation == null || string.IsNullOrEmpty(EmployerLocation.Value) ? emptyFieldMessage : EmployerLocation.Value)}{newLine}" +
        $"Position Type: {(JobType == null || string.IsNullOrEmpty(JobType.Value) ? emptyFieldMessage : JobType.Value)}{newLine}" +
        $"Core Competency: {(JobCoreCompetency == null || string.IsNullOrEmpty(JobCoreCompetency.Value) ? emptyFieldMessage : JobCoreCompetency.Value)}{newLine}";

            return jobLabels;
        }

            // TODO: Task 5: Generate custom ToString() method.
            //     Until you create this method, you will not be able to print a job to the console.

    }
}

