# ExceptionHandling


## Handle-Custom-And-Generic-Exceptions

ExceptionHandling is a sample app that shows how to manage custom or standard exceptions. It also shows how to add custom exceptions and throw them, so they can be managed on the top level.

###### Description of the sample

The app uses SimpleInjector as a dependency library, 
[SimpleInjector](https://github.com/simpleinjector/SimpleInjector)

You can find the implementation on the highest level of the sample in the \Global.asax.cs , under the ApplicationStart method. Where you can see a simple implementation just for demonstration purposes.

The app uses the log4net logging platform for logging, 
[log4net](https://github.com/apache/log4net)

You can find the configuration of the log4net in the web.config, where you can see the configuration and a simple appender, for demonstration purposes in the handling of the exceptions.

The implementation of the custom exception can be found in the ExceptionHandling.Core project.
Under CustomBLLException, there is a custom exception, that inherits from System.Exception, which is used in the sample for throwing and managing that custom exception.
As in the Exceptions.cs there you can be find the enums, that show one way in which they can be implemented to throw custom messages. 

In the top level, under the BaseController, you can find a method, that is being used to handle the exceptions, based on their level, from more specific to more general ones.

###### Prerequisites

This sample requires:
 
- Visual Studio


###### To start the sample

- Clone the project
- Restore nuget packages 
- Build the sample
- Run and test the sample

###### Change log

- August 2016
