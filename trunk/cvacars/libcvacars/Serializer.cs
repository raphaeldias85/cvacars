using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace libcvacars
{
    static class Serializer
    {
        public static void BSerialize( object o, string path )
        {
            FileStream fs = File.Open( path, FileMode.CreateNew );
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize( fs, o );
            fs.Close();
            fs.Dispose();
        }
        public static object BDeserialize( string path )
        {
            FileStream fs = File.Open( path, FileMode.Open );
            BinaryFormatter bf = new BinaryFormatter();
            object o = bf.Deserialize( fs );
            fs.Close();
            fs.Dispose();
            return o;
        }
        /*public static void XSerialize( object obb, string path )
        {
            TextWriter tw = new StreamWriter( File.Open( path, FileMode.CreateNew ) );
            XmlSerializer xs = new XmlSerializer( typeof( obb ) );
        }*/
    }
}
