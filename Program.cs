using LazarB_Challenge_AllForOneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<SayHelloServices>();
builder.Services.AddScoped<AddNumbersServices>();
builder.Services.AddScoped<AskQuestionsServices>();
builder.Services.AddScoped<GreaterOrLessServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<ReverseItStrServices>();
builder.Services.AddScoped<ReverseItNumServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<MagicBallServices>();
builder.Services.AddScoped<RestaurantPickerServices>();


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
