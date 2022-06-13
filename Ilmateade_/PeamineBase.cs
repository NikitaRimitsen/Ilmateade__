using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ilmateade_
{
    [Table("PeamineBase")]
    public class PeamineBase
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Riik { get; set; }
        public string Linn { get; set; }
        public string Temtemperatuur { get; set; }
        public int Surve { get; set; }
        public int Niiskus { get; set; }
        public string Tuule_suund { get; set; }
        //public string tuulekiirus { get; set; }
        //public int zapomnit { get; set; }

        [Ignore]
        public string kartinka
        {
            get
            {
                if (Niiskus <= 25)
                {
                    return "solnce.png";
                }
                else if (Niiskus <= 50)
                {
                    return "solnceizoblakov.png";
                }
                else
                {
                    return "dozd.png";
                }
            }
        }

        [Ignore]
        public string varvid
        {
            get
            {
                if (Niiskus <= 25)
                {
                    return "LightSteelBlue";
                }
                else if (Niiskus <= 50)
                {
                    return "RoyalBlue";
                }
                else
                {
                    return "DodgerBlue";
                }
            }
        }
    }
}
