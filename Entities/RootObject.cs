using Newtonsoft.Json;
using System.Collections.Generic;

namespace CP_Preprocessing.Entities
{
    public class RootObject
    {
        [JsonProperty("一般分類")]
        public GeneralClass generals { get; set; }

        [JsonProperty("學群分類")]
        public GroupClass groups { get; set; }
    }
}
