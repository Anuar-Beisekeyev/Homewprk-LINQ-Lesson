using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkLINQlesson.Models
{
    public class Notebook : Entity
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public string Processor { get; set; }
        public double CPU { get; set; }
        public double MemoryCapacity { get; set; }
        public string StorageDevice { get; set; }
        public string ScreenResolution { get; set; }
        public string OperatingSystem { get; set; }
        


    }
}
