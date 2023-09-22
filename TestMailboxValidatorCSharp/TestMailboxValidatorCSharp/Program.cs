using Newtonsoft.Json;
using MailboxValidator;

var apikey = "PASTE_YOUR_API_KEY_HERE";
var email = "example@example.com";
SingleValidation mbv = new SingleValidation(apikey);

var mytask = mbv.ValidateEmailAsync(email); // async API Call
var myobj = mytask.Result;

Console.WriteLine(JsonConvert.SerializeObject(myobj, Formatting.Indented)); // to pretty-print the JSON

Console.WriteLine("email_address:" + myobj["email_address"].ToString());
Console.WriteLine("domain:" + myobj["domain"].ToString());
Console.WriteLine("is_free:" + myobj["is_free"].ToString());
Console.WriteLine("is_syntax:" + myobj["is_syntax"].ToString());
Console.WriteLine("is_domain:" + myobj["is_domain"].ToString());
Console.WriteLine("is_smtp:" + myobj["is_smtp"].ToString());
Console.WriteLine("is_verified:" + myobj["is_verified"].ToString());
Console.WriteLine("is_server_down:" + myobj["is_server_down"].ToString());
Console.WriteLine("is_greylisted:" + myobj["is_greylisted"].ToString());
Console.WriteLine("is_disposable:" + myobj["is_disposable"].ToString());
Console.WriteLine("is_suppressed:" + myobj["is_suppressed"].ToString());
Console.WriteLine("is_role:" + myobj["is_role"].ToString());
Console.WriteLine("is_high_risk:" + myobj["is_high_risk"].ToString());
Console.WriteLine("is_catchall:" + myobj["is_catchall"].ToString());
Console.WriteLine("mailboxvalidator_score:" + myobj["mailboxvalidator_score"].ToString());
Console.WriteLine("time_taken:" + myobj["time_taken"].ToString());
Console.WriteLine("status:" + myobj["status"].ToString());
Console.WriteLine("credits_available:" + myobj["credits_available"].ToString());

var mytask2 = mbv.DisposableEmailAsync(email); // async API Call
var myobj2 = mytask2.Result;

Console.WriteLine(JsonConvert.SerializeObject(myobj2, Formatting.Indented)); // to pretty-print the JSON

Console.WriteLine("email_address:" + myobj2["email_address"].ToString());
Console.WriteLine("is_disposable:" + myobj2["is_disposable"].ToString());
Console.WriteLine("credits_available:" + myobj2["credits_available"].ToString());

var mytask3 = mbv.FreeEmailAsync(email); // async API Call
var myobj3 = mytask3.Result;

Console.WriteLine(JsonConvert.SerializeObject(myobj3, Formatting.Indented)); // to pretty-print the JSON

Console.WriteLine("email_address:" + myobj3["email_address"].ToString());
Console.WriteLine("is_free:" + myobj3["is_free"].ToString());
Console.WriteLine("credits_available:" + myobj3["credits_available"].ToString());
