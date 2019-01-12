using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //we grab all of the requirements from IProductModel interface
    //plus we add extra to DigitalProduct because it needs totalDownloads
    //then when THIS interface is inhereted, it will force to make everything from
    //IProductModel AND everything set out here
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
