// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PortAudioNet
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct PaStreamCallbackTimeInfo
    {
        [FieldOffset(0)] public double inputBufferAdcTime;

        [FieldOffset(8)] public double currentTime;

        [FieldOffset(16)] public double outputBufferDacTime;
    }
}
