

using Microsoft.EntityFrameworkCore;
using TripApi.Data;

var builder = WebApplication.CreateBuilder(args);


// builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<TripDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("PostgresConnection")
    ));



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();

}


// Automatically apply migrations
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider
        .GetRequiredService<TripDbContext>();

    await db.Database.MigrateAsync();
}


app.UseHttpsRedirection();

app.MapControllers();

app.Run();

