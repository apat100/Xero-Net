using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xero.Api.Core.Model
{
    public class Alert
    {
        [DataMember(EmitDefaultValue = false)]
        public Guid Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TargetType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Guid TargetId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public IList<AlertAction> Actions { get; set; }
    }
}
