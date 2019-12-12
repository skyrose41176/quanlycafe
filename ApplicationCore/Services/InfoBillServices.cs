using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class InfoBillService : IInfoBillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InfoBillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateInfoBill(SaveInfoBillDto infoBillDto)
        {
           var info = _mapper.Map<SaveInfoBillDto,InfoBill>(infoBillDto);
            _unitOfWork.InfoBill.Add(info);
            _unitOfWork.Complete();
        }

        public void DeleteInfoBill(int id)
        {
            var info = _unitOfWork.InfoBill.GetPro(id);
            if (info != null)
            {
                _unitOfWork.InfoBill.Remove(info);
                _unitOfWork.Complete();
            }
        }

        public List<float> GetInfoBilla(int id)
        {
            return _unitOfWork.InfoBill.GetInfoBill(id);
        }
        public InfoBillDto GetInfoBill(int id)
        {
            var InfoBill = _unitOfWork.InfoBill.GetPro(id);
            return _mapper.Map<InfoBill, InfoBillDto>(InfoBill);
        }
        public IEnumerable<InfoBillDto> GetInfoBills(string searchString, int category, int pageIndex, int pageSize, out int count)
        {
            InfoBillSpecification InfoBillFilterPaginated = new InfoBillSpecification(searchString, category, pageIndex, pageSize);
            InfoBillSpecification InfoBillFilter = new InfoBillSpecification(searchString, category);

            var InfoBill = _unitOfWork.InfoBill.Find(InfoBillFilterPaginated);
            count = _unitOfWork.InfoBill.Count(InfoBillFilter);

            return _mapper.Map<IEnumerable<InfoBill>, IEnumerable<InfoBillDto>>(InfoBill);

        }

        public void UpdateInfoBill(SaveInfoBillDto infoBillDto)
        {
            throw new System.NotImplementedException();
        }
    }
}