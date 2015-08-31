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

namespace Sharpex2D.Framework.Audio.OpenAL
{
    internal class OpenALDataBuffer
    {
        /// <summary>
        /// Initializes a new OpenALDataBuffer class.
        /// </summary>
        /// <param name="id">The Id.</param>
        private OpenALDataBuffer(uint id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the next data buffer.
        /// </summary>
        public OpenALDataBuffer Next { set; get; }

        /// <summary>
        /// Gets the buffer id.
        /// </summary>
        public uint Id { private set; get; }

        /// <summary>
        /// Creates a new OpenALDataBuffer.
        /// </summary>
        /// <returns>OpenALDataBuffer</returns>
        public static OpenALDataBuffer CreateBuffer()
        {
            var bufferId = new uint[1];
            OpenALInterops.alGenBuffers(1, bufferId);
            return new OpenALDataBuffer(bufferId[0]);
        }
    }
}
