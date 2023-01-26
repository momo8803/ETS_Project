using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ETS_ClassLibrary
{
    class Donation
    {
        string DonationID;
        string DonationDate;
        string DonorID;
        double DonationAmount;
        string PrizeID;



        //public Donation(string donationID, string donationDate, string donorID, double donationAmount, string prizeID)
        //{
        //    DonationID = donationID;
        //    DonationDate = donationDate;
        //    DonorID = donorID;
        //    DonationAmount = donationAmount;
        //    PrizeID = prizeID;

        //}

        public Donation(string donationID, double donationAmount, string donationDate)
        {
            DonationID = donationID;
            DonationDate = donationDate;
            //DonorID = donorID;
            DonationAmount = donationAmount;
            //PrizeID = prizeID;

        }




        public string toString()
        {
            return "\nDonationID: " + this.DonationID +
                "   DonationDate: " + this.DonationDate +
                //" DonorID: " + this.DonorID +
                "   Donation Amount: " + this.DonationAmount;
                //" PrizeID: " + this.PrizeID;
        }

        public string donationID
        {
            get { return this.DonationID; }
            set { this.DonationID = value; }
        }

        public string donationDate
        {
            get { return this.DonationDate; }
            set { this.DonationDate = value; }
        }

        public string donorID
        {
            get { return this.DonorID; }
            set { this.DonorID = value; }
        }

        public double donationAmount
        {
            get { return this.DonationAmount; }
            set { this.DonationAmount = value; }
        }

        public string prizeID
        {
            get { return this.PrizeID; }
            set { this.PrizeID = value; }
        }


        public string getID()
        {
            return DonationID;
        }



    }
}
