using AutoMapper;
using KotaAndShisanyamaHub.Services.CouponAPI;
using KotaAndShisanyamaHub.Services.CouponAPI.Data;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

ApplyMigration();

app.Run();

void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        //var services = scope.ServiceProvider;
        //try
        //{
        //    var context = services.GetRequiredService<AppDbContext>();
        //    context.Database.Migrate();
        //}
        //catch (Exception ex)
        //{
        //    var logger = services.GetRequiredService<ILogger<Program>>();
        //    logger.LogError(ex, "An error occurred while migrating the database.");
        //}
        var services = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        if (services.Database.GetPendingMigrations().Count() > 0)
        {
            services.Database.Migrate();
        }
    }
}
