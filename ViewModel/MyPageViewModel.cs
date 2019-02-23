using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Runtime.CompilerServices;
using Radzievska_Homework1.Tools;

namespace Radzievska_Homework1.ViewModels
{
    internal class MyPageViewModel : BaseViewModel
    {
        private User user;
        private DateTime _dateOfBirth;
        private string _age;
        private string _massage;
        private string _western;
        private string _chinese;


        public MyPageViewModel()
        {
            user = new User();
        }

        #region Commands
        private RelayCommand<object> goCommand;


        #region Properties
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
            }
        }

        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return _massage; }
            set
            {
                _massage = value;
                OnPropertyChanged();
            }
        }

        public string Western
        {
            get { return _western; }
            set
            {
                _western = value;
                OnPropertyChanged();
            }
        }

        public string Chinese
        {
            get { return _chinese; }
            set
            {
                _chinese = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public RelayCommand<object> GoCommand
        {
            get
            {
                return goCommand ??
                  (goCommand = new RelayCommand<object>(async obj =>
                  {
                      Age = "";
                      Western = "";
                      Message = "";
                      Chinese = "";

                      LoaderManager.Instance.ShowLoader();
                      await Task.Run(() => Thread.Sleep(1000));
                      LoaderManager.Instance.HideLoader();


                      int inputAge = countAge();
                      if (inputAge <= 0 || inputAge >= 135)
                      {
                          MessageBox.Show("It's seems that your input uncorrect data");
                      }
                      else
                      {
                          if (DateOfBirth.Day == DateTime.Today.Day)
                              Message = "Happy Birthday!";

                          Age =  ""+ inputAge;
                          Western = discoverZodiac();
                          Chinese =  countChineeseZodiak();
                      }

                  }));
            }
        }
        #endregion



        #region Functionality
        private int countAge()
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth > today.AddYears(-age)) age--;
            Console.WriteLine(age);
            return age;
        }

        private string discoverZodiac()
        {
            int moth = DateOfBirth.Month;
            int day = DateOfBirth.Day;
            switch (moth)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn";
                    else
                        return "Aquarius";

                case 2:
                    if (day <= 18)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                    if (day <= 20)
                        return "Pisces";
                    else
                        return "Aries";
                case 4:
                    if (day <= 19)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (day <= 20)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (day <= 20)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (day <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (day <= 22)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (day <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (day <= 22)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (day <= 21)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (day <= 21)
                        return "Sagittarius";
                    else
                        return "Capricorn";
            }
            return "";
        }

        private string countChineeseZodiak()
        {
            System.Globalization.EastAsianLunisolarCalendar cc = new System.Globalization.ChineseLunisolarCalendar();
            int sexagenaryYear = cc.GetSexagenaryYear(DateOfBirth);
            int terrestrialBranch = cc.GetTerrestrialBranch(sexagenaryYear);

            string[] years = new string[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

            return years[terrestrialBranch - 1];
        }
        #endregion

    }
}
