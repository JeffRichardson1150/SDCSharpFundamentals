using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPatters_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            // reference a different file:  hover over StreamingContent  Ctrl+.  the Select Add reference to 07_RepositoryPattern_Repository     it creates a "using _07_RepositoryPattern_Repository;" at top of the file
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        // Each DataRow will run a separate test
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            // AAA Paradigm
            // Arrange
            StreamingContent content = new StreamingContent();
            // Act
            // this is like a foreach loop...will run for how ever many datarows we have
            content.TypeOfGenre = typeOfGenre;
            // Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);

        }
    }
}
