using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace APIClient
{
    public interface IApiService
    {
        public Task<ActionTBList> GetAllActions();

        public Task<int> InsertAnAction(ActionTBL action);

        public Task<int> UpdateAnAction(ActionTBL action);

        public Task<int> DeleteAnAction(ActionTBL action);

        public Task<CityTBList> GetAllCities();

        public Task<int> InsertACity(CityTBL city);

        public Task<int> UpdateACity(CityTBL city);

        public Task<int> DeleteACity(CityTBL city);

        public Task<ApprenticeTBList> GetAllApprentices();

        public Task<int> InsertAnApprentice(ApprenticeTBL apprentice);

        public Task<int> UpdateAnApprentice(ApprenticeTBL apprentice);

        public Task<int> DeleteAnApprentice(ApprenticeTBL apprentice);

        public Task<BranchTBList> GetAllBranchs();

        public Task<int> InsertABranch(BranchTBL branch);

        public Task<int> UpdateABranch(BranchTBL branch);

        public Task<int> DeleteABranch(BranchTBL branch);

        public Task<GradeTBList> GetAllGrades();

        public Task<int> InsertAGrade(GradeTBL grade);

        public Task<int> UpdateAGrade(GradeTBL grade);

        public Task<int> DeleteAGrade(GradeTBL grade);

        public Task<GroupsTBList> GetAllGroupss();

        public Task<int> InsertAGroups(GroupsTBL groups);

        public Task<int> UpdateAGroups(GroupsTBL groups);

        public Task<int> DeleteAGroups(GroupsTBL groups);

        public Task<GuideTBList> GetAllGuides();

        public Task<int> InsertAGuide(GuideTBL guide);

        public Task<int> UpdateAGuide(GuideTBL guide);

        public Task<int> DeleteAGuide(GuideTBL guide);

        public Task<PersonTBList> GetAllPersons();

        public Task<int> InsertAPerson(PersonTBL person);

        public Task<int> UpdateAPerson(PersonTBL person);

        public Task<int> DeleteAPerson(PersonTBL person);

        public Task<RoleTBList> GetAllRoles();

        public Task<int> InsertARole(RoleTBL role);

        public Task<int> UpdateARole(RoleTBL role);

        public Task<int> DeleteARole(RoleTBL role);

        public Task<SchoolTBList> GetAllSchools();

        public Task<int> InsertASchool(SchoolTBL school);

        public Task<int> UpdateASchool(SchoolTBL school);

        public Task<int> DeleteASchool(SchoolTBL school);

        public Task<SpecialNeedsTBList> GetAllSpecialNeeds();

        public Task<int> InsertASpecialNeeds(SpecialNeedsTBL specialNeeds);

        public Task<int> UpdateASpecialNeeds(SpecialNeedsTBL specialNeeds);

        public Task<int> DeleteASpecialNeeds(SpecialNeedsTBL specialNeeds);

        public Task<StaffMemberTBList> GetAllStaffMembers();

        public Task<int> InsertAStaffMember(StaffMemberTBL staffmember);

        public Task<int> UpdateAStaffMember(StaffMemberTBL staffmember);

        public Task<int> DeleteAStaffMember(StaffMemberTBL staffmember);

        public Task<AssigningApprenticeToActionTBList> GetAllAssigningApprenticeToActions();

        public Task<int> InsertAnAssigningApprenticeToAction(AssigningApprenticeToActionTBL assigningApprenticeToAction);

        public Task<int> UpdateAnAssigningApprenticeToAction(AssigningApprenticeToActionTBL assigningApprenticeToAction);

        public Task<int> DeleteAnAssigningApprenticeToAction(AssigningApprenticeToActionTBL assigningApprenticeToAction);

        public Task<AssigningApprenticeToAGroupTBList> GetAllAssigningApprenticeToAGroups();

        public Task<int> InsertAnAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroup);

        public Task<int> UpdateAnAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroup);

        public Task<int> DeleteAnAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroup);

        public Task<AssigningChildrenToAGroupTBList> GetAllAssigningChildrenToAGroups();

        public Task<int> InsertAnAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL assigningChildrenToAGroup);

        public Task<int> UpdateAnAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL assigningChildrenToAGroup);

        public Task<int> DeleteAnAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL assigningChildrenToAGroup);

        public Task<AssigningGroupToActionTBList> GetAllAssigningGroupToActions();

        public Task<int> InsertAnAssigningGroupToAction(AssigningGroupToActionTBL assigningGroupToAction);

        public Task<int> UpdateAnAssigningGroupToAction(AssigningGroupToActionTBL assigningGroupToAction);

        public Task<int> DeleteAnAssigningGroupToAction(AssigningGroupToActionTBL assigningGroupToAction);

        public Task<ChildWithSpecialNeedList> GetAllChildWithSpecialNeeds();

        public Task<int> InsertAChildWithSpecialNeed(ChildWithSpecialNeedTBL childWithSpecialNeed);

        public Task<int> UpdateAChildWithSpecialNeed(ChildWithSpecialNeedTBL childWithSpecialNeed);

        public Task<int> DeleteAChildWithSpecialNeed(ChildWithSpecialNeedTBL childWithSpecialNeed);

    }
}
