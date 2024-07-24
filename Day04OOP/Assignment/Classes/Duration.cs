using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public class Duration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }


        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }


        public override string ToString()
        {
            return Hours > 0 ? $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}" :
                   Minutes > 0 ? $"Minutes: {Minutes}, Seconds: {Seconds}" :
                   $"Seconds: {Seconds}";
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
            return (Hours, Minutes, Seconds).GetHashCode();
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            if (ReferenceEquals(d1, null))
            {
                return ReferenceEquals(d2, null);
            }

            return d1.Equals(d2);
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToTotalSeconds() + d2.ToTotalSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds = d.ToTotalSeconds() + seconds;
            return new Duration(totalSeconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToTotalSeconds() - d2.ToTotalSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator ++(Duration d)
        {
            int totalSeconds = d.ToTotalSeconds() + 60;
            return new Duration(totalSeconds);
        }

        public static Duration operator --(Duration d)
        {
            int totalSeconds = d.ToTotalSeconds() - 60;
            return new Duration(totalSeconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }


        public static implicit operator bool(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        private int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
    }
}

