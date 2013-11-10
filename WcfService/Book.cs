using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int Pages { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}