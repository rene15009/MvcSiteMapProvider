﻿// -----------------------------------------------------------------------
// <copyright file="ISiteMapBuilderSetStrategy.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace MvcSiteMapProvider.Core.SiteMap.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface ISiteMapBuilderSetStrategy
    {
        ISiteMapBuilder GetBuilder(string name);
    }
}