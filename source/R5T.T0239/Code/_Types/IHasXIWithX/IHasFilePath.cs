﻿using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    /// <summary>
    /// Has a stringly-typed file path.
    /// </summary>
    [HasXMarker, DataTypeMarker]
    public interface IHasFilePath
    {
        string FilePath { get; }
    }
}
