using AutoMapper;
using BusinessLogic.Concrete;
using BusinessLogic.Interfaces;
using DAL.ADO;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Injection;

namespace WindowsFormsProject
{
    static class Program
    {
        
        public static IUnityContainer Container;
        private static string connStr;

        [STAThread]
        static void Main()
        {
            string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;

            ConfigureUnity();
            UnityContainer Container = new UnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            LoginForm lf = Container.Resolve<LoginForm>();
            
            if (lf.ShowDialog() == DialogResult.OK)
            {
               
                Application.Run(Container.Resolve<SupplyList>());
            }
            else
            {
                Application.Exit();
            }
        }

        private static void ConfigureUnity()
        {
            Container = new UnityContainer();  
            Container.RegisterInstance<string>("connStr", connStr);
            Container.RegisterType<IPersonDAL, PersonDAL>(new InjectionConstructor(new ResolvedParameter("connStr")))
                .RegisterType<ISupplyDAL, SupplyDAL>()
                .RegisterType<IRolesDAL, RolesDAL>()
                .RegisterType<ICategoryDAL, CategoryDAL>()
                .RegisterType<IAuthManager, AuthManager>()
                .RegisterType<ISupplyManager, SupplyManager>();
        }
    }
}
