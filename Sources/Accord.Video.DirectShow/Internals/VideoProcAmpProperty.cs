namespace Accord.Video.DirectShow.Internals
{
    /// <summary>
    /// https://msdn.microsoft.com/en-us/library/ms787924(v=vs.85).aspx
    /// </summary>
    public enum VideoProcAmpProperty
    {
        /// <summary>
        /// Specifies the brightness, also called the black level. For NTSC, the value is expressed in IRE units * 100.
        /// For non-NTSC sources, the units are arbitrary, with zero representing blanking and 10,000 representing pure white.
        /// Values range from –10,000 to 10,000.
        /// </summary>
        Brightness,

        /// <summary>
        /// Specifies the contrast, expressed as gain factor * 100. Values range from zero to 10,000. 
        /// </summary>
        Contrast,

        /// <summary>
        /// Specifies the hue, in degrees * 100. Values range from -180,000 to 180,000 (-180 to +180 degrees).
        /// </summary>
        Hue,

        /// <summary>
        /// Specifies the saturation. Values range from 0 to 10,000.
        /// </summary>
        Saturation,

        /// <summary>
        /// Specifies the sharpness. Values range from 0 to 100.
        /// </summary>
        Sharpness,

        /// <summary>
        /// Specifies the gamma, as gamma * 100. Values range from 1 to 500. 
        /// </summary>
        Gamma,

        /// <summary>
        /// Specifies the color enable setting. The possible values are 0 (off) and 1 (on).
        /// </summary>
        ColorEnable,

        /// <summary>
        /// Specifies the white balance, as a color temperature in degrees Kelvin. The range of values depends on the device.
        /// </summary>
        WhiteBalance,

        /// <summary>
        /// Specifies the backlight compensation setting. Possible values are 0 (off) and 1 (on).
        /// For Logitech cameras this should be the automatic light setting and should be turned off.
        /// </summary>
        BacklightCompensation,

        /// <summary>
        /// Specifies the gain adjustment. Zero is normal. Positive values are brighter and negative values are darker. The range of values depends on the device.
        /// </summary>
        Gain
    }
}