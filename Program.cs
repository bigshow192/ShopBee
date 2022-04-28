using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
namespace Webbanhang
{

    internal static class Program
    {
        public static Product[] p1 = new Product[24];
        public static int sodu = 10000000;
        public static ListViewItem[] arritem = new ListViewItem[1000];
        public static int lengthitem = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Product[] p = new Product[24];
            p1[0] = new Product("Vouge", 1, 100000, "", "", "", "C:/Users/Administrator/Pictures/Product/vouge.jpg");
            p1[1]=  new Product("Supreme Nam", 1, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/supreme.jpg");
            p1[2] = new Product("Armani", 1, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/armani.jpg");
            p1[3] = new Product("Supreme Nữ", 2, 200000, "", "", "", "C:/Users/Administrator/Pictures/Product/supremenu.jpg");
            p1[4] = new Product("Croptop", 2, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/croptop.jpg");
            p1[5] = new Product("Hoodie", 2, 400000, "", "", "", "C:/Users/Administrator/Pictures/Product/hoodie.jpg");
            p1[6] = new Product("Nokia", 3, 3000000, "", "", "", "C:/Users/Administrator/Pictures/Product/nokia.jpg");
            p1[7] = new Product("Samsung", 3, 4000000, "", "", "", "C:/Users/Administrator/Pictures/Product/samsung.jpg");
            p1[8] = new Product("Iphone", 3, 8000000, "", "", "", "C:/Users/Administrator/Pictures/Product/iphone.jpg");
            p1[9] = new Product("Tả lót", 4, 200000, "", "", "", "C:/Users/Administrator/Pictures/Product/talot.png");
            p1[10] = new Product("Ghế ăn", 4, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/ghean.jpg");
            p1[11] = new Product("Sữa", 4, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/sua.jpg");
            p1[12] = new Product("Nồi cơm điện", 5, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/noicomdien.jpg");
            p1[13] = new Product("Điều hòa", 5, 3000000, "", "", "", "C:/Users/Administrator/Pictures/Product/dieuhoa.jpg");
            p1[14] = new Product("Máy giặt", 5, 1000000, "", "", "", "C:/Users/Administrator/Pictures/Product/maygiat.jpg");
            p1[15] = new Product("Chổi lau nhà", 6, 700000, "", "", "", "C:/Users/Administrator/Pictures/Product/choilaunha.jpg");
            p1[16] = new Product("Nồi Inox", 6, 100000, "", "", "", "C:/Users/Administrator/Pictures/Product/noiinox.jpg");
            p1[17] = new Product("Chảo chống dính", 6, 200000, "", "", "", "C:/Users/Administrator/Pictures/Product/chao.jpg");
            p1[18] = new Product("Laptop Dell", 7, 15000000, "", "", "", "C:/Users/Administrator/Pictures/Product/laptopdell.png");
            p1[19] = new Product("Máy tính gaming", 7, 30000000, "", "", "", "C:/Users/Administrator/Pictures/Product/maytinh.jpg");
            p1[20] = new Product("Laptop Acer", 7, 20000000, "", "", "", "C:/Users/Administrator/Pictures/Product/laptop.png");
            p1[21] = new Product("Son môi", 8, 1500000, "", "", "", "C:/Users/Administrator/Pictures/Product/son.jpg");
            p1[22] = new Product("Kẻ lông mày", 8, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/merzy.jpg");
            p1[23] = new Product("Kem dưỡng da", 8, 300000, "", "", "", "C:/Users/Administrator/Pictures/Product/riori.jpg");
            Application.Run(new Form7());
        }

    }
}
