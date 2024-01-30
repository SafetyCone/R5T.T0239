using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    [WithXMarker, DataTypeMarker]
    public interface IWithFilePath :
        IHasFilePath
    {
        new string FilePath { get; set; }
    }
}
