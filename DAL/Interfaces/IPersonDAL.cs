﻿using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IPersonDAL
    {
        List<PersonDTO> GetAllPerson();
        PersonDTO GetPersonById(int personId);
        PersonDTO UpdatePerson(PersonDTO p);
        PersonDTO CreatPerson(PersonDTO p);
        void DeletePerson(int personId);
    }
}
