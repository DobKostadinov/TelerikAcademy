using P02.BankAccounts.Common;

namespace P02.BankAccounts.Models.Customers
{
    public class Customer
    {
        private string name;
        private CustomerType type;

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                Validator.EmptyValidation(value);

                this.name = value;
            }
        }

        public CustomerType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
