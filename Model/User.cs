using System;
using Radzievska_Homework1.Properties;

namespace Radzievska_Homework1
{
    internal class User
    {
        private DateTime _dateOfBirth;
        private string _age;
        private string _western;
        private string _chinese;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set {
                _dateOfBirth = value;
            }
        }
        
    }
}
