namespace ShopLibrary.Models;

public partial class User
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LibraryCard { get; set; } = null!;

    public string Login { get; set; } = null!;

    public int IdRoles { get; set; }

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Role Role { get; set; } = null!;
}
