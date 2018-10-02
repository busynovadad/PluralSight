using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            //int damageReduction = 0;
            //if (_specialDefence != null)
            //{
            //    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //}
            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
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
