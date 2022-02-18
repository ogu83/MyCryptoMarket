using System.Collections.Generic;

namespace MyCryptoMarket.Models
{
    public class DxGridResponse<T> where T : class
    {
        public DxGridResponse(IEnumerable<T> elements, int totalCount)
        {
            data = elements;
            this.totalCount = totalCount;
        }

        public IEnumerable<T> data { get; set; }
        public int totalCount { get; set; }
    }
}