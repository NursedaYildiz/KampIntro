using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "NURSEDA" && gamer.LastName== "YILDIZ" && gamer.IdentityNumber== 123456789)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
