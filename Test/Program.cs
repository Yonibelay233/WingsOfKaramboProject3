using System.Collections.Generic;
using ViewModel;
using WingsOfKaramboProject;

CityDB cdb = new();
CityTBList cList = cdb.SelectAll();
foreach (CityTBL c in cList)
    Console.WriteLine(c.WhatCity);
CityTBL CityTBLToUpdate = cList[2];
CityTBLToUpdate.WhatCity += "אאא";
cdb.Update(CityTBLToUpdate);
int x = cdb.SaveChanges();
Console.WriteLine($"{x} rows were update");
CityTBL newCityTBL = new CityTBL
{
    WhatCity = "מטולה"
};
cdb.Insert(newCityTBL);
int x = cdb.SaveChanges();
Console.WriteLine($"{x} rows were insert");
CityTBL c = cList.Last();
cdb.Delete(c);
int z = cdb.SaveChanges();
Console.WriteLine($"{z} rows were deleted");

ApprenticeDB apdb = new();
ApprenticeTBList aList = apdb.SelectAll();
foreach (ApprenticeTBL a in aList)
{
    Console.WriteLine(a.School.WhatSchool);
    Console.WriteLine(a.FirstName);
   Console.WriteLine(a.LastName);
    Console.WriteLine(a.Grade.WhatGrade);
    Console.WriteLine(a.Street);
    Console.WriteLine(a.BuildingNumber);
    Console.WriteLine(a.IdPerson);
    Console.WriteLine(a.City.WhatCity);
    Console.WriteLine(a.DateOfBirth);
}
SchoolDB sdb = new();
SchoolTBList sList = sdb.SelectAll();
foreach (SchoolTBL s in sList)
    Console.WriteLine(s.WhatSchool);


RoleDB rdb = new();
RoleTBList rList = rdb.SelectAll();
foreach (RoleTBL r in rList)
    Console.WriteLine(r.WhatRole);

GradeDB gdb = new();
GradeTBList gList = gdb.SelectAll();
foreach (GradeTBL g in gList)
    Console.WriteLine(g.WhatGrade);

BranchDB bdb = new();
BranchTBList bList = bdb.SelectAll();
foreach (BranchTBL b in bList)
{
    Console.WriteLine(b.NameOfBranch);
    Console.WriteLine(b.City.WhatCity);
}

StaffMemberDB smdb = new();
StaffMemberTBList smList = smdb.SelectAll();
foreach (StaffMemberTBL sm in smList)
    Console.WriteLine(sm.RoleCode.WhatRole);



