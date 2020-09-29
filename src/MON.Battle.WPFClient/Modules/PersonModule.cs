using Autofac;
using Bogus;
using MON.Battle.Fakers;
using MON.Battle.FakeServices;
using MON.Battle.IServices;
using MON.Battle.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MON.Battle.WPFClient.Modules
{
    public class PersonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonsViewModel>().SingleInstance();
            builder.RegisterType<FakePersonService>().As<IPersonService>().SingleInstance();
            builder.RegisterType<PersonFaker>().As<Faker<Models.Person>>().SingleInstance();

        }
    }
}
