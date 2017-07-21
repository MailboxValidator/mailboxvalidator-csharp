using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace MailboxValidator
{
    public class SingleValidation
    {
        private String api_key = "";

        public SingleValidation(String apikey)
        {
            api_key = apikey;
        }

        public MBVResult ValidateEmail(String email)
        {

            MBVResult record = new MBVResult(email);

            HttpWebRequest request = null;
            HttpWebResponse response = null;

            Dictionary<String, String> data = new Dictionary<String, String>();

            data.Add("format", "json");
            data.Add("email", email);
            data.Add("key", api_key);
            String datastr = String.Join("&", data.Select(x => x.Key + "=" + System.Uri.EscapeDataString(x.Value)).ToArray());

            request = (HttpWebRequest)WebRequest.Create("http://api.mailboxvalidator.com/v1/validation/single?" + datastr.TrimStart("&".ToCharArray()));

            request.Method = "GET";
            response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            String output = reader.ReadToEnd();
            var jss = new JavaScriptSerializer();
            Dictionary<String, String> dict = jss.Deserialize<Dictionary<String, String>>(output);

            record.Domain = dict["domain"];
            record.IsFree = dict["is_free"];
            record.IsSyntax = dict["is_syntax"];
            record.IsDomain = dict["is_domain"];
            record.IsSMTP = dict["is_smtp"];
            record.IsVerified = dict["is_verified"];
            record.IsServerDown = dict["is_server_down"];
            record.IsGreylisted = dict["is_greylisted"];
            record.IsDisposable = dict["is_disposable"];
            record.IsSuppressed = dict["is_suppressed"];
            record.IsRole = dict["is_role"];
            record.IsHighRisk = dict["is_high_risk"];
            record.IsCatchall = dict["is_catchall"];
            record.MailboxValidatorScore = (dict["mailboxvalidator_score"] == "") ? (float)0.0 : Single.Parse(dict["mailboxvalidator_score"]);
            record.TimeTaken = Single.Parse(dict["time_taken"]);
            record.Status = dict["status"];
            record.CreditsAvailable = (dict["credits_available"] == "") ? 0 : UInt32.Parse(dict["credits_available"]);
            record.ErrorCode = dict["error_code"];
            record.ErrorMessage = dict["error_message"];

            return record;
        }
    }
}
