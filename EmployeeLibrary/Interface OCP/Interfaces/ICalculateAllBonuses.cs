using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary.Interface_OCP.Interfaces
{
    public interface ICalculateAllBonuses
    {
        decimal CalculateAllBonuses(ICollection<ICalculateBonus> employees);
    }
}
