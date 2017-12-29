FROM microsoft/dotnet:sdk AS Build
WORKDIR /Psythyst
COPY ./ ./
RUN dotnet restore
RUN dotnet publish -c Release -o ./Publish