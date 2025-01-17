﻿// See https://aka.ms/new-console-template for more information
using RFD.OFXTool.Library;

Console.WriteLine("Welcom to OFX-Tool!\n");

Console.WriteLine("\n# Loading an OFX file...");
var MyOfx = new OfxTool("S:\\Downloads\\TL59.ofx");

if (MyOfx.Ofx.Response.SignonResponseMessageSetV1.SignonResponse.Status.Code == "0")
{
    Console.WriteLine("OFX document is loaded.");
}


Console.WriteLine("\n\n>> You can now work with the OFX data...");


Console.WriteLine("\n\n# Building an OFX file...");
MyOfx.Build("S:\\Downloads\\TL59-RFD.ofx");
if (File.Exists("S:\\Downloads\\TL59-RFD.ofx"))
{
    Console.WriteLine("OFX file is created.");
}