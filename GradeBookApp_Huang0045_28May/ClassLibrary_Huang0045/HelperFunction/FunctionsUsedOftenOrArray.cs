using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Huang0045.HelperFunction
{
    public class FunctionsUsedOftenOrArray
    {
        public double highestValue = double.MinValue, lowestValue = double.MaxValue;
        public int highestIndex = 0, lowestIndex = 0;
        public double average = 0.0;

        public static int compare2Data(double a, double b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return +1;
            else
                return 0;
        }// end of compare2Data
        public double FindHighest(double[] arrayData)
        {
            highestValue = arrayData[0];
            highestIndex = 0;

            for (int count = 1; count < arrayData.Length; count++)
            {
                if (arrayData[count] > highestValue)
                {
                    highestValue = arrayData[count];
                    highestIndex = count;
                }
            }
            return highestValue;
        }// end of  FindHighes
        public double FindLowest(double[] arrayData)
        {
            lowestValue = arrayData[0];
            lowestIndex = 0;

            for (int count = 1; count < arrayData.Length; count++)
            {
                if (arrayData[count] < lowestValue)
                {
                    lowestValue = arrayData[count];
                    lowestIndex = count;
                }
            }
            return lowestValue;
        }// end of FindLowest
        public double FindAverage(double[] arrayData)
        {
            double total = 0.0;
            double average = 0.0;
            foreach (double value in arrayData)
                total += value;
            average = total / arrayData.Length;
            return average;
        }// end of FindAverage

        public static int findAmountBelowThresholdUsingArray(double[] arrayData, double thresholdValue, bool flag4NO)//flag4NO<=0
        {
            int numBelow = 0;
            for (int count = 0; count < arrayData.Length; count++)
            {

                if (flag4NO ? (arrayData[count] <= thresholdValue) : (arrayData[count] < thresholdValue))
                {
                    numBelow++;
                }
            }
            return numBelow;
        }//end of finAmountBelowThresholdUsingArray
        public static int findAmountAboveThresholdUsingArray(double[] arrayData, double thresholdValue, bool flag4PO)//flag4NO<=0
        {
            int numAbove = 0;
            for (int count = 0; count < arrayData.Length; count++)
            {

                if (flag4PO ? (arrayData[count] >= thresholdValue) : (arrayData[count] > thresholdValue))
                {
                    numAbove++;
                }
            }
            return numAbove;
        }//end of finAmountUpThresholdUsingArray
        public static IEnumerable<double> setRange(double[] arrayData, double _upperLimt, double _lowerLimit)
        {
            // filter a range of salaries using && in a LINQ query
            var rangeSelect =
               from data in arrayData
               where (data >= _lowerLimit) && (data <= _upperLimt)
               select data;
            return rangeSelect;
        }
        public static IEnumerable<double> LINQ_DoubleArraySortedByDesending(double[] arrayData)
        {
            var sortFilter =
               from value in arrayData   // data source is LINQ query filtered
               orderby value descending//由大到小
               select value;
            return sortFilter;
        }
        public static IEnumerable<double> LINQ_DoubleArraySortedByAsending(double[] arrayData)
        {
            var sortFilter =
               from value in arrayData   // data source is LINQ query filtered
               orderby value ascending
               select value;
            return sortFilter;
        }
    }//end class FunctionsUsedOftenOrArray
}//end namespace ClassLibrary_Huang0045.HelperFunction
