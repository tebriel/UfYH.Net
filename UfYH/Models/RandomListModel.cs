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
             Tasks = new List<Task>();
         }
        public List<Task> Tasks;
    }
}