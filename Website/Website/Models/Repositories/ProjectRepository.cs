﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rae.Website.Models.Repositories
{
    public class ProjectRepository : Repository<Project>
    {
        public IQueryable<Project> GetFeatured()
        {
            return dbSet.Where(p => p.IsFeatured);
        }

        public IQueryable<Project> GetByTitle(string Title, bool Exact = true)
        {
            if (Exact)
                return dbSet.Where(p => p.Title.ToLower() == Title.ToLower());
            else
                return dbSet.Where(p => p.Title.ToLower().Contains(Title.ToLower()));
        }

        public IQueryable<Project> GetByCustomer(string Customer, bool Exact = true)
        {
            if (Exact)
                return dbSet.Where(p => p.Customer.ToLower() == Customer.ToLower());
            else
                return dbSet.Where(p => p.Customer.ToLower().Contains(Customer.ToLower()));
        }

        public IQueryable<Project> GetByCategory(string Category)
        {
            string category = Category.ToLower();
            return dbSet.Where(p => p.Categories.ToLower().Contains("," + category)
                || p.Categories.ToLower().Contains(category + ",")
                || p.Categories.ToLower() == category);
        }

        public IQueryable<Project> GetByDescription(string Term)
        {
            return dbSet.Where(p => p.Description.ToLower().Contains(Term.ToLower()));
        }

        public IQueryable<Project> GetByTool(string Tool)
        {
            return dbSet.Where(p => p.Tools.ToLower().Contains(Tool.ToLower()));
        }

        public IQueryable<Project> GetByYear(int Year)
        {
            return dbSet.Where(p => p.Year == Year);
        }

        public IQueryable<Project> GetPreviousProject(int Id)
        {
            return dbSet.Where(p => p.ProjectId < Id).OrderByDescending(p => p.ProjectId).Take(1);
        }

        public IQueryable<Project> GetNextProject(int Id)
        {
            return dbSet.Where(p => p.ProjectId > Id).OrderBy(p => p.ProjectId).Take(1);
        }
    }
}