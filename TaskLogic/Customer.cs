using System;

namespace TaskLogic
{
    public class Customer : IEquatable<Customer>
    {
        #region Fields & properties

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        #endregion

        #region Constructors
        public Customer() : this("Default Name", "Default Last Name") { }

        public Customer(string name, string lastName)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
                throw new ArgumentNullException();
            Name = name;
            LastName = lastName;
            Id = GetHashCode();
        }

        #endregion

        #region Equolity

        public bool Equals(Customer other)
        {
            if (other == null)
                throw new ArgumentNullException();
            return Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Customer);

        #endregion

        #region Compare operations

        public static bool operator >(Customer x, Customer y) => x.Name.CompareTo(y.Name) >= 0;

        public static bool operator <(Customer x, Customer y) => !(x > y);

        public static bool operator ==(Customer x, Customer y) => x.Equals(y);

        public static bool operator !=(Customer x, Customer y) => !(x == y);

        public bool Compare(Customer other, Func<Customer, Customer, bool> comparer)
        {
            return comparer(this, other);
        }

        #endregion

        #region Overrides from object

        public override string ToString()
        {
            return $"Id of Customer: {Id}" + Environment.NewLine 
                 + $"Name: {Name}" + Environment.NewLine
                 + $"LastName: {LastName}";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 13;

                hash = (hash * 7) + Id.GetHashCode();
                hash = (hash * 7) + Name.GetHashCode();
                hash = (hash * 7) + LastName.GetHashCode();

                return hash;
            }
        }

        #endregion
    }
}
