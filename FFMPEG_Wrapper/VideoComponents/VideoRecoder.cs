using FFMPEG_Wrapper.Forms.MainWindow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFMPEG_Wrapper.VideoComponents
{
    public class VideoRecoder : VideoProcess
    {
        float bitRate = 0;

        string videoCodec = String.Empty;
        string audioCodec = String.Empty;
        string preset = String.Empty;

        int targetWidth;
        int targetHeight;

        string flipAddon = string.Empty;

        public EncodeParameters EncodeParameters => encodeParameters;
        EncodeParameters encodeParameters;

        public VideoRecoder(EncodeParameters parameters)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            encodeParameters = parameters;
            outputPath = parameters.OutputPath;
            bitRate = parameters.Bitrate;
            targetHeight = parameters.Height;
            targetWidth = parameters.Width;




            videoCodec = EncodeParameters.VideoCodecAsString(parameters.VideoCodec);
            audioCodec = EncodeParameters.AudioCodecAsString(parameters.AudioCodec);
            preset = EncodeParameters.PresetAsString(parameters.Preset);


            command = $"-i \"{parameters.InputPath}\" -c:v {videoCodec}";



            if (parameters.SaveAspectRatio)
            {
                if (parameters.HorizontalFlip && parameters.VerticalFlip)
                    flipAddon = "hflip,vflip,";
                else if (parameters.HorizontalFlip)
                    flipAddon = "hflip,";
                else if (parameters.VerticalFlip)
                    flipAddon = "vflip,";

                if (bitRate > 0)
                    command += $" -vf \"{flipAddon} scale={targetWidth}:{targetHeight}:force_original_aspect_ratio=decrease,pad={targetWidth}:{targetHeight}:(ow-iw)/2:(oh-ih)/2\" -b:v {bitRate}M";
                else
                    command += $" -vf \"{flipAddon} scale={targetWidth}:{targetHeight}:force_original_aspect_ratio=decrease,pad={targetWidth}:{targetHeight}:(ow-iw)/2:(oh-ih)/2\"";
            }
            else
            {
                if (parameters.HorizontalFlip && parameters.VerticalFlip)
                    flipAddon = "hflip,vflip,";
                else if (parameters.HorizontalFlip)
                    flipAddon = "hflip,";
                else if (parameters.VerticalFlip)
                    flipAddon = "vflip,";

                if (bitRate > 0)
                    command += $" -vf \"{flipAddon} scale={targetWidth}:{targetHeight},setsar=1\" -b:v {bitRate}M";
                else
                    command += $" -vf \"{flipAddon} scale={targetWidth}:{targetHeight},setsar=1\"";
            }


            if (preset == "none")
            {
                if (audioCodec != "none")
                    command += $" -c:a {audioCodec} \"{outputPath}\"";
                else
                    command += $" -an \"{outputPath}\"";
            }
            else
            {
                if (audioCodec != "none")
                    command += $" -c:a {audioCodec} -preset {preset} \"{outputPath}\"";
                else
                    command += $" -an -preset {preset} \"{outputPath}\"";
            }
        }

        
    }
}
