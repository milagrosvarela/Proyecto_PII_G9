using System; 

namespace Chatbot;

//           UML
// ---------------------------
// + Categories : List<string>
// ---------------------------
// + AddCategory()
// + RemoveCategory()
// + GetCategory()
// ---------------------------

// La clase Category permite que el administrador pueda añadir nuevas categorías y eliminar otras. Además 
// colabora con Search y Sort para que el empleador pueda escoger un servicio de forma más eficiente. 

public class Category
{
    public List<string> Categories;

    public void AddCategory(string category)
    {
        Categories.Add(category);

    }

    public void RemoveCategory()
    {

    }

    public void GetCategory()
    {

    }

}