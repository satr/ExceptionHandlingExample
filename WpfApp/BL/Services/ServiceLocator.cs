using System;
using System.Collections.Generic;

namespace WpfApp.BL.Services
{
    class ServiceLocator
    {
        private static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>();
        private static readonly object Sync = new object();

        public static T Get<T>() where T: class, new()
        {
            lock (Sync)
            {
                var type = typeof(T);
                if(!Services.ContainsKey(type))
                    Services.Add(type, new T());
                return (T) Services[type];
            }
        }

        public static void Mock<T>(T mock) where T: class
        {
            lock (Sync)
            {
                var type = typeof(T);
                if (Services.ContainsKey(type))
                    Services[type] = mock;
                else
                    Services.Add(type, mock);
            }
        }

        public static void Clear()
        {
            lock (Sync)
            {
                Services.Clear();
            }
        }

  
    }
}
