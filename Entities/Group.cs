using Newtonsoft.Json;
using AutoMapper;
using AutoMapper.Configuration.Annotations;

namespace CP_Preprocessing.Entities
{
   [AutoMap(typeof(G_CP))]
    public class Group
    {
        [SourceMember(nameof(G_CP.Gname))]
        public string name { get; set; }

        [JsonProperty("平均分數")]
        [SourceMember(nameof(G_CP.MinScore))]
        public double AverageScore { get; set; }

        [JsonProperty("平均薪資")]
        [SourceMember(nameof(G_CP.SalaryInK))]
        public double AverageSalary { get; set; }

        [JsonProperty("分數百分位(P)")]
        [SourceMember(nameof(G_CP.P))]
        public double ScorePercentile { get; set; }

        [JsonProperty("薪資百分位(C)")]
        [SourceMember(nameof(G_CP.C))]
        public double SalaryPercentile { get; set; }

        [JsonProperty("CP值")]
        [SourceMember(nameof(G_CP.CP))]
        public double CPValue { get; set; }
    }
}
