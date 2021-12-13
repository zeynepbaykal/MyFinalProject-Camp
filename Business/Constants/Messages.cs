﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static vermemizin sebebi new'lemeye gerek kalmaması için.
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün eklenmedi,isim geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductListed="ürünler listelendi";
        public static string ProductCountOfCategoryAdded="bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Aynı isimde iki ürün olamaz.";
    }
}
