using BookingApp.Core.Repositories;
using BookingApp.Core.UseCases;
using BookingApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add your repository and use cases dependencies here
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<GetAllBookingsUseCase>();
builder.Services.AddScoped<CreateBookingUseCase>();
builder.Services.AddScoped<GetBookingByIdUseCase>();

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

app.Run();