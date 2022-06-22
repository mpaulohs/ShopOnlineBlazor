using Api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Shared.Models.Catalogs;
using Shared.Models.Documents;
using Shared.Models.Identities;
using Shared.Services.Repository;
using System;

namespace Api
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

            services.AddControllers().AddNewtonsoftJson();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });


            // TODO: this should be limited only to specified sources
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("x-pagination")
                );

            });

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("AppConnectionString"));
                //options.UseSqlServer(Configuration.GetConnectionString("AppConnectionString"));
            });

            services.AddIdentity<User, Role>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddScoped(typeof(IRepository<AdditionalInformation, Guid>), typeof(RepositoryBaseApi<AdditionalInformation, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<BankAccount, Guid>), typeof(RepositoryBaseApi<BankAccount, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Bank, Guid>), typeof(RepositoryBaseApi<Bank, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<CashDesk, Guid>), typeof(RepositoryBaseApi<CashDesk, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ClientContactInformation, Guid>), typeof(RepositoryBaseApi<ClientContactInformation, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ClientContactInformationType, Guid>), typeof(RepositoryBaseApi<ClientContactInformationType, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ClientContract, Guid>), typeof(RepositoryBaseApi<ClientContract, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Currency, Guid>), typeof(RepositoryBaseApi<Currency, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<DocumentPayment, Guid>), typeof(RepositoryBaseApi<DocumentPayment, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<DocumentSale, Guid>), typeof(RepositoryBaseApi<DocumentSale, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Mesage, Guid>), typeof(RepositoryBaseApi<Mesage, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Organization, Guid>), typeof(RepositoryBaseApi<Organization, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<PriceType, Guid>), typeof(RepositoryBaseApi<PriceType, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductCharacteristic, Guid>), typeof(RepositoryBaseApi<ProductCharacteristic, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Product, Guid>), typeof(RepositoryBaseApi<Product, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductQuality, Guid>), typeof(RepositoryBaseApi<ProductQuality, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductQuantity, Guid>), typeof(RepositoryBaseApi<ProductQuantity, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductSerie, Guid>), typeof(RepositoryBaseApi<ProductSerie, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductType, Guid>), typeof(RepositoryBaseApi<ProductType, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductUnitClassifier, Guid>), typeof(RepositoryBaseApi<ProductUnitClassifier, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<ProductUnitMeasurement, Guid>), typeof(RepositoryBaseApi<ProductUnitMeasurement, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Storage, Guid>), typeof(RepositoryBaseApi<Storage, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<Subdivision, Guid>), typeof(RepositoryBaseApi<Subdivision, Guid, ApplicationDbContext>));

            services.AddScoped(typeof(IRepository<User, Guid>), typeof(RepositoryBaseApi<User, Guid, ApplicationDbContext>));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseCors();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

