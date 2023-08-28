Microservicios es todo lo que necesitas saber para pasar de principiante a intermedio y conseguir un buen empleo

## .Net Microservices
#: no ddd en esta oportunidad
#: use case simple (two servicios)
#: Monolith no usar por esta oprtunidad

Microservicios no es la cura de todo, existe distintas aproximación para resolver un solo problema

usar docker, kubernetes, mssql, rabbitmq, GRPC

### Microservicios | Que quiere decir?
small | build fast microservicios (ideal para saas para crear mvp)
Responsable for doing 1 thing well -> solo 1 cosa se encarga el microservicio construido

Self contained | Autonomous

monolith -> usan un solo stack

microservicio -> cada servicio usa un stack, se puede repetir pero usualmente usan la tecnologia que mejor resolvería el sistema. 

#### Beneficios
Easier to change & deploy
Can be built using different technologies
Increased organisational ownership | alignment

If one microservices break, other will continue run.
*Scalable* -> only scale the services you need

#### No Beneficios
Microservicios es dificultuoso en implementar
Puede resultar en analisis de paralisis
Need strong domain knowledge


Monoliths -> can use CI/CD, daily deployes, small changes, simple to implement


## The platform services
Funciont as an Asset Register
Track all the platforms / system in company
Built by the infrastructure Team : engineering, accounting, techinical support, procurement


### The command services
Function as a repository of command line augment for given platofrms
Aid in the automation of support process
Built by the Techinal support


### Solution Architecture - Project

![Descripción de la imagen](/images_resumen/solution_architecturue.png)

