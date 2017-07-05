using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Xero.Api.Infrastructure.ThirdParty.ServiceStack.Text;

namespace Xero.Api.HQ.Model
{
    public class AlertDataTest
    {
        [DataMember(EmitDefaultValue = false)]
        public string App { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime Date { get; set; }
    }
}
