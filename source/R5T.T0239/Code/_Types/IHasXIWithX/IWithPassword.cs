using System;

using R5T.T0142;


namespace R5T.T0239
{
    /// <summary>
    /// Framework-typed (string-based) IWithX interface for password.
    /// </summary>
    [DataTypeMarker]
    public interface IWithPassword :
        IHasPassword
    {
        new string Password { get; set; }
    }
}
