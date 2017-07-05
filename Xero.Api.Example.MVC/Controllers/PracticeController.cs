using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xero.Api.HQ.Model;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Example.MVC.Helpers;
using Xero.Api.Example.MVC.Models;
using Xero.Api.HQ;
using Xero.Api.HQ.Model.Types;
using Xero.Api.Infrastructure.Exceptions;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Example.MVC.Controllers
{
    public class PracticeController : Controller
    {
        private IXeroHQApi _api;

        public PracticeController()
        {
            _api = XeroApiHelper.HQApi();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new PracticeView();

            try
            {
                viewModel.Clients = _api.Clients.Find().ToList();
            }
            catch (RenewTokenException e)
            {
                return RedirectToAction("Connect", "Home");
            }
            catch (XeroHqApiException ex)
            {
                viewModel.Errors = ex.ValidationErrors;
            }

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(AlertView alertData)
        {
            var viewModel = new PracticeView();

            try
            {
                viewModel.Clients = _api.Clients.Find().ToList();

                var alert = new Alert
                {
                    Type = alertData.AlertType,
                    TargetType = "CLIENT",
                    TargetId = alertData.ClientId,
                    Access = new AlertAccess
                    {
                        To = AlertAccessTo.AllUsers
                    },
                    AdditionalData = new AlertDataTest
                    {
                        AppName = alertData.AppName,
                        Date = DateTime.UtcNow
                    },
                    Actions = new List<AlertAction>
                    {
                        new AlertAction
                        {
                            Label = alertData.ActionLabel,
                            Link = alertData.ActionLink
                        }
                    }
                };

                viewModel.Alert = _api.Create(alert);
            }
            catch (RenewTokenException e)
            {
                return RedirectToAction("Connect", "Home");
            }
            catch (XeroHqApiException ex)
            {
                viewModel.Errors = ex.ValidationErrors;
            }

            return View(viewModel);
        }
    }
}