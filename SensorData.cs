//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;

// Type created for JSON at <<root>>
[DataContractAttribute()]
public partial class SensorData
{
    
    [DataMemberAttribute()]
    public string status;
    
    [DataMemberAttribute()]
    public SensorDataMessage message;
}

// Type created for JSON at <<root>> --> message
[DataContractAttribute(Name="message")]
public partial class SensorDataMessage
{
    
    [DataMemberAttribute()]
    public string current_parameter;
    
    [DataMemberAttribute()]
    public string next_parameter;
    
    [DataMemberAttribute()]
    public string previous_parameter;
    
    [DataMemberAttribute()]
    public int start;
    
    [DataMemberAttribute()]
    public int depthWhenEmpty_cm;
    
    [DataMemberAttribute()]
    public int distanceSensorToFillLine_cm;
    
    [DataMemberAttribute()]
    public SensorDataEntry[] lists;
}

// Type created for JSON at <<root>> --> message --> lists
[DataContractAttribute(Name="lists")]
public partial class SensorDataEntry
{
    
    [DataMemberAttribute()]
    public int sensorsdataID;
    
    [DataMemberAttribute()]
    public int sensorstokenID;
    
    [DataMemberAttribute()]
    public int sensorallocatedID;
    
    [DataMemberAttribute()]
    public string sensorEventID;
    
    [DataMemberAttribute()]
    public string sensorDeviceID;
    
    [DataMemberAttribute()]
    public string firmwareVersion;
    
    [DataMemberAttribute()]
    public string headerMethod;
    
    [DataMemberAttribute()]
    public string reason;
    
    [DataMemberAttribute()]
    public string temperatureExist;
    
    [DataMemberAttribute()]
    public double temperatureValue;
    
    [DataMemberAttribute()]
    public string temperatureOkay;
    
    [DataMemberAttribute()]
    public double accelerometer_x;
    
    [DataMemberAttribute()]
    public double accelerometer_y;
    
    [DataMemberAttribute()]
    public double accelerometer_z;
    
    [DataMemberAttribute()]
    public string ultrasoundExist;
    
    [DataMemberAttribute()]
    public int ultrasound;
    
    [DataMemberAttribute()]
    public int batteryVoltage_mV;
    
    [DataMemberAttribute()]
    public string signalStrengthExist;
    
    [DataMemberAttribute()]
    public double signalStrength_rssi_dbm;
    
    [DataMemberAttribute()]
    public int signalStrength_bitErrorRate;
    
    [DataMemberAttribute()]
    public int timestampdata;

    [IgnoreDataMember]
    public string Timestamp
    {
        get
        {
            return (new DateTime(1970, 1, 1).AddSeconds(Convert.ToInt64(timestampdata))).ToLocalTime().ToString();
        }
    }
}