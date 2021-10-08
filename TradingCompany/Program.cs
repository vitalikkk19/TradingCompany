using DAL.ADO;
using DTO;
using System;
using System.Configuration;

namespace TradingCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        public static void ShowMenu()
        {
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var supplyDal = new SupplyDAL(connStr);
            var rolesDal = new RolesDAL(connStr);
            var categoryDal = new CategoryDAL(connStr);
            var personDal = new PersonDAL(connStr);

            while (true)
            {
                Console.WriteLine(@"
            TRAIDING COMPANY - Goods receiver.
        1 - CREATE
        2 - READ
        3 - UPDATE
        4 - DELETE
        0 - return

");
                string f = Console.ReadLine();
                Console.WriteLine("\t");

                switch (f)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine(@"
                     CREATE:
                1 - Category
                2 - Person
                3 - Roles
                4 - Supply
                0 - return
                E - Exit

");
                            string c = Console.ReadLine();
                            Console.WriteLine("\t");
                            switch (c)
                            {
                                case "1":
                                    CreateCategory(categoryDal);
                                    break;
                                case "2":
                                    CreatePerson(personDal);
                                    break;
                                case "3":
                                    CreateRoles(rolesDal);
                                    break;
                                case "4":
                                    CreateSupply(supplyDal);
                                    break;
                                case "0":
                                    ShowMenu();
                                    break;
                                case "E":
                                    return;
                            }
                        }
                    case "2":
                        while (true)
                        {
                            Console.WriteLine(@"
                     READ:
                1 - Category
                2 - Person
                3 - Roles
                4 - Supply
                0 - return
                E - Exit
");
                            string r = Console.ReadLine();
                            Console.WriteLine("\t");
                            switch (r)
                            {
                                case "1":
                                    GetAllCategory(categoryDal);
                                    break;
                                case "2":
                                    GetAllPerson(personDal);
                                    break;
                                case "3":
                                    GetAllRoles(rolesDal);
                                    break;
                                case "4":
                                    GetAllSupply(supplyDal);
                                    break;
                                case "0":
                                    ShowMenu();
                                    break;
                                case "E":
                                    return;
                            }
                        }

                    case "3":
                        while (true)
                        {
                            Console.WriteLine(@"
                     UPDATE:
                1 - Category
                2 - Person
                3 - Roles
                4 - Supply
                0 - return
                E - Exit

");
                            string u = Console.ReadLine();
                            Console.WriteLine("\t");
                            switch (u)
                            {
                                case "1":
                                    UpdateCategory(categoryDal);
                                    break;
                                case "2":
                                    UpdatePerson(personDal);
                                    break;
                                case "3":
                                    UpdateRoles(rolesDal);
                                    break;
                                case "4":
                                    UpdateSupply(supplyDal);
                                    break;
                                case "0":
                                    ShowMenu();
                                    break;
                                case "E":
                                    return;
                            }
                        }
                    case "4":
                        while (true)
                        {


                            Console.WriteLine(@"
                     DELETE:
                1 - Category
                2 - Person
                3 - Roles
                4 - Supply
                0 - return
                E - Exit

");
                            string d = Console.ReadLine();
                            Console.WriteLine("\t");
                            switch (d)
                            {
                                case "1":
                                    DeleteCategory(categoryDal);
                                    break;
                                case "2":
                                    DeletePerson(personDal);
                                    break;
                                case "3":
                                    DeleteRoles(rolesDal);
                                    break;
                                case "4":
                                    DeleteSupply(supplyDal);
                                    break;
                                case "0":
                                    ShowMenu();
                                    break;
                                case "E":
                                    return;
                            }
                        }
                    case "0":
                        return;

                }

            }
        }

        private static void UpdateSupply(SupplyDAL supplyDal)
        {
            Console.WriteLine("Updating supply");
            Console.WriteLine("Input SupplyID: ");
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var supDal = new SupplyDAL(connStr);
            Program.GetAllSupply(supDal);

            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids);

            SupplyDTO mySupply = supplyDal.GetSupplyById(id);

            if (mySupply is null)
            {
                Console.WriteLine("Invalid input!\n");
                return;
            }

            Console.WriteLine("~ Updating Supply:",
            mySupply.ID_Person,
            mySupply.ID_Category,
            mySupply.NameGoods,
            mySupply.Number,
            mySupply.PriceUnit
            );
            try
            {
                while (true)
                {
                    Console.WriteLine(@"
        1 - update Id_Person
        2 - update ID_Category
        3 - update name goods
        4 - update number
        5 - update price unit

");

                    string m = Console.ReadLine();
                    Console.WriteLine("\t");
                    switch (m)
                    {
                        case "1":
                            {
                                Console.WriteLine("Input PersonID: ");
                                var perDal = new PersonDAL(connStr);
                                Program.GetAllPerson(perDal);

                                string idst = Console.ReadLine();
                                int idr = Convert.ToInt32(ids);
                                mySupply.ID_Person = idr;
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Input CategoryID: ");
                                var catDal = new CategoryDAL(connStr);
                                Program.GetAllCategory(catDal);

                                string idst = Console.ReadLine();
                                int idr = Convert.ToInt32(ids);
                                mySupply.ID_Category = idr;
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Input new Name goods: ");
                                mySupply.NameGoods = Console.ReadLine();
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Input new number: ");
                                string b = Console.ReadLine();
                                mySupply.Number = Convert.ToInt32(b);
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Input new price unit: ");
                                string b = Console.ReadLine();
                                mySupply.PriceUnit = Convert.ToInt32(b); break;
                            }

                        case "0": return;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("ERROR.");
            }
        }

        private static void UpdatePerson(PersonDAL personDal)
        {
            Console.WriteLine("Updating person");
            Console.WriteLine("Input PersonID: ");
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var perDal = new PersonDAL(connStr);
            Program.GetAllPerson(perDal);

            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids);

            PersonDTO myPerson = personDal.GetPersonById(id);

            if (myPerson is null)
            {
                Console.WriteLine("Invalid input!\n");
                return;
            }

            Console.WriteLine("~ Updating Person:",
            myPerson.ID_Role,
            myPerson.FirstName,
            myPerson.LastName,
            myPerson.Login,
            myPerson.Password
            );
            try
            {
                while (true)
                {
                    Console.WriteLine(@"
        1 - update Id_Role
        2 - update FirsName
        3 - update LastName
        4 - update Login
        5 - update Password

");

                    string m = Console.ReadLine();
                    Console.WriteLine("\t");
                    switch (m)
                    {
                        case "1":
                            Console.WriteLine("Input RolesID: ");
                            var rolDal = new RolesDAL(connStr);
                            Program.GetAllRoles(rolDal);

                            string idst = Console.ReadLine();
                            int idr = Convert.ToInt32(ids);
                            myPerson.ID_Role = idr;                     
                                break;
                        case "2":
                            {
                                Console.WriteLine("Input new First Name: ");
                                myPerson.FirstName = Console.ReadLine();
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Input new Last Name: ");
                                myPerson.LastName = Console.ReadLine();
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Input new Login: ");
                                myPerson.Login = Console.ReadLine();
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Input new Password: ");
                                myPerson.Password = Console.ReadLine();
                                break;
                            }

                        case "0": return;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("ERROR.");
            }
        }

        private static void DeleteSupply(SupplyDAL supplyDal)
        {
            Console.WriteLine("Deleting Supply");
            Console.WriteLine("Input SupplyID: ");
            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids); supplyDal.DeleteSupply(id);
            Console.WriteLine("Successfully deleted");
        }

        private static void DeletePerson(PersonDAL personDal)
        {
            Console.WriteLine("Deleting Person");
            Console.WriteLine("Input PersonID: ");
            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids); personDal.DeletePerson(id);
            Console.WriteLine("Successfully deleted");
        }

        private static void DeleteRoles(RolesDAL rolesDal)
        {
            Console.WriteLine("Deleting Role");
            Console.WriteLine("Input RoleID: ");
            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids); rolesDal.DeleteRoles(id);
            Console.WriteLine("Successfully deleted");
        }

        private static void DeleteCategory(CategoryDAL categoryDal)
        {
            Console.WriteLine("Deleting Category");
            Console.WriteLine("Input CategoryID: ");
            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids); categoryDal.DeleteCategory(id);
            Console.WriteLine("Successfully deleted");
        }

        private static void UpdateRoles(RolesDAL rolesDal)
        {
            Console.WriteLine("Updating role");
            Console.WriteLine("Input RoleID: ");
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var rolDal = new RolesDAL(connStr);
            Program.GetAllRoles(rolDal);

            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids);

            RolesDTO myRoles = rolesDal.GetRolesById(id);

            if (myRoles is null)
            {
                Console.WriteLine("Invalid input!\n");
                return;
            }

            Console.WriteLine("~ Updating Role:",
            myRoles.RoleName);
            try
            {
                Console.WriteLine("Input Role new Name: ");
                myRoles.RoleName = Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("ERROR.");
            }
        }

        private static void UpdateCategory(CategoryDAL categoryDal)
        {
            Console.WriteLine("Updating Category");
            Console.WriteLine("Input CategoryID: ");
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var catDal = new CategoryDAL(connStr);
            Program.GetAllCategory(catDal);

            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids);

            CategoryDTO myCategory = categoryDal.GetCategoryById(id);

            if (myCategory is null) 
            {
                Console.WriteLine("Invalid input!\n");
                return;
            }

           Console.WriteLine("~ Updating Category:",
           myCategory.CategoryName);
            try
            {
                Console.WriteLine("Input Category new Name: ");
                myCategory.CategoryName = Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("ERROR.");
            }
            
        }

        private static void CreateSupply(SupplyDAL supplyDal)
        {
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var personDal = new PersonDAL(connStr);
            var categoryDal = new CategoryDAL(connStr);

            Console.WriteLine("Creating New Supply");
            Console.WriteLine("Select a person id: ");
            Program.GetAllPerson(personDal);
            string _personId = (Console.ReadLine());
            int _person2 = Convert.ToInt32(_personId);

            Console.WriteLine("Select a category id: ");
            Program.GetAllCategory(categoryDal);
            string _catId = (Console.ReadLine());
            int _cat2 = Convert.ToInt32(_catId);

            Console.WriteLine("Input NameGoods: ");
            string _nameGoods = Console.ReadLine();
            Console.WriteLine("Input Number: ");
            string _num = Console.ReadLine();
            int _num2 = Convert.ToInt32(_num);
            Console.WriteLine("Input price unit: ");
            string _pu = Console.ReadLine();
            int _put = Convert.ToInt32(_pu);


            SupplyDTO mySupply = new SupplyDTO
            {
               ID_Person = _person2,
               ID_Category = _cat2,
               NameGoods = _nameGoods,
               Number = _num2,
               PriceUnit = _put
            };

            try
            {
                mySupply = supplyDal.CreatSupply(mySupply);
                Console.WriteLine($"New SupplyID is {mySupply.ID_Supply}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Data inputted incorrectly.");
            }
        }

        private static void CreatePerson(PersonDAL personDal)
        {
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
            var rolesDal = new RolesDAL(connStr);
            Console.WriteLine("Creating New Person");
            Console.WriteLine("Select a Role: ");
            Program.GetAllRoles(rolesDal);
            string _roleId = (Console.ReadLine());
            int _roleId2 = Convert.ToInt32(_roleId);
            Console.WriteLine("Input First Name: ");
            string _firstName = Console.ReadLine();
            Console.WriteLine("Input Last Name: ");
            string _lastName = Console.ReadLine();
            Console.WriteLine("Input Login: ");
            string _log = Console.ReadLine();
            Console.WriteLine("Input Password: ");
            string _passw = Console.ReadLine();


            PersonDTO myPerson = new PersonDTO
            {
                ID_Role = _roleId2,
                FirstName = _firstName,
                LastName = _lastName,
                Login = _log,
                Password =_passw
            };

            try
            {
                myPerson = personDal.CreatPerson(myPerson);
                Console.WriteLine($"New PersonID is {myPerson.ID_Person}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Data inputted incorrectly.");
            }
        }

        private static void CreateRoles(RolesDAL rolesDal)
        {
            Console.WriteLine("Creating New Roles");
            Console.WriteLine("Input Role Name: ");
            string _roleName = Console.ReadLine();

            RolesDTO myRoles = new RolesDTO
            {
                RoleName = _roleName
            };

            try
            {
                myRoles = rolesDal.CreatRoles(myRoles);
                Console.WriteLine($"New RoleID is {myRoles.ID_Role}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Data inputted incorrectly.");
            }
        }

        private static void CreateCategory(CategoryDAL categoryDal)
        {
            Console.WriteLine("Creating New Category");
            Console.WriteLine("Input Category Name: ");
            string _categoryName = Console.ReadLine();
           
            CategoryDTO myCategory = new CategoryDTO
            {
                CategoryName = _categoryName
            };
           
            try
            {
                myCategory = categoryDal.CreateCategory(myCategory);
                Console.WriteLine($"New CategoryID is {myCategory.ID_Category}");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Data inputted incorrectly.");
            }
        }

        private static void GetAllRoles(RolesDAL rolesDal)
        {
            var roles = rolesDal.GetAllRoles();
            Console.WriteLine("Roles:");
            foreach (var r in roles)
            {
                Console.WriteLine($"{r.ID_Role}\t{r.RoleName}\t{r.RowInsertTime}");
            }
        }

        private static void GetAllCategory(CategoryDAL categoryDal)
        {
            var category = categoryDal.GetAllCategory();
            Console.WriteLine("Category:");
            foreach (var c in category)
            {
                Console.WriteLine($"{c.ID_Category}\t{c.CategoryName}\t{c.RowInsertTime}");
            }
        }

        private static void GetAllPerson(PersonDAL personDal)
        {
            var person = personDal.GetAllPerson();
            Console.WriteLine("Person:");
            foreach (var p in person)
            {
                Console.WriteLine($"{p.ID_Person}\t{p.ID_Role}\t{p.FirstName}\t{p.LastName}\t{p.Login}\t{p.Password}\t{p.RowInsertTime}");
            }
        }

        private static void GetAllSupply(SupplyDAL supplyDal)
        {
            var supply = supplyDal.GetAllSupply();
            Console.WriteLine("Supply:");
            foreach (var s in supply )
            {
                Console.WriteLine($"{s.ID_Category}\t{s.ID_Person}\t{s.ID_Supply}\t{s.NameGoods}\t{s.Number}\t{s.PriceUnit}\t{s.RowInsertTime}");
            }
        }
    }
}

