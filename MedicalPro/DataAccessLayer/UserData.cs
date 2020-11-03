using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MedicalPro.DataAccessLayer
{
    public class UserData
    {
        private readonly MedicalProEntities _context;
        public static int UserId { get; set; }
        public UserData()
        {
            _context = new MedicalProEntities();
        }

        public  bool ValidateUser(string name,string password)
        {
            try
            {
                var user = _context.tblUsers.Where(x => x.UserName == name && x.Password == password && x.IsActive == true)
                                   .FirstOrDefault();
                UserId = user.UserId;
                if (user != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }
       

       
    }
}