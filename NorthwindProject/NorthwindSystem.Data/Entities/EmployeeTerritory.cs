using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace NorthwindSystem.Data.Entities
{
    [Table("EmployeeTerritories")]
    public class EmployeeTerritory
    {
        [Key]
        public int EmployeeID { get; set; }
        public int TerritoryID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }

    }
}
