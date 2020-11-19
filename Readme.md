## Stopped at page 74


### Create GIT repo
1. git init
2. git add .
3. git commit -m "First commit"
4. git remote add origin https://github.com/vidonism/essential-docker.git
5. git push origin master


### Commit new changes
1. git add .
2. git status
3. git commit -m "Updates"
4. git push origin master


### Prepare for publish
1. dotnet restore
2. dotnet publish --framework net5.0 --configuration Release --output dist


### Create custom container
1. Create Dockerfile
2. docker build . -t vidonism/exampleapp:0.1 -f Dockerfile


### Run new image
1. docker create -p 3000:80 --name exampleApp3000 vidonism/exampleapp:0.1
2. docker start exampleApp3000


### Committing Container Changes
1. docker commit exampleApp3000 vidonism/exampleapp:changed

### Creating a volume and running on it
1. docker volume create --name testdata
2. docker run --name vtest2 -v testdata:/data vidonism/vtest


### Examine docker
1. docker inspect vidonism/vtest
