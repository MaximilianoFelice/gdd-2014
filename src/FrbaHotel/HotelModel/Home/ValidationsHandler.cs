using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HotelModel.Home
{
    public class ValidationsHandler
    {
        Boolean noErrors;

        public Boolean validateDecimal(String aString){
            try
            {
                Decimal numDecimal = Decimal.Parse(aString);
                noErrors = true;

            }
            catch (Exception e)
            {
                noErrors = false;
            }

            return noErrors;
        }

        public Boolean validateInt32(String aString){
            try
            {
                Int32 numDecimal = Int32.Parse(aString);
                noErrors = true;

            }
            catch (Exception e)
            {
                noErrors = false;
            }

            return noErrors;
        }

        public Boolean validateFloat(String aString)
        {
            try
            {
                float numFloat = float.Parse(aString);
                noErrors = true;

            }
            catch (Exception e)
            {
                noErrors = false;
            }

            return noErrors;
        }


        public Boolean validateNullString(String aString){
           
            if(aString.Trim().Length ==0){
                noErrors=false;
             }else{
                 noErrors = true;
             }
           return noErrors;

            
        }

        public Boolean validateDateTime(String aString) {
            try
            {
                DateTime aDate = DateTime.Parse(aString);
                noErrors = true;

            }
            catch (Exception e)
            {
                noErrors = false;
            }

            return noErrors;
        
        }


        public Boolean validatePhoneFormat(String aString) {

            Match m = Regex.Match(aString, @"\(\d{3}\)\s\d{3}-\d{4}$");

            if (!m.Success)
            {
                noErrors = true;
            }
            else
            {
                noErrors = false;
            }

            return noErrors;
        
        }


    }
}
