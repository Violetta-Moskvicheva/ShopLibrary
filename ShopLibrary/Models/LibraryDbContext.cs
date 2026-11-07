using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShopLibrary.Models;

namespace ShopLibrary;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookLoan> BookLoans { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=library_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("avtors_pkey");

            entity.ToTable("authors");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('avtors_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("books_pkey");

            entity.ToTable("books");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annotation).HasColumnName("annotation");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.IdAuthor).HasColumnName("id_author");
            entity.Property(e => e.IdGenre).HasColumnName("id_genre");
            entity.Property(e => e.IdPublisher).HasColumnName("id_publisher");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Pages).HasColumnName("pages");
            entity.Property(e => e.PublicationYear).HasColumnName("publication_year");
            entity.Property(e => e.TotalQuantity).HasColumnName("total_quantity");

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAuthor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("books_id_author_fkey");

            entity.HasOne(d => d.Genre).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdGenre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("books_id_genre_fkey");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdPublisher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("books_id_publisher_fkey");
        });

        modelBuilder.Entity<BookLoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("book_loans_pkey");

            entity.ToTable("book_loans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualReturnDate).HasColumnName("actual_return_date");
            entity.Property(e => e.DateOfIssue).HasColumnName("date_of_issue");
            entity.Property(e => e.IdBookIsbn).HasColumnName("id_book_ISBN");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUserLibraryCard).HasColumnName("id_user_library_card");
            entity.Property(e => e.PlannedReturnDate).HasColumnName("planned_return_date");

            entity.HasOne(d => d.Book).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdBookIsbn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("book_loans_id_book_ISBN_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("book_loans_id_status_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdUserLibraryCard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("book_loans_id_user_library_card_fkey");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufactures_pkey");

            entity.ToTable("publishers");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('manufactures_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRoles).HasColumnName("id_roles");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.LibraryCard).HasColumnName("library_card");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_id_roles_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
