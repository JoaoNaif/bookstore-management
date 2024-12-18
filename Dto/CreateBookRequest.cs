using LibraryChalenger.Entities;

namespace LibraryChalenger.Dto;

public class CreateBookRequest
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Gender Gender { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}