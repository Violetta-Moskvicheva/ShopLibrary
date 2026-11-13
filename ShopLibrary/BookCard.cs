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

            lbISBNAndName.Text = $"ISBN: {book.Isbn} | {book.Name}";
            lbAuthor.Text = $"Автор: {book.Author?.Name}";
            lbGenre.Text = $"Жанр: {book.Genre?.Name}";
            lbPublish.Text = $"Издательсва: {book.Publisher?.Name}";
            lbYearPublish.Text = $"Год издания: {book.PublicationYear}";
            lbPages.Text = $"Страниц: {book.Pages}";
            lbTotalCount.Text = $"Всего экземпляр: {book.TotalQuantity}";
            lbAvailable.Text = $"Доступно: {book.Available}";
            lbAnnotation.Text = $"Аннотация: {book.Annotation}";

            string currentStatusText = "В наличии";
            //просрочен
            bool isOverdue = false;
            //выдача книг
            if (book.BookLoans != null && book.BookLoans.Count > 0)
            {
                var lastLoan = book.BookLoans
                    //сортируем дату выдачи от самой новой к самой старой
                    .OrderByDescending(bl => bl.DateOfIssue)
                    //берём самую первую запись
                    .FirstOrDefault();
                
                if (lastLoan.Status != null)
                {
                    currentStatusText = lastLoan.Status.Name;
                    lbStatus.Text = $"Статус: {currentStatusText}";
                }

                if (lastLoan.ActualReturnDate == null && (DateTime.Now - lastLoan.DateOfIssue).TotalDays > 30)
                {
                    isOverdue = true;
                }
            }

            if (isOverdue)
            {
                BackColor = ColorTranslator.FromHtml("#D4EDDA");
            }
            else if (book.Available == 0)
            {
                BackColor = ColorTranslator.FromHtml("#FFCCCC");
                lbStatus.Text = "Статус: Нет в наличии";
            }
            else if (book.Available <= 2)
            {
                BackColor = ColorTranslator.FromHtml("#FFF3CD");
                lbStatus.Text = "Статус: Мало экземпляров";
            }
            else
            {
                BackColor = ColorTranslator.FromHtml("#F0F8FF");
            }
        }

        public Image LoadBookImage(string Image)
        {
            if (!String.IsNullOrEmpty(Image))
            {
                string rn = Path.GetFileNameWithoutExtension(Image).Trim();

                if (Resources.ResourceManager.GetObject(rn) is Image img)
                {
                    return img;
                }
            }

            return Resources.book_placeholder;
        }
    }
}
