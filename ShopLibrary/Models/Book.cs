namespace ShopLibrary.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Isbn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IdAuthor { get; set; }

    public int IdGenre { get; set; }

    public int IdPublisher { get; set; }

    public int PublicationYear { get; set; }

    public int Pages { get; set; }

    public int TotalQuantity { get; set; }

    public int Available { get; set; }

    public string Annotation { get; set; } = null!;

    public string Image { get; set; } = null!;

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Author Author { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual Publisher Publisher { get; set; } = null!;
}
