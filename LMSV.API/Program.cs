using LMSV.API.DbContexts;
using LMSV.API.EntityDataModels;
using LMSV.API.Services;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddOData(opt =>
    opt.AddRouteComponents("api/reporting", new LMSVDataModel().GetEntityDataModel())
        .Select().Filter().OrderBy().Count().SetMaxTop(5000));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CardInfoContext>(dbContextOptions => dbContextOptions
    .UseSqlServer(builder.Configuration["ConnectionStrings:WebApiDatabase"]));

builder.Services.AddScoped<ILMSVReportingRepository, LMSVReportingRepository>();

//Only need this line if using DTOs
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DefaultModelsExpandDepth(-1);
    });
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
