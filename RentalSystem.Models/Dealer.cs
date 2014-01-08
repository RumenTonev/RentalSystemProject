namespace RentalSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Dealer : IComparable<Dealer>
    {
        private ICollection<Contract> contracts;

        public Dealer()
        {
            this.contracts = new HashSet<Contract>();
        }

        public int DealerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name
        {
            get { return this.FirstName + " " + this.LastName; }
        }

        public string GetName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public int CompareTo(Dealer other)
        {
            return this.GetName().CompareTo(other.GetName());
        }
    }
}