namespace ShopLibrary
{
    partial class BookCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbBook = new PictureBox();
            lbISBNAndName = new Label();
            lbAvailable = new Label();
            lbAuthor = new Label();
            lbGenre = new Label();
            lbPublish = new Label();
            pnInfoBook = new Panel();
            lbStatus = new Label();
            lbAnnotation = new Label();
            lbTotalCount = new Label();
            lbPages = new Label();
            lbYearPublish = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBook).BeginInit();
            pnInfoBook.SuspendLayout();
            SuspendLayout();
            // 
            // pbBook
            // 
            pbBook.Dock = DockStyle.Left;
            pbBook.Location = new Point(10, 10);
            pbBook.Name = "pbBook";
            pbBook.Padding = new Padding(10);
            pbBook.Size = new Size(206, 225);
            pbBook.SizeMode = PictureBoxSizeMode.Zoom;
            pbBook.TabIndex = 0;
            pbBook.TabStop = false;
            // 
            // lbISBNAndName
            // 
            lbISBNAndName.AutoSize = true;
            lbISBNAndName.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbISBNAndName.Location = new Point(31, 14);
            lbISBNAndName.Name = "lbISBNAndName";
            lbISBNAndName.Size = new Size(159, 17);
            lbISBNAndName.TabIndex = 2;
            lbISBNAndName.Text = "ISBN | Наименование";
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Location = new Point(31, 154);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new Size(70, 17);
            lbAvailable.TabIndex = 3;
            lbAvailable.Text = "Доступно:";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(31, 34);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(50, 17);
            lbAuthor.TabIndex = 4;
            lbAuthor.Text = "Автор:";
            // 
            // lbGenre
            // 
            lbGenre.AutoSize = true;
            lbGenre.Location = new Point(31, 54);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(45, 17);
            lbGenre.TabIndex = 5;
            lbGenre.Text = "Жанр:";
            // 
            // lbPublish
            // 
            lbPublish.AutoSize = true;
            lbPublish.Location = new Point(31, 74);
            lbPublish.Name = "lbPublish";
            lbPublish.Size = new Size(99, 17);
            lbPublish.TabIndex = 6;
            lbPublish.Text = "Издательство:";
            // 
            // pnInfoBook
            // 
            pnInfoBook.Controls.Add(lbStatus);
            pnInfoBook.Controls.Add(lbAnnotation);
            pnInfoBook.Controls.Add(lbTotalCount);
            pnInfoBook.Controls.Add(lbPages);
            pnInfoBook.Controls.Add(lbYearPublish);
            pnInfoBook.Controls.Add(lbISBNAndName);
            pnInfoBook.Controls.Add(lbPublish);
            pnInfoBook.Controls.Add(lbAvailable);
            pnInfoBook.Controls.Add(lbGenre);
            pnInfoBook.Controls.Add(lbAuthor);
            pnInfoBook.Dock = DockStyle.Fill;
            pnInfoBook.Location = new Point(216, 10);
            pnInfoBook.Name = "pnInfoBook";
            pnInfoBook.Size = new Size(766, 225);
            pnInfoBook.TabIndex = 7;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(31, 194);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(56, 17);
            lbStatus.TabIndex = 11;
            lbStatus.Text = "Статус:";
            // 
            // lbAnnotation
            // 
            lbAnnotation.AutoSize = true;
            lbAnnotation.Location = new Point(31, 174);
            lbAnnotation.Name = "lbAnnotation";
            lbAnnotation.Size = new Size(75, 17);
            lbAnnotation.TabIndex = 10;
            lbAnnotation.Text = "Аннотация";
            // 
            // lbTotalCount
            // 
            lbTotalCount.AutoSize = true;
            lbTotalCount.Location = new Point(31, 134);
            lbTotalCount.Name = "lbTotalCount";
            lbTotalCount.Size = new Size(130, 17);
            lbTotalCount.TabIndex = 9;
            lbTotalCount.Text = "Всего экземпляров:";
            // 
            // lbPages
            // 
            lbPages.AutoSize = true;
            lbPages.Location = new Point(31, 114);
            lbPages.Name = "lbPages";
            lbPages.Size = new Size(63, 17);
            lbPages.TabIndex = 8;
            lbPages.Text = "Страниц:";
            // 
            // lbYearPublish
            // 
            lbYearPublish.AutoSize = true;
            lbYearPublish.Location = new Point(31, 94);
            lbYearPublish.Name = "lbYearPublish";
            lbYearPublish.Size = new Size(87, 17);
            lbYearPublish.TabIndex = 7;
            lbYearPublish.Text = "Год издания:";
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnInfoBook);
            Controls.Add(pbBook);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "BookCard";
            Padding = new Padding(10);
            Size = new Size(992, 245);
            ((System.ComponentModel.ISupportInitialize)pbBook).EndInit();
            pnInfoBook.ResumeLayout(false);
            pnInfoBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBook;
        private Label lbISBNAndName;
        private Label lbAvailable;
        private Label lbAuthor;
        private Label lbGenre;
        private Label lbPublish;
        private Panel pnInfoBook;
        private Label lbYearPublish;
        private Label lbTotalCount;
        private Label lbPages;
        private Label lbAnnotation;
        private Label lbStatus;
    }
}
