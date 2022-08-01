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
            Message =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            DatePosted = new DateTime(2022, 5, 11);
        }

        public PostsDummy(string i_Message, DateTime i_DatePosted)
        {
            Message = i_Message;
            DatePosted = i_DatePosted;
        }

        public static List<PostsDummy> GenerateDummyPosts()
        {
            List<PostsDummy> postsDummy = new List<PostsDummy>();
            var random = new Random();
            int numberOfElements = random.Next(1, 10);
            for(int i = 0; i < numberOfElements; i++)
            {
                postsDummy.Add(new PostsDummy());
            }

            return postsDummy;
        }
    }
}
