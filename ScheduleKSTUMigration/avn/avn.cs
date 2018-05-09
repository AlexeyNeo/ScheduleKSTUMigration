namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class avn : DbContext
    {
        public avn()
            : base("name=avn")
        {
        }

        public virtual DbSet<C___Directions> C___Directions { get; set; }
        public virtual DbSet<C___T_TempSerachBookFiles> C___T_TempSerachBookFiles { get; set; }
        public virtual DbSet<C__s_g_mirror> C__s_g_mirror { get; set; }
        public virtual DbSet<a_year> a_year { get; set; }
        public virtual DbSet<a_year_1> a_year_1 { get; set; }
        public virtual DbSet<Ab_InfoOnEdIns> Ab_InfoOnEdIns { get; set; }
        public virtual DbSet<Ab_MilitaryInfo> Ab_MilitaryInfo { get; set; }
        public virtual DbSet<Ab_ParentsInfo> Ab_ParentsInfo { get; set; }
        public virtual DbSet<Abit_disp_report> Abit_disp_report { get; set; }
        public virtual DbSet<Abit_Log> Abit_Log { get; set; }
        public virtual DbSet<abit_razryd> abit_razryd { get; set; }
        public virtual DbSet<Abit_razryd_sport> Abit_razryd_sport { get; set; }
        public virtual DbSet<Abit_smi> Abit_smi { get; set; }
        public virtual DbSet<Abit_sostav_priem> Abit_sostav_priem { get; set; }
        public virtual DbSet<Abit_spec_disp> Abit_spec_disp { get; set; }
        public virtual DbSet<Abiturient> Abiturient { get; set; }
        public virtual DbSet<AbiturientPhoto> AbiturientPhoto { get; set; }
        public virtual DbSet<AbiturientTest> AbiturientTest { get; set; }
        public virtual DbSet<Abroad> Abroad { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Admin_temp_online_payment> Admin_temp_online_payment { get; set; }
        public virtual DbSet<aud_discip_rasp> aud_discip_rasp { get; set; }
        public virtual DbSet<Aud_rastoynie> Aud_rastoynie { get; set; }
        public virtual DbSet<Auditoriums> Auditoriums { get; set; }
        public virtual DbSet<Aurochs> Aurochs { get; set; }
        public virtual DbSet<AVN_Log> AVN_Log { get; set; }
        public virtual DbSet<AVN_Prog_List> AVN_Prog_List { get; set; }
        public virtual DbSet<AVN_Progs> AVN_Progs { get; set; }
        public virtual DbSet<AVN_rep_user> AVN_rep_user { get; set; }
        public virtual DbSet<AVN_report_role> AVN_report_role { get; set; }
        public virtual DbSet<AVN_reports> AVN_reports { get; set; }
        public virtual DbSet<AVN_Security> AVN_Security { get; set; }
        public virtual DbSet<AVN_svyazi> AVN_svyazi { get; set; }
        public virtual DbSet<AVN_Test_category> AVN_Test_category { get; set; }
        public virtual DbSet<AVN_Test_samoozenka> AVN_Test_samoozenka { get; set; }
        public virtual DbSet<AVN_TEST_SREZ> AVN_TEST_SREZ { get; set; }
        public virtual DbSet<AVN_TEST_TestResult> AVN_TEST_TestResult { get; set; }
        public virtual DbSet<AVN_Test_type> AVN_Test_type { get; set; }
        public virtual DbSet<AVN_Test_vopros> AVN_Test_vopros { get; set; }
        public virtual DbSet<AVN_User> AVN_User { get; set; }
        public virtual DbSet<AVNStudent> AVNStudent { get; set; }
        public virtual DbSet<AVNTeacher> AVNTeacher { get; set; }
        public virtual DbSet<_base> _base { get; set; }
        public virtual DbSet<bk> bk { get; set; }
        public virtual DbSet<Bronya> Bronya { get; set; }
        public virtual DbSet<CallEducationInst> CallEducationInst { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Citizenship> Citizenship { get; set; }
        public virtual DbSet<CityKR> CityKR { get; set; }
        public virtual DbSet<com_gspe> com_gspe { get; set; }
        public virtual DbSet<com_kt> com_kt { get; set; }
        public virtual DbSet<com_sfe> com_sfe { get; set; }
        public virtual DbSet<com_ygr> com_ygr { get; set; }
        public virtual DbSet<come> come { get; set; }
        public virtual DbSet<component> component { get; set; }
        public virtual DbSet<control> control { get; set; }
        public virtual DbSet<ControlRating> ControlRating { get; set; }
        public virtual DbSet<country> country { get; set; }
        public virtual DbSet<DatabaseVersion> DatabaseVersion { get; set; }
        public virtual DbSet<DATE_reg_DFS> DATE_reg_DFS { get; set; }
        public virtual DbSet<Day> Day { get; set; }
        public virtual DbSet<Debts> Debts { get; set; }
        public virtual DbSet<deduce> deduce { get; set; }
        public virtual DbSet<Def_Uslug> Def_Uslug { get; set; }
        public virtual DbSet<Del_DisciplineForStudent> Del_DisciplineForStudent { get; set; }
        public virtual DbSet<Del_Educ_sh> Del_Educ_sh { get; set; }
        public virtual DbSet<Del_Mark_Mag> Del_Mark_Mag { get; set; }
        public virtual DbSet<Del_movement_t> Del_movement_t { get; set; }
        public virtual DbSet<Del_payment> Del_payment { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DIPL_PRIX> DIPL_PRIX { get; set; }
        public virtual DbSet<Diploma_kval> Diploma_kval { get; set; }
        public virtual DbSet<direction> direction { get; set; }
        public virtual DbSet<disc_n_sv> disc_n_sv { get; set; }
        public virtual DbSet<discipline> discipline { get; set; }
        public virtual DbSet<disciplineForGos> disciplineForGos { get; set; }
        public virtual DbSet<DisciplineForStudent> DisciplineForStudent { get; set; }
        public virtual DbSet<DisciplineForStudent2> DisciplineForStudent2 { get; set; }
        public virtual DbSet<DisciplineForStudentDeleted> DisciplineForStudentDeleted { get; set; }
        public virtual DbSet<DisciplineForStudentForVidZaniatiy> DisciplineForStudentForVidZaniatiy { get; set; }
        public virtual DbSet<disciplineForZashita> disciplineForZashita { get; set; }
        public virtual DbSet<DistrictKR> DistrictKR { get; set; }
        public virtual DbSet<dopolnitelno> dopolnitelno { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<dv> dv { get; set; }
        public virtual DbSet<ebe> ebe { get; set; }
        public virtual DbSet<ebe_detal> ebe_detal { get; set; }
        public virtual DbSet<Edu> Edu { get; set; }
        public virtual DbSet<Educ> Educ { get; set; }
        public virtual DbSet<educ_form> educ_form { get; set; }
        public virtual DbSet<educ_sh> educ_sh { get; set; }
        public virtual DbSet<educ_sh_kpv> educ_sh_kpv { get; set; }
        public virtual DbSet<Educ_sh_sel> Educ_sh_sel { get; set; }
        public virtual DbSet<Educ_t> Educ_t { get; set; }
        public virtual DbSet<ee> ee { get; set; }
        public virtual DbSet<Elect_org> Elect_org { get; set; }
        public virtual DbSet<end_semestr> end_semestr { get; set; }
        public virtual DbSet<enter> enter { get; set; }
        public virtual DbSet<est_config> est_config { get; set; }
        public virtual DbSet<estimation> estimation { get; set; }
        public virtual DbSet<EstimationOther> EstimationOther { get; set; }
        public virtual DbSet<examination> examination { get; set; }
        public virtual DbSet<expense> expense { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Experience_type_job> Experience_type_job { get; set; }
        public virtual DbSet<f_educ> f_educ { get; set; }
        public virtual DbSet<f_educ_vid> f_educ_vid { get; set; }
        public virtual DbSet<f_est> f_est { get; set; }
        public virtual DbSet<faculty> faculty { get; set; }
        public virtual DbSet<family> family { get; set; }
        public virtual DbSet<family_> family_ { get; set; }
        public virtual DbSet<Family_s> Family_s { get; set; }
        public virtual DbSet<Family_spec> Family_spec { get; set; }
        public virtual DbSet<finish> finish { get; set; }
        public virtual DbSet<formAction> formAction { get; set; }
        public virtual DbSet<FormOfStydy> FormOfStydy { get; set; }
        public virtual DbSet<GAK_member_history> GAK_member_history { get; set; }
        public virtual DbSet<GAK_member_speciality> GAK_member_speciality { get; set; }
        public virtual DbSet<group_slushatel> group_slushatel { get; set; }
        public virtual DbSet<group_t> group_t { get; set; }
        public virtual DbSet<group_y> group_y { get; set; }
        public virtual DbSet<GroupNotInRRNK> GroupNotInRRNK { get; set; }
        public virtual DbSet<HighQualification> HighQualification { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<Holliday_t> Holliday_t { get; set; }
        public virtual DbSet<IndividualModulPermiss> IndividualModulPermiss { get; set; }
        public virtual DbSet<IndividualModulPermissByFuckulty> IndividualModulPermissByFuckulty { get; set; }
        public virtual DbSet<IndividualModulPermissBySpeciality> IndividualModulPermissBySpeciality { get; set; }
        public virtual DbSet<IndividualModulPermissGROUP> IndividualModulPermissGROUP { get; set; }
        public virtual DbSet<IndividualModulPermissPotok> IndividualModulPermissPotok { get; set; }
        public virtual DbSet<IndividualModulPermissPotok_group> IndividualModulPermissPotok_group { get; set; }
        public virtual DbSet<InfoOnTesting> InfoOnTesting { get; set; }
        public virtual DbSet<kafedra> kafedra { get; set; }
        public virtual DbSet<kafLogins> kafLogins { get; set; }
        public virtual DbSet<KafSecurity> KafSecurity { get; set; }
        public virtual DbSet<KasFak> KasFak { get; set; }
        public virtual DbSet<Kassa> Kassa { get; set; }
        public virtual DbSet<kinds> kinds { get; set; }
        public virtual DbSet<korpus> korpus { get; set; }
        public virtual DbSet<Kredit_fakulty> Kredit_fakulty { get; set; }
        public virtual DbSet<kv_job> kv_job { get; set; }
        public virtual DbSet<Kvalifikation> Kvalifikation { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Language_options> Language_options { get; set; }
        public virtual DbSet<languages> languages { get; set; }
        public virtual DbSet<leave> leave { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Library_dolg> Library_dolg { get; set; }
        public virtual DbSet<Library_dolg_LOG> Library_dolg_LOG { get; set; }
        public virtual DbSet<Licence> Licence { get; set; }
        public virtual DbSet<mark_mag> mark_mag { get; set; }
        public virtual DbSet<mark_mag_arch> mark_mag_arch { get; set; }
        public virtual DbSet<Member_type> Member_type { get; set; }
        public virtual DbSet<mil_card> mil_card { get; set; }
        public virtual DbSet<mil_card_> mil_card_ { get; set; }
        public virtual DbSet<Mil_name> Mil_name { get; set; }
        public virtual DbSet<Mil_R_Voisk> Mil_R_Voisk { get; set; }
        public virtual DbSet<Mil_valid> Mil_valid { get; set; }
        public virtual DbSet<MilitaryInfo> MilitaryInfo { get; set; }
        public virtual DbSet<ministerstvo> ministerstvo { get; set; }
        public virtual DbSet<MobileContactBack> MobileContactBack { get; set; }
        public virtual DbSet<MobileProblem> MobileProblem { get; set; }
        public virtual DbSet<MobileRaport> MobileRaport { get; set; }
        public virtual DbSet<MobileRaportDetail> MobileRaportDetail { get; set; }
        public virtual DbSet<MobileStudentAdmission> MobileStudentAdmission { get; set; }
        public virtual DbSet<MobileStudentAdmissionForReport> MobileStudentAdmissionForReport { get; set; }
        public virtual DbSet<MobileStudentAnnounceDays> MobileStudentAnnounceDays { get; set; }
        public virtual DbSet<MobileStudentDolg> MobileStudentDolg { get; set; }
        public virtual DbSet<MobileStudentDuty> MobileStudentDuty { get; set; }
        public virtual DbSet<MobileToken> MobileToken { get; set; }
        public virtual DbSet<Modul> Modul { get; set; }
        public virtual DbSet<modul_info> modul_info { get; set; }
        public virtual DbSet<ModulPermiss> ModulPermiss { get; set; }
        public virtual DbSet<mov_beg_giv> mov_beg_giv { get; set; }
        public virtual DbSet<mov_beg_ret> mov_beg_ret { get; set; }
        public virtual DbSet<mov_ved_giv> mov_ved_giv { get; set; }
        public virtual DbSet<mov_ved_ret> mov_ved_ret { get; set; }
        public virtual DbSet<movement_slushatel> movement_slushatel { get; set; }
        public virtual DbSet<movement_t> movement_t { get; set; }
        public virtual DbSet<MovementDop> MovementDop { get; set; }
        public virtual DbSet<MVD_Pasport> MVD_Pasport { get; set; }
        public virtual DbSet<n_gr> n_gr { get; set; }
        public virtual DbSet<nagrada> nagrada { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<nedeli> nedeli { get; set; }
        public virtual DbSet<nedeli_shedule> nedeli_shedule { get; set; }
        public virtual DbSet<ObemChasov> ObemChasov { get; set; }
        public virtual DbSet<obrazovanie_teacher> obrazovanie_teacher { get; set; }
        public virtual DbSet<oplata> oplata { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Organization_member> Organization_member { get; set; }
        public virtual DbSet<Otdel_1> Otdel_1 { get; set; }
        public virtual DbSet<ParentsInfo> ParentsInfo { get; set; }
        public virtual DbSet<Partiya> Partiya { get; set; }
        public virtual DbSet<passport> passport { get; set; }
        public virtual DbSet<pay_educ> pay_educ { get; set; }
        public virtual DbSet<pay_gr_con> pay_gr_con { get; set; }
        public virtual DbSet<pay_group> pay_group { get; set; }
        public virtual DbSet<PaymentTransfer_Virtual> PaymentTransfer_Virtual { get; set; }
        public virtual DbSet<Pensioners> Pensioners { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Place_leave> Place_leave { get; set; }
        public virtual DbSet<Place_of_birth> Place_of_birth { get; set; }
        public virtual DbSet<Place_of_residence> Place_of_residence { get; set; }
        public virtual DbSet<plan_abit> plan_abit { get; set; }
        public virtual DbSet<PlaseSetrORT> PlaseSetrORT { get; set; }
        public virtual DbSet<pol> pol { get; set; }
        public virtual DbSet<poseshal> poseshal { get; set; }
        public virtual DbSet<Posrekvezit> Posrekvezit { get; set; }
        public virtual DbSet<post> post { get; set; }
        public virtual DbSet<Prerekvezit> Prerekvezit { get; set; }
        public virtual DbSet<Prikaz_come> Prikaz_come { get; set; }
        public virtual DbSet<prikaz_come_slushatel> prikaz_come_slushatel { get; set; }
        public virtual DbSet<Prikaz_leave> Prikaz_leave { get; set; }
        public virtual DbSet<prikaz_leave_slushatel> prikaz_leave_slushatel { get; set; }
        public virtual DbSet<Prog_Security> Prog_Security { get; set; }
        public virtual DbSet<Progs_Permiss> Progs_Permiss { get; set; }
        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<PublicationType> PublicationType { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<Quit_Course> Quit_Course { get; set; }
        public virtual DbSet<r_ss> r_ss { get; set; }
        public virtual DbSet<Raboty_sprav> Raboty_sprav { get; set; }
        public virtual DbSet<Rang> Rang { get; set; }
        public virtual DbSet<rashod> rashod { get; set; }
        public virtual DbSet<rate> rate { get; set; }
        public virtual DbSet<ReceptInfo> ReceptInfo { get; set; }
        public virtual DbSet<RegionKR> RegionKR { get; set; }
        public virtual DbSet<Republics> Republics { get; set; }
        public virtual DbSet<RRNK> RRNK { get; set; }
        public virtual DbSet<RRNK_doljnost> RRNK_doljnost { get; set; }
        public virtual DbSet<rrnk_elements> rrnk_elements { get; set; }
        public virtual DbSet<rrnk_elements_old> rrnk_elements_old { get; set; }
        public virtual DbSet<rrnk_fakt> rrnk_fakt { get; set; }
        public virtual DbSet<RRNK_gr_kolst> RRNK_gr_kolst { get; set; }
        public virtual DbSet<RRNK_krdt_kolst> RRNK_krdt_kolst { get; set; }
        public virtual DbSet<RRNK_pps> RRNK_pps { get; set; }
        public virtual DbSet<RRNK_Schedule> RRNK_Schedule { get; set; }
        public virtual DbSet<RRNKCalc> RRNKCalc { get; set; }
        public virtual DbSet<RRNKDop> RRNKDop { get; set; }
        public virtual DbSet<RRNKkrdt> RRNKkrdt { get; set; }
        public virtual DbSet<rrnkPermiss> rrnkPermiss { get; set; }
        public virtual DbSet<rss> rss { get; set; }
        public virtual DbSet<S_G> S_G { get; set; }
        public virtual DbSet<S_G_opt> S_G_opt { get; set; }
        public virtual DbSet<SCHDayOffAuditories> SCHDayOffAuditories { get; set; }
        public virtual DbSet<SCHDayOffEmployees> SCHDayOffEmployees { get; set; }
        public virtual DbSet<SCHDayOffGroups> SCHDayOffGroups { get; set; }
        public virtual DbSet<ScheduleAdditionalGroups> ScheduleAdditionalGroups { get; set; }
        public virtual DbSet<SchoolDiscipline> SchoolDiscipline { get; set; }
        public virtual DbSet<SCHSchedule> SCHSchedule { get; set; }
        public virtual DbSet<SCHSchedule_discp_pasp> SCHSchedule_discp_pasp { get; set; }
        public virtual DbSet<SCHScheduleGroups> SCHScheduleGroups { get; set; }
        public virtual DbSet<SCHStudyType> SCHStudyType { get; set; }
        public virtual DbSet<SCHSubjectShortName> SCHSubjectShortName { get; set; }
        public virtual DbSet<SCHWeekDay> SCHWeekDay { get; set; }
        public virtual DbSet<ScientificActivity> ScientificActivity { get; set; }
        public virtual DbSet<semester> semester { get; set; }
        public virtual DbSet<SemestrShcedule> SemestrShcedule { get; set; }
        public virtual DbSet<Shcedule> Shcedule { get; set; }
        public virtual DbSet<shet> shet { get; set; }
        public virtual DbSet<shetchik_avn10_report> shetchik_avn10_report { get; set; }
        public virtual DbSet<smeta> smeta { get; set; }
        public virtual DbSet<Smeta_date> Smeta_date { get; set; }
        public virtual DbSet<Soc_pr> Soc_pr { get; set; }
        public virtual DbSet<Spec_Code> Spec_Code { get; set; }
        public virtual DbSet<special> special { get; set; }
        public virtual DbSet<specialOKT> specialOKT { get; set; }
        public virtual DbSet<Specifics> Specifics { get; set; }
        public virtual DbSet<Spravka> Spravka { get; set; }
        public virtual DbSet<SQL_User> SQL_User { get; set; }
        public virtual DbSet<StandardOfEducation> StandardOfEducation { get; set; }
        public virtual DbSet<Stavka> Stavka { get; set; }
        public virtual DbSet<StreamType> StreamType { get; set; }
        public virtual DbSet<structure> structure { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Student_ORT_balls> Student_ORT_balls { get; set; }
        public virtual DbSet<StudentPhoto> StudentPhoto { get; set; }
        public virtual DbSet<StudLang> StudLang { get; set; }
        public virtual DbSet<StudyCemester> StudyCemester { get; set; }
        public virtual DbSet<StudyYear> StudyYear { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<T_AliveCreditSmeta> T_AliveCreditSmeta { get; set; }
        public virtual DbSet<T_AliveExpense> T_AliveExpense { get; set; }
        public virtual DbSet<T_AliveMovement> T_AliveMovement { get; set; }
        public virtual DbSet<T_AliveMovement_temp> T_AliveMovement_temp { get; set; }
        public virtual DbSet<T_AlivePayment> T_AlivePayment { get; set; }
        public virtual DbSet<T_AlivePaymentTransfer> T_AlivePaymentTransfer { get; set; }
        public virtual DbSet<T_AliveSmeta> T_AliveSmeta { get; set; }
        public virtual DbSet<T_AvnLog> T_AvnLog { get; set; }
        public virtual DbSet<T_Banks> T_Banks { get; set; }
        public virtual DbSet<T_BaseBookCategories> T_BaseBookCategories { get; set; }
        public virtual DbSet<T_BlockUmk> T_BlockUmk { get; set; }
        public virtual DbSet<T_BookCategories> T_BookCategories { get; set; }
        public virtual DbSet<T_Books> T_Books { get; set; }
        public virtual DbSet<T_ComEbeFEst> T_ComEbeFEst { get; set; }
        public virtual DbSet<T_Contragents> T_Contragents { get; set; }
        public virtual DbSet<T_Countries> T_Countries { get; set; }
        public virtual DbSet<T_CreditRate> T_CreditRate { get; set; }
        public virtual DbSet<T_CreditSmeta> T_CreditSmeta { get; set; }
        public virtual DbSet<T_CreditSmetaBudgetContract> T_CreditSmetaBudgetContract { get; set; }
        public virtual DbSet<T_DisciplineForStudentPermissions> T_DisciplineForStudentPermissions { get; set; }
        public virtual DbSet<T_DynUrl> T_DynUrl { get; set; }
        public virtual DbSet<T_EmisHumanTemp> T_EmisHumanTemp { get; set; }
        public virtual DbSet<T_EventMessages> T_EventMessages { get; set; }
        public virtual DbSet<T_Exceptions> T_Exceptions { get; set; }
        public virtual DbSet<T_FileType> T_FileType { get; set; }
        public virtual DbSet<T_HistoryEmailToStudents> T_HistoryEmailToStudents { get; set; }
        public virtual DbSet<T_HumanType> T_HumanType { get; set; }
        public virtual DbSet<T_Languages> T_Languages { get; set; }
        public virtual DbSet<T_LogActions> T_LogActions { get; set; }
        public virtual DbSet<T_LogMarkMag> T_LogMarkMag { get; set; }
        public virtual DbSet<T_MarkMagModulCopyAccess> T_MarkMagModulCopyAccess { get; set; }
        public virtual DbSet<T_Message> T_Message { get; set; }
        public virtual DbSet<T_MessageDetails> T_MessageDetails { get; set; }
        public virtual DbSet<T_MessageFiles> T_MessageFiles { get; set; }
        public virtual DbSet<T_MessagesForFaculty> T_MessagesForFaculty { get; set; }
        public virtual DbSet<T_OnlinePaymentAccountType> T_OnlinePaymentAccountType { get; set; }
        public virtual DbSet<T_OnlinePaymentCheckCommandLog> T_OnlinePaymentCheckCommandLog { get; set; }
        public virtual DbSet<T_OnlinePaymentPreparedAccount> T_OnlinePaymentPreparedAccount { get; set; }
        public virtual DbSet<T_OnlinePaymentStream> T_OnlinePaymentStream { get; set; }
        public virtual DbSet<T_OnlinePaymentStreamAction> T_OnlinePaymentStreamAction { get; set; }
        public virtual DbSet<T_OnlinePaymentStreamCanceled> T_OnlinePaymentStreamCanceled { get; set; }
        public virtual DbSet<T_OnlinePaymentStreamTemp> T_OnlinePaymentStreamTemp { get; set; }
        public virtual DbSet<T_OnlinePaymentStreamUndoCanceled> T_OnlinePaymentStreamUndoCanceled { get; set; }
        public virtual DbSet<T_PaymentFacultyRates> T_PaymentFacultyRates { get; set; }
        public virtual DbSet<T_ResidentSettlings> T_ResidentSettlings { get; set; }
        public virtual DbSet<T_saved_balance> T_saved_balance { get; set; }
        public virtual DbSet<T_saved_balanceSummer> T_saved_balanceSummer { get; set; }
        public virtual DbSet<T_Schedule_AdditionalGroupForDepartment> T_Schedule_AdditionalGroupForDepartment { get; set; }
        public virtual DbSet<T_ScheduleForDepartment> T_ScheduleForDepartment { get; set; }
        public virtual DbSet<T_SchoolChildren> T_SchoolChildren { get; set; }
        public virtual DbSet<T_SchoolClasses> T_SchoolClasses { get; set; }
        public virtual DbSet<T_SchoolTeachers> T_SchoolTeachers { get; set; }
        public virtual DbSet<T_SmsAccountRegistartor> T_SmsAccountRegistartor { get; set; }
        public virtual DbSet<T_SmsActionLog> T_SmsActionLog { get; set; }
        public virtual DbSet<T_SmsActions> T_SmsActions { get; set; }
        public virtual DbSet<T_SmsDateAutoSend> T_SmsDateAutoSend { get; set; }
        public virtual DbSet<T_SmsDateAutoSendHandled> T_SmsDateAutoSendHandled { get; set; }
        public virtual DbSet<T_SmsMessages> T_SmsMessages { get; set; }
        public virtual DbSet<T_SmsShifrPaymentHandled> T_SmsShifrPaymentHandled { get; set; }
        public virtual DbSet<T_SmsTempActions> T_SmsTempActions { get; set; }
        public virtual DbSet<T_SmsVuzRegistratorForAbiturients> T_SmsVuzRegistratorForAbiturients { get; set; }
        public virtual DbSet<T_SmsVuzRegistratorForStudents> T_SmsVuzRegistratorForStudents { get; set; }
        public virtual DbSet<T_StudentDiscount> T_StudentDiscount { get; set; }
        public virtual DbSet<T_StudentJournalVisit> T_StudentJournalVisit { get; set; }
        public virtual DbSet<T_StudentUploadFileTasksSchedule> T_StudentUploadFileTasksSchedule { get; set; }
        public virtual DbSet<T_StudyAgreements> T_StudyAgreements { get; set; }
        public virtual DbSet<T_TeacherUmkTypeVisibility> T_TeacherUmkTypeVisibility { get; set; }
        public virtual DbSet<T_TempCreditRate> T_TempCreditRate { get; set; }
        public virtual DbSet<T_TempDisciplineForStudentDeleted> T_TempDisciplineForStudentDeleted { get; set; }
        public virtual DbSet<T_TempDisciplineForStudentInserted> T_TempDisciplineForStudentInserted { get; set; }
        public virtual DbSet<T_TempEducShDeleted> T_TempEducShDeleted { get; set; }
        public virtual DbSet<T_TempEducShInserted> T_TempEducShInserted { get; set; }
        public virtual DbSet<T_TempEducShUpdated> T_TempEducShUpdated { get; set; }
        public virtual DbSet<T_TempMarkMagInserted> T_TempMarkMagInserted { get; set; }
        public virtual DbSet<T_TempMovementFromArchive> T_TempMovementFromArchive { get; set; }
        public virtual DbSet<T_TempMovementToArchive> T_TempMovementToArchive { get; set; }
        public virtual DbSet<T_TempPayment> T_TempPayment { get; set; }
        public virtual DbSet<T_UmkType> T_UmkType { get; set; }
        public virtual DbSet<T_Universities> T_Universities { get; set; }
        public virtual DbSet<T_UserType> T_UserType { get; set; }
        public virtual DbSet<T_UserUniversity> T_UserUniversity { get; set; }
        public virtual DbSet<teacher> teacher { get; set; }
        public virtual DbSet<teacher_info> teacher_info { get; set; }
        public virtual DbSet<teacher_medosmotr> teacher_medosmotr { get; set; }
        public virtual DbSet<teacher_skills> teacher_skills { get; set; }
        public virtual DbSet<teacher_stepen> teacher_stepen { get; set; }
        public virtual DbSet<teacher_struktura> teacher_struktura { get; set; }
        public virtual DbSet<temp_online_payment> temp_online_payment { get; set; }
        public virtual DbSet<temp_tt> temp_tt { get; set; }
        public virtual DbSet<testtable> testtable { get; set; }
        public virtual DbSet<Time_> Time_ { get; set; }
        public virtual DbSet<ToolTable> ToolTable { get; set; }
        public virtual DbSet<Trudoem> Trudoem { get; set; }
        public virtual DbSet<TypeChasov> TypeChasov { get; set; }
        public virtual DbSet<TypeControl> TypeControl { get; set; }
        public virtual DbSet<TypeHour> TypeHour { get; set; }
        public virtual DbSet<TypeScholl> TypeScholl { get; set; }
        public virtual DbSet<uch_step> uch_step { get; set; }
        public virtual DbSet<uch_zvanie> uch_zvanie { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<User_ebe_var> User_ebe_var { get; set; }
        public virtual DbSet<User_f_educ> User_f_educ { get; set; }
        public virtual DbSet<User_f_est> User_f_est { get; set; }
        public virtual DbSet<user_faculty> user_faculty { get; set; }
        public virtual DbSet<User_Kafedra> User_Kafedra { get; set; }
        public virtual DbSet<user_ok> user_ok { get; set; }
        public virtual DbSet<usluga_rashod> usluga_rashod { get; set; }
        public virtual DbSet<uslugi> uslugi { get; set; }
        public virtual DbSet<v_docs> v_docs { get; set; }
        public virtual DbSet<v_opl> v_opl { get; set; }
        public virtual DbSet<v_zanyatii> v_zanyatii { get; set; }
        public virtual DbSet<Vakansii> Vakansii { get; set; }
        public virtual DbSet<var_sum> var_sum { get; set; }
        public virtual DbSet<vedomost_akadem> vedomost_akadem { get; set; }
        public virtual DbSet<vid_zaniatiy> vid_zaniatiy { get; set; }
        public virtual DbSet<VillageKR> VillageKR { get; set; }
        public virtual DbSet<VisibleCallEduc> VisibleCallEduc { get; set; }
        public virtual DbSet<VisibleRecTable> VisibleRecTable { get; set; }
        public virtual DbSet<Visitings> Visitings { get; set; }
        public virtual DbSet<vuz> vuz { get; set; }
        public virtual DbSet<VuzDefaults> VuzDefaults { get; set; }
        public virtual DbSet<Vyz> Vyz { get; set; }
        public virtual DbSet<Vyz_> Vyz_ { get; set; }
        public virtual DbSet<w_s> w_s { get; set; }
        public virtual DbSet<Wbr_Rooms> Wbr_Rooms { get; set; }
        public virtual DbSet<Wbr_Students> Wbr_Students { get; set; }
        public virtual DbSet<Wbr_Teachers> Wbr_Teachers { get; set; }
        public virtual DbSet<Work> Work { get; set; }
        public virtual DbSet<Working> Working { get; set; }
        public virtual DbSet<akad_grafik> akad_grafik { get; set; }
        public virtual DbSet<CorrT> CorrT { get; set; }
        public virtual DbSet<DEL_mark_mag_arch> DEL_mark_mag_arch { get; set; }
        public virtual DbSet<Del_RRNK> Del_RRNK { get; set; }
        public virtual DbSet<Del_RRNKkrdt> Del_RRNKkrdt { get; set; }
        public virtual DbSet<discipline_type> discipline_type { get; set; }
        public virtual DbSet<group_yyy> group_yyy { get; set; }
        public virtual DbSet<IncorrT> IncorrT { get; set; }
        public virtual DbSet<InfoOnEdIns> InfoOnEdIns { get; set; }
        public virtual DbSet<mov_ved_ind> mov_ved_ind { get; set; }
        public virtual DbSet<mov_ved_ind_ret> mov_ved_ind_ret { get; set; }
        public virtual DbSet<pay_educ_leta> pay_educ_leta { get; set; }
        public virtual DbSet<rrnk_aa_table> rrnk_aa_table { get; set; }
        public virtual DbSet<rrnk_aa_table__> rrnk_aa_table__ { get; set; }
        public virtual DbSet<T_EBooks> T_EBooks { get; set; }
        public virtual DbSet<T_Institutions> T_Institutions { get; set; }
        public virtual DbSet<T_ManagerAccessByCourse> T_ManagerAccessByCourse { get; set; }
        public virtual DbSet<T_PermittedFacultyForOnlinePayment> T_PermittedFacultyForOnlinePayment { get; set; }
        public virtual DbSet<temp_markmagSH> temp_markmagSH { get; set; }
        public virtual DbSet<temp_mm_archSH> temp_mm_archSH { get; set; }
        public virtual DbSet<temp_movement_t> temp_movement_t { get; set; }
        public virtual DbSet<Tmp_special> Tmp_special { get; set; }
        public virtual DbSet<user_come> user_come { get; set; }
        public virtual DbSet<user_leave> user_leave { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C___Directions>()
                .Property(e => e.IDDirections)
                .IsUnicode(false);

            modelBuilder.Entity<C___Directions>()
                .Property(e => e.NameDirections)
                .IsUnicode(false);

            modelBuilder.Entity<C___Directions>()
                .Property(e => e.SmallNameDirect)
                .IsUnicode(false);

            modelBuilder.Entity<C___Directions>()
                .Property(e => e.Apprenticeship)
                .IsUnicode(false);

            modelBuilder.Entity<a_year>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<a_year>()
                .HasMany(e => e.com_ygr)
                .WithRequired(e => e.a_year)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<a_year>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.a_year)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<a_year>()
                .HasMany(e => e.smeta)
                .WithRequired(e => e.a_year)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<a_year_1>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoOnEdIns>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoOnEdIns>()
                .Property(e => e.YearTerminations)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoOnEdIns>()
                .Property(e => e.SeriesAD)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoOnEdIns>()
                .Property(e => e.NumberAD)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_MilitaryInfo>()
                .Property(e => e.NumberMT)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_MilitaryInfo>()
                .Property(e => e.DateMAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_MilitaryInfo>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_MilitaryInfo>()
                .Property(e => e.MilitaryAcSP)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_MilitaryInfo>()
                .Property(e => e.NameMilComm)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.SurnameFather)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.NameFather)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.PatronymicFather)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.PlaceJobFather)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.PostFather)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.SurnameMother)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.NameMother)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.PatronymicMother)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.PlaceJobMother)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.PostMother)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_ParentsInfo>()
                .Property(e => e.TelephoneHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.first_p1)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.Streetbirth)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.adrhome)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.TelephoneHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.StreetNow)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.adrnow)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.TelephoneNow)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.SerialPas)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.NumberPas)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.lang)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.hobby)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.religion)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.visitKG)
                .IsUnicode(false);

            modelBuilder.Entity<Abiturient>()
                .Property(e => e.aids)
                .IsUnicode(false);

            modelBuilder.Entity<Abroad>()
                .Property(e => e.purchose)
                .IsUnicode(false);

            modelBuilder.Entity<Auditoriums>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<Auditoriums>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<Auditoriums>()
                .HasMany(e => e.SCHDayOffAuditories)
                .WithRequired(e => e.Auditoriums)
                .HasForeignKey(e => e.AuditoryID);

            modelBuilder.Entity<AVN_report_role>()
                .Property(e => e.report_role)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_report_role>()
                .Property(e => e.reports)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_reports>()
                .Property(e => e.n_reports)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_reports>()
                .Property(e => e.clic)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_reports>()
                .Property(e => e.n_otdel)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_svyazi>()
                .Property(e => e.vopros)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_svyazi>()
                .Property(e => e.osn_table_name)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_svyazi>()
                .Property(e => e.osn_ident_name)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_svyazi>()
                .Property(e => e.dop_table_name)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_svyazi>()
                .Property(e => e.dop_ident_name)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_User>()
                .Property(e => e.Old_password)
                .IsUnicode(false);

            modelBuilder.Entity<_base>()
                .Property(e => e.base_over)
                .IsUnicode(false);

            modelBuilder.Entity<_base>()
                .HasMany(e => e.Work)
                .WithOptional(e => e._base)
                .HasForeignKey(e => e.id_type_job);

            modelBuilder.Entity<_base>()
                .HasMany(e => e.Working)
                .WithRequired(e => e._base)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<bk>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<bk>()
                .Property(e => e.s_name)
                .IsUnicode(false);

            modelBuilder.Entity<CallEducationInst>()
                .Property(e => e.CallEducat)
                .IsUnicode(false);

            modelBuilder.Entity<CallEducationInst>()
                .HasMany(e => e.Ab_InfoOnEdIns)
                .WithOptional(e => e.CallEducationInst)
                .HasForeignKey(e => e.CallEdIns);

            modelBuilder.Entity<CallEducationInst>()
                .HasMany(e => e.InfoOnEdIns)
                .WithOptional(e => e.CallEducationInst)
                .HasForeignKey(e => e.CallEdIns);

            modelBuilder.Entity<Category>()
                .Property(e => e.n_category)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.for_stetment)
                .IsUnicode(false);

            modelBuilder.Entity<Citizenship>()
                .Property(e => e.Citizenship1)
                .IsUnicode(false);

            modelBuilder.Entity<CityKR>()
                .Property(e => e.NameCity)
                .IsUnicode(false);

            modelBuilder.Entity<com_gspe>()
                .Property(e => e.id_sub_group)
                .IsUnicode(false);

            modelBuilder.Entity<com_gspe>()
                .HasMany(e => e.group_t)
                .WithRequired(e => e.com_gspe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_kt>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<com_sfe>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.com_sfe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_sfe>()
                .HasMany(e => e.plan_abit)
                .WithRequired(e => e.com_sfe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_sfe>()
                .HasMany(e => e.smeta)
                .WithRequired(e => e.com_sfe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<come>()
                .Property(e => e.come1)
                .IsUnicode(false);

            modelBuilder.Entity<come>()
                .Property(e => e.c_name)
                .IsUnicode(false);

            modelBuilder.Entity<come>()
                .Property(e => e.come_kg)
                .IsUnicode(false);

            modelBuilder.Entity<come>()
                .HasMany(e => e.movement_t)
                .WithRequired(e => e.come)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<control>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<control>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.control)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country>()
                .Property(e => e.p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.s_p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .HasMany(e => e.Citizenship)
                .WithRequired(e => e.country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<deduce>()
                .Property(e => e.deduce1)
                .IsUnicode(false);

            modelBuilder.Entity<deduce>()
                .HasMany(e => e.Vakansii)
                .WithRequired(e => e.deduce)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Del_Educ_sh>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Del_Educ_sh>()
                .Property(e => e.isSelect)
                .IsFixedLength();

            modelBuilder.Entity<Del_Educ_sh>()
                .Property(e => e.del_oper)
                .IsFixedLength();

            modelBuilder.Entity<Del_Mark_Mag>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<Del_Mark_Mag>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Del_Mark_Mag>()
                .Property(e => e.del_oper)
                .IsFixedLength();

            modelBuilder.Entity<Del_movement_t>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.host_del)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.oper_del)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Del_payment>()
                .Property(e => e.tmp)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.NameDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.SmallNameDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.CodeDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<DIPL_PRIX>()
                .Property(e => e.S_FIO)
                .IsFixedLength();

            modelBuilder.Entity<DIPL_PRIX>()
                .Property(e => e.NOMER)
                .IsFixedLength();

            modelBuilder.Entity<Diploma_kval>()
                .Property(e => e.diploma_kval1)
                .IsUnicode(false);

            modelBuilder.Entity<direction>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<direction>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<direction>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<discipline>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<discipline>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<discipline>()
                .Property(e => e.s_p34)
                .IsUnicode(false);

            modelBuilder.Entity<discipline>()
                .HasMany(e => e.Bronya)
                .WithOptional(e => e.discipline)
                .HasForeignKey(e => e.kod_predmet);

            modelBuilder.Entity<discipline>()
                .HasMany(e => e.disc_n_sv)
                .WithRequired(e => e.discipline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<discipline>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.discipline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<discipline>()
                .HasMany(e => e.SemestrShcedule)
                .WithOptional(e => e.discipline)
                .HasForeignKey(e => e.kod_predmet);

            modelBuilder.Entity<DistrictKR>()
                .Property(e => e.NameDistrict)
                .IsUnicode(false);

            modelBuilder.Entity<dopolnitelno>()
                .Property(e => e.insert_pole)
                .IsUnicode(false);

            modelBuilder.Entity<dopolnitelno>()
                .Property(e => e.insert_pole_kg)
                .IsUnicode(false);

            modelBuilder.Entity<dopolnitelno>()
                .Property(e => e.coment)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<dv>()
                .Property(e => e.dv1)
                .IsUnicode(false);

            modelBuilder.Entity<dv>()
                .Property(e => e.opl)
                .IsUnicode(false);

            modelBuilder.Entity<Edu>()
                .Property(e => e.education)
                .IsUnicode(false);

            modelBuilder.Entity<Educ>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<Educ>()
                .Property(e => e.Diploma_No)
                .IsUnicode(false);

            modelBuilder.Entity<Educ>()
                .Property(e => e.vuz)
                .IsUnicode(false);

            modelBuilder.Entity<educ_form>()
                .Property(e => e.educ_form1)
                .IsUnicode(false);

            modelBuilder.Entity<educ_sh>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<educ_sh_kpv>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Educ_sh_sel>()
                .Property(e => e.avn_user)
                .IsUnicode(false);

            modelBuilder.Entity<Educ_t>()
                .Property(e => e.Educ_type)
                .IsUnicode(false);

            modelBuilder.Entity<Elect_org>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Elect_org>()
                .Property(e => e.elected_as)
                .IsUnicode(false);

            modelBuilder.Entity<Elect_org>()
                .Property(e => e.year_elect)
                .IsUnicode(false);

            modelBuilder.Entity<Elect_org>()
                .Property(e => e.year_End)
                .IsUnicode(false);

            modelBuilder.Entity<Elect_org>()
                .Property(e => e.organ)
                .IsUnicode(false);

            modelBuilder.Entity<enter>()
                .Property(e => e.enter1)
                .IsUnicode(false);

            modelBuilder.Entity<enter>()
                .HasMany(e => e.Vakansii)
                .WithRequired(e => e.enter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estimation>()
                .Property(e => e.p31_2)
                .IsUnicode(false);

            modelBuilder.Entity<estimation>()
                .Property(e => e.diplom)
                .IsUnicode(false);

            modelBuilder.Entity<estimation>()
                .Property(e => e.ved1)
                .IsUnicode(false);

            modelBuilder.Entity<estimation>()
                .Property(e => e.ved2)
                .IsUnicode(false);

            modelBuilder.Entity<estimation>()
                .Property(e => e.ved3)
                .IsUnicode(false);

            modelBuilder.Entity<estimation>()
                .HasMany(e => e.ee)
                .WithRequired(e => e.estimation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<examination>()
                .Property(e => e.p30_1)
                .IsUnicode(false);

            modelBuilder.Entity<examination>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.examination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<examination>()
                .HasMany(e => e.ee)
                .WithRequired(e => e.examination)
                .HasForeignKey(e => e.id_exmination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<expense>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<expense>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<expense>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<expense>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<expense>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<expense>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.specialty)
                .IsUnicode(false);

            modelBuilder.Entity<Experience_type_job>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<f_educ>()
                .Property(e => e.p108_1)
                .IsUnicode(false);

            modelBuilder.Entity<f_educ>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<f_est>()
                .Property(e => e.p109)
                .IsUnicode(false);

            modelBuilder.Entity<faculty>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<faculty>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<family>()
                .Property(e => e.p15)
                .IsUnicode(false);

            modelBuilder.Entity<family>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<family>()
                .HasMany(e => e.family_)
                .WithOptional(e => e.family)
                .HasForeignKey(e => e.id_family_status);

            modelBuilder.Entity<family_>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<family_>()
                .Property(e => e.Org_Address)
                .IsUnicode(false);

            modelBuilder.Entity<family_>()
                .Property(e => e.p26)
                .IsUnicode(false);

            modelBuilder.Entity<family_>()
                .Property(e => e.p27)
                .IsUnicode(false);

            modelBuilder.Entity<family_>()
                .Property(e => e.p28)
                .IsUnicode(false);

            modelBuilder.Entity<Family_s>()
                .Property(e => e.stepen)
                .IsUnicode(false);

            modelBuilder.Entity<Family_spec>()
                .Property(e => e.job_specification)
                .IsUnicode(false);

            modelBuilder.Entity<finish>()
                .Property(e => e.p99)
                .IsUnicode(false);

            modelBuilder.Entity<finish>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<FormOfStydy>()
                .Property(e => e.FormSt)
                .IsUnicode(false);

            modelBuilder.Entity<group_t>()
                .HasMany(e => e.movement_t)
                .WithRequired(e => e.group_t)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<group_y>()
                .Property(e => e.p21)
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.n_prikaz)
                .IsFixedLength();

            modelBuilder.Entity<Holiday>()
                .Property(e => e.otz_prik)
                .IsUnicode(false);

            modelBuilder.Entity<Holliday_t>()
                .Property(e => e.Holiday_type)
                .IsUnicode(false);

            modelBuilder.Entity<IndividualModulPermissPotok_group>()
                .Property(e => e.host)
                .IsUnicode(false);

            modelBuilder.Entity<kafedra>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<kafedra>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<kafedra>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<kafedra>()
                .Property(e => e.pswd)
                .IsUnicode(false);

            modelBuilder.Entity<kafedra>()
                .HasMany(e => e.com_kt)
                .WithOptional(e => e.kafedra)
                .WillCascadeOnDelete();

            modelBuilder.Entity<kafedra>()
                .HasMany(e => e.direction)
                .WithOptional(e => e.kafedra)
                .WillCascadeOnDelete();

            modelBuilder.Entity<kafedra>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.kafedra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<kafLogins>()
                .HasMany(e => e.KafSecurity)
                .WithOptional(e => e.kafLogins)
                .HasForeignKey(e => e.id_kafLogin)
                .WillCascadeOnDelete();

            modelBuilder.Entity<korpus>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<korpus>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<kv_job>()
                .Property(e => e.p86)
                .IsUnicode(false);

            modelBuilder.Entity<kv_job>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Kvalifikation>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<Kvalifikation>()
                .Property(e => e.sertifikate)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.NameLanguage)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.InfoOnEdIns)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.LanguageEduc);

            modelBuilder.Entity<languages>()
                .Property(e => e.lang)
                .IsUnicode(false);

            modelBuilder.Entity<leave>()
                .Property(e => e.leave1)
                .IsUnicode(false);

            modelBuilder.Entity<leave>()
                .Property(e => e.akadem)
                .IsUnicode(false);

            modelBuilder.Entity<leave>()
                .HasMany(e => e.movement_t)
                .WithRequired(e => e.leave)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .Property(e => e.l_level)
                .IsUnicode(false);

            modelBuilder.Entity<Library_dolg_LOG>()
                .Property(e => e.AVN_user_login)
                .IsUnicode(false);

            modelBuilder.Entity<Licence>()
                .Property(e => e.Resolution)
                .IsUnicode(false);

            modelBuilder.Entity<Licence>()
                .Property(e => e.ResolutionBeg)
                .IsUnicode(false);

            modelBuilder.Entity<Licence>()
                .Property(e => e.ResolutionEnd)
                .IsUnicode(false);

            modelBuilder.Entity<Licence>()
                .Property(e => e.Supplement)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_arch>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_arch>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<mil_card>()
                .Property(e => e.p16)
                .IsUnicode(false);

            modelBuilder.Entity<mil_card>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<mil_card_>()
                .Property(e => e.voencom)
                .IsUnicode(false);

            modelBuilder.Entity<mil_card_>()
                .Property(e => e.Sostav)
                .IsUnicode(false);

            modelBuilder.Entity<Mil_name>()
                .Property(e => e.mil_name1)
                .IsUnicode(false);

            modelBuilder.Entity<Mil_R_Voisk>()
                .Property(e => e.R_voisk)
                .IsUnicode(false);

            modelBuilder.Entity<Mil_valid>()
                .Property(e => e.valid)
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryInfo>()
                .Property(e => e.NumberMT)
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryInfo>()
                .Property(e => e.DateMAccount)
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryInfo>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryInfo>()
                .Property(e => e.MilitaryAcSP)
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryInfo>()
                .Property(e => e.NameMilComm)
                .IsUnicode(false);

            modelBuilder.Entity<ministerstvo>()
                .Property(e => e.mo)
                .IsUnicode(false);

            modelBuilder.Entity<MobileContactBack>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<MobileContactBack>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<MobileProblem>()
                .HasMany(e => e.MobileContactBack)
                .WithRequired(e => e.MobileProblem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MobileRaport>()
                .HasMany(e => e.MobileRaportDetail)
                .WithRequired(e => e.MobileRaport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MobileStudentDolg>()
                .Property(e => e.DolgSum)
                .HasPrecision(20, 2);

            modelBuilder.Entity<mov_beg_giv>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<mov_ved_giv>()
                .Property(e => e.Shifr)
                .IsUnicode(false);

            modelBuilder.Entity<mov_ved_ret>()
                .Property(e => e.Shifr)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<MVD_Pasport>()
                .Property(e => e.CodeMVD)
                .IsUnicode(false);

            modelBuilder.Entity<MVD_Pasport>()
                .HasMany(e => e.passport)
                .WithOptional(e => e.MVD_Pasport)
                .HasForeignKey(e => e.id_passport_organ);

            modelBuilder.Entity<n_gr>()
                .Property(e => e.n_gr1)
                .IsUnicode(false);

            modelBuilder.Entity<nagrada>()
                .Property(e => e.nagrada1)
                .IsUnicode(false);

            modelBuilder.Entity<nagrada>()
                .Property(e => e.By_who)
                .IsUnicode(false);

            modelBuilder.Entity<Nationality>()
                .HasMany(e => e.teacher_info)
                .WithOptional(e => e.Nationality)
                .HasForeignKey(e => e.id_nationality);

            modelBuilder.Entity<oplata>()
                .Property(e => e.oplata1)
                .IsUnicode(false);

            modelBuilder.Entity<oplata>()
                .Property(e => e.s_opl)
                .IsUnicode(false);

            modelBuilder.Entity<oplata>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Otdel_1>()
                .Property(e => e.otdel_11)
                .IsUnicode(false);

            modelBuilder.Entity<Otdel_1>()
                .HasMany(e => e.Vakansii)
                .WithOptional(e => e.Otdel_1)
                .HasForeignKey(e => e.id_otdel_1);

            modelBuilder.Entity<Otdel_1>()
                .HasMany(e => e.Vakansii1)
                .WithOptional(e => e.Otdel_11)
                .HasForeignKey(e => e.id_otdel_11);

            modelBuilder.Entity<Otdel_1>()
                .HasMany(e => e.Vakansii2)
                .WithOptional(e => e.Otdel_12)
                .HasForeignKey(e => e.id_otdel_2);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.SurnameFather)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.NameFather)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.PatronymicFather)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.PlaceJobFather)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.PostFather)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.SurnameMother)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.NameMother)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.PatronymicMother)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.PlaceJobMother)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.PostMother)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ParentsInfo>()
                .Property(e => e.TelephoneHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Partiya>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<passport>()
                .Property(e => e.s_p)
                .IsUnicode(false);

            modelBuilder.Entity<passport>()
                .Property(e => e.n_p)
                .IsUnicode(false);

            modelBuilder.Entity<Pensioners>()
                .Property(e => e.AVN_user)
                .IsFixedLength();

            modelBuilder.Entity<Pensioners>()
                .Property(e => e.AVN_update)
                .IsFixedLength();

            modelBuilder.Entity<Place_leave>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Place_of_residence>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<plan_abit>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSetrORT>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSetrORT>()
                .Property(e => e.ColorSert)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSetrORT>()
                .Property(e => e.dop_place)
                .IsUnicode(false);

            modelBuilder.Entity<pol>()
                .Property(e => e.p17)
                .IsUnicode(false);

            modelBuilder.Entity<pol>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Posrekvezit>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Posrekvezit>()
                .Property(e => e.post_code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<post>()
                .Property(e => e.post1)
                .IsUnicode(false);

            modelBuilder.Entity<post>()
                .HasMany(e => e.Vakansii)
                .WithRequired(e => e.post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prerekvezit>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Prerekvezit>()
                .Property(e => e.pre_code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Prikaz_come>()
                .Property(e => e.prikaz_come1)
                .IsUnicode(false);

            modelBuilder.Entity<Prikaz_come>()
                .HasMany(e => e.Working)
                .WithRequired(e => e.Prikaz_come)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prikaz_leave>()
                .Property(e => e.prikaz_leave1)
                .IsUnicode(false);

            modelBuilder.Entity<Prikaz_leave>()
                .HasMany(e => e.Working)
                .WithRequired(e => e.Prikaz_leave)
                .HasForeignKey(e => e.id_leave)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Qualification>()
                .Property(e => e.NameQualification)
                .IsUnicode(false);

            modelBuilder.Entity<Quit_Course>()
                .Property(e => e.cource)
                .IsUnicode(false);

            modelBuilder.Entity<Raboty_sprav>()
                .Property(e => e.Naimenovanie_rabot)
                .IsUnicode(false);

            modelBuilder.Entity<Rang>()
                .Property(e => e.rang1)
                .IsUnicode(false);

            modelBuilder.Entity<rashod>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<rashod>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<rashod>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<rate>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<rate>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<rate>()
                .HasMany(e => e.com_ygr)
                .WithRequired(e => e.rate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rate>()
                .HasMany(e => e.movement_t)
                .WithRequired(e => e.rate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rate>()
                .HasMany(e => e.semester)
                .WithRequired(e => e.rate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceptInfo>()
                .Property(e => e.NumberOrder)
                .IsUnicode(false);

            modelBuilder.Entity<ReceptInfo>()
                .Property(e => e.NumberProtocol)
                .IsUnicode(false);

            modelBuilder.Entity<ReceptInfo>()
                .Property(e => e.RegNum)
                .IsUnicode(false);

            modelBuilder.Entity<ReceptInfo>()
                .Property(e => e.Recom_protokol)
                .IsUnicode(false);

            modelBuilder.Entity<RegionKR>()
                .Property(e => e.NameRegion)
                .IsUnicode(false);

            modelBuilder.Entity<RRNK_doljnost>()
                .Property(e => e.n_doljnost)
                .IsUnicode(false);

            modelBuilder.Entity<S_G>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<S_G>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<S_G>()
                .Property(e => e.idid)
                .IsUnicode(false);

            modelBuilder.Entity<S_G>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule>()
                .HasMany(e => e.SCHScheduleGroups)
                .WithRequired(e => e.SCHSchedule)
                .HasForeignKey(e => e.ScheduleID);

            modelBuilder.Entity<SCHStudyType>()
                .HasMany(e => e.SCHSchedule)
                .WithRequired(e => e.SCHStudyType)
                .HasForeignKey(e => e.StudyTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<semester>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<semester>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.semester)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<semester>()
                .HasMany(e => e.movement_t)
                .WithRequired(e => e.semester)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shet>()
                .Property(e => e.shet1)
                .IsUnicode(false);

            modelBuilder.Entity<shet>()
                .Property(e => e.n_shet)
                .IsUnicode(false);

            modelBuilder.Entity<shet>()
                .Property(e => e.shet2)
                .IsUnicode(false);

            modelBuilder.Entity<shet>()
                .Property(e => e.n_shet2)
                .IsUnicode(false);

            modelBuilder.Entity<smeta>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Soc_pr>()
                .Property(e => e.soc_status)
                .IsUnicode(false);

            modelBuilder.Entity<special>()
                .Property(e => e.p25_1)
                .IsUnicode(false);

            modelBuilder.Entity<special>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<special>()
                .Property(e => e.standart)
                .IsUnicode(false);

            modelBuilder.Entity<specialOKT>()
                .Property(e => e.p25_1)
                .IsUnicode(false);

            modelBuilder.Entity<specialOKT>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<specialOKT>()
                .Property(e => e.standart)
                .IsUnicode(false);

            modelBuilder.Entity<Specifics>()
                .Property(e => e.specifics1)
                .IsUnicode(false);

            modelBuilder.Entity<Specifics>()
                .Property(e => e.short_specifics)
                .IsFixedLength();

            modelBuilder.Entity<Specifics>()
                .HasMany(e => e.Auditoriums)
                .WithOptional(e => e.Specifics)
                .HasForeignKey(e => e.specific);

            modelBuilder.Entity<StandardOfEducation>()
                .Property(e => e.NameLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Stavka>()
                .HasMany(e => e.Working)
                .WithRequired(e => e.Stavka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<structure>()
                .Property(e => e.structure1)
                .IsFixedLength();

            modelBuilder.Entity<structure>()
                .HasMany(e => e.user_ok)
                .WithRequired(e => e.structure)
                .HasForeignKey(e => e.strukture)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<structure>()
                .HasMany(e => e.Vakansii)
                .WithRequired(e => e.structure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.first_p1)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Streetbirth)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.adrhome)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.TelephoneHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StreetNow)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.adrnow)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.TelephoneNow)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.SerialPas)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.NumberPas)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.DateRegistr)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.lang)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.hobby)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.religion)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.visitKG)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.aids)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.smsAccountFromAbit)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Attribute)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.op)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasOptional(e => e.MilitaryInfo)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.movement_t)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasOptional(e => e.ParentsInfo)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.InfoOnEdIns)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.IDStudent);

            modelBuilder.Entity<T_AliveExpense>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveExpense>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveExpense>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveExpense>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveExpense>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveExpense>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement_temp>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement_temp>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement_temp>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<T_AliveMovement_temp>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<T_AlivePayment>()
                .Property(e => e.tmp)
                .IsUnicode(false);

            modelBuilder.Entity<T_AvnLog>()
                .Property(e => e.tableName)
                .IsUnicode(false);

            modelBuilder.Entity<T_AvnLog>()
                .Property(e => e.fieldName)
                .IsUnicode(false);

            modelBuilder.Entity<T_AvnLog>()
                .Property(e => e.logMessage)
                .IsUnicode(false);

            modelBuilder.Entity<T_Banks>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<T_Banks>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<T_BaseBookCategories>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<T_ComEbeFEst>()
                .Property(e => e.Definition)
                .IsUnicode(false);

            modelBuilder.Entity<T_EventMessages>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<T_EventMessages>()
                .Property(e => e.fileName)
                .IsUnicode(false);

            modelBuilder.Entity<T_FileType>()
                .Property(e => e.filetypeName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MessagesForFaculty>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<T_MessagesForFaculty>()
                .Property(e => e.fileName)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentAccountType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentCheckCommandLog>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentCheckCommandLog>()
                .Property(e => e.requestHash)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentCheckCommandLog>()
                .Property(e => e.fromAddress)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentPreparedAccount>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentStream>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentStream>()
                .Property(e => e.txn_id)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentStream>()
                .Property(e => e.fromAddress)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentStreamAction>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentStreamCanceled>()
                .Property(e => e.fromAddress)
                .IsUnicode(false);

            modelBuilder.Entity<T_OnlinePaymentStreamUndoCanceled>()
                .Property(e => e.fromAddress)
                .IsUnicode(false);

            modelBuilder.Entity<T_saved_balance>()
                .Property(e => e.AVN_user)
                .IsFixedLength();

            modelBuilder.Entity<T_SchoolChildren>()
                .Property(e => e.parentPhone)
                .IsUnicode(false);

            modelBuilder.Entity<T_SchoolTeachers>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<T_SchoolTeachers>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<T_SchoolTeachers>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<T_SchoolTeachers>()
                .Property(e => e.password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_SmsAccountRegistartor>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<T_SmsActionLog>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<T_SmsActions>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<T_SmsVuzRegistratorForAbiturients>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<T_SmsVuzRegistratorForStudents>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<T_TempEducShUpdated>()
                .Property(e => e.Suser)
                .IsFixedLength();

            modelBuilder.Entity<T_TempMarkMagInserted>()
                .Property(e => e.Suser)
                .IsFixedLength();

            modelBuilder.Entity<T_UserType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.p26)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.p27)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.p28)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Abroad)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Bronya)
                .WithOptional(e => e.teacher)
                .HasForeignKey(e => e.kod_prepod);

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.com_kt)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Elect_org)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Experience)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Holiday)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.kv_job)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Kvalifikation)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Language_options)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.mil_card_)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.nagrada)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Partiya)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Photo)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.SemestrShcedule)
                .WithOptional(e => e.teacher)
                .HasForeignKey(e => e.kod_prepod);

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Work)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Working)
                .WithRequired(e => e.teacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<teacher_info>()
                .Property(e => e.Phon_w)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_info>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_info>()
                .Property(e => e.phone_mobile)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_info>()
                .Property(e => e.nauch_r)
                .IsUnicode(false);

            modelBuilder.Entity<temp_online_payment>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<temp_online_payment>()
                .Property(e => e.account2)
                .IsUnicode(false);

            modelBuilder.Entity<Time_>()
                .Property(e => e.Time_1)
                .IsUnicode(false);

            modelBuilder.Entity<Time_>()
                .Property(e => e.begin_time)
                .IsUnicode(false);

            modelBuilder.Entity<TypeChasov>()
                .Property(e => e.short_name)
                .IsUnicode(false);

            modelBuilder.Entity<TypeScholl>()
                .Property(e => e.NameType)
                .IsUnicode(false);

            modelBuilder.Entity<TypeScholl>()
                .HasMany(e => e.CallEducationInst)
                .WithRequired(e => e.TypeScholl)
                .HasForeignKey(e => e.TypeEdIns)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<uch_step>()
                .Property(e => e.k5)
                .IsUnicode(false);

            modelBuilder.Entity<uch_zvanie>()
                .Property(e => e.k6)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.NameUniversity)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.StreetUniversity)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.TelephoneUniversity)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.FaxUniversity)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.RectorSurname)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.RectorName)
                .IsUnicode(false);

            modelBuilder.Entity<University>()
                .Property(e => e.RectorPatronymic)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user1)
                .IsFixedLength();

            modelBuilder.Entity<user>()
                .Property(e => e.parol)
                .IsFixedLength();

            modelBuilder.Entity<user_faculty>()
                .Property(e => e.f_user_name)
                .IsUnicode(false);

            modelBuilder.Entity<user_faculty>()
                .Property(e => e.user_name)
                .IsFixedLength();

            modelBuilder.Entity<user_faculty>()
                .Property(e => e.OKS)
                .IsFixedLength();

            modelBuilder.Entity<user_faculty>()
                .Property(e => e.OKPPS)
                .IsFixedLength();

            modelBuilder.Entity<user_ok>()
                .Property(e => e.user_name)
                .IsFixedLength();

            modelBuilder.Entity<usluga_rashod>()
                .Property(e => e.shet)
                .IsUnicode(false);

            modelBuilder.Entity<usluga_rashod>()
                .Property(e => e.n_rashod)
                .IsUnicode(false);

            modelBuilder.Entity<usluga_rashod>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<uslugi>()
                .Property(e => e.uslugi1)
                .IsUnicode(false);

            modelBuilder.Entity<uslugi>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<uslugi>()
                .Property(e => e.shet)
                .IsUnicode(false);

            modelBuilder.Entity<v_docs>()
                .Property(e => e.code_docs)
                .IsUnicode(false);

            modelBuilder.Entity<v_docs>()
                .Property(e => e.name_docs)
                .IsUnicode(false);

            modelBuilder.Entity<v_opl>()
                .Property(e => e.p105)
                .IsUnicode(false);

            modelBuilder.Entity<v_opl>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<v_zanyatii>()
                .Property(e => e.v_zanyatii1)
                .IsUnicode(false);

            modelBuilder.Entity<Vakansii>()
                .Property(e => e.razrad)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Vakansii>()
                .Property(e => e.e_n_p)
                .IsUnicode(false);

            modelBuilder.Entity<Vakansii>()
                .Property(e => e.d_n_p)
                .IsUnicode(false);

            modelBuilder.Entity<Vakansii>()
                .HasMany(e => e.Working)
                .WithRequired(e => e.Vakansii)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<var_sum>()
                .Property(e => e.prog)
                .IsUnicode(false);

            modelBuilder.Entity<vid_zaniatiy>()
                .Property(e => e.polya)
                .IsUnicode(false);

            modelBuilder.Entity<VillageKR>()
                .Property(e => e.NameVillage)
                .IsUnicode(false);

            modelBuilder.Entity<vuz>()
                .Property(e => e.v1)
                .IsUnicode(false);

            modelBuilder.Entity<vuz>()
                .Property(e => e.v2)
                .IsUnicode(false);

            modelBuilder.Entity<vuz>()
                .Property(e => e.v1_k)
                .IsUnicode(false);

            modelBuilder.Entity<vuz>()
                .HasMany(e => e.faculty)
                .WithRequired(e => e.vuz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vyz>()
                .Property(e => e.AppVersion)
                .IsUnicode(false);

            modelBuilder.Entity<Vyz_>()
                .Property(e => e.AppVersion)
                .IsUnicode(false);

            modelBuilder.Entity<w_s>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<w_s>()
                .Property(e => e.p42_KG)
                .IsUnicode(false);

            modelBuilder.Entity<w_s>()
                .HasMany(e => e.semester)
                .WithRequired(e => e.w_s)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Work>()
                .Property(e => e.Doljnost)
                .IsUnicode(false);

            modelBuilder.Entity<Work>()
                .Property(e => e.Name_org)
                .IsUnicode(false);

            modelBuilder.Entity<Work>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Work>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Work>()
                .Property(e => e.FIO_Dir)
                .IsUnicode(false);

            modelBuilder.Entity<Work>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Working>()
                .Property(e => e.Num_prikaz_Enter)
                .IsUnicode(false);

            modelBuilder.Entity<Working>()
                .Property(e => e.Num_prikaz_leave)
                .IsUnicode(false);

            modelBuilder.Entity<Working>()
                .Property(e => e.Reason_quit)
                .IsFixedLength();

            modelBuilder.Entity<DEL_mark_mag_arch>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<DEL_mark_mag_arch>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<group_yyy>()
                .Property(e => e.p21)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIns>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIns>()
                .Property(e => e.YearTerminations)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIns>()
                .Property(e => e.SeriesAD)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIns>()
                .Property(e => e.NumberAD)
                .IsUnicode(false);

            modelBuilder.Entity<T_EBooks>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<T_EBooks>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<T_EBooks>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<T_EBooks>()
                .Property(e => e.fileName)
                .IsUnicode(false);

            modelBuilder.Entity<temp_mm_archSH>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<temp_mm_archSH>()
                .Property(e => e.oper)
                .IsUnicode(false);
        }
    }
}
