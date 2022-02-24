﻿namespace MedicalStore.Utils.Validator
{
    public class ProductValidator
    {
        public static readonly int PRODUCTNAME_MAX = 300;
        public static readonly int PRODUCTNAME_MIN = 5;
        public static readonly int DESCRIPTION_MAX = 300;
        public static readonly int DESCRIPTION_MIN = 20;
        public static readonly int ORIGINALPRICE_MAX = 999999;
        public static readonly int ORIGINALPRICE_MIN = 4;
        public static readonly int RETAILPRICE_MAX = 999999;
        public static readonly int RETAILPRICE_MIN = 4;
        public static readonly int QUANTITY_MAX = 50;
        public static readonly int QUANTITY_MIN = 1;
        public static readonly int IMAGEURL_MAX = 10000;
        public static readonly int IMAGEURL_MIN = 1;
    }
}
