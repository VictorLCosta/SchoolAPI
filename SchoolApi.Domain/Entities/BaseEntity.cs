using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime? _dateCreated;
        public DateTime? DateCreated 
        { 
            get { return _dateCreated; } 
            set { _dateCreated = value == null ? DateTime.Now : value; } 
        }

        public DateTime? DateUpdated { get; set; }
        
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

    }
}