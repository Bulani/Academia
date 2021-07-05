using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Principal.AppCode.DAL;

namespace Principal.AppCode.ClassesControle
{
    public class BackupControle
    {
        public string ExecutarBakcup(string caminhoComNome)
        { 
            BackupDAL backDAL = new BackupDAL();
            return backDAL.ExecutarBakcup(caminhoComNome);
        }


    }
}
