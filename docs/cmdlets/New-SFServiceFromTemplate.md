# New-SFServiceFromTemplate
Creates a Service Fabric service from the service template.
## Description

Creates a Service Fabric service from the service template defined in the application manifest. A service template 
contains the properties that will be same for the service instance of the same type. The API allows overriding the 
properties that are usually different for different services of the same service type.



## Required Parameters
#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ApplicationName

The name of the application, including the 'fabric:' URI scheme.



#### -ServiceName

The full name of the service with 'fabric:' URI scheme.



#### -ServiceTypeName

Name of the service type as specified in the service manifest.



## Optional Parameters
#### -InitializationData

The initialization data for the newly created service instance.



#### -ServicePackageActivationMode

The activation mode of service package to be used for a service. Possible values include: 'SharedProcess', 
'ExclusiveProcess'
                    
                    The activation mode of service package to be used for a Service Fabric service. This is specified 
at the time of creating the Service.



#### -ServiceDnsName

The DNS name of the service. It requires the DNS system service to be enabled in Service Fabric cluster.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



