using System.Collections.ObjectModel;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IWorkService
    {

        [OperationContract]
        [FaultContract(typeof(RecoverableFault))]
        [FaultContract(typeof(UnrecoverableFault))]
        Collection<Book> GetBookListCorrect();

        [OperationContract]
        [FaultContract(typeof(RecoverableFault))]
        [FaultContract(typeof(UnrecoverableFault))]
        Collection<Book> GetBookListError();

        [OperationContract]
        [FaultContract(typeof(RecoverableFault))]
        [FaultContract(typeof(UnrecoverableFault))]
        Collection<Book> GetBookListCriticalFail();

        [OperationContract]
        [FaultContract(typeof(RecoverableFault))]
        [FaultContract(typeof(UnrecoverableFault))]
        void SaveCorrect(Book book);

        [OperationContract]
        [FaultContract(typeof(RecoverableFault))]
        [FaultContract(typeof(UnrecoverableFault))]
        void SaveError(Book book);

        [OperationContract]
        [FaultContract(typeof(RecoverableFault))]
        [FaultContract(typeof(UnrecoverableFault))]
        void SaveCriticalFail(Book book);

    }
}
