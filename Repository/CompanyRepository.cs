﻿using Contract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        //public Company GetCompany(Guid companyId)
        //{
        //    return FindByCondition(c => c.Id.Equals(companyId))
        //        .FirstOrDefault();
        //}
    }
}