﻿using System.Text;


namespace SoxSharp
{
  /// <summary>
  /// Input format options.
  /// </summary>
  public class InputFormatOptions : FormatOptions
  {
    /// <summary>
    /// Input file volume adjustment factor.
    /// </summary>
    public double? Volume { get; set; }

    /// <summary>
    /// Ignore input file length given in header and read to EOF.
    /// </summary>
    public bool? IgnoreLength { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="T:SoxSharp.InputFormatOptions"/> class.
    /// </summary>
    public InputFormatOptions()
    : base()
    {
    }


    /// <summary>
    /// Translate a <see cref="InputFormatOptions"/> instance to a set of command arguments to be passed to SoX to be applied to the input file (invalidates <see cref="object.ToString()"/>).
    /// </summary>
    /// <returns>String containing SoX command arguments.</returns>
    public override string ToString()
    {
      StringBuilder inputOptions = new StringBuilder(base.ToString());

      if (Volume.HasValue)
        inputOptions.Append("--volume " + Volume.Value);

      if (IgnoreLength.HasValue && (IgnoreLength.Value == true))
        inputOptions.Append(" --ignore-length");

      return inputOptions.ToString();
    }

  }
}