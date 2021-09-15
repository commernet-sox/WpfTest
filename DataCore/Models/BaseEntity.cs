using Caliburn.Micro;
using CPC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCore.Models
{
    public class BaseEntity : PropertyChangedBase, IMapEntity
    {
        private int id;
        private DateTime createTime;
        private string createBy;
        private DateTime? modifyTime;
        private string modifyBy;
        private bool isDeleted;
        /// <summary>
        /// 主键自增ID
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id
        {
            get => this.id;
            set { this.id = value;  }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime
        {
            get => this.createTime;
            set { this.createTime = value; NotifyOfPropertyChange(() => CreateTime); }
        }

        /// <summary>
        /// 创建人
        /// </summary>
        [MaxLength(30), Required]
        public virtual string CreateBy
        {
            get => this.createBy;
            set { this.createBy = value; NotifyOfPropertyChange(() => CreateBy); }
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? ModifyTime
        {
            get => this.modifyTime;
            set { this.modifyTime = value; NotifyOfPropertyChange(() => ModifyTime); }
        }

        /// <summary>
        /// 修改人
        /// </summary>
        [MaxLength(30)]
        public virtual string ModifyBy
        {
            get => this.modifyBy;
            set { this.modifyBy = value; NotifyOfPropertyChange(() => ModifyBy); }
        }

        /// <summary>
        /// 是否数据已删除
        /// </summary>
        public virtual bool IsDeleted
        {
            get => this.isDeleted;
            set { this.isDeleted = value; NotifyOfPropertyChange(() => IsDeleted); }
        }
    }
}
