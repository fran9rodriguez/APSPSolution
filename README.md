# APSPSolution

This Solution contains 2 projects:

1. <a href="https://github.com/fran9rodriguez/APSPSolution/tree/master/APSPService" target="_blank"> WCF Rest Service </a> that provides an API with the necessary methods 
2. <a href="https://github.com/fran9rodriguez/APSPSolution/tree/master/APSPUI" target="_blank"> AngularJS GUI </a> to consume the methods implemented in the WCF Service 
3. The <a href="https://github.com/fran9rodriguez/APSPSolution/blob/master/Documentation/Help/Documentation.chm" target="_blank"> Documentation </a> of the WCF Rest Service generated using SandCastle 

## WCF Service
### Arquitecture

The idea behing the project is to use a SOAP arquitecture in order to offer a strongly de-couple solution. I've implemented 4 layers:

1. Data Access. This layer is implemented in the project <a href="https://github.com/fran9rodriguez/APSPSolution/tree/master/NewShore.APSP.DA"> APSP.DA </a> and it has been implemented using the <a href="http://www.tutorialspoint.com/design_pattern/factory_pattern.htm"> Factory Pattern Desing </a>. One of the application requiriements is that the data will be stored in FILE.DAT but as you can imagine it doesnt make sense in the real life, so most probably we will want to change the source of this data for a SQL or noSQL data sytem. For this reason in order to avoid futures big changes and facilitate the testing I've implemented the class FactoryDA which implements an Interface IDataAccess. This class call the class FileDAT in order to handle the data using .DAT Files. In case of the user wants to change this source of data in the future it is only necessary to implement a new class with the Interface IDataAccess and update the Factory Class and thats all.
2. Controller. This layer is implemented in the project <a href="https://github.com/fran9rodriguez/APSPSolution/tree/master/NewShore.APSP.Controller"> APSP.Controller </a>. The idea is to have an isolated business layer in order to implement the Service Contracts and service from the businees point of view. It has been implemented a Query class using the IQuery interface
3. Common Layer. This layer is cross layer used in the whole project. It contains the Logging system and the definition of the needed entities in the project. In order to implement the Logging system I've followed the same approach than with the DA using the Factory PD and my selection for store the logs has been <a href="https://fran9rodriguez.loggly.com"> Loggly System </a>.
4. Service Layer. Obviously here I've implemented an DI approach in order to facilate the Testing and provides a new level of abstraction of the layer. I've implemeted a QueryService which CodeBehing is using a QueryServiceHostFactory class that inherit from ServiceHostFactory. This class creates a service host based on a Service Proxy Factory which creates a proxy type that creates the actual target using the given target Factory.

Regarding the Concurrency and Throttling I've decided to use the option Instance mode = Per Call and Concurrency = Multiple. In this combination, multiple instances are created for every call but multiple threads serve every method call to a WCF service instance. Every method call is handled by multiple threads. Therefor i've also implemented the lock system to avoid deadlocks.

### Testing

### Configuration

## AngularJS GUI
### Arquitecture

### Screen Shots
