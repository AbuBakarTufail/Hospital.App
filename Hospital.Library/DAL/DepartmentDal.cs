using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Hospital.Library.DAL;

public class DepartmentDal : IDepartment
{
    private readonly HmsContext context;
    
    public DepartmentDal(HmsContext context)
    {
        this.context = context;
    }
    
    public async Task<bool> DeleteById(int id)
    {
        EntityEntry<Department> department = context.Departments.Attach(new Department { Id = id });
        department.State = EntityState.Deleted;
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteDepartments(List<int> departmentIds)
    {
        List<Department> departments = await context.Departments.Where(x=> departmentIds.Contains(x.Id)).ToListAsync();
        if (departments != null && departmentIds.Any())
        {
            context.Departments.RemoveRange(departments);
        }
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<Department?> GetById(int id) => await context.Departments.FindAsync(id);

    public async Task<List<Department>> GetList() => await context.Departments.ToListAsync();
    
    public async Task<bool> SaveUpdate(Department record)
    {
        if (record.Id > 0)
        {
            Department? existingDepartment = await context.Departments.FindAsync(record.Id);
            if (existingDepartment != null)
            {
                existingDepartment.Name = record.Name;
                existingDepartment.ModifiedById = record.ModifiedById;
                existingDepartment.DateModified = DateTime.Now;
            }
        }
        else
        {
            record.DateCreated = DateTime.Now;
            record.DateModified = DateTime.Now;
            await context.Departments.AddAsync(record);
        }
        return await context.SaveChangesAsync() > 0;
    }
}
