FROM mcr.microsoft.com/dotnet/core/runtime:2.2

WORKDIR /app

# cd to ConsoleDockerDeploy folder and run dotnet publish -o out or dotnet publish -c Release -o out
COPY out/ /app

CMD [ "dotnet", "/app/ConsoleDockerDeploy.dll"]

# finally run docker build .

#gave me an imgage name (66b9306418c2)
#docker run (image)