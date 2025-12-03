using System;

namespace BethanysPieShopHRM.HR
{
    internal class Developer : Employee
    {
        // constructor  
        public Developer(string firstName, string lastName, string email, DateTime dateOfBirth, double? hourlyRate) : base(firstName, lastName, email, dateOfBirth, hourlyRate)
        {
        }
        private string currentProject;

        // property
        public string CurrentProject
        {
            get { return currentProject; }
            set { currentProject = value; }
        }

    }
}


