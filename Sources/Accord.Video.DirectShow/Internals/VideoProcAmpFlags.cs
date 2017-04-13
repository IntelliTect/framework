using System;

namespace Accord.Video.DirectShow.Internals
{
    /// <summary>
    /// https://msdn.microsoft.com/en-us/library/ms787923(v=vs.85).aspx
    /// </summary>
    [Flags]
    public enum VideoProcAmpFlags
    {
        /// <summary>
        /// The setting is not controlled.
        /// </summary>
        None = 0,

        /// <summary>
        /// The setting is controlled automatically.
        /// </summary>
        Auto = 0x0001,

        /// <summary>
        /// The setting is controlled manually.
        /// </summary>
        Manual = 0x0002
    }
}