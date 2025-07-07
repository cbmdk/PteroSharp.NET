using System;
using System.Linq;
using PteroSharp.Objects;

namespace PteroSharp.Exceptions
{
    public class PterodactylException : Exception
    {

        public PterodactylError[] Errors { get; }

        public PterodactylException(PterodactylError[] errors) : base(errors.First().Detail)
        {
            Errors = errors;
        }

        public PterodactylException(string exception) : base(exception)
        { }

    }
}
