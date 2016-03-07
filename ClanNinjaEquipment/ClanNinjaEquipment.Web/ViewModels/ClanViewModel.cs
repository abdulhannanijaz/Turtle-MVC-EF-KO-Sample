using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClanNinjaEquipment.Web.ViewModels
{
    public class ClanViewModel
    {
        public int ClanID { get; set; }
        public string Name { get; set; }
        public string SymbolPic { get; set; }
        public Nullable<bool> IsEvil { get; set; }

        public string MessageToClient { get; set; }
    }
}