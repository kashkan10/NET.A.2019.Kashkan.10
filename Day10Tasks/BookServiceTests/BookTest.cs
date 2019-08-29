using BookService;
using NUnit.Framework;

namespace BookServiceTests
{
    public class BookTest
    {
        private Book book = new Book("978-1-10-739989-2", "Losna", "Black lake", "RB.C", 2008, 238, 621);

        [Test]
        public void A_FormatTest()
        {
            string expected = "Losna, Black lake";
            string actual = book.ToString("A");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void B_FormatTest()
        {
            string expected = "Losna, Black lake, RB.C, 2008";
            string actual = book.ToString("B");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void C_FormatTest()
        {
            string expected = "ISBN 13: 978-1-10-739989-2, Losna, Black lake, RB.C, 2008, P. 238";
            string actual = book.ToString("C");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void D_FormatTest()
        {
            string expected = "ISBN 13: 978-1-10-739989-2, Losna, Black lake, RB.C, 2008, P. 238, 621$";
            string actual = book.ToString("D");

            Assert.AreEqual(expected, actual);
        }
    }
}