using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLogic
{
    public class Customer : IEquatable<Customer>
    {
        #region Fields & properties

        private int Id;
        private string Name;
        public string LastName;

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
