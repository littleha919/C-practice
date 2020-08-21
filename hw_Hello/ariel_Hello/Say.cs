using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariel_Hello
{
    class Say
    {
        public string name;
        public string english;
        public string gender;
        public string constell;

        public string greet()
        {
            return ",我是" + name + ","
                + "\n英文名字是 " + english + ","
                + "\n性別是" + gender + ","
                + "\n星座是" + constell + ","
                + "\n很高興認識你。";
        }
    }


}
