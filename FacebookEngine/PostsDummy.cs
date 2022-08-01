using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookEngine
{
    public class PostsDummy
    {
        public string Message { get; }

        public DateTime DatePosted { get; }

        public PostsDummy()
        {
            Message = RandomGenerator.GetRandomFromType("Post");
            DatePosted = RandomGenerator.GenerateRandomDateTime();
        }

        public PostsDummy(string i_Message, DateTime i_DatePosted)
        {
            Message = i_Message;
            DatePosted = i_DatePosted;
        }

        public static List<PostsDummy> GenerateDummyPosts()
        {
            List<PostsDummy> postsDummy = new List<PostsDummy>();
            Random random = new Random(DateTime.Now.Second);
            int numberOfElements = random.Next(1, 10);
            for(int i = 0; i < numberOfElements; i++)
            {
                postsDummy.Add(new PostsDummy());
            }

            return postsDummy;
        }
    }
}
