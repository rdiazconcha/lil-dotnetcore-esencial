using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Throws<System.IO.DirectoryNotFoundException>(()=>{
                zipper.ZipperLogic.Zip(@"C:\test", ":::");
            });
        }
    }
}