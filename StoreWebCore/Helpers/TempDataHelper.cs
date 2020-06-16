using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreWebCore.Helpers
{
    public static class TempDataHelper
    {

        public static void Put<T>(this ITempDataDictionary tempData, string key, T value)where T:class {
            tempData[key] = JsonConvert.SerializeObject(value);
        }

        public static T Get<T>(this ITempDataDictionary temData, string key) where T : class {
            object o;
            temData.TryGetValue(key, out o);
            return  JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}
