using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercent { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropPercent, bool isDefaultItem) 
        {
            Details = details;
            DropPercent = dropPercent;
            IsDefaultItem = isDefaultItem;
        }
    }
}
