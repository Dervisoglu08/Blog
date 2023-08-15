using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public abstract class EntityBase: IEntityBase //IEntityBase'den kalıtım al dedik.
    {
       
        public virtual Guid Id { get; set; }= Guid.NewGuid();
        public virtual string CreateBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }= DateTime.Now; //
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; }=false; //silinmemiş olarak gelecek.

    }
}
