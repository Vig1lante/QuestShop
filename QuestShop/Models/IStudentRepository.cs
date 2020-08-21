using System.Collections.Generic;

namespace QuestShop.Models
{
    public interface IStudentRepository
    {
        AppUser LoggedInUser { get; set; }
        double UserPoints { get; set; }
    }
}