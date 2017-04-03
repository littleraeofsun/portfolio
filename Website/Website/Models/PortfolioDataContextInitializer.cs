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
            #region Project: Injury Form
            Project injuryForm = Context.Projects.Add(new Project()
            {
                Title = "Injury Reporting Application",
                Customer = "City of Tulsa",
                Year = 2013,
                Tools = "Visual Studio, ASP.NET, C#, jQuery, KnockoutJS, Photoshop, SketchFlow, MSSQL",
                Description = @"As a part of the Mayor's initiative to create a culture of safety and decrease workplace injuries, the Safety group requested a project for an injury reporting and analysis system. They needed an application that would ask employees and their supervisors questions about their workplace injuries to help identify and prevent unsafe work conditions. They presented me with two paper forms, the 905A Report and the 905B Investigation, and asked me to build them an application.
I started putting together some designs for the system in Microsoft SketchFlow to demonstrate a potential workflow and set of features for the forms. I also ran by form design by the City graphic designer to ensure it met branding and design integrity standards.
The project took about two months from planning to launch, and is still being used today. The Safety group and Human Resources reported a nearly 50% drop in reported injuries and costs in the years following the launch of the form. 
My favorite feature of this project was the virtualization of the body diagram from the paper forms. I designed a ViewModel map of injury points that users could interact with to show where exactly on their bodies they were injured. The points were stored in the database with coordinates for subjective analysis on the forms and print-outs and with body region categorization for objective analysis of where injuries occur most on the body.
Since the launch, a Fire Department-specific portion of the form has been added so that the Fire Chief can better assess hazards for firefighters and staff. A similar functionality is planned for the Police Department as well. I will also be implementing a registration process for department heads to request receiving a copy of forms submitted for employees in their department.",
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
                FeaturedImageUrlSmall = "https://farm4.staticflickr.com/3792/33674992121_c7180629f2_z.jpg",
                FeaturedImageUrlMedium = "https://farm4.staticflickr.com/3792/33674992121_c7180629f2_b.jpg",
                FeaturedImageUrlLarge = "https://farm4.staticflickr.com/3792/33674992121_4eb6b6b0fe_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2254",
                Description = "",
                UrlSmall = "https://farm4.staticflickr.com/3792/33674992121_c7180629f2_z.jpg",
                UrlMedium = "https://farm4.staticflickr.com/3792/33674992121_c7180629f2_b.jpg",
                UrlLarge = "https://farm4.staticflickr.com/3792/33674992121_4eb6b6b0fe_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2014",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2942/33674952161_810676d2bc_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2942/33674952161_810676d2bc_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2942/33674952161_a671a32a76_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2100",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2893/33648120152_837a6c387a_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2893/33648120152_837a6c387a_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2893/33648120152_082bdb5766_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_1982",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2860/33419665590_ec990fe11e_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2860/33419665590_ec990fe11e_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2860/33419665590_894c3a5ac4_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2045",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2871/33419632640_8dbe2cd2ce_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2871/33419632640_8dbe2cd2ce_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2871/33419632640_b38e29d167_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_1985",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2924/33674956471_b575a2358c_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2924/33674956471_b575a2358c_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2924/33674956471_50e9826931_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2030",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2920/32961210974_63849bf8e0_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2920/32961210974_63849bf8e0_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2920/32961210974_378cd1ff93_k.jpg",
            });            
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2028",
                Description = "",
                UrlSmall = "https://farm4.staticflickr.com/3937/32961204714_7015a8793a_z.jpg",
                UrlMedium = "https://farm4.staticflickr.com/3937/32961204714_7015a8793a_b.jpg",
                UrlLarge = "https://farm4.staticflickr.com/3937/32961204714_3d1893e7ba_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_1970",
                Description = "",
                UrlSmall = "https://farm4.staticflickr.com/3940/33419675130_55624b4b34_z.jpg",
                UrlMedium = "https://farm4.staticflickr.com/3940/33419675130_55624b4b34_b.jpg",
                UrlLarge = "https://farm4.staticflickr.com/3940/33419675130_7b868c097b_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_1992",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2891/33419669820_59b94728cd_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2891/33419669820_59b94728cd_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2891/33419669820_6efc5f87df_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_1995",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2812/33648155202_3427e7f705_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2812/33648155202_3427e7f705_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2812/33648155202_8e3953c67e_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2022",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2865/33804262025_59b1f52c50_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2865/33804262025_59b1f52c50_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2865/33804262025_13aaa81c66_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_1967",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2837/33804283695_cb126ef737_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2837/33804283695_cb126ef737_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2837/33804283695_7d85c5e4fd_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2205",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2943/33804234315_0dcc58c96a_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2943/33804234315_0dcc58c96a_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2943/33804234315_475552d498_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2071",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2905/33674981771_61fa415b9a_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2905/33674981771_61fa415b9a_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2905/33674981771_8add48982f_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2263",
                Description = "",
                UrlSmall = "https://farm4.staticflickr.com/3944/33674986711_1f7922c9fb_z.jpg",
                UrlMedium = "https://farm4.staticflickr.com/3944/33674986711_1f7922c9fb_b.jpg",
                UrlLarge = "https://farm4.staticflickr.com/3944/33674986711_12ef7e6548_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2104",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2865/33674982961_2ff5a24c10_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2865/33674982961_2ff5a24c10_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2865/33674982961_7256f3bbc8_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2258",
                Description = "",
                UrlSmall = "https://farm4.staticflickr.com/3754/33804302505_5bc5d8e048_z.jpg",
                UrlMedium = "https://farm4.staticflickr.com/3754/33804302505_5bc5d8e048_b.jpg",
                UrlLarge = "https://farm4.staticflickr.com/3754/33804302505_bc18562a41_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2249",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2864/33419622250_5838849a3c_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2864/33419622250_5838849a3c_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2864/33419622250_8c861712da_k.jpg",
            });
            Context.Media.Add(new Image()
            {
                Album = blandWedding,
                Name = "IMG_2196",
                Description = "",
                UrlSmall = "https://farm3.staticflickr.com/2838/33674932111_690003bbc0_z.jpg",
                UrlMedium = "https://farm3.staticflickr.com/2838/33674932111_690003bbc0_b.jpg",
                UrlLarge = "https://farm3.staticflickr.com/2838/33674932111_832bb58ac9_k.jpg",
            });
            #endregion
            Context.SaveChanges();
        }
    }
}