using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Person
    {
        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FirstName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LastName { get; set; }
    }
}
