using LMSV.API.Entities;
using LMSV.API.STSModels;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace LMSV.API.EntityDataModels
{
    public class ApiDataModel
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "Api";
            builder.ContainerName = "ApiContainer";

            //LMSV Reports Controller endpoints
            builder.EntitySet<Card>("Cards");
            builder.EntitySet<Client>("Clients");
            builder.EntitySet<EmsUser>("EmsUsers");
            builder.EntitySet<GiftCardType>("GiftCardTypes");
            builder.EntitySet<Store>("Stores");
            builder.EntitySet<Transaction>("Transactions");

            //STS Controller endpoints
            builder.EntitySet<STSAddress>("Addresses");
            builder.EntitySet<STSCard>("STSCards");
            builder.EntitySet<STSCardOrder>("CardOrders");
            builder.EntitySet<STSCardTran>("CardTrans");
            builder.EntitySet<STSChain>("Chains");
            builder.EntitySet<STSClerk>("Clerks");
            builder.EntitySet<STSMerchant>("Merchants");
            builder.EntitySet<STSProduct>("Products");
            builder.EntitySet<STSTerminal>("Terminals");
            builder.EntitySet<STSValidProduct>("ValidProducts");
            builder.EntitySet<STSVenue>("Venues");
            builder.EntitySet<STSWtConfig>("WtConfigs");
            builder.EntitySet<STSWtUser>("WtUsers");

            return builder.GetEdmModel();
        }
    }
}
