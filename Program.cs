/*
ARELY MARTINEZ 
OCT 25 2022, 10:51 AM 
SAY HELLO END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN INPUT 2 NUMBER AND IT REPSOND 
WITH WITCH ONE IS GREAT AND LESS THAN. 
THEY WOULD INPUT THROUGH POSTMAN LIKE 
https://localhost:7255/new/comparing/6/8
OUTPUT: 8 > 8 6 > 8

PEER REVIEW: JACOB DEKOK -- THE CODE LOOKS GREAT 
AND IS ORGANIZEDTHE PROGRAM RUNS AS INTENDED AND 
EVERYTHING CHECKS OUT
 */

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
