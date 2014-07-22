using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ositos5.Models
{
    public class MyWebSite
    {

        public int ID { get; set; }
        public string Title { get; set; }


        public string TagLine1 { get; set; }
        public string TagLine2 { get; set; }

        public string AboutUs { get; set; } //Approximately 20 Words
        public string PhoneNumber { get; set; }
        public string EmailContactGeneral { get; set; }

        public string Address { get; set; }
        public bool Address_Show { get; set; }

        public bool SignUpLink_Show { get; set; } 
        public Uri SignUpLink { get; set; }


        public bool SignIn_Show { get; set; }
        public Uri SignInLink { get; set; }


        public bool ShowMap { get; set; }
       
        public string ContactPhone { get; set; }
        public Uri TwitterLink { get; set; }
        public Uri LinkedInLink { get; set; }
        public Uri FacebookLink { get; set; }
    
        public string EmailContactSales { get; set; }
        public string EmailTechSupport { get; set; }

        public bool Blog_Exist { get; set; }
        public Uri BlogLink { get; set; }
        
 


    }

    public class MyAppStrapWebsite : MyWebSite
    {


        public Uri Slide1Image { get; set; } //~600 x 350

        public bool Slide2_Heading_Show { get; set; }
        public string Slide2_Heading { get; set; }

        public Uri Slide2_Layer1 { get; set; }  //Far left image on slide 2.  Approximately 300 x300
        public Uri Slide2_Layer2 { get; set; }  // Far right image on slide 2.  Approximately 330 x 500
        public Uri Slide2_Layer3 { get; set; }  //Top Center image on slide 2.  900x310 or 450 x 440

        
        public string Slide2_ActionLine1 { get; set; }

        public string Slide2_ActionLine2_a { get; set; }
        public string Slide2_ActionLine2_b { get; set; }

        public string Slide2_ActionLine3 { get; set; }
        public string Slide2_ActionButtonText { get; set; }






        public bool AboutUs_ShowFindOutMoreButton { get; set; }

        public string CoreFeaturesHeading_a { get; set; }
        public string CoreFeaturesHeading_b { get; set; }

        public string CoreFeaturesSubHeading { get; set; }

        public string Core1_a { get; set; }
        public string Core1_b { get; set; }
        public string Core1Desc { get; set; }
        public Uri Core1ImgURI { get; set; } //260 x 140

        public string Core2_a { get; set; }
        public string Core2_b { get; set; }
        public string Core2Desc { get; set; }
        public Uri Core2ImgURI { get; set; } //260 x 140
        
        public string Core3_a { get; set; }
        public string Core3_b { get; set; }
        public string Core3Desc { get; set; }
        public Uri Core3ImgURI { get; set; } //260 x 140
        
        public string Core4_a { get; set; }
        public string Core4_b { get; set; }
        public string Core4Desc { get; set; }
        public Uri Core4ImgURI { get; set; } //260 x 140


        public string PosterBoardHeading_a { get; set; }
        public string PosterBoardHeading_b { get; set; }

        public string PosterBoardSubHeading { get; set; }

        public bool Poster1_Show { get; set; }
        public string Poster1 { get; set; }  
        public string Poster1SubHeading { get; set; } // i.e. $199.95 or Free
        public string Poster1Line1 { get; set; }
        public string Poster1Line2 { get; set; }
        public string Poster1Line3 { get; set; }
        public string Poster1Line4 { get; set; }


        public bool Poster2_Show { get; set; }
        public string Poster2_a { get; set; }
        public string Poster2_b { get; set; }
        public string Poster2SubHeading { get; set; } // i.e. $199.95 or Free
        public string Poster2Line1 { get; set; }
        public string Poster2Line2 { get; set; }
        public string Poster2Line3 { get; set; }
        public string Poster2Line4 { get; set; }


        public bool Poster3_Show { get; set; }
        public string Poster3_a { get; set; }
        public string Poster3_b { get; set; }
        public string Poster3SubHeading { get; set; } // i.e. $199.95 or Free
        public string Poster3Line1 { get; set; }
        public string Poster3Line2 { get; set; }
        public string Poster3Line3 { get; set; }
        public string Poster3Line4 { get; set; }

        public bool Poster4_Show { get; set; }
        public string Poster4_a { get; set; }
        public string Poster4_b { get; set; }
        public string Poster4SubHeading { get; set; } // i.e. $199.95 or Free
        public string Poster4Line1 { get; set; }
        public string Poster4Line2 { get; set; }
        public string Poster4Line3 { get; set; }
        public string Poster4Line4 { get; set; }

        public string PosterBoardAreaFooter { get; set; }

        public string CustomerReview1 { get; set; }
        public string Customer1Name { get; set; }

        public string Customer2Name { get; set; }
        public string CustomerReview2 { get; set; }

        public string Customer3Name { get; set; }
        public string CustomerReview3 { get; set; }

        public string FootNoteTagLine { get; set; }

        public string LastButtonOnPage { get; set; }
        public Uri LastButtonOnPageLink { get; set; }


    }
}