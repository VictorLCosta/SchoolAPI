using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id => Guid.NewGuid();

        private DateTime? _dateCreated;
        public DateTime? DateCreated 
        { 
            get { return _dateCreated; } 
            set { _dateCreated = value == null ? DateTime.Now : value; } 
        }

        public DateTime? DateUpdated { get; set; }
        
    }
}