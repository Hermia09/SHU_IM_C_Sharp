using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Huang0045.HelperFunction
{
    public class FunctionUsingLIQNorList
    {
        public double findAverage4List(List<double> _listData)
        {
            double total = 0.0;
            foreach (double value in _listData)
                total += value;

            return (double)total / _listData.Count;
        }//end double findAverage4List

        public double findLowest(List<double> _listData)
        {
            double lowestValue = _listData[0];
            for (int count = 1; count < _listData.Count; count++)
            {
                if (_listData[count] < lowestValue)
                {
                    lowestValue = _listData[count];
                }
            }
            return lowestValue;
        }//end double findLowest

        public double findHighest(List<double> _listData)
        {
            double highestValue = _listData[0];
            for (int count = 1; count < _listData.Count; count++)
            {
                if (_listData[count] > highestValue)
                {
                    highestValue = _listData[count];
                }
            }
            return highestValue;
        }//end double findHighest

        public static int finAmountBelowThresholdUsingList(List<double> _listData, double thresholdValue, bool flag4NO)
        {
            int numBelow = 0;
            for (int count = 0; count < _listData.Count; count++)
            {

                if (flag4NO ? (_listData[count] <= thresholdValue) : (_listData[count] < thresholdValue))
                {
                    numBelow++;
                }
            }
            return numBelow;
        }//end static int finAmountBelowThresholdUsingList

        public static int finAmountAboveThresholdUsingList(List<double> _listData, double thresholdValue, bool flag4PO)//flag4NO<=0
        {
            int numAbove = 0;
            for (int count = 0; count < _listData.Count; count++)
            {

                if (flag4PO ? (_listData[count] >= thresholdValue) : (_listData[count] > thresholdValue))
                {
                    numAbove++;
                }
            }
            return numAbove;
        }//end finAmountUpThresholdUsingArray

        public static IEnumerable<double> LINQ_DoubleListSortedByDesending(List<double> _listData)
        {
            var sortFilter =
               from value in _listData   // data source is LINQ query filtered
               orderby value descending//由大到小
               select value;
            return sortFilter;
        }//end sortFilter

        public static IEnumerable<double> LINQ_DoubleListSortedByAsending(List<double> _listData)
        {
            var sortFilter =
               from value in _listData   // data source is LINQ query filtered
               orderby value ascending
               select value;
            return sortFilter;
        }//end sortFilter

        public static IEnumerable<double> setRange(List<double> _listData, double _upperLimt, double _lowerLimit)
        {
            // filter a range of salaries using && in a LINQ query
            var rangeSelect =
               from data in _listData
               where (data >= _lowerLimit) && (data <= _upperLimt)
               select data;
            return rangeSelect;
        }//end static rangeSelect

    }// end of class FunctionUsingLIQNorList
}// end of namespace ClassLibrary_Huang0045.HelperFunction
