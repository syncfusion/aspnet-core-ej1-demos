#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using samplebrowser.Data;
using samplebrowser.Models;
using samplebrowser.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel.Resolution;
using Microsoft.Extensions.DependencyModel;
using Syncfusion.Licensing;
using System.IO;
using Microsoft.DotNet.PlatformAbstractions;
using System.Reflection;
using System.Text;

namespace samplebrowser
{
    public class Startup
    {
        private string _contentRootPath = "";
        public Startup(IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            var mvcBuilder = serviceProvider.GetService<IMvcBuilder>();
            new MvcConfiguration().ConfigureMvc(mvcBuilder);
            string License = File.ReadAllText(System.IO.Path.Combine(env.ContentRootPath  , "SyncfusionLicense.txt"),Encoding.UTF8);
            SyncfusionLicenseProvider.RegisterLicense(License);
            Configuration = builder.Build();

            _contentRootPath = env.ContentRootPath;
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            string connection = Configuration.GetConnectionString("NorthWndConnection");
            if (connection.Contains("%CONTENTROOTPATH%"))
            {
                connection = connection.Replace("%CONTENTROOTPATH%", _contentRootPath);
            }
            services.AddDbContext<NORTHWNDContext>(options => options.UseSqlServer(connection));
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Introduction}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "arearoute",
                    template: "{area:exists}/{controller}/{action}");
            });
        }
    }

    public class MvcConfiguration : IDesignTimeMvcBuilderConfiguration
    {
        private class DirectReferenceAssemblyResolver : ICompilationAssemblyResolver
        {
            public bool TryResolveAssemblyPaths(CompilationLibrary library, List<string> assemblies)
            {
                if (!string.Equals(library.Type, "reference", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                var paths = new List<string>();

                foreach (var assembly in library.Assemblies)
                {
                    var path = Path.Combine(ApplicationEnvironment.ApplicationBasePath, assembly);

                    if (!File.Exists(path))
                    {
                        return false;
                    }

                    paths.Add(path);
                }

                assemblies.AddRange(paths);

                return true;
            }
        }

        public void ConfigureMvc(IMvcBuilder builder)
        {
            typeof(CompilationLibrary)
                .GetTypeInfo()
                .GetDeclaredField("<DefaultResolver>k__BackingField")
                .SetValue(null, new CompositeCompilationAssemblyResolver(new ICompilationAssemblyResolver[]
                {
                    new DirectReferenceAssemblyResolver(),
                    new AppBaseCompilationAssemblyResolver(),
                    new ReferenceAssemblyPathResolver(),
                    new PackageCompilationAssemblyResolver(),
                }));
        }
    }
}
