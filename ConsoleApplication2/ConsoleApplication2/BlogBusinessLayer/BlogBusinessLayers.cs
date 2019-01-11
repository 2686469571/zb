using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Models;
using ConsoleApplication2.DataAccessLayer;
using System.Data.Entity;

namespace ConsoleApplication2.BlogBusinessLayer
{
   public class BlogBusinessLayers
    {
        public void Add(Blog blog)
        {
            //设置上下文生存期
            using (var db=new BloggingContext())
            {
                //向上下文blogs数据集添加一个实体（改写实体状态为添加）
                db.Blogs.Add(blog);            
                //保存状态改变
                db.SaveChanges();
            }
        }
        public void pAdd(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }
        public List<Blog> Query()
        {
            //设置上下文生存期
            using (var db = new BloggingContext())
            {
                //将数据集转换为列表
                return db.Blogs.ToList();
            }
        }
        public Blog Query(int id)
        {
            using (var db =new BloggingContext())
            {
                return db.Blogs.Find(id);
            }
        }

        public List<Blog> Query(string name)
        {
            using (var db = new BloggingContext())
            {
                // 查询所有包含字符串name的博客
                var blogs = from b in db.Blogs
                            where b.Name.Contains(name)
                            select b;
                return blogs.ToList();
            }
        }


        public void Upddte(Blog blog)
        {   
            //设置上下文生存期
            using (var db = new BloggingContext())
            {
                //将数据集转换为列表
                db.Entry(blog).State = EntityState.Modified;
                      db.SaveChanges();
               
               
            }
        }
        public void Delete(Blog blog)
        {
            //设置上下文生存期
            using (var db = new BloggingContext())
            {
                //修改博客状态
                db.Entry(blog).State = EntityState.Deleted;
                //保存状态
                db.SaveChanges();
               
            }
        }
        public void Deletej(Post post)
        {
            //设置上下文生存期
            using (var db = new BloggingContext())
            {
                //修改博客状态
                db.Entry(post).State = EntityState.Deleted;
                //保存状态         
                db.SaveChanges();

            }
        }


    }
}
