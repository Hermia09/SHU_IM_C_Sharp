using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_Huang0045.HelperFunction;

namespace ClassLibrary_Huang0045.HelperFunction.InputCheckValidation_Huang0045
{
    public class DataCheckValidation_Huang0045
    {
        public bool CONSOLE_ON { get; set; }
        public bool GUI_ON { get; set; }

        public int INT_TYPE = 1, DOUBLE_TYPE = 2;
        public int TYPE_INT = 0;
        public int inputIntValue = 0;
        public double inputValue = 0;
        public double inputDoubleValue = 0;
        public DataCheckValidation_Huang0045(bool consoleOn, bool guiOn) // 以布林參數傳
        {
            CONSOLE_ON = consoleOn;
            GUI_ON = guiOn;
        }//end constrictor with 2 parameters

        public bool checkStringNoEmpty(string stringInput, string keyString)
        {
            var check_S = false;
            var Qes = keyString + "?";
            try
            {
                if (stringInput != string.Empty)
                {
                    check_S = true;
                }
                else
                {
                    //if (CONSOLE_ON) Console.WriteLine("Re-input" + keyString +"(Cannot be Emoty!)");
                    //if (GUI_ON) MessageBox.Show(string.Format("Re-input: \r\n{0}",keyString));
                    throw new Exception("Re-input" + keyString + "(Cannot be Emoty!)");
                }
            }
            catch (Exception)
            {
                if (CONSOLE_ON) Console.WriteLine("Re-input" + keyString + "(Cannot be Emoty!)");
                if (GUI_ON) MessageBox.Show(string.Format("Re-input: \r\n{0}", keyString));
            }
            return check_S;
        }// end of  checkStringNoEmpty function

        /// according  to condidered TYPE_INT (INT_TYPE=1,DOUBLE_INT=2)
        /// 
        public bool checkValueUsingCompare_1flag(string dataInString, string keyString, double thresholdValue, int flagValuePN0, int _typeInt)
        {
            var check_S_NUM = false;
            var caption = "Re-input" + keyString;
            TYPE_INT = _typeInt;
            try
            {
                if (TYPE_INT == INT_TYPE)
                {
                    inputIntValue = int.Parse(dataInString);
                    inputValue = inputIntValue;
                }
                else if (TYPE_INT == DOUBLE_TYPE)
                {
                    inputDoubleValue = double.Parse(dataInString);
                    inputValue = inputDoubleValue;
                }
                if (FunctionsUsedOftenOrArray.compare2Data(inputValue, thresholdValue) == flagValuePN0)
                {
                    check_S_NUM = true;
                }
                else
                {
                    throw new Exception("something wrong with yopur input");
                }
            }
            catch
            {
                if (CONSOLE_ON) Console.WriteLine("Re-input" + keyString + "(Cannot be Emoty!)");
                if (GUI_ON) MessageBox.Show(string.Format("Re-input: \r\n{0}", keyString));
            }

            return check_S_NUM;
        }// end of checkValueUsingCompare_1flag

        //public string checkValueInRange(string data_String, string keyString, double minValue, double maxValue,
        //                                   bool checkFlagMin0, bool checkFlagMax0, int _typeInt)
        //{
        //    var check_S_Num = false;
        //    TYPE_INT = _typeInt;

        //    check_S_Num=

        //    inputValue = 0.0;
        //    return check_S_Num;
        //}

        public string validateValueInRange(string keyString, double minValue, double maxValue,
                                           bool checkFlagMin0, bool checkFlagMax0, int _typeInt) 
        {
            var check_S_Num = false;
            var Qes = keyString + "(between" + minValue +
                            (checkFlagMin0 ? "(>=)" : "(>)") + "and" + maxValue +
                            (checkFlagMax0 ? "(<=)!" : "(<)!") + "?";
            var stringInput = string.Empty;

            while (check_S_Num == false) 
            {
                Console.WriteLine(Qes);
                stringInput = Console.ReadLine();

                //check_S_Num= 
            }
            return stringInput;
        }
        
    }//end class DataCheckValidation_Huang0045
}//end namespace ClassLibrary_Huang0045.HelperFunction.InputCheckValidation_Huang0045