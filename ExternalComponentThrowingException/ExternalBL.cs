using System;
using ExternalBLInterfaces;

namespace ExternalComponent
{
    public class ExternalBL : IExternalBL
    {
        public void DoWork()
        {
            MethodThrowingException();
        }

        public string Description
        {
            get
            {
                return "Plugin Throwing Exception";
            }
        }

        private void MethodThrowingException()
        {
            throw new Exception("Unexpected error orrured");
        }
    }

}
