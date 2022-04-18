using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme08ConsoleAppTask04
{
    class Contact
    {
        #region Поля
        private string fullName;

        private string street;

        private string houseNumber;

        private int flatNumber;

        private string mobilePhone;

        private string flatPhone;

        #endregion

        #region Свойства
        public string FullName { get { return this.fullName; } set { this.fullName = value; } }

        public string Street { get { return this.street; } set { this.street = value; } }

        public string HouseNumber { get { return this.houseNumber; } set { this.houseNumber = value; } }

        public int FlatNumber { get { return this.flatNumber; } set { this.flatNumber = value; } }

        public string MobilePhone { get { return this.mobilePhone; } set { this.mobilePhone = value; } }

        public string FlatPhone { get { return this.flatPhone; } set { this.flatPhone = value; } }

        #endregion

        #region Конструкторы
        public Contact (string FullName, string Street, string HouseNumber, int FlatNumber, string MobilePhone, string FlatPhone)
        {
            this.fullName = FullName;
            this.street = Street;
            this.houseNumber = HouseNumber;
            this.flatNumber = FlatNumber;
            this.mobilePhone = MobilePhone;
            this.flatPhone = FlatPhone;
        }
        #endregion
    }
}
