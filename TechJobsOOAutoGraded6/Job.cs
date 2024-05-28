﻿using System;

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



        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string idString = string.IsNullOrEmpty(Id.ToString()) ? "Data not available" : Id.ToString();
            string nameString = string.IsNullOrEmpty(Name) ? "Data not available" : Name;
            string employerString = string.IsNullOrEmpty(EmployerName.ToString()) ? "Data not available" : EmployerName.ToString();
            string locationString = string.IsNullOrEmpty(EmployerLocation.ToString()) ? "Data not available" : EmployerLocation.ToString();
            string jobTypeString = string.IsNullOrEmpty(JobType.ToString()) ? "Data not available" : JobType.ToString();
            string coreCompetencyString = string.IsNullOrEmpty(JobCoreCompetency.ToString()) ? "Data not available" : JobCoreCompetency.ToString();
            
            string nl = Environment.NewLine;
            
            return 
            nl +
            "ID: " + idString + nl +
            "Name: " + nameString + nl +
            "Employer: " + employerString + nl +
            "Location: " + locationString + nl +
            "Position Type: " + jobTypeString + nl +
            "Core Competency: " + coreCompetencyString +
            nl;

            
        }
    }
}
