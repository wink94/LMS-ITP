using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace LabManagement.Controllers
{
    class Validation
    {
        private Dictionary<string,string> errmsg = new Dictionary<string, string> {
            {"alphaVal","" },{"numberVal","" },{"emailVal","" },{"IsNumeric","" },{"alphaNumericVal","" } };

        /* letters only!! validation*/

        public bool alphaVal(string val)
        {
            string pattern = @"^[A-Za-z\s]+$";
            Match m = Regex.Match(val, pattern);
            string errormsg_alphaVal;

            if (!m.Success || val.Length > 45)
            {
                errormsg_alphaVal = "invalid entry only letters are allowed.!" + "\n";
                errmsg["alphaVal"]= errormsg_alphaVal;
                return false;
            }
            else
            {
                errormsg_alphaVal = "";
                errmsg["alphaVal"] = errormsg_alphaVal;
                return true;
            }
        }

        /* phone number validation*/
        public bool numberVal(string val)
        {
            string pattern = @"\d{10}";
            Match m = Regex.Match(val, pattern);
            string errormsg_numberVal;

            if (!m.Success || val.Length != 10)
            {

                errormsg_numberVal = "invalid entry only number are allowed.!" + "\n";
                errmsg["numberVal"]=errormsg_numberVal;
                return false;
            }
            else
            {
                errormsg_numberVal = "";
                errmsg["numberVal"] = errormsg_numberVal;
                return true;
            }

        }
        /* email validation*/
        public bool emailVal(string emailaddress)
        {
            string errormsg_emailVal;
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                errormsg_emailVal = "";
                errmsg["emailVal"]=errormsg_emailVal;
                return true;
            }
            catch (Exception)
            {
                errormsg_emailVal = "invalid email.!" + "\n";
                errmsg["emailVal"] = errormsg_emailVal;
                return false;
            }
        }

        /* numeric validation*/
        public bool IsNumeric(string input)
        {
            int test;
            string errormsg_IsNumeric;
            if (!int.TryParse(input, out test))
            {
                errormsg_IsNumeric = "invalid numeric value.!" + "\n";
                errmsg["IsNumeric"]=errormsg_IsNumeric;
                return false;
            }
            else
            {
                errormsg_IsNumeric = "";
                errmsg["IsNumeric"] = errormsg_IsNumeric;
                return true;
            }
        }

        /* check for alphbatical and numeric characters  */

        public bool alphaNumericVal(string val)
        {
            string pattern = @"^[A-Za-z0-9-\s]+$";
            Match m = Regex.Match(val, pattern);
            string errormsg_alphaNumericVal;

            if (!m.Success || val.Length > 45)
            {
                errormsg_alphaNumericVal = "invalid entry only letters are allowed.!" + "\n";
                errmsg["alphaNumericVal"]=errormsg_alphaNumericVal;
                return false;
            }
            else
            {
                errormsg_alphaNumericVal = "";
                errmsg["alphaNumericVal"] = errormsg_alphaNumericVal;
                return true;
            }
        }


        public void printError(bool val)
        {
            if (val)
            {
                string msg="";
               foreach(var a in errmsg)
                {
                    if (a.Value != "")
                        msg += a.Value;
                }
                MessageBox.Show(msg);
            }
        }

    }
}
