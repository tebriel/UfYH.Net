using System;
using System.Xml.Serialization;

namespace UfYH.Models
{
    [Serializable]
    public class Task
    {
        //Empty constructor for serialization
        public Task()
        {
            
        }
        public string Text { get; set; }

        public string Room { get; set; }

        public int Duration { get; set; }
    }
}
