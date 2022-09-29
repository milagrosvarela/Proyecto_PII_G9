using System; 

namespace Chatbot;

//             UML
// ---------------------------
//
// ---------------------------
// + SearchNoFilter(sort)
// + SearchbyCategory(sort)
// --------------------------- 

// * Falta establecer una lista de servicios para aplicar al searcher.

public class Search 
{
    // Muestra una lista de todos los servicios.
    public List<string> SearchNoFilter()
    {
        /*
        List<string> result = new ArrayList();
        foreach (Service service in this.Services)
        {
                result.Add(Service);
        }
        return result;
        */
    }

    // Muestra una lista de todos los servicios de la categoría indicada.
    public List<string> GetServicesByCategory(string category)
    {
        /*
        List<string> result = new ArrayList();
        foreach (Service service in this.Services)
        {
            if (Service.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(Service);
            }
        }
        return result;
        */
    }

}