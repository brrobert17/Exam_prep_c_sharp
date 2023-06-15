namespace LINQ;

public static class BookExtensionMethod
{
    public static List<Book> OrderByAuthor(this List<Book> books, string author)
    {
        return books.Where(b => b.Author == author).ToList();
    }
}