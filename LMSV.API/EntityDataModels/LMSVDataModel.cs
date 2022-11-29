using LMSV.API.Entities;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace LMSV.API.EntityDataModels
{
    public class LMSVDataModel
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "LMSV";
            builder.ContainerName = "LMSVContainer";

            builder.EntitySet<Card>("Cards");
            builder.EntitySet<Client>("Clients");
            builder.EntitySet<EmsUser>("EmsUsers");
            builder.EntitySet<GiftCardType>("GiftCardTypes");
            builder.EntitySet<Transaction>("Transactions");

            return builder.GetEdmModel();
        }
    }
}
