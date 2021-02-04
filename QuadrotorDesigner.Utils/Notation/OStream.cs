using fastJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Utils.Notation
{
    public class OStream
    {
        static public string GetObjectStream<T>(T obj, bool beautify)
        {
            string retValue = string.Empty;

            try
            {
                JSONParameters parameter = new JSONParameters();

                parameter.UseExtensions = false;
                parameter.KVStyleStringDictionary = false;

                retValue = beautify ? JSON.ToNiceJSON(obj, parameter) : JSON.ToJSON(obj, parameter);
            }
            catch (Exception) { };

            return retValue;
        }

        static public T GetStreamObject<T>(string stream)
        {
            T retValue = default(T);

            try
            {
                retValue = JSON.ToObject<T>(stream);
            }
            catch (Exception) { };

            return retValue;
        }
    }
}
