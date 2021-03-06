﻿// <copyright file="IntersectNode.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Drawing.Shapes.PolygonClipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using Paths;

    /// <summary>
    /// ??
    /// </summary>
    internal class IntersectNode
    {
#pragma warning disable SA1401 // Field must be private
        /// <summary>
        /// The edge1
        /// </summary>
        internal TEdge Edge1;

        /// <summary>
        /// The edge2
        /// </summary>
        internal TEdge Edge2;

        /// <summary>
        /// The pt
        /// </summary>
        internal System.Numerics.Vector2 Pt;
#pragma warning restore SA1401 // Field must be private
    }
}