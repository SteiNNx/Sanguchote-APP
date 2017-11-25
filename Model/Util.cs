﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Model
{
    public static class Util
    {
        public static CL_Compra DeserializeCompra<CL_Compra>(string xml)
        {

            if (string.IsNullOrEmpty(xml))
            {
                return default(CL_Compra);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(CL_Compra));

            XmlReaderSettings settings = new XmlReaderSettings();
            // No settings need modifying here

            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (CL_Compra)serializer.Deserialize(xmlReader);
                }
            }
        }

        public static CL_DetalleCompra DeserializeDetalleCompra<CL_DetalleCompra>(string xml)
        {

            if (string.IsNullOrEmpty(xml))
            {
                return default(CL_DetalleCompra);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(CL_DetalleCompra));

            XmlReaderSettings settings = new XmlReaderSettings();
            // No settings need modifying here

            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (CL_DetalleCompra)serializer.Deserialize(xmlReader);
                }
            }
        }

        public static string SerializeCompra<CL_Compra>(CL_Compra value)
        {

            if (value == null)
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(CL_Compra));

            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Encoding = new UnicodeEncoding(false, false), // no BOM in a .NET string
                Indent = false,
                OmitXmlDeclaration = false
            };

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, value);
                }
                return textWriter.ToString();
            }
        }
        public static string SerializeDetalleCompra<CL_DetalleCompra>(CL_DetalleCompra value)
        {

            if (value == null)
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(CL_DetalleCompra));

            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Encoding = new UnicodeEncoding(false, false), // no BOM in a .NET string
                Indent = false,
                OmitXmlDeclaration = false
            };

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, value);
                }
                return textWriter.ToString();
            }
        }

    }
}