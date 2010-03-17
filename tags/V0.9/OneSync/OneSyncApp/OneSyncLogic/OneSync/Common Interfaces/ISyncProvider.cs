﻿/*
 $Id: ISyncProvider.cs 66 2010-03-10 07:48:55Z gclin009 $
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace OneSync.Synchronization
{
    /// <summary>
    /// Sync provider retrieve and update the metadata
    /// </summary>
    public interface ISyncProvider
    {
        //this change results must contains change in source (compare to destination) and changes in destination
        //(compared to source).
        IList<SyncAction> Generate();            

    }
}
