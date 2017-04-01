using System;
using System.Collections.Generic;
using System.Linq;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Infrastructure.Exceptions
{
    [Serializable]
    public class XeroHqApiException
        : ValidationException
    {
        public XeroHqApiException() { }

        public XeroHqApiException(List<ValidationError> validationErrors)
        {
            ValidationErrors = validationErrors;
        }
    }
}