namespace BookService
{
    public static class BookExtension
    {
        /// <summary>
        /// Extension method for Book
        /// </summary>
        /// <returns>String representation</returns>
        public static string ToCustomString(this Book book)
        {
            return string.Format($"{book.ISBN}, {book.Year}");
        }
    }
}
