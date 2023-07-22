namespace Homework3
{
    internal class Program
    {
        delegate void printString(string str);
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // builder.Services.AddRazorPages();

            var app = builder.Build();
            /*// Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            */
            printString prString;

            PrintColor pc = new PrintColor();
            prString = pc.PrintOrange;
            prString += pc.PrintGreen;
            prString += pc.PrintRandom;
            prString("Color text");

            app.Run();

        }

    }
}
