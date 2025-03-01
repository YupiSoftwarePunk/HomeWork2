using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Recomendations
    {
        public static bool Recommend(Post a)
        {
            return a.IsRecommend();
        }
    }
}
