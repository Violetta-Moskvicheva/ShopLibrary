using ShopLibrary.Models;
using ShopLibrary.Properties;
using System.Data;

namespace ShopLibrary
{
    public partial class BookCard : UserControl
    {
        public BookCard()
        {
            InitializeComponent();
        }

        public void LoadBookCard_Load(Book book)
        {
            pbBook.Image = LoadBookImage(book.Image);

            lbISBNAndName.Text = $"{book.Isbn} | {book.Name}";
            lbAuthor.Text = $"Автор: {book.Author?.Name}";
            lbGenre.Text = $"Жанр: {book.Genre?.Name}";
            lbPublish.Text = $"Издательсва: {book.Publisher?.Name}";
            lbYearPublish.Text = $"Год издания: {book.PublicationYear}";
            lbPages.Text = $"Страниц: {book.Pages}";
            lbTotalCount.Text = $"Всего экземпляр: {book.TotalQuantity}";
            lbAvailable.Text = $"Доступно: {book.Available}";
            lbAnnotation.Text = $"Аннотация: {book.Annotation}";

            int available = book.Available;
            string currentStatusText = null;
            bool isOverdue = false;

            if (book.BookLoans != null && book.BookLoans.Count > 0)
            {
                var lastLoan = book.BookLoans.OrderByDescending(bl => bl.DateOfIssue).FirstOrDefault();
                if (lastLoan != null)
                {
                    if (lastLoan.Status != null)
                    {
                        currentStatusText = lastLoan.Status.Name;
                    }

                    if (lastLoan.ActualReturnDate == null && (DateTime.Now - lastLoan.DateOfIssue).TotalDays > 30)
                    {
                        isOverdue = true;
                    }
                }
            }
            lbStatus.Text = $"Статус: {currentStatusText}";

            if (isOverdue)
            {
                this.BackColor = ColorTranslator.FromHtml("#D4EDDA");
            }
            else if (available == 0)
            {
                this.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                lbStatus.Text = $"Статус: Нет в наличии";
            }
            else if (available <= 2)
            {
                this.BackColor = ColorTranslator.FromHtml("#FFF3CD");
                lbStatus.Text = $"Статус: Мало Экземпляров";
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#F0F8FF");
            }
        }

        public Image LoadBookImage(string Image)
        {
            if (!String.IsNullOrEmpty(Image))
            {
                string rn = Path.GetFileNameWithoutExtension(Image).Trim();

                var rm = Properties.Resources.ResourceManager;

                if (rm.GetObject(rn) is Image img)
                {
                    return img;
                }
            }

            return Resources.book_placeholder;
        }
    }
}
