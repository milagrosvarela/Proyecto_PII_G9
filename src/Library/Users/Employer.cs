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
    public int Rate{get;set;}
    public string SearchService{get;set;}
    public string ViewProfile(User user){return "";}
    public int RateWorker(User user){return Rate;}

    public override void CancelService(Service service){
        
    }
    public override void RateWorker(Rating rating){
        
    }
}