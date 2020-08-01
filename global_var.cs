using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2sem_Project
{
    class global_var
    {
        private static string glob_user_name = "";
        public static string glob_user_N
        {
            get
            {
                return glob_user_name;
            }
            set
            {
                glob_user_name = value;
            }
        }
        private static string glob_user_post = "";
        public static string glob_user_p
        {
            get
            {
                return glob_user_post;
            }
            set
            {
                glob_user_post = value;
            }
        }
    }
}
