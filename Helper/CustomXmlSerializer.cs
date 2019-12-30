using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CurrencyExchangeRate.Helper
{
    public class CustomXmlSerializer<T>
    {   
        private XmlSerializer serializer;
        public CustomXmlSerializer<T> Build(string root){
            serializer = new XmlSerializer(typeof(List<T>),new XmlRootAttribute(root));
            return this;
        }

        public List<T> GetList(Stream stream){
            if(serializer == null){
                throw new Exception("Serializer must be built");
            }
            try{
                List<T> list = (List<T>)serializer.Deserialize(stream);
                return list;
            }catch(Exception ex){
                throw ex;
            } 
        }

    }
}