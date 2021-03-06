# New-SFInfrastructureQuery
Invokes a read-only query on the given infrastructure service instance.
## Description

For clusters that have one or more instances of the Infrastructure Service configured,
                this API provides a way to send infrastructure-specific queries to a particular
                instance of the Infrastructure Service.
                
                Available commands and their corresponding response formats vary depending upon
                the infrastructure on which the cluster is running.
                
                This API supports the Service Fabric platform; it is not meant to be used directly from your code.



## Optional Parameters
#### -ServiceId

The identity of the infrastructure service. This is the full name of the infrastructure service without the 'fabric:' 
URI scheme. This parameter required only for the cluster that has more than one instance of infrastructure service 
running.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



