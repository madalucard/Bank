using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Repositories
{
    public sealed class RepositrorySingleton
    {
        public static readonly string CONECTION_STRING = "Server=TRANSFORMER3\\SQLEXPRESS2016;Database=Bank;Trusted_Connection=True;";

        static RepositrorySingleton()
        {
        }
        private RepositrorySingleton()
        {
        }
        public static RepositrorySingleton Instance
        {
            get
            {
                return CONECTION_STRING;
            }
        }
    }
}
