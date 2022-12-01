using LMSV.API.STSModels;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace LMSV.API.EntityDataModels
{
    public class STSDataModel
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "STS";
            builder.ContainerName = "STSContainer";

            builder.EntitySet<STSAddress>("Addresses");
            builder.EntitySet<STSCard>("Cards");
            builder.EntitySet<STSCardOrder>("CardOrders");
            builder.EntitySet<STSCardTran>("CardTrans");
            builder.EntitySet<STSChain>("Chains");
            builder.EntitySet<STSClerk>("Clerks");
            //builder.EntitySet<Client>("Clients");
            //builder.EntitySet<EmsUser>("EmsUsers");
            //builder.EntitySet<GiftCardType>("GiftCardTypes");
            //builder.EntitySet<Store>("Stores");
            //builder.EntitySet<Transaction>("Transactions");

            return builder.GetEdmModel();
        }
    }
}
