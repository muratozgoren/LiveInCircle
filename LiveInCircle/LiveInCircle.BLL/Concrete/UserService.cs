using LiveInCircle.BLL.Abstract;
using LiveInCircle.DAL.Abstract;
using LiveInCircle.Model.Entities;
using LiveInCircle.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL userDAL;
        public UserService(IUserDAL dal)
        {
            userDAL = dal;
        }

        void Check(User user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.Address))
            {
                throw new Exception("Değer boş geçilemez.");
            }
        }

        public void Insert(User entity)
        {
            Check(entity);
            entity.Role = UserRole.Standart;
            entity.ActivationCode = Guid.NewGuid();
            userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            Check(entity);
            userDAL.Update(entity);
        }
        public void Delete(User entity)
        {
            entity.IsActive = false;
            userDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            User user = Get(entityID);
            user.IsActive = false;
            userDAL.Update(user);
        }

        public User Get(int entityID)
        {
            return userDAL.Get(a => a.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return userDAL.GetAll();
        }

        public User GetUserByActivationCode(Guid guid)
        {

            User newUser = userDAL.Get(a => a.ActivationCode == guid);
            return newUser;
        }
        public User GetUserByLoginData(string mail, string password)
        {

            User loginUser = userDAL.Get(a => a.IsActive && a.Email == mail && a.Password == password);
            return loginUser;
        }
    }
}
