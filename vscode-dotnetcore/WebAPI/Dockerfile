FROM microsoft/dotnet:2-sdk

# https://docs.microsoft.com/en-us/nuget/tools/cli-ref-environment-variables
# Do not extract XML documentation files
ENV NUGET_XMLDOC_MODE skip
# https://docs.microsoft.com/en-us/aspnet/core/fundamentals/hosting?tabs=aspnetcore2x#host-configuration-values
ENV ASPNETCORE_URLS=http://0.0.0.0:80
EXPOSE 80

WORKDIR /vsdbg

# Installing vsdbg debbuger
RUN apt-get update && \
    apt-get install -y --no-install-recommends unzip && \
    rm -rf /var/lib/apt/lists/* && \
    curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /vsdbg

WORKDIR /app

# Copying source files into container and publish it
COPY WebAPI.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Debug -o out

# Start container and wait for debugger to attach
ENTRYPOINT [ "/bin/bash", "-c", "sleep infinity" ]
