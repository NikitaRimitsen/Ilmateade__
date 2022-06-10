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
        public int Temtemperatuur { get; set; }
        public int Surve { get; set; }
        public int Niiskus { get; set; }
        public string tuule_suund { get; set; }
        //public string tuulekiirus { get; set; }
        public int zapomnit { get; set; }


    }
}
