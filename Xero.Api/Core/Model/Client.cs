using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Client
    {
        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string XeroOrganisationId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Business Business { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Person Person { get; set; }

        public string Name
        {
            get
            {
                string name = " ";
                if (Business != null)
                {
                    name = Business.Name;
                }
                else if (Person != null)
                {
                    name = string.Format("{0} {1}", Person.FirstName, Person.LastName);
                }
                return name;
            }
        }
    }
}
