// Copyright (c) 2012-2015 Sharpex2D - Kevin Scholz (ThuCommix)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the 'Software'), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Sharpex2D.Framework.Rendering.OpenGL
{
    internal enum ContextAttributes
    {
        /// <summary>
        /// Major version.
        /// </summary>
        MajorVersion = 0x2091,

        /// <summary>
        /// Minor version.
        /// </summary>
        MinorVersion = 0x2092,

        /// <summary>
        /// Layer plane.
        /// </summary>
        LayerPlane = 0x2093,

        /// <summary>
        /// Flags.
        /// </summary>
        Flags = 0x2094,

        /// <summary>
        /// Profile mask.
        /// </summary>
        ProfileMask = 0x9126,

        /// <summary>
        /// Debug.
        /// </summary>
        Debug = 0x0001,

        /// <summary>
        /// Forward compatible.
        /// </summary>
        ForwardCompatible = 0x0002,

        /// <summary>
        /// Core profile.
        /// </summary>
        CoreProfile = 0x00000001,

        /// <summary>
        /// Compatibility profile.
        /// </summary>
        CompatibilityProfile = 0x00000002
    }
}
