using System;

namespace SimpleUDP
{
    public static class Log
    {
        public static Action<string> Info = Console.WriteLine;
        public static Action<string> Warning = Console.WriteLine;
        public static Action<string> Error = Console.Error.WriteLine;
        
        public static void Initializer(Action<string> info, Action<string> warning = null, Action<string> error = null)
        {
            if (info != null) Info = info;
            if (warning != null) Warning = warning;
            if (error != null) Error = error;
        }
    }
}