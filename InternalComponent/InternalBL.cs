using System;

namespace InternalComponent
{
    public class InternalBL
    {
        public void DoInternalBLWork()
        {
            DoSomeWorkInsideTheComponent();
        }

        private void DoSomeWorkInsideTheComponent()
        {
            throw new NotImplementedException();
        }
    }
}
