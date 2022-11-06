# A simple C# REST API of a Book Catalogue with a Jenkins Pipeline

## Contents
* [Overview](#overview)
* [Deploying the application](#deploying)
  * [Deployment strategy 1: docker-compose](#strategy1)
  * [Deployment strategy 2: Kubernetes deployment with manifests](#strategy2)
  * [Deployment strategy 3: Kubernetes deployment with Helm](#strategy3)

<a name="overview"></a>
## Overview
This is a simple example of a containerized application and an automation CI/CD pipeline.

The application consists of three components:
* A MySQL database for storing the Book Catalogue
* A REST API for a Book Catalogue (C#), which uses the Entity Framework Core ORM to interract with the database. The API has a Swagger UI, where you will find various endpoints to interact with the database and check the API's health.
* A frontend application (PHPMyAdmin) for direct interaction with the database without going through the C# API (for easier debugging and verification purposes)

The CI/CD pipeline is done with Jenkins (Not yet implemented).

To run the application clone the repository locally and follow the instructions below, depending on your deployment strategy.

<a name="deploying"></a>
## Deploying the application
There are three ways to deploy the application **without** the CI/CD pipeline:
* Deploying in docker with docker-compose 
* Deploying in Kubernetes with manifests
* Deploying in Kubernetes as Helm charts

<a name="strategy1"></a>
### **Deployment strategy 1:** docker-compose
To deploy the application with docker-compose run the commands below from the repository's root directory:
```bash:
cd docker
docker-compose up
```

Database frontend (PHPMyAdmin): You can visit the PHPMyAdmin page on your browser at [localhost:8080](localhost:8080). The **username** is root and the **password** is password.
Book Catalogue API (C#): You can visit the API's Swagger UI on your browser at [localhost:8081/swagger/index.html](localhost:8081/swagger/index.html). 

To delete the application containers, run:
```bash:
docker-compose down
```

<a name="strategy2"></a>
### **Deployment strategy 2:** Kubernetes deployment with manifests
To deploy the application with kubernetes manifests run from the repository's root directory:
```bash:
kubectl apply -f kubernetes/
```
This will deploy all manifests in the kubernetes folder, in the namespace my-app. To find the ports the C# API and PHPMyAdmin pods are listening to, run
 ```bash:
kubectl -n my-app get svc 
```

Database frontend (PHPMyAdmin): You can visit the PHPMyAdmin page on your browser at [localhost:phpmyadmin-port](localhost:phpmyadmin-port). The **username** is root and the **password** is password.
Book Catalogue API (C#): You can visit the API's Swagger UI on your browser at [localhost:api-port/swagger/index.html](localhost:api-port/swagger/index.html). 

To delete the application containers, run:
```bash:
kubectl delete -f kubernetes/
```

<a name="strategy3"></a>
### **Deployment strategy 3:** Kubernetes deployment with Helm
To deploy the application with Helm run from the repository's root directory:
```bash:
helm install app -f .\helm\values.yaml helm\.
```
This will install the Helm chart found in the helm folder, in the namespace my-app. To find the ports the C# API and PHPMyAdmin pods are listening to, run
 ```bash:
kubectl -n my-app get svc 
```

Database frontend (PHPMyAdmin): You can visit the PHPMyAdmin page on your browser at [localhost:phpmyadmin-port](localhost:phpmyadmin-port). The **username** is root and the **password** is password.
Book Catalogue API (C#): You can visit the API's Swagger UI on your browser at [localhost:api-port/swagger/index.html](localhost:api-port/swagger/index.html). 

To delete the application containers (uninstall the Helm chart), run:
```bash:
helm uninstall app
```