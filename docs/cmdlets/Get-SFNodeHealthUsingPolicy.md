# Get-SFNodeHealthUsingPolicy
Gets the health of a Service Fabric node, by using the specified health policy.
## Description

Gets the health of a Service Fabric node. Use EventsHealthStateFilter to filter the collection of health events 
reported on the node based on the health state. Use ClusterHealthPolicy in the POST body to override the health 
policies used to evaluate the health. If the node that you specify by name does not exist in the health store, this 
returns an error.



## Optional Parameters
#### -EventsHealthStateFilter

Allows filtering the collection of HealthEvent objects returned based on health state.
                    The possible values for this parameter include integer value of one of the following health states.
                    Only events that match the filter are returned. All events are used to evaluate the aggregated 
health state.
                    If not specified, all entries are returned. The state values are flag-based enumeration, so the 
value could be a combination of these values, obtained using the bitwise 'OR' operator. For example, If the provided 
value is 6 then all of the events with HealthState value of OK (2) and Warning (4) are returned.
                    
                    - Default - Default value. Matches any HealthState. The value is zero.
                    - None - Filter that doesn't match any HealthState value. Used in order to return no results on a 
given collection of states. The value is 1.
                    - Ok - Filter that matches input with HealthState value Ok. The value is 2.
                    - Warning - Filter that matches input with HealthState value Warning. The value is 4.
                    - Error - Filter that matches input with HealthState value Error. The value is 8.
                    - All - Filter that matches input with any HealthState value. The value is 65535.



#### -ConsiderWarningAsError

Indicates whether warnings are treated with the same severity as errors.



#### -MaxPercentUnhealthyNodes

The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be 
unhealthy, this value would be 10.
                    
                    The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before 
the cluster is considered in error.
                    If the percentage is respected but there is at least one unhealthy node, the health is evaluated 
as Warning.
                    The percentage is calculated by dividing the number of unhealthy nodes over the total number of 
nodes in the cluster.
                    The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is 
zero.
                    
                    In large clusters, some nodes will always be down or out for repairs, so this percentage should be 
configured to tolerate that.



#### -MaxPercentUnhealthyApplications

The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of 
applications to be unhealthy, this value would be 10.
                    
                    The percentage represents the maximum tolerated percentage of applications that can be unhealthy 
before the cluster is considered in error.
                    If the percentage is respected but there is at least one unhealthy application, the health is 
evaluated as Warning.
                    This is calculated by dividing the number of unhealthy applications over the total number of 
application instances in the cluster, excluding applications of application types that are included in the 
ApplicationTypeHealthPolicyMap.
                    The computation rounds up to tolerate one failure on small numbers of applications. Default 
percentage is zero.



#### -ApplicationTypeHealthPolicyMap

Defines a map with max percentage unhealthy applications for specific application types.
                    Each entry specifies as key the application type name and as value an integer that represents the 
MaxPercentUnhealthyApplications percentage used to evaluate the applications of the specified application type.
                    
                    The application type health policy map can be used during cluster health evaluation to describe 
special application types.
                    The application types included in the map are evaluated against the percentage specified in the 
map, and not with the global MaxPercentUnhealthyApplications defined in the cluster health policy.
                    The applications of application types specified in the map are not counted against the global pool 
of applications.
                    For example, if some applications of a type are critical, the cluster administrator can add an 
entry to the map for that application type
                    and assign it a value of 0% (that is, do not tolerate any failures).
                    All other applications can be evaluated with MaxPercentUnhealthyApplications set to 20% to 
tolerate some failures out of the thousands of application instances.
                    The application type health policy map is used only if the cluster manifest enables application 
type health evaluation using the configuration entry for HealthManager/EnableApplicationTypeHealthEvaluation.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