/*
string connStr = "Data Source=DESKTOP-DTPMS50;Initial Catalog=TraidingCompany;Integrated Security=True";
using (SqlConnection conn = new SqlConnection(connStr))
using (SqlCommand comm = conn.CreateCommand())
{
    conn.Open();
    string fName = "Taras";
    string lName = "Schevchenko";
    int Idr = 1;
    string Log = "taras.schevchenko";
    string Pas = "0000";

    comm.CommandText = "INSERT INTO Person (ID_Role,FirstName,LastName,Login,Password) OUTPUT INSERTED.ID_Person VALUES(@idr, @fname, @lname, @log, @pas)";
    comm.Parameters.Clear();
    comm.Parameters.AddWithValue("@idr", Idr);
    comm.Parameters.AddWithValue("@fname", fName);
    comm.Parameters.AddWithValue("@lname", lName);
    comm.Parameters.AddWithValue("@log", Log);
    comm.Parameters.AddWithValue("@pas", Pas);


    int personId = (int)comm.ExecuteScalar();
    Console.WriteLine($"New person ID = {personId}");

    conn.Close();
    comm.CommandText = "select ID_Person,ID_Role,FirstName,LastName,RowInsertTime from Person";
    conn.Open();

    SqlDataReader reader = comm.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader["ID_Person"]}\t{reader["ID_Role"]}\t{reader["FirstName"]}\t{reader["LastName"]}\t{reader["RowInsertTime"]}\t");
    }

}
*/