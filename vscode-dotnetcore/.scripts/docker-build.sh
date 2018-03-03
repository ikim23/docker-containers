#!/bin/bash

IMAGE=api

# Stop all running containers
docker stop $(docker ps -q)
# Rebuild container
docker-compose build $IMAGE
# Start container for debugging
docker-compose up -d $IMAGE
