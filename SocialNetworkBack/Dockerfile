# Используем официальный образ .NET SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Копируем csproj и восстанавливаем зависимости
COPY *.sln .
COPY SocialNetworkBack/*.csproj ./SocialNetworkBack/
RUN dotnet restore

# Копируем остальные файлы проекта и собираем
COPY SocialNetworkBack/. ./SocialNetworkBack/
WORKDIR /src/SocialNetworkBack
RUN dotnet build -c Release -o /app/build

# Создаем финальный образ
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

COPY --from=build /app/build .

EXPOSE 80

# Запускаем приложение
ENTRYPOINT ["dotnet", "SocialNetworkBack.dll"]
