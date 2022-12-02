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
