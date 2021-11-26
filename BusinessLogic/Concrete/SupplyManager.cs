using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Concrete
{
    public class SupplyManager : ISupplyManager
    {
        private readonly ICategoryDAL _categoryDAL;
        private readonly IRolesDAL _rolesDAL;
        private readonly ISupplyDAL _supplyDAL;

        public SupplyManager(ICategoryDAL categoryDAL, IPersonDAL personDAL, IRolesDAL rolesDAL, ISupplyDAL supply)
        {
            _categoryDAL = categoryDAL;
            _rolesDAL = rolesDAL;
            _supplyDAL = supply;
        }

        public SupplyDTO AddSupply(SupplyDTO supply)
        {
            return _supplyDAL.CreatSupply(supply);
        }

        public void DeleteSupply(int supplyId)
        {
            _supplyDAL.DeleteSupply(supplyId);
        }

        public List<CategoryDTO> GetListOfCategory()
        {
            return _categoryDAL.GetAllCategory();
        }

        public List<RolesDTO> GetListOfRoles()
        {
            return _rolesDAL.GetAllRoles();
        }

        public List<SupplyDTO> GetListOfSupply()
        {
            return _supplyDAL.GetAllSupply();
        }

        public List<SupplyDTO> GetSort() //sort price
        {
            List<SupplyDTO> price = _supplyDAL.GetAllSupply().OrderBy(p => p.PriceUnit).ToList(); 
            return price;
        }

        public SupplyDTO GetSupplyById(int supplyID)
        {
            return _supplyDAL.GetSupplyById(supplyID);
        }

        public List<SupplyDTO> SearchGoodsByCategory(int id) 
        {
            return _supplyDAL.GetSupplyByIdCategory(id);
        }

        public SupplyDTO UpdateSupply(SupplyDTO s, int id)
        {
            return _supplyDAL.UpdateSupply(s, id);
        }
    }
}
