using System; 

namespace Chatbot;

//           UML
// ---------------------------
// 
// ---------------------------
// + SaveData()
// + ValidateData()
// ---------------------------

public class Register
{
    public void SaveData()
    {
        
    }
    public void ValidateData()
    {
        Validation.ValidateName();
        Validation.ValidateEmail();
        Validation.ValidatePhoneNumber();
    }

}