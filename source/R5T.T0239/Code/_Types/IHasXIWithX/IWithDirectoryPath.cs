﻿using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0239
{
    [WithXMarker, DataTypeMarker]
    public interface IWithDirectoryPath :
        IHasDirectoryPath
    {
        new string DirectoryPath { get; set; }
    }
}
