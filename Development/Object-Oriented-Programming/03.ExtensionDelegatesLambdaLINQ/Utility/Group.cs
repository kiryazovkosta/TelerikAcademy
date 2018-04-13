namespace Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Group
    {
        private readonly int groupNumber;
        private readonly string departmentName;

        public Group(int groupNumberParam, string departmentNameParam)
        {
            if (groupNumberParam <= 0)
            {
                throw new ArgumentException(nameof(groupNumberParam));
            }

            if (string.IsNullOrWhiteSpace(departmentNameParam) || departmentNameParam.Length < 0)
            {
                throw new ArgumentException(nameof(departmentNameParam));
            }

            this.groupNumber = groupNumberParam;
            this.departmentName = departmentNameParam;
        }

        public int GroupNumber => this.groupNumber;

        public string DepartmentName => this.departmentName;
    }
}
