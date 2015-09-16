using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.Mobile.Services._001_Domain;
using AdventureWorks.Mobile.Services._002_Infra;

namespace AdventureWorks.Mobile.Services.Controllers
{
    public class AdventureWorksController : ApiController
    {
        public AuthenticationResult Authenticate(decimal mobileNumber, string password)
        {
            return new DbConnector().Authenticate(mobileNumber, password);
        }

        public UserProfile GetProfile(decimal userId)
        {
            return new DbConnector().GetProfile(userId);
        }

        public string Signup(decimal mobileNumber, string password, UserProfile profile)
        {

            return "success";
        }

        public OrderConfirmation SubmitOrder(decimal mobileNumber, Order order)
        {

        }
    }
}
