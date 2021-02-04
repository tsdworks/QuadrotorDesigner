using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Studio.IO
{
    public class FStream
    {
        public static bool WriteStreamToTextFile(string fileName, string stringToWrite)
        {
            bool retValue = false;

            try
            {
                string filePath = Path.GetDirectoryName(fileName);
                Directory.CreateDirectory(filePath);

                FileStream fileStream =
                    new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter streamWriter = new StreamWriter(fileStream);

                streamWriter.Write(stringToWrite);
                streamWriter.Flush();
                streamWriter.Close();

                fileStream.Close();
            }
            catch (Exception) { };

            return retValue;
        }

        public static string ReadStreamFromTextFile(string fileName)
        {
            string retValue = string.Empty;

            try
            {
                if (File.Exists(fileName))
                {
                    FileStream fileStream =
                        new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(fileStream);

                    retValue = streamReader.ReadToEnd();

                    streamReader.Close();

                    fileStream.Close();
                }
            }
            catch (Exception) { };

            return retValue;
        }

        public static string CombinePath(string pathToCombine1, string pathToCombine2, bool isURLStyle)
        {
            string retValue = string.Empty;

            char splitChar = isURLStyle ? '/' : '\\';

            try
            {
                if (pathToCombine1 != string.Empty && pathToCombine2 != string.Empty)
                {
                    if (pathToCombine1[pathToCombine1.Length - 1] != splitChar)
                    {
                        if (pathToCombine2[0] != splitChar)
                        {
                            retValue = pathToCombine1 + splitChar.ToString() + pathToCombine2;
                        }
                        else if (pathToCombine2[0] == splitChar)
                        {
                            retValue = pathToCombine1 + pathToCombine2;
                        }
                    }
                    else
                    {
                        if (pathToCombine2[0] != splitChar)
                        {
                            retValue = pathToCombine1 + pathToCombine2;
                        }
                        else if (pathToCombine2[0] == splitChar)
                        {
                            retValue = pathToCombine1.Substring(0, pathToCombine1.Length - 1) + pathToCombine2;
                        }
                    }
                }
            }
            catch (Exception) { };

            return retValue;
        }

        public class SerializerHelper
        {
            public static void Serialize<T>(T obj, string file)
            {
                using (var fs = File.CreateText(file))
                {
                    var serializer = new JsonSerializer();
                    serializer.Converters.Add(new StringEnumConverter());
                    serializer.Formatting = Formatting.Indented;

                    serializer.Serialize(fs, obj);
                }
            }

            public static T Deserialize<T>(string file) where T : class
            {
                using (var fs = File.OpenText(file))
                {
                    var serializer = new JsonSerializer();
                    serializer.Converters.Add(new StringEnumConverter());

                    var result = serializer.Deserialize(fs, typeof(T));
                    return result as T;
                }
            }
        }
    }
}
