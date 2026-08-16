using AddressBookApp.Business;
using AddressBookApp.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using AddressBookApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AddressBookDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection")));
builder.Services.AddScoped<IAddressBookRepository, AddressBookRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();

builder.Services.AddScoped<IAddressBookService, AddressBookService>();
builder.Services.AddScoped<IContactsService, ContactsService>();

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
