using System.Collections.Generic;
using FunBooksAndVideos.BusinessEntities.Models;

namespace FunBooksAndVideos.BusinessLogic.Models
{
    public interface IPurchaseOrder
    {
        Customer Customer { get; }
        long Id { get; }
        IEnumerable<Product> LineItems { get; }
        decimal TotalPrice { get; }

        long? Process();
    }
}