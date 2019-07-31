using Newtonsoft.Json;
using AutoMapper;
using AutoMapper.Configuration.Annotations;

namespace CP_Preprocessing.Entities
{
    [AutoMap(typeof(D_CP))]
    public class Department
    {
        [JsonProperty("校名")]
        [SourceMember(nameof(D_CP.Uname))]
        public string SchoolName { get; set; }

        [JsonProperty("系名")]
        [SourceMember(nameof(D_CP.Dname))]
        public string DepartName { get; set; }

        [SourceMember(nameof(D_CP.UDname))]
        public string name { get; set; }

        [JsonProperty("平均分數")]
        [SourceMember(nameof(D_CP.MinScore))]
        public double AverageScore { get; set; }

        [JsonProperty("平均薪資")]
        [SourceMember(nameof(D_CP.SalaryInK))]
        public double AverageSalary { get; set; }

        [JsonProperty("分數百分位(P)")]
        [SourceMember(nameof(D_CP.P))]
        public double ScorePercentile { get; set; }

        [JsonProperty("薪資百分位(C)")]
        [SourceMember(nameof(D_CP.C))]
        public double SalaryPercentile { get; set; }

        [JsonProperty("CP值")]
        [SourceMember(nameof(D_CP.CP))]
        public double CPValue { get; set; }
    }
}
