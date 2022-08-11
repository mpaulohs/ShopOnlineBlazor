using Api.Data;
using Api.Controllers;
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
using Api.MappProfiles;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddNewtonsoftJson();
            // services.AddAutoMapper(cfg =>
            // cfg.AddProfile<ProductProfile>()

            // );
            services.AddAutoMapper(typeof(Startup).Assembly);
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "RestAPI", Version = "v1" });
                options.EnableAnnotations();
            });


            // ToDo: in production this should be limited only to specified sources
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("x-pagination")
                );

            });

            services.AddDbContext<ApplicationDbContext<Guid>>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("AppConnectionString"));

                //ToDo: disable in production after debuging
                options.EnableSensitiveDataLogging();

                //ToDo: check on SqlServer
                //options.UseSqlServer(Configuration.GetConnectionString("AppConnectionString"));
            });

            services.AddIdentity<User<Guid>, Role<Guid>>().AddEntityFrameworkStores<ApplicationDbContext<Guid>>().AddDefaultTokenProviders();

            services.AddScoped(typeof(IRepository<AdditionalInformation<Guid>, Guid>), typeof(RepositoryBase<AdditionalInformation<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<BankAccount<Guid>, Guid>), typeof(RepositoryBase<BankAccount<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Bank<Guid>, Guid>), typeof(RepositoryBase<Bank<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<CashDesk<Guid>, Guid>), typeof(RepositoryBase<CashDesk<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ClientContactInformation<Guid>, Guid>), typeof(RepositoryBase<ClientContactInformation<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ClientContactInformationType<Guid>, Guid>), typeof(RepositoryBase<ClientContactInformationType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ClientContract<Guid>, Guid>), typeof(RepositoryBase<ClientContract<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Currency<Guid>, Guid>), typeof(RepositoryBase<Currency<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<DocumentPayment<Guid>, Guid>), typeof(RepositoryBase<DocumentPayment<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<DocumentType<Guid>, Guid>), typeof(RepositoryBase<DocumentType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<DocumentSale<Guid>, Guid>), typeof(RepositoryBase<DocumentSale<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Mesage<Guid>, Guid>), typeof(RepositoryBase<Mesage<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Organization<Guid>, Guid>), typeof(RepositoryBase<Organization<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<PriceType<Guid>, Guid>), typeof(RepositoryBase<PriceType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductCharacteristic<Guid>, Guid>), typeof(RepositoryBase<ProductCharacteristic<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Product<Guid>, Guid>), typeof(RepositoryBase<Product<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductQuality<Guid>, Guid>), typeof(RepositoryBase<ProductQuality<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductQuantity<Guid>, Guid>), typeof(RepositoryBase<ProductQuantity<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductSerie<Guid>, Guid>), typeof(RepositoryBase<ProductSerie<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductType<Guid>, Guid>), typeof(RepositoryBase<ProductType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductUnitClassifier<Guid>, Guid>), typeof(RepositoryBase<ProductUnitClassifier<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductUnitMeasurement<Guid>, Guid>), typeof(RepositoryBase<ProductUnitMeasurement<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Role<Guid>, Guid>), typeof(RepositoryBase<Role<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Storage<Guid>, Guid>), typeof(RepositoryBase<Storage<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Subdivision<Guid>, Guid>), typeof(RepositoryBase<Subdivision<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<User<Guid>, Guid>), typeof(RepositoryBase<User<Guid>, Guid, ApplicationDbContext<Guid>>));

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                }
                );
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

