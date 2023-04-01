using Machinia_Mongodb_Crud_Api.data;
using System.ComponentModel.DataAnnotations;


var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Mongodb_Configuration>(builder.Configuration.GetSection("MongoDB_servicesSettings"));
builder.Services.AddSingleton<Mongodb_Api_manager>();
var app = builder.Build();

app.MapGet("/get_records", async (Mongodb_Api_manager Mongodb_Api_manager_service) => 
            await Mongodb_Api_manager_service.Get()
) ;
app.MapGet("/get_records/{id}", async (Mongodb_Api_manager Mongodb_Api_manager_service, string id) =>
{
    var result = await Mongodb_Api_manager_service.Get(id);
    return result is null ? Results.NotFound(new { Error = "No result found for entered Key" }) : Results.Ok(result);
    }
);

app.MapPost("/insert_new_records", async(Mongodb_Api_manager Mongodb_Api_manager_service, Mongodb_Model Mongodb_strucure) =>
{
    var validationResults = new List<ValidationResult>();
    var validationContext = new ValidationContext(Mongodb_strucure, null, null);
    if (!Validator.TryValidateObject(Mongodb_strucure, validationContext, validationResults, true))
    {
        return Results.BadRequest(validationResults);
    }
    await Mongodb_Api_manager_service.Create(Mongodb_strucure);
    return Results.Ok(Mongodb_strucure);

});

app.Run();
