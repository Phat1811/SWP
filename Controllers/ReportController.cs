using MedicalStore.DAO.Interface;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStore.Controllers
{
    [Route("report")]
    public class ReportController : Controller
    {
        private readonly IReportService ReportService;
        private readonly IUserService UserService;
        private readonly IProductService ProductService;
        public ReportController(IReportService reportService, IUserService userService, IProductService productService)
        {
            this.ReportService = reportService;
            this.UserService = userService;
            this.ProductService = productService;
        }

        [HttpGet("create")]
        public IActionResult CreateReport(string ProductId)
        {
            var report = ReportService.GetReportByProductID(ProductId);
            var product = ProductService.GetProductById(ProductId);
            this.ViewData["product"] = product;
            this.ViewData["report"] = report;
            return View(Routers.Report.Page);
        }
    }
}
