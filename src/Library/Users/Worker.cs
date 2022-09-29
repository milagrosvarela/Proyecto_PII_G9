using System;

namespace Chatbot;

//             UML
// --------------------------
// + Services : List<service>
// --------------------------
// + NewService()
// + ViewProfile(user)
// + RateEmployer(user)
// --------------------------

public class Worker : User
{
    int ID { get; }
    string Name { get; set; }
    string PhoneNumber { get; set; }
    string Email { get; set; }
    string Password { get; set; }
    Rating Rating { get; set; }

    public Worker(string name, string phoneNumber, string email, string password)
    {
        this.ID = 0;
        this.Name = name;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Password = password;
        this.Rating = new Rating();
    }
    public List<Service> Services= new List<Service>{};
    public override void Login()
    {

    }
    public override void ChangeUserData()
    {

    }
    public override void DeleteUser(User user)
    {

    }
    public override void CancelService(Service service)
    {

    }
    
    public void NewService()
    {

    }
    public void ViewProfile(User user)
    {

    }
    public void RateEmployer(User user)
    {

    }
}