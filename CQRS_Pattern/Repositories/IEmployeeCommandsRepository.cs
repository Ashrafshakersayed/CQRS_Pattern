using CQRS_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Repositories
{
    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }
} 

