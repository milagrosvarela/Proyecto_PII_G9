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

// La clase Employer permite que los empleadores puedan buscar un servicio, contactarse con el trabajador y 
// calificarlo en cuanto a su desempeño. 

public class Employer : User
{
    public int Rate{get;set;}
    public void SearchService()
    {

    }
    public void ViewProfile(User user)
    {
        
    }
    public void RateWorker(User user)
    {
        
    }
    public override void CancelService(Service service)
    {
        
    }
    public void RateWorker(Rating rating)
    {
        
    }
    public override void DeleteUser(User user)
    {
        
    }
    public override void ChangeUserData()
    {
        
    }
    public override void Login()
    {
        
    }
}