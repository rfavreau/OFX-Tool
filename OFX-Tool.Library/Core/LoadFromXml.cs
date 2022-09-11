﻿using RFD.OFXTool.Library.Core.Elements;
using RFD.OFXTool.Library.Entities;
using System.Xml;

namespace RFD.OFXTool.Library.Core
{
    public class LoadFromXml
    {
        public string XmlFile { get; }
        public ResponseDocument OfxDocument { get; }

        public LoadFromXml(string xmlFile)
        {
            XmlFile = xmlFile;
            OfxDocument = new ResponseDocument();

            //
            Extract();

        }

        private void Extract()
        {
            // 
            var xmlReader = new XmlTextReader(XmlFile);
            try
            {
                while (xmlReader.Read())
                {
                    //
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name.Equals(Entity.GetElement<SignonResponseMessageSetV1>()))
                    {
                        OfxDocument.SignonResponseMessageSetV1 = new SIGNONMSGSRSV1().Load(xmlReader);
                    }

                    //
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name.Equals(Entity.GetElement<BankResponseMessageSetV1>()))
                    {
                        OfxDocument.BankResponseMessageSetV1 = new BANKMSGSRSV1().Load(xmlReader);
                    }
                }
            }
            catch (Exception e)
            {
                throw new OFXToolException($"Invalid OFX file! [{e.Message}]", e);
            }
            finally
            {
                xmlReader.Close();
            }
        }
    }
}