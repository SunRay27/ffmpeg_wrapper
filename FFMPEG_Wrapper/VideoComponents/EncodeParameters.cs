using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMPEG_Wrapper.VideoComponents
{

    public enum VideoCodec { H264, H264_amd, H264_nvenc, H264_intel_qsv, H265, H265_nvenc, H265_amd, H265_intel_qsv, VP8, VP9, Copy };
    public enum AudioCodec { Copy, Vorbis, WavPack, MP3, Remove };
    public enum Preset { none, ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow };
    public enum OutExtension { mp4, mkv };

    public class EncodeParameters
    {

        string inputPath;
        string outputFolder = "";
        string outputName = "";
        string outputPath = "";
        OutExtension extention = OutExtension.mp4;

        float bitrate = -1;
        int width;
        int height;
        bool horizontalFlip = false;
        bool verticalFlip = false;
        bool saveAspect = false;

        VideoCodec videoCodec = VideoCodec.Copy;
        AudioCodec audioCodec = AudioCodec.Copy;
        Preset preset = Preset.medium;

        public string InputPath => inputPath;
        public string OutputFolder => outputFolder;
        public string OutputName => outputName;
        public string OutputPath => outputPath;
        public OutExtension Extension => extention;
        public float Bitrate => bitrate;
        public int Width => width;
        public int Height => height;
        public bool HorizontalFlip => horizontalFlip;
        public bool VerticalFlip => verticalFlip;
        public bool SaveAspectRatio => saveAspect;
        public VideoCodec VideoCodec => videoCodec;
        public AudioCodec AudioCodec => audioCodec;
        public Preset Preset => preset;


        public EncodeParameters(string inputPath, string outputFolder, string outputName, VideoCodec videoCodec, AudioCodec audioCodec, Preset preset, OutExtension extention, float bitrate, int width, int height, bool horizontalFlip, bool verticalFlip, bool saveAspect)
        {
            this.inputPath = inputPath;
            this.outputFolder = outputFolder;
            this.outputName = outputName;
            this.videoCodec = videoCodec;
            this.audioCodec = audioCodec;
            this.preset = preset;
            this.extention = extention;
            this.bitrate = bitrate;
            this.width = width;
            this.height = height;
            this.horizontalFlip = horizontalFlip;
            this.verticalFlip = verticalFlip;
            this.saveAspect = saveAspect;

            this.outputPath = $@"{outputFolder}\{outputName}.{extention}";

        }


        public static string VideoCodecAsString(VideoCodec codec)
        {
            string videoCodec;
            switch (codec)
            {
                case VideoCodec.H264:
                    videoCodec = "libx264";
                    break;
                case VideoCodec.H264_amd:
                    videoCodec = "h264_amf";
                    break;
                case VideoCodec.H264_nvenc:
                    videoCodec = "h264_nvenc";
                    break;
                case VideoCodec.H264_intel_qsv:
                    videoCodec = "h264_qsv";
                    break;
                case VideoCodec.H265:
                    videoCodec = "libx265";
                    break;
                case VideoCodec.H265_nvenc:
                    videoCodec = "hevc_nvenc";
                    break;
                case VideoCodec.H265_amd:
                    videoCodec = "hevc_amf";
                    break;
                case VideoCodec.H265_intel_qsv:
                    videoCodec = "hevc_qsv";
                    break;
                case VideoCodec.VP8:
                    videoCodec = "libvpx";
                    break;
                case VideoCodec.VP9:
                    videoCodec = "libvpx-vp9";
                    break;
                case VideoCodec.Copy:
                    videoCodec = "copy";
                    break;
                default:
                    videoCodec = "copy";
                    break;
            }
            return videoCodec;

        }
        public static string AudioCodecAsString(AudioCodec codec)
        {
            string audioCodec;
            switch (codec)
            {
                case AudioCodec.Copy:
                     audioCodec = "copy";
                    break;
                case AudioCodec.MP3:
                    audioCodec = "libmp3lame";
                    break;
                case AudioCodec.Vorbis:
                    audioCodec = "libvorbis";
                    break;
                case AudioCodec.WavPack:
                    audioCodec = "wavpack";
                    break;
                case AudioCodec.Remove:
                    audioCodec = "none";
                    break;
                default:
                    audioCodec = "none";
                    break;
            }
            return audioCodec;
        }
        public static string PresetAsString(Preset preset)
        {
            return preset.ToString();
        }
    }

}
