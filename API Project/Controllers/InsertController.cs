using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;
using WingsOfKaramboProject;

namespace API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        [HttpPost]
        [ActionName("InsertACity")]
        public int InsertACity([FromBody] CityTBL cityTBL)
        {
            CityDB db = new CityDB();
            db.Insert(cityTBL);
            int x = db.SaveChanges();
            return x;
        }

        public int InsertAStaffMember([FromBody] StaffMemberTBL staffMemberTBL)
        {
            StaffMemberDB db = new StaffMemberDB();
            db.Insert(staffMemberTBL);
            int x = db.SaveChanges();
            return x;
        }

        //public int InsertASpecialNeeds([FromBody] SpecialNeedsTBL specialNeedsTBL)
        //{
        //    SpecialNeedsDB db = new SpecialNeedsDB();
        //    db.Insert(specialNeedsTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAAssigningChildrenToAGroup([FromBody] AssigningChildrenToAGroupTBL assigningChildrenToAGroupTBL)
        //{
        //    AssigningChildrenToAGroupDB db = new AssigningChildrenToAGroupDB();
        //    db.Insert(assigningChildrenToAGroupTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAAssigningApprenticeToAGroup([FromBody] AssigningApprenticeToAGroupTBL assigningApprenticeToAGroupTBL)
        //{
        //    AssigningApprenticeToAGroupDB db = new AssigningApprenticeToAGroupDB();
        //    db.Insert(assigningApprenticeToAGroupTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAAssigningGroupToAction([FromBody] AssigningGroupToActionTBL assigningGroupToActionTBL)
        //{
        //    AssigningGroupToActionDB db = new AssigningGroupToActionDB();
        //    db.Insert(assigningGroupToActionTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAAssigningApprenticeToAction([FromBody] AssigningApprenticeToActionTBL assigningApprenticeToActionTBL)
        //{
        //    AssigningApprenticeToActionDB db = new AssigningApprenticeToActionDB();
        //    db.Insert(assigningApprenticeToActionTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAChildWithSpecialNeed([FromBody] ChildWithSpecialNeedTBL childWithSpecialNeedTBL)
        //{
        //    ChildWithSpecialNeedDB db = new ChildWithSpecialNeedDB();
        //    db.Insert(childWithSpecialNeedTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAPerson([FromBody] PersonTBL personTBL)
        //{
        //    PersonDB db = new PersonDB();
        //    db.Insert(personTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertARole([FromBody] RoleTBL roleTBL)
        //{
        //    RoleDB db = new RoleDB();
        //    db.Insert(roleTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAGuide([FromBody] GuideTBL guideTBL)
        //{
        //    GuideDB db = new GuideDB();
        //    db.Insert(guideTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertASchool([FromBody] SchoolTBL schoolTBL)
        //{
        //    SchoolDB db = new SchoolDB();
        //    db.Insert(schoolTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAGroups([FromBody] GroupsTBL groupsTBL)
        //{
        //    GroupsDB db = new GroupsDB();
        //    db.Insert(groupsTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAGrade([FromBody] GradeTBL gradeTBL)
        //{
        //    GradeDB db = new GradeDB();
        //    db.Insert(gradeTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertABranch([FromBody] BranchTBL branchTBL)
        //{
        //    BranchDB db = new BranchDB();
        //    db.Insert(branchTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAApprentice([FromBody] ApprenticeTBL apprenticeTBL)
        //{
        //    ApprenticeDB db = new ApprenticeDB();
        //    db.Insert(apprenticeTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}

        //public int InsertAAction([FromBody] ActionTBL actionTBL)
        //{
        //    ActionDB db = new ActionDB();
        //    db.Insert(actionTBL);
        //    int x = db.SaveChanges();
        //    return x;
        //}
    }
}
