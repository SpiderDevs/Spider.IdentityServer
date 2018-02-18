#!/bin/bash
docker stop spider-identity-server && docker rmi spider-identity-server
docker image  build . --tag spider-identity-server 