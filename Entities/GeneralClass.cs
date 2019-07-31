using Newtonsoft.Json;
using System.Collections.Generic;

namespace CP_Preprocessing.Entities
{
    public class GeneralClass
    {
        [JsonProperty("學校")]
        public List<School> schools { get; set; }

        [JsonProperty("學群")]
        public List<Group> groups { get; set; }

        [JsonProperty("科系")]
        public List<Department> departments { get; set; }
    }
}
