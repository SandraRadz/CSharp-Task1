using System;
using Radzievska_Homework1.Properties;

namespace Radzievska_Homework1
{
    internal class User
    {
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set {
                _dateOfBirth = value;
            }
        }

        
    }
}
