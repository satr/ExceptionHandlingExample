namespace WcfService
{
    public static class Storage
    {
        private static BookManager _bookManager;

        public static BookManager BookManager
        {
            get { return _bookManager?? (_bookManager = new BookManager()); }
        }
    }
}