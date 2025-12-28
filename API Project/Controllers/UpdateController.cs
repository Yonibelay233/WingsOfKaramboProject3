using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;
using WingsOfKaramboProject;

namespace API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        //[HttpPut]
        //[ActionName("CityTBLUpdater")]

        //public int UpdateACityTBL(CityTBL cityTBL)
        //{
        //    CityDB db = new CityDB();
        //    db.Update(cityTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("ActionTBLUpdater")]

        //public int UpdateAActionTBL(ActionTBL actionTBL)
        //{
        //    ActionDB db = new ActionDB();
        //    db.Update(actionTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("ApprenticeTBLUpdater")]

        //public int UpdateAApprenticeTBL(ApprenticeTBL apprenticeTBL)
        //{
        //    ApprenticeDB db = new ApprenticeDB();
        //    db.Update(apprenticeTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("BranchTBLUpdater")]

        //public int UpdateABranchTBL(BranchTBL branchTBL)
        //{
        //    BranchDB db = new BranchDB();
        //    db.Update(branchTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("GradeTBLUpdater")]

        //public int UpdateAGradeTBL(GradeTBL gradeTBL)
        //{
        //    GradeDB db = new GradeDB();
        //    db.Update(gradeTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("GroupsTBLUpdater")]

        //public int UpdateAGroupsTBL(GroupsTBL groupsTBL)
        //{
        //    GroupsDB db = new GroupsDB();
        //    db.Update(groupsTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("SchoolTBLUpdater")]

        //public int UpdateASchoolTBL(SchoolTBL schoolTBL)
        //{
        //    SchoolDB db = new SchoolDB();
        //    db.Update(schoolTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("GuideTBLUpdater")]

        //public int UpdateAGuideTBL(GuideTBL guideTBL)
        //{
        //    GuideDB db = new GuideDB();
        //    db.Update(guideTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("RoleTBLUpdater")]

        //public int UpdateARoleTBL(RoleTBL roleTBL)
        //{
        //    RoleDB db = new RoleDB();
        //    db.Update(roleTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("PersonTBLUpdater")]

        //public int UpdateAPersonTBL(PersonTBL personTBL)
        //{
        //    PersonDB db = new PersonDB();
        //    db.Update(personTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("ChildWithSpecialNeedTBLUpdater")]

        //public int UpdateAChildWithSpecialNeedTBL(ChildWithSpecialNeedTBL childWithSpecialNeedTBL)
        //{
        //    ChildWithSpecialNeedDB db = new ChildWithSpecialNeedDB();
        //    db.Update(childWithSpecialNeedTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("StaffMemberTBLUpdater")]

        //public int UpdateAStaffMemberTBL(StaffMemberTBL staffMemberTBL)
        //{
        //    StaffMemberDB db = new StaffMemberDB();
        //    db.Update(staffMemberTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("SpecialNeedsTBLUpdater")]

        //public int UpdateASpecialNeedsTBL(SpecialNeedsTBL specialNeedsTBL)
        //{
        //    SpecialNeedsDB db = new SpecialNeedsDB();
        //    db.Update(specialNeedsTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("AssigningChildrenToAGroupTBLUpdater")]

        //public int UpdateAAssigningChildrenToAGroupTBL(AssigningChildrenToAGroupTBL assigningChildrenToAGroupTBL)
        //{
        //    AssigningChildrenToAGroupDB db = new AssigningChildrenToAGroupDB();
        //    db.Update(assigningChildrenToAGroupTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("AssigningApprenticeToAGroupTBLUpdater")]

        //public int UpdateAAssigningApprenticeToAGroupTBL(AssigningApprenticeToAGroupTBL assigningApprenticeToAGroupTBL)
        //{
        //    AssigningApprenticeToAGroupDB db = new AssigningApprenticeToAGroupDB();
        //    db.Update(assigningApprenticeToAGroupTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("AssigningGroupToActionTBLUpdater")]

        //public int UpdateAAssigningGroupToActionTBL(AssigningGroupToActionTBL assigningGroupToActionTBL)
        //{
        //    AssigningGroupToActionDB db = new AssigningGroupToActionDB();
        //    db.Update(assigningGroupToActionTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //[HttpPut]
        //[ActionName("AssigningApprenticeToActionTBLUpdater")]

        //public int UpdateAAssigningApprenticeToActionTBL(AssigningApprenticeToActionTBL assigningApprenticeToActionTBL)
        //{
        //    AssigningApprenticeToActionDB db = new AssigningApprenticeToActionDB();
        //    db.Update(assigningApprenticeToActionTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}
    }
}
