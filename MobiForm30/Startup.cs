﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobiForm30.Startup))]
namespace MobiForm30
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
