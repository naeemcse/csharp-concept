﻿using Autofac;
using Demo.Models;

namespace Demo
{
    public class WebModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Item>().As<IItem>().InstancePerLifetimeScope();

            base.Load(builder);

        }
    }
}
