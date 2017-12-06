using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SWIDAL;

namespace SWIBLL
{
    public class JobOrderManager
    {
        public static DataTable getJobOrders()
        {
            return DataAccess.Instance.getJobOrders();
        }

        public static bool createJobOrder()
        {
            return true;
        }

        public static bool updateJobOrder(int jobOrderId)
        {
            return true;
        }

        public static bool deleteJobOrder(int jobOrderId)
        {
            return true;
        }
    }
}
