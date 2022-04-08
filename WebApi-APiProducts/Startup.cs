using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using WebApi_APiProducts.Context;
using WebApi_APiProducts.Services;
using AutoMapper;
using WebApi_APiProducts.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebApi_APiProducts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
            options.TokenValidationParameters = new TokenValidationParameters
            {   
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "http://localhost:1028",
            ValidAudience = "http://localhost:1028",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
            };

            });

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            services.AddControllersWithViews().AddNewtonsoftJson(option => option.SerializerSettings.
            ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).
            AddNewtonsoftJson(options => options.SerializerSettings.
            ContractResolver = new DefaultContractResolver());

            services.AddControllers();

            services.AddDbContext<ProductApiContext>();
            services.AddDbContext<ProductApiContextComplextQ>();

            services.AddScoped<IProductRepesitory, ProductRepesitory>();

            services.AddScoped<IContibuterRepesitory, ContributerRepesitory>();

            services.AddScoped<IOwnerRepesitory, OwnerRepesitory>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();
            app.UseCors(option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
