using System.Collections.Generic;

namespace QuestShop.Models
{
    public interface IStudentRepository
    {
        AppUser LoggedInUser { get; }
        double UserPoints { get; set; }
    }
}