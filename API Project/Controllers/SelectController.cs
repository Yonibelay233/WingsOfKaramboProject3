using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WingsOfKaramboProject;
using ViewModel;

namespace API_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        [ActionName("ActionSelector")]
        public ActionTBList SelectAllActions()
        {
            ActionDB db = new ActionDB();
            ActionTBList actions = db.SelectAll();
            return actions;
        }

        [HttpGet]
        [ActionName("ApprenticeSelector")]

        public ApprenticeTBList SelectAllApprentices()
        {
            ApprenticeDB db = new ApprenticeDB();
            ApprenticeTBList apprentices = db.SelectAll();
            return apprentices;
        }
        [HttpGet]
        [ActionName("CitySelector")]

        public CityTBList SelectAllCities()
        {
            CityDB db = new CityDB();
            CityTBList cities = db.SelectAll();
            return cities;
        }
        [HttpGet]
        [ActionName("BranchSelector")]

        public BranchTBList SelectAllBranchs()
        {
            BranchDB db = new BranchDB();
            BranchTBList branchs = db.SelectAll();
            return branchs;
        }
        [HttpGet]
        [ActionName("GradeSelector")]

        public GradeTBList SelectAllGrades()
        {
            GradeDB db = new GradeDB();
            GradeTBList grades = db.SelectAll();
            return grades;
        }
        [HttpGet]
        [ActionName("GroupsSelector")]

        public GroupsTBList SelectAllGroups()
        {
            GroupsDB db = new GroupsDB();
            GroupsTBList groups = db.SelectAll();
            return groups;
        }
        [HttpGet]
        [ActionName("SchoolSelector")]

        public SchoolTBList SelectAllSchools()
        {
            SchoolDB db = new SchoolDB();
            SchoolTBList schools = db.SelectAll();
            return schools;
        }
        [HttpGet]
        [ActionName("GuideSelector")]

        public GuideTBList SelectAllGuides()
        {
            GuideDB db = new GuideDB();
            GuideTBList guides = db.SelectAll();
            return guides;
        }

        [HttpGet]
        [ActionName("RoleSelector")]

        public RoleTBList SelectAllRoles()
        {
            RoleDB db = new RoleDB();
            RoleTBList roles = db.SelectAll();
            return roles;
        }

        [HttpGet]
        [ActionName("PersonSelector")]

        public PersonTBList SelectAllPersons()
        {
            PersonDB db = new PersonDB();
            PersonTBList persons = db.SelectAll();
            return persons;
        }
        [HttpGet]
        [ActionName("ChildWithSpecialNeedSelector")]

        public ChildWithSpecialNeedList SelectAllChildWithSpecialNeeds()
        {
            ChildWithSpecialNeedDB db = new ChildWithSpecialNeedDB();
            ChildWithSpecialNeedList childWithSpecialNeeds = db.SelectAll();
            return childWithSpecialNeeds;
        }
        [HttpGet]
        [ActionName("AssigningApprenticeToActionSelector")]

        public AssigningApprenticeToActionTBList SelectAllAssigningApprenticeToActions()
        {
            AssigningApprenticeToActionDB db = new AssigningApprenticeToActionDB();
            AssigningApprenticeToActionTBList assigningApprenticeToActions = db.SelectAll();
            return assigningApprenticeToActions;
        }
        [HttpGet]
        [ActionName("AssigningGroupToActionSelector")]

        public AssigningGroupToActionTBList SelectAllAssigningGroupToActions()
        {
            AssigningGroupToActionDB db = new AssigningGroupToActionDB();
            AssigningGroupToActionTBList assigningGroupToActions = db.SelectAll();
            return assigningGroupToActions;
        }
        [HttpGet]
        [ActionName("AssigningApprenticeToAGroupSelector")]

        public AssigningApprenticeToAGroupTBList SelectAllAssigningApprenticeToAGroups()
        {
            AssigningApprenticeToAGroupDB db = new AssigningApprenticeToAGroupDB();
            AssigningApprenticeToAGroupTBList assigningApprenticeToAGroups = db.SelectAll();
            return assigningApprenticeToAGroups;
        }
        [HttpGet]
        [ActionName("AssigningChildrenToAGroupSelector")]

        public AssigningChildrenToAGroupTBList SelectAllAssigningChildrenToAGroups()
        {
            AssigningChildrenToAGroupDB db = new AssigningChildrenToAGroupDB();
            AssigningChildrenToAGroupTBList assigningChildrenToAGroups = db.SelectAll();
            return assigningChildrenToAGroups;
        }
        [HttpGet]
        [ActionName("SpecialNeedsSelector")]

        public SpecialNeedsTBList SelectAllSpecialNeeds()
        {
            SpecialNeedsDB db = new SpecialNeedsDB();
            SpecialNeedsTBList specialNeeds = db.SelectAll();
            return specialNeeds;
        }
        [HttpGet]
        [ActionName("StaffMemberSelector")]

        public StaffMemberTBList SelectAllStaffMembers()
        {
            StaffMemberDB db = new StaffMemberDB();
            StaffMemberTBList staffMembers = db.SelectAll();
            return staffMembers;
        }
    }
}
