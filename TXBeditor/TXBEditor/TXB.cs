using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TXBeditor.TXBEditor
{
    internal class TXB
    {
        public class ImageInfo
        {
            public int load_index { get; set; }
            public required byte[] byte_array { get; set; }
        }

        static public List<ImageInfo> LoadFromFile(string file_path)
        {
            List<ImageInfo> image_list = new List<ImageInfo>();

            using (var stream = File.Open(file_path, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {

                    int image_count = reader.ReadInt32();
                    stream.Position += 0x4;

                    for (int i = 0; i < image_count; i++)
                    {
                        int image_id = reader.ReadInt32();
                        int image_offset = reader.ReadInt32();

                        long original_stream_position = stream.Position;

                        //  getting image size
                        int TIM2_size = 0;
                        stream.Position = image_offset + 5;
                        byte TIM2_alignment = reader.ReadByte();

                        if (TIM2_alignment == 1)
                        { // 128 bytes aligned TIM2
                            stream.Position += 0x7A;
                            int size = reader.ReadInt32();
                            TIM2_size = size + 0x80;
                            stream.Position -= 0x84;
                        }
                        else
                        { // 16 bytes aligned, used mostly just on Stands
                            stream.Position += 0xA;
                            int size = reader.ReadInt32();
                            TIM2_size = size + 0x10;
                            stream.Position -= 0x14;
                        }

                        byte[] image_buffer = reader.ReadBytes(TIM2_size);

                        image_list.Add(new ImageInfo()
                        {
                            load_index = image_id,
                            byte_array = image_buffer
                        });

                        stream.Position = original_stream_position;
                    }
                }
            }
            return image_list;
        }

        static public void WriteOutputData(BinaryWriter writer, List<ImageInfo> image_list)
        {
            // TXB header
            int current_offset = 0x200;
            writer.Write(image_list.Count);
            writer.Write(0x0);
            for (int i = 0; i < 63; i++)
            {
                if (i < image_list.Count)
                {
                    ImageInfo current_image = image_list.ElementAt(i);
                    writer.Write(current_image.load_index);
                    writer.Write(current_offset);
                    current_offset += current_image.byte_array.Length;
                }
                else { writer.Write(0x0); writer.Write(0x200); } // padding
            }

            // image array
            foreach (ImageInfo image in image_list) { writer.Write(image.byte_array); }
        }

    }
}
