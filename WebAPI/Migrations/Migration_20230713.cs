using FluentMigrator;

namespace WebAPI.Migrations
{
    [Migration(202307130000, "Add base tables")]
    public class Migration_20230713 : Migration
    {
        public override void Down()
        {
            Delete.Table("Movie");
            Delete.Table("Genre");
            Delete.Table("MovieGenre");
            Delete.Table("Actor");
            Delete.Table("MovieActor");
        }

        public override void Up()
        {
            Create.Table("Movie")
                .WithColumn("MovieId").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Year").AsInt16().NotNullable();

            Create.Table("Genre")
                .WithColumn("GenreId").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable();

            Create.Table("MovieGenre")
            .WithColumn("MovieId").AsInt32().NotNullable()
            .WithColumn("GenreId").AsInt32().NotNullable();
            Create.PrimaryKey("Movie-Genre-PK")
                .OnTable("MovieGenre")
                .Columns("MovieId", "GenreId");
            Create.ForeignKey()
                .FromTable("MovieGenre").ForeignColumn("MovieId")
                .ToTable("Movie").PrimaryColumn("MovieId");
            Create.ForeignKey()
                .FromTable("MovieGenre").ForeignColumn("GenreId")
                .ToTable("Genre").PrimaryColumn("GenreId");

            Create.Table("Actor")
                .WithColumn("ActorId").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable();

            Create.Table("MovieActor")
                .WithColumn("MovieId").AsInt32().NotNullable()
                .WithColumn("ActorId").AsInt32().NotNullable();
            Create.PrimaryKey("Movie-Actor-PK")
                .OnTable("MovieActor")
                .Columns("MovieId", "ActorId");
            Create.ForeignKey()
                .FromTable("MovieActor").ForeignColumn("MovieId")
                .ToTable("Movie").PrimaryColumn("MovieId");
            Create.ForeignKey()
                .FromTable("MovieActor").ForeignColumn("ActorId")
                .ToTable("Actor").PrimaryColumn("ActorId");
        }
    }
}
