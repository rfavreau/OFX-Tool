﻿using RFD.OFXTool.Library.Entities;
using System.Xml;

namespace RFD.OFXTool.Library.Core.Extract
{
    internal class ExtractSIGNONMSGSRSV1
    {
        internal SignonResponseMessageSetV1 Element { get; }

        internal ExtractSIGNONMSGSRSV1(XmlTextReader xmlReader)
        {
            Element = new SignonResponseMessageSetV1();

            while (xmlReader.Read())
            {
                // End of this element object
                if (xmlReader.NodeType == XmlNodeType.EndElement && xmlReader.Name.Equals("SIGNONMSGSRSV1"))
                {
                    break;
                }

                // SONRS element object
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name.Equals("SONRS"))
                {
                    Element.SignonResponse = new ExtractSONRS(xmlReader).Element;
                }
            }
        }
    }
}