using FFMPEG_Wrapper.Forms.MainWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMPEG_Wrapper.VideoComponents
{
    public class ConcatParameters
    {
        List<string> inputPaths;
        string outputFolder = "";
        string outputName = "";
        string outputPath = "";
        OutExtension extention = OutExtension.mp4;

        public List<string> InputPaths => inputPaths;
        public string OutputFolder => outputFolder;
        public string OutputName => outputName;
        public string OutputPath => outputPath;
        public OutExtension Extension => extention;

        public ConcatParameters(List<string> inputPaths, string outputFolder, string outputName, OutExtension extention)
        {
            this.inputPaths = inputPaths;
            this.outputFolder = outputFolder;
            this.outputName = outputName;
            this.extention = extention;
            this.outputPath = $@"{outputFolder}{outputName}.{extention}";
        }
    }

    class VideoConcatenator : VideoProcess
    {
        

        public ConcatParameters ConcatParameters => concatParameters;
        ConcatParameters concatParameters;

        public VideoConcatenator(ConcatParameters parameters)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            concatParameters = parameters;
            outputPath = concatParameters.OutputPath;

            string listPath = $"{FileManager.TempFolderPath}fileList.txt";
            string fileContents = "";

                for (int i = 0; i < parameters.InputPaths.Count; i++)
                fileContents+=($"file \'{parameters.InputPaths[i]}\'\n");

            File.WriteAllText(listPath, fileContents);
            //ffmpeg -f concat -safe 0 -i mylist.txt -c copy output.mp4
           // command = $" -f concat -safe 0 -use_wallclock_as_timestamps 1 -fflags +genpts -i \"{listPath}\" -c copy \"{parameters.OutputPath}\"";
            command = $"-safe 0 -f concat -segment_time_metadata 1 -i \"{listPath}\" -vf select=concatdec_select -af aselect=concatdec_select,aresample=async=1 \"{parameters.OutputPath}\"";


        }

    }
}
