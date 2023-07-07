using WebApi1;

internal class Program
{
    /* private List<Car> cars = new List<Car>
    {   new Car ( "Volkswagen", "Eos", "cabrio", 211, 2009 ),
        new Car ("Suzuki","GrandVitara","SUV", 149, 2007 ),
        new Car ("Vaz","2101","sedan", 39, 1975 )
    }; */
    private static void Main(string[] args)
    {
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

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}