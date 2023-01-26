using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_ClassLibrary
{
    class Donor : Person
    {
        public string DonorID;
        public string Address;
        public string Phone;
        public char CardType;
        public string CardNumber;
        public string CardExpiry;

        public Donor(string donorID, string address, string phone, char cardType,
            string cardNumber, string cardExpiry,string firstname, string lastname) : base(firstname, lastname)
        {
            this.DonorID = donorID;
            this.Address = address;
            this.Phone = phone;
            this.CardType = cardType;
            this.CardNumber = cardNumber;
            this.CardExpiry = cardExpiry;
        }

        public override string toString()
        {
            return "DonorID: " + this.DonorID + 
                "   Address: " + this.Address + 
                "   Phone: " + this.Phone +
                "\nCardType: " + this.CardType +
                "  CardNumber: " + this.CardNumber +
                "  CardExpiry: " + this.CardExpiry +
                base.toString();
        }

        public string donorID
        {
            get { return this.DonorID; }
            set { this.DonorID = value; }
        }
        public string address
        {
            get { return this.Address; }
            set { this.Address = value; }
        }
        public string phone
        {
            get { return this.Phone; }
            set { this.Phone = value; }
        }
        public char cardType
        {
            get { return this.CardType; }
            set { this.CardType = value; }
        }
        public string cardNumber
        {
            get { return this.CardNumber; }
            set { this.CardNumber = value; }
        }
        public string cardExpiry
        {
            get { return this.CardExpiry; }
            set { this.CardExpiry = value; }
        }

        public string getID()
        {
            return DonorID;
        }





    }
}
