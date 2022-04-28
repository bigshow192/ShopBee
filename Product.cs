using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webbanhang
{
    public class Product
    {
        private String name;
        private int category;
        private int price;
        private String des1, des2, des3;
        private String Image;
        public Product()
        {
        }
        public Product(string name, int category, int price, string des1, string des2, string des3, string image)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.des1 = des1;
            this.des2 = des2;
            this.des3 = des3;
            this.Image = image;
        }
         public int getCategory()
        {
        return this.category;
        }
        public String getName()
        {
            return this.name;
        }
        public int getprice()
        {
            return this.price;
        }
        public String theloai()
        {
            int k = this.category;
            if (k == 1) return ("Thời trang nam");
            else if (k == 2) return ("Thời trang nữ");
            else if (k == 3) return ("Điện thoại và phụ kiện");
            else if (k == 4) return ("Mẹ và bé");
            else if (k == 5) return ("Thiết bị điện tử");
            else if (k == 6) return ("Nhà cửa và đời sống");
            else if (k == 7) return ("Máy tính và laptop");
            else return ("Sắc đẹp");
        }
       public String getImage()
        {
            return this.Image;
        }

    }
}
