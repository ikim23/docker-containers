# Atlassian Bamboo

## Used containers:
- [cptactionhank/atlassian-bamboo](https://hub.docker.com/r/cptactionhank/atlassian-bamboo/)
- [mysql](https://hub.docker.com/r/_/mysql/)

## Initialization:

Environment variables stored in `.env` file:

|Variable|Description|
|-|-|
|MYSQL_ROOT_PASSWORD|Mandaroty field, specifying root superuser password|
|MYSQL_DATABASE|Database name|
|MYSQL_USER|User account for database|
|MYSQL_PASSWORD|User password|

## Run (local machine):

```
docker-compose up
```

## Run in detached mode (server):

```
docker-compose up -d
```

## Connect MySQL to Bamboo

- [See instructions](https://confluence.atlassian.com/bamboo/mysql-289276817.html)

|Parameter|Value|
|-|-|
|Driver Class Name|com.mysql.jdbc.Driver|
|Database URL|jdbc:mysql://bamboodb:3306/bamboo?autoReconnect=true&useUnicode=true&characterEncoding=utf8|
|User Name|Value of MYSQL_USER|
|Password|Value of MYSQL_PASSWORD|
