using NHibernate.Linq;
using SimpleBlog.Infrastructure;
using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SimpleBlog.ViewModels
{
    //public class PostsIndex
    //{
    //    private const int PostsPerPage = 10;
    //    public ActionResult Index(int page = 1)
    //    {
    //        var baseQuery = Database.Session.Query<Post>().Where(t => t.DeletedAt == null).OrderByDescending(t => t.CreatedAt);

    //        var totalPostCount = baseQuery.Count();
    //        var postIds = baseQuery.Skip((page - 1) * PostsPerPage).Take(PostsPerPage).Select(t => t.Id).ToArray();
    //        var posts = baseQuery.Where(t => postIds.Contains(t.Id)).FetchMany(t => t.Tags).Fetch(t => t.User).ToList();

    //        return View(new PostsIndex
    //        {
    //            Posts = new PagedData<Post>(posts, totalPostCount, page, PostsPerPage)
    //        });
    //    }
    //}

    public class PostsIndex
    {
        public PagedData<Post> Posts { get; set; }
    }

    public class PostsShow
    {
        public Post Post { get; set; }
    }

    public class PostsTag
    {
        public Tag Tag { get; set; }
        public PagedData<Post> Posts { get; set; }
    }
}