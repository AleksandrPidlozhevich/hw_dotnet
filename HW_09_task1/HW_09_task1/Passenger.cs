using System;

namespace HW_09_task1
{
    public class Passenger
    {
        private string _firstName { get; set; }
        private string _secondName { get; set; }
        private string _passportnam { get; set; }
        private bool _checkInStatus { get; set; }
        private bool _securityCheck { get; set; }
        private bool _passportCheck { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                _secondName = value;
            }
        }
        public string PassportNam
        {
            get
            {
                return _passportnam;
            }
            set
            {
                _passportnam = GeneratePassportNumber();
            }
        }
        public bool CheckInStatus
        {
            get
            {
                return _checkInStatus;
            }
            set
            {
                _checkInStatus = true;
            }
        }
        public bool SecurityCheck
        {
            get
            {
                return _securityCheck;
            }
            set
            {
                _securityCheck = true;
            }
        }
        public bool PassportCheck
        {
            get
            {
                return _passportCheck;
            }
            set
            {
                _passportCheck = true;
            }
        }
        string GeneratePassportNumber()
        {
            Random rand = new Random();

            return $"МР{rand.Next(1000000, 9999999)}";
        }
    }

}