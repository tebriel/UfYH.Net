using System;
using System.Collections.Generic;

namespace UfYH.Models
{
    [Serializable]
    public class RandomListModel
    {
        //Empty constructor for Serialization
         public RandomListModel()
         {
             Items = new List<string>();
         }
        public IList<string> Items;
        public int TimeLength;
    }
}