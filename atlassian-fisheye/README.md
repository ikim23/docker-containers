# Atlassian Fisheye

## Used containers:
- [mswinarski/atlassian-fisheye](https://hub.docker.com/r/mswinarski/atlassian-fisheye/)
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
