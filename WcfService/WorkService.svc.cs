using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using WcfService.Properties;

namespace WcfService
{
    public class WorkService : IWorkService
    {
        public Collection<Book> GetBookListCorrect()
        {
            return Storage.BookManager.GetBookList();
        }

        public Collection<Book> GetBookListError()
        {
            //simulate error
            ThrowRecoverableException(Resources.Messafe_Operation_cannot_be_performed, Resources.Message_Book_storage_is_not_available_at_this_time);
            return Storage.BookManager.GetBookList();
        }

        public Collection<Book> GetBookListCriticalFail()
        {
            //simulate critical failure
            ThrowUnrecoverableException(Resources.Message_This_operation_requires_user_permits, Resources.Message_Access_to_database_denied);
            return Storage.BookManager.GetBookList();
        }

        public void SaveCorrect(Book book)
        {
            try
            {
                Storage.BookManager.Add(book);
            }
            catch (ArgumentException e)
            {
                ThrowRecoverableException(e.Message, Resources.Message_Book_with_such_title_and_amount_of_pages_exists);
            }
            catch (Exception)
            {
                ThrowUnrecoverableException(Resources.Message_Critical_failure_occured, Resources.Message_Operation_is_interrupted);
            }
        }

        public void SaveError(Book book)
        {
            //simulate error
            ThrowRecoverableException(Resources.Messafe_Operation_cannot_be_performed, Resources.Message_Book_storage_is_not_available_at_this_time);
        }

        public void SaveCriticalFail(Book book)
        {
            //simulate critical failure
            ThrowUnrecoverableException(Resources.Message_This_operation_requires_user_permits, Resources.Message_Access_to_database_denied);
        }

        private static void ThrowRecoverableException(string issue, string reason)
        {
            throw new FaultException<RecoverableFault>(new RecoverableFault {Issue = issue}, new FaultReason(reason));
        }

        private static void ThrowUnrecoverableException(string issue, string reason)
        {
            throw new FaultException<UnrecoverableFault>(new UnrecoverableFault {Issue = issue}, new FaultReason(reason));
        }
    }
}
