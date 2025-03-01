using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Post
    {
        private int _id;
        private int _likes;
        private int _disLikes;
        private string text;


        public Post(int id, int likes, int disLikes, string text)
        {
            _id = id;
            _likes = likes;
            _disLikes = disLikes;
            this.text = text;
        }

        public static int operator+(Post a, int likesCount)
        {
            a._likes += likesCount;
            return a._likes;
        }
        public static int operator -(Post a, int dislikesCount)
        {
            a._disLikes += dislikesCount;
            return a._disLikes;
        }
        public static int operator ++(Post a)
        {
            a._likes += 1;
            return a._likes;
        }
        public static int operator --(Post a)
        {
            a._disLikes += 1;
            return a._disLikes;
        }

        public bool IsRecommend()
        {
            return _likes / _disLikes >= 2;
        }
    }
}
