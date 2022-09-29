using System; 

namespace Chatbot;

//           UML
// ---------------------------
// + Email : string
// + Pass : string
// ---------------------------
// + ValidateLogin()
// ---------------------------

public class Login
{
    string Email {get;set;}
    string Pass {get;set;}

    public Login(string Email, string Pass)
    {
        this.Email = Email;
        this.Pass = Pass;
    }


    public void ValidateLogin()
    {
        
    }
}