namespace Radzievska_Homework1
{
    class User
    {
        private string _birthday;
        private int _age;
        private string _zodiac;
        private string _chinaZodiac;

        public string Birthday
        {
            get { return _birthday; }
            set {_birthday = value;}
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Zodaic
        {
            get { return _zodiac; }
            set { _zodiac = value; }
        }
        public string ChinaZodiac
        {
            get { return _chinaZodiac; }
            set { _chinaZodiac = value; }
        }

    }
}
