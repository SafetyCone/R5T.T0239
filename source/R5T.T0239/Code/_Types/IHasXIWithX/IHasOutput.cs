using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    [HasXMarker, DataTypeMarker]
    public interface IHasOutput<TOutput>
    {
        TOutput Output { get; }
    }
}
