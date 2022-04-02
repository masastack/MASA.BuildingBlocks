using Masa.BuildingBlocks.BasicAbility.Pm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa.BuildingBlocks.BasicAbility.Pm
{
    public interface IPmCaching
    {
        Task<List<ProjectModel>> GetProjectListAsync(string envName);
    }
}
