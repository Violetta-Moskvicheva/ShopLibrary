namespace ShopLibrary
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool exiteProgram = false;

            while (!exiteProgram)
            {
                using(var formBooks = new BooksForm())
                {
                    if(formBooks.ShowDialog() == DialogResult.OK)
                    {
                        continue;
                    }
                    else
                    {
                        exiteProgram = true;
                    }
                }
            }
        }
    }
}