using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    /// <summary>
    /// Framework-typed (string-based) IWithX interface for username.
    /// </summary>
    [WithXMarker, DataTypeMarker]
    public interface IWithUsername :
        IHasUsername
    {
        new string Username { get; set; }
    }
}
