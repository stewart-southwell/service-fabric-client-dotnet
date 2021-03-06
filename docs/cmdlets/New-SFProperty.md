# New-SFProperty
## Description
Creates or updates a Service Fabric property.
## Required Parameters
#### -BinaryData
Array of bytes to be sent as an integer array. Each element of array is a number between 0 and 255. This is used when Binary switch parameter is provided.
#### -Data
The Data for the property to be created. This is used when Int64, Double, String or Guid switch parameter is provided.
#### -NameId
The Service Fabric name, without the 'fabric:' URI scheme.
#### -PropertyName
The name of the Service Fabric property.
#### -Binary
Binary switch paramter indicating binary data.
#### -Double
Double switch paramter indicating Double data.
#### -Guid
Guid switch paramter indicating Guid data.
#### -Int64
Int64 switch paramter indicating Int64 data.
#### -String
String switch paramter indicating String data.
## Optional Parameters
#### -CustomTypeId
The property's custom type ID. Using this property, the user is able to tag the type of the value of the property.
#### -ServerTimeout
The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.