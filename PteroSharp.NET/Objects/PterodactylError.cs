﻿using System.Diagnostics;

namespace PteroSharp.Objects
{
    [DebuggerDisplay("{" + nameof(Status) + "} : {" + nameof(Detail) + "}")]
    public class PterodactylError
    {

        public string Code { get; set; }

        public int Status { get; set; }

        public string Detail { get; set; }
        
    }
}
