namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AvnDB : DbContext
    {
        public AvnDB()
            : base("name=AvnDB")
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
        public virtual DbSet<Abiturient> Abiturients { get; set; }
        public virtual DbSet<AbiturientPhoto> AbiturientPhotoes { get; set; }
        public virtual DbSet<AbiturientTest> AbiturientTests { get; set; }
        public virtual DbSet<Abroad> Abroads { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Admin_temp_online_payment> Admin_temp_online_payment { get; set; }
        public virtual DbSet<aud_discip_rasp> aud_discip_rasp { get; set; }
        public virtual DbSet<Aud_rastoynie> Aud_rastoynie { get; set; }
        public virtual DbSet<Auditorium> Auditoriums { get; set; }
        public virtual DbSet<Auroch> Aurochs { get; set; }
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
        public virtual DbSet<AVNStudent> AVNStudents { get; set; }
        public virtual DbSet<AVNTeacher> AVNTeachers { get; set; }
        public virtual DbSet<_base> bases { get; set; }
        public virtual DbSet<bk> bks { get; set; }
        public virtual DbSet<Bronya> Bronyas { get; set; }
        public virtual DbSet<CallEducationInst> CallEducationInsts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Citizenship> Citizenships { get; set; }
        public virtual DbSet<CityKR> CityKRs { get; set; }
        public virtual DbSet<com_gspe> com_gspe { get; set; }
        public virtual DbSet<com_kt> com_kt { get; set; }
        public virtual DbSet<com_sfe> com_sfe { get; set; }
        public virtual DbSet<com_ygr> com_ygr { get; set; }
        public virtual DbSet<come> comes { get; set; }
        public virtual DbSet<component> components { get; set; }
        public virtual DbSet<control> controls { get; set; }
        public virtual DbSet<ControlRating> ControlRatings { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<DatabaseVersion> DatabaseVersions { get; set; }
        public virtual DbSet<DATE_reg_DFS> DATE_reg_DFS { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Debt> Debts { get; set; }
        public virtual DbSet<deduce> deduces { get; set; }
        public virtual DbSet<Def_Uslug> Def_Uslug { get; set; }
        public virtual DbSet<Del_DisciplineForStudent> Del_DisciplineForStudent { get; set; }
        public virtual DbSet<Del_Educ_sh> Del_Educ_sh { get; set; }
        public virtual DbSet<Del_Mark_Mag> Del_Mark_Mag { get; set; }
        public virtual DbSet<Del_movement_t> Del_movement_t { get; set; }
        public virtual DbSet<Del_payment> Del_payment { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DIPL_PRIX> DIPL_PRIX { get; set; }
        public virtual DbSet<Diploma_kval> Diploma_kval { get; set; }
        public virtual DbSet<direction> directions { get; set; }
        public virtual DbSet<disc_n_sv> disc_n_sv { get; set; }
        public virtual DbSet<discipline> disciplines { get; set; }
        public virtual DbSet<disciplineForGo> disciplineForGos { get; set; }
        public virtual DbSet<DisciplineForStudent> DisciplineForStudents { get; set; }
        public virtual DbSet<DisciplineForStudent2> DisciplineForStudent2 { get; set; }
        public virtual DbSet<DisciplineForStudentDeleted> DisciplineForStudentDeleteds { get; set; }
        public virtual DbSet<DisciplineForStudentForVidZaniatiy> DisciplineForStudentForVidZaniatiys { get; set; }
        public virtual DbSet<disciplineForZashita> disciplineForZashitas { get; set; }
        public virtual DbSet<DistrictKR> DistrictKRs { get; set; }
        public virtual DbSet<dopolnitelno> dopolnitelnoes { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<dv> dvs { get; set; }
        public virtual DbSet<ebe> ebes { get; set; }
        public virtual DbSet<ebe_detal> ebe_detal { get; set; }
        public virtual DbSet<Edu> Edus { get; set; }
        public virtual DbSet<Educ> Educs { get; set; }
        public virtual DbSet<educ_form> educ_form { get; set; }
        public virtual DbSet<educ_sh> educ_sh { get; set; }
        public virtual DbSet<educ_sh_kpv> educ_sh_kpv { get; set; }
        public virtual DbSet<Educ_sh_sel> Educ_sh_sel { get; set; }
        public virtual DbSet<Educ_t> Educ_t { get; set; }
        public virtual DbSet<ee> ees { get; set; }
        public virtual DbSet<Elect_org> Elect_org { get; set; }
        public virtual DbSet<end_semestr> end_semestr { get; set; }
        public virtual DbSet<enter> enters { get; set; }
        public virtual DbSet<est_config> est_config { get; set; }
        public virtual DbSet<estimation> estimations { get; set; }
        public virtual DbSet<EstimationOther> EstimationOthers { get; set; }
        public virtual DbSet<examination> examinations { get; set; }
        public virtual DbSet<expense> expenses { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Experience_type_job> Experience_type_job { get; set; }
        public virtual DbSet<f_educ> f_educ { get; set; }
        public virtual DbSet<f_educ_vid> f_educ_vid { get; set; }
        public virtual DbSet<f_est> f_est { get; set; }
        public virtual DbSet<faculty> faculties { get; set; }
        public virtual DbSet<family> families { get; set; }
        public virtual DbSet<family_> family_ { get; set; }
        public virtual DbSet<Family_s> Family_s { get; set; }
        public virtual DbSet<Family_spec> Family_spec { get; set; }
        public virtual DbSet<finish> finishes { get; set; }
        public virtual DbSet<formAction> formActions { get; set; }
        public virtual DbSet<FormOfStydy> FormOfStydies { get; set; }
        public virtual DbSet<GAK_member_history> GAK_member_history { get; set; }
        public virtual DbSet<GAK_member_speciality> GAK_member_speciality { get; set; }
        public virtual DbSet<group_slushatel> group_slushatel { get; set; }
        public virtual DbSet<group_t> group_t { get; set; }
        public virtual DbSet<group_y> group_y { get; set; }
        public virtual DbSet<GroupNotInRRNK> GroupNotInRRNKs { get; set; }
        public virtual DbSet<HighQualification> HighQualifications { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Holliday_t> Holliday_t { get; set; }
        public virtual DbSet<IndividualModulPermiss> IndividualModulPermisses { get; set; }
        public virtual DbSet<IndividualModulPermissByFuckulty> IndividualModulPermissByFuckulties { get; set; }
        public virtual DbSet<IndividualModulPermissBySpeciality> IndividualModulPermissBySpecialities { get; set; }
        public virtual DbSet<IndividualModulPermissGROUP> IndividualModulPermissGROUPs { get; set; }
        public virtual DbSet<IndividualModulPermissPotok> IndividualModulPermissPotoks { get; set; }
        public virtual DbSet<IndividualModulPermissPotok_group> IndividualModulPermissPotok_group { get; set; }
        public virtual DbSet<InfoOnTesting> InfoOnTestings { get; set; }
        public virtual DbSet<kafedra> kafedras { get; set; }
        public virtual DbSet<kafLogin> kafLogins { get; set; }
        public virtual DbSet<KafSecurity> KafSecurities { get; set; }
        public virtual DbSet<KasFak> KasFaks { get; set; }
        public virtual DbSet<Kassa> Kassas { get; set; }
        public virtual DbSet<kind> kinds { get; set; }
        public virtual DbSet<korpu> korpus { get; set; }
        public virtual DbSet<Kredit_fakulty> Kredit_fakulty { get; set; }
        public virtual DbSet<kv_job> kv_job { get; set; }
        public virtual DbSet<Kvalifikation> Kvalifikations { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Language_options> Language_options { get; set; }
        public virtual DbSet<language1> languages1 { get; set; }
        public virtual DbSet<leave> leaves { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Library_dolg> Library_dolg { get; set; }
        public virtual DbSet<Library_dolg_LOG> Library_dolg_LOG { get; set; }
        public virtual DbSet<Licence> Licences { get; set; }
        public virtual DbSet<mark_mag> mark_mag { get; set; }
        public virtual DbSet<mark_mag_arch> mark_mag_arch { get; set; }
        public virtual DbSet<Member_type> Member_type { get; set; }
        public virtual DbSet<mil_card> mil_card { get; set; }
        public virtual DbSet<mil_card_> mil_card_ { get; set; }
        public virtual DbSet<Mil_name> Mil_name { get; set; }
        public virtual DbSet<Mil_R_Voisk> Mil_R_Voisk { get; set; }
        public virtual DbSet<Mil_valid> Mil_valid { get; set; }
        public virtual DbSet<MilitaryInfo> MilitaryInfoes { get; set; }
        public virtual DbSet<ministerstvo> ministerstvoes { get; set; }
        public virtual DbSet<MobileContactBack> MobileContactBacks { get; set; }
        public virtual DbSet<MobileProblem> MobileProblems { get; set; }
        public virtual DbSet<MobileRaport> MobileRaports { get; set; }
        public virtual DbSet<MobileRaportDetail> MobileRaportDetails { get; set; }
        public virtual DbSet<MobileStudentAdmission> MobileStudentAdmissions { get; set; }
        public virtual DbSet<MobileStudentAdmissionForReport> MobileStudentAdmissionForReports { get; set; }
        public virtual DbSet<MobileStudentAnnounceDay> MobileStudentAnnounceDays { get; set; }
        public virtual DbSet<MobileStudentDolg> MobileStudentDolgs { get; set; }
        public virtual DbSet<MobileStudentDuty> MobileStudentDuties { get; set; }
        public virtual DbSet<MobileToken> MobileTokens { get; set; }
        public virtual DbSet<Modul> Moduls { get; set; }
        public virtual DbSet<modul_info> modul_info { get; set; }
        public virtual DbSet<ModulPermiss> ModulPermisses { get; set; }
        public virtual DbSet<mov_beg_giv> mov_beg_giv { get; set; }
        public virtual DbSet<mov_beg_ret> mov_beg_ret { get; set; }
        public virtual DbSet<mov_ved_giv> mov_ved_giv { get; set; }
        public virtual DbSet<mov_ved_ret> mov_ved_ret { get; set; }
        public virtual DbSet<movement_slushatel> movement_slushatel { get; set; }
        public virtual DbSet<movement_t> movement_t { get; set; }
        public virtual DbSet<MovementDop> MovementDops { get; set; }
        public virtual DbSet<MVD_Pasport> MVD_Pasport { get; set; }
        public virtual DbSet<n_gr> n_gr { get; set; }
        public virtual DbSet<nagrada> nagradas { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<nedeli> nedelis { get; set; }
        public virtual DbSet<nedeli_shedule> nedeli_shedule { get; set; }
        public virtual DbSet<ObemChasov> ObemChasovs { get; set; }
        public virtual DbSet<obrazovanie_teacher> obrazovanie_teacher { get; set; }
        public virtual DbSet<oplata> oplatas { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Organization_member> Organization_member { get; set; }
        public virtual DbSet<Otdel_1> Otdel_1 { get; set; }
        public virtual DbSet<ParentsInfo> ParentsInfoes { get; set; }
        public virtual DbSet<Partiya> Partiyas { get; set; }
        public virtual DbSet<passport> passports { get; set; }
        public virtual DbSet<pay_educ> pay_educ { get; set; }
        public virtual DbSet<pay_gr_con> pay_gr_con { get; set; }
        public virtual DbSet<pay_group> pay_group { get; set; }
        public virtual DbSet<PaymentTransfer_Virtual> PaymentTransfer_Virtual { get; set; }
        public virtual DbSet<Pensioner> Pensioners { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Place_leave> Place_leave { get; set; }
        public virtual DbSet<Place_of_birth> Place_of_birth { get; set; }
        public virtual DbSet<Place_of_residence> Place_of_residence { get; set; }
        public virtual DbSet<plan_abit> plan_abit { get; set; }
        public virtual DbSet<PlaseSetrORT> PlaseSetrORTs { get; set; }
        public virtual DbSet<pol> pols { get; set; }
        public virtual DbSet<poseshal> poseshals { get; set; }
        public virtual DbSet<Posrekvezit> Posrekvezits { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<Prerekvezit> Prerekvezits { get; set; }
        public virtual DbSet<Prikaz_come> Prikaz_come { get; set; }
        public virtual DbSet<prikaz_come_slushatel> prikaz_come_slushatel { get; set; }
        public virtual DbSet<Prikaz_leave> Prikaz_leave { get; set; }
        public virtual DbSet<prikaz_leave_slushatel> prikaz_leave_slushatel { get; set; }
        public virtual DbSet<Prog_Security> Prog_Security { get; set; }
        public virtual DbSet<Progs_Permiss> Progs_Permiss { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<PublicationType> PublicationTypes { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Quit_Course> Quit_Course { get; set; }
        public virtual DbSet<r_ss> r_ss { get; set; }
        public virtual DbSet<Raboty_sprav> Raboty_sprav { get; set; }
        public virtual DbSet<Rang> Rangs { get; set; }
        public virtual DbSet<rashod> rashods { get; set; }
        public virtual DbSet<rate> rates { get; set; }
        public virtual DbSet<ReceptInfo> ReceptInfoes { get; set; }
        public virtual DbSet<RegionKR> RegionKRs { get; set; }
        public virtual DbSet<Republic> Republics { get; set; }
        public virtual DbSet<RRNK> RRNKs { get; set; }
        public virtual DbSet<RRNK_doljnost> RRNK_doljnost { get; set; }
        public virtual DbSet<rrnk_elements> rrnk_elements { get; set; }
        public virtual DbSet<rrnk_elements_old> rrnk_elements_old { get; set; }
        public virtual DbSet<rrnk_fakt> rrnk_fakt { get; set; }
        public virtual DbSet<RRNK_gr_kolst> RRNK_gr_kolst { get; set; }
        public virtual DbSet<RRNK_krdt_kolst> RRNK_krdt_kolst { get; set; }
        public virtual DbSet<RRNK_pps> RRNK_pps { get; set; }
        public virtual DbSet<RRNK_Schedule> RRNK_Schedule { get; set; }
        public virtual DbSet<RRNKCalc> RRNKCalcs { get; set; }
        public virtual DbSet<RRNKDop> RRNKDops { get; set; }
        public virtual DbSet<RRNKkrdt> RRNKkrdts { get; set; }
        public virtual DbSet<rrnkPermiss> rrnkPermisses { get; set; }
        public virtual DbSet<rss> rsses { get; set; }
        public virtual DbSet<S_G> S_G { get; set; }
        public virtual DbSet<S_G_opt> S_G_opt { get; set; }
        public virtual DbSet<SCHDayOffAuditory> SCHDayOffAuditories { get; set; }
        public virtual DbSet<SCHDayOffEmployee> SCHDayOffEmployees { get; set; }
        public virtual DbSet<SCHDayOffGroup> SCHDayOffGroups { get; set; }
        public virtual DbSet<ScheduleAdditionalGroup> ScheduleAdditionalGroups { get; set; }
        public virtual DbSet<SchoolDiscipline> SchoolDisciplines { get; set; }
        public virtual DbSet<SCHSchedule> SCHSchedules { get; set; }
        public virtual DbSet<SCHSchedule_discp_pasp> SCHSchedule_discp_pasp { get; set; }
        public virtual DbSet<SCHScheduleGroup> SCHScheduleGroups { get; set; }
        public virtual DbSet<SCHStudyType> SCHStudyTypes { get; set; }
        public virtual DbSet<SCHSubjectShortName> SCHSubjectShortNames { get; set; }
        public virtual DbSet<SCHWeekDay> SCHWeekDays { get; set; }
        public virtual DbSet<ScientificActivity> ScientificActivities { get; set; }
        public virtual DbSet<semester> semesters { get; set; }
        public virtual DbSet<SemestrShcedule> SemestrShcedules { get; set; }
        public virtual DbSet<Shcedule> Shcedules { get; set; }
        public virtual DbSet<shet> shets { get; set; }
        public virtual DbSet<shetchik_avn10_report> shetchik_avn10_report { get; set; }
        public virtual DbSet<smeta> smetas { get; set; }
        public virtual DbSet<Smeta_date> Smeta_date { get; set; }
        public virtual DbSet<Soc_pr> Soc_pr { get; set; }
        public virtual DbSet<Spec_Code> Spec_Code { get; set; }
        public virtual DbSet<special> specials { get; set; }
        public virtual DbSet<specialOKT> specialOKTs { get; set; }
        public virtual DbSet<Specific> Specifics { get; set; }
        public virtual DbSet<Spravka> Spravkas { get; set; }
        public virtual DbSet<SQL_User> SQL_User { get; set; }
        public virtual DbSet<StandardOfEducation> StandardOfEducations { get; set; }
        public virtual DbSet<Stavka> Stavkas { get; set; }
        public virtual DbSet<StreamType> StreamTypes { get; set; }
        public virtual DbSet<structure> structures { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_ORT_balls> Student_ORT_balls { get; set; }
        public virtual DbSet<StudentPhoto> StudentPhotoes { get; set; }
        public virtual DbSet<StudLang> StudLangs { get; set; }
        public virtual DbSet<StudyCemester> StudyCemesters { get; set; }
        public virtual DbSet<StudyYear> StudyYears { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
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
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<teacher_info> teacher_info { get; set; }
        public virtual DbSet<teacher_medosmotr> teacher_medosmotr { get; set; }
        public virtual DbSet<teacher_skills> teacher_skills { get; set; }
        public virtual DbSet<teacher_stepen> teacher_stepen { get; set; }
        public virtual DbSet<teacher_struktura> teacher_struktura { get; set; }
        public virtual DbSet<temp_online_payment> temp_online_payment { get; set; }
        public virtual DbSet<temp_tt> temp_tt { get; set; }
        public virtual DbSet<testtable> testtables { get; set; }
        public virtual DbSet<Time_> Time_ { get; set; }
        public virtual DbSet<ToolTable> ToolTables { get; set; }
        public virtual DbSet<Trudoem> Trudoems { get; set; }
        public virtual DbSet<TypeChasov> TypeChasovs { get; set; }
        public virtual DbSet<TypeControl> TypeControls { get; set; }
        public virtual DbSet<TypeHour> TypeHours { get; set; }
        public virtual DbSet<TypeScholl> TypeScholls { get; set; }
        public virtual DbSet<uch_step> uch_step { get; set; }
        public virtual DbSet<uch_zvanie> uch_zvanie { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<User_ebe_var> User_ebe_var { get; set; }
        public virtual DbSet<User_f_educ> User_f_educ { get; set; }
        public virtual DbSet<User_f_est> User_f_est { get; set; }
        public virtual DbSet<user_faculty> user_faculty { get; set; }
        public virtual DbSet<User_Kafedra> User_Kafedra { get; set; }
        public virtual DbSet<user_ok> user_ok { get; set; }
        public virtual DbSet<usluga_rashod> usluga_rashod { get; set; }
        public virtual DbSet<uslugi> uslugis { get; set; }
        public virtual DbSet<v_docs> v_docs { get; set; }
        public virtual DbSet<v_opl> v_opl { get; set; }
        public virtual DbSet<v_zanyatii> v_zanyatii { get; set; }
        public virtual DbSet<Vakansii> Vakansiis { get; set; }
        public virtual DbSet<var_sum> var_sum { get; set; }
        public virtual DbSet<vedomost_akadem> vedomost_akadem { get; set; }
        public virtual DbSet<vid_zaniatiy> vid_zaniatiy { get; set; }
        public virtual DbSet<VillageKR> VillageKRs { get; set; }
        public virtual DbSet<VisibleCallEduc> VisibleCallEducs { get; set; }
        public virtual DbSet<VisibleRecTable> VisibleRecTables { get; set; }
        public virtual DbSet<Visiting> Visitings { get; set; }
        public virtual DbSet<vuz> vuzs { get; set; }
        public virtual DbSet<VuzDefault> VuzDefaults { get; set; }
        public virtual DbSet<Vyz> Vyzs { get; set; }
        public virtual DbSet<Vyz_> Vyz_ { get; set; }
        public virtual DbSet<w_s> w_s { get; set; }
        public virtual DbSet<Wbr_Rooms> Wbr_Rooms { get; set; }
        public virtual DbSet<Wbr_Students> Wbr_Students { get; set; }
        public virtual DbSet<Wbr_Teachers> Wbr_Teachers { get; set; }
        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<Working> Workings { get; set; }
        public virtual DbSet<akad_grafik> akad_grafik { get; set; }
        public virtual DbSet<CorrT> CorrTs { get; set; }
        public virtual DbSet<DEL_mark_mag_arch> DEL_mark_mag_arch { get; set; }
        public virtual DbSet<Del_RRNK> Del_RRNK { get; set; }
        public virtual DbSet<Del_RRNKkrdt> Del_RRNKkrdt { get; set; }
        public virtual DbSet<discipline_type> discipline_type { get; set; }
        public virtual DbSet<group_yyy> group_yyy { get; set; }
        public virtual DbSet<IncorrT> IncorrTs { get; set; }
        public virtual DbSet<InfoOnEdIn> InfoOnEdIns { get; set; }
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
        public virtual DbSet<C__Z_USPEV_UC> C__Z_USPEV_UC { get; set; }
        public virtual DbSet<C__ZS_EDUCSH> C__ZS_EDUCSH { get; set; }
        public virtual DbSet<C__ZS_mark_mag> C__ZS_mark_mag { get; set; }
        public virtual DbSet<C11> C11 { get; set; }
        public virtual DbSet<C1111111111> C1111111111 { get; set; }
        public virtual DbSet<C123> C123 { get; set; }
        public virtual DbSet<a_attandanceGroup> a_attandanceGroup { get; set; }
        public virtual DbSet<a_disiplinForStudentAttandance> a_disiplinForStudentAttandance { get; set; }
        public virtual DbSet<a1_1> a1_1 { get; set; }
        public virtual DbSet<a1_2> a1_2 { get; set; }
        public virtual DbSet<a1_2_vse> a1_2_vse { get; set; }
        public virtual DbSet<ab_fio> ab_fio { get; set; }
        public virtual DbSet<Ab_InfoSchool> Ab_InfoSchool { get; set; }
        public virtual DbSet<abit_1> abit_1 { get; set; }
        public virtual DbSet<abit_2> abit_2 { get; set; }
        public virtual DbSet<abit_3> abit_3 { get; set; }
        public virtual DbSet<abit_4> abit_4 { get; set; }
        public virtual DbSet<abit_5> abit_5 { get; set; }
        public virtual DbSet<abit_6> abit_6 { get; set; }
        public virtual DbSet<abit_7> abit_7 { get; set; }
        public virtual DbSet<abit_find> abit_find { get; set; }
        public virtual DbSet<ABIT_PROVERKA> ABIT_PROVERKA { get; set; }
        public virtual DbSet<Abit_ranj_lgotnik> Abit_ranj_lgotnik { get; set; }
        public virtual DbSet<abit_ranj_sel> abit_ranj_sel { get; set; }
        public virtual DbSet<Abit_svod_kateg> Abit_svod_kateg { get; set; }
        public virtual DbSet<Abit_svod_kateg_kontr> Abit_svod_kateg_kontr { get; set; }
        public virtual DbSet<Abit_svod_kateg_PLAN> Abit_svod_kateg_PLAN { get; set; }
        public virtual DbSet<Abit_svod_kateg2> Abit_svod_kateg2 { get; set; }
        public virtual DbSet<abit_temp_direction> abit_temp_direction { get; set; }
        public virtual DbSet<abit_temp_plan> abit_temp_plan { get; set; }
        public virtual DbSet<Abit_test_view> Abit_test_view { get; set; }
        public virtual DbSet<Abit_web> Abit_web { get; set; }
        public virtual DbSet<AbitRecom> AbitRecoms { get; set; }
        public virtual DbSet<AbitRecom_podtver> AbitRecom_podtver { get; set; }
        public virtual DbSet<AbitRecom_zachisl> AbitRecom_zachisl { get; set; }
        public virtual DbSet<AbitRecom_zachisl_pivot> AbitRecom_zachisl_pivot { get; set; }
        public virtual DbSet<Admin_good_onlinepayment> Admin_good_onlinepayment { get; set; }
        public virtual DbSet<Admin_KyrgazstanBank_Unhandled_List> Admin_KyrgazstanBank_Unhandled_List { get; set; }
        public virtual DbSet<analiz_1m> analiz_1m { get; set; }
        public virtual DbSet<ank_fak> ank_fak { get; set; }
        public virtual DbSet<ank_fak_gr_st> ank_fak_gr_st { get; set; }
        public virtual DbSet<Ankenirovanie_RS_tfio_R> Ankenirovanie_RS_tfio_R { get; set; }
        public virtual DbSet<Ankentirovanie4> Ankentirovanie4 { get; set; }
        public virtual DbSet<anket_kaf1> anket_kaf1 { get; set; }
        public virtual DbSet<Anket_Questionnaires> Anket_Questionnaires { get; set; }
        public virtual DbSet<Anket_Questions> Anket_Questions { get; set; }
        public virtual DbSet<Anket_RRNK_kaf> Anket_RRNK_kaf { get; set; }
        public virtual DbSet<Anketirovanie_Da> Anketirovanie_Da { get; set; }
        public virtual DbSet<Anketirovanie_kol_ball> Anketirovanie_kol_ball { get; set; }
        public virtual DbSet<Anketirovanie_MM> Anketirovanie_MM { get; set; }
        public virtual DbSet<Anketirovanie_net> Anketirovanie_net { get; set; }
        public virtual DbSet<Anketirovanie_Questions> Anketirovanie_Questions { get; set; }
        public virtual DbSet<Anketirovanie_RA_Full> Anketirovanie_RA_Full { get; set; }
        public virtual DbSet<Anketirovanie_RS> Anketirovanie_RS { get; set; }
        public virtual DbSet<Anketirovanie_RS_kaf> Anketirovanie_RS_kaf { get; set; }
        public virtual DbSet<Anketirovanie_RS_vuz> Anketirovanie_RS_vuz { get; set; }
        public virtual DbSet<Anketirovanie_RS2> Anketirovanie_RS2 { get; set; }
        public virtual DbSet<Anketirovarie_Kol_Full> Anketirovarie_Kol_Full { get; set; }
        public virtual DbSet<Antekirovanie_RS_kafedra> Antekirovanie_RS_kafedra { get; set; }
        public virtual DbSet<AVN_Progs_Info> AVN_Progs_Info { get; set; }
        public virtual DbSet<AVN_User_Deleted> AVN_User_Deleted { get; set; }
        public virtual DbSet<AVN_User_View> AVN_User_View { get; set; }
        public virtual DbSet<AVN_User_Visible> AVN_User_Visible { get; set; }
        public virtual DbSet<AVNLOG_1_1> AVNLOG_1_1 { get; set; }
        public virtual DbSet<AVNLOG_2> AVNLOG_2 { get; set; }
        public virtual DbSet<AVNLOG_3> AVNLOG_3 { get; set; }
        public virtual DbSet<AVNLOG_4> AVNLOG_4 { get; set; }
        public virtual DbSet<AVNLOG_B_3> AVNLOG_B_3 { get; set; }
        public virtual DbSet<AVNtest_1> AVNtest_1 { get; set; }
        public virtual DbSet<AVNtest_2> AVNtest_2 { get; set; }
        public virtual DbSet<AVNtest_3> AVNtest_3 { get; set; }
        public virtual DbSet<AVNtest_4> AVNtest_4 { get; set; }
        public virtual DbSet<AZ_AttandanceDiagramma> AZ_AttandanceDiagramma { get; set; }
        public virtual DbSet<AZ_DOPUSK> AZ_DOPUSK { get; set; }
        public virtual DbSet<AZ_mobileDisiplineForStudent> AZ_mobileDisiplineForStudent { get; set; }
        public virtual DbSet<AZ_mobileTeacherAttandance> AZ_mobileTeacherAttandance { get; set; }
        public virtual DbSet<AZ_sum_KREDIT> AZ_sum_KREDIT { get; set; }
        public virtual DbSet<b_temp> b_temp { get; set; }
        public virtual DbSet<bank_akt_sverka> bank_akt_sverka { get; set; }
        public virtual DbSet<bank_akt_sverka3> bank_akt_sverka3 { get; set; }
        public virtual DbSet<Bank_payment> Bank_payment { get; set; }
        public virtual DbSet<bank_payment_3> bank_payment_3 { get; set; }
        public virtual DbSet<bank_payment_5> bank_payment_5 { get; set; }
        public virtual DbSet<bf_0> bf_0 { get; set; }
        public virtual DbSet<bf_1_0> bf_1_0 { get; set; }
        public virtual DbSet<bf_1_1_new> bf_1_1_new { get; set; }
        public virtual DbSet<bf_1_11> bf_1_11 { get; set; }
        public virtual DbSet<bf_1_2> bf_1_2 { get; set; }
        public virtual DbSet<bf_1_2_old> bf_1_2_old { get; set; }
        public virtual DbSet<bf_1_2l> bf_1_2l { get; set; }
        public virtual DbSet<bf_1_3> bf_1_3 { get; set; }
        public virtual DbSet<bf_1_3l> bf_1_3l { get; set; }
        public virtual DbSet<BriefDisciplineInfo> BriefDisciplineInfoes { get; set; }
        public virtual DbSet<ch1> ch1 { get; set; }
        public virtual DbSet<ch2> ch2 { get; set; }
        public virtual DbSet<ch3> ch3 { get; set; }
        public virtual DbSet<ch4> ch4 { get; set; }
        public virtual DbSet<con_user> con_user { get; set; }
        public virtual DbSet<ControlRating_aud> ControlRating_aud { get; set; }
        public virtual DbSet<ControlRating_disc> ControlRating_disc { get; set; }
        public virtual DbSet<ControlRating_gr_f> ControlRating_gr_f { get; set; }
        public virtual DbSet<D_gr> D_gr { get; set; }
        public virtual DbSet<del_null_rrnk> del_null_rrnk { get; set; }
        public virtual DbSet<Dipl_gr> Dipl_gr { get; set; }
        public virtual DbSet<disc> discs { get; set; }
        public virtual DbSet<duty> duties { get; set; }
        public virtual DbSet<dva> dvas { get; set; }
        public virtual DbSet<dva_os> dva_os { get; set; }
        public virtual DbSet<dva_ps> dva_ps { get; set; }
        public virtual DbSet<ed_sh_gr> ed_sh_gr { get; set; }
        public virtual DbSet<Educ_sh_with_kpv> Educ_sh_with_kpv { get; set; }
        public virtual DbSet<est> ests { get; set; }
        public virtual DbSet<est1> est1 { get; set; }
        public virtual DbSet<est2> est2 { get; set; }
        public virtual DbSet<est3> est3 { get; set; }
        public virtual DbSet<est4> est4 { get; set; }
        public virtual DbSet<exp_dipl> exp_dipl { get; set; }
        public virtual DbSet<expen_rate> expen_rate { get; set; }
        public virtual DbSet<expen_st> expen_st { get; set; }
        public virtual DbSet<f_4b> f_4b { get; set; }
        public virtual DbSet<f_AVN28_disc> f_AVN28_disc { get; set; }
        public virtual DbSet<f_AVN28_disc_base> f_AVN28_disc_base { get; set; }
        public virtual DbSet<f_AVN28_exam> f_AVN28_exam { get; set; }
        public virtual DbSet<f_AVN28_exam_base> f_AVN28_exam_base { get; set; }
        public virtual DbSet<f_AVN28_gr_potok> f_AVN28_gr_potok { get; set; }
        public virtual DbSet<f_AVN28_gr_potok_base> f_AVN28_gr_potok_base { get; set; }
        public virtual DbSet<f_AVN28_sem> f_AVN28_sem { get; set; }
        public virtual DbSet<f_AVN28_sem_base> f_AVN28_sem_base { get; set; }
        public virtual DbSet<F_FIO> F_FIO { get; set; }
        public virtual DbSet<F_lms_Semesters> F_lms_Semesters { get; set; }
        public virtual DbSet<F_lms_Years> F_lms_Years { get; set; }
        public virtual DbSet<f1_1> f1_1 { get; set; }
        public virtual DbSet<f1_1sel> f1_1sel { get; set; }
        public virtual DbSet<f1_3> f1_3 { get; set; }
        public virtual DbSet<f1_3sel> f1_3sel { get; set; }
        public virtual DbSet<f1_4> f1_4 { get; set; }
        public virtual DbSet<f1_4a> f1_4a { get; set; }
        public virtual DbSet<f1_4sel> f1_4sel { get; set; }
        public virtual DbSet<f1_5> f1_5 { get; set; }
        public virtual DbSet<f1_6> f1_6 { get; set; }
        public virtual DbSet<f10_1> f10_1 { get; set; }
        public virtual DbSet<f10_5> f10_5 { get; set; }
        public virtual DbSet<f12_1> f12_1 { get; set; }
        public virtual DbSet<f12_2> f12_2 { get; set; }
        public virtual DbSet<f12_2_1> f12_2_1 { get; set; }
        public virtual DbSet<f12_2_2> f12_2_2 { get; set; }
        public virtual DbSet<f12_3> f12_3 { get; set; }
        public virtual DbSet<f13_1_0> f13_1_0 { get; set; }
        public virtual DbSet<f13_1_1> f13_1_1 { get; set; }
        public virtual DbSet<f13_1_1_1> f13_1_1_1 { get; set; }
        public virtual DbSet<f13_1_2> f13_1_2 { get; set; }
        public virtual DbSet<f13_1_2_1> f13_1_2_1 { get; set; }
        public virtual DbSet<f13_1_3> f13_1_3 { get; set; }
        public virtual DbSet<f13_1_3_1> f13_1_3_1 { get; set; }
        public virtual DbSet<f13_2_1> f13_2_1 { get; set; }
        public virtual DbSet<f13_2_1_1> f13_2_1_1 { get; set; }
        public virtual DbSet<f13_2_2> f13_2_2 { get; set; }
        public virtual DbSet<f13_2_2_1> f13_2_2_1 { get; set; }
        public virtual DbSet<f13_2_3> f13_2_3 { get; set; }
        public virtual DbSet<f13_2_3_1> f13_2_3_1 { get; set; }
        public virtual DbSet<f13_3_1> f13_3_1 { get; set; }
        public virtual DbSet<f13_3_1_1> f13_3_1_1 { get; set; }
        public virtual DbSet<f13_3_2> f13_3_2 { get; set; }
        public virtual DbSet<f13_3_2_1> f13_3_2_1 { get; set; }
        public virtual DbSet<f13_3_3> f13_3_3 { get; set; }
        public virtual DbSet<f13_3_3_1> f13_3_3_1 { get; set; }
        public virtual DbSet<f14_1_0> f14_1_0 { get; set; }
        public virtual DbSet<f14_1_1> f14_1_1 { get; set; }
        public virtual DbSet<f14_1_1_1> f14_1_1_1 { get; set; }
        public virtual DbSet<f14_1_2> f14_1_2 { get; set; }
        public virtual DbSet<f14_1_2_1> f14_1_2_1 { get; set; }
        public virtual DbSet<f14_1_3> f14_1_3 { get; set; }
        public virtual DbSet<f14_1_3_1> f14_1_3_1 { get; set; }
        public virtual DbSet<f15_1_0> f15_1_0 { get; set; }
        public virtual DbSet<f15_1_1> f15_1_1 { get; set; }
        public virtual DbSet<f15_1_1_1> f15_1_1_1 { get; set; }
        public virtual DbSet<f15_1_2> f15_1_2 { get; set; }
        public virtual DbSet<f15_1_2_1> f15_1_2_1 { get; set; }
        public virtual DbSet<f15_1_3> f15_1_3 { get; set; }
        public virtual DbSet<f15_1_3_1> f15_1_3_1 { get; set; }
        public virtual DbSet<f15_2_1> f15_2_1 { get; set; }
        public virtual DbSet<f15_2_1_1> f15_2_1_1 { get; set; }
        public virtual DbSet<f15_2_2> f15_2_2 { get; set; }
        public virtual DbSet<f15_2_2_1> f15_2_2_1 { get; set; }
        public virtual DbSet<f15_2_3> f15_2_3 { get; set; }
        public virtual DbSet<f15_2_3_1> f15_2_3_1 { get; set; }
        public virtual DbSet<f15_3_1> f15_3_1 { get; set; }
        public virtual DbSet<f15_3_1_1> f15_3_1_1 { get; set; }
        public virtual DbSet<f15_3_2> f15_3_2 { get; set; }
        public virtual DbSet<f15_3_2_1> f15_3_2_1 { get; set; }
        public virtual DbSet<f15_3_3> f15_3_3 { get; set; }
        public virtual DbSet<f15_3_3_1> f15_3_3_1 { get; set; }
        public virtual DbSet<f15_4_1> f15_4_1 { get; set; }
        public virtual DbSet<f15_4_1_1> f15_4_1_1 { get; set; }
        public virtual DbSet<f15_4_2> f15_4_2 { get; set; }
        public virtual DbSet<f15_4_2_1> f15_4_2_1 { get; set; }
        public virtual DbSet<f15_4_3> f15_4_3 { get; set; }
        public virtual DbSet<f15_4_3_1> f15_4_3_1 { get; set; }
        public virtual DbSet<f15_5_0> f15_5_0 { get; set; }
        public virtual DbSet<f15_5_1> f15_5_1 { get; set; }
        public virtual DbSet<f15_5_2> f15_5_2 { get; set; }
        public virtual DbSet<f15_5_3> f15_5_3 { get; set; }
        public virtual DbSet<f15_6_1> f15_6_1 { get; set; }
        public virtual DbSet<f15_6_2> f15_6_2 { get; set; }
        public virtual DbSet<f15_6_3> f15_6_3 { get; set; }
        public virtual DbSet<f16_1_0> f16_1_0 { get; set; }
        public virtual DbSet<f16_1_1> f16_1_1 { get; set; }
        public virtual DbSet<f16_1_1_1> f16_1_1_1 { get; set; }
        public virtual DbSet<f16_1_2> f16_1_2 { get; set; }
        public virtual DbSet<f16_1_2_1> f16_1_2_1 { get; set; }
        public virtual DbSet<f16_1_3> f16_1_3 { get; set; }
        public virtual DbSet<f16_1_3_1> f16_1_3_1 { get; set; }
        public virtual DbSet<f16_1_4> f16_1_4 { get; set; }
        public virtual DbSet<f16_1_4_1> f16_1_4_1 { get; set; }
        public virtual DbSet<f17_1_0> f17_1_0 { get; set; }
        public virtual DbSet<f17_1_1> f17_1_1 { get; set; }
        public virtual DbSet<f17_1_1_1> f17_1_1_1 { get; set; }
        public virtual DbSet<f17_1_2> f17_1_2 { get; set; }
        public virtual DbSet<f17_1_2_1> f17_1_2_1 { get; set; }
        public virtual DbSet<f17_1_3> f17_1_3 { get; set; }
        public virtual DbSet<f17_1_3_1> f17_1_3_1 { get; set; }
        public virtual DbSet<f17_1_4> f17_1_4 { get; set; }
        public virtual DbSet<f17_1_4_1> f17_1_4_1 { get; set; }
        public virtual DbSet<f18_1_0> f18_1_0 { get; set; }
        public virtual DbSet<f18_1_1> f18_1_1 { get; set; }
        public virtual DbSet<f18_1_1_1> f18_1_1_1 { get; set; }
        public virtual DbSet<f18_1_2> f18_1_2 { get; set; }
        public virtual DbSet<f18_1_2_1> f18_1_2_1 { get; set; }
        public virtual DbSet<f18_1_3> f18_1_3 { get; set; }
        public virtual DbSet<f18_1_3_1> f18_1_3_1 { get; set; }
        public virtual DbSet<f18_1_4> f18_1_4 { get; set; }
        public virtual DbSet<f18_1_4_1> f18_1_4_1 { get; set; }
        public virtual DbSet<f19_1_0> f19_1_0 { get; set; }
        public virtual DbSet<f20_1_0> f20_1_0 { get; set; }
        public virtual DbSet<f26_1_0> f26_1_0 { get; set; }
        public virtual DbSet<f28_gruppa> f28_gruppa { get; set; }
        public virtual DbSet<f28_years> f28_years { get; set; }
        public virtual DbSet<f3_1> f3_1 { get; set; }
        public virtual DbSet<f3_1_1> f3_1_1 { get; set; }
        public virtual DbSet<f3_1_2> f3_1_2 { get; set; }
        public virtual DbSet<f3_1_3> f3_1_3 { get; set; }
        public virtual DbSet<f3_1_4> f3_1_4 { get; set; }
        public virtual DbSet<f3_1_5> f3_1_5 { get; set; }
        public virtual DbSet<f3_1_6> f3_1_6 { get; set; }
        public virtual DbSet<f3_2_1> f3_2_1 { get; set; }
        public virtual DbSet<f3_2_2> f3_2_2 { get; set; }
        public virtual DbSet<f3_2_3> f3_2_3 { get; set; }
        public virtual DbSet<f3_2_4> f3_2_4 { get; set; }
        public virtual DbSet<f3_3_1> f3_3_1 { get; set; }
        public virtual DbSet<f3_3_2> f3_3_2 { get; set; }
        public virtual DbSet<f3_3_3> f3_3_3 { get; set; }
        public virtual DbSet<f8_3_b8> f8_3_b8 { get; set; }
        public virtual DbSet<f8_3_d6> f8_3_d6 { get; set; }
        public virtual DbSet<f8_3_d68> f8_3_d68 { get; set; }
        public virtual DbSet<f8_3_dolg> f8_3_dolg { get; set; }
        public virtual DbSet<f8_3_dva> f8_3_dva { get; set; }
        public virtual DbSet<f8_3_odin> f8_3_odin { get; set; }
        public virtual DbSet<f8_3_st> f8_3_st { get; set; }
        public virtual DbSet<f8_3_tri> f8_3_tri { get; set; }
        public virtual DbSet<f9_2_1> f9_2_1 { get; set; }
        public virtual DbSet<Faculty_V> Faculty_V { get; set; }
        public virtual DbSet<fio_st> fio_st { get; set; }
        public virtual DbSet<for_arch_marg_mag> for_arch_marg_mag { get; set; }
        public virtual DbSet<for_avn6_kol_st> for_avn6_kol_st { get; set; }
        public virtual DbSet<for_kass> for_kass { get; set; }
        public virtual DbSet<for_kass_2> for_kass_2 { get; set; }
        public virtual DbSet<for_test> for_test { get; set; }
        public virtual DbSet<for_test_all> for_test_all { get; set; }
        public virtual DbSet<for_test_povtor> for_test_povtor { get; set; }
        public virtual DbSet<ForElectrVedomost> ForElectrVedomosts { get; set; }
        public virtual DbSet<foto_1kurs> foto_1kurs { get; set; }
        public virtual DbSet<foto_2kurs> foto_2kurs { get; set; }
        public virtual DbSet<foto_3kurs> foto_3kurs { get; set; }
        public virtual DbSet<foto_4kurs> foto_4kurs { get; set; }
        public virtual DbSet<foto_5kurs> foto_5kurs { get; set; }
        public virtual DbSet<foto_6kurs> foto_6kurs { get; set; }
        public virtual DbSet<g_f> g_f { get; set; }
        public virtual DbSet<g_r> g_r { get; set; }
        public virtual DbSet<g_r_y> g_r_y { get; set; }
        public virtual DbSet<g_s> g_s { get; set; }
        public virtual DbSet<g_s_sem_disc_exam> g_s_sem_disc_exam { get; set; }
        public virtual DbSet<g_s_sem_disc_exam_v> g_s_sem_disc_exam_v { get; set; }
        public virtual DbSet<g_sem> g_sem { get; set; }
        public virtual DbSet<GetMinMaxBalForEstimation> GetMinMaxBalForEstimations { get; set; }
        public virtual DbSet<GPA> GPAs { get; set; }
        public virtual DbSet<gr_sem_disc_exam> gr_sem_disc_exam { get; set; }
        public virtual DbSet<gr_sem_disc_exam_bk> gr_sem_disc_exam_bk { get; set; }
        public virtual DbSet<gr_sem_disc_exam1> gr_sem_disc_exam1 { get; set; }
        public virtual DbSet<gr_st_kol_dolg> gr_st_kol_dolg { get; set; }
        public virtual DbSet<gr_st_view> gr_st_view { get; set; }
        public virtual DbSet<gr_year_spec_oz_fac> gr_year_spec_oz_fac { get; set; }
        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<group_form> group_form { get; set; }
        public virtual DbSet<Group_kol_yaer> Group_kol_yaer { get; set; }
        public virtual DbSet<group_reports> group_reports { get; set; }
        public virtual DbSet<GroupPlan> GroupPlans { get; set; }
        public virtual DbSet<group1> groups1 { get; set; }
        public virtual DbSet<Groups_payment> Groups_payment { get; set; }
        public virtual DbSet<GroupsByYear> GroupsByYears { get; set; }
        public virtual DbSet<hor> hors { get; set; }
        public virtual DbSet<hor_2> hor_2 { get; set; }
        public virtual DbSet<hor_os> hor_os { get; set; }
        public virtual DbSet<ind_ved_1> ind_ved_1 { get; set; }
        public virtual DbSet<ind_ved_2> ind_ved_2 { get; set; }
        public virtual DbSet<ind_ved_3> ind_ved_3 { get; set; }
        public virtual DbSet<ind_ved_4> ind_ved_4 { get; set; }
        public virtual DbSet<ind_ved_ar> ind_ved_ar { get; set; }
        public virtual DbSet<InfoForRating> InfoForRatings { get; set; }
        public virtual DbSet<InfoSchool> InfoSchools { get; set; }
        public virtual DbSet<JOB_mov_1> JOB_mov_1 { get; set; }
        public virtual DbSet<JOB_mov_2> JOB_mov_2 { get; set; }
        public virtual DbSet<k_st_gr_sem> k_st_gr_sem { get; set; }
        public virtual DbSet<kaf_dis> kaf_dis { get; set; }
        public virtual DbSet<kass> kasses { get; set; }
        public virtual DbSet<kass_1> kass_1 { get; set; }
        public virtual DbSet<kass_2> kass_2 { get; set; }
        public virtual DbSet<kass_ab> kass_ab { get; set; }
        public virtual DbSet<kass_e> kass_e { get; set; }
        public virtual DbSet<kass_opl_kred> kass_opl_kred { get; set; }
        public virtual DbSet<kass_opl_sem> kass_opl_sem { get; set; }
        public virtual DbSet<kass_p> kass_p { get; set; }
        public virtual DbSet<kass_pe> kass_pe { get; set; }
        public virtual DbSet<kass2> kass2 { get; set; }
        public virtual DbSet<kassa_ee> kassa_ee { get; set; }
        public virtual DbSet<kassa_opl_kredL> kassa_opl_kredL { get; set; }
        public virtual DbSet<kassa_p_ab> kassa_p_ab { get; set; }
        public virtual DbSet<kassa_pp> kassa_pp { get; set; }
        public virtual DbSet<kol_st_all_b_k> kol_st_all_b_k { get; set; }
        public virtual DbSet<kol_st_bk_j> kol_st_bk_j { get; set; }
        public virtual DbSet<kol_st_gr_all> kol_st_gr_all { get; set; }
        public virtual DbSet<kol_st_gr_all_b> kol_st_gr_all_b { get; set; }
        public virtual DbSet<kol_st_gr_all_b_KPV> kol_st_gr_all_b_KPV { get; set; }
        public virtual DbSet<kol_st_gr_all_KPV> kol_st_gr_all_KPV { get; set; }
        public virtual DbSet<kol_st_gr_b> kol_st_gr_b { get; set; }
        public virtual DbSet<kol_st_gr_bk> kol_st_gr_bk { get; set; }
        public virtual DbSet<kol_st_gr_k> kol_st_gr_k { get; set; }
        public virtual DbSet<kol_st_j> kol_st_j { get; set; }
        public virtual DbSet<kol_st_subgr> kol_st_subgr { get; set; }
        public virtual DbSet<kol_st_subgroup> kol_st_subgroup { get; set; }
        public virtual DbSet<komul_GPA> komul_GPA { get; set; }
        public virtual DbSet<kor_mov_1> kor_mov_1 { get; set; }
        public virtual DbSet<kor_mov_2> kor_mov_2 { get; set; }
        public virtual DbSet<KPV_Educ_sh_inf> KPV_Educ_sh_inf { get; set; }
        public virtual DbSet<l4> l4 { get; set; }
        public virtual DbSet<lms_gr_sem_disc_exam> lms_gr_sem_disc_exam { get; set; }
        public virtual DbSet<Lookup_S_FIO_Abit> Lookup_S_FIO_Abit { get; set; }
        public virtual DbSet<Lookup_S_FIO_Payment> Lookup_S_FIO_Payment { get; set; }
        public virtual DbSet<Lookup_S_FIO_Payment_old> Lookup_S_FIO_Payment_old { get; set; }
        public virtual DbSet<Lookup_S_FIO_slushatel> Lookup_S_FIO_slushatel { get; set; }
        public virtual DbSet<m1> m1 { get; set; }
        public virtual DbSet<mark_mag_est> mark_mag_est { get; set; }
        public virtual DbSet<mark_mag_maxest_arch> mark_mag_maxest_arch { get; set; }
        public virtual DbSet<mark_mag_u> mark_mag_u { get; set; }
        public virtual DbSet<mm_est> mm_est { get; set; }
        public virtual DbSet<mm_kor_1> mm_kor_1 { get; set; }
        public virtual DbSet<mm_kor_2> mm_kor_2 { get; set; }
        public virtual DbSet<mm_kor_3> mm_kor_3 { get; set; }
        public virtual DbSet<mm_kor_4> mm_kor_4 { get; set; }
        public virtual DbSet<mm_kor_5> mm_kor_5 { get; set; }
        public virtual DbSet<mm_user> mm_user { get; set; }
        public virtual DbSet<mmPayment> mmPayments { get; set; }
        public virtual DbSet<mov_e_sh> mov_e_sh { get; set; }
        public virtual DbSet<mov_mm_edsh> mov_mm_edsh { get; set; }
        public virtual DbSet<mov_ws> mov_ws { get; set; }
        public virtual DbSet<movement> movements { get; set; }
        public virtual DbSet<movement_spets> movement_spets { get; set; }
        public virtual DbSet<movement_t_b> movement_t_b { get; set; }
        public virtual DbSet<movement_t_k> movement_t_k { get; set; }
        public virtual DbSet<MovementView> MovementViews { get; set; }
        public virtual DbSet<Nagruzka_godovaya> Nagruzka_godovaya { get; set; }
        public virtual DbSet<name_and_surname_of_students> name_and_surname_of_students { get; set; }
        public virtual DbSet<nb> nbs { get; set; }
        public virtual DbSet<nb_os> nb_os { get; set; }
        public virtual DbSet<neud> neuds { get; set; }
        public virtual DbSet<neud_1> neud_1 { get; set; }
        public virtual DbSet<neud_1_os> neud_1_os { get; set; }
        public virtual DbSet<neud_2> neud_2 { get; set; }
        public virtual DbSet<neud_2_os> neud_2_os { get; set; }
        public virtual DbSet<neud_3> neud_3 { get; set; }
        public virtual DbSet<neud_3_os> neud_3_os { get; set; }
        public virtual DbSet<neud_ps> neud_ps { get; set; }
        public virtual DbSet<not_est> not_est { get; set; }
        public virtual DbSet<nr_a> nr_a { get; set; }
        public virtual DbSet<nr_a_lb> nr_a_lb { get; set; }
        public virtual DbSet<nr_a_pr> nr_a_pr { get; set; }
        public virtual DbSet<nr_ins_kol_st> nr_ins_kol_st { get; set; }
        public virtual DbSet<nr_ins_rrnkkrdt> nr_ins_rrnkkrdt { get; set; }
        public virtual DbSet<nr_ins_rrnkkrdt_lb> nr_ins_rrnkkrdt_lb { get; set; }
        public virtual DbSet<nr_ins_rrnkkrdt_pr> nr_ins_rrnkkrdt_pr { get; set; }
        public virtual DbSet<nr_kol_st> nr_kol_st { get; set; }
        public virtual DbSet<nr_UP> nr_UP { get; set; }
        public virtual DbSet<nr_UP_lb> nr_UP_lb { get; set; }
        public virtual DbSet<nr_UP_pr> nr_UP_pr { get; set; }
        public virtual DbSet<nu> nus { get; set; }
        public virtual DbSet<ok_f20_1> ok_f20_1 { get; set; }
        public virtual DbSet<ok_f20_2> ok_f20_2 { get; set; }
        public virtual DbSet<ok_f20_3> ok_f20_3 { get; set; }
        public virtual DbSet<ok_f20_4> ok_f20_4 { get; set; }
        public virtual DbSet<ok_f20_5> ok_f20_5 { get; set; }
        public virtual DbSet<ok_f20_6> ok_f20_6 { get; set; }
        public virtual DbSet<oks_c1> oks_c1 { get; set; }
        public virtual DbSet<oks_c2> oks_c2 { get; set; }
        public virtual DbSet<oks_c3> oks_c3 { get; set; }
        public virtual DbSet<oks_c4> oks_c4 { get; set; }
        public virtual DbSet<oks_c5> oks_c5 { get; set; }
        public virtual DbSet<oks_c6> oks_c6 { get; set; }
        public virtual DbSet<oks_c7> oks_c7 { get; set; }
        public virtual DbSet<oks_g_r> oks_g_r { get; set; }
        public virtual DbSet<oks_l2> oks_l2 { get; set; }
        public virtual DbSet<oks_l3> oks_l3 { get; set; }
        public virtual DbSet<oks_l4> oks_l4 { get; set; }
        public virtual DbSet<oks_l5> oks_l5 { get; set; }
        public virtual DbSet<oks_l6> oks_l6 { get; set; }
        public virtual DbSet<oks_l7> oks_l7 { get; set; }
        public virtual DbSet<oks_s_c1> oks_s_c1 { get; set; }
        public virtual DbSet<oks_s_c2> oks_s_c2 { get; set; }
        public virtual DbSet<oks_s_c3> oks_s_c3 { get; set; }
        public virtual DbSet<oks_s_c4> oks_s_c4 { get; set; }
        public virtual DbSet<oks_s_c5> oks_s_c5 { get; set; }
        public virtual DbSet<oks_s_c6> oks_s_c6 { get; set; }
        public virtual DbSet<oks_s_c7> oks_s_c7 { get; set; }
        public virtual DbSet<oks_s_j> oks_s_j { get; set; }
        public virtual DbSet<oks_s_l2> oks_s_l2 { get; set; }
        public virtual DbSet<oks_s_l3> oks_s_l3 { get; set; }
        public virtual DbSet<oks_s_l4> oks_s_l4 { get; set; }
        public virtual DbSet<oks_s_l5> oks_s_l5 { get; set; }
        public virtual DbSet<oks_s_l6> oks_s_l6 { get; set; }
        public virtual DbSet<oks_s_l7> oks_s_l7 { get; set; }
        public virtual DbSet<opl_diplom> opl_diplom { get; set; }
        public virtual DbSet<oplata_smeta> oplata_smeta { get; set; }
        public virtual DbSet<o> os { get; set; }
        public virtual DbSet<Otchis_s> Otchis_s { get; set; }
        public virtual DbSet<Otchis_s_2> Otchis_s_2 { get; set; }
        public virtual DbSet<otl> otls { get; set; }
        public virtual DbSet<otl_2> otl_2 { get; set; }
        public virtual DbSet<otl_os> otl_os { get; set; }
        public virtual DbSet<p1> p1 { get; set; }
        public virtual DbSet<p2> p2 { get; set; }
        public virtual DbSet<p3> p3 { get; set; }
        public virtual DbSet<pay> pays { get; set; }
        public virtual DbSet<pay_exp> pay_exp { get; set; }
        public virtual DbSet<pay_no_exp> pay_no_exp { get; set; }
        public virtual DbSet<pay_plus_exp> pay_plus_exp { get; set; }
        public virtual DbSet<pay_st> pay_st { get; set; }
        public virtual DbSet<pay_with_exp> pay_with_exp { get; set; }
        public virtual DbSet<pay_with_exp_leta> pay_with_exp_leta { get; set; }
        public virtual DbSet<Payment1V> Payment1V { get; set; }
        public virtual DbSet<Payment2V> Payment2V { get; set; }
        public virtual DbSet<Payment3V> Payment3V { get; set; }
        public virtual DbSet<PaymentForAbit> PaymentForAbits { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Plan_AbitV> Plan_AbitV { get; set; }
        public virtual DbSet<PlanAbitForAbiturient> PlanAbitForAbiturients { get; set; }
        public virtual DbSet<PlaseSertORT> PlaseSertORTs { get; set; }
        public virtual DbSet<plus_exp> plus_exp { get; set; }
        public virtual DbSet<plus_expen_no> plus_expen_no { get; set; }
        public virtual DbSet<plus_expen_rate> plus_expen_rate { get; set; }
        public virtual DbSet<prob4> prob4 { get; set; }
        public virtual DbSet<p> ps { get; set; }
        public virtual DbSet<p_s> p_s { get; set; }
        public virtual DbSet<p_s1> p_s1 { get; set; }
        public virtual DbSet<pvp> pvps { get; set; }
        public virtual DbSet<pvp_os> pvp_os { get; set; }
        public virtual DbSet<pvp_ps> pvp_ps { get; set; }
        public virtual DbSet<R_1> R_1 { get; set; }
        public virtual DbSet<R_2> R_2 { get; set; }
        public virtual DbSet<R_3> R_3 { get; set; }
        public virtual DbSet<R_4> R_4 { get; set; }
        public virtual DbSet<R_5> R_5 { get; set; }
        public virtual DbSet<r_chek_nagr> r_chek_nagr { get; set; }
        public virtual DbSet<r_krdt_kol_st> r_krdt_kol_st { get; set; }
        public virtual DbSet<r_nagr_all> r_nagr_all { get; set; }
        public virtual DbSet<r_nagr_krdt> r_nagr_krdt { get; set; }
        public virtual DbSet<r_nagr_rrnk> r_nagr_rrnk { get; set; }
        public virtual DbSet<r_sheduller> r_sheduller { get; set; }
        public virtual DbSet<r_UP_kaf> r_UP_kaf { get; set; }
        public virtual DbSet<rasp_1_a> rasp_1_a { get; set; }
        public virtual DbSet<rasp_1_b> rasp_1_b { get; set; }
        public virtual DbSet<rasp_2> rasp_2 { get; set; }
        public virtual DbSet<rasp_2_a> rasp_2_a { get; set; }
        public virtual DbSet<rasp_2_b> rasp_2_b { get; set; }
        public virtual DbSet<rasp_napravlenie> rasp_napravlenie { get; set; }
        public virtual DbSet<RASP_RRNKkrdt_and_RRNK> RASP_RRNKkrdt_and_RRNK { get; set; }
        public virtual DbSet<rasp_student_SH> rasp_student_SH { get; set; }
        public virtual DbSet<rasp_teacher> rasp_teacher { get; set; }
        public virtual DbSet<RatingView> RatingViews { get; set; }
        public virtual DbSet<read> reads { get; set; }
        public virtual DbSet<reit_2> reit_2 { get; set; }
        public virtual DbSet<Renuw_UC> Renuw_UC { get; set; }
        public virtual DbSet<Result_of_the_test> Result_of_the_test { get; set; }
        public virtual DbSet<RNK> RNKs { get; set; }
        public virtual DbSet<rr_a> rr_a { get; set; }
        public virtual DbSet<rr_a_bk> rr_a_bk { get; set; }
        public virtual DbSet<rr_a_k> rr_a_k { get; set; }
        public virtual DbSet<rr_a_rrnk> rr_a_rrnk { get; set; }
        public virtual DbSet<rr_b> rr_b { get; set; }
        public virtual DbSet<rr_c> rr_c { get; set; }
        public virtual DbSet<rr_c_b_RRNK> rr_c_b_RRNK { get; set; }
        public virtual DbSet<rr_d> rr_d { get; set; }
        public virtual DbSet<rr_k_a> rr_k_a { get; set; }
        public virtual DbSet<rr_k_b> rr_k_b { get; set; }
        public virtual DbSet<rr_k_c> rr_k_c { get; set; }
        public virtual DbSet<rr2_a> rr2_a { get; set; }
        public virtual DbSet<rr2_d> rr2_d { get; set; }
        public virtual DbSet<rr3_a> rr3_a { get; set; }
        public virtual DbSet<rr3_b> rr3_b { get; set; }
        public virtual DbSet<rr4_a> rr4_a { get; set; }
        public virtual DbSet<rr4_d> rr4_d { get; set; }
        public virtual DbSet<rr5_a> rr5_a { get; set; }
        public virtual DbSet<rr5_b> rr5_b { get; set; }
        public virtual DbSet<rr5_c> rr5_c { get; set; }
        public virtual DbSet<rr5_d> rr5_d { get; set; }
        public virtual DbSet<rr6_a> rr6_a { get; set; }
        public virtual DbSet<rrnk_1> rrnk_1 { get; set; }
        public virtual DbSet<rrnk_2> rrnk_2 { get; set; }
        public virtual DbSet<rrnk_a> rrnk_a { get; set; }
        public virtual DbSet<rrnk_a2> rrnk_a2 { get; set; }
        public virtual DbSet<rrnk_aa> rrnk_aa { get; set; }
        public virtual DbSet<rrnk_aaa> rrnk_aaa { get; set; }
        public virtual DbSet<rrnk_DiscForStud_KPV> rrnk_DiscForStud_KPV { get; set; }
        public virtual DbSet<rrnk_f_1> rrnk_f_1 { get; set; }
        public virtual DbSet<rrnk_f_1_1> rrnk_f_1_1 { get; set; }
        public virtual DbSet<rrnk_for_lk> rrnk_for_lk { get; set; }
        public virtual DbSet<rrnk_for_t> rrnk_for_t { get; set; }
        public virtual DbSet<rrnk_gr> rrnk_gr { get; set; }
        public virtual DbSet<rrnk_group_plan_stud> rrnk_group_plan_stud { get; set; }
        public virtual DbSet<rrnk_group_plan_stud_KPV> rrnk_group_plan_stud_KPV { get; set; }
        public virtual DbSet<rrnk_group_plan_stud1> rrnk_group_plan_stud1 { get; set; }
        public virtual DbSet<RRNKForIndividualPermiss> RRNKForIndividualPermisses { get; set; }
        public virtual DbSet<RRNKkrdt_proverka> RRNKkrdt_proverka { get; set; }
        public virtual DbSet<s_citizenship> s_citizenship { get; set; }
        public virtual DbSet<s_fio> s_fio { get; set; }
        public virtual DbSet<s_fio_birth> s_fio_birth { get; set; }
        public virtual DbSet<s_g_old> s_g_old { get; set; }
        public virtual DbSet<s_g_r> s_g_r { get; set; }
        public virtual DbSet<s_g_SYS> s_g_SYS { get; set; }
        public virtual DbSet<s_spets_y> s_spets_y { get; set; }
        public virtual DbSet<s_working> s_working { get; set; }
        public virtual DbSet<SCHDirectionList> SCHDirectionLists { get; set; }
        public virtual DbSet<SCHEducationFormList> SCHEducationFormLists { get; set; }
        public virtual DbSet<SCHEmployeeList> SCHEmployeeLists { get; set; }
        public virtual DbSet<SCHGroupByRateList> SCHGroupByRateLists { get; set; }
        public virtual DbSet<SCHGroupList> SCHGroupLists { get; set; }
        public virtual DbSet<SCHSchedule_discipline> SCHSchedule_discipline { get; set; }
        public virtual DbSet<SCHSchedule_discipline1> SCHSchedule_discipline1 { get; set; }
        public virtual DbSet<SCHScheduleList> SCHScheduleLists { get; set; }
        public virtual DbSet<SCHScheduleList_a> SCHScheduleList_a { get; set; }
        public virtual DbSet<SCHScheduleList_old> SCHScheduleList_old { get; set; }
        public virtual DbSet<SCHSpecialityList> SCHSpecialityLists { get; set; }
        public virtual DbSet<SCHStudyPlanList> SCHStudyPlanLists { get; set; }
        public virtual DbSet<SCHStudyPlanList_a> SCHStudyPlanList_a { get; set; }
        public virtual DbSet<SCHStudyPlanList_b> SCHStudyPlanList_b { get; set; }
        public virtual DbSet<SCHSubjectList> SCHSubjectLists { get; set; }
        public virtual DbSet<SelDesciplineForKPV> SelDesciplineForKPVs { get; set; }
        public virtual DbSet<SelIdvil> SelIdvils { get; set; }
        public virtual DbSet<sem_min> sem_min { get; set; }
        public virtual DbSet<sharp_temp_t1> sharp_temp_t1 { get; set; }
        public virtual DbSet<SingleTeacher> SingleTeachers { get; set; }
        public virtual DbSet<smeta_a> smeta_a { get; set; }
        public virtual DbSet<smeta_a_BudgetContract> smeta_a_BudgetContract { get; set; }
        public virtual DbSet<smeta_expen> smeta_expen { get; set; }
        public virtual DbSet<smeta_expense> smeta_expense { get; set; }
        public virtual DbSet<smeta_o> smeta_o { get; set; }
        public virtual DbSet<smeta_oplata> smeta_oplata { get; set; }
        public virtual DbSet<smeta_pay> smeta_pay { get; set; }
        public virtual DbSet<smeta_pay_exp> smeta_pay_exp { get; set; }
        public virtual DbSet<smeta_pay_expen> smeta_pay_expen { get; set; }
        public virtual DbSet<smeta_rate> smeta_rate { get; set; }
        public virtual DbSet<Smeta_spec> Smeta_spec { get; set; }
        public virtual DbSet<smeta_y> smeta_y { get; set; }
        public virtual DbSet<SMS_duty_discipline> SMS_duty_discipline { get; set; }
        public virtual DbSet<SMS_duty_pay> SMS_duty_pay { get; set; }
        public virtual DbSet<SMS_m1> SMS_m1 { get; set; }
        public virtual DbSet<SMS_m2> SMS_m2 { get; set; }
        public virtual DbSet<speciality_form> speciality_form { get; set; }
        public virtual DbSet<specialityRR> specialityRRs { get; set; }
        public virtual DbSet<specialityV> specialityVs { get; set; }
        public virtual DbSet<SRS_v_faculty> SRS_v_faculty { get; set; }
        public virtual DbSet<SRS_v_groups> SRS_v_groups { get; set; }
        public virtual DbSet<SRS_v_groups_student> SRS_v_groups_student { get; set; }
        public virtual DbSet<SRS_v_groups_students_prep> SRS_v_groups_students_prep { get; set; }
        public virtual DbSet<SRS_v_kaf_teacher> SRS_v_kaf_teacher { get; set; }
        public virtual DbSet<SRS_v_student> SRS_v_student { get; set; }
        public virtual DbSet<SRS_v_student_discipline> SRS_v_student_discipline { get; set; }
        public virtual DbSet<SRS_v_teacher> SRS_v_teacher { get; set; }
        public virtual DbSet<SRS_v_teachersDiscipline> SRS_v_teachersDiscipline { get; set; }
        public virtual DbSet<ST_23> ST_23 { get; set; }
        public virtual DbSet<st_bk_b_k> st_bk_b_k { get; set; }
        public virtual DbSet<st_gr> st_gr { get; set; }
        public virtual DbSet<st_sp_g> st_sp_g { get; set; }
        public virtual DbSet<st1> st1 { get; set; }
        public virtual DbSet<STKGTU> STKGTUs { get; set; }
        public virtual DbSet<Streamgroup> Streamgroups { get; set; }
        public virtual DbSet<Student_info_View> Student_info_View { get; set; }
        public virtual DbSet<Student_ItnGyrg> Student_ItnGyrg { get; set; }
        public virtual DbSet<student_live> student_live { get; set; }
        public virtual DbSet<Student_Po_id_Group> Student_Po_id_Group { get; set; }
        public virtual DbSet<Student_Propiska> Student_Propiska { get; set; }
        public virtual DbSet<StudentsGroup> StudentsGroups { get; set; }
        public virtual DbSet<sv_1> sv_1 { get; set; }
        public virtual DbSet<sv_2> sv_2 { get; set; }
        public virtual DbSet<sv_3> sv_3 { get; set; }
        public virtual DbSet<sv_a_NEW> sv_a_NEW { get; set; }
        public virtual DbSet<sv_a_old> sv_a_old { get; set; }
        public virtual DbSet<sv_a_u> sv_a_u { get; set; }
        public virtual DbSet<sv_aa> sv_aa { get; set; }
        public virtual DbSet<sv_ar> sv_ar { get; set; }
        public virtual DbSet<sv_b> sv_b { get; set; }
        public virtual DbSet<sv_bb> sv_bb { get; set; }
        public virtual DbSet<sv_c> sv_c { get; set; }
        public virtual DbSet<sv_d> sv_d { get; set; }
        public virtual DbSet<SV_proced1_temp_t1> SV_proced1_temp_t1 { get; set; }
        public virtual DbSet<sv2> sv2 { get; set; }
        public virtual DbSet<t> t { get; set; }
        public virtual DbSet<t_fio> t_fio { get; set; }
        public virtual DbSet<t_nag_sh_lb_update> t_nag_sh_lb_update { get; set; }
        public virtual DbSet<t_nag_sh_lk_RRNK_new_LB_potok> t_nag_sh_lk_RRNK_new_LB_potok { get; set; }
        public virtual DbSet<t_nag_sh_lk_RRNK_new_LK_potok> t_nag_sh_lk_RRNK_new_LK_potok { get; set; }
        public virtual DbSet<t_nag_sh_lk_RRNK_new_PR_potok> t_nag_sh_lk_RRNK_new_PR_potok { get; set; }
        public virtual DbSet<t_nag_sh_lk_update> t_nag_sh_lk_update { get; set; }
        public virtual DbSet<t_nag_sh_pr_update> t_nag_sh_pr_update { get; set; }
        public virtual DbSet<t_rrnk_a> t_rrnk_a { get; set; }
        public virtual DbSet<t_rrnkdop_a> t_rrnkdop_a { get; set; }
        public virtual DbSet<t_rrnkkrdt_a> t_rrnkkrdt_a { get; set; }
        public virtual DbSet<t_rrnkkrdt_aa> t_rrnkkrdt_aa { get; set; }
        public virtual DbSet<t_s_fio> t_s_fio { get; set; }
        public virtual DbSet<teemp> teemps { get; set; }
        public virtual DbSet<temp_13> temp_13 { get; set; }
        public virtual DbSet<temp_a> temp_a { get; set; }
        public virtual DbSet<temp_aannkk> temp_aannkk { get; set; }
        public virtual DbSet<TEMP_ABIT_ORT> TEMP_ABIT_ORT { get; set; }
        public virtual DbSet<temp_Ainura> temp_Ainura { get; set; }
        public virtual DbSet<temp_ALL> temp_ALL { get; set; }
        public virtual DbSet<Temp_ALL_est> Temp_ALL_est { get; set; }
        public virtual DbSet<temp_ALL_st> temp_ALL_st { get; set; }
        public virtual DbSet<temp_an2> temp_an2 { get; set; }
        public virtual DbSet<temp_ank> temp_ank { get; set; }
        public virtual DbSet<temp_ank_b> temp_ank_b { get; set; }
        public virtual DbSet<temp_ank_kol_st> temp_ank_kol_st { get; set; }
        public virtual DbSet<temp_ank_reg_st> temp_ank_reg_st { get; set; }
        public virtual DbSet<temp_ank_sdal> temp_ank_sdal { get; set; }
        public virtual DbSet<temp_arch_dubl_clean_del> temp_arch_dubl_clean_del { get; set; }
        public virtual DbSet<temp_b> temp_b { get; set; }
        public virtual DbSet<temp_b1> temp_b1 { get; set; }
        public virtual DbSet<temp_bektur> temp_bektur { get; set; }
        public virtual DbSet<temp_c> temp_c { get; set; }
        public virtual DbSet<temp_c_1> temp_c_1 { get; set; }
        public virtual DbSet<temp_copy_est_from_ebe> temp_copy_est_from_ebe { get; set; }
        public virtual DbSet<temp_copy_summ_for_ball> temp_copy_summ_for_ball { get; set; }
        public virtual DbSet<TEMP_COPYEST> TEMP_COPYEST { get; set; }
        public virtual DbSet<temp_d> temp_d { get; set; }
        public virtual DbSet<temp_del_date> temp_del_date { get; set; }
        public virtual DbSet<temp_del_paym> temp_del_paym { get; set; }
        public virtual DbSet<temp_dop_prim_1> temp_dop_prim_1 { get; set; }
        public virtual DbSet<temp_dop_prim_2> temp_dop_prim_2 { get; set; }
        public virtual DbSet<temp_ed_sh_kpv> temp_ed_sh_kpv { get; set; }
        public virtual DbSet<temp_EST_nagr_reg> temp_EST_nagr_reg { get; set; }
        public virtual DbSet<temp_field_studetnt> temp_field_studetnt { get; set; }
        public virtual DbSet<temp_FIKSIR> temp_FIKSIR { get; set; }
        public virtual DbSet<temp_for_rasp> temp_for_rasp { get; set; }
        public virtual DbSet<temp_GROUP_ED_SH> temp_GROUP_ED_SH { get; set; }
        public virtual DbSet<temp_kpv_educ_sh> temp_kpv_educ_sh { get; set; }
        public virtual DbSet<temp_log> temp_log { get; set; }
        public virtual DbSet<temp_log_upd> temp_log_upd { get; set; }
        public virtual DbSet<temp_log2> temp_log2 { get; set; }
        public virtual DbSet<temp_max_leave_sem> temp_max_leave_sem { get; set; }
        public virtual DbSet<TEMP_MINMAX_sem> TEMP_MINMAX_sem { get; set; }
        public virtual DbSet<temp_mm> temp_mm { get; set; }
        public virtual DbSet<temp_MM_dubl> temp_MM_dubl { get; set; }
        public virtual DbSet<temp_nagr_reg> temp_nagr_reg { get; set; }
        public virtual DbSet<temp_net_nagr_fix_O> temp_net_nagr_fix_O { get; set; }
        public virtual DbSet<temp_net_nagr_reg_O> temp_net_nagr_reg_O { get; set; }
        public virtual DbSet<temp_NEW_GROUP> temp_NEW_GROUP { get; set; }
        public virtual DbSet<temp_nur> temp_nur { get; set; }
        public virtual DbSet<temp_osenTK> temp_osenTK { get; set; }
        public virtual DbSet<temp_pay_error> temp_pay_error { get; set; }
        public virtual DbSet<temp_payment_rate_update> temp_payment_rate_update { get; set; }
        public virtual DbSet<temp_prob> temp_prob { get; set; }
        public virtual DbSet<temp_r_1> temp_r_1 { get; set; }
        public virtual DbSet<temp_r_2> temp_r_2 { get; set; }
        public virtual DbSet<temp_r_3> temp_r_3 { get; set; }
        public virtual DbSet<temp_r_4> temp_r_4 { get; set; }
        public virtual DbSet<temp_rasp> temp_rasp { get; set; }
        public virtual DbSet<Temp_rasp_error> Temp_rasp_error { get; set; }
        public virtual DbSet<temp_rasp2> temp_rasp2 { get; set; }
        public virtual DbSet<TEMP_SMETA> TEMP_SMETA { get; set; }
        public virtual DbSet<temp_SV_proced1> temp_SV_proced1 { get; set; }
        public virtual DbSet<temp_test> temp_test { get; set; }
        public virtual DbSet<temp_tr_BK> temp_tr_BK { get; set; }
        public virtual DbSet<temp_tr_EBE> temp_tr_EBE { get; set; }
        public virtual DbSet<temp_tr_F> temp_tr_F { get; set; }
        public virtual DbSet<temp_tr_Y> temp_tr_Y { get; set; }
        public virtual DbSet<temp_trnk> temp_trnk { get; set; }
        public virtual DbSet<TEMP_UC> TEMP_UC { get; set; }
        public virtual DbSet<temp_View_9> temp_View_9 { get; set; }
        public virtual DbSet<temp_vrem_kontingent_stud> temp_vrem_kontingent_stud { get; set; }
        public virtual DbSet<temp1> temp1 { get; set; }
        public virtual DbSet<temp2> temp2 { get; set; }
        public virtual DbSet<temp3> temp3 { get; set; }
        public virtual DbSet<temp4> temp4 { get; set; }
        public virtual DbSet<temp_arch_clean> temp_arch_clean { get; set; }
        public virtual DbSet<tempBK> tempBKs { get; set; }
        public virtual DbSet<tempDF> tempDFS { get; set; }
        public virtual DbSet<tempDFS_NOT_RRNK> tempDFS_NOT_RRNK { get; set; }
        public virtual DbSet<tempEBE> tempEBEs { get; set; }
        public virtual DbSet<tempEBEarch> tempEBEarches { get; set; }
        public virtual DbSet<tempF> tempFs { get; set; }
        public virtual DbSet<tempFarch> tempFarches { get; set; }
        public virtual DbSet<tempMM_NOT_EDSH_DFS> tempMM_NOT_EDSH_DFS { get; set; }
        public virtual DbSet<temppp> temppps { get; set; }
        public virtual DbSet<temppp_1> temppp_1 { get; set; }
        public virtual DbSet<tempq> tempqs { get; set; }
        public virtual DbSet<tempTRNK> tempTRNKs { get; set; }
        public virtual DbSet<tempttt> tempttts { get; set; }
        public virtual DbSet<tempY> tempies { get; set; }
        public virtual DbSet<tempYarch> tempYarches { get; set; }
        public virtual DbSet<test_DFS> test_DFS { get; set; }
        public virtual DbSet<trnk_kurs> trnk_kurs { get; set; }
        public virtual DbSet<trnk_rs_naz> trnk_rs_naz { get; set; }
        public virtual DbSet<ttt_del> ttt_del { get; set; }
        public virtual DbSet<uch_kart> uch_kart { get; set; }
        public virtual DbSet<uchk_d> uchk_d { get; set; }
        public virtual DbSet<uchk_d_kpv> uchk_d_kpv { get; set; }
        public virtual DbSet<uchk_ds> uchk_ds { get; set; }
        public virtual DbSet<uchk_s> uchk_s { get; set; }
        public virtual DbSet<ud> uds { get; set; }
        public virtual DbSet<ud_os> ud_os { get; set; }
        public virtual DbSet<V__EDUC_SH> V__EDUC_SH { get; set; }
        public virtual DbSet<V_abit_oplata> V_abit_oplata { get; set; }
        public virtual DbSet<V_admin_online_payment_canceled_check> V_admin_online_payment_canceled_check { get; set; }
        public virtual DbSet<V_ank> V_ank { get; set; }
        public virtual DbSet<V_ank_a> V_ank_a { get; set; }
        public virtual DbSet<V_ank_b> V_ank_b { get; set; }
        public virtual DbSet<V_ank_c> V_ank_c { get; set; }
        public virtual DbSet<V_ank_da_net> V_ank_da_net { get; set; }
        public virtual DbSet<V_ank_kol_num> V_ank_kol_num { get; set; }
        public virtual DbSet<V_anket_Respondent> V_anket_Respondent { get; set; }
        public virtual DbSet<V_anket_vsego_ank> V_anket_vsego_ank { get; set; }
        public virtual DbSet<V_anket_vsego_registrazi> V_anket_vsego_registrazi { get; set; }
        public virtual DbSet<V_anket_vsego_st_movment> V_anket_vsego_st_movment { get; set; }
        public virtual DbSet<V_anket_vsego_zdali_displ> V_anket_vsego_zdali_displ { get; set; }
        public virtual DbSet<V_anket1> V_anket1 { get; set; }
        public virtual DbSet<V_anketirovanie> V_anketirovanie { get; set; }
        public virtual DbSet<V_anketirovanie3> V_anketirovanie3 { get; set; }
        public virtual DbSet<v_Auditory> v_Auditory { get; set; }
        public virtual DbSet<V_citizenshYearKontraktGroup> V_citizenshYearKontraktGroup { get; set; }
        public virtual DbSet<V_Date_reg_DFS> V_Date_reg_DFS { get; set; }
        public virtual DbSet<V_EdocDocNatureName> V_EdocDocNatureName { get; set; }
        public virtual DbSet<V_Educ_sh> V_Educ_sh { get; set; }
        public virtual DbSet<V_educ_sh_del_RRNKkrdt> V_educ_sh_del_RRNKkrdt { get; set; }
        public virtual DbSet<V_Educ_sh_RRNK> V_Educ_sh_RRNK { get; set; }
        public virtual DbSet<V_edush> V_edush { get; set; }
        public virtual DbSet<V_FX_Full> V_FX_Full { get; set; }
        public virtual DbSet<V_FXByFaculty> V_FXByFaculty { get; set; }
        public virtual DbSet<V_FXDistinct> V_FXDistinct { get; set; }
        public virtual DbSet<V_FXDistinctByFaculty> V_FXDistinctByFaculty { get; set; }
        public virtual DbSet<v_groups> v_groups { get; set; }
        public virtual DbSet<V_IndividualModulPermissPotok_group_discipline> V_IndividualModulPermissPotok_group_discipline { get; set; }
        public virtual DbSet<V_Jurnal> V_Jurnal { get; set; }
        public virtual DbSet<V_Jurnal_chasi> V_Jurnal_chasi { get; set; }
        public virtual DbSet<V_Jurnal_dis> V_Jurnal_dis { get; set; }
        public virtual DbSet<V_Jurnal_visit> V_Jurnal_visit { get; set; }
        public virtual DbSet<V_Jurnal_visit_dis> V_Jurnal_visit_dis { get; set; }
        public virtual DbSet<V_Jurnal_visit_st> V_Jurnal_visit_st { get; set; }
        public virtual DbSet<v_kaf_teacher> v_kaf_teacher { get; set; }
        public virtual DbSet<V_KPV_Info> V_KPV_Info { get; set; }
        public virtual DbSet<V_KPV_Info_2> V_KPV_Info_2 { get; set; }
        public virtual DbSet<V_LMS_SMS_spets> V_LMS_SMS_spets { get; set; }
        public virtual DbSet<V_Login> V_Login { get; set; }
        public virtual DbSet<V_ManagerFacultyForStudents> V_ManagerFacultyForStudents { get; set; }
        public virtual DbSet<V_ManagerKafedraForTeachers> V_ManagerKafedraForTeachers { get; set; }
        public virtual DbSet<V_mark_mag_arch> V_mark_mag_arch { get; set; }
        public virtual DbSet<V_mark_mag_isprav1> V_mark_mag_isprav1 { get; set; }
        public virtual DbSet<V_MarkMag_user> V_MarkMag_user { get; set; }
        public virtual DbSet<V_MM_GPA> V_MM_GPA { get; set; }
        public virtual DbSet<V_MM_GPA_sem> V_MM_GPA_sem { get; set; }
        public virtual DbSet<V_mm_max> V_mm_max { get; set; }
        public virtual DbSet<V_mm_max_ekv> V_mm_max_ekv { get; set; }
        public virtual DbSet<V_mm_max_teacher> V_mm_max_teacher { get; set; }
        public virtual DbSet<V_Movement_MaxRate_OfGroup> V_Movement_MaxRate_OfGroup { get; set; }
        public virtual DbSet<V_Movement_MaxRate_Students> V_Movement_MaxRate_Students { get; set; }
        public virtual DbSet<V_Movement_MaxRate_StudentsOfGroup> V_Movement_MaxRate_StudentsOfGroup { get; set; }
        public virtual DbSet<V_MYFIND> V_MYFIND { get; set; }
        public virtual DbSet<V_NewEdoc_RS1> V_NewEdoc_RS1 { get; set; }
        public virtual DbSet<V_NewEdoc_RS2> V_NewEdoc_RS2 { get; set; }
        public virtual DbSet<V_oplana_st> V_oplana_st { get; set; }
        public virtual DbSet<v_payment> v_payment { get; set; }
        public virtual DbSet<V_PaymentTransferVirtual> V_PaymentTransferVirtual { get; set; }
        public virtual DbSet<V_podrazd_RSlib> V_podrazd_RSlib { get; set; }
        public virtual DbSet<V_Raspisanie_new> V_Raspisanie_new { get; set; }
        public virtual DbSet<V_RASPISANIE_STUD> V_RASPISANIE_STUD { get; set; }
        public virtual DbSet<V_RASPISANIE_typeRrnk0> V_RASPISANIE_typeRrnk0 { get; set; }
        public virtual DbSet<V_RRNK_MARK_MAG> V_RRNK_MARK_MAG { get; set; }
        public virtual DbSet<V_RRNK_plan> V_RRNK_plan { get; set; }
        public virtual DbSet<V_RRNKCrdt_MARK_MAG> V_RRNKCrdt_MARK_MAG { get; set; }
        public virtual DbSet<V_RRNKkrdt> V_RRNKkrdt { get; set; }
        public virtual DbSet<V_RRNKkrdt_disipline> V_RRNKkrdt_disipline { get; set; }
        public virtual DbSet<V_RrrnkTeacherFaculties> V_RrrnkTeacherFaculties { get; set; }
        public virtual DbSet<V_SCHSchedule_discp_pasp> V_SCHSchedule_discp_pasp { get; set; }
        public virtual DbSet<V_SCHShedule_Error_aud> V_SCHShedule_Error_aud { get; set; }
        public virtual DbSet<V_SG_Citizenship_fakylty> V_SG_Citizenship_fakylty { get; set; }
        public virtual DbSet<V_smeta_spec> V_smeta_spec { get; set; }
        public virtual DbSet<V_SmetaForGroup> V_SmetaForGroup { get; set; }
        public virtual DbSet<V_special_rate> V_special_rate { get; set; }
        public virtual DbSet<v_StreamGroup> v_StreamGroup { get; set; }
        public virtual DbSet<v_teachersDiscipline> v_teachersDiscipline { get; set; }
        public virtual DbSet<v_teachersFIO> v_teachersFIO { get; set; }
        public virtual DbSet<V_Test_samoozenka> V_Test_samoozenka { get; set; }
        public virtual DbSet<V_time> V_time { get; set; }
        public virtual DbSet<V_UMK_spets> V_UMK_spets { get; set; }
        public virtual DbSet<V_UserInfo> V_UserInfo { get; set; }
        public virtual DbSet<V1> V1 { get; set; }
        public virtual DbSet<V2> V2 { get; set; }
        public virtual DbSet<VarEstimationInfo> VarEstimationInfoes { get; set; }
        public virtual DbSet<ved_pps_a> ved_pps_a { get; set; }
        public virtual DbSet<View_1> View_1 { get; set; }
        public virtual DbSet<View_2> View_2 { get; set; }
        public virtual DbSet<View_3> View_3 { get; set; }
        public virtual DbSet<View_4> View_4 { get; set; }
        public virtual DbSet<View_5> View_5 { get; set; }
        public virtual DbSet<View_6> View_6 { get; set; }
        public virtual DbSet<View_7> View_7 { get; set; }
        public virtual DbSet<View_8> View_8 { get; set; }
        public virtual DbSet<View_9> View_9 { get; set; }
        public virtual DbSet<vipuskniki> vipusknikis { get; set; }
        public virtual DbSet<visyat1> visyat1 { get; set; }
        public virtual DbSet<visyat2> visyat2 { get; set; }
        public virtual DbSet<vit_1> vit_1 { get; set; }
        public virtual DbSet<vit_2> vit_2 { get; set; }
        public virtual DbSet<vit_3> vit_3 { get; set; }
        public virtual DbSet<VKafedraForKPV> VKafedraForKPVs { get; set; }
        public virtual DbSet<VOSTON_BA> VOSTON_BA { get; set; }
        public virtual DbSet<Vostonov_s> Vostonov_s { get; set; }
        public virtual DbSet<VSelForKPV> VSelForKPVs { get; set; }
        public virtual DbSet<VV_Questionnaires> VV_Questionnaires { get; set; }
        public virtual DbSet<VV_RespondentAnsvers> VV_RespondentAnsvers { get; set; }
        public virtual DbSet<VV_Respondents> VV_Respondents { get; set; }
        public virtual DbSet<ws_sem> ws_sem { get; set; }
        public virtual DbSet<www> wwws { get; set; }
        public virtual DbSet<www_books> www_books { get; set; }
        public virtual DbSet<www_dv> www_dv { get; set; }
        public virtual DbSet<www1> www1 { get; set; }
        public virtual DbSet<Z_ab_infoOnEdIns> Z_ab_infoOnEdIns { get; set; }
        public virtual DbSet<Z_AKADEM> Z_AKADEM { get; set; }
        public virtual DbSet<Z_DEL_Faculty_NULL> Z_DEL_Faculty_NULL { get; set; }
        public virtual DbSet<Z_Faculty_Null> Z_Faculty_Null { get; set; }
        public virtual DbSet<Z_LMS_SMS_KR> Z_LMS_SMS_KR { get; set; }
        public virtual DbSet<Z_mm_gr_st> Z_mm_gr_st { get; set; }
        public virtual DbSet<Z_mm_with_arch> Z_mm_with_arch { get; set; }
        public virtual DbSet<Z_nauka1> Z_nauka1 { get; set; }
        public virtual DbSet<Z_rasp_DFS> Z_rasp_DFS { get; set; }
        public virtual DbSet<Z_rasp_matrix> Z_rasp_matrix { get; set; }
        public virtual DbSet<Z_rasp_obyas> Z_rasp_obyas { get; set; }
        public virtual DbSet<Z_rasp_obyas_a> Z_rasp_obyas_a { get; set; }
        public virtual DbSet<Z_rasp_obyas_a_kaf> Z_rasp_obyas_a_kaf { get; set; }
        public virtual DbSet<Z_rasp_obyas_a_RRNKkrdt> Z_rasp_obyas_a_RRNKkrdt { get; set; }
        public virtual DbSet<Z_rasp_y> Z_rasp_y { get; set; }
        public virtual DbSet<Z_rasp_yacheika> Z_rasp_yacheika { get; set; }
        public virtual DbSet<Z_rasp_yacheika_1> Z_rasp_yacheika_1 { get; set; }
        public virtual DbSet<Z_rasp_yacheika_a> Z_rasp_yacheika_a { get; set; }
        public virtual DbSet<Z_rasp_yacheika_a_new> Z_rasp_yacheika_a_new { get; set; }
        public virtual DbSet<Z_rasp_yacheika2> Z_rasp_yacheika2 { get; set; }
        public virtual DbSet<Z_ReceptInfo> Z_ReceptInfo { get; set; }
        public virtual DbSet<Z_SHEDULER> Z_SHEDULER { get; set; }
        public virtual DbSet<Z_SHEDULER_new> Z_SHEDULER_new { get; set; }
        public virtual DbSet<Z_Sheduler_RRNKkrdt_y_rasp> Z_Sheduler_RRNKkrdt_y_rasp { get; set; }
        public virtual DbSet<Z_SHEDULER_TEACHER> Z_SHEDULER_TEACHER { get; set; }
        public virtual DbSet<Z_SV_F83_dis> Z_SV_F83_dis { get; set; }
        public virtual DbSet<Z_SV_F83_ots> Z_SV_F83_ots { get; set; }
        public virtual DbSet<Z_SV_F83_stud> Z_SV_F83_stud { get; set; }
        public virtual DbSet<Z_SV1> Z_SV1 { get; set; }
        public virtual DbSet<Z_SV1_NEW_OLD> Z_SV1_NEW_OLD { get; set; }
        public virtual DbSet<Z_SV1_OLD> Z_SV1_OLD { get; set; }
        public virtual DbSet<Z_transcriptA> Z_transcriptA { get; set; }
        public virtual DbSet<Z_transcriptA___BK> Z_transcriptA___BK { get; set; }
        public virtual DbSet<Z_uchpl_NEW_gr> Z_uchpl_NEW_gr { get; set; }
        public virtual DbSet<Z_USPEV> Z_USPEV { get; set; }
        public virtual DbSet<Z_USPEV_a> Z_USPEV_a { get; set; }
        public virtual DbSet<Z_USPEV_a_isstatFalse> Z_USPEV_a_isstatFalse { get; set; }
        public virtual DbSet<Z_USPEV_a_isstatTrue> Z_USPEV_a_isstatTrue { get; set; }
        public virtual DbSet<Z_USPEV_b> Z_USPEV_b { get; set; }
        public virtual DbSet<Z_USPEV_b_edsh> Z_USPEV_b_edsh { get; set; }
        public virtual DbSet<Z_USPEV_b_edsh_st> Z_USPEV_b_edsh_st { get; set; }
        public virtual DbSet<Z_USPEV_b_registr> Z_USPEV_b_registr { get; set; }
        public virtual DbSet<Z_USPEV_b_registr_st> Z_USPEV_b_registr_st { get; set; }
        public virtual DbSet<Z_USPEV_b_static> Z_USPEV_b_static { get; set; }
        public virtual DbSet<Z_USPEV_b_static_st> Z_USPEV_b_static_st { get; set; }
        public virtual DbSet<Z_USPEV_c> Z_USPEV_c { get; set; }
        public virtual DbSet<Z_USPEV_c_False> Z_USPEV_c_False { get; set; }
        public virtual DbSet<Z_USPEV_GE> Z_USPEV_GE { get; set; }
        public virtual DbSet<Z_USPEV_GE_oldd> Z_USPEV_GE_oldd { get; set; }
        public virtual DbSet<Z_USPEV_OLD> Z_USPEV_OLD { get; set; }
        public virtual DbSet<Z_USPEV_UC_A> Z_USPEV_UC_A { get; set; }
        public virtual DbSet<Z_USPEV_UC_B> Z_USPEV_UC_B { get; set; }
        public virtual DbSet<zanyat> zanyats { get; set; }
        public virtual DbSet<Zoomo_VIEW> Zoomo_VIEW { get; set; }
        public virtual DbSet<ZS_REG> ZS_REG { get; set; }
        public virtual DbSet<ZS_stud_ws> ZS_stud_ws { get; set; }
        public virtual DbSet<ZS_SV1> ZS_SV1 { get; set; }

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
                .HasMany(e => e.smetas)
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

            modelBuilder.Entity<Auditorium>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<Auditorium>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<Auditorium>()
                .HasMany(e => e.SCHDayOffAuditories)
                .WithRequired(e => e.Auditorium)
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
                .HasMany(e => e.Works)
                .WithOptional(e => e._base)
                .HasForeignKey(e => e.id_type_job);

            modelBuilder.Entity<_base>()
                .HasMany(e => e.Workings)
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
                .HasMany(e => e.smetas)
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
                .HasMany(e => e.Citizenships)
                .WithRequired(e => e.country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<deduce>()
                .Property(e => e.deduce1)
                .IsUnicode(false);

            modelBuilder.Entity<deduce>()
                .HasMany(e => e.Vakansiis)
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
                .HasMany(e => e.Bronyas)
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
                .HasMany(e => e.SemestrShcedules)
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

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
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
                .HasMany(e => e.Vakansiis)
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
                .HasMany(e => e.ees)
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
                .HasMany(e => e.ees)
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
                .HasMany(e => e.directions)
                .WithOptional(e => e.kafedra)
                .WillCascadeOnDelete();

            modelBuilder.Entity<kafedra>()
                .HasMany(e => e.educ_sh)
                .WithRequired(e => e.kafedra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<kafLogin>()
                .HasMany(e => e.KafSecurities)
                .WithOptional(e => e.kafLogin)
                .HasForeignKey(e => e.id_kafLogin)
                .WillCascadeOnDelete();

            modelBuilder.Entity<korpu>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<korpu>()
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

            modelBuilder.Entity<language1>()
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
                .HasMany(e => e.MobileContactBacks)
                .WithRequired(e => e.MobileProblem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MobileRaport>()
                .HasMany(e => e.MobileRaportDetails)
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
                .HasMany(e => e.passports)
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
                .HasMany(e => e.Vakansiis)
                .WithOptional(e => e.Otdel_1)
                .HasForeignKey(e => e.id_otdel_1);

            modelBuilder.Entity<Otdel_1>()
                .HasMany(e => e.Vakansiis1)
                .WithOptional(e => e.Otdel_11)
                .HasForeignKey(e => e.id_otdel_11);

            modelBuilder.Entity<Otdel_1>()
                .HasMany(e => e.Vakansiis2)
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

            modelBuilder.Entity<Pensioner>()
                .Property(e => e.AVN_user)
                .IsFixedLength();

            modelBuilder.Entity<Pensioner>()
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
                .HasMany(e => e.Vakansiis)
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
                .HasMany(e => e.Workings)
                .WithRequired(e => e.Prikaz_come)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prikaz_leave>()
                .Property(e => e.prikaz_leave1)
                .IsUnicode(false);

            modelBuilder.Entity<Prikaz_leave>()
                .HasMany(e => e.Workings)
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
                .HasMany(e => e.semesters)
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
                .HasMany(e => e.SCHSchedules)
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

            modelBuilder.Entity<Specific>()
                .Property(e => e.specifics)
                .IsUnicode(false);

            modelBuilder.Entity<Specific>()
                .Property(e => e.short_specifics)
                .IsFixedLength();

            modelBuilder.Entity<Specific>()
                .HasMany(e => e.Auditoriums)
                .WithOptional(e => e.Specific1)
                .HasForeignKey(e => e.specific);

            modelBuilder.Entity<StandardOfEducation>()
                .Property(e => e.NameLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Stavka>()
                .HasMany(e => e.Workings)
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
                .HasMany(e => e.Vakansiis)
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
                .HasMany(e => e.Abroads)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Bronyas)
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
                .HasMany(e => e.Experiences)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Holidays)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.kv_job)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Kvalifikations)
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
                .HasMany(e => e.nagradas)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Partiyas)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Photos)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.SemestrShcedules)
                .WithOptional(e => e.teacher)
                .HasForeignKey(e => e.kod_prepod);

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Works)
                .WithOptional(e => e.teacher)
                .WillCascadeOnDelete();

            modelBuilder.Entity<teacher>()
                .HasMany(e => e.Workings)
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
                .HasMany(e => e.CallEducationInsts)
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
                .HasMany(e => e.Workings)
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
                .HasMany(e => e.faculties)
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
                .HasMany(e => e.semesters)
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

            modelBuilder.Entity<InfoOnEdIn>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIn>()
                .Property(e => e.YearTerminations)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIn>()
                .Property(e => e.SeriesAD)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOnEdIn>()
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

            modelBuilder.Entity<C11>()
                .Property(e => e.s_p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<C11>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<C1111111111>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.p19)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.p6_1)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.p6_2)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.p6_3)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.p9)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.k1)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.k2)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.k3)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.k4)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.regReg)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.regDist)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.regCity)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.regVil)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.Streetbirth)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.regnow)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.distnow)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.citynow)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.vilnow)
                .IsUnicode(false);

            modelBuilder.Entity<a1_1>()
                .Property(e => e.strnow)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoSchool>()
                .Property(e => e.NameCity)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoSchool>()
                .Property(e => e.NameDistrict)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoSchool>()
                .Property(e => e.NameRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoSchool>()
                .Property(e => e.NameVillage)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoSchool>()
                .Property(e => e.CallEducat)
                .IsUnicode(false);

            modelBuilder.Entity<Ab_InfoSchool>()
                .Property(e => e.NameEdInst)
                .IsUnicode(false);

            modelBuilder.Entity<abit_1>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<abit_1>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.fakult)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.bk_name)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.Recom_protokol)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.number_zachisl)
                .IsUnicode(false);

            modelBuilder.Entity<ABIT_PROVERKA>()
                .Property(e => e.n_category)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.bk_name)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.fakult)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.Recom_protokol)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.number_zachisl)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_ranj_lgotnik>()
                .Property(e => e.n_category)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg_kontr>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg_kontr>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg_kontr>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg_kontr>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg_kontr>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg2>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg2>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg2>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_svod_kateg2>()
                .Property(e => e.n_category)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_direction>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_direction>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_direction>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_plan>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_plan>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_plan>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<abit_temp_plan>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_test_view>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_test_view>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_test_view>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_test_view>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_web>()
                .Property(e => e.bk_name)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_web>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_web>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<Abit_web>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.bk_name)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.fakult)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.Recom_protokol)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.number_zachisl)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.n_category)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.bk_name)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.fakult)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.Recom_protokol)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_podtver>()
                .Property(e => e.number_zachisl)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.bk_name)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.fakult)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.Recom_protokol)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<AbitRecom_zachisl>()
                .Property(e => e.number_zachisl)
                .IsUnicode(false);

            modelBuilder.Entity<Admin_good_onlinepayment>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<Admin_good_onlinepayment>()
                .Property(e => e.txn_id)
                .IsUnicode(false);

            modelBuilder.Entity<Admin_good_onlinepayment>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<Admin_KyrgazstanBank_Unhandled_List>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<ank_fak>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<ank_fak>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<ank_fak>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<ank_fak_gr_st>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Ankenirovanie_RS_tfio_R>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<Ankenirovanie_RS_tfio_R>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Ankentirovanie4>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Anketirovanie_MM>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Anketirovanie_MM>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.b1)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.b2)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B3)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B4)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B5)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B6)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B7)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B10)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B11)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B12)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B13)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B8)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RA_Full>()
                .Property(e => e.B9)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.b1)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.b2)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B3)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B4)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B5)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B6)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B7)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B8)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B9)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B10)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B11)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B12)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.B13)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.sum)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Anketirovanie_RS>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v1)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v2)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v3)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v4)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v5)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v6)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v7)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v8)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v9)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v10)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v11)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v12)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.v13)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Antekirovanie_RS_kafedra>()
                .Property(e => e.s_sum)
                .HasPrecision(38, 6);

            modelBuilder.Entity<AVN_User_Deleted>()
                .Property(e => e.Old_password)
                .IsUnicode(false);

            modelBuilder.Entity<AVN_User_Visible>()
                .Property(e => e.Old_password)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_3>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_3>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_4>()
                .Property(e => e.detal)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_4>()
                .Property(e => e.oldValue)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_4>()
                .Property(e => e.newValue)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_4>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_4>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_4>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_B_3>()
                .Property(e => e.detal)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_B_3>()
                .Property(e => e.oldValue)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_B_3>()
                .Property(e => e.newValue)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_B_3>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_B_3>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<AVNLOG_B_3>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<AVNtest_1>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<AVNtest_2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<AVNtest_4>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<AVNtest_4>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<AVNtest_4>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<AVNtest_4>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<AZ_DOPUSK>()
                .Property(e => e.dopusk)
                .IsUnicode(false);

            modelBuilder.Entity<AZ_sum_KREDIT>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<AZ_sum_KREDIT>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<AZ_sum_KREDIT>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<bank_akt_sverka3>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<bank_payment_5>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<bf_1_0>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<bf_1_2>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<bf_1_2_old>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<bf_1_2l>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<bf_1_3>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<BriefDisciplineInfo>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ch1>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<ch1>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<ch1>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.nowReg)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.nowDist)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.homeReg)
                .IsUnicode(false);

            modelBuilder.Entity<ch2>()
                .Property(e => e.homeDist)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.nowReg)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.nowDist)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.homeReg)
                .IsUnicode(false);

            modelBuilder.Entity<ch3>()
                .Property(e => e.homeDist)
                .IsUnicode(false);

            modelBuilder.Entity<con_user>()
                .Property(e => e.db_user)
                .IsFixedLength();

            modelBuilder.Entity<ControlRating_aud>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<ControlRating_disc>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<D_gr>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Dipl_gr>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<ed_sh_gr>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<ed_sh_gr>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ed_sh_gr>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ed_sh_gr>()
                .Property(e => e.p26)
                .IsUnicode(false);

            modelBuilder.Entity<ed_sh_gr>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ed_sh_gr>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<f_4b>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f_4b>()
                .Property(e => e.p30_1)
                .IsUnicode(false);

            modelBuilder.Entity<f_AVN28_sem>()
                .Property(e => e.sem)
                .IsUnicode(false);

            modelBuilder.Entity<f_AVN28_sem_base>()
                .Property(e => e.sem)
                .IsUnicode(false);

            modelBuilder.Entity<F_FIO>()
                .Property(e => e.F_FIO1)
                .IsUnicode(false);

            modelBuilder.Entity<F_lms_Semesters>()
                .Property(e => e.sem)
                .IsUnicode(false);

            modelBuilder.Entity<F_lms_Years>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<f1_4>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f1_4>()
                .Property(e => e.p30_1)
                .IsUnicode(false);

            modelBuilder.Entity<f1_4a>()
                .Property(e => e.p30_1)
                .IsUnicode(false);

            modelBuilder.Entity<f1_4sel>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f10_1>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f10_5>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f28_years>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<f3_1>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<f3_1>()
                .Property(e => e.p25_1)
                .IsUnicode(false);

            modelBuilder.Entity<f3_1>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_b8>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_b8>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_b8>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_d6>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_d6>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_d6>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_d68>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_d68>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_d68>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_dolg>()
                .Property(e => e.g_st)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_dva>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_dva>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_dva>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_odin>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_odin>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_odin>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_st>()
                .Property(e => e.g_st)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_tri>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_tri>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<f8_3_tri>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<f9_2_1>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<f9_2_1>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<f9_2_1>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<f9_2_1>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty_V>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<fio_st>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<fio_st>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<fio_st>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<fio_st>()
                .Property(e => e.fio_st1)
                .IsUnicode(false);

            modelBuilder.Entity<for_test>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<for_test>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<for_test>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<for_test>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_all>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_all>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_all>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_povtor>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_povtor>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_povtor>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<for_test_povtor>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ForElectrVedomost>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ForElectrVedomost>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ForElectrVedomost>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<ForElectrVedomost>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<g_r>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<g_r_y>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<g_s>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<g_s>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<g_sem>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<gr_sem_disc_exam>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<gr_sem_disc_exam_bk>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<gr_sem_disc_exam1>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<gr_year_spec_oz_fac>()
                .Property(e => e.id_sub_group)
                .IsUnicode(false);

            modelBuilder.Entity<group>()
                .Property(e => e.id_sub_group)
                .IsUnicode(false);

            modelBuilder.Entity<group_form>()
                .Property(e => e.p21)
                .IsUnicode(false);

            modelBuilder.Entity<group_form>()
                .Property(e => e.id_sub_group)
                .IsUnicode(false);

            modelBuilder.Entity<group_reports>()
                .Property(e => e.id_sub_group)
                .IsUnicode(false);

            modelBuilder.Entity<GroupPlan>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<GroupPlan>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<group1>()
                .Property(e => e.id_sub_group)
                .IsUnicode(false);

            modelBuilder.Entity<Groups_payment>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_1>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_1>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_1>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_1>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_1>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_1>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.v_zanyatii)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_2>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_3>()
                .Property(e => e.v_zanyatii)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_4>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_ar>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_ar>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_ar>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_ar>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_ar>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<ind_ved_ar>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InfoForRating>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<InfoForRating>()
                .Property(e => e.Semester)
                .IsUnicode(false);

            modelBuilder.Entity<InfoForRating>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<InfoForRating>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<InfoForRating>()
                .Property(e => e.v1)
                .IsUnicode(false);

            modelBuilder.Entity<InfoSchool>()
                .Property(e => e.NameCity)
                .IsUnicode(false);

            modelBuilder.Entity<InfoSchool>()
                .Property(e => e.NameDistrict)
                .IsUnicode(false);

            modelBuilder.Entity<InfoSchool>()
                .Property(e => e.NameRegion)
                .IsUnicode(false);

            modelBuilder.Entity<InfoSchool>()
                .Property(e => e.NameVillage)
                .IsUnicode(false);

            modelBuilder.Entity<InfoSchool>()
                .Property(e => e.CallEducat)
                .IsUnicode(false);

            modelBuilder.Entity<InfoSchool>()
                .Property(e => e.NameEdInst)
                .IsUnicode(false);

            modelBuilder.Entity<kass>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass>()
                .Property(e => e.sl_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_1>()
                .Property(e => e.name_shet)
                .IsUnicode(false);

            modelBuilder.Entity<kass_1>()
                .Property(e => e.shet)
                .IsUnicode(false);

            modelBuilder.Entity<kass_1>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass_1>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass_2>()
                .Property(e => e.name_shet)
                .IsUnicode(false);

            modelBuilder.Entity<kass_2>()
                .Property(e => e.shet)
                .IsUnicode(false);

            modelBuilder.Entity<kass_2>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass_2>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass_ab>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass_ab>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_ab>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass_e>()
                .Property(e => e.e_uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass_e>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_e>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_e>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass_e>()
                .Property(e => e.sl_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_p>()
                .Property(e => e.p_uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass_p>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_p>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_p>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass_p>()
                .Property(e => e.sl_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_pe>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kass_pe>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_pe>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kass_pe>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass2>()
                .Property(e => e.name_shet)
                .IsUnicode(false);

            modelBuilder.Entity<kass2>()
                .Property(e => e.shet)
                .IsUnicode(false);

            modelBuilder.Entity<kass2>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kass2>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_ee>()
                .Property(e => e.e_uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_ee>()
                .Property(e => e.ab_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_ee>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_ee>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_ee>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_p_ab>()
                .Property(e => e.p_uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_p_ab>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_p_ab>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_pp>()
                .Property(e => e.p_uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_pp>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_pp>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<kassa_pp>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<kor_mov_2>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<lms_gr_sem_disc_exam>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Abit>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment>()
                .Property(e => e.s)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment>()
                .Property(e => e.first_p1)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment_old>()
                .Property(e => e.s)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment_old>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment_old>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_Payment_old>()
                .Property(e => e.first_p1)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_slushatel>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup_S_FIO_slushatel>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<m1>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_est>()
                .Property(e => e.tableName)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_est>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_est>()
                .Property(e => e.oldValue)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_est>()
                .Property(e => e.newValue)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_est>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_maxest_arch>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_maxest_arch>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_u>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<mark_mag_u>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<mm_kor_2>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<mm_kor_2>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<mm_kor_2>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<mm_kor_2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<mm_kor_2>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<mmPayment>()
                .Property(e => e.dopusk)
                .IsUnicode(false);

            modelBuilder.Entity<movement>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<movement>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_spets>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_spets>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_spets>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_spets>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_b>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_b>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_b>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_b>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_b>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_k>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_k>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_k>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_k>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<movement_t_k>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.come)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.leave)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<MovementView>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Nagruzka_godovaya>()
                .Property(e => e.id_n)
                .IsUnicode(false);

            modelBuilder.Entity<Nagruzka_godovaya>()
                .Property(e => e.potok)
                .IsUnicode(false);

            modelBuilder.Entity<name_and_surname_of_students>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<name_and_surname_of_students>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<ok_f20_1>()
                .Property(e => e.structure)
                .IsFixedLength();

            modelBuilder.Entity<ok_f20_2>()
                .Property(e => e.structure)
                .IsFixedLength();

            modelBuilder.Entity<ok_f20_3>()
                .Property(e => e.structure)
                .IsFixedLength();

            modelBuilder.Entity<ok_f20_3>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ok_f20_4>()
                .Property(e => e.structure)
                .IsFixedLength();

            modelBuilder.Entity<ok_f20_5>()
                .Property(e => e.structure)
                .IsFixedLength();

            modelBuilder.Entity<ok_f20_6>()
                .Property(e => e.structure)
                .IsFixedLength();

            modelBuilder.Entity<oks_s_c1>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_c2>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_c3>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_c4>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_c5>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_c6>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_c7>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_l2>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_l3>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_l4>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_l5>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_l6>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oks_s_l7>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<oplata_smeta>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<oplata_smeta>()
                .Property(e => e.p105)
                .IsUnicode(false);

            modelBuilder.Entity<oplata_smeta>()
                .Property(e => e.p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<Payment1V>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<Payment1V>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Payment1V>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<Payment1V>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Payment2V>()
                .Property(e => e.p105)
                .IsUnicode(false);

            modelBuilder.Entity<Payment2V>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Payment2V>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Payment2V>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<Payment2V>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<Payment3V>()
                .Property(e => e.p105)
                .IsUnicode(false);

            modelBuilder.Entity<Payment3V>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Payment3V>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Payment3V>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentForAbit>()
                .Property(e => e.uslugi)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentForAbit>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<Plan_AbitV>()
                .Property(e => e.NameQualification)
                .IsUnicode(false);

            modelBuilder.Entity<Plan_AbitV>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<PlanAbitForAbiturient>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSertORT>()
                .Property(e => e.NamePlase)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSertORT>()
                .Property(e => e.ColorSert)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSertORT>()
                .Property(e => e.dop_place)
                .IsUnicode(false);

            modelBuilder.Entity<PlaseSertORT>()
                .Property(e => e.ColorAndPlace)
                .IsUnicode(false);

            modelBuilder.Entity<prob4>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<prob4>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<prob4>()
                .Property(e => e.p105)
                .IsUnicode(false);

            modelBuilder.Entity<p_s>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<p_s>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<p_s>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<p_s>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<p_s1>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<p_s1>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<p_s1>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<p_s1>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<R_2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<r_chek_nagr>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<r_chek_nagr>()
                .Property(e => e.s_p34)
                .IsUnicode(false);

            modelBuilder.Entity<r_chek_nagr>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<r_chek_nagr>()
                .Property(e => e.potok)
                .IsUnicode(false);

            modelBuilder.Entity<r_chek_nagr>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<r_nagr_all>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<r_nagr_krdt>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<r_nagr_rrnk>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<r_sheduller>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<r_UP_kaf>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_a>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_a>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_a>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_b>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_b>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_b>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_b>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_1_b>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.auditoria)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.auditoria)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_a>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.auditoria)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_2_b>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_napravlenie>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_napravlenie>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_napravlenie>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_napravlenie>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_student_SH>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<rasp_teacher>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<RatingView>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<Result_of_the_test>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Result_of_the_test>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<RNK>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr_b>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr_d>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<rr_d>()
                .Property(e => e.n_type_chasov)
                .IsUnicode(false);

            modelBuilder.Entity<rr_k_b>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_a>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_a>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_a>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_d>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_d>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_d>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr2_d>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_a>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_a>()
                .Property(e => e.n_element)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_a>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_a>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_d>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_d>()
                .Property(e => e.n_element)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_d>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_d>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr4_d>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.n_element)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_a>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.n_element)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_b>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_c>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_c>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_c>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_c>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_c>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_c>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.f_educ_vid)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rr5_d>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.n_element)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rr6_a>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_a2>()
                .Property(e => e.kafedra)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_a2>()
                .Property(e => e.year)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_a2>()
                .Property(e => e.teacher)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_a2>()
                .Property(e => e.semester)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_a2>()
                .Property(e => e.discipline)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_a2>()
                .Property(e => e.faculty)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1>()
                .Property(e => e.educ_form)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1_1>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1_1>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1_1>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1_1>()
                .Property(e => e.educ_form)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_f_1_1>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<rrnk_for_t>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<RRNKForIndividualPermiss>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<RRNKForIndividualPermiss>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<RRNKForIndividualPermiss>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<RRNKForIndividualPermiss>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<s_fio>()
                .Property(e => e.s_fio1)
                .IsUnicode(false);

            modelBuilder.Entity<s_fio>()
                .Property(e => e.s_s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<s_fio>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_old>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_old>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_old>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_old>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_r>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_r>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_r>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_SYS>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<s_g_SYS>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<s_spets_y>()
                .Property(e => e.ssy)
                .IsUnicode(false);

            modelBuilder.Entity<SCHDirectionList>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEducationFormList>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEmployeeList>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEmployeeList>()
                .Property(e => e.post)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEmployeeList>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEmployeeList>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<SCHGroupList>()
                .Property(e => e.p21)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline>()
                .Property(e => e.s_p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline1>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline1>()
                .Property(e => e.s_p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline1>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSchedule_discipline1>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList>()
                .Property(e => e.AuditoryName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList>()
                .Property(e => e.FullFIO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList>()
                .Property(e => e.FIO2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList>()
                .Property(e => e.KafedraName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList>()
                .Property(e => e.KafedraFullName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.s_p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.FullFIO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.FIO2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.AuditoryName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.KafedraName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.KafedraFullName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_a>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_old>()
                .Property(e => e.AuditoryName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHScheduleList_old>()
                .Property(e => e.FullFIO)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSpecialityList>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList>()
                .Property(e => e.kafedraName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList>()
                .Property(e => e.discipline)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_a>()
                .Property(e => e.kafedraName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_a>()
                .Property(e => e.discipline)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_a>()
                .Property(e => e.SubjectShortName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.AVN_update)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.kafedraName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.discipline)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.examinationName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.disciplineName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHStudyPlanList_b>()
                .Property(e => e.SubjectShortName)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSubjectList>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSubjectList>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<SCHSubjectList>()
                .Property(e => e.s_p34)
                .IsUnicode(false);

            modelBuilder.Entity<SelDesciplineForKPV>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<SelIdvil>()
                .Property(e => e.NameVillage)
                .IsUnicode(false);

            modelBuilder.Entity<SelIdvil>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<sharp_temp_t1>()
                .Property(e => e.id_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<SingleTeacher>()
                .Property(e => e.NameDistrict)
                .IsUnicode(false);

            modelBuilder.Entity<speciality_form>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<specialityRR>()
                .Property(e => e.p25_1)
                .IsUnicode(false);

            modelBuilder.Entity<specialityRR>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<specialityRR>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<specialityRR>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<specialityRR>()
                .Property(e => e.p25_21)
                .IsUnicode(false);

            modelBuilder.Entity<specialityV>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<specialityV>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<specialityV>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<specialityV>()
                .Property(e => e.p25_21)
                .IsUnicode(false);

            modelBuilder.Entity<specialityV>()
                .Property(e => e.p25_2_fe_kaf)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_faculty>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_faculty>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_groups_student>()
                .Property(e => e.fio)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_kaf_teacher>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_student>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_student>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_student>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_student_discipline>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_teacher>()
                .Property(e => e.p26)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_teacher>()
                .Property(e => e.p28)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_teacher>()
                .Property(e => e.p27)
                .IsUnicode(false);

            modelBuilder.Entity<SRS_v_teachersDiscipline>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<st_gr>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<st_gr>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.first_p1)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.Streetbirth)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.adrhome)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.TelephoneHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.StreetNow)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.adrnow)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.TelephoneNow)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.SerialPas)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.NumberPas)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.DateRegistr)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.lang)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.hobby)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.religion)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.visitKG)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.aids)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.smsAccountFromAbit)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.Attribute)
                .IsUnicode(false);

            modelBuilder.Entity<STKGTU>()
                .Property(e => e.op)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student_info_View>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Student_info_View>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Po_id_Group>()
                .Property(e => e.idid)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Po_id_Group>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.NameRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.NameDistrict)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.NameCity)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.NameVillage)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Propiska>()
                .Property(e => e.StreetHomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsGroup>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsGroup>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsGroup>()
                .Property(e => e.NameLanguage)
                .IsUnicode(false);

            modelBuilder.Entity<StudentsGroup>()
                .Property(e => e.v2)
                .IsUnicode(false);

            modelBuilder.Entity<sv_a_NEW>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<sv_a_old>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<sv_ar>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<SV_proced1_temp_t1>()
                .Property(e => e.id_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.come_k)
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_fio>()
                .Property(e => e.t_fio1)
                .IsUnicode(false);

            modelBuilder.Entity<t_fio>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<t_nag_sh_lk_RRNK_new_LB_potok>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<t_nag_sh_lk_RRNK_new_LK_potok>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<t_nag_sh_lk_RRNK_new_PR_potok>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<t_s_fio>()
                .Property(e => e.fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_a>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<temp_a>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<temp_aannkk>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_ABIT_ORT>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_ABIT_ORT>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.S_f)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.S_n)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.S_o)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.kafedra)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p26)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p27)
                .IsUnicode(false);

            modelBuilder.Entity<temp_Ainura>()
                .Property(e => e.p28)
                .IsUnicode(false);

            modelBuilder.Entity<temp_ALL>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_ank_kol_st>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_b1>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<temp_b1>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_b1>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_b1>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_bektur>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_bektur>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_bektur>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<temp_bektur>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c_1>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c_1>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<temp_c_1>()
                .Property(e => e.p109)
                .IsUnicode(false);

            modelBuilder.Entity<temp_d>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_d>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_d>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_date>()
                .Property(e => e.id_student)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_date>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.host_del)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.oper_del)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<temp_del_paym>()
                .Property(e => e.tmp)
                .IsUnicode(false);

            modelBuilder.Entity<temp_dop_prim_1>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<temp_dop_prim_1>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_dop_prim_1>()
                .Property(e => e.prim)
                .IsUnicode(false);

            modelBuilder.Entity<temp_dop_prim_2>()
                .Property(e => e.prim)
                .IsUnicode(false);

            modelBuilder.Entity<temp_kpv_educ_sh>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log>()
                .Property(e => e.table)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log>()
                .Property(e => e.detal)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log_upd>()
                .Property(e => e.table)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log_upd>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log_upd>()
                .Property(e => e.detal)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log_upd>()
                .Property(e => e.oldValue)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log_upd>()
                .Property(e => e.newValue)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log_upd>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.mm)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.table)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.detal)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.oldValue)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.newValue)
                .IsUnicode(false);

            modelBuilder.Entity<temp_log2>()
                .Property(e => e.userComp)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_fix_O>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_fix_O>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_fix_O>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_fix_O>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_reg_O>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_reg_O>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_reg_O>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_net_nagr_reg_O>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_nur>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_nur>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_nur>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_nur>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_nur>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_nur>()
                .Property(e => e.p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<temp_pay_error>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_pay_error>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_pay_error>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_prob>()
                .Property(e => e.NameRegion)
                .IsUnicode(false);

            modelBuilder.Entity<temp_prob>()
                .Property(e => e.NameDistrict)
                .IsUnicode(false);

            modelBuilder.Entity<temp_rasp>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Temp_rasp_error>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Temp_rasp_error>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<Temp_rasp_error>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temp_rasp2>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.s_s_fio_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<temp_SV_proced1>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_test>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<temp_test>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_test>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_test>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_test>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_trnk>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_trnk>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_UC>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_UC>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_UC>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_UC>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_UC>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<temp_View_9>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<temp_vrem_kontingent_stud>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temp_vrem_kontingent_stud>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<temp2>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<temp2>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.tmp)
                .IsUnicode(false);

            modelBuilder.Entity<temppp>()
                .Property(e => e.id_onlinePaymentStream)
                .HasPrecision(20, 0);

            modelBuilder.Entity<temppp>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.dopol)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.osnovanie)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.primech)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.dop_info)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.num_prikaz)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.tmp)
                .IsUnicode(false);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.id_onlinePaymentStream)
                .HasPrecision(20, 0);

            modelBuilder.Entity<temppp_1>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<tempq>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<tempTRNK>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<tempTRNK>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<tempTRNK>()
                .Property(e => e.s_p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<tempTRNK>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<tempttt>()
                .Property(e => e.proz)
                .HasPrecision(30, 15);

            modelBuilder.Entity<test_DFS>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<test_DFS>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<test_DFS>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<test_DFS>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<test_DFS>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<test_DFS>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<trnk_kurs>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<trnk_kurs>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<trnk_kurs>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<trnk_kurs>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<trnk_kurs>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<trnk_rs_naz>()
                .Property(e => e.s_p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.v2)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.mo)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<uch_kart>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<uchk_d>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<uchk_d_kpv>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<uchk_ds>()
                .Property(e => e.p45)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<uchk_ds>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<uchk_s>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.god)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.fac)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<V__EDUC_SH>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v1)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v2)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v3)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v4)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v5)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v6)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v7)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v8)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v9)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v10)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v11)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v12)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank>()
                .Property(e => e.v13)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_b>()
                .Property(e => e.sred)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C1)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C2)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C3)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C4)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C5)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C6)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C7)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C8)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C9)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C10)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C11)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C12)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C13)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C14)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C15)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C16)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C17)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C18)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C19)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_ank_c>()
                .Property(e => e.C20)
                .HasPrecision(38, 6);

            modelBuilder.Entity<V_anket_vsego_st_movment>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_anket_vsego_st_movment>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_anketirovanie>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_anketirovanie>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_anketirovanie>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<V_anketirovanie>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<v_Auditory>()
                .Property(e => e.name_korpus)
                .IsUnicode(false);

            modelBuilder.Entity<v_Auditory>()
                .Property(e => e.Auditory)
                .IsUnicode(false);

            modelBuilder.Entity<v_Auditory>()
                .Property(e => e.specifics)
                .IsUnicode(false);

            modelBuilder.Entity<v_Auditory>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<V_Educ_sh>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_Educ_sh>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<V_Educ_sh>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Educ_sh>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Educ_sh>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_Educ_sh_RRNK>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_edush>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_edush>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<V_edush>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<V_edush>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_edush>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_edush>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXByFaculty>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXByFaculty>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXByFaculty>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXByFaculty>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXByFaculty>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXDistinct>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_FXDistinct>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_IndividualModulPermissPotok_group_discipline>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<v_kaf_teacher>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_KPV_Info_2>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.s_s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_LMS_SMS_spets>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Login>()
                .Property(e => e.snp)
                .IsUnicode(false);

            modelBuilder.Entity<V_Login>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<V_ManagerFacultyForStudents>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_ManagerKafedraForTeachers>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_mark_mag_arch>()
                .Property(e => e.p35)
                .IsUnicode(false);

            modelBuilder.Entity<V_MarkMag_user>()
                .Property(e => e.p109)
                .IsUnicode(false);

            modelBuilder.Entity<V_Movement_MaxRate_StudentsOfGroup>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_Movement_MaxRate_StudentsOfGroup>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<V_Movement_MaxRate_StudentsOfGroup>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<V_MYFIND>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_MYFIND>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_MYFIND>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<V_oplana_st>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<V_oplana_st>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_oplana_st>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<V_oplana_st>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_oplana_st>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<V_oplana_st>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_PaymentTransferVirtual>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<V_PaymentTransferVirtual>()
                .Property(e => e.rate)
                .IsUnicode(false);

            modelBuilder.Entity<V_PaymentTransferVirtual>()
                .Property(e => e.v_opl)
                .IsUnicode(false);

            modelBuilder.Entity<V_podrazd_RSlib>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_podrazd_RSlib>()
                .Property(e => e.otd1)
                .IsUnicode(false);

            modelBuilder.Entity<V_podrazd_RSlib>()
                .Property(e => e.otd11)
                .IsUnicode(false);

            modelBuilder.Entity<V_podrazd_RSlib>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_podrazd_RSlib>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.ch_zham)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_Raspisanie_new>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<V_RRNKkrdt>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_RRNKkrdt>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<V_RRNKkrdt>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_RRNKkrdt>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_RRNKkrdt>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHSchedule_discp_pasp>()
                .Property(e => e.AVN_user)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHSchedule_discp_pasp>()
                .Property(e => e.kafedraName)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHSchedule_discp_pasp>()
                .Property(e => e.examinationName)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHShedule_Error_aud>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHShedule_Error_aud>()
                .Property(e => e.semester)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHShedule_Error_aud>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHShedule_Error_aud>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<V_SCHShedule_Error_aud>()
                .Property(e => e.nedeli)
                .IsUnicode(false);

            modelBuilder.Entity<V_SG_Citizenship_fakylty>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_SG_Citizenship_fakylty>()
                .Property(e => e.spec)
                .IsUnicode(false);

            modelBuilder.Entity<V_SG_Citizenship_fakylty>()
                .Property(e => e.p20)
                .IsUnicode(false);

            modelBuilder.Entity<V_SG_Citizenship_fakylty>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_SG_Citizenship_fakylty>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<V_SG_Citizenship_fakylty>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<V_smeta_spec>()
                .Property(e => e.p108)
                .IsUnicode(false);

            modelBuilder.Entity<V_smeta_spec>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_smeta_spec>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_smeta_spec>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_smeta_spec>()
                .Property(e => e.p14_7)
                .IsUnicode(false);

            modelBuilder.Entity<V_special_rate>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_special_rate>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_special_rate>()
                .Property(e => e.p24_1)
                .IsUnicode(false);

            modelBuilder.Entity<V_special_rate>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_special_rate>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_special_rate>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<v_StreamGroup>()
                .Property(e => e.potok)
                .IsUnicode(false);

            modelBuilder.Entity<v_teachersDiscipline>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<v_teachersFIO>()
                .Property(e => e.fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_Test_samoozenka>()
                .Property(e => e.p1)
                .IsUnicode(false);

            modelBuilder.Entity<V_Test_samoozenka>()
                .Property(e => e.p2)
                .IsUnicode(false);

            modelBuilder.Entity<V_Test_samoozenka>()
                .Property(e => e.p3)
                .IsUnicode(false);

            modelBuilder.Entity<V_time>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<V_UMK_spets>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<V_UMK_spets>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_UMK_spets>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<V_UMK_spets>()
                .Property(e => e.sn_f1)
                .IsUnicode(false);

            modelBuilder.Entity<V_UMK_spets>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<V_UMK_spets>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<V1>()
                .Property(e => e.id_onlinePaymentStream)
                .HasPrecision(20, 0);

            modelBuilder.Entity<ved_pps_a>()
                .Property(e => e.ved1)
                .IsUnicode(false);

            modelBuilder.Entity<ved_pps_a>()
                .Property(e => e.ved2)
                .IsUnicode(false);

            modelBuilder.Entity<ved_pps_a>()
                .Property(e => e.ved3)
                .IsUnicode(false);

            modelBuilder.Entity<ved_pps_a>()
                .Property(e => e.ekv_num)
                .IsUnicode(false);

            modelBuilder.Entity<View_4>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<View_7>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<View_7>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<View_8>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<vit_2>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<vit_3>()
                .Property(e => e.sh_st)
                .IsUnicode(false);

            modelBuilder.Entity<VKafedraForKPV>()
                .Property(e => e.kafedra)
                .IsUnicode(false);

            modelBuilder.Entity<VSelForKPV>()
                .Property(e => e.year)
                .IsUnicode(false);

            modelBuilder.Entity<VSelForKPV>()
                .Property(e => e.semester)
                .IsUnicode(false);

            modelBuilder.Entity<VSelForKPV>()
                .Property(e => e.faculty)
                .IsUnicode(false);

            modelBuilder.Entity<VSelForKPV>()
                .Property(e => e.discipline)
                .IsUnicode(false);

            modelBuilder.Entity<www_dv>()
                .Property(e => e.come_reg)
                .IsUnicode(false);

            modelBuilder.Entity<www_dv>()
                .Property(e => e.come_date)
                .IsUnicode(false);

            modelBuilder.Entity<www_dv>()
                .Property(e => e.leave_reg)
                .IsUnicode(false);

            modelBuilder.Entity<www_dv>()
                .Property(e => e.leave_k)
                .IsUnicode(false);

            modelBuilder.Entity<www_dv>()
                .Property(e => e.oper)
                .IsUnicode(false);

            modelBuilder.Entity<Z_AKADEM>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Faculty_Null>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Faculty_Null>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Z_LMS_SMS_KR>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Z_LMS_SMS_KR>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<Z_LMS_SMS_KR>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<Z_LMS_SMS_KR>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Z_nauka1>()
                .Property(e => e.t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Z_nauka1>()
                .Property(e => e.k5)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_DFS>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_DFS>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_DFS>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_DFS>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_DFS>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_DFS>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_obyas>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_obyas_a>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_obyas_a_kaf>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_obyas_a_RRNKkrdt>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_yacheika>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_rasp_yacheika2>()
                .Property(e => e.code_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p42)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p23_1)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p23_2)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p25_2)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.Time_)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.aud_num)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.f1)
                .IsUnicode(false);

            modelBuilder.Entity<Z_Sheduler_RRNKkrdt_y_rasp>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Z_SV1>()
                .Property(e => e.id_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_SV1_NEW_OLD>()
                .Property(e => e.id_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_SV1_OLD>()
                .Property(e => e.id_discipline)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_GE>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_GE_oldd>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_OLD>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_A>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_A>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_A>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_A>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_A>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_A>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_B>()
                .Property(e => e.s_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_B>()
                .Property(e => e.p22)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_B>()
                .Property(e => e.p43)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_B>()
                .Property(e => e.p34)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_B>()
                .Property(e => e.p32)
                .IsUnicode(false);

            modelBuilder.Entity<Z_USPEV_UC_B>()
                .Property(e => e.s_t_fio)
                .IsUnicode(false);

            modelBuilder.Entity<Zoomo_VIEW>()
                .Property(e => e.NumberSertRT)
                .IsUnicode(false);

            modelBuilder.Entity<Zoomo_VIEW>()
                .Property(e => e.p24_2)
                .IsUnicode(false);

            modelBuilder.Entity<Zoomo_VIEW>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ZS_SV1>()
                .Property(e => e.id_discipline)
                .IsUnicode(false);
        }
    }
}
