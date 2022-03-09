using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IActionResult CreateReport(string productId)
        {
            var report = ReportService.GetReportByProductID(productId);
            var product = ProductService.GetProductById(productId);
            this.ViewData["product"] = product;
            this.ViewData["report"] = report;
            return View(Routers.Report.Page);
        }

        [HttpGet("detail")]
        public IActionResult ReportDetail(string productId)
        {
            var listReportByProductId = (List<ReportTicket>)ReportService.GetListReportByProductId(productId);
            var product = ProductService.GetProductById(productId);
            this.ViewData["product"] = product;
            this.ViewData["listReportByProductId"] = listReportByProductId;
            return View(Routers.ReportList.Page);
        }
    }
}
