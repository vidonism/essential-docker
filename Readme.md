## Stopped at page 51


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


