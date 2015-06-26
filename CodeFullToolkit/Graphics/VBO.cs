﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFull.Graphics
{
    /// <summary>
    /// Represents the required VBO handles
    /// </summary>
    public struct Vbo
    {
        /// <summary>
        /// The vertex buffer handle
        /// </summary>
        public int vertexId;

        /// <summary>
        /// The color buffer handle
        /// </summary>
        public int colorId;

        /// <summary>
        /// The face arrays handle
        /// </summary>
        public int faceId;

        /// <summary>
        /// Number of elements in this VBO
        /// </summary>
        public int numElements;
    }
}
