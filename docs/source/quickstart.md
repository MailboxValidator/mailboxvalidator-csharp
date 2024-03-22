# Quickstart

## Dependencies

An API key is required for this module to function.

Go to https://www.mailboxvalidator.com/plans#api to sign up for FREE API plan and you'll be given an API key.

## Compilation

Just open the solution file in Visual Studio 2022 or later and compile.

## Sample Codes

### Validate email

You can validate whether an email address is invalid or not as below:

```csharp
using Newtonsoft.Json;
using MailboxValidator;

var apikey = "PASTE_YOUR_API_KEY_HERE";
var email = "example@example.com";
SingleValidation mbv = new SingleValidation(apikey);

var mytask = mbv.ValidateEmailAsync(email); // async API Call
var myobj = mytask.Result;

Console.WriteLine(JsonConvert.SerializeObject(myobj, Formatting.Indented)); // to pretty-print the JSON

Console.WriteLine("email_address:" + myobj["email_address"].ToString());
Console.WriteLine("base_email_address:" + myobj["base_email_address"].ToString());
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
Console.WriteLine("is_dmarc_enforced:" + myobj["is_dmarc_enforced"].ToString());
Console.WriteLine("is_strict_spf:" + myobj["is_strict_spf"].ToString());
Console.WriteLine("website_exist:" + myobj["website_exist"].ToString());
Console.WriteLine("mailboxvalidator_score:" + myobj["mailboxvalidator_score"].ToString());
Console.WriteLine("time_taken:" + myobj["time_taken"].ToString());
Console.WriteLine("status:" + myobj["status"].ToString());
Console.WriteLine("credits_available:" + myobj["credits_available"].ToString());
```

### Check if an email is from a disposable email provider

You can validate whether an email address is disposable email address or not as below:

```csharp
using Newtonsoft.Json;
using MailboxValidator;

var apikey = "PASTE_YOUR_API_KEY_HERE";
var email = "example@example.com";
SingleValidation mbv = new SingleValidation(apikey);

var mytask = mbv.DisposableEmailAsync(email); // async API Call
var myobj = mytask.Result;

Console.WriteLine(JsonConvert.SerializeObject(myobj, Formatting.Indented)); // to pretty-print the JSON

Console.WriteLine("email_address:" + myobj["email_address"].ToString());
Console.WriteLine("is_disposable:" + myobj["is_disposable"].ToString());
Console.WriteLine("credits_available:" + myobj["credits_available"].ToString());
```

### Check if an email is from a free email provider

You can validate whether an email address is free email address or not as below:

```csharp
using Newtonsoft.Json;
using MailboxValidator;

var apikey = "PASTE_YOUR_API_KEY_HERE";
var email = "example@example.com";
SingleValidation mbv = new SingleValidation(apikey);

var mytask = mbv.FreeEmailAsync(email); // async API Call
var myobj = mytask.Result;

Console.WriteLine(JsonConvert.SerializeObject(myobj, Formatting.Indented)); // to pretty-print the JSON

Console.WriteLine("email_address:" + myobj["email_address"].ToString());
Console.WriteLine("is_free:" + myobj["is_free"].ToString());
Console.WriteLine("credits_available:" + myobj["credits_available"].ToString());
```
