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

// La clase Rating gestiona la calificación tanto de los trabajadores como de los empleadores, determinando el 
// rango de calificaciones que se puede asignar y el puntaje promedio de cada uno para así obtener su reputación.
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