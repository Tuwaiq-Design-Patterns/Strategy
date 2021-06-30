using System;

namespace Strategy
{

    public interface ICompression
    {
        void CompressFolder(string compressedFileName);
    }

    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedFileName)
        {
            Console.WriteLine("Folder is compressed using rar Strategy: '" + compressedFileName
                 + ".rar' file is created");
        }
    }

    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedFileName)
        {
            Console.WriteLine("Folder is compressed using zip Strategy: '" + compressedFileName
                 + ".zip' file is created");
        }
    }

    public class CompressionContext
    {
        private ICompression Compression;

        public CompressionContext(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void Create(string compressedFileName)
        {
            Compression.CompressFolder(compressedFileName);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            CompressionContext con = new CompressionContext(new ZipCompression());
            con.Create("DesignPattern-Strategy");
            con.SetStrategy(new RarCompression());
            con.Create("DesignPattern-Strategy");
        }
    }
}
