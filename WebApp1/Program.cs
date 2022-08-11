var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//for specific domain 
builder.Services.AddCors(p => p.AddPolicy("corspolicy", b => {
    b.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
       }
));
//for any domain 
/*
builder.Services.AddCors(p => p.AddPolicy("corspolicy", b => {
    b.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}
)); */


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
app.UseCors("corspolicy");


app.Run();
