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

public abstract class User
{
    int ID{get;}
    string Name{get;set;}
    string PhoneNumber{get;set;}
    string Email{get;set;}
    string Password{get;set;}
    Rating Rating{get;set;}
    public abstract void Login();
    public abstract void ChangeUserData();
    public abstract void DeleteUser(User user);
    public abstract void CancelService(Service service);
}
