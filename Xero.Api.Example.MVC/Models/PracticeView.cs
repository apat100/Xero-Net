using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xero.Api.HQ.Model;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Example.MVC.Models
{
    public class PracticeView
    {
        public IList<Client> Clients { get; set; }
        public Alert Alert { get; set; }
        public List<ValidationError> Errors { get; set; } = new List<ValidationError>();
    }
}