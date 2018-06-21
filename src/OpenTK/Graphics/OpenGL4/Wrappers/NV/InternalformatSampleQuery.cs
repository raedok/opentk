//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "InternalformatSampleQuery" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_internalformat_sample_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="samples">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="params">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "NV_internalformat_sample_query", Version = "", EntryPoint = "glGetInternalformatSampleivNV")]
            public static void GetInternalformatSample(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.InternalFormat internalformat, int samples, OpenTK.Graphics.OpenGL4.InternalFormatPName pname, int bufSize, [OutAttribute, CountAttribute(Parameter = "bufSize")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_internalformat_sample_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="samples">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="params">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "NV_internalformat_sample_query", Version = "", EntryPoint = "glGetInternalformatSampleivNV")]
            public static void GetInternalformatSample(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.InternalFormat internalformat, int samples, OpenTK.Graphics.OpenGL4.InternalFormatPName pname, int bufSize, [OutAttribute, CountAttribute(Parameter = "bufSize")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_internalformat_sample_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="samples">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="params">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "NV_internalformat_sample_query", Version = "", EntryPoint = "glGetInternalformatSampleivNV")]
            public static unsafe void GetInternalformatSample(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.InternalFormat internalformat, int samples, OpenTK.Graphics.OpenGL4.InternalFormatPName pname, int bufSize, [OutAttribute, CountAttribute(Parameter = "bufSize")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(386)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetInternalformatSampleivNV(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.InternalFormat internalformat, int samples, OpenTK.Graphics.OpenGL4.InternalFormatPName pname, int bufSize, [OutAttribute, CountAttribute(Parameter = "bufSize")] int* @params);
        }
    }
}
