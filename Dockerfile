FROM microsoft/dotnet:sdk AS Build
WORKDIR /Psythyst
COPY ./Psythyst ./
RUN dotnet restore
RUN dotnet publish -c Release -o ./Publish