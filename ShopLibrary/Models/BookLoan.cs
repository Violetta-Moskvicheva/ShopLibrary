namespace ShopLibrary.Models;

public partial class BookLoan
{
    public int Id { get; set; }

    public int IdUserLibraryCard { get; set; }

    public int IdBookIsbn { get; set; }

    public DateTime DateOfIssue { get; set; }

    public DateTime PlannedReturnDate { get; set; }

    public DateTime? ActualReturnDate { get; set; }

    public int IdStatus { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
