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
            #region Project: Tulsa City Website
            Project cityoftulsaorg = Context.Projects.Add(new Project()
            {
                Title = "City of Tulsa Website",
                Customer = "City of Tulsa",
                Year = 2017,
                Tools = "Visual Studio, Umbraco 7, MVC, C#, jQuery, KnockoutJS, Photoshop, MSSQL, Git",
                Description = @"In 2013 the Tulsa IT and Communications departments decided that the city website needed updating. The old site, built back around 2005, ran on Umbraco 4 CMS and was several years behind on patches. The layout only allowed for 580px of content on pages, and the extensibility options were limited and rigid due to a lack of training on the CMS.
I volunteered to work on the redesign of the site and began researching responsive web design methods and CMS options between my normal tasks. Ultimately I chose to go with Bootstrap and Umbraco 7. Because I had never used either of these frameworks before, I put together a series of proof of concept projects to learn the ropes and demonstrate the capabilities to the rest of my team.
With Umbraco's online tutorial series and Level 2 certification course, I was able to build a development site based on the Photoshop mock-ups from our Communications department. I taught the rest of our development team how to migrate our old WebForms applications to MVC macros in Umbraco and how to use Git to save and manage their changes.
A little under a year after I completed my Level 2 training, we launched the new City of Tulsa website with over 10,000 pages of reorganized content, nearly 50 forms and applications transitioned from .NET 2.0 to 4.5 (and added to change control), and nearly 20 brand new solutions custom built for various departments and citizens.
The core focus of the new site was to make things easier to find. I leveraged Umbraco's Examine search engine to replace our old Google site search, and Communications chose a theme centered around a prominent search bar. Acceptance has been overwhelmingly positive, and many groups (including the new mayor) have already expressed interest in having new features and applications built into or alongside the new site.",
                Categories = "Website, Training",
                IsFeatured = true,
                FeaturedImageUrlSmall = "https://farm3.staticflickr.com/2835/33833739761_68522156bb_z.jpg",
                FeaturedImageUrlMedium = "https://farm3.staticflickr.com/2835/33833739761_68522156bb_b.jpg",
                FeaturedImageUrlLarge = "https://farm3.staticflickr.com/2835/33833739761_29310c53da_o.png"
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
                FeaturedImageUrlLarge = "/images/featured/injury-form-large.jpg",
                FeaturedImageUrlMedium = "/images/featured/injury-form-medium.jpg",
                FeaturedImageUrlSmall = "/images/featured/injury-form-small.jpg"
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
    }
}