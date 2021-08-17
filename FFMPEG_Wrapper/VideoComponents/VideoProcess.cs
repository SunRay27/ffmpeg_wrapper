using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMPEG_Wrapper.VideoComponents
{
    public abstract class VideoProcess
    {
        protected string command = "";
        public string Command => command;

        protected string outputPath = "";
        public string OutputPath => outputPath;
    }
}
