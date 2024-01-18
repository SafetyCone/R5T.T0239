using System;

using R5T.T0142;


namespace R5T.T0239
{
    /// <summary>
    /// Has a stringly-typed file path.
    /// </summary>
    [DataTypeMarker]
    public interface IHasFilePath
    {
        string FilePath { get; }
    }
}
