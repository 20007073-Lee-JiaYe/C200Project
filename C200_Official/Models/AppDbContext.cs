using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace C200_Official.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleComment> ArticleComments { get; set; }
        public virtual DbSet<ArticleRating> ArticleRatings { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionRating> QuestionRatings { get; set; }
        public virtual DbSet<Supplement> Supplements { get; set; }
        public virtual DbSet<SupplementType> SupplementTypes { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<VideoComment> VideoComments { get; set; }
        public virtual DbSet<VideoRating> VideoRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.AnsweredDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__MemberID__282DF8C2");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__Question__29221CFB");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("Article");

                entity.Property(e => e.AiFlag)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ai_flag");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedOn).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Article__Categor__160F4887");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Article__MemberI__151B244E");
            });

            modelBuilder.Entity<ArticleComment>(entity =>
            {
                entity.ToTable("Article_Comment");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.DatePublished).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleComments)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Article_C__Artic__18EBB532");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ArticleComments)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Article_C__Membe__19DFD96B");
            });

            modelBuilder.Entity<ArticleRating>(entity =>
            {
                entity.ToTable("Article_Rating");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleRatings)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Article_R__Artic__1CBC4616");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ArticleRatings)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__Article_R__Membe__1DB06A4F");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Programme>(entity =>
            {
                entity.ToTable("Programme");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PicFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Programmes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Programme__Categ__06CD04F7");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__Catego__2180FB33");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__Member__208CD6FA");
            });

            modelBuilder.Entity<QuestionRating>(entity =>
            {
                entity.ToTable("Question_Rating");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.QuestionRatings)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__Question___Membe__25518C17");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionRatings)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question___Quest__245D67DE");
            });

            modelBuilder.Entity<Supplement>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuggestedUse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Suggested Use");

                entity.Property(e => e.SupplementTypeId).HasColumnName("SupplementTypeID");

                entity.Property(e => e.Warnings)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Supplements)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplemen__Membe__2DE6D218");

                entity.HasOne(d => d.SupplementType)
                    .WithMany(p => p.Supplements)
                    .HasForeignKey(d => d.SupplementTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplemen__Suppl__2EDAF651");
            });

            modelBuilder.Entity<SupplementType>(entity =>
            {
                entity.ToTable("Supplement_Type");

                entity.Property(e => e.Benefits)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("Video");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DatePublished).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedOn).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Video__CategoryI__0A9D95DB");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Video__MemberID__09A971A2");
            });

            modelBuilder.Entity<VideoComment>(entity =>
            {
                entity.ToTable("Video_Comment");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.VideoComments)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Video_Com__Membe__0D7A0286");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoComments)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Video_Com__Video__0E6E26BF");
            });

            modelBuilder.Entity<VideoRating>(entity =>
            {
                entity.ToTable("Video_Rating");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.VideoRatings)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__Video_Rat__Membe__114A936A");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoRatings)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Video_Rat__Video__123EB7A3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
