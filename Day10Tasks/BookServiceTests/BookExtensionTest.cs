using BookService;
using NUnit.Framework;

namespace BookServiceTests
{
    public class BookExtensionTest
    {
        [Test]
        public void ExtensionTest()
        {
            Book book = new Book("978-1-10-739989-2", "Losna", "Black lake", "RB.C", 2008, 238, 621);

            string expected = "978-1-10-739989-2, 2008";
            string actual = book.ToCustomString();

            Assert.AreEqual(expected, actual);
        }
    }
}