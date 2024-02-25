#!/bin/bash


sudo docker stack deploy --compose-file docker-compose.yml wpstack
sudo docker service scale wpstack_wordpress=4
sudo docker service update wpstack_wordpress

# sudo docker stack rm wpstack
