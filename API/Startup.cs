using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ShopOnline.API.Data;
using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Models.Identities;
using ShopOnline.Shared.Services;
using System;

namespace ShopOnline.API
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

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            });

            services.AddDbContext<ApplicationDbContext<Guid>>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppConnectionString"));
            });

            services.AddIdentity<User<Guid>, Role<Guid>>().AddEntityFrameworkStores<ApplicationDbContext<Guid>>().AddDefaultTokenProviders();

            services.AddScoped(typeof(IRepository<AdditionalInformation<Guid>, Guid>), typeof(RepositoryBaseApi<AdditionalInformation<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<BankAccount<Guid>, Guid>), typeof(RepositoryBaseApi<BankAccount<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Bank<Guid>, Guid>), typeof(RepositoryBaseApi<Bank<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<CashDesk<Guid>, Guid>), typeof(RepositoryBaseApi<CashDesk<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ClientContactInformation<Guid>, Guid>), typeof(RepositoryBaseApi<ClientContactInformation<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ClientContactInformationType<Guid>, Guid>), typeof(RepositoryBaseApi<ClientContactInformationType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ClientContract<Guid>, Guid>), typeof(RepositoryBaseApi<ClientContract<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Currency<Guid>, Guid>), typeof(RepositoryBaseApi<Currency<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<DocumentPayment<Guid>, Guid>), typeof(RepositoryBaseApi<DocumentPayment<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<DocumentSale<Guid>, Guid>), typeof(RepositoryBaseApi<DocumentSale<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Mesage<Guid>, Guid>), typeof(RepositoryBaseApi<Mesage<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Organization<Guid>, Guid>), typeof(RepositoryBaseApi<Organization<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<PriceType<Guid>, Guid>), typeof(RepositoryBaseApi<PriceType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductCharacteristic<Guid>, Guid>), typeof(RepositoryBaseApi<ProductCharacteristic<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Product<Guid>, Guid>), typeof(RepositoryBaseApi<Product<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductQuality<Guid>, Guid>), typeof(RepositoryBaseApi<ProductQuality<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductQuantity<Guid>, Guid>), typeof(RepositoryBaseApi<ProductQuantity<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductSerie<Guid>, Guid>), typeof(RepositoryBaseApi<ProductSerie<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductType<Guid>, Guid>), typeof(RepositoryBaseApi<ProductType<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductUnitClassifier<Guid>, Guid>), typeof(RepositoryBaseApi<ProductUnitClassifier<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<ProductUnitMeasurement<Guid>, Guid>), typeof(RepositoryBaseApi<ProductUnitMeasurement<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Storage<Guid>, Guid>), typeof(RepositoryBaseApi<Storage<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<Subdivision<Guid>, Guid>), typeof(RepositoryBaseApi<Subdivision<Guid>, Guid, ApplicationDbContext<Guid>>));

            services.AddScoped(typeof(IRepository<User<Guid>, Guid>), typeof(RepositoryBaseApi<User<Guid>, Guid, ApplicationDbContext<Guid>>));

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

