using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    /// <summary>
    /// Framework-typed (string-based) IHaxX interface for username.
    /// </summary>
    [HasXMarker, DataTypeMarker]
    public interface IHasUsername
    {
        string Username { get; }
    }
}
