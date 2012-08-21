using System;
using System.Collections.Generic;
using System.Linq;

namespace UfYH.Models
{
    public enum Room { AllRooms, Bathroom, Bedroom, Kitchen, LivingRoom }

    [Serializable]
    public class RandomListModel
    {
        //Empty constructor for Serialization
         public RandomListModel()
         {
             Tasks = new List<Task>();
         }
        public List<Task> Tasks;

        public Task GetRandomTask(int duration, Room room)
        {
            IList<Task> list;
            if (room.Equals(Room.AllRooms))
                list = (from task in Tasks where (task.Duration.Equals(duration)) select task).ToList();
            else
                list =
                    (from task in Tasks where (task.Duration.Equals(duration)) && (task.Room.Equals(room)) select task).
                        ToList();

            return list[(new Random()).Next(0, list.Count)];
        } 

        public Task GetRandomTask(Room room)
        {
            var list = (from task in Tasks where (task.Room.Equals(room)) select task).ToList();
            return list[(new Random()).Next(0, list.Count)];  
        }
    }
}