## Projeto NerdStore 
Uma abordagem de DDD, CQRS, EventDriven e EventSourcing

### Iniciar EventStoreDb
```console
docker run --name esdb-node -it -p 2113:2113 -p 1113:1113 eventstore/eventstore:latest --insecure --run-projections=All --enable-external-tcp --enable-atom-pub-over-http
```

## Iniciar Projeto
Antes de iniciar, definir connection strings e rodar migrations nos contexts.