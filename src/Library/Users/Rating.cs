using System; 

namespace Chatbot;

//           UML
// ---------------------------
// + Ratings : List<int>
// + AverageRating : int
// ---------------------------
// + GetAverageRating()
// + AddRating(rating)
// ---------------------------

public class Rating
{
    List<Service> Ratings {get;set;}
    int AverageRating {get;set;}

    public Rating()
    {
        this.Ratings = new List<Service>{};
        this.AverageRating = 0;
    }

    public void GetAverageRating()
    {

    }
    public void AddRating(Rating rating)
    {

    }
}