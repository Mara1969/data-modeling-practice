using System;

namespace BethanysPieShopHRM.HR
{
    public interface IEmployee
    {
        double ReceiveWage(bool resetHours = true);
        void PerformWork();
        void GiveBonus();
        void PerformWork(int numberOfHours);
        void DisplayEmployeeDetails();
        void GiveCompliment();
    }
}
