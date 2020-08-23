﻿using System.Collections.Generic;

namespace QuestShop.Models
{
    public interface IStudentRepository
    {
        AppUser LoggedInUser { get; }
        double UserPoints { get; set; }
        ModelEnums.UserRank UserRank { get; set; }
        ModelEnums.UserType UserType { get; set; }

    }
}