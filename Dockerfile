FROM mcr.microsoft.com/playwright/dotnet:v1.59.0-jammy

WORKDIR /app

# Copy full project
COPY . .
 
RUN dotnet restore

# Build
RUN dotnet build -c Release
