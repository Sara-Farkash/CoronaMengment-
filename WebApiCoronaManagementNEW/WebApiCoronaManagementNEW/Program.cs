//using static Azure.Core.HttpHeader;
using Microsoft.EntityFrameworkCore;
using WebApiCoronaManagementNEW;
using Dal;
using Bll;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IUserDal), typeof(UserDal));
builder.Services.AddScoped(typeof(IUserBll), typeof(UserBll));

builder.Services.AddScoped(typeof(IVaccinationDal), typeof(VaccinationDal));
builder.Services.AddScoped(typeof(IVaccinationBll), typeof(VaccinationBll));

//builder.Services.AddScoped(typeof(IIllBll), typeof(IllBll));
//builder.Services.AddScoped(typeof(IIllDal), typeof(IllDal));



builder.Services.AddScoped<IIllBll, IllBll>();
builder.Services.AddScoped<IIllDal, IllDal>();
builder.Services.AddDbContext<Database>();




builder.Services.AddDbContext<Database>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
var app = builder.Build();
app.UseCors("MyPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();