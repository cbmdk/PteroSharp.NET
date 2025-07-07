using System.Collections.Generic;

namespace PteroSharp.Endpoints
{
    public class BaseResponse<T>
    {

        public IEnumerable<T> Data { get; set; }

    }
}
