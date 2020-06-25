using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutobilaApi.Models;

namespace AutobilaApi.Controllers.api
{
    public class AutobilaController : ApiController
    {
        [HttpPost]
        [Route("api/colormaster")]
        public async Task<object> colormaster()
        {
            List<ColorMaster> modellist = new List<ColorMaster>();
            try
            {
                modellist = autobila.ColorMaster_selectall();
                return Request.CreateResponse(HttpStatusCode.OK,modellist);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/autoattachments")]
        public List<AutoAttachments> autoattachments()
        {
            List<AutoAttachments> modellist = new List<AutoAttachments>();
            try
            {
                modellist = autobila.AutoAttachments_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/autofeatures")]
        public List<AutoFeatures> autofeatures()
        {
            List<AutoFeatures> modellist = new List<AutoFeatures>();
            try
            {
                modellist = autobila.AutoFeatures_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/autoinfomaster")]
        public List<AutoInfoMaster> autoinfomaster()
        {
            List<AutoInfoMaster> modellist = new List<AutoInfoMaster>();
            try
            {
                modellist = autobila.AutoInfoMaster_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/automakemaster")]
        public List<AutoMakeMaster> automakemaster()
        {
            List<AutoMakeMaster> modellist = new List<AutoMakeMaster>();
            try
            {
                modellist = autobila.AutoMakeMaster_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/automodelmaster")]
        public List<AutoModelMaster> automodelmaster()
        {
            List<AutoModelMaster> modellist = new List<AutoModelMaster>();
            try
            {
                modellist = autobila.AutoModelMaster_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/autotypemaster")]
        public List<AutoTypeMaster> autotypemaster()
        {
            List<AutoTypeMaster> modellist = new List<AutoTypeMaster>();
            try
            {
                modellist = autobila.AutoTypeMaster_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/dealerattachments")]
        public List<DealerAttachments> dealerattachments()
        {
            List<DealerAttachments> modellist = new List<DealerAttachments>();
            try
            {
                modellist = autobila.DealerAttachments_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
        [HttpPost]
        [Route("api/dealersinfomaster")]
        public List<DealersInfoMaster> dealersinfomaster()
        {
            List<DealersInfoMaster> modellist = new List<DealersInfoMaster>();
            try
            {
                modellist = autobila.DealersInfoMaster_selectall();
                return modellist;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(
            Request.CreateErrorResponse(HttpStatusCode.NotFound, ex));
            }

        }
    }
}
