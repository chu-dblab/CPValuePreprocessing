using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CP_Preprocessing.Entities;

namespace CP_Preprocessing
{
    public class CPValueOperation
    {
        private PredictionEntities db;

        public CPValueOperation()
        {
            db = new PredictionEntities();
        }

        public IConfigurationProvider GetConfiguration(Type type)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => cfg.AddMaps(type));
            var mapper = new Mapper(config);
            return mapper.DefaultContext.ConfigurationProvider;
        }

        public RootObject GetRootObject()
        {
            return new RootObject
            {
                generals = GetGeneralClass(),
                groups = GetGroupClass()
            };
        }

        public GeneralClass GetGeneralClass()
        {
            GeneralClass general = new GeneralClass
            {
                groups = GetGroups(),
                departments = GetDepartments(),
                schools = GetSchools()
            };
            return general;
        }

        public GroupClass GetGroupClass()
        {
            return new GroupClass
            {
                information = GetInformationSciences(),
                engineerings = GetEngineerings(),
                earthAndEnvironments = GetEarthAndEnvironments(),
                educations = GetEducations(),
                architectureAndDesigns = GetArchitectureAndDesigns(),
                arts = GetArts(),
                managements = GetManagements(),
                mathAndChemicals = GetMathAndChemicals(),
                communications = GetMassCommunications(),
                medicalHealths = GetMedicalHealths(),
                bioresources = GetBioresources(),
                socialAndPsychologies = GetSocialAndPsychologies(),
                recreationAndKinematics = GetRecreationAndKinematics(),
                lawAndPolicies = GetLawAndPolicies(),
                foreignLanguages = GetForeignLanguages(),
                financials = GetFinancialAndEconomics(),
                lifeSciences = GetLifeSciences(),
                literaries = GetLiteraries()
            };
        }

        #region 一般分類--各類別之間欄位的對應
        public List<School> GetSchools()
        {
            return db.U_CP.OrderByDescending(a => a.CP)
                .ThenByDescending(a=>a.SalaryInK).ThenByDescending(a=>a.MinScore)
                .ProjectTo<School>(GetConfiguration(typeof(School))).ToList();
           
        }

        public List<Department> GetDepartments()
        {
            return db.D_CP.OrderByDescending(a => a.CP)
                .ThenByDescending(a => a.SalaryInK).ThenByDescending(a => a.MinScore)
                .ProjectTo<Department>(GetConfiguration(typeof(Department))).ToList();
        }

        public List<Group> GetGroups()
        {
            return db.G_CP.OrderByDescending(a => a.CP)
                          .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                          .ProjectTo<Group>(GetConfiguration(typeof(G_CP))).ToList();
        }
        #endregion

        #region 各學群的欄位對應
        public List<ArchitectureAndDesign> GetArchitectureAndDesigns()
        {
            return db.建築與設計學群_CP.OrderByDescending(a => a.CP)
                            .ThenByDescending(a => a.SalaryInK).ThenByDescending(a => a.MinScore)
                            .ProjectTo<ArchitectureAndDesign>(GetConfiguration(typeof(ArchitectureAndDesign))).ToList();

        }

        public List<Bioresources> GetBioresources()
        {
            return db.生物資源學群_CP.OrderByDescending(a => a.CP)
                     .ThenByDescending(a => a.SalaryInK).ThenByDescending(a => a.MinScore)
                     .ProjectTo<Bioresources>(GetConfiguration(typeof(Bioresources))).ToList();
        }

        public List<EarthAndEnvironment> GetEarthAndEnvironments()
        {
            return db.地球與環境學群_CP.OrderByDescending(a => a.CP)
                     .ThenByDescending(a => a.SalaryInK).ThenByDescending(a => a.MinScore)
                     .ProjectTo<EarthAndEnvironment>(GetConfiguration(typeof(EarthAndEnvironment))).ToList();
        }

        public List<LifeSciences> GetLifeSciences()
        {
            return db.生命科學學群_CP.OrderByDescending(a => a.CP)
                                   .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                   .ProjectTo<LifeSciences>(GetConfiguration(typeof(LifeSciences))).ToList();
        }

        public List<InformationScience> GetInformationSciences()
        {
            return db.資訊學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<InformationScience>(GetConfiguration(typeof(InformationScience))).ToList();

        }

        public List<Engineering> GetEngineerings()
        {
            return db.工程學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<Engineering>(GetConfiguration(typeof(Engineering))).ToList();
        }

        public List<Education> GetEducations()
        {
            return db.教育學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<Education>(GetConfiguration(typeof(Education))).ToList();
        }

        public List<FinancialAndEconomics> GetFinancialAndEconomics()
        {
            return db.財經學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<FinancialAndEconomics>(GetConfiguration(typeof(FinancialAndEconomics))).ToList();
        }

        public List<ForeignLanguage> GetForeignLanguages()
        {
            return db.外語學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<ForeignLanguage>(GetConfiguration(typeof(ForeignLanguage))).ToList();
        }

        public List<LawAndPolicy> GetLawAndPolicies()
        {
            return db.法政學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<LawAndPolicy>(GetConfiguration(typeof(LawAndPolicy))).ToList();
        }

        public List<Literary> GetLiteraries()
        {
            return db.文史哲學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<Literary>(GetConfiguration(typeof(Literary))).ToList();
        }

        public List<Management> GetManagements()
        {
            return db.管理學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<Management>(GetConfiguration(typeof(Management))).ToList();
        }

        public List<MassCommunications> GetMassCommunications()
        {
            return db.大眾傳播學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<MassCommunications>(GetConfiguration(typeof(MassCommunications))).ToList();
        }

        public List<MathAndChemical> GetMathAndChemicals()
        {
            return db.數理化學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<MathAndChemical>(GetConfiguration(typeof(MathAndChemical))).ToList();
        }

        public List<MedicalHealth> GetMedicalHealths()
        {
            return db.醫藥衛生學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<MedicalHealth>(GetConfiguration(typeof(MedicalHealth))).ToList();
        }

        public List<RecreationAndKinematics> GetRecreationAndKinematics()
        {
            return db.遊憩與運動學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<RecreationAndKinematics>(GetConfiguration(typeof(RecreationAndKinematics))).ToList();
        }

        public List<SocialAndPsychology> GetSocialAndPsychologies()
        {
            return db.社會與心理學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<SocialAndPsychology>(GetConfiguration(typeof(SocialAndPsychology))).ToList();
        }

        public List<Art> GetArts()
        {
            return db.藝術學群_CP.OrderByDescending(a => a.CP)
                                .ThenBy(a => a.SalaryInK).ThenBy(a => a.MinScore)
                                .ProjectTo<Art>(GetConfiguration(typeof(Art))).ToList();
        }
        #endregion

        
    }
}
