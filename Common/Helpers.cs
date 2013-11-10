using System;
using System.Linq;

namespace Common
{
    public static class Helpers
    {
        static readonly object[] FormatArgExtention = Enumerable.Repeat((object)'?', 100).ToArray();

        public static void Throw<T>(string format, params object[] args)
            where T : Exception
        {
            throw (T)Activator.CreateInstance(typeof(T), GetStringFormatUnchecked(format, args));
        }

        public static string GetStringFormatUnchecked(string format, params object[] args)
        {
            try
            {
                return string.Format(format, args);
            }
            catch (FormatException)
            {
                return string.Format(format, args.Concat(FormatArgExtention).ToArray());
            }
        }
    }
}
