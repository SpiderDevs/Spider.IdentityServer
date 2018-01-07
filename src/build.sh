#!/bin/bash
docker rmi spider-identity-server
docker image  build . --tag spider-identity-server 