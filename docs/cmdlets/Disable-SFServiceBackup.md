# Disable-SFServiceBackup
Disables periodic backup of Service Fabric service which was previously enabled.
## Description

Disables periodic backup of Service Fabric service which was previously enabled. Backup must be explicitly enabled 
before it can be disabled.
                In case the backup is enabled for the Service Fabric application, which this service is part of, this 
service would continue to be periodically backed up as per the policy mapped at the application level.



## Required Parameters
#### -ServiceId

The identity of the service. This ID is typically the full name of the service without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the service name is "fabric:/myapp/app1/svc1", the service identity would be 
"myapp~app1~svc1" in 6.0+ and "myapp/app1/svc1" in previous versions.



#### -CleanBackup

Boolean flag to delete backups. It can be set to true for deleting all the backups which were created for the backup 
entity that is getting disabled for backup.



