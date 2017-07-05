using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Xero.Api.HQ.Model.Types;

namespace Xero.Api.HQ.Model
{
    public class AlertAccess
    {
        [DataMember]
        public string To { get; set; }
    }
}
