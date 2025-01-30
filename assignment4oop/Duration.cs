using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4oop
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public void DisplayDuration()
        {
            Console.WriteLine($"Duration: {Hours} hours, {Minutes} minutes, {Seconds} seconds");
        }

        public override string ToString()
        {
            return $"Duration: {Hours} hours, {Minutes} minutes, {Seconds} seconds";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
