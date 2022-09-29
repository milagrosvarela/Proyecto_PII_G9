using System; 

namespace Chatbot;

//             UML
// --------------------------
// + ID: int
// + Name : string
// + PhoneNumber : string
// + Email : string
// + Pass : string
// + Rating : int
// --------------------------
// + Login()
// + ChangeUserData()
// + DeleteUser()
// + CancelService()
// --------------------------

// La clase abstracta User es base de Worker y Employer. Tiene variables y métodos generales a todos los usuarios,
// como ID, datos personales y de contacto. Además almacena la reputación del usuario y les permite ingresar a su
// cuenta, cancelar un servicio, cambiar su información o borrar su cuenta. 

public abstract class User
{
    int ID{get;}
    string Name{get;set;}
    int PhoneNumber{get;set;}
    string Email{get;set;}
    string Password{get;set;}
    Rating Rating{get;set;}

    public User(string Name, int PhoneNumber, string Email, string Password)
    {
        this.Name = Name.Trim();
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
        this.Password = Password;
    }

    public abstract void Login();
    public abstract void ChangeUserData();
    public abstract void DeleteUser(User user);
    public abstract void CancelService(Service service);
}
