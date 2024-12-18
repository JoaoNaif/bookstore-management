namespace LibraryChalenger.Entities;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public Gender Gender { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}