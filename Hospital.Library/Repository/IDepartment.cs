using Hospital.Library.Entities;

namespace Hospital.Library.Repository;

public interface IDepartment:ICommon<Department>
{
    public Task<bool> DeleteDepartments(List<int> departmentIds);
}
