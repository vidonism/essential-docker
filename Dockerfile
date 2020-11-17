FROM mcr.microsoft.com/dotnet/aspnet:5.0

COPY dist /app

WORKDIR /app

EXPOSE 80/tcp

ENTRYPOINT [ "dotnet", "ExampleApp.dll" ]
