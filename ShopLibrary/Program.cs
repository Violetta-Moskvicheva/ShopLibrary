namespace ShopLibrary
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using(var formBooks = new BooksForm())
            {
                formBooks.ShowDialog();
            }
        }
    }
}