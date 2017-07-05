using System;
using System.Collections.Generic;

namespace Xero.Api.Example.MVC.Models
{
    public class AlertView
    {
        public Guid ClientId { get; set; }
        public string AppName { get; set; }
        public string AlertType { get; set; }
        public string ActionLabel { get; set; }
        public string ActionLink { get; set; }
    }
}