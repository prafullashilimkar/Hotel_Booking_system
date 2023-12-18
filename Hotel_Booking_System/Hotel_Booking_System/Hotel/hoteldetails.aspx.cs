using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Hotel_Booking_System.Hotel
{
    public partial class hoteldetails : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string selectedHotel = Request.QueryString["hotel"];
                

                // Set the CSS class based on the selected hotel (e.g., Hayatt or Ibis)
                body.Attributes["class"] = selectedHotel;

                // Customize the content based on the selected hotel
                switch (selectedHotel)
                {
                    case "Hayatt":
                        hotelTitle.InnerText = "Welcome to Hayatt";
                        hotelDescription.InnerText = "Experience the charm, well-suited for business and leisure travel. Explore open, relaxed spaces at our downtown hotel, close to the airport. Well-appointed rooms offer large windows and in-room amenities. Experience wellness and varied cuisine, set in serenity.";
                        videoSource.Src = "video/hayatt.mp4";
                        break;
                    case "Ibis":
                        hotelTitle.InnerText = "Welcome to Ibis";
                        hotelDescription.InnerText = "The property, located along Nagar Road in Maharashtra State, enjoys a great location advantage and provides easy and fast connectivity to the major transit points of the city. Some of the popular transit points from IBIS Pune Viman Nagar are the Pune International Airport which is a 7-minute drive away (3.2 kms), as well as the Pune Station Bus Stand, a mere 15-minute drive away (6.4 kms).";
                        videoSource.Src = "video/IBIS.mp4";
                        break;
                    case "ORCHID":
                        hotelTitle.InnerText = "Welcome to Orchid Hotel";
                        hotelDescription.InnerText = "The Orchid Hotel Pune is an iconic structure situated on the Bangalore - Pune - Mumbai Expressway with easy access to the heart of Pune's dynamic central business district. Our eco-friendly hotel in Pune is only minutes from major corporations, key government institutions and premier academic and research institutions. Fine shopping malls, exquisite restaurants and entertainment hubs are just moments away at Balewadi High Street. We are also within easy reach of popular tourist attractions like Aga Khan Palace and Shaniwar Wada, making it an ideal destination for business travellers and families vacationing in India.";
                        videoSource.Src = "video/Orchid.mp4";
                        break;
                    case "COCOON":
                        hotelTitle.InnerText = "Welcome to COCOON HOTEL";
                        hotelDescription.InnerText = "Cocoon Hotel comes under the Mother Brand - Magarpatta Clubs & Resorts Limited (MCRPL). Cocoon Hotel Started in 2009, an exclusive all-suite hotel at Magarpatta City providing 4-star facilities. Cocoon Hotel has 118 rooms built inside an integrated township, with commercial and residential zones. The room size is largest amongst its competitors, each room has a separate living room and a balcony. Rooms are provided with the ‘best in class’ amenities and facilities for discerning guests. The hotel has a Banquet, Bar, 24 Hour Room Service and Restaurant.";
                        videoSource.Src = "video/Cocoon.mp4";
                        break;
                    case "MARRIOTT":
                        hotelTitle.InnerText = "Welcome to JW MARRIOTT";
                        hotelDescription.InnerText = "Experience award-winning service and sophisticated style at JW Marriott Hotel Pune. Situated between the airport and Mumbai-Pune Expressway, our 5-star luxury hotel in Pune is an ideal escape to India for both business travelers and vacationing families. After exploring the city, return for our delightful dining options, including Italian fare and a chic rooftop bar. .";
                        videoSource.Src = "video/JW.mp4";
                        break;
                    case "TOWNHOUSE":
                        hotelTitle.InnerText = "Welcome to TOWNHOUSE";
                        hotelDescription.InnerText = "OYO Townhouse 063 M G Road is an impressive property offering a beautiful stay to the modern traveller. The rooms offered by this establishment are really spacious and have been designed and decorated very thoughtfully.";
                        videoSource.Src = "video/Townhouse.mp4";
                        break;
                    case "CENTRO":
                        hotelTitle.InnerText = "Welcome to CENTRO HOTEL";
                        hotelDescription.InnerText = "Well located in the Shivaji Nagar district of Pune, Centro is located 300 metres from Fergusson College, 1.3 km from Pataleshwar Cave Temple and 2.1 km from Srimant Dagadusheth Halwai Ganapati Temple. With a restaurant, the 4-star hotel has air-conditioned rooms with free WiFi, each with a private bathroom. Free private parking is available and the hotel also provides car hire for guests who want to explore the surrounding area.";
                        videoSource.Src = "video/Centro.mp4";
                        break;
                    case "NOVOTEL":
                        hotelTitle.InnerText = "Welcome to NOVOTEL HOTEL";
                        hotelDescription.InnerText = "At Novotel Pune you will find a well-equipped business centre and banqueting facilities. Other facilities offered include a safety deposit, luggage storage and dry cleaning. Guests can approach the tour desk for all travel related arrangements and currency exchange.";
                        videoSource.Src = "video/Novotel.mp4";
                        break;
                    case "CONRED":
                        hotelTitle.InnerText = "Welcome to CONRED HOTEL";
                        hotelDescription.InnerText = "Echoing the glamour of the Art Deco era, our Central Business District hotel is two kilometers from Koregaon Park. We feature a luxury spa, beauty salon, outdoor pool and bar, and eclectic dining options. Our concierge is on-hand to curate local experiences, reserve limousine travel, and more";
                        videoSource.Src = "video/Conred.mp4";
                        
                        break;
                    default:
                        // Handle other hotels or default case
                        break;
                }
            }

            
            }

      
        protected void btnBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["hotel"]))
            {
                // Retrieve the hotel name from the query string
                string selectedHotel = Request.QueryString["hotel"];

                // Redirect to mainbooking.aspx page with the hotel name in the query string
                Response.Redirect("../Hotel/MainBooking.aspx?hotel=" + selectedHotel);
            }
            // Response.Redirect("../Hotel/MainBooking.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Hotel/Masteruser.aspx");
        }
    }
}
        
    