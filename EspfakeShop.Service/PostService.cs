using EspfakeShop.Data.Infrastructure;
using EspfakeShop.Data.Repositories;
using EspfakeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspfakeShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChanges();

    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitRepository;
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitRepository = unitOfWork;

        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] {"PostCategory" });
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            //todo : select all by post tag
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitRepository.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
