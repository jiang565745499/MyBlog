using SqlSugar;
using System;

namespace MyBlog.Model
{
    public class BaseId<TKey>
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public TKey Id { get; set; }
    }
}
