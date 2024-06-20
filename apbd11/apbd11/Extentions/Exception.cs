namespace apbd11.Extentions;

public static class Exception
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder appBuilder)
    {
        appBuilder.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                // Implement exception handling here
            });
        });
    }
}