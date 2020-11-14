using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barata_Krisztian_Lab2
{
    class Doughnut
    {

        KeyValuePair<DoughnutType, double>[] PriceList = {
    new KeyValuePair<DoughnutType, double>(DoughnutType.Sugar, 2.5),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Glazed,3),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Chocolate,4.5),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Vanilla,4),
    new KeyValuePair<DoughnutType, double>(DoughnutType.Lemon,3.5)
    };
        private DoughnutType mFlavor;
        private int mRaisedGlazed = 0;
        private int mRaisedSugar = 0;
        private int mFilledLemon = 0;
        private int mFilledChocolate = 0;
        private int mFilledVanilla = 0;
        private double Total = 0;
        private DoughnutType selectedDoughnut;
        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }
            set
            {
                mFlavor = value;
            }
        }
        private float mPrice;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public Doughnut(DoughnutType aFlavor) // constructor
        {
            mFlavor = aFlavor;
        }
    }
}
    public enum DoughnutType
    {
        Glazed,
        Sugar,
        Lemon,
        Chocolate,
        Vanilla
    }

