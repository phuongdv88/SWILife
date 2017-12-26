using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SWIDAL;
using SWIBLL.Models;

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
            //todo
            return true;
        }

        public static bool updateJobOrder(int jobOrderId)
        {
            //todo
            return true;
        }

        public static bool deleteJobOrder(int jobOrderId)
        {
            //todo
            return true;
        }

        public static JobOrder getJobOrder(int id)
        {

            JobOrder job = null;
            DataTable tbl = DataAccess.Instance.getJobOrderById(id);
            if (tbl.Rows.Count > 0)
            {
                DataRow datarow = tbl.Rows[0];
                job = Data.CreateItemFromRow<JobOrder>(datarow);
            }
            return job;
        }

        public static bool updateAttactmentLink(JobOrder jobOrder)
        {
            string sql = string.Format("UPDATE `swilifecore`.`joborder` SET `AttachmentLink`='{0}' WHERE `JobOrderId`='{1}'", QueryBuilder.mySqlEscape(jobOrder.AttachmentLink), jobOrder.JobOrderId);
            int result = DataAccess.Instance.executeNonQuery(sql);
            return result > 0 ? true : false;
        }

    }
}
