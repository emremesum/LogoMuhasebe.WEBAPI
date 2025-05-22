using LogoMuhasebeApp.Domain.Entities;

namespace LogoMuhasebeApp.Infrastructure.Repositories
{
    public class LoginRepository
    {
        private static readonly List<Login> Users = new()
        {
            new Login { Username = "admin", Password = "admin", FirmNr = "3" ,PeriodNr =1},
            new Login { Username = "okyanus", Password = "okyanus", FirmNr = "3" ,PeriodNr =3 }
        };

        public Login GetUser(string username, string password,string firmNr,int periodNr)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
