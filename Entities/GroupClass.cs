using Newtonsoft.Json;
using System.Collections.Generic;

namespace CP_Preprocessing.Entities
{
    public class GroupClass
    {
        [JsonProperty("資訊學群")]
        public List<InformationScience> information { get; set; }

        [JsonProperty("工程學群")]
        public List<Engineering> engineerings { get; set; }

        [JsonProperty("大眾傳播學群")]
        public List<MassCommunications> communications { get; set; }

        [JsonProperty("數理化學群")]
        public List<MathAndChemical> mathAndChemicals { get; set; }

        [JsonProperty("生命科學學群")]
        public List<LifeSciences> lifeSciences { get; set; }

        [JsonProperty("管理學群")]
        public List<Management> managements { get; set; }

        [JsonProperty("財經學群")]
        public List<FinancialAndEconomics> financials { get; set; }

        [JsonProperty("法政學群")]
        public List<LawAndPolicy> lawAndPolicies { get; set; }

        [JsonProperty("外語學群")]
        public List<ForeignLanguage> foreignLanguages { get; set; }

        [JsonProperty("生物資源學群")]
        public List<Bioresources> bioresources { get; set; }

        [JsonProperty("教育學群")]
        public List<Education> educations { get; set; }

        [JsonProperty("藝術學群")]
        public List<Art> arts { get; set; }

        [JsonProperty("地球與環境學群")]
        public List<EarthAndEnvironment> earthAndEnvironments { get; set; }

        [JsonProperty("社會與心理學群")]
        public List<SocialAndPsychology> socialAndPsychologies { get; set; }

        [JsonProperty("醫藥衛生學群")]
        public List<MedicalHealth> medicalHealths { get; set; }

        [JsonProperty("遊憩與運動學群")]
        public List<RecreationAndKinematics> recreationAndKinematics { get; set; }

        [JsonProperty("建築與設計學群")]
        public List<ArchitectureAndDesign> architectureAndDesigns { get; set; }

        [JsonProperty("文史哲學群")]
        public List<Literary> literaries { get; set; }
    }
}
