using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ETS_ClassLibrary
{
    class Prize
    {
        string PrizeID;
        string Description;
        double Value;
        double DonationLimit;
        int OriginalAvailable;
        //how many = OriginalAvailable
        int CurrentAvailable;
        string SponsorID;
        

        public Prize(string prizeID, string description, double value, int originalAvailable, 
            double donationLimit, string sponsorID)
        {
            this.PrizeID = prizeID;
            this.Description = description;
            this.Value = value;
            this.DonationLimit = donationLimit;
            this.OriginalAvailable = originalAvailable;
            this.CurrentAvailable = currentAvailable;
            this.SponsorID = sponsorID;
            
        }

        public string prizeID
        {
            get { return PrizeID; }
            set { PrizeID = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public double value
        {
            get { return Value; }
            set { Value = value; }
        }

        public string sponsorID
        {
            get { return SponsorID; }
            set { SponsorID = value; }
        }

        public double donationLimit
        {
            get { return DonationLimit; }
            set { DonationLimit = value; }
        }

        public int originalAvailable
        {
            get { return OriginalAvailable; }
            set { OriginalAvailable = value; }
        }

        public int currentAvailable
        {
            get { return CurrentAvailable; }
            set { CurrentAvailable = value; }
        }


        public string toString()
        {
            return "PrizeID: " + this.PrizeID +
                "  Description: " + this.Description +
                "  Value: " + this.Value +
                "  DonationLimit: " + this.DonationLimit +
                "  OriginalAvailable: " + this.OriginalAvailable +
               // "  CurrentAvailable: " + this.CurrentAvailable +
                "  Sponsor ID: " + this.SponsorID;
        }

        public string showPrice()
        {
            return "PrizeID: " + this.PrizeID +
                "  Description: " + this.Description +
                "  Value: " + this.Value;
                
                
        }
        public void Decrease()
        {

        }

        public void ClearPrize()
        {
            Console.Clear();
        }

        public string getID()
        {
            return prizeID;
        }







    }
}
