using System.Collections.Generic;
using FunBooksAndVideos.BusinessEntities.Models;

namespace FunBooksAndVideos.BusinessLogic.Services
{
    public class ShippingSlipGenerator : IShippingSlipGenerator
    {
        public long? Generate(IEnumerable<PhysicalProduct> physicalProducts)
        {
            throw new System.NotImplementedException();
        }
    }
}