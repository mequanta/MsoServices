using System;
using SmartQuant;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SmartQuant
{
    public static class Extensions
    {
        public static string AsJson(this IProvider provider)
        {
            return string.Format("{{id:{0},name:{1}}}", provider.Id, provider.Name);
        }

        public static string AsJson(this ProviderManager manager)
        {
            var count = manager.Providers.Count;
            var sb = new StringBuilder();
            sb.Append("{");
            sb.AppendFormat("count:{0},", count);
            var list = new List<string>(count);
            foreach (var provider in manager.Providers)
                list.Add(provider.AsJson());
            sb.AppendFormat("providers:[{0}]", string.Join(",", list));
            sb.Append("}");
            return sb.ToString();
        }
    }
}
