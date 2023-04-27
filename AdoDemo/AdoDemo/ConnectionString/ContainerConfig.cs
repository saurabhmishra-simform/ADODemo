using AdoDemo.Interfaces;
using AdoDemo.Querys;
using AdoDemo.UI;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo.ConnectionString
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var Builder = new ContainerBuilder();

            Builder.RegisterType<InsertData>().As<IInsertData>();
            Builder.RegisterType<UpdateData>().As<IUpdateData>();
            Builder.RegisterType<DeleteData>().As<IDeleteData>();
            Builder.RegisterType<DisplayData>().As<IDeleteData>();

            Builder.RegisterType<MenuOption>().As<IMenuOption>();

            return Builder.Build();
        }
    }
}
