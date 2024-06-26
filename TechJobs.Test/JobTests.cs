﻿
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
//Testing objects
Job job1 = new Job();

Job job2 = new Job();

Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id); 
            Assert.IsTrue(job1.Id+1 == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job4.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
        Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
        Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string newLine = Environment.NewLine;
            string jobTester = job3.ToString();
            string stringLabels = 
            $"{newLine}ID: {job3.Id}{newLine}" + 
            $"Name: {job3.Name}{newLine}" + 
            $"Employer: {job3.EmployerName}{newLine}" + 
            $"Location: {job3.EmployerLocation}{newLine}" + 
            $"Position Type: {job3.JobType}{newLine}" + 
            $"Core Competency: {job3.JobCoreCompetency}{newLine}";
            Assert.AreEqual(jobTester, stringLabels);
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string emptyFeildMessage = "Data not available";
            Assert.IsTrue(job1.ToString().Contains(emptyFeildMessage));
        }
    }
}


