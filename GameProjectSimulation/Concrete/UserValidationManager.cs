using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirsName == "Muzaffer" && gamer.LastName == "Balkan" && gamer.BirthYear == 2002 && gamer.IdentityNumber=="12345678910")
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
