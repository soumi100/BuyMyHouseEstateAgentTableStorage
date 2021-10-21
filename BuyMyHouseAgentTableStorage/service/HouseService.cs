using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMyHouseAgentTableStorage.service
{
    public class HouseService
    {
        public UnitOfWork _unitOfWork { get; set; }

        public HouseService()
        {
            _unitOfWork = new UnitOfWork("test001");
        }
        public void insert(House house)
        {
            //House house = new House()
            //{
            //    City = "den haag",
            //    NbrRooms = 5,
            //    Price = 5000,
            //    Id = 2,
            //    status =Status.forSale
            //};
            _unitOfWork.HouseRepository.Insert(house);
        }
    }
}
