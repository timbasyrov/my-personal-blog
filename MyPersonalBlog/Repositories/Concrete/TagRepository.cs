﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPersonalBlog.Models;
using System.Data.Entity;

namespace MyPersonalBlog.Repositories
{
    public class TagRepository : ITagRepository
    {
        private BlogContext _db = new BlogContext();

        public IEnumerable<Tag> Tags
        {
            get
            {
                return _db.Tags;
            }
        }

        public Tag GetById(int id)
        {
            return _db.Tags
                .Where(t => t.Id == id)
                .FirstOrDefault();
        }

        public void Save(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Tag Delete(int tagId)
        {
            throw new NotImplementedException();
        }
    }
}