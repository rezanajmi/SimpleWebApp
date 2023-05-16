using SimpleWebApp.Web;

var builder = WebApplication.CreateBuilder(args);
Startup.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();
Startup.ConfigureApp(app);

app.Run();
