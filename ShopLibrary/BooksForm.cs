using Microsoft.EntityFrameworkCore;

namespace ShopLibrary
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            LoadBookForm();

        }

        private void LoadBookForm()
        {
            try
            {
                using (var db = new LibraryDbContext())
                {
                    var books = db.Books
                        .Include(b => b.Author)
                        .Include(b => b.Genre)
                        .Include(b => b.Publisher)
                        .Include(b => b.BookLoans)
                            .ThenInclude(bl => bl.Status)
                        .ToList();

                    flpBooks.SuspendLayout();
                    flpBooks.Controls.Clear();

                    foreach (var book in books)
                    {
                        BookCard card = new BookCard();
                        card.LoadBookCard_Load(book);
                        flpBooks.Controls.Add(card);
                    }
                    flpBooks.ResumeLayout();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Данная функция пока не доступна", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}