using System;
using System.IO.Compression;

namespace zipper
{
    public class ZipperLogic
    {
        public static void Zip(string source, string target){
            ZipFile.CreateFromDirectory(source, target);
        }
    }
}
