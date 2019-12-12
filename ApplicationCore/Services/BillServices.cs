using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class BillService : IBillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<string> GetBill()
        {
            return _unitOfWork.Bill.GetBill();
        }
        public void CreateBill(SaveBillDto saveBillDto)
        {
            var Bill = _mapper.Map<SaveBillDto,Bill>(saveBillDto);
            _unitOfWork.Bill.Add(Bill);
            _unitOfWork.Complete();
        }
        public void DeleteBill(int id)
        {
            var Bill = _unitOfWork.Bill.GetPro(id);
            if (Bill != null)
            {
                _unitOfWork.Bill.Remove(Bill);
                _unitOfWork.Complete();
            }
        }
        public BillDto GetBill(int id)
        {
            var Bill = _unitOfWork.Bill.GetPro(id);
            return _mapper.Map<Bill, BillDto>(Bill);
        }
        public IEnumerable<BillDto> GetBills(string searchString, int category, int pageIndex, int pageSize, out int count)
        {
            
            BillSpecification BillFilterPaginated = new BillSpecification(searchString, category, pageIndex, pageSize);
            BillSpecification BillFilter = new BillSpecification(searchString, category);

            var Bill = _unitOfWork.Bill.Find(BillFilterPaginated);
            count = _unitOfWork.Bill.Count(BillFilter);

            return _mapper.Map<IEnumerable<Bill>, IEnumerable<BillDto>>(Bill);

        }

        public void UpdateBill(SaveBillDto saveBillDto)
        {
            var Bill = _unitOfWork.Bill.GetPro(saveBillDto.Id);
            if (Bill == null) return;
            _mapper.Map<SaveBillDto,Bill>(saveBillDto,Bill);
            _unitOfWork.Complete();
        }

        
    }
}