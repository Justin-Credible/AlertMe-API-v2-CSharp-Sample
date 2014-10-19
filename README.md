AlertMe API v2 - C# Sample Application
=============================

The AlertMe API is a home automation API that is used by Lowe's Iris Smart Home platform (among others). I put together this repository as an example of how to make calls to the XML-RPC API using C#.

## Overview ##

The official AlertMe documentation is included in the `AlertMe Web API 2.2.pdf` file. This is the file that was used to build and document the C# API.

The C# API is located in the `IAlertMeApi.cs` file which contains annotations that are consumed by the `XmlRcp` library.

Currently, the API allows for logging in, retrieving hub information, and querying of device status. It does include a call for sending commands to individual devices, but the API doc doesn't list all of the commands.

It is also important to note that this is not feature complete. I've instead opted to work in the [v5 API](https://github.com/Justin-Credible/AlertMe-API-v5-CSharp-Sample) which is a REST API that has much more complete documentation.

Finally, a quick and dirty WinForms application is also included which allows for quick testing of each API call. Parameters can be pipe delimited an entered into the parameters text box, and the responses will appear as pipe delimited strings (per the API doc) in the responses text box. 

## Why? ##

First and foremost, I wanted to write my own mobile application, using C# to make the API calls.

Second, the AlertMe system is the backbone of both the Lowe's Iris and British Gas 'Safe & Secure' products, neither of these services currently provide a publicly documented API interface. I would encourage you to contact the retailers of these products and request that this facility be added, as there is no good reason for its omission.

## Additional Resources

[AlertMePy](https://github.com/birdslikewires/AlertMePy) - A Python implementation of the AlertMe v2 API

[AlertMe Web API Documentation v2.02](http://support.alertme.com/ics/support/DLRedirect.asp?fileNum=82326&deptID=5503) - The official API in PDF format

[AlertMe Web API Example Code](https://api.alertme.com/webapi/test/v2/) - Contains a HTML test page with a JavaScript implementation as well as some Python source code

I've also included the PDF documentation in this repository in case the URL's above go dark. It is available [here](https://github.com/Justin-Credible/AlertMe-API-v2-CSharp-Sample/blob/master/AlertMe%20Web%20API%202.2.pdf).

## Future ##

After writing this API I found out that there is a much better documented and easier to use RESTful API available. I've stopped working on this API in favor of the new one. It can be found [here](https://github.com/Justin-Credible/AlertMe-API-v5-CSharp-Sample).

## License ##

Copyright © 2014 Justin Unterreiner.

Released under an MIT license; see [LICENSE](https://github.com/Justin-Credible/AlertMe-API-v2-CSharp-Sample/blob/master/LICENSE) for more information.