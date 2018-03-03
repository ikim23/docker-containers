SET image=api

:: Stop all running containers
docker stop $(docker ps -q)
:: Rebuild container
docker-compose build %image%
:: Start container for debugging
docker-compose up -d %image%
