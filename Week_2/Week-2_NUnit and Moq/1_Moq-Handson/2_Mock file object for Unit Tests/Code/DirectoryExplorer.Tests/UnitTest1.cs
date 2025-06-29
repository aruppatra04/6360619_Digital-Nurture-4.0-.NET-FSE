using NUnit.Framework;
using Moq;
using MagicFilesLib;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _mock;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Setup()
        {
            _mock = new Mock<IDirectoryExplorer>();
            _mock.Setup(m => m.GetFiles(It.IsAny<string>()))
                 .Returns(new List<string> { _file1, _file2 });
        }

        [Test]
        public void GetFiles_ReturnsFiles()
        {
            var files = _mock.Object.GetFiles("dummyPath");

            TestContext.WriteLine("Files returned: " + string.Join(", ", files));

            Assert.That(files, Is.Not.Null);
            Assert.That(files.Count, Is.EqualTo(2));
            Assert.That(files, Does.Contain(_file1));
        }
    }
}
