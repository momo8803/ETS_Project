using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ETS_ClassLibrary
{
    public class ETSManager
    {
        public ETSManager() { }
        Sponsors mySponsors = new Sponsors();
        Donors myDonors = new Donors();
        Prizes myPrizes = new Prizes();
        Donations myDonations = new Donations();

        public bool sponsorVerifier(string sID)
        {
            bool flag = false;
            foreach (Sponsor spo in mySponsors)
            {
                if (spo.getID() == sID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool donorsVerifier(string dID)
        {
            bool flag = false;
            foreach (Donor don in myDonors)
            {
                if (don.getID() == dID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool prizesVerifier(string pID)
        {
            bool flag = false;
            foreach (Prize pri in myPrizes)
            {
                if (pri.getID() == pID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool donationVerifier(string doID)
        {
            bool flag = false;
            foreach (Donation dona in myDonations)
            {
                if (dona.getID() == doID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public string addSponsor(string sponsorID, double totalPrizeValue, string firstname, string lastname)
        {
            string message = "";
            if (sponsorID.Length != 4)
            {
                message = "Error. The sponsorID should be 4 chars.";
            }
            else
            {
                if (sponsorVerifier(sponsorID) == true)
                {
                    message = "Error! There exist this ID for another sponsor!";
                }
                else
                {
                    if (firstname.Length + lastname.Length > 30)
                    {
                        message = "Error! Names should be 30 chars";
                    }
                    else
                    {
                        Sponsor sponsor = new Sponsor(sponsorID, totalPrizeValue, firstname, lastname);
                        mySponsors.add(sponsor);
                        message = "Success! The sponsor added to the list";
                    }
                }
            }
            return message;
        }

        public string addDonor(string donorID, string address, string phone, char cardType,
            string cardNumber, string cardExpiry, string firstname, string lastname)
        {
            string message = "";
            if (donorID.Length != 4)
            {
                message = "Error. The donorID should be 4 chars.";
            }
            else
            {
                if (donorsVerifier(donorID) == true)
                {
                    message = "Error! There exist this ID for another donor!";
                }
                else
                {
                    if (firstname.Length + lastname.Length > 30)
                    {
                        message = "Error! Names should be 30 chars";
                    }
                    else
                    {
                        Donor donor = new Donor(donorID, address, phone, cardType, cardNumber, cardExpiry, firstname, lastname);    
                        myDonors.add(donor);
                        message = "Success! The donor added to the list";
                    }
                }
            }
            return message;
        }

        
        public string addPrize(string prizeID, string description, double value,int originalAvailable,
            double donationLimit, string sponsorID)
        {
            string message = "";
            if (prizeID.Length != 4)
            {
                message = "Error. The prizeID should be 4 chars.";
            }
            else
            {
                if (prizesVerifier(prizeID) == true)
                {
                    message = "Error! There exist this ID for another prize!";
                }
                else
                {
                    if (value > 299.99)
                    {
                        message = "Prize value should be less than $299.99";
                    }
                    else
                    {
                        if (sponsorVerifier(sponsorID) == false)
                        {
                            message = " Cannot find this sponsor ID";
                        }
                        else
                        {
                            Prize prize = new Prize(prizeID, description, value, originalAvailable, donationLimit,sponsorID);
                            double tpv = value * originalAvailable;
                            foreach (Sponsor spo in mySponsors)
                            {
                                if (spo.SponsorID == sponsorID)
                                {
                                    spo.addValue(tpv);
                                }
                            }
                                myPrizes.add(prize);
                            message = "Success! The prize added to the list";
                        }
                    }
                }
            }
            return message;
        }

       

        public string addDonation(string donationID, double donationAmount, string donationDate)

        {
            string message = "";
            if (donationID.Length != 4)
            {
                message = "Error. The donationID should be 4 chars.";
            }
            else
            {
                if (donationVerifier(donationID) == true)
                {
                    message = "Error! There exist this ID for another donation!";
                }
                else
                {
                    if (donationAmount < 5 && donationAmount > 999999.99)
                    {
                        message = "Amount can be between $5 and $999,999.99";
                    }
                    else
                    {
                    Donation donation = new Donation(donationID, donationAmount, donationDate);                  
                    myDonations.add(donation);
                    message = "Success! The donation added to the list";
                    }
                }
            }
            return message;
        }


        public string getAllSponsorInfo()
        {
            string info = "";
            foreach (Sponsor spo in mySponsors)
            {
                info += spo.toString();
                info += Environment.NewLine;
            }
            return info;
        }

        public string getAllDonorInfo()
        {
            string info = "";
            foreach (Donor don in myDonors)
            {
                info += don.toString();
                info += Environment.NewLine;
            }
            return info;
        }

        public string getAllPrizeInfo()
        {
            string info = "";
            foreach (Prize pri in myPrizes)
            {
                info += pri.toString();
                info += Environment.NewLine;
            }
            return info;
        }

        public string getAllDonationInfo()
        {
            string info = "";
            foreach (Donation dona in myDonations)
            {
                info += dona.toString();
                info += Environment.NewLine;
            }
            return info;
        }

        public string showPrize(string showPID/*, int number*/)
        {
            //bool flag = false;
            string message = "";
            foreach (Prize pri in myPrizes)
            {
                if (showPID.Length != 4)
                {
                    message = "Error. The prizeID should be 4 chars.";
                }
                else
                {
                    if(showPID != pri.prizeID)
                    {
                    message = "Cant find this prize ID";
                    //flag = true;
                    }
                    else
                    {
                        //if(number == pri.howMany)
                        //{
                        message += pri.showPrice();
                        message += Environment.NewLine;
                    }
                    //    flag = true;
                    //}
                    //else
                    //{
                    //    message = "cant find this number";
                    //    flag = true;
                    //}
                }
                
            }
            //if(flag == false)
            //{
            //    message = "cant find any!";
            //}

            return message;
        }

        public string saveDonorIntoFile()
        {
            string message = "";
            try
            {
                using (StreamWriter SW = new StreamWriter(@"C:\Users\mosik\source\C2\TelethonSystemWin\Donor.txt"))
                {
                    foreach (Donor don in myDonors)
                    {
                        SW.WriteLine(don.toString());
                    }
                }
                message = "Success! Records added to the file!";
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            return message;
        }









    }
}
