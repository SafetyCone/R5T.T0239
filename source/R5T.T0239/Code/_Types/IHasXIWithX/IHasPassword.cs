using System;

using R5T.T0142;


namespace R5T.T0239
{
    /// <summary>
    /// Framework-typed (string-based) IHaxX interface for password.
    /// </summary>
    [DataTypeMarker]
    public interface IHasPassword
    {
        string Password { get; }
    }
}
