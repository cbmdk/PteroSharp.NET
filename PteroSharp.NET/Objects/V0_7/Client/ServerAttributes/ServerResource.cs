using PteroSharp.Enum;
using PteroSharp.Objects.Components;

namespace PteroSharp.Objects.V0_7.Client.ServerAttributes
{

    public class ServerResource
    {

        public ServerRunningState State { get; set; }

        public Memory Memory { get; set; }

        public Cpu CPU { get; set; }

        public Disk Disk { get; set; }

    }
}
