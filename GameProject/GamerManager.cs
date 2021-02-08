using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız...");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi.");
        }
    }
}
