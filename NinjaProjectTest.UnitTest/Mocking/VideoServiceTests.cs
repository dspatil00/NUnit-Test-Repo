using System;
using Moq;
using NinjaProjectTest.Mocking;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NinjaProjectTest.UnitTest.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService(new FakeFileReader());
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            // var service = new VideoService();

            // Injecting via Method Parameter
            // var result = service.ReadVideoTitle(new FakeFileReader());

            // Injecting Via Property
            //service.fileReader = new FakeFileReader();


            //Injecting via Constructor Parameter
            //var service = new VideoService(new FakeFileReader());
            //var result = service.ReadVideoTitle();
            //Assert.That(result, Does.Contain("error").IgnoreCase);

           
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
           
           
            var result = _videoService.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);

        }
    }
}
