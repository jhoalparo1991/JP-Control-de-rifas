using DataAccess;

namespace Domain
{
    public class N_Procesos
    {
        public static bool getConnectionTest()
        {
            return D_Procesos.getConnectionTest();
        }
     
    }
}
