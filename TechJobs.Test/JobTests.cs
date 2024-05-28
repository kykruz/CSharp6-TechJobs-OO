
using System.Runtime.CompilerServices;
using System.Xml;

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
        Job job5 = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id +1, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
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
            string nl = Environment.NewLine;
            Assert.AreEqual(
            nl +
            "ID: " + "18" + nl +
            "Name: " + "Product tester" + nl +
            "Employer: " + "ACME" + nl +
            "Location: " + "Desert" + nl +
            "Position Type: " + "Quality control" + nl +
            "Core Competency: " + "Persistence" +
            nl, job3.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string nl = Environment.NewLine;
            Assert.AreEqual(
            nl +
            "ID: " + "25" + nl +
            "Name: " + "Data not available" + nl +
            "Employer: " + "ACME" + nl +
            "Location: " + "Desert" + nl +
            "Position Type: " + "Quality control" + nl +
            "Core Competency: " + "Persistence" +
            nl, job5.ToString());
        }

        
    }
}

