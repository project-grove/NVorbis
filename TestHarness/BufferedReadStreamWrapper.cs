using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NVorbis
{
    #if !NETCOREAPP2_0
    public partial class BufferedReadStream
    {
    }
    #endif
}
namespace TestHarness
{
    #if !NETCOREAPP2_0
    public class BufferedReadStream : NVorbis.BufferedReadStream
    #else
    class BufferedReadStream : NVorbis.BufferedReadStream
    #endif
    {
        public BufferedReadStream(Stream baseStream)
            : base(baseStream)
        {
        }

        public BufferedReadStream(Stream baseStream, bool minimalRead)
            : base(baseStream, minimalRead)
        {
        }

        public BufferedReadStream(Stream baseStream, int initialSize, int maxSize)
            : base(baseStream, initialSize, maxSize)
        {
        }

        public BufferedReadStream(Stream baseStream, int initialSize, int maxSize, bool minimalRead)
            : base(baseStream, initialSize, maxSize, minimalRead)
        {
        }
    }
}
