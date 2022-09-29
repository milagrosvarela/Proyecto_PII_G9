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
<<<<<<< HEAD
    string Name{get;set;}
=======
    string Name{set; get;}
>>>>>>> b42d16f7c53ab01abc456bc317836a86c71ffc4e
    int PhoneNumber{get;set;}
    string Email{get;set;}
    string Password{get;set;}
    Rating Rating{get;set;}

<<<<<<< HEAD
    public abstract void Login();
=======
    public abstract void Login(Login login);
>>>>>>> b42d16f7c53ab01abc456bc317836a86c71ffc4e
    public abstract void ChangeUserData();
    public abstract void DeleteUser(User user);
    public abstract void CancelService(Service service);
}
