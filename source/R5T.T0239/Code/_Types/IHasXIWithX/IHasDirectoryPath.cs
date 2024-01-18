using System;

using R5T.T0142;


namespace R5T.T0239
{
    /// <summary>
    /// Has a stringly-typed directory path.
    /// </summary>
    [DataTypeMarker]
    public interface IHasDirectoryPath
    {
        string DirectoryPath { get; }
    }
}
