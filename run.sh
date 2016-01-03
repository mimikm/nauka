#!/bin/bash
docker build -t dominik-test . 
docker run -i -t -v `pwd`:/var/www/html/dominik dominik-test bash
