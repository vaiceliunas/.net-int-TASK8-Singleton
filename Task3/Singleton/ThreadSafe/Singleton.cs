using System;

namespace Singleton.ThreadSafe
{
    public class Singleton
    {
        private static Singleton _instance = new Singleton();
        private Singleton()
        {
        }
        static Singleton()
        {
        }
        public static Singleton Instance => _instance;
    }
}
