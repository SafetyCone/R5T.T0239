using System;

using R5T.T0142;


namespace R5T.T0239
{
    [DataTypeMarker]
    public interface IWithFilePath :
        IHasFilePath
    {
        new string FilePath { get; set; }
    }
}
