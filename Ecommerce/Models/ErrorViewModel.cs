using System;

namespace Ecommerce.Models
{
    public class ErrorViewModel
    {//teste
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}