//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraphicTool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class picture
    { [Key]
        public int painting_id { get; set; }
        public string username { get; set; }
        public byte[] painting { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public string descript { get; set; }
        public string path { get; set; }
        public byte[] bg { get; set; }

        public virtual user user { get; set; }
    }
}
