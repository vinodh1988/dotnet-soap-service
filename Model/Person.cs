using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model{
    [DataContract]
    public class Person{
        [DataMember]
        public int Sno { get; set; }
        [DataMember]
        public String Name {get; set; }
        [DataMember]
        public String City { get; set; }
    }
}