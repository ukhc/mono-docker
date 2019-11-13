FROM mono:6.4.0.198
MAINTAINER UKHC DevOps <devops@uky.edu>

RUN mkdir /app
WORKDIR /app

# please make sure that your published app is in the out folder
# you can use dotnet publish -c Release -o ./out 
# this works with full framework as well as dotnet core
# just make sure you have the appropirate project.json file included with the targeted framework
COPY ./out /app

ENTRYPOINT