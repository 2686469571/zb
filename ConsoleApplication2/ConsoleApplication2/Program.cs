using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Models;
using ConsoleApplication2.BlogBusinessLayer;
using ConsoleApplication2.DataAccessLayer;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个新的博客
            //createBlog();
            ////显示所有博客
            //QueryBlog();

            ////更新所有博客
            //Update();
            ////根据ID删除博客
            //Delete();
            ////显示所有博客
            //QueryBlog();


            //帖子
            //AddPost();
            //int bol = GetBlogId();
            //DeleteT(bol);

            //QueryABlog(name);

            A();

            Console.WriteLine("按任意键退出");
            Console.ReadKey();
           

        }
        static void AddPost()
        {           
            //显示博客列表
             //QueryBlog();
            //用户选择某个博客（id）
            int blogId=  GetBlogId();
            //显示指定博客的帖子列表         
            DisplataPosts(blogId);
            //根据指定到博客信息创建新帖子      
            PostBuID(blogId);
            //显示指定博客的帖子列表
        }

        static void PostBuID(int blogId)
        {
            Console.WriteLine("请输入一个帖子名称");
            string title = Console.ReadLine();
            Console.WriteLine("请输入一个帖子的内容");
            string content = Console.ReadLine();

            Post post = new Post();
            post.BlogId = blogId;
            post.Title = title;
            post.Content = content;
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            bbl.pAdd(post);
            DisplataPosts(blogId);
        }
        static int GetBlogId()
        {
            //提示用户输入博客ID
            Console.WriteLine("请输入id");
            // 获取 用户输入，并存入变量ID
            int id = int.Parse(Console.ReadLine());

            return id;
            //BlogBusinessLayers bbl = new BlogBusinessLayers();
            //Console.WriteLine("请选择某个博客ID");
            //int id = int.Parse(Console.ReadLine());
            //Blog blog = bbl.Query(id);

        }

        static void DisplataPosts(int blogId)
        {
          
            Console.WriteLine(blogId + "的帖子列表");
            List<Post> list = null;
            //BlogBusinessLayers bbl = new BlogBusinessLayers();
            //var blog = bbl.Query(blogId);
            //Console.WriteLine(blog.Name);
            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(blogId);
                //根据博客导航，获取所有该博客的帖子
                list = blog.Posts;
            }
            //遍历所有帖子，显示帖子标题（博客号-帖子标题）
            foreach (var item in list )
            {
                Console.WriteLine("博客ID：" + item.Blog.BlogId + "           帖子ID：" + item.PostId + "    帖子内容:" + item.Title);
                //Console.WriteLine("帖子："+item.Title + "    帖子内容" + item.Content);
            }
        }
        
        static void DeleteT(int bol)
        {       
            BlogBusinessLayers bbl = new BlogBusinessLayers();

            Console.WriteLine("请输入所需要删除帖子的博客的ID");

            List<Post> list = null;
            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(bol);
                //根据博客导航，获取所有该博客的帖子
                list = blog.Posts;
            }
            foreach (var item in list)
            {
                Console.WriteLine("博客ID："+item.Blog.BlogId+ "           帖子ID：" + item.PostId+ "    帖子内容:" + item.Title);             
            }
            // 获取 用户输入，并存入变量ID
            int id = int.Parse(Console.ReadLine());

            Post blg = new Post();
            blg.PostId = id;
            //调用 写在BlogBusinessLayers里的方法
            bbl.Deletej(blg);
            //显示该ID的博客所有帖子
            DisplataPosts(bol);

        }



        static void createBlog()
        {
            Console.WriteLine("请输入一个博客名称！");
            string name = Console.ReadLine();
        
            Blog bolg = new Blog();
            bolg.Name = name;
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            bbl.Add(bolg);

        }

        //显示全部博客
        static void QueryBlog()
        {
  
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            var blogs = bbl.Query();
            
            foreach (var item in blogs)
            {
                Console.WriteLine(item.BlogId + "" + item.Name);
            }
        }
        static void Update()
        {
            BlogBusinessLayers bbl =new BlogBusinessLayers();
            Console.WriteLine("请输入所更改的ID");
            int id = int.Parse(Console.ReadLine());
          
            Blog blog = bbl.Query(id);
            Console.WriteLine("请重新输入名字");
            string name = Console.ReadLine();
            blog.Name = name;
            bbl.Upddte(blog);
        }
        static void Delete()
        {
            BlogBusinessLayers bbl = new BlogBusinessLayers();
            Console.WriteLine("请输入所需要删除博客的ID");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            bbl.Delete(blog);

        }



        static void A()
        {
            //显示所有博客
            QueryBlog();
            Console.WriteLine("--1-退出 --2-新增博客   --3-更改博客  --4-删除博客  --5-删除帖子 --6-增加帖子");
            Console.WriteLine("请输入操作指令");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                return;
            }

            else if (i == 2)
            {
                createBlog();
                QueryBlog();
                Console.Clear();
                A();
            }
            else if (i == 3)
            {
                Update();
                QueryBlog();
                Console.Clear();
                A();
            }
            else if (i == 4)
            {
                Delete();
                QueryBlog();
                Console.Clear();
                A();
            }
            else if (i == 5)
            {
                int bol = GetBlogId();
                //int bol = GetBlogId();
                //显示指定博客的帖子列表
                DeleteT(bol);
                Console.Clear();
                A();
            }
            else if (i == 6)
            {
                int bol = GetBlogId();
         
                PostBuID(bol);
                xian(bol);
                //Console.Clear();
                return;
            }
            else
            {
                Console.WriteLine("无效字符");
            }
        }
        
      

        static void xian(int bol)
        {
            List<Post> list = null;
            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(bol);
                //根据博客导航，获取所有该博客的帖子
                list = blog.Posts;
            }
            foreach (var item in list)
            {
                Console.WriteLine("博客ID：" + item.Blog.BlogId + "           帖子ID：" + item.PostId + "    帖子内容:" + item.Title);
            }
        }

       static void sjh()
        {
            Console.WriteLine("输入一个博客名称！");

        }

    }
}
