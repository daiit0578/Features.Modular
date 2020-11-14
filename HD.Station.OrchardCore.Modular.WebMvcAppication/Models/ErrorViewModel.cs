using System;

namespace HD.Station.OrchardCore.Modular.WebMvcAppication.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
