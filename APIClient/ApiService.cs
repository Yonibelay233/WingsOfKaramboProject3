using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WingsOfKaramboProject;

namespace APIClient
{
    public class ApiService : IApiService
    {
        string uri;
        private HttpClient client;
        public ApiService()
        {
            uri = "http://localhost:5078";
            client = new HttpClient();
        }

        public async Task<CityTBList> GetAllCities()
        {
            return await client.GetFromJsonAsync<CityTBList>(uri + "/api/Select/CitySelector");
        }
        public async Task<int> DeleteACity(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteACityTBL/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateACity(CityTBL c)
        {
            return (await client.PutAsJsonAsync<CityTBL>(uri + "/api/Update/CityTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertACity(CityTBL c)
        {
            return (await client.PostAsJsonAsync<CityTBL>(uri + "/api/Insert/InsertACity/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ActionTBList> GetAllActions()
        {
            return await client.GetFromJsonAsync<ActionTBList>(uri + "/api/Select/ActionSelector");
        }
        public async Task<int> DeleteAnAction(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAction/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAnAction(ActionTBL a)
        {
            return (await client.PutAsJsonAsync<ActionTBL>(uri + "/api/Update/ActionTBLUpdate/", a)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAnAction(ActionTBL a)
        {
            return (await client.PostAsJsonAsync<ActionTBL>(uri + "/api/Insert/InsertAAction/", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ApprenticeTBList> GetAllApprentices()
        {
            return await client.GetFromJsonAsync<ApprenticeTBList>(uri + "/api/Select/ApprenticeSelector");
        }
        public async Task<int> DeleteAApprentice(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAApprentice/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAApprentice(ApprenticeTBL c)
        {
            return (await client.PutAsJsonAsync<ApprenticeTBL>(uri + "/api/Update/ApprenticeTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAApprentice(ApprenticeTBL c)
        {
            return (await client.PostAsJsonAsync<ApprenticeTBL>(uri + "/api/Insert/InsertAApprentice/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<BranchTBList> GetAllBranchs()
        {
            return await client.GetFromJsonAsync<BranchTBList>(uri + "/api/Select/BranchSelector");
        }
        public async Task<int> DeleteABranch(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteABranch/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateABranch(BranchTBL c)
        {
            return (await client.PutAsJsonAsync<BranchTBL>(uri + "/api/Update/BranchTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertABranch(BranchTBL c)
        {
            return (await client.PostAsJsonAsync<BranchTBL>(uri + "/api/Insert/InsertABranch/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<GradeTBList> GetAllGrades()
        {
            return await client.GetFromJsonAsync<GradeTBList>(uri + "/api/Select/GradeSelector");
        }
        public async Task<int> DeleteAGrade(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAGrade/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAGrade(GradeTBL c)
        {
            return (await client.PutAsJsonAsync<GradeTBL>(uri + "/api/Update/GradeTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAGrade(GradeTBL c)
        {
            return (await client.PostAsJsonAsync<GradeTBL>(uri + "/api/Insert/InsertAGrade/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<GroupsTBList> GetAllGroups()
        {
            return await client.GetFromJsonAsync<GroupsTBList>(uri + "/api/Select/GroupsSelector");
        }
        public async Task<int> DeleteAGroups(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAGroups/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAGroups(GroupsTBL c)
        {
            return (await client.PutAsJsonAsync<GroupsTBL>(uri + "/api/Update/GroupsTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAGroups(GroupsTBL c)
        {
            return (await client.PostAsJsonAsync<GroupsTBL>(uri + "/api/Insert/InsertAGroups/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<GuideTBList> GetAllGuides()
        {
            return await client.GetFromJsonAsync<GuideTBList>(uri + "/api/Select/GuideSelector");
        }
        public async Task<int> DeleteAGuide(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAGuide/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAGuide(GuideTBL c)
        {
            return (await client.PutAsJsonAsync<GuideTBL>(uri + "/api/Update/GuideTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAGuide(GuideTBL c)
        {
            return (await client.PostAsJsonAsync<GuideTBL>(uri + "/api/Insert/InsertAGuide/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<PersonTBList> GetAllPersons()
        {
            return await client.GetFromJsonAsync<PersonTBList>(uri + "/api/Select/PersonSelector");
        }
        public async Task<int> DeleteAPerson(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAPerson/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAPerson(PersonTBL c)
        {
            return (await client.PutAsJsonAsync<PersonTBL>(uri + "/api/Update/PersonTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAPerson(PersonTBL c)
        {
            return (await client.PostAsJsonAsync<PersonTBL>(uri + "/api/Insert/InsertAPerson/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<RoleTBList> GetAllRoles()
        {
            return await client.GetFromJsonAsync<RoleTBList>(uri + "/api/Select/RoleSelector");
        }
        public async Task<int> DeleteARole(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteARole/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateARole(RoleTBL c)
        {
            return (await client.PutAsJsonAsync<RoleTBL>(uri + "/api/Update/RoleTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertARole(RoleTBL c)
        {
            return (await client.PostAsJsonAsync<RoleTBL>(uri + "/api/Insert/InsertARole/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<SpecialNeedsTBList> GetAllSpecialNeeds()
        {
            return await client.GetFromJsonAsync<SpecialNeedsTBList>(uri + "/api/Select/SpecialNeedsSelector");
        }
        public async Task<int> DeleteASpecialNeeds(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteASpecialNeeds/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateASpecialNeeds(SpecialNeedsTBL c)
        {
            return (await client.PutAsJsonAsync<SpecialNeedsTBL>(uri + "/api/Update/SpecialNeedsTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertASpecialNeeds(SpecialNeedsTBL c)
        {
            return (await client.PostAsJsonAsync<SpecialNeedsTBL>(uri + "/api/Insert/InsertASpecialNeeds/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<StaffMemberTBList> GetAllStaffMembers()
        {
            return await client.GetFromJsonAsync<StaffMemberTBList>(uri + "/api/Select/StaffMemberSelector");
        }
        public async Task<int> DeleteAStaffmember(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAStaffMember/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAStaffmember(StaffMemberTBL c)
        {
            return (await client.PutAsJsonAsync<StaffMemberTBL>(uri + "/api/Update/StaffMemberTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAStaffmember(StaffMemberTBL c)
        {
            return (await client.PostAsJsonAsync<StaffMemberTBL>(uri + "/api/Insert/InsertAStaffMember/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<ChildWithSpecialNeedList> GetAllChildWithSpecialNeeds()
        {
            return await client.GetFromJsonAsync<ChildWithSpecialNeedList>(uri + "/api/Select/ChildWithSpecialNeedSelector");
        }
        public async Task<int> DeleteAChildWithSpecialNeed(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAChildWithSpecialNeed/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAChildWithSpecialNeed(ChildWithSpecialNeedTBL c)
        {
            return (await client.PutAsJsonAsync<ChildWithSpecialNeedTBL>(uri + "/api/Update/ChildWithSpecialNeedTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAChildWithSpecialNeed(ChildWithSpecialNeedTBL c)
        {
            return (await client.PostAsJsonAsync<ChildWithSpecialNeedTBL>(uri + "/api/Insert/InsertAChildWithSpecialNeed/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<SchoolTBList> GetAllSchools()
        {
            return await client.GetFromJsonAsync<SchoolTBList>(uri + "/api/Select/SchoolSelector");
        }
        public async Task<int> DeleteASchool(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteASchool/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateASchool(SchoolTBL c)
        {
            return (await client.PutAsJsonAsync<SchoolTBL>(uri + "/api/Update/SchoolTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertASchool(SchoolTBL c)
        {
            return (await client.PostAsJsonAsync<SchoolTBL>(uri + "/api/Insert/InsertASchool/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<AssigningChildrenToAGroupTBList> GetAllAssigningChildrenToAGroups()
        {
            return await client.GetFromJsonAsync<AssigningChildrenToAGroupTBList>(uri + "/api/Select/AssigningChildrenToAGroupSelector");
        }
        public async Task<int> DeleteAAssigningChildrenToAGroup(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAAssigningChildrenToAGroup/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL c)
        {
            return (await client.PutAsJsonAsync<AssigningChildrenToAGroupTBL>(uri + "/api/Update/AssigningChildrenToAGroupTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL c)
        {
            return (await client.PostAsJsonAsync<AssigningChildrenToAGroupTBL>(uri + "/api/Insert/InsertAAssigningChildrenToAGroup/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<AssigningApprenticeToAGroupTBList> GetAllAssigningApprenticeToAGroups()
        {
            return await client.GetFromJsonAsync<AssigningApprenticeToAGroupTBList>(uri + "/api/Select/AssigningApprenticeToAGroupSelector");
        }
        public async Task<int> DeleteAAssigningApprenticeToAGroup(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAAssigningApprenticeToAGroup/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL c)
        {
            return (await client.PutAsJsonAsync<AssigningApprenticeToAGroupTBL>(uri + "/api/Update/AssigningApprenticeToAGroupTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL c)
        {
            return (await client.PostAsJsonAsync<AssigningApprenticeToAGroupTBL>(uri + "/api/Insert/InsertAssigningApprenticeToAGroup/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<AssigningApprenticeToActionTBList> GetAllAssigningApprenticeToActions()
        {
            return await client.GetFromJsonAsync<AssigningApprenticeToActionTBList>(uri + "/api/Select/AssigningApprenticeToActionSelector");
        }
        public async Task<int> DeleteAAssigningApprenticeToAction(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAAssigningApprenticeToAction/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAAssigningApprenticeToAction(AssigningApprenticeToActionTBL c)
        {
            return (await client.PutAsJsonAsync<AssigningApprenticeToActionTBL>(uri + "/api/Update/AssigningApprenticeToActionTBLUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAAssigningApprenticeToAction(AssigningApprenticeToActionTBL c)
        {
            return (await client.PostAsJsonAsync<AssigningApprenticeToActionTBL>(uri + "/api/Insert/InsertAAssigningApprenticeToAction/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<AssigningGroupToActionTBList> GetAllAssigningGroupToActions()
        {
            return await client.GetFromJsonAsync<AssigningGroupToActionTBList>(uri + "/api/Select/AssigningGroupToActionSelector");
        }
        public async Task<int> DeleteAAssigningGroupToAction(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Delete/DeleteAAssigningGroupToAction/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAAssigningGroupToAction(AssigningGroupToActionTBL c)
        {
            return (await client.PutAsJsonAsync<AssigningGroupToActionTBL>(uri + "/api/Update/AssigningGroupToActionUpdate/", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAAssigningGroupToAction(AssigningGroupToActionTBL c)
        {
            return (await client.PostAsJsonAsync<AssigningGroupToActionTBL>(uri + "/api/Insert/InsertAAssigningGroupToAction/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public Task<int> DeleteAnAction(ActionTBL action)
        {
            throw new NotImplementedException();
        }

        Task<CityTBList> IApiService.GetAllCities()
        {
            throw new NotImplementedException();
        }



        public Task<int> DeleteACity(CityTBL city)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAnApprentice(ApprenticeTBL apprentice)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAnApprentice(ApprenticeTBL apprentice)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAnApprentice(ApprenticeTBL apprentice)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteABranch(BranchTBL branch)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAGrade(GradeTBL grade)
        {
            throw new NotImplementedException();
        }

        public Task<GroupsTBList> GetAllGroupss()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAGroups(GroupsTBL groups)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAGuide(GuideTBL guide)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAPerson(PersonTBL person)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteARole(RoleTBL role)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteASchool(SchoolTBL school)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteASpecialNeeds(SpecialNeedsTBL specialNeeds)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAStaffMember(StaffMemberTBL staffmember)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAnAssigningApprenticeToAction(AssigningApprenticeToActionTBL assigningApprenticeToAction)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAnAssigningApprenticeToAction(AssigningApprenticeToActionTBL assigningApprenticeToAction)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAnAssigningApprenticeToAction(AssigningApprenticeToActionTBL assigningApprenticeToAction)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAnAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroup)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAnAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroup)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAnAssigningApprenticeToAGroup(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroup)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAnAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL assigningChildrenToAGroup)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAnAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL assigningChildrenToAGroup)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAnAssigningChildrenToAGroup(AssigningChildrenToAGroupTBL assigningChildrenToAGroup)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAnAssigningGroupToAction(AssigningGroupToActionTBL assigningGroupToAction)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAnAssigningGroupToAction(AssigningGroupToActionTBL assigningGroupToAction)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAnAssigningGroupToAction(AssigningGroupToActionTBL assigningGroupToAction)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAChildWithSpecialNeed(ChildWithSpecialNeedTBL childWithSpecialNeed)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAStaffMember(StaffMemberTBL staffmember)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAStaffMember(StaffMemberTBL staffmember)
        {
            throw new NotImplementedException();
        }
    }
}
