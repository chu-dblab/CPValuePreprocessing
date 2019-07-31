using Newtonsoft.Json;
using AutoMapper;
using AutoMapper.Configuration.Annotations;

namespace CP_Preprocessing.Entities
{
    [AutoMap(typeof(U_CP))]
    public class School
    {
       [SourceMember(nameof(U_CP.Uname))]
        public string name { get; set; }

        [JsonProperty("平均分數")]
        [SourceMember(nameof(U_CP.MinScore))]
        public double AverageScore { get; set; }

        [JsonProperty("平均薪資")]
        [SourceMember(nameof(U_CP.SalaryInK))]
        public double AverageSalary { get; set; }

        [JsonProperty("分數百分位(P)")]
        [SourceMember(nameof(U_CP.P))]
        public double ScorePercentile { get; set; }

        [JsonProperty("薪資百分位(C)")]
        [SourceMember(nameof(U_CP.C))]
        public double SalaryPercentile { get; set; }

        [JsonProperty("CP值")]
        [SourceMember(nameof(U_CP.CP))]
        public double CPValue { get; set; }
    }
}
