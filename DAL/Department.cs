//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Department1 = new HashSet<Department>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string parentid { get; set; }
    
        public virtual ICollection<Department> Department1 { get; set; }
        public virtual Department Department2 { get; set; }
    }
}
