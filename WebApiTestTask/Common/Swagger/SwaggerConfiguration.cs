namespace WebApiTestTask.Common.Swagger
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services) 
        {
            services.AddSwaggerDocument(c => 
            {
                c.Title = "Dresses";
                c.DocumentName 
            })
        }
    }
}
