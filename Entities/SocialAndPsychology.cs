using Newtonsoft.Json;
using AutoMapper;
using AutoMapper.Configuration.Annotations;

namespace CP_Preprocessing.Entities
{
    [AutoMap(typeof(社會與心理學群_CP))]
    public class SocialAndPsychology
    {
        [JsonProperty("校名")]
        [SourceMember(nameof(社會與心理學群_CP.Uname))]
        public string SchoolName { get; set; }

        [JsonProperty("系名")]
        [SourceMember(nameof(社會與心理學群_CP.Dname))]
        public string DepartName { get; set; }

        [SourceMember(nameof(社會與心理學群_CP.UDname))]
        public string name { get; set; }

        [JsonProperty("平均分數")]
        [SourceMember(nameof(社會與心理學群_CP.MinScore))]
        public double AverageScore { get; set; }

        [JsonProperty("平均薪資")]
        [SourceMember(nameof(社會與心理學群_CP.SalaryInK))]
        public double AverageSalary { get; set; }

        [JsonProperty("分數百分位(P)")]
        [SourceMember(nameof(社會與心理學群_CP.P))]
        public double ScorePercentile { get; set; }

        [JsonProperty("薪資百分位(C)")]
        [SourceMember(nameof(社會與心理學群_CP.C))]
        public double SalaryPercentile { get; set; }

        [JsonProperty("CP值")]
        [SourceMember(nameof(社會與心理學群_CP.CP))]
        public double CPValue { get; set; }
    }
}
