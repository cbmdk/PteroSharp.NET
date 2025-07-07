using PteroSharp.Endpoints;
using System.Collections.Generic;

namespace PteroSharp.Utils
{
    public class PterodactylList<T> : List<T> 
    {

        public PterodactylList(BaseResponse<T> response) : base(response.Data)
        { }

        public PterodactylList(IEnumerable<T> enumerable) : base(enumerable)
        { }
    }
}
