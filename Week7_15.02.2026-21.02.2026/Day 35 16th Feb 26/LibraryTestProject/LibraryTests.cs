using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using LibraryManagementSystem;

namespace LibraryTestProject
{
    [TestFixture]
    internal class LibraryTests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
            library.AddBook("C# Basics", 2);
        }

        [Test]
        public void AddBook_NewBook_IncreasesCount()
        {
            // Arrange
            string title = "ASP.NET Core";
            int quantity = 3;

            // Act
            library.AddBook(title, quantity);

            // Assert
            Assert.That(library.GetBookCount(title), Is.EqualTo(3));
        }

        [Test]
        public void BorrowBook_ExistingBook_DecreasesCount()
        {
            // Arrange
            string title = "C# Basics";

            // Act
            library.BorrowBook(title);

            // Assert
            Assert.That(library.GetBookCount(title), Is.EqualTo(1));
        }

        [Test]
        public void BorrowBook_NotAvailable_ThrowsException()
        {
            // Arrange
            string title = "Java";

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => library.BorrowBook(title));
        }

    }
}
