FROM microsoft/dotnet:2.0.3-sdk as builder
ARG source
WORKDIR /app
COPY . /app
RUN bash compile.sh

FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=builder /app/Release .
ENV ASPNETCORE_ENVIRONMENT=Uat
ENV ASPNETCORE_URLS=http://*:80
EXPOSE 80
ENTRYPOINT ["dotnet", "Spider.IdentityServer.dll"]