﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReservaLaboratorios.Startup))]
namespace ReservaLaboratorios
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
