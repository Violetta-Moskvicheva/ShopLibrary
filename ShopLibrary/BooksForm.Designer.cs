namespace ShopLibrary
{
    partial class BooksForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            pnTop = new Panel();
            btLogout = new Button();
            flpBooks = new FlowLayoutPanel();
            pnTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.AliceBlue;
            pnTop.Controls.Add(btLogout);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1032, 55);
            pnTop.TabIndex = 0;
            // 
            // btLogout
            // 
            btLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btLogout.BackColor = Color.FromArgb(74, 111, 165);
            btLogout.FlatAppearance.BorderSize = 0;
            btLogout.FlatStyle = FlatStyle.Flat;
            btLogout.Location = new Point(935, 3);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(94, 29);
            btLogout.TabIndex = 1;
            btLogout.Text = "Выйти";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // flpBooks
            // 
            flpBooks.AutoScroll = true;
            flpBooks.BackColor = Color.White;
            flpBooks.Dock = DockStyle.Fill;
            flpBooks.FlowDirection = FlowDirection.TopDown;
            flpBooks.Location = new Point(0, 55);
            flpBooks.Name = "flpBooks";
            flpBooks.Size = new Size(1032, 519);
            flpBooks.TabIndex = 1;
            flpBooks.WrapContents = false;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 574);
            Controls.Add(flpBooks);
            Controls.Add(pnTop);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список книг";
            pnTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private FlowLayoutPanel flpBooks;
        private Button btLogout;
    }
}