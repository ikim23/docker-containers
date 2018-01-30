# Flask - MySQL

## Initialization

Environment variables stored in `.env.mysql` file:

|Variable|Description|
|-|-|
|MYSQL_ROOT_PASSWORD|Mandaroty field, specifying root superuser password|
|MYSQL_DATABASE|Database name|
|MYSQL_USER|User account for database|
|MYSQL_PASSWORD|User password|

Environment variables stored in `.env.flask` file:

|Variable|Description|
|-|-|
|FLASK_DEBUG|Allow debugging|

Set your variables and add `.env*` file to `.gitignore`.

Start DB container for the first time, to let it create DB instance files:

```
docker-compose up db
```
When everything is done stop container: `Ctrl+C`.

Build application container:

```
docker-compose build app
```

## Usage

Start application in container:

```
docker-compose up app
```

Open bash inside container:

```
docker-compose run -p 3000:3000 shell
```

You can access Adminer database management tool on: http://localhost:8080/
