using System;

using R5T.T0142;


namespace R5T.T0239
{
    [DataTypeMarker]
    public interface IWithDirectoryPath :
        IHasDirectoryPath
    {
        new string DirectoryPath { get; set; }
    }
}
