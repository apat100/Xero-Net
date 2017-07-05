using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Xero.Api.Core.Model.Types;

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
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FirstName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string LastName { get; set; }
        [DataMember]
        public BusinessStructure BusinessStructure { get; set; }
        
        public string DisplayName
        {
            get
            {
                string name;

                switch (BusinessStructure)
                {
                    case BusinessStructure.Person:
                    case BusinessStructure.SoleTrader:
                        name = string.Format("{0} {1}", FirstName, LastName);
                        break;
                    default:
                        name = Name;
                        break;
                }

                return name;
            }
        }
    }
}
