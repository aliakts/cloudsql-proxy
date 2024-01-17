FROM mcr.microsoft.com/dotnet/aspnet:7.0

COPY . /app

RUN apt-get update && \
    chmod +x /app/CloudSQL.dll
    
EXPOSE 80
WORKDIR /app
ENTRYPOINT ["dotnet", "./CloudSQL.dll"]
