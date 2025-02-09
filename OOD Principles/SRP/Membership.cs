using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.SRP
{

    public class Membership
    {
        private readonly EmailSender? _emailSender;
        private readonly EncriptionUtility _encryptionUtility;
        private readonly DataUtility _dataUtility;
        Membership()
        {
            _emailSender = new EmailSender();
            _encryptionUtility = new EncriptionUtility();
            _dataUtility = new DataUtility();
        }

        public void CreateAccount(string username,string password,string email)
        {
            if(!_dataUtility.CheckDuplicateEmail(username))
            {
                password = _encryptionUtility.EncryptPassword(password);
            }
            if (!_dataUtility.SaveAccount(username, email, password))
            {
                _emailSender.SendNewAccountEmail(email);
            }
        }
    }
}
