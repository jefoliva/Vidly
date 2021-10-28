namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCustomersMovies : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('John Doe',  0,  1,  '19940610 10:34:09 AM')
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('Carl Sagan',  0,  2,  '19940610 10:34:09 AM')
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('Richard Feynman',  0,  3,  '19940610 10:34:09 AM')
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('Jorge Luis Borges',  0,  1,  '19940610 10:34:09 AM')
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('Marcus Aurelius',  0,  2,  '19940610 10:34:09 AM')
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('Dennis Ritchie',  0,  3,  '19940610 10:34:09 AM')
            INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES ('Edger Dijkstra',  0,  1,  '19940610 10:34:09 AM')
            ");

            Sql(@"
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('2001: A Space Time Oddisey', 1, GETDATE(), '19720405 10:34:09 AM', 10, 10)
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('The Shawshank Redemption', 2, GETDATE(), '19940405 10:34:09 AM', 10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('The Godfather', 3, GETDATE(), '19720302 10:34:09 AM',10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('The Dark Knight', 4, GETDATE(), '20080102 10:34:09 AM',10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('12 Angry Men', 1, GETDATE(), '19570209 10:34:09 AM', 10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('The Lord of The Rings', 2, GETDATE(), '20030405 10:34:09 AM', 10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('Pulp Fiction', 3, GETDATE(), '19940405 10:34:09 AM', 10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('Schindlers List', 4, GETDATE(), '19930405 10:34:09 AM', 10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('Inception', 2, GETDATE(), '20100405 10:34:09 AM', 10, 10 )
                INSERT INTO [dbo].[Movies] ([Name] ,[GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES ('Fight Club', 2, GETDATE(), '19990405 10:34:09 AM', 10, 10)
            ");
        }
    
        
        public override void Down()
        {
        }
    }
}
