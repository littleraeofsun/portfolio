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
            try
            {
                #region Project: Ashcorp
                Project ashcorp = Context.Projects.Add(new Project()
                {
                    Title = "Ashcorp",
                    Customer = "Brian Smith",
                    Url = "http://www.ashcorptechnologies.com",
                    Year = 2017,
                    Categories = "Website, Branding",
                    Tools = "Dreamweaver, PHP, Bootstrap, Photoshop, Illustrator",
                    Description = @"I was introduced to Brian Smith through an investment opportunity. Ashcorp, his company, was still very young, and Brian needed a lot of help with branding and media. Initially I gave him some feedback on his existing website and assisted him with a few site management tasks.
In exchange for stock in his growing company, I put together a strategy for designing his new site so that it could be developed quickly and would present his products in a meaningful way. During the planning process I realized Brian needed a lot in the way of graphics, so I put together a variety of logo ideas for his various products, and we worked together to produce the logos currently on the site.
Because he had little interest in personally maintaining his site, I determined the best solution for Brian would be to make a series of static PHP pages that I could easily and quickly adjust to fit his needs. I built the pages with bootstrap and bootstrap plug-ins so his site would be mobile-friendly.
Note: this site is still a work in progress.",
                    IsFeatured = true,
                    FeaturedImageUrlSmall = "/images/featured/ashcorp-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/ashcorp-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/ashcorp-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = ashcorp,
                    Name = "ashcorp-site_WM",
                    Description = "The Home page features the Ashcorp logo and introduction to Front Row Ticket",
                    UrlSmall = "https://farm3.staticflickr.com/2885/33833726451_e236828af8_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2885/33833726451_e236828af8_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2885/33833726451_54132d9029_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = ashcorp,
                    Name = "ashcorp-site-slides-selfzone_WM",
                    Description = "The slider feature presents the primary focuses of Ashcorp, including SelfZone",
                    UrlSmall = "https://farm3.staticflickr.com/2867/33922620736_08aedc2e70_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2867/33922620736_08aedc2e70_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2867/33922620736_0aa1132cf3_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = ashcorp,
                    Name = "ashcorp-site-slides-floatinginternet_WM",
                    Description = "The home page slider also demonstrates the concept art for Floating Internet",
                    UrlSmall = "https://farm4.staticflickr.com/3930/33120298104_0de7f321f3_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3930/33120298104_0de7f321f3_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3930/33120298104_25e4eecd0e_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = ashcorp,
                    Name = "ashcorp-site-frontrow_WM",
                    Description = "The Front Row Ticket feature page",
                    UrlSmall = "https://farm3.staticflickr.com/2814/33964000675_466326d8f2_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2814/33964000675_466326d8f2_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2814/33964000675_5e3a74a79e_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = ashcorp,
                    Name = "ashcorp-selfzone-logoevolution_WM",
                    Description = "Logo evolution for SelfZone, the first project I worked on for Ashcorp",
                    UrlSmall = "https://farm3.staticflickr.com/2934/33922620446_5d15b175d9_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2934/33922620446_5d15b175d9_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2934/33922620446_be2b5ec32b_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = ashcorp,
                    Name = "ashcorp-frontrow-logoevolution_WM",
                    Description = "Logo evolution for Front Row Ticket",
                    UrlSmall = "https://farm3.staticflickr.com/2815/33120298154_587d555c17_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2815/33120298154_587d555c17_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2815/33120298154_f3f3fc46ea_o.png",
                });
                #endregion
                #region Project: Tulsa City Website
                Project cityoftulsaorg = Context.Projects.Add(new Project()
                {
                    Title = "City of Tulsa Website",
                    Customer = "City of Tulsa",
                    Url = "http://www.cityoftulsa.org",
                    Year = 2017,
                    Tools = "Visual Studio, Umbraco 7, MVC, C#, Bootstrap, jQuery, KnockoutJS, Photoshop, MSSQL, Git",
                    Description = @"In 2013 the Tulsa IT and Communications departments decided that the city website needed updating. The old site, built back around 2005, ran on Umbraco 4 CMS and was several years behind on patches. The layout only allowed for 580px of content on pages, and the extensibility options were limited and rigid due to a lack of training on the CMS.
I volunteered to work on the redesign of the site and began researching responsive web design methods and CMS options between my normal tasks. Ultimately I chose to go with Bootstrap and Umbraco 7. Because I had never used either of these frameworks before, I put together a series of proof of concept projects to learn the ropes and demonstrate the capabilities to the rest of my team.
With Umbraco's online tutorial series and Level 2 certification course, I was able to build a development site based on the Photoshop mock-ups from our Communications department. I taught the rest of our development team how to migrate our old WebForms applications to MVC macros in Umbraco and how to use Git to save and manage their changes.
A little under a year after I completed my Level 2 training, we launched the new City of Tulsa website with over 10,000 pages of reorganized content, nearly 50 forms and applications transitioned from .NET 2.0 to 4.5 (and added to change control), and nearly 20 brand new solutions custom built for various departments and citizens.
The core focus of the new site was to make things easier to find. I leveraged Umbraco's Examine search engine to replace our old Google site search, and Communications chose a theme centered around a prominent search bar. Acceptance has been overwhelmingly positive, and many groups (including the new mayor) have already expressed interest in having new features and applications built into or alongside the new site.",
                    Categories = "Website, Training",
                    IsFeatured = true,
                    FeaturedImageUrlSmall = "/images/featured/cot-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/cot-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/cot-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-home_WM",
                    Description = "The new cityoftulsa.org website with responsive and search-centered design",
                    UrlSmall = "https://farm3.staticflickr.com/2835/33833739761_68522156bb_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2835/33833739761_68522156bb_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2835/33833739761_29310c53da_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-home-foot_WM",
                    Description = "Home page features include responsive video, image gallery, and calendar",
                    UrlSmall = "https://farm3.staticflickr.com/2831/33806147732_fb228f3b4d_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2831/33806147732_fb228f3b4d_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2831/33806147732_2f48fd1f71_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-umbraco_WM",
                    Description = "The website uses the Umbraco 7 CMS",
                    UrlSmall = "https://farm3.staticflickr.com/2836/33833739961_5743f10d3d_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2836/33833739961_5743f10d3d_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2836/33833739961_af6b44ce96_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-umbraco-templates_WM",
                    Description = "Nested templates allow for flexibility; document type properties enable code-free content management",
                    UrlSmall = "https://farm3.staticflickr.com/2810/33964012475_fd6dd2211c_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2810/33964012475_fd6dd2211c_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2810/33964012475_1858777776_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-employmentpage_WM",
                    Description = "Site pages include the search bar, navigation, and contextual social media share links",
                    UrlSmall = "https://farm3.staticflickr.com/2911/33806147832_53e8a07108_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2911/33806147832_53e8a07108_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2911/33806147832_08ee18ba05_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-availablepositions_WM",
                    Description = "The HR office can control available positions which are displayed here and on the job application",
                    UrlSmall = "https://farm3.staticflickr.com/2859/33964012445_4ce2f9ac38_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2859/33964012445_4ce2f9ac38_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2859/33964012445_2f765d6e66_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-specialevents_WM",
                    Description = "Communications manages special event request documents and feedback comments in one place",
                    UrlSmall = "https://farm3.staticflickr.com/2908/33806148252_e678e68d20_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2908/33806148252_e678e68d20_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2908/33806148252_99dd002492_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-bids_WM",
                    Description = "The Purchasing office lists bid proposals the automatically switch to the results page after their deadlines",
                    UrlSmall = "https://farm4.staticflickr.com/3951/33964012385_ce4765839a_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3951/33964012385_ce4765839a_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3951/33964012385_7024845bed_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-jobsbulletin_WM",
                    Description = "I created a custom page template for HR to distribute regular job position bulletins",
                    UrlSmall = "https://farm4.staticflickr.com/3947/33833740231_7440355b20_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3947/33833740231_7440355b20_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3947/33833740231_3ae5bc7f60_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = cityoftulsaorg,
                    Name = "cot-umbraco-jobsbulletin_WM",
                    Description = "Job Bulletin templates are similarly flexible to the main site and also feature customizable properties",
                    UrlSmall = "https://farm3.staticflickr.com/2889/33964012495_9a3edc0ba2_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2889/33964012495_9a3edc0ba2_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2889/33964012495_04563ef0eb_o.png",
                });
                #endregion
                #region Project: Tulsa Job Application
                Project tulsajobapp = Context.Projects.Add(new Project()
                {
                    Title = "Tulsa Job Application",
                    Customer = "City of Tulsa",
                    Url = "https://www.cityoftulsa.org/government/departments/human-resources/employment/application-form/",
                    Year = 2017,
                    Tools = "Visual Studio, Umbraco 7, MVC, C#, Bootstrap, jQuery, KnockoutJS, MSSQL",
                    Description = @"The first project I worked on at the City of Tulsa was converting the PDF job application into an online form on the public-facing website. The Human Resources department had a legacy system they used for storing and retrieving applications, and my solution needed to feed into that.
I explored a couple different approaches and wound up going with a hybrid KnockoutJS WebForm, an AJAX broker ASPX page, and Web Services behind the firewall which interacted with an MSSQL database. Upon submission, the application data was transformed into plain text that could be entered into the HR legacy system. Over the next two years we added a version of the application for internal positions as well as for Fire Department recruitment.
When it came time to redesign the City of Tulsa website, I took the opportunity to rebuild the job applications. I redesigned the front-end using Bootstrap and consolidated the logic into a single code base. I also experimented with inheritance of my Knockout viewmodels to further eliminate duplicate code. Instead of a broker page, the new applications use a UmbracoWebAPI services to ferry requests behind the firewall.",
                    Categories = "Website",
                    IsFeatured = true,
                    FeaturedImageUrlSmall = "/images/featured/job-app-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/job-app-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/job-app-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp_WM",
                    Description = "The new City of Tulsa external job application",
                    UrlSmall = "https://farm4.staticflickr.com/3940/33806169712_fe0d34456f_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3940/33806169712_fe0d34456f_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3940/33806169712_61712ce84e_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-progress-toast_WM",
                    Description = "Form progress is saved automatically 10 seconds after changes are made",
                    UrlSmall = "https://farm3.staticflickr.com/2866/33806169802_714694c61c_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2866/33806169802_714694c61c_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2866/33806169802_1024584916_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-positions_WM",
                    Description = "Available positions are maintained by HR in Umbraco and pulled into the application via Controller",
                    UrlSmall = "https://farm3.staticflickr.com/2908/33806169852_b8556df878_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2908/33806169852_b8556df878_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2908/33806169852_8615f9ecaf_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-criminal_WM",
                    Description = "With the Ban the Box initiative, only certain secure positions trigger the criminal background questions",
                    UrlSmall = "https://farm3.staticflickr.com/2896/33150697183_98a7f2af1b_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2896/33150697183_98a7f2af1b_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2896/33150697183_2faa6420de_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-education_WM",
                    Description = "The application provides spaces for applicants to list comprehensive education history",
                    UrlSmall = "https://farm3.staticflickr.com/2908/33150697143_54c127554a_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2908/33150697143_54c127554a_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2908/33150697143_75df0b1ac9_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-error_WM",
                    Description = "Fields and sections are blue for incomplete fields, but they turn red for fields and sections that have errors",
                    UrlSmall = "https://farm4.staticflickr.com/3935/33806170052_bdda79d7bc_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3935/33806170052_bdda79d7bc_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3935/33806170052_54aff1681a_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-extracommunication_WM",
                    Description = "Issue notification by the Next button ensures applicants are aware of their progress",
                    UrlSmall = "https://farm3.staticflickr.com/2948/33806169992_685c3a338e_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2948/33806169992_685c3a338e_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2948/33806169992_7811f2acc3_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-summary_WM",
                    Description = "The summary section notifies applicants of issues or potentially overlooked areas",
                    UrlSmall = "https://farm4.staticflickr.com/3940/33806169772_d2e1733131_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3940/33806169772_d2e1733131_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3940/33806169772_640e80eea1_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-internal_WM",
                    Description = "The internal job application has a handful of variations, including the employee number field",
                    UrlSmall = "https://farm3.staticflickr.com/2855/33806169912_fa96422fac_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2855/33806169912_fa96422fac_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2855/33806169912_4d4e4b409b_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = tulsajobapp,
                    Name = "jobapp-fire_WM",
                    Description = "The Fire and Police applications feature more comprehensive sections, such as Criminal Background",
                    UrlSmall = "https://farm3.staticflickr.com/2834/33806169952_68c0b100bd_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2834/33806169952_68c0b100bd_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2834/33806169952_b88d4349e2_o.png",
                });
                #endregion
                #region Project: Job App Admin Portal
                Project jobappportal = Context.Projects.Add(new Project()
                {
                    Title = "Job Application Admin Portal",
                    Customer = "City of Tulsa",
                    Year = 2017,
                    Tools = "Visual Studio, Entity Framework, C# WebAPI, AngularJS, Bootstrap, MSSQL",
                    Description = @"After providing Human Resources with an online job application form, they requested a tool to be able to look up forms in the event that someone was having trouble completing the form.
Initially I built a very quick and dirty ASPX search page housed on our intranet server to query the database. As we added different job applications, I adapted the search page into each project, including the addition of a resubmit button for application search results.
With the website relaunch and the consolidation of the job applications, I took the opportunity to rebuild the search pages with more contemporary tools. I centralized the searches and reports in an AngularJS front-end portal with WebAPI controllers and a database-first Entity Framework context.
The new Job Apps Admin Portal is more robust and easier to use. It also serves as a demonstration project for how Entity Framework, WebAPI (with RoleProvider Authorization), and Angular can be utilized in our environment.
Note: this is very much a work in progress.",
                    Categories = "Website",
                    IsFeatured = false,
                    FeaturedImageUrlSmall = "/images/featured/job-portal-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/job-portal-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/job-portal-large.jpeg",
                });
                Context.Media.Add(new Image()
                {
                    Project = jobappportal,
                    Name = "jobappportal-home_WM",
                    Description = "The Job Application Administration Portal centralizes applicant information for HR",
                    UrlSmall = "https://farm4.staticflickr.com/3945/33922682236_297e2540a0_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3945/33922682236_297e2540a0_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3945/33922682236_31e18e3926_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = jobappportal,
                    Name = "jobappportal-search_WM",
                    Description = "The portal features tailored searches for each type of application",
                    UrlSmall = "https://farm4.staticflickr.com/3947/33922682116_61ac35ca6d_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3947/33922682116_61ac35ca6d_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3947/33922682116_541e40b1fe_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = jobappportal,
                    Name = "jobappportal-searchresults_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3933/33922682406_6039989960_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3933/33922682406_6039989960_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3933/33922682406_f3ceac4333_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = jobappportal,
                    Name = "jobappportal-searchresult_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2823/33833804541_dd0faac690_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2823/33833804541_dd0faac690_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2823/33833804541_b90889b708_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = jobappportal,
                    Name = "jobappportal-resumixtext_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2864/33922682186_b294bef4bc_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2864/33922682186_b294bef4bc_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2864/33922682186_8719d12438_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = jobappportal,
                    Name = "jobappportal-dailyreport_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3945/33922682326_79df8fffc2_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3945/33922682326_79df8fffc2_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3945/33922682326_986bdf1b62_o.png",
                });
                #endregion
                #region Project: Lodging Tax Form
                Project lodgingtax = Context.Projects.Add(new Project()
                {
                    Title = "Tulsa Lodging Tax Form",
                    Customer = "City of Tulsa",
                    Year = 2016,
                    Tools = "Visual Studio, ASP.NET, C#, Bootstrap, jQuery, KnockoutJS, MSSQL",
                    Description = @"In 2015 the Treasury department of Tulsa established an electronic filing process for Hotels and Lodging tax collection. They started out with a PDF form, but understandably wanted a less cumbersome solution.
I built out what I thought form should look like in pure HTML and Bootstrap to get acceptance on the appearance and intended workflow. After confirming the direction of the form with Treasury, I built out the database, business logic services, and local web service in the client project to piggyback AJAX calls to the business services behind the firewall.
In the final testing stage, the Treasury department asked if there was a way citizens could upload or import lists of exemptions to avoid typing them all out by hand, so I put together a last-minute basic copy and paste workflow using a special Excel document and video tutorial.
After the first few months of use, Treasury relayed to us that citizens wanted a way to save and auto-populate data for their tax forms each month. Initially they proposed an account system with logins. After we determined that idea to be unfeasible, I added a Clone feature for submitted forms that would replicate the desired data.",
                    Categories = "Website, Video",
                    IsFeatured = true,
                    FeaturedImageUrlSmall = "/images/featured/lodging-tax-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/lodging-tax-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/lodging-tax-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax_WM",
                    Description = "Hotel owners use the Lodging Tax Form to determine their monthly income tax",
                    UrlSmall = "https://farm3.staticflickr.com/2862/33833817571_27c21e356c_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2862/33833817571_27c21e356c_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2862/33833817571_cb14b0cff6_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-progress_WM",
                    Description = "The form uses KnockoutJS to communicate form status throughout and in the footer bar",
                    UrlSmall = "https://farm3.staticflickr.com/2859/33833816391_15acedb83e_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2859/33833816391_15acedb83e_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2859/33833816391_a09e236772_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-exemptions-tutorial_WM",
                    Description = "Exemption sections feature a rough import workflow with explanatory video",
                    UrlSmall = "https://farm3.staticflickr.com/2851/33833816691_fda1d4c569_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2851/33833816691_fda1d4c569_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2851/33833816691_43cf108d85_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-adjustments_WM",
                    Description = "Adjustments can be entered to correct for previous returns",
                    UrlSmall = "https://farm4.staticflickr.com/3931/33833816861_ba95b22da4_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3931/33833816861_ba95b22da4_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3931/33833816861_bffff66538_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-countdown_WM",
                    Description = "The alert at the top of the page gives a countdown to the next deadline",
                    UrlSmall = "https://farm3.staticflickr.com/2882/33833816741_e9500852d0_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2882/33833816741_e9500852d0_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2882/33833816741_06a99b49fb_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-final_WM",
                    Description = "The Summary tab displays final calculations and fields for submitter information",
                    UrlSmall = "https://farm3.staticflickr.com/2925/33833816521_1f4dbbd962_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2925/33833816521_1f4dbbd962_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2925/33833816521_068020609b_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-submitted_WM",
                    Description = "Submitted tax returns provide users with payment information, and can be printed or cloned",
                    UrlSmall = "https://farm3.staticflickr.com/2869/33833817661_b834cdfbc7_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2869/33833817661_b834cdfbc7_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2869/33833817661_09e456bd45_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = lodgingtax,
                    Name = "lodgintax-email_WM",
                    Description = "Submission confirmation email is sent to the submitters with summary information and links to view their form later",
                    UrlSmall = "https://farm3.staticflickr.com/2905/33833816641_e89e2c1521_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2905/33833816641_e89e2c1521_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2905/33833816641_00942355c7_o.png",
                });
                #endregion
                #region Project: Injury Form
                Project injuryForm = Context.Projects.Add(new Project()
                {
                    Title = "Injury Reporting Application",
                    Customer = "City of Tulsa",
                    Year = 2013,
                    Tools = "Visual Studio, ASP.NET, C#, jQuery, KnockoutJS, Photoshop, SketchFlow, MSSQL",
                    Description = @"As a part of the Mayor's initiative to create a culture of safety and decrease workplace injuries, the Safety group requested a project for an injury reporting and analysis system. They needed an application that would ask employees and their supervisors questions about their workplace injuries to help identify and prevent unsafe work conditions. They presented me with two paper forms, the 905A Report and the 905B Investigation, and asked me to build them an application.
I started putting together some designs for the system in Microsoft SketchFlow to demonstrate a potential workflow and collaborated with the City graphic designer to ensure to incorporate branding and design standards. The form comprises a custom HTML front end, KnockoutJS viewmodels, AJAX-submitted C# brokers and C# business logic services.
The project took about two months from planning to launch, and is still used daily. The Safety group and Human Resources reported a nearly 50% drop in reported injuries and costs in the years following the launch of the form.",
                    Categories = "Website",
                    IsFeatured = true,
                    FeaturedImageUrlSmall = "/images/featured/injury-form-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/injury-form-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/injury-form-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "Home Page",
                    Description = "The home page for the Injury Reporting application allows users to see 905A and B forms they have started, as well as other forms they have viewed recently.",
                    UrlSmall = "https://c1.staticflickr.com/3/2870/32935312883_b5813f6314_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2870/32935312883_b5813f6314_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2870/32935312883_dde0c92f03_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "Login Page",
                    Description = "The login portal for the Injury Reporting application authenticates users against Active Directory. This feature was added for departments that use kiosk computers.",
                    UrlSmall = "https://c1.staticflickr.com/3/2834/32935312843_454a48ae07_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2834/32935312843_454a48ae07_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2834/32935312843_64f76014f0_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "Search Page",
                    Description = "The search feature for the Injury Reporting application allows users to query submitted forms using a handful of parameters.",
                    UrlSmall = "https://c1.staticflickr.com/4/3951/33619271521_6576d084c9_b.jpg",
                    UrlMedium = "https://c1.staticflickr.com/4/3951/33619271521_6576d084c9_b.jpg",
                    UrlLarge = "https://c2.staticflickr.com/4/3951/33619271521_a1378a0812_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "Help Page",
                    Description = "The helpful tips and questions page for the Injury Reporting applucation features explanations of icons to help users filling the form out for the first time.",
                    UrlSmall = "https://c1.staticflickr.com/4/3781/32935312903_1cd4f0a0b1_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/4/3781/32935312903_1cd4f0a0b1_b.jpg",
                    UrlLarge = "https://c2.staticflickr.com/4/3781/32935312903_32f3e9f9cc_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "905A Employee Entry Page",
                    Description = "The 905A Injury Report Form starts off with an employee look-up page that takes an employee ID number and auto-populated employee information from our database.",
                    UrlSmall = "https://c1.staticflickr.com/3/2921/33619271481_0efec309b3_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2921/33619271481_0efec309b3_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2921/33619271481_3e3d1eb584_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "905A Injury Entry Page",
                    Description = "The Injury Report Form allows employees to document their injury from time and place to indicators on a body diagram.",
                    UrlSmall = "https://c1.staticflickr.com/4/3754/32935312503_7e53d85435_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/4/3754/32935312503_7e53d85435_b.jpg",
                    UrlLarge = "https://c2.staticflickr.com/4/3754/32935312503_073ca8106c_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "905A Results Entry Page",
                    Description = "The 905A Report Results page directs employees and supervisors to review the injury event details and come up with preventive actions to take for the future.",
                    UrlSmall = "https://c1.staticflickr.com/3/2887/32935312463_f9eb45e0e2_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2887/32935312463_f9eb45e0e2_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2887/32935312463_1733c964bc_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "905B Causes Entry Page",
                    Description = "The 905B Investigation Causes page directs supervisors to examine the various causes for the injury to identify changes needed in the work environment.",
                    UrlSmall = "https://c1.staticflickr.com/4/3757/32935312403_a4d42acaa0_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/4/3757/32935312403_a4d42acaa0_b.jpg",
                    UrlLarge = "https://c2.staticflickr.com/4/3757/32935312403_656b83354f_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "905B Investigation Results Page",
                    Description = "The 905B Investigation Results page engages supervisors and directors to commit to making their employees work environments safer.",
                    UrlSmall = "https://c1.staticflickr.com/3/2890/33619271321_55471cda8d_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2890/33619271321_55471cda8d_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2890/33619271321_a185f0be29_o.png"
                });
                Context.Media.Add(new Image()
                {
                    Project = injuryForm,
                    Name = "Injury Form Print View",
                    Description = "Both 905A and B forms have printable versions for offline discussion and record-keeping.",
                    UrlSmall = "https://c1.staticflickr.com/4/3946/32935312753_b1cd68d897_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/4/3946/32935312753_b1cd68d897_b.jpg",
                    UrlLarge = "https://c2.staticflickr.com/4/3946/32935312753_0ca5297c77_o.png"
                });
                #endregion
                #region Project: SketchOver
                Project sketchover = Context.Projects.Add(new Project()
                {
                    Title = "SketchOver",
                    Customer = "Me",
                    Year = 2013,
                    Categories = "Desktop",
                    Tools = "Visual Studio, C# WPF, Illustrator",
                    Description = @"If you've used PowerPoint before, you might be familiar with the Pen tool in Presentation Mode: it allows you to make marks on your slides to clarify or supplement your presentation information. A few years back I came up with the idea for something that would allow me to sketch like that over top of other programs too.
My search yielded one program for Macs but nothing sufficient for PC, so I set to work writing my own desktop sketch program in WPF.
SketchOver features a comprehensive color picker, pencil and highlighter tools, eraser and line removal capabilities, and the ability to capture screenshots as well as saving and opening canvases using the .sko registered file type. The application is also touchscreen and tablet-friendly, and will swap between the Pen tool and the Eraser tool when flipping advanced styluses (Wacom, etc.).
Note: this project is still a work in progress, and I hope to be able to add more features to it in the future.",
                    IsFeatured = false,
                    FeaturedImageUrlSmall = "/images/featured/sketchover-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/sketchover-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/sketchover-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = sketchover,
                    Name = "logo color meaning_WM",
                    Description = "SketchOver allows you to make notes on top of any application",
                    UrlSmall = "https://farm4.staticflickr.com/3684/33150759943_a7b15da057_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3684/33150759943_a7b15da057_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3684/33150759943_8ccaa42ab8_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = sketchover,
                    Name = "help and eraser_WM",
                    Description = "The eraser tool can erase parts of lines and the help menu explains the other tools",
                    UrlSmall = "https://farm3.staticflickr.com/2909/33150760113_ed0377d3f2_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2909/33150760113_ed0377d3f2_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2909/33150760113_880be0ca67_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = sketchover,
                    Name = "code review_WM",
                    Description = "SketchOver can be used for code reviews or demos",
                    UrlSmall = "https://farm3.staticflickr.com/2932/33150760333_ec3e4e41c5_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2932/33150760333_ec3e4e41c5_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2932/33150760333_d1effea6e0_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = sketchover,
                    Name = "wacom_WM",
                    Description = "Demo of SketchOver on a tablet PC being used to correct page content",
                    UrlSmall = "https://farm4.staticflickr.com/3944/33578983870_1bb0cc63e4_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3944/33578983870_1bb0cc63e4_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3944/33578983870_b896205d89_o.png",
                });
                #endregion
                #region Project: IntersectionInk
                Project intersectionink = Context.Projects.Add(new Project()
                {
                    Title = "Intersection Ink",
                    Customer = "Alabama CAPS",
                    Year = 2010,
                    Categories = "Desktop",
                    Tools = "Visual Studio, C# WPF, XML/XSD, Illustrator",
                    Description = @"After my senior capstone course, I got the opportunity to participate in an internship program hosted by the University of Alabama Center for Advanced Public Safety (CAPS).
Because of my background in .NET and User Interface design, they offered me the opportunity to work on a replacement for the collision diagramming application their civil engineers had relied on since the 90's. They took data from their CARE collision dashboard and mapped it into the application so that civil engineers could spatially analyze the data and come up with solutions to reduce the risk of collisions in intersections or roadways.
I chose to build my application in WPF because the CAPS engineers wanted it to run on PCs, and because I felt it would promote the longevity of the application. Over the course of the summer I worked closely with the CAPS software engineers to determine the method of transporting the data between our applications as well the possibility of integrating my application into their .NET dashboard.
I designed a set of rules in an XSD for defining an intersection in XML as well as detailing any collisions within the intersection. I worked with the CAPS engineers to transform their data into XML according to my schema rules and pipe it into my application. IntersectionInk would then procedurally render the intersection and collisions. I use symbols to illustrate the state of vehicles when a collision occurred and unambiguous nautical terms for describing how the vehicles interacted during the collision.",
                    IsFeatured = true,
                    FeaturedImageUrlSmall = "/images/featured/intersection-ink-small.jpg",
                    FeaturedImageUrlMedium = "/images/featured/intersection-ink-medium.jpg",
                    FeaturedImageUrlLarge = "/images/featured/intersection-ink-large.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = intersectionink,
                    Name = "4 way_WM",
                    Description = "Demo of a 4-way intersection with collisions with source XML file",
                    UrlSmall = "https://farm3.staticflickr.com/2843/33966439365_c713c2c8ce_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2843/33966439365_c713c2c8ce_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2843/33966439365_6d61bc093a_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = intersectionink,
                    Name = "3 way_WM",
                    Description = "Demo of a 3-way intersection with collisions with source XML file",
                    UrlSmall = "https://farm3.staticflickr.com/2871/33966439465_835840eeee_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2871/33966439465_835840eeee_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2871/33966439465_f0c5b50d68_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = intersectionink,
                    Name = "xsd_WM",
                    Description = "Sample of XSD used to define the intersection XML",
                    UrlSmall = "https://farm4.staticflickr.com/3703/33808632042_5d197b5445_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3703/33808632042_5d197b5445_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3703/33808632042_a997130f5b_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Project = intersectionink,
                    Name = "slide-intersection_WM",
                    Description = "Presentation slide for intersection serialization and graphical explanation",
                    UrlSmall = "https://farm3.staticflickr.com/2853/33808631842_38601b1dc7_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2815/33966439325_a4353954ba_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2815/33966439325_a4353954ba_b.jpg",
                });
                Context.Media.Add(new Image()
                {
                    Project = intersectionink,
                    Name = "slide-collision-detail_WM",
                    Description = "Presentation slide for drilldown of important collision data from CARE",
                    UrlSmall = "https://farm3.staticflickr.com/2815/33966439325_a4353954ba_z.jpg",
                    UrlMedium = "https://c1.staticflickr.com/3/2853/33808631842_38601b1dc7_b.jpg",
                    UrlLarge = "https://c1.staticflickr.com/3/2853/33808631842_38601b1dc7_b.jpg",
                });
                #endregion


                #region Album: Bland Wedding
                Album blandWedding = Context.Albums.Add(new Album()
                {
                    Name = "Bland Wedding 2012",
                    Description = "Photographs from the wedding of Wes Bland and Kelly Moore",
                    FeaturedImageUrlSmall = "https://farm3.staticflickr.com/2943/33837080921_963bac0d70_z.jpg",
                    FeaturedImageUrlMedium = "https://farm3.staticflickr.com/2943/33837080921_963bac0d70_b.jpg",
                    FeaturedImageUrlLarge = "https://farm3.staticflickr.com/2943/33837080921_c300427aaf_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_1995_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2935/33809434622_429a19087e_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2935/33809434622_429a19087e_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2935/33809434622_462d5c9e39_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2022_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2941/33582327800_7d38fa0e7e_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2941/33582327800_7d38fa0e7e_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2941/33582327800_960b79e221_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2014_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3943/33582328360_02fafbf0dc_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3943/33582328360_02fafbf0dc_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3943/33582328360_e33d403e8f_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2028_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2890/33967301045_c3c53d7e47_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2890/33967301045_c3c53d7e47_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2890/33967301045_ef875b8642_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2071_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2930/33967296565_ae4f000486_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2930/33967296565_ae4f000486_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2930/33967296565_e94cbffae3_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2249_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3950/33967290345_5813281e53_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3950/33967290345_5813281e53_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3950/33967290345_d46ffe1e1e_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2045_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3950/33967297965_ab1141a49e_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3950/33967297965_ab1141a49e_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3950/33967297965_f439f6c5e1_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2196_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2949/33967292775_c5f40c70c3_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2949/33967292775_c5f40c70c3_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2949/33967292775_baef03a280_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2104_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2875/33967294155_e3bca7442d_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2875/33967294155_e3bca7442d_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2875/33967294155_aff05f3840_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_1992_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2827/33967285765_21ba88d140_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2827/33967285765_21ba88d140_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2827/33967285765_e3b0cc4244_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_1970_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2937/33837076541_ff79bd5ee8_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2937/33837076541_ff79bd5ee8_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2937/33837076541_a531b3ec33_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2030_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2934/33809428762_643f8dc63f_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2934/33809428762_643f8dc63f_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2934/33809428762_0cc8165be4_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2205_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2920/33967291275_ec91acb688_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2920/33967291275_ec91acb688_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2920/33967291275_289795b6b7_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2100_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3804/33809424652_7ba921209c_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3804/33809424652_7ba921209c_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3804/33809424652_046a446c6a_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2263_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2891/33837078741_5e6cc2024a_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2891/33837078741_5e6cc2024a_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2891/33837078741_d1e4d50f29_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2258_WM",
                    Description = "",
                    UrlSmall = "https://farm4.staticflickr.com/3945/33967288785_3423f47e38_z.jpg",
                    UrlMedium = "https://farm4.staticflickr.com/3945/33967288785_3423f47e38_b.jpg",
                    UrlLarge = "https://farm4.staticflickr.com/3945/33967288785_37b4748635_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_2254_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2943/33837080921_963bac0d70_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2943/33837080921_963bac0d70_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2943/33837080921_c300427aaf_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_1967_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2905/33967287705_0f6ef72d49_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2905/33967287705_0f6ef72d49_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2905/33967287705_1c1195920a_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_1982_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2833/33967286765_62f8009398_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2833/33967286765_62f8009398_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2833/33967286765_67847c5824_o.png",
                });
                Context.Media.Add(new Image()
                {
                    Album = blandWedding,
                    Name = "IMG_1985_WM",
                    Description = "",
                    UrlSmall = "https://farm3.staticflickr.com/2827/33837073941_e7361c4b4c_z.jpg",
                    UrlMedium = "https://farm3.staticflickr.com/2827/33837073941_e7361c4b4c_b.jpg",
                    UrlLarge = "https://farm3.staticflickr.com/2827/33837073941_a557e992e0_o.png",
                });
                #endregion
                Context.SaveChanges();
            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(System.Data.Entity.Validation.DbEntityValidationException))
                {
                    var temp = ((System.Data.Entity.Validation.DbEntityValidationException)e).EntityValidationErrors;
                }
            }
        }
    }
}