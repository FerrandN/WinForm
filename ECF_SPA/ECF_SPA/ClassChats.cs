using ECF_SPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_SPA
{
    internal class ClassChats
    {
        public long NumeroPuce { get; set; }

        public string? Nom { get; set; }

        public int? Age { get; set; }

        public int Race { get; set; }

        public virtual Race RaceNavigation { get; set; } = null!;

        public enum EnumRaceDuChat
        {
            Abyssin,
            Europeen,
            MaineCoon,
            Sphynx
        }
        public EnumRaceDuChat hisRace;
        public ClassChats(Chat chatToModify)
        {
            NumeroPuce = chatToModify.NumeroPuce;
            Nom = chatToModify.Nom;
            Age = chatToModify.Age;
            Race = chatToModify.Race;
            RaceNavigation = chatToModify.RaceNavigation;
            hisRace = (ClassChats.EnumRaceDuChat)chatToModify.Race;
        }
    }
}
