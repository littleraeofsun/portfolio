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
            Project firstProject = Context.Projects.Add(new Project() { Title = "Test Project", Customer = "Fake Customer", Year = 2008, Tools = "Photoshop, Illustrator, Dreamweaver, JavaScript, jQuery", Description = "This is only a test. I like turles.", Url = "http://localhost", Categories = "Branding,Website" });
            Project secondProject = Context.Projects.Add(new Project() { Title = "Test Project 2", Customer = "Fake Customer 2", Year = 2009, Tools = "Visual Studio, WPF, .NET C#", Description = "This is only a test 2. I like 2 turles.", Url = "http://localhost:2", Categories = "Desktop,Content" });
            Project thirdProject = Context.Projects.Add(new Project() { Title = "Test Project 3", Customer = "Fake Customer 3", Year = 2010, Tools = "Visual Studio, WinForms, .NET C#, WebForms, Illustrator", Description = "This is only a test 3. I like 3 turles.", Url = "http://localhost:3", Categories = "Desktop,Website,Branding" });
            Project fourthProject = Context.Projects.Add(new Project() { Title = "Test Project 4", Customer = "Fake Customer 4", Year = 2011, Tools = "Dreamweaver, PHP, JavaScript, jQuery, AJAX", Description = "This is only a test 4. I like 4 turles.", Url = "http://localhost:4", Categories = "Website" });
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
            
            //legit stuff
            Project injuryForm = Context.Projects.Add(new Project()
            {
                Title = "Tulsa Injury Reporting and Analysis Application",
                Customer = "City of Tulsa",
                Year = 2013,
                Tools = "Visual Studio, ASP.NET, C#, jQuery, KnockoutJS, Photoshop, SketchFlow, MSSQL",
                Description = @"As a part of the Mayor's initiative to create a culture of safety and decrease workplace injuries, the Safety group requested a project for an injury reporting and analysis system. They needed an application that would ask employees and their supervisors questions about their workplace injuries to help identify and prevent unsafe work conditions. They presented me with two paper forms, the 905A Report and the 905B Investigation, and asked me to build them an application.
I started putting together some designs for the system in Microsoft SketchFlow to demonstrate a potential workflow and set of features for the forms. I also ran by form design by the City graphic designer to ensure it met branding and design integrity standards.
The project took about two months from planning to launch, and is still being used today. The Safety group and Human Resources reported a nearly 50% drop in reported injuries and costs in the years following the launch of the form. 
My favorite feature of this project was the virtualization of the body diagram from the paper forms. I designed a ViewModel map of injury points that users could interact with to show where exactly on their bodies they were injured. The points were stored in the database with coordinates for subjective analysis on the forms and print-outs and with body region categorization for objective analysis of where injuries occur most on the body.
Since the launch, a Fire Department-specific portion of the form has been added so that the Fire Chief can better assess hazards for firefighters and staff. A similar functionality is planned for the Police Department as well. I will also be implementing a registration process for department heads to request receiving a copy of forms submitted for employees in their department.
",
                Categories = "Website"
            });
            Context.Media.Add(new Image()
            {
                Project = injuryForm,
                Name = "Login Page",
                Description = "This is the login portal for the Injury Reporting application. It authenticates users against Active Directory. This feature was added for departments that use kiosk computers.",
                UrlSmall = "https://c2.staticflickr.com/4/3804/32897106453_cae5e7a177_z.jpg",
                UrlMedium = "https://c2.staticflickr.com/4/3804/32897106453_cae5e7a177_b.jpg",
                UrlLarge = "https://c2.staticflickr.com/4/3804/32897106453_21acda5dab_o.png"
            });
            Context.Media.Add(new Image()
            {
                Project = injuryForm,
                Name = "Home Page",
                Description = "This is the home page for the Injury Reporting application. Users can see which 905A and B forms they have started, as well as other forms they have viewed recently. The lists feature links to the forms, status indicators, summary information, and 'Share' email links.",
                UrlSmall = "https://c2.staticflickr.com/4/3700/32897106523_b495ac6c9b_z.jpg",
                UrlMedium = "https://c2.staticflickr.com/4/3700/32897106523_b495ac6c9b_b.jpg",
                UrlLarge = "https://c2.staticflickr.com/4/3700/32897106523_ec357916d2_o.png"
            });
            Context.Media.Add(new Image()
            {
                Project = injuryForm,
                Name = "Search Page",
                Description = "This is the search feature for the Injury Reporting application. It allows users to query submitted forms using a handful of parameters.",
                UrlSmall = "https://c1.staticflickr.com/3/2877/33710677235_923b5529d6_z.jpg",
                UrlMedium = "https://c1.staticflickr.com/3/2877/33710677235_923b5529d6_b.jpg",
                UrlLarge = "https://c1.staticflickr.com/3/2877/33710677235_e44942e784_o.png"
            });
            Context.Media.Add(new Image()
            {
                Project = injuryForm,
                Name = "Help Page",
                Description = "This is the helpful tips and questions page for the Injury Reporting applucation. It features explanations of icons to help users filling the form out for the first time. Additionally, there is a small feedback form for users to ask questions or report issues. This form captures browser details along with the message.",
                UrlSmall = "https://c1.staticflickr.com/3/2818/32897106513_bb98c4974c_z.jpg",
                UrlMedium = "https://c1.staticflickr.com/3/2818/32897106513_bb98c4974c_b.jpg",
                UrlLarge = "https://c1.staticflickr.com/3/2818/32897106513_a936340d87_o.png"
            });


            Context.SaveChanges();
        }
    }
}