# dotnet-angular-full-stack-app
full stack app incorporating microservice architecture


start by cd-ing into aspcorecrud/ and run docker-compose up. 
If that doesn't work

individual commands to run the images once you have created them are : 
docker run -d --name sql_server_name --network sql-server-test -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=YourPassword123' -p 1433:1433 microsoft/mssql-server-linux

docker run -it --name aspcorecrud_name --network sql-server-test -p 8080:80  aspcorecrud:v1

docker run --rm -p 4200:80 angularfront_name
