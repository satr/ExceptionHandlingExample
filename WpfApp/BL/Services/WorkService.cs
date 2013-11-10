using WpfApp.WorkServiceReference;

namespace WpfApp.BL.Services
{
    class WorkService
    {
        private WorkServiceClient _serviceClient;

        public IWorkService Instance
        {
            get { return _serviceClient?? (_serviceClient = new WorkServiceReference.WorkServiceClient()); }
        }
    }
}
