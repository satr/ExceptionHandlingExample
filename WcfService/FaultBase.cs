using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class FaultBase
    {
        [DataMember]
        public string Issue { get; set; }

        [DataMember]
        public string Details { get; set; }
    }
}