using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AutobilaApi.Models
{
    public class autobila
    {
        public static List<ColorMaster> ColorMaster_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<ColorMaster> modellist = new List<ColorMaster>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_ColorMaster", parameters, "ColorMaster");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ColorMaster model = new ColorMaster();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.ColorName = Convert.ToString(dr["ColorName"]);
                        model.ColorCode = Convert.ToString(dr["ColorCode"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<AutoAttachments> AutoAttachments_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<AutoAttachments> modellist = new List<AutoAttachments>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_AutoAttachments", parameters, "AutoAttachments");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        AutoAttachments model = new AutoAttachments();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.AutoInfoId = Convert.ToInt32(dr["AutoInfoId"]);
                        model.FileName = Convert.ToString(dr["FileName"]);
                        model.FileType = Convert.ToString(dr["FileType"]);
                        model.FileContent = Convert.ToString(dr["FileContent"]);
                        model.FileDesc = Convert.ToString(dr["FileDesc"]);
                        model.FilePath = Convert.ToString(dr["FilePath"]);
                        model.FolderPath = Convert.ToString(dr["FolderPath"]);
                        model.FileContent = Convert.ToString(dr["FileContent"]);
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<AutoFeatures> AutoFeatures_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<AutoFeatures> modellist = new List<AutoFeatures>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_AutoFeatures", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        AutoFeatures model = new AutoFeatures();
                        model.Id = Convert.ToInt64(dr["Id"]);
                        model.AutoMakeId = Convert.ToInt32(dr["AutoMakeId"]);
                        model.AutoModelId = Convert.ToInt32(dr["AutoModelId"]);
                        model.InteriorDesign = Convert.ToString(dr["InteriorDesign"]);
                        model.SpecialFeatures = Convert.ToString(dr["SpecialFeatures"]);
                        model.ExteriorFeatures = Convert.ToString(dr["ExteriorFeatures"]);
                        model.SecurityEnvironment = Convert.ToString(dr["SecurityEnvironment"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        model.CreatedBy = Convert.ToString(dr["CreatedBy"]);
                        if (dr["UpdatedDateTime"] != DBNull.Value)
                        {
                            model.UpdatedDateTime = Convert.ToDateTime(dr["UpdatedDateTime"]);
                        }
                        model.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
                        model.ModelDescription = Convert.ToString(dr["ModelDescription"]);
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<AutoInfoMaster> AutoInfoMaster_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            List<AutoInfoMaster> modellist = new List<AutoInfoMaster>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_AutoInfoMaster", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        AutoInfoMaster model = new AutoInfoMaster();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.AutoDealerId = Convert.ToInt32(dr["AutoDealerId"]);
                        model.AutoDealerName = Convert.ToString(dr["AutoDealerName"]);
                        model.AutoName = Convert.ToString(dr["AutoName"]);
                        model.AutoDescription = Convert.ToString(dr["AutoDescription"]);
                        model.AutoLocation = Convert.ToString(dr["AutoLocation"]);
                        model.AutoMake = Convert.ToString(dr["AutoMake"]);
                        model.AutoModel = Convert.ToString(dr["AutoModel"]);
                        model.Price = Convert.ToString(dr["Price"]);
                        model.Year = Convert.ToInt32(dr["Year"]);
                        model.Kilometers = Convert.ToInt32(dr["Kilometers"]);
                        model.AutoType = Convert.ToString(dr["AutoType"]);
                        model.Color = Convert.ToString(dr["Color"]);
                        model.InteriorColor = Convert.ToString(dr["InteriorColor"]);
                        model.GearBox = Convert.ToString(dr["GearBox"]);
                        model.Seats = Convert.ToInt32(dr["Seats"]);
                        model.Specs = Convert.ToString(dr["Specs"]);
                        model.Doors = Convert.ToInt32(dr["Doors"]);
                        model.Cylinders = Convert.ToInt32(dr["Cylinders"]);
                        model.Wheels = Convert.ToInt32(dr["Wheels"]);
                        model.FuelType = Convert.ToString(dr["FuelType"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        model.CreatedBy = Convert.ToString(dr["CreatedBy"]);
                        if (dr["UpdatedDateTime"] != DBNull.Value)
                        {
                            model.UpdatedDateTime = Convert.ToDateTime(dr["UpdatedDateTime"]);
                        }
                        model.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
                        model.FirstImage = Convert.ToString(dr["FirstImage"]);
                        model.DealerImage = Convert.ToString(dr["DealerImage"]);
                        model.AutoFeatures = Convert.ToString(dr["AutoFeatures"]);
                        model.AutoLatitude = Convert.ToString(dr["AutoLatitude"]);
                        model.AutoLongitude = Convert.ToString(dr["AutoLongitude"]);
                        model.AutoMakeId = Convert.ToInt32(dr["AutoMakeId"]);
                        model.Comments = Convert.ToString(dr["Comments"]);
                        model.AutoModelId = Convert.ToInt32(dr["AutoModelId"]);
                        model.AutoFolderPath = Convert.ToString(dr["AutoFolderPath"]);
                        model.Condition = Convert.ToString(dr["Condition"]);
                        model.AutoTypeId = Convert.ToInt32(dr["AutoTypeId"]);
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (ds != null)
                {
                    ds.Dispose();
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<AutoMakeMaster> AutoMakeMaster_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<AutoMakeMaster> modellist = new List<AutoMakeMaster>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_AutoMakeMaster", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        AutoMakeMaster model = new AutoMakeMaster();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.AutoMakeName = Convert.ToString(dr["AutoMakeName"]);
                        model.AutoMakeCode = Convert.ToString(dr["AutoMakeCode"]);
                        model.AutoMakeDescription = Convert.ToString(dr["AutoMakeDescription"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        
                        if (dr["UpdatedDateTime"] != DBNull.Value)
                        {
                            model.UpdatedDateTime = Convert.ToDateTime(dr["UpdatedDateTime"]);
                        }
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<AutoModelMaster> AutoModelMaster_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<AutoModelMaster> modellist = new List<AutoModelMaster>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_AutoModelMaster", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        AutoModelMaster model = new AutoModelMaster();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.AutoMakeMasterId = Convert.ToInt32(dr["AutoMakeMasterId"]);
                        model.AutoModelName = Convert.ToString(dr["AutoModelName"]);
                        model.AutoModelCode = Convert.ToString(dr["AutoModelCode"]);
                        model.AutoModelDescription = Convert.ToString(dr["AutoModelDescription"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        
                        if (dr["UpdatedDateTime"] != DBNull.Value)
                        {
                            model.UpdatedDateTime = Convert.ToDateTime(dr["UpdatedDateTime"]);
                        }
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<AutoTypeMaster> AutoTypeMaster_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<AutoTypeMaster> modellist = new List<AutoTypeMaster>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_AutoTypeMaster", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        AutoTypeMaster model = new AutoTypeMaster();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.AutoTypeName = Convert.ToString(dr["AutoTypeName"]);
                        model.AutoTypeCode = Convert.ToString(dr["AutoTypeCode"]);
                        model.AutoTypeDescription = Convert.ToString(dr["AutoTypeDescription"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        
                        if (dr["UpdatedDateTime"] != DBNull.Value)
                        {
                            model.UpdatedDateTime = Convert.ToDateTime(dr["UpdatedDateTime"]);
                        }
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<DealerAttachments> DealerAttachments_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<DealerAttachments> modellist = new List<DealerAttachments>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_DealerAttachments", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DealerAttachments model = new DealerAttachments();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.FileName = Convert.ToString(dr["FileName"]);
                        model.FileType = Convert.ToString(dr["FileType"]);
                        model.FileContent = Convert.ToString(dr["FileContent"]);
                        model.FileDesc = Convert.ToString(dr["FileDesc"]);
                        model.FilePath = Convert.ToString(dr["FilePath"]);
                        model.DealerInfoId = Convert.ToInt32(dr["DealerInfoId"]);
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
        public static List<DealersInfoMaster> DealersInfoMaster_selectall()
        {
            SQLHelper dbo = new SQLHelper();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<DealersInfoMaster> modellist = new List<DealersInfoMaster>();

            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("action","selectall"),
                };

                ds = dbo.RunProcedure("usp_DealersInfoMaster", parameters, "AutoFeatures");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DealersInfoMaster model = new DealersInfoMaster();
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.FirstName = Convert.ToString(dr["FirstName"]);
                        model.LastName = Convert.ToString(dr["LastName"]);
                        model.CompanyName = Convert.ToString(dr["CompanyName"]);
                        model.ContactPerson = Convert.ToString(dr["ContactPerson"]);
                        model.Email = Convert.ToString(dr["Email"]);
                        model.Telephone = Convert.ToString(dr["Telephone"]);
                        model.TradeLicense = Convert.ToString(dr["TradeLicense"]);
                        model.Password = Convert.ToString(dr["Password"]);
                        model.DealerImage = Convert.ToString(dr["DealerImage"]);
                        model.Comments = Convert.ToString(dr["Comments"]);
                        model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        if (dr["CreatedDateTime"] != DBNull.Value)
                        {
                            model.CreatedDateTime = Convert.ToDateTime(dr["CreatedDateTime"]);
                        }
                        model.CreatedBy = Convert.ToString(dr["CreatedBy"]);
                        if (dr["UpdatedDateTime"] != DBNull.Value)
                        {
                            model.UpdatedDateTime = Convert.ToDateTime(dr["UpdatedDateTime"]);
                        }
                        model.UpdatedBy = Convert.ToString(dr["UpdatedBy"]);
                        if (dr["IsConfirm"] != DBNull.Value)
                        {
                            model.IsConfirm = Convert.ToBoolean(dr["IsConfirm"]);
                        }
                        modellist.Add(model);
                    }
                }
                return modellist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error Occured in " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString() + " Error Message: " + ex.Message);
            }
            finally
            {

                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }

                if (modellist != null)
                {
                    modellist = null;
                }


            }
        }
    }
}