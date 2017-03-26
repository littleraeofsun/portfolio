using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rae.Website.Models
{
    public class PortfolioDataContextInitializer : DropCreateDatabaseAlways<PortfolioContext>
    {
        protected override void Seed(PortfolioContext Context)
        {
            Project firstProject = Context.Projects.Add(new Project() { Title = "Test Project", Customer = "Fake Customer", Description = "This is only a test. I like turles.", Url = "http://localhost", Categories = "Branding,Website" });
            Project secondProject = Context.Projects.Add(new Project() { Title = "Test Project 2", Customer = "Fake Customer 2", Description = "This is only a test 2. I like 2 turles.", Url = "http://localhost:2", Categories = "Desktop,Content" });
            Project thirdProject = Context.Projects.Add(new Project() { Title = "Test Project 3", Customer = "Fake Customer 3", Description = "This is only a test 3. I like 3 turles.", Url = "http://localhost:3", Categories = "Desktop,Website,Branding" });
            Project fourthProject = Context.Projects.Add(new Project() { Title = "Test Project 4", Customer = "Fake Customer 4", Description = "This is only a test 4. I like 4 turles.", Url = "http://localhost:4", Categories = "Website" });
            Context.Media.Add(new Image() { Project = firstProject, Name = "One", Description = "This is the first first image.", UrlLarge = "https://c1.staticflickr.com/9/8367/8446773934_7990072aea_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8367/8446773934_7990072aea_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8367/8446773934_003d59622d_n.jpg" });
            Context.Media.Add(new Image() { Project = firstProject, Name = "Two", Description = "This is the second first image.", UrlLarge = "https://c1.staticflickr.com/9/8051/8446776190_b056476cd9_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8051/8446776190_b056476cd9_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8051/8446776190_0e6d4558b0_n.jpg" });
            Context.Media.Add(new Image() { Project = secondProject, Name = "Three", Description = "This is the first second image.", UrlLarge = "https://c1.staticflickr.com/9/8074/8445688215_645a381644_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8074/8445688215_645a381644_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8074/8445688215_5c7b7b9ee9_n.jpg" });
            Context.Media.Add(new Image() { Project = secondProject, Name = "Four", Description = "This is the second second image.", UrlLarge = "https://c1.staticflickr.com/9/8372/8446775888_fffdcd8851_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8372/8446775888_fffdcd8851_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8372/8446775888_6c869c6be3_n.jpg" });
            Context.Media.Add(new Audio() { Project = firstProject, Name = "Audiooo", Description = "Listen to this!", AudioUrl = "Media/menu-music.mp3" });
            Context.Media.Add(new Video() { Project = secondProject, Name = "Videooo", Description = "Check this out!", VideoUrl = "https://www.youtube.com/embed/bYFBGUKxdpU" });

            Album firstAlbum = Context.Albums.Add(new Album() { Name = "First Album", Description = "These are my first set of photos." });
            Album secondAlbum = Context.Albums.Add(new Album() { Name = "Second Album", Description = "These are my second set of photos." });
            Context.Media.Add(new Image() { Album = firstAlbum, Name = "Five", Description = "This is the first third image.", UrlLarge = "https://c1.staticflickr.com/9/8367/8446773934_7990072aea_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8367/8446773934_7990072aea_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8367/8446773934_003d59622d_n.jpg" });
            Context.Media.Add(new Image() { Album = firstAlbum, Name = "Six", Description = "This is the second third image.", UrlLarge = "https://c1.staticflickr.com/9/8051/8446776190_b056476cd9_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8051/8446776190_b056476cd9_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8051/8446776190_0e6d4558b0_n.jpg" });
            Context.Media.Add(new Image() { Album = secondAlbum, Name = "Seven", Description = "This is the first fourth image.", UrlLarge = "https://c1.staticflickr.com/9/8074/8445688215_645a381644_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8074/8445688215_645a381644_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8074/8445688215_5c7b7b9ee9_n.jpg" });
            Context.Media.Add(new Image() { Album = secondAlbum, Name = "Eight", Description = "This is the second fourth image.", UrlLarge = "https://c1.staticflickr.com/9/8372/8446775888_fffdcd8851_o.jpg", UrlMedium = "https://c1.staticflickr.com/9/8372/8446775888_fffdcd8851_o.jpg", UrlSmall = "https://c1.staticflickr.com/9/8372/8446775888_6c869c6be3_n.jpg" });
            Context.SaveChanges();
        }
    }
}