using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    /// <summary>
    /// OBSOLETE - See R5T.L0093.T000.
    /// 
    /// Has a stringly-typed directory path.
    /// </summary>
    [HasXMarker, DataTypeMarker]
    public interface IHasDirectoryPath
    {
        string DirectoryPath { get; }
    }
}
