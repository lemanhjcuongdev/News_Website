using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_News_Website
{
    public class User
    {
        private string taikhoan, matkhau;
        private string role;
        private int id;

        public User(int id, string taikhoan, string matkhau, string role)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.role = role;
            this.id = id;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Taikhoan
        {
            get => taikhoan;
            set => taikhoan = value;
        }

        public string Matkhau
        {
            get => matkhau;
            set => matkhau = value;
        }

        public string Role
        {
            get => role;
            set => role = value;
        }
    }

}