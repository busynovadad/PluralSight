using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        //public Nullable<int> DaysSinceLastLogin { get; set; }
        //public Nullable<DateTime> DateOfBirth { get; set; }
        public int? DaysSinceLastLogin { get; set;}
        public DateTime? DateOfBirth{ get; set; }
        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            //            DateOfBirth = DateTime.MinValue; // magic number
            //            DaysSinceLastLogin = -1; // magic number again
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }
    }
}
