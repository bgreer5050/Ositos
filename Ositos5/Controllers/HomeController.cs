using Ositos5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ositos5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("ositos");
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index2()
        {

            return View();

        }

        public ActionResult Tier2()
        {
            MyAppStrapWebsite site = new MyAppStrapWebsite();
            site.Title = "Tier 2 Tech Support";
            site.TagLine1 = "Computer Support Team";
            site.TagLine2 = "Trained Professionals";
            
            site.Blog_Exist = false;
            
            site.AboutUs = "We have a combined experience of 35 years of experience troubleshooting IT problems.  We are NOT the kid next door.";
            site.Address = "Chicago Area";
            site.PhoneNumber = "(708) 320-9810";
            site.ContactPhone = "(708) 320-9810";
            site.EmailContactGeneral = "bgreer5050@gmail.com";

    


            site.Customer1Name = "James Grodon";
            site.CustomerReview1 = @"It's totally awesome, The team at Tier 2 removed viruses that I didn't know I even had!";
            
            site.Customer2Name = "Mary Beth Olson";
            site.CustomerReview2 = @"My son had a paper due the next morning and I could not print.  Art at Tier 2 logged into my machine remotely and got us going." ;
            
            site.Customer3Name = "John Fitzpatrick";
            site.CustomerReview3 = @"Tier 2 came out and put a new power supply in my PC on a Sunday afternoon.  Nice work!";


            site.Core1ImgURI = new Uri(@"/home/img/features/feature-1.png", UriKind.Relative);
            site.Core2ImgURI = new Uri(@"/home/img/features/feature-1.png", UriKind.Relative);
            site.Core3ImgURI = new Uri(@"/home/img/features/feature-1.png", UriKind.Relative);
            site.Core4ImgURI = new Uri(@"/home/img/features/feature-1.png", UriKind.Relative);

            site.FootNoteTagLine = @"<span class=""spacer"">//</span> Free anti-virus scan against 54 antivirus engines. <span class=""spacer"">//</span> 24/7 Support <span class=""spacer"">//</span> Business Support Plans from $19.99/month <span class=""spacer"">//</span>";

            return View(site);

        }

        public ActionResult FrankfortGroup()
        {
            MyAppStrapWebsite site = new MyAppStrapWebsite();
            site.Title = "Frankfort Roofing Siding and Windows";
            site.TagLine1 = "Exterior Pros";
            site.TagLine2 = "";
            site.PhoneNumber = "(708) 320-9810";
            site.AboutUs = "We install roofing, siding, gutters, soffit, fascia and windows in the Frankfort area.";

            site.Slide2_Layer1 = new Uri("/home/img/slides/window_slide.png",UriKind.Relative);
            site.Slide2_Layer2 = new Uri("/home/img/slides/siding_slide.png", UriKind.Relative);
            site.Slide2_Layer3 = new Uri("/home/img/slides/roofing_slide.png", UriKind.Relative);
            

            site.Customer1Name = "James Grodon";
            site.CustomerReview1 = @"I had the windows, siding, gutters, soffit and fascia replaced.  I was scared of such a huge project, but it went great!";

            site.Customer2Name = "Mary Beth Olson";
            site.CustomerReview2 = @"Very professional.  They left the construction site clean and the job looks great.";

            site.Customer3Name = "John Fitzpatrick";
            site.CustomerReview3 = @"Chris from K&G roofing came out and helped me with an insurance claim.  My roof had hail damage and Chris worked with my insurance company to get it paid for.";


            site.Core1ImgURI = new Uri(@"/home/img/features/roofing.png", UriKind.Relative);
            site.Core1_a = "KG";
            site.Core1_b = "Roofing";
            site.Core1Desc = "The groups licensed roofer is KG Roofing.  KG roofing has an A+ rating with the BBB and fantastic reviews across the internet";


            site.Core2ImgURI = new Uri(@"/home/img/features/windows.png", UriKind.Relative);
            site.Core2_a = "Weather Guard";
            site.Core2_b = "Windows";
            site.Core2Desc = "Beutify your house with new energy efficient windows installed by our pros.";


            site.Core3ImgURI = new Uri(@"/home/img/features/windows.png", UriKind.Relative);
            site.Core3_a = "Roman's Construction";
            site.Core3_b = "Siding";
            site.Core3Desc = "We will beutify your home with a high quality, maintenance free, weather resistant siding product that you will enjoy for many years.";

            site.Core2ImgURI = new Uri(@"/home/img/features/windows.png", UriKind.Relative);
            site.Core3ImgURI = new Uri(@"/home/img/features/siding.png", UriKind.Relative);
            site.Core4ImgURI = new Uri(@"/home/img/features/gutters.png", UriKind.Relative);

            site.FootNoteTagLine = @"<span class=""spacer"">//</span> Free anti-virus scan against 54 antivirus engines. <span class=""spacer"">//</span> 24/7 Support <span class=""spacer"">//</span> Business Support Plans from $19.99/month <span class=""spacer"">//</span>";


            site.PosterBoardHeading_a = "Summer";
            site.PosterBoardHeading_b = "Packages";

            return View(site);

        }

        public ActionResult Ositos()
        {

            MyAppStrapWebsite site = new MyAppStrapWebsite();

            site.Title = "Ositos Party Rentals";

            site.AboutUs = "Ositos is a full service party rental company.  We have a huge selection of bounce houses, snow cone machines.....";
            site.Address = "Shorewood & Chicago, IL";
            site.Address_Show = true;
            site.AboutUs_ShowFindOutMoreButton = false;
            site.Blog_Exist = true;
            site.PhoneNumber = "773-988-8582";
            site.ContactPhone = "773-988-8582";
            site.EmailContactGeneral = "ositospartyrentals@gmail.com";


            site.Slide2_Layer1 = new Uri("/home/img/slides/ositos/phone_slide.png", UriKind.Relative);
            site.Slide2_Layer2 = new Uri("/home/img/slides/ositos/bear_slide.png", UriKind.Relative);
            site.Slide2_Layer3 = new Uri("/home/img/slides/ositos/main_slide.png", UriKind.Relative);


            site.Slide2_ActionLine1 = "We Are Booking Fast!!";
            site.Slide2_ActionLine2_a ="Call";
            site.Slide2_ActionLine2_b = "Today";

            site.Slide2_ActionLine3 ="While Supplies Last";
            site.Slide2_ActionButtonText = "Reserve Now";
            

            site.CoreFeaturesHeading_a= "Products and Services";
            site.CoreFeaturesSubHeading = "";

            site.Core1_a = "BOUNCE";
            site.Core1_b = "HOUSES & SLIDES"; 
            site.Core1Desc = @"<ul><li>Mickey-Minnie</li><li>Justice League</li><li>Princess</li><li>Super Heroes</li></li><li>Cars</li></ul>";
            site.Core1ImgURI = new Uri("/home/img/ositos/JusticeLeague.png", UriKind.Relative);




            site.Core2_a = "TENTS";
            site.Core2_b = "CANOPIES"; //site.Core1ImgURI = new Uri("") //260 x 140
            site.Core2Desc = @"<ul><li>Pole Canopies</li><li>Pop-Up Canopies</li><li>Enclosed</li><li>More</li></li></ul>";
            site.Core2ImgURI = new Uri("/home/img/ositos/canopy2020.png", UriKind.Relative);


            site.Core3_a = "TABLES";
            site.Core3_b = "CHAIRS";
            site.Core3Desc = @"<ul><li>Disney</li><li>Princess</li><li>Slides</li><li>More</li></li></ul>";
            site.Core3ImgURI = new Uri("/home/img/ositos/ChairsCanopy_.png", UriKind.Relative);


            site.Core4_a = "OTHER";
            site.Core4_b = "RENTALS";
            site.Core4Desc = @"<ul><li>Snowcone Machines</li><li>Bean Bags</li><li>Coolers</li><li>More</li></li></ul>";
            site.Core4ImgURI = new Uri("/home/img/ositos/snowcone_.jpg", UriKind.Relative);


            site.Poster1_Show = true;
            site.Poster2_Show = true;
            site.Poster3_Show = true;
            site.Poster4_Show = true;



            site.Poster1 = "Monday Special";
            site.Poster1SubHeading = "$145";
            site.Poster1Line1 = "1 Bounce House";
            site.Poster1Line2 = "1 Snow Cone Machine";
            site.Poster1Line3 = "20 Chairs";
            site.Poster1Line4 = "2 Tables";



            site.Poster2_a = "Tuesday";
            site.Poster2_b = "Special";

            site.Poster2SubHeading = "$185";
            site.Poster2Line1 = "1 Bounce House";
            site.Poster2Line2 = "1 Snow Cone Machine";
            site.Poster2Line3 = "20 Chairs";
            site.Poster2Line4 = "2 Tables";


            site.Poster3_a = "Wednesday";
            site.Poster3_b = "Special";
            site.Poster3SubHeading = "$185";
            site.Poster3Line1 = "1 Bounce House";
            site.Poster3Line2 = "1 Snow Cone Machine";
            site.Poster3Line3 = "20 Chairs";
            site.Poster3Line4 = "2 Tables";


            site.Poster4_a = "Thursday";
            site.Poster4_b = "Special";
            site.Poster4SubHeading = "$185";
            site.Poster4Line1 = "1 Bounce House";
            site.Poster4Line2 = "1 Snow Cone Machine";
            site.Poster4Line3 = "20 Chairs";
            site.Poster4Line4 = "2 Tables";


            site.PosterBoardAreaFooter = "";



            site.Customer1Name = "Mike Hernandez";
            site.CustomerReview1 = @"The wife wanted a last minute birthday party for our 1st grader.  Osito's brought out a jumpy the same day I called!";

            site.Customer2Name = "Mary Beth Olson";
            site.CustomerReview2 = @"Ositos Party Rentals gave me a package deal on a bounce house, tent, chairs, tables and a snow cone machine.  They were 30% cheaper than others.";

            site.Customer3Name = "Cindy";
            site.CustomerReview3 = @"Ositos helped me with an outdoor part in December.  They provided me with a heated enclosed canopy.";


            site.PosterBoardHeading_a = "Summer";
            site.PosterBoardHeading_b = "Packages";

            return View(site);
        }
       



    }
}
