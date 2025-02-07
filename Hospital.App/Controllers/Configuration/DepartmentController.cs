using Hospital.App.Models.Configurations;
using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Hospital.App.Controllers.Configuration;

[Route("api/[controller]/[action]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly IDepartment departmentDal;
    public DepartmentController(IDepartment department)
    {
        departmentDal = department;
    }

    [HttpGet]
    public async Task<IActionResult> GetDepartments()
    {
        List<Department> departments = await departmentDal.GetList();
        List<DepartmentModel> models = new();
        foreach (Department item in departments)
        {
            models.Add(new()
            {
                Id = item.Id,
                Name = item.Name,
            });
        }
        return Ok(models);
    }

    [HttpGet]
    public async Task<IActionResult> GetDepartment(int departmentId)
    {
        Department? department = await departmentDal.GetById(departmentId);
        DepartmentModel model = new();
        if (department != null)
        {
            model.Id = department.Id;
            model.Name = department.Name;
        }
        return Ok(model);
    }

    [HttpPost]
    public async Task<IActionResult> SaveDepartment(Department department)
    {
        return Ok(await departmentDal.SaveUpdate(department));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteDeaprment(int departmentId)
    {
        return Ok(await departmentDal.DeleteById(departmentId));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteDeaprments(List<int> departmentIds)
    {
        return Ok(await departmentDal.DeleteDepartments(departmentIds));
    }

}
