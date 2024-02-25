﻿namespace FinancialHub.Common.Domain.Models
{
    public abstract class BaseModel
    {
        public Guid? Id { get; set; }

        protected BaseModel() { }

        protected BaseModel(Guid? id)
        {
            Id = id;
        }
    }
}
