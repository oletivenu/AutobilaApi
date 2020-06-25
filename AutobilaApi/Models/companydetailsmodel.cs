using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace AutobilaApi.Models
{
    public class companymethodmodel
    {
        
        //public string DataTableToJSON(DataTable table)
        //{
        //    string JSONString = string.Empty;
        //    JSONString = JsonConvert.SerializeObject(table);
        //    return JSONString;
        //}
        public string GetCompanyDetails(string license_no)
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = null;

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("license_no",license_no),
                };

                ds = dbo.RunProcedure("usp_Company_Details", parameters, "usp_Company_Details");

                if (ds != null && ds.Tables[0] != null)
                {
                    return common.DatatableToJson(ds.Tables[0]);
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dbo = null;

            }
        }
    }
}