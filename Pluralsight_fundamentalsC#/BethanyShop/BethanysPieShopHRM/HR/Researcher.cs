using System;

namespace BethanysPieShopHRM.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email, DateTime dateOfBirth, double? hourlyRate) : base(firstName, lastName, email, dateOfBirth, hourlyRate)
        {
        }
        private int numberOfPieTasesInvented = 0;
        public int NumberOfPieTastesInvented
        {
            get { return numberOfPieTasesInvented; }
            set { numberOfPieTasesInvented = value; }
        }
    }

}
