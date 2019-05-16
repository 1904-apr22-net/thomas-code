FROM mcr.microsoft.com/dotnet/core/sdk:2.2

WORKDIR /app/src

# cd to ConsoleDockerDeploy folder and run dotnet publish -o out or dotnet publish -c Release -o out
COPY ./ /app/scr

RUN dotnet build
RUN dotnet publish -o /app/out

WORKDIR /app/out

CMD ["dotnet", "ConsoleDockerBuild.dll"]

# finally run docker build . or docker build -t consoledockerbuild:0.1 .