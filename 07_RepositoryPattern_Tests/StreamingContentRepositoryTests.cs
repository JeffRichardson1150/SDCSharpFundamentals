using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            List<string> stringList = new List<string>();
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            // Act
            bool addResult = repo.AddContentToDirectory(content);

            // Assert
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetContents_ShouldReturnCorrectCollection()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(content);

            // Act
            List<StreamingContent> contents = repo.GetContents();
            bool directoryHasContent = contents.Contains(content);

            // Assert
            Assert.IsTrue(directoryHasContent);
        }


        // test initialize - executes before each test (like the state thing)
        private StreamingContent _content;
        private StreamingContentRepository _repo;
        [TestInitialize]
        // run below for each test method
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Mr. Right", "Hitman falls in love", MaturityRating.R, 100, GenreType.Action);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            // Arrange is above
            // Act - think of "what gets returned from the method I'm calling?"
            StreamingContent searchResult = _repo.GetContentByTitle("Mr. Right");
            // Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent newContent = new StreamingContent("Mr. Right", "Hitman falls in love, and gains a new partner in crime", MaturityRating.R, 100, GenreType.Romance);
            // Act
            bool updatedResult = _repo.UpdateExistingContent("Mr. Right", newContent);
            // Assert
            // Assert.IsTrue(updatedResult);
            Assert.AreEqual(GenreType.Romance, _content.TypeOfGenre);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent content = _repo.GetContentByTitle("Mr. Right");
            // Act
            bool removeResult = _repo.DeleteExistingContent(content);
            // Assert
            Assert.IsTrue(removeResult);
        }
    }

}
