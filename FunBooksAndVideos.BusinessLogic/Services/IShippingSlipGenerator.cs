using System.Collections.Generic;
using FunBooksAndVideos.BusinessEntities.Models;

namespace FunBooksAndVideos.BusinessLogic.Services
{
    public interface IShippingSlipGenerator
    {
        long? Generate(IEnumerable<PhysicalProduct> physicalProducts);
    }
}