using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using WcfService.Properties;

namespace WcfService
{
    public class WorkService : IWorkService
    {
        private readonly static Collection<Book> BookList = new Collection<Book>();

        public Collection<Book> GetBookListCorrect()
        {
            return BookList;
        }

        public Collection<Book> GetBookListError()
        {
            //simulate error
            ThrowRecoverableException(Resources.Messafe_Operation_cannot_be_performed, Resources.Message_Book_storage_is_not_available_at_this_time);
            return BookList;
        }

        public Collection<Book> GetBookListCriticalFail()
        {
            //simulate critical failure
            ThrowUnrecoverableException(Resources.Message_This_operation_requires_user_permits, Resources.Message_Access_to_database_denied);
            return BookList;
        }

        public void SaveCorrect(Book book)
        {
            if (BookList.Any(b => b.Title == book.Title && b.Pages == book.Pages))
                ThrowRecoverableException(Resources.Message_This_book_already_exists, Resources.Message_Book_with_such_title_and_amount_of_pages_exists);
            BookList.Add(book);
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
