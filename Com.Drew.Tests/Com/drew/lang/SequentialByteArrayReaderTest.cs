using System;
using NUnit.Framework;

namespace Com.Drew.Lang
{
    /// <author>Drew Noakes https://drewnoakes.com</author>
    public class SequentialByteArrayReaderTest : SequentialAccessTestBase
    {
        [Test, ExpectedException(typeof(ArgumentNullException))]
        public virtual void TestConstructWithNullStreamThrows()
        {
            new SequentialByteArrayReader(null);
        }

        protected override SequentialReader CreateReader(byte[] bytes)
        {
            return new SequentialByteArrayReader(bytes);
        }
    }
}
