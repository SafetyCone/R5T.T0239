using System;

using R5T.T0142;


namespace R5T.T0239
{
    /// <summary>
    /// Framework-typed (string-based) IHaxX interface for username.
    /// </summary>
    [DataTypeMarker]
    public interface IHasUsername
    {
        string Username { get; }
    }
}
