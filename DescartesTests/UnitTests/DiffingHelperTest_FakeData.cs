using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescartesTests.UnitTests
{
    public static class DiffingHelperTest_FakeData
    {
        /// <summary>
        /// Gemerates an array of bytes
        /// </summary>
        /// <param name="sizeInKB">Specify the number of KB you want your array to have. Default: 1KB</param>
        /// <returns>Byte array</returns>
        public static byte[] GenerateFakeArray(int sizeInKB = 1)
        {
            byte[] data = new byte[sizeInKB * 1024];
            new Random().NextBytes(data);
            return data;
        }

    }
}
