using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace StoreWebCore.Helpers
{
    public static  class SessionHelpers
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetOBjectFromJson<T>(this ISession  session, string key) {
            var value = session.GetString(key);
            return value== null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
