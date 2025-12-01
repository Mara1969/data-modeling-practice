namespace BethanysPieShopHRM.Accounting
{
    internal class Customer
    {
      private string customerID;
      private string name;

      public string CustomerID
      {
          get { return customerID; }
          set { customerID = value; }
      }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
