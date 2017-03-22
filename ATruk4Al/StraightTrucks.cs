using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATruk4Al
{
    class StraightTrucks : Truck
    {
        public StraightTrucks() { }
        //Atributes 
        string totaTime;



        // Constructor         
        //public StraightTrucks(string aTruckBrand, string aTruckType, double aLoadWeight, double aLoadHight, double aLoadWidth, char aloadType, int aDistance)
        //{
        //    TruckBrand = aTruckBrand;
        //    TruckType = aTruckType;
        //    LoadWeight = aLoadWeight;
        //    LoadWidth = aLoadWidth;
        //    LoadHight = aLoadHight;
        //    Distance = aDistance;

        //}// end of the constructor method for StrightTrucks 

        //public override string CreateIDNumber
            
        //{
        //    get
        //    {

        //    string temp, temp1, temp2, todoTemp;
        //    Random tempRnd = new Random();


        //    // this will be the first 3 letters of the brand of the truck + Type 2 + waith of load 4 ramdom number
        //    temp = this.TruckBrand.Substring(0, 3);

        //    temp1 = this.TruckType.Substring(0, 2);

        //    temp2 = this.LoadWeight.ToString();

        //    return todoTemp = String.Format("Yor Ticket ID is:  " + "{0}" + "{1}" + "{2}" + "{3}",
        //                        temp, temp1, temp2, tempRnd.Next(1000, 100000).ToString());
        //   }

        //}// end of the method override  Create Id mumber 

        public override string TimeEnlapse
        {
            get
            {
                double  timeHours;
                decimal timeMin;
                int MILES_PER_HOUR = 65;
                
                Console.WriteLine("How many miles are you going to trabel?");
                timeHours =  Convert.ToDouble(Console.ReadLine()) / MILES_PER_HOUR;
                timeMin = Convert.ToDecimal(timeHours);

                int count = BitConverter.GetBytes(decimal.GetBits(timeMin)[3])[2];

                return totaTime = String.Format("Your will receive your Load in about  " + " {0}" + " hours"  + " and" + " {1}" + " minutes" ,
                    System.Math.Truncate(timeHours).ToString(), timeMin.ToString());
                                
            }
            set
            {
                value = totaTime; 

            }
           

        }
    }
}
