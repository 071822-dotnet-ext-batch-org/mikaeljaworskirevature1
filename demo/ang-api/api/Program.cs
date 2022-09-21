var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string MyAllowAllOrigins = " _myAllowAllOrigins"; //this'll get built over so naything is allowed
builder.Services.AddCors( Options => { //adds CORS to the API with almbda expression
    Options.AddPolicy( name: MyAllowAllOrigins,
    builder => 
    {
        builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowAllOrigins);

app.Run();