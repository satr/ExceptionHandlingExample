using System;
using System.IO;

namespace InternalComponent
{
    public class InternalBL
    {
        public void MethodWhichInvokesPrivateMethodThrowingFileNotFoundException()
        {
            MethodThrowingFileNotFoundException();
        }

        private void MethodThrowingFileNotFoundException()
        {
            throw new FileNotFoundException("Expected file not found");
        }

        public void MethodWhichInvokesPrivateMethodThrowingException()
        {
            MethodThrowingException();
        }

        private void MethodThrowingException()
        {
            throw new Exception("Unexpected error orrured");
        }
    }
}
