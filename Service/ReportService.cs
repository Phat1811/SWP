using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils;
using System.Collections.Generic;

namespace MedicalStore.Service
{
    public class ReportService : IReportService
    {
        private readonly DBContext DBContext;
        private readonly IReportRepository ReportRepository;

        public ReportService(DBContext dBContext, IReportRepository reportRepository)
        {
            this.DBContext = dBContext;
            ReportRepository = reportRepository;
        }

        public bool CreateReportHandler(ReportTicket report)
        {
            return this.ReportRepository.CreateReportHandler(report);
        }

        public bool DeleteReportHandler(ReportTicket report)
        {
            return this.ReportRepository.DeleteReportHandler(report);
        }

        public List<ReportTicket> GetAllReprot()
        {
            return this.ReportRepository.GetAllReprot();
        }

        public List<ReportTicket> GetListReportByProductId(string productId)
        {
            return this.ReportRepository.GetListReportByProductId(productId);
        }

        public ReportTicket GetReportById(string id)
        {
            return this.ReportRepository.GetReportById(id);
        }

        public ReportTicket GetReportByProductID(string product)
        {
            return this.ReportRepository.GetReportByProductID(product);
        }

        public bool UpdateReportInfoHandler(ReportTicket report)
        {
            return this.ReportRepository.UpdateReportInfoHandler(report);
        }
    }
}
