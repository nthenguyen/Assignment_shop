using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.ViewModels.Common
{
    public class PagedRequestBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
