using System;
using System.Collections.Generic;
using System.Linq;

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

        public Task GetRandomTask(int duration)
        {
            var list = (from task in Tasks where (task.Duration.Equals(duration)) select task).ToList();
            return list[(new Random()).Next(0, list.Count)];
        } 

        public Task GetRandomTask(string room)
        {
            var list = (from task in Tasks where (task.Room.Equals(room)) select task).ToList();
            return list[(new Random()).Next(0, list.Count)];  
        }
    }
}