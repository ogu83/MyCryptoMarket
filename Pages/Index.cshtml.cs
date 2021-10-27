using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyCryptoMarket.Data;
using MyCryptoMarket.Models;

namespace MyCryptoMarket.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CryptoMarketContext _context;
        private readonly MvcOptions _mvcOptions;

        public IndexModel(
            ILogger<IndexModel> logger,
            CryptoMarketContext context, 
            IOptions<MvcOptions> mvcOptions)
        {
            _logger = logger;
            _context = context;
            if (mvcOptions != null)
            {
                _mvcOptions = mvcOptions.Value;
            }
        }

        public void OnGet()
        {
            var query = _context.Tickers.ToList();
            var myQuery = query.Where(x => x.WeightedAvgPrice > 0);
            var tickers = Newtonsoft.Json.JsonConvert.SerializeObject((myQuery.ToList()));
            ViewData["Tickers"] = tickers;
        }

        public IActionResult OnGet24hTickers(DxGridRequest args)
        {
            var query = _context.Tickers.AsQueryable();
            var totalCount = query.Count();

            if (args.sort != null)
            {
                //TODO: Sort Here
            }

            if (args.take > 0)
            {
                query = query.Take(args.take);
            }

            if (args.skip > 0)
            {
                query = query.Skip(args.skip);
            }

            var tickers = query.ToList();
            var model = new DxGridResponse<Models.Ticker>(tickers, totalCount);
            var retval = new JsonResult(model);
            return retval;
        }
    }
}