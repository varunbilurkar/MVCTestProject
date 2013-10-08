using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.TestProject.Data;
using Mvc.TestProject.Data;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Data.Entity;

namespace Mvc.TestProject.Installers
{
    public class EntityFrameworkFacility :IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(RepositoryBase<>)).LifestylePerWebRequest());

            container.Register(Component.For<DbContext>()
                .ImplementedBy<DataContext>()
                .LifestylePerWebRequest());
        }
    }
}