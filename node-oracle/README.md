# Node.js - Oracle database

## Initialization

Start DB container for the first time, to let it create Oracle DB instance files:

```
docker-compose up db
```
When everything is done stop container: `Ctrl+C`.

Environment variables stored in `.env` file:

|Variable|Description|
|-|-|
|USER|Root user name|
|PASSWORD|Root user password|
|CONNECT_STRING|Database connection string|

Set your variables and add `.env` file to `.gitignore`.

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

## Debugging in VSCode

1. Stop all running containers: `docker stop $(docker ps -q)`
2. Open debugger: `Ctrl+Shift+D`
3. Choose `Node` configuration
4. Start debugging session: `F5`

Code is watched by [Nodemon](https://nodemon.io/). To propagate changes just hit `Ctrl+S` and server will be restarted for you without interrupting debug session.
