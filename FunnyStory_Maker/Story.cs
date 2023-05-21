using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyStory
{
    class Story
    {
        public enum Sex { Men, Women };
        
        public static string ToStringStory(string actor,
                Sex sex,
                string lastTime,
                string unfinishedThing,
                string whyDo,
                string whereDo,
                string whenDo,
                bool isFinished,
                string end)
        {
            string stringSex = sex == Sex.Men ? "他" : "她";
            char thing1stChar = unfinishedThing[0];
            string stringIsFinished = isFinished ? $"{thing1stChar}完了" : $"没{thing1stChar}完";

            return $"从前有一个{actor}，{stringSex}已经{lastTime}没{unfinishedThing}了。有一天，" +
                $"{stringSex + whyDo}，连忙来到{whereDo}，就开始{unfinishedThing}，{thing1stChar}啊{thing1stChar}，" +
                $"{thing1stChar}了{whenDo}，最后{stringSex}还是{stringIsFinished}，" +
                end + "。";
        }
    }
}
