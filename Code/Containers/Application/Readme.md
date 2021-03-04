Docker
======
Training:
 https://code-maze.com/docker-series/

Commands:
 docker images
 http://localhost:2375/v1.39/info (after expose deamon on tcop://localhost:2375 without TLS)

Project:
 docker image build --platform windows .\GreetingApi -t greeting-api
 docker run -d greeting-api 
 docker container stop greeting-api 
 docker container rm greeting-api

 docker image build --platform windows .\GreetingClient -t greeting-web
 docker run -d greeting-web 
 docker run -d -p 8080:80 greeting-web 
 docker container stop greeting-web 
 docker container rm greeting-webprojects

 docker-compose up -d

- No network needs to be defined as network is public by default

Private Registries:
  These are the options:
  - Use an open source solution (Portus, Harbor)
  - Optionally make a registry image yourself and host it in a docker container
  - Use the registry of minikube

  Open Source Solution:
   Portus, open source authorization server and user interface for the next generation of the Docker registry. (https://github.com/SUSE/Portus; http://port.us.org/docs/first-steps.html)
   Harbor, open source trusted cloud native registry with UI (https://github.com/goharbor/harbor)

  SetUp Custom Registry (see LocalRegistry folder)
   Use image 'stefanscherer/registry-windows' or make ourself one via 'build.ps1' and 'config.yml''
   Run 'SetupLocalRegistry.ps1' for setting up an local registry on your machin e
   
  SetUp LocalRegistry
   docker pull stefanscherer/registry-windows
   cd .\LocalRegistry
   docker-compose up -d
   ---or---
   docker run -d -p 5000:5000 --restart always --name localregistry stefanscherer/registry-windows:latest
   docker run -d -p 5000:5000 --restart=always --name localregistry -v c:\registry:c:\registry registry:latest

   http://localregistry:5000/v2/_catalog

 docker tag greeting-api:dev localregistry:5000/demo/images/greeting-api:dev
 docker tag greeting-api:dev localregistry:5000/demo/images/greeting-web:dev
 docker push localregistry:5000/demo/images/greeting-api:dev (http://localhost:6000/v2/_catalog)
 docker push localregistry:5000/demo/images/greeting-web:dev

 https://kubernetes.io/docs/concepts/containers/images/#using-a-private-registry

minikube
========
 (local local Kubernetes cluster; https://github.com/kubernetes/minikube)
 choco install minikube
 minikube start --insecure-registry=localregistry:5000 (=> 2CPU, 4GB mem, 20GB disk)
 minikube delete
 minikube dashboard
 minikube service greeting-web
 minikube docker-env (minikube has it's own docker image registry)
 & minikube -p minikube docker-env | Invoke-Expression (to point your shell to the minikube's docker-daemon' and rebuild images)
 & minikube -p minikube docker-env -u | Invoke-Expression
 minikube addons enable registry (to enable it's own registry; https://minikube.sigs.k8s.io/docs/handbook/registry/)

Helm
====
Installation:
  Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
  choco install kubernetes-helm

Convert docker-compose to helm (use https://kompose.io/)
  choco install kubernetes-kompose
  kompose convert -c 

Cache
  set HELM_EXPERIMENTAL_OCI=1
  helm env (shows your helm environment and where the cache is located)
  helm chart save . greeting-web:v1.0.0 (save in cache)

Registry (you can use docker as registry https://helm.sh/docs/topics/registries/)
  docker run -dp 5100:5100 --restart=always --name registry helm_charts
  helm env (shows your helm environment)
  helm show chart greeting-web:v1.0.0 

Kubernetes
==========
 kubectl config use-context docker-for-desktop 
 kubectl config use-context minikube

 kubectl apply -f <your helm yaml file>.yaml
  =>  kubectl apply -f greeting-api-deployment.yaml
  =>  kubectl apply -f greeting-api-service.yaml
  =>  kubectl apply -f greeting-web-deployment.yaml
  =>  kubectl apply -f greeting-web-service.yaml

 kubectl get po
 kubectl describe svc greeting-web
 kubectl config view

 In case of 
 kubectl delete -f <your helm yaml file>.yaml
 kubectl create -f <your helm yaml file>.yaml

Azure DevOps
============
- Setup Kubernetes Environment:https://www.youtube.com/watch?v=qBO5-xINmSs

Links
- https://codefresh.io/kubernetes-tutorial/local-kubernetes-windows-minikube-vs-docker-desktop/

