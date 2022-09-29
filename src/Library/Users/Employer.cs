using System; 

namespace Chatbot;

//           UML
// ------------------------
//
// ------------------------
// + SearchService()
// + ViewProfile(user)
// + RateWorker(user)
// ------------------------

public class Employer : User
{
    int ID{get;}
    string Name{get;set;}
    string PhoneNumber{get;set;}
    string Email{get;set;}
    string Password{get;set;}
    Rating Rating{get;set;}

    public Employer(string name, string phoneNumber, string email, string password)
    {
        this.ID = 0;
        this.Name = name;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Password = password;
        this.Rating = new Rating();
    }
    public string ViewProfile(User user){return "";}
    public int RateWorker(User user){return 0;}
    public override void CancelService(Service service)
    {}
    public void SearchService(Service service){}
    public override void DeleteUser(User user)
    {}
    public override void ChangeUserData()
    {}
    public override void Login()
    {}
    
}