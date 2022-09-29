using System; 

namespace Chatbot;

//           UML
// ------------------------
// + Name : string
// + Category : string
// + Description : string 
// + Fee : string
// ------------------------
// + ValidateService()
// ------------------------

// La clase Service permite que los trabajadores ofrezcan un servicio, incluyendo categoría, descripción 
// y costo. 

public class Service
{
    public string Name{get;set;}
    public string Category{get;set;}
    public string Description{get;set;}
    public string Fee{get;set;}

    public Service(String Name, string Category, string Description, string Fee)
    {
        this.Name = Name.Trim();
        this.Category = Category.Trim();
        this.Description = Description;
        this.Fee = Fee;
    }

    public void ValidateService()
    {
        //Utilizar los métodos de validación de la clase Validation
    }
    
}