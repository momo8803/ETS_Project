using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_ClassLibrary
{
    class Sponsor : Person
    {
        public string SponsorID;
        double TotalPrizeValue;

        public Sponsor(string sponsorID, double totalPrizeValue, string firstname, string lastname) :base(firstname,lastname)
        {
            this.SponsorID = sponsorID;
            this.TotalPrizeValue = totalPrizeValue;
        }

        public override string toString()
        {
            return "SponsorID: " + this.SponsorID +
                    "  Total Prize Value: " + this.TotalPrizeValue +
                    base.toString();
        }

        public string sponsorID
        {
            get { return this.SponsorID; }
            set { this.SponsorID = value; }
        }

        public double totalPrizeValue
        {
            get { return this.TotalPrizeValue; }
            set { this.TotalPrizeValue = value; }
        }

        public string getID()
        {
            return sponsorID;
        }

        public void addValue(double value)
        {
            totalPrizeValue += value;
        }



    }
}
