using DTO;
using System.Collections.Generic;


namespace DAL.Interfaces
{
    public interface IRolesDAL
    {
        List<RolesDTO> GetAllRoles();
        RolesDTO GetRolesById(int rolesId);
        RolesDTO UpdateRoles(RolesDTO r);
        RolesDTO CreatRoles(RolesDTO r);
        void DeleteRoles(int rolesId);
    }
}
