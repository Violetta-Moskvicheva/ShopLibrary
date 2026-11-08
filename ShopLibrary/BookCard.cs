using ShopLibrary.Models;
using ShopLibrary.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            lbAuthor.Text = $"Автор: {book.Author}";
            lbGenre.Text = $"Жанр: {book.Genre}";
            lbPublish.Text = $"Издательсва: {book.Publisher}";
            lbYearPublish.Text = $"Год издания: {book.PublicationYear}";
            lbPages.Text = $"Страниц: {book.Pages}";
            lbTotalCount.Text = $"Всего экземпляр: {book.TotalQuantity}";
            lbAvailable.Text = $"Доступно: {book.Available}";
            lbAnnotation.Text = $"Аннотация: {book.Annotation}";
            

            int available = 0;
            if (book.Available != null)
            {
                available = book.Available;
                if (available == 0)
                {
                    lbStatus.Text = $"Статус: Нет в наличии";
                    this.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                }
                else if (available <= 2)
                {
                    lbStatus.Text = $"Статус: Мало экземпляров";
                    this.BackColor = ColorTranslator.FromHtml("#FFF3CD");
                }
            }
        }

        public Image LoadBookImage(string Image)
        {
            if (!String.IsNullOrEmpty(Image))
            {
                string rn = Path.GetFileNameWithoutExtension(Image).Trim();

                var rm = Properties.Resources.ResourceManager;
                var img = rm.GetObject(rn) as Image;

                return img;
            }

            return Resources.book_placeholder;
        }
    }
}
