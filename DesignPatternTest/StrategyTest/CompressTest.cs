using DesignPattern.Strategy;
using NFluent;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatternTest.StrategyTest
{
    class CompressTest
    {

        [Test]
        public void Should_compress_folder_to_zip()
        {
            var folders = new List<ICompression>()
            {
                new ZipCompression("Documents"),
                new ZipCompression("Job"),
                new ZipCompression("Photos"),
            };

            var context = new CompressContext(folders);

            var actualValue = context.Compress();

            string expectedValue = $"The Documents Folder is compressed using Zip approach" +
                $"The Job Folder is compressed using Zip approach" +
                $"The Photos Folder is compressed using Zip approach";

            Check.That(actualValue).Equals(expectedValue);
        }

        [Test]
        public void Should_compress_folder_to_the_right_type()
        {
            var folders = new List<ICompression>()
            {
                new ZipCompression("Documents"),
                new RarCompression("Job"),
                new TarCompression("Photos"),
            };

            var context = new CompressContext(folders);

            var actualValue = context.Compress();

            string expectedValue = $"The Documents Folder is compressed using Zip approach" +
                $"The Job Folder is compressed using Rar approach" +
                $"The Photos Folder is compressed using Tar approach";

            Check.That(actualValue).Equals(expectedValue);
        }
    }
}