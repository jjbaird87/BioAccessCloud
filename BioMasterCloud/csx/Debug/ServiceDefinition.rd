<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="BioMasterCloud" generation="1" functional="0" release="0" Id="dc8bd41b-8a92-4448-993a-14871183e83b" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="BioMasterCloudGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="BioAccessCloudWCF:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/BioMasterCloud/BioMasterCloudGroup/LB:BioAccessCloudWCF:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="BioAccessCloudWCFInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/BioMasterCloud/BioMasterCloudGroup/MapBioAccessCloudWCFInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:BioAccessCloudWCF:Endpoint1">
          <toPorts>
            <inPortMoniker name="/BioMasterCloud/BioMasterCloudGroup/BioAccessCloudWCF/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapBioAccessCloudWCFInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/BioMasterCloud/BioMasterCloudGroup/BioAccessCloudWCFInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="BioAccessCloudWCF" generation="1" functional="0" release="0" software="C:\Users\JJ\Documents\Visual Studio 2013\Projects\BioMasterCloud\BioMasterCloud\csx\Debug\roles\BioAccessCloudWCF" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;BioAccessCloudWCF&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;BioAccessCloudWCF&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/BioMasterCloud/BioMasterCloudGroup/BioAccessCloudWCFInstances" />
            <sCSPolicyUpdateDomainMoniker name="/BioMasterCloud/BioMasterCloudGroup/BioAccessCloudWCFUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/BioMasterCloud/BioMasterCloudGroup/BioAccessCloudWCFFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="BioAccessCloudWCFUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="BioAccessCloudWCFFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="BioAccessCloudWCFInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="8e58bac3-3b90-45ec-8bda-5e3f2f5ac8ff" ref="Microsoft.RedDog.Contract\ServiceContract\BioMasterCloudContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="174ce765-e76c-42b2-9d12-c7e701506064" ref="Microsoft.RedDog.Contract\Interface\BioAccessCloudWCF:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/BioMasterCloud/BioMasterCloudGroup/BioAccessCloudWCF:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>