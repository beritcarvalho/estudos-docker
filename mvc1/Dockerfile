FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.2" description="Aplicacao ASP .NET Core MVC"
WORKDIR /app
COPY dist /app
RUN ls -la /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]