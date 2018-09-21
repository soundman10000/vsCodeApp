//this file is for calculators of activities
using System;

namespace Application.N.Shit
{
    public static class ActivityCalculator
    {
        public static Activity AnalyzeEntry(string input)
        {
            var type = ActivityType.Dumb;
            const string message = "That sounds {0}";
            if (input.Contains("drugs", StringComparison.InvariantCultureIgnoreCase))
            {
                type = ActivityType.Fun;
            }

            if (input.Contains("women", StringComparison.InvariantCultureIgnoreCase))
            {
                type = ActivityType.Stupid;
            }

            return new Activity(type, message);
        }
    }

    public class Activity
    {
        public Activity(ActivityType type, string message)
        {
            this.Type = type;
            this.Message = message;

        }
        public ActivityType Type { get; }
        public string Message { get; }

        public override string ToString()
        {
            return string.Format(this.Message, this.Type.ToString());
        }
    }

    public enum ActivityType
    {
        Fun,
        Stupid,
        Dumb
    }
}