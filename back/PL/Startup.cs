﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PL.Startup))]

namespace PL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}