using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.OCP
{
    public interface IEncryptionProcess
    {
        public string EncryptPassword(string password);
    }
}
