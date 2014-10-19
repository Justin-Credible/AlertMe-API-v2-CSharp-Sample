using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace JustinCredible.AlertMeAPIv2CSharpSample
{
    public interface IAlertMeApi : CookComputing.XmlRpc.IXmlRpcProxy
    {
        /// <summary>
        /// Enables customers to log in to the API service and initiates a secure session for the user.
        /// A session token  is returned after a successful login call. After 20 minutes of inactivity
        /// the API will log the user out and invalidate the session token.
        /// </summary>
        /// <param name="username">The user name to use for login.</param>
        /// <param name="password">The password to use for login.</param>
        /// <param name="callerDescription">The description of the device that is calling the API (used in logs etc).</param>
        /// <returns>A session token.</returns>
        [XmlRpcMethod("login")]
        string Login(string username, string password, string callerDescription);

        /// <summary>
        /// Allows you to explicitly end your session.
        /// </summary>
        /// <param name="sessionToken">The session to end.</param>
        /// <returns>The string "ok"</returns>
        [XmlRpcMethod("logout")]
        string Logout(string sessionToken);

        /// <summary>
        /// Returns user information.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A string with the format "firstname|[first name],lastname|[last name],username|[username]"</returns>
        [XmlRpcMethod("getUserInfo")]
        string GetUserInfo(string sessionToken);

        /// <summary>
        /// Returns a list of all hubs associated with the logged in user.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A string with the format "[hub name 1]|[hub ID 1],[hub name 2]|[hub ID 2],..."</returns>
        [XmlRpcMethod("getAllHubs")]
        string GetAllHubs(string sessionToken);

        /// <summary>
        /// Once this method has been called, subsequent API commands in this session will operate on the
        /// specified hub. If this method isn't called at the start of an API session, it will default to
        /// the first hub that was configured for that user.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="hubId">The ID of the hub to use for subsequent API calls.</param>
        /// <returns>The string "ok"</returns>
        [XmlRpcMethod("setHub")]
        string SetHub(string sessionToken, string hubId);

        /// <summary>
        /// Requests status information for the user's selected hub.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A string with the format "[name]|[value],[name]|[value],..."</returns>
        [XmlRpcMethod("getHubStatus")]
        string GetHubStatus(string sessionToken);

        /// <summary>
        /// Requests status information for the user's selected hub.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="statusElement">The name of the specific status element to retrieve.</param>
        /// <returns>The value for the requested status element.</returns>
        [XmlRpcMethod("getHubStatus")]
        string GetHubStatus(string sessionToken, string statusElement);

        /// <summary>
        /// Returns a list of all possible behaviours for the user's selected hub.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A string with the format "Home,Away,Night,..."</returns>
        [XmlRpcMethod("getAllBehaviours")]
        string GetAllBehaviours(string sessionToken);

        /// <summary>
        /// Returns the current behaviour of the user's selected hub. Note that the behaviour only changes when
        /// grace periods have timed out. For instance a hub that is arming will still be considered "Home" until
        /// the grace period expires, at which point it will be changed to "Away" (or "Night").
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>The behaviour name (which will be one of the behaviours returned by GetAllBehaviours).</returns>
        [XmlRpcMethod("getBehaviour")]
        string GetBehaviour(string sessionToken);

        /// <summary>
        /// Returns entries from the event log.
        /// 
        /// Times are in UNIX time format (number of seconds since the Epoch) and refer to UTC unless localisedTime is used.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="serviceName">Specify a service name if you want log entries associated with that service only, or "null" if you don't want any filtering to occur.</param>
        /// <param name="numEntries">The number of entries required (max 50).</param>
        /// <param name="start">The time for the logs to start from.</param>
        /// <param name="end">The time for the logs to end.</param>
        /// <param name="localisedTime">If passed as true then timestamps will refer to the local time of the hub itself rather than UTC/GMT.</param>
        /// <returns>Returns either "no_data" if there are no log messages fitting the specified criteria OR a comma seperated list of log entries in the format "[timestamp]|[zigbeeId|[zigbeeId]|devType|[deviceType]|[message],..."</returns>
        [XmlRpcMethod("getEventLog")]
        string GetEventLog(string sessionToken, string serviceName, int numEntries, int start, int end, bool localisedTime);

        /// <summary>
        /// Returns a list of all services enabled for the user's hub. Note that services that have been disabled by the
        /// user via the web-based AlertMe configuration system will not be listed in the response. Example services are:
        /// IntruderAlarm, EmergencyAlarm, Doorbell.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A list of services with the format "[serviceName1],[serviceName2],..."</returns>
        [XmlRpcMethod("getAllServices")]
        string GetAllServices(string sessionToken);

        /// <summary>
        /// Returns a list of all possible states for a specified service.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="serviceName">The name of the service to retrieve states for.</param>
        /// <returns>A string with the format "[state1],[state2],..."</returns>
        [XmlRpcMethod("getAllServiceStates")]
        string GetAllServiceStates(string sessionToken, string serviceName);

        /// <summary>
        /// Requests the current state for all available services.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A string with the format "[serviceName]|[state],[serviceName]|[state],..."</returns>
        [XmlRpcMethod("getCurrentServiceState")]
        string GetCurrentServiceState(string sessionToken);

        /// <summary>
        /// Requests the current state for a single named service.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="serviceName">The name of the service to obtain a state for.</param>
        /// <returns>A string with the format "[serviceName]|[state],[serviceName]|[state],..."</returns>
        [XmlRpcMethod("getCurrentServiceState")]
        string GetCurrentServiceState(string sessionToken, string serviceName);

        /// <summary>
        /// Sends a command to a service on the hub. Currently available commands for services are:
        /// IntruderAlarm: arm, disarm, nightArm, serverClear.
        /// EmergencyAlarm: serverClear.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="serviceName">The name of the service to send a command for.</param>
        /// <param name="command">The command to send.</param>
        /// <returns>The results of performing the command, typically "ok" or "failed".</returns>
        [XmlRpcMethod("sendCommand")]
        string SendCommand(string sessionToken, string serviceName, string command);

        /// <summary>
        /// Sends a command to a service on the hub. Currently available commands for services are:
        /// IntruderAlarm: arm, disarm, nightArm, serverClear.
        /// EmergencyAlarm: serverClear.
        /// Energy: on, off (must specifiy the SmartPlug device ID).
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="serviceName">The name of the service to send a command for.</param>
        /// <param name="command">The command to send.</param>
        /// <param name="smartPlugDeviceId">The ID of the SmartPlug device when using the "Energy" service.</param>
        /// <returns>The results of performing the command, typically "ok" or "failed".</returns>
        [XmlRpcMethod("sendCommand")]
        string SendCommand(string sessionToken, string serviceName, string command, string smartPlugDeviceId);
        
        /// <summary>
        /// Returns a list of all devices in the user's system.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <returns>A list of devices with the format "[deviceName1]|[deviceId1]|[deviceType1],[deviceName2]|[deviceId2]|[deviceType2],..."</returns>
        [XmlRpcMethod("getAllDevices")]
        string GetAllDevices(string sessionToken);

        /// <summary>
        /// Returns details about a particular device.
        /// </summary>
        /// <param name="sessionToken">The current session token.</param>
        /// <param name="deviceId">The ID of the device to retrieve details for.</param>
        /// <returns>A string with the format "Type|[device type],Id|[device Id],SoftwareVersion|[software version],HardwareVersion|[hardware version]"</returns>
        [XmlRpcMethod("getDeviceDetails")]
        string GetDeviceDetails(string sessionToken, string deviceId);

        /// <summary>
        /// Returns the channels available on a particular device. Channels are types of data that a
        /// particular device  provides. Examples are "Temperature", "LQI", "BatteryLevel" or "PowerLevel"
        /// (for energy measuring devices).
        /// </summary>
        /// <param name="sessionId">The current session token.</param>
        /// <param name="deviceId">The ID of the device to retrieve channels for</param>
        /// <returns>A list of channels for that device in the format "[channel1],[channel2],..."</returns>
        [XmlRpcMethod("getAllDeviceChannels")]
        string GetAllDeviceChannels(string sessionId, string deviceId);

        /// <summary>
        /// Returns entries from the device log.
        /// 
        /// Times are in UNIX time format (number of seconds since the Epoch) and refer to UTC unless localisedTime is used.
        /// </summary>
        /// <param name="sessionId">The current session token.</param>
        /// <param name="deviceId">The ID of the device to retrieve logs for.</param>
        /// <param name="channelName">The channel name for the device to retrieve logs for.</param>
        /// <param name="numEntries">The number of entries required (max 50).</param>
        /// <param name="start">The time for the logs to start from.</param>
        /// <param name="end">The time for the logs to end.</param>
        /// <returns>The string "no_data" if there are no log messages fitting the specified criteria OR a string with the format "[date]|[log],[date]|[log],..."</returns>
        [XmlRpcMethod("getDeviceChannelLog")]
        string GetDeviceChannelLog(string sessionId, string deviceId, string channelName, int numEntries, int start, int end);

        /// <summary>
        /// Returns the current values for all available channels for a particular device.
        /// </summary>
        /// <param name="sessionId">The current session token.</param>
        /// <param name="deviceId">The ID of the device to examine.</param>
        /// <returns>The value for all available channels for the given device.</returns>
        [XmlRpcMethod("getDeviceChannelValue")]
        [Obsolete("Use GetAllDeviceChannelValues instead as this API call has problems with several values (like negative temperature values).")]
        string GetDeviceChannelValue(string sessionId, string deviceId);

        /// <summary>
        /// Returns the current values for a given channel on a particular device.
        /// </summary>
        /// <param name="sessionId">The current session token.</param>
        /// <param name="deviceId">The ID of the device to examine.</param>
        /// <param name="channelName">The channel name to retrieve a value for.</param>
        /// <returns>The value for the given channel for the given device.</returns>
        [XmlRpcMethod("getDeviceChannelValue")]
        string GetDeviceChannelValue(string sessionId, string deviceId, string channelName);

        /// <summary>
        /// Returns the current values for all available channels on all available devices.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="deviceId">The ID of the device to examine.</param>
        /// <returns>A string in the format TODO</returns>
        [XmlRpcMethod("getAllDeviceChannelValues")]
        string GetAllDeviceChannelValues(string sessionId);

    }
}
