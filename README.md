MailboxValidator C# Libary
==========================

This C# library provides an easy way to call the MailboxValidator API which validates if an email address is a valid one.

This library can be used in many types of projects such as:

 - validating a user's email during sign up
 - cleaning your mailing list prior to an email marketing campaign
 - a form of fraud check

Compilation
===========

Just open the solution file in Visual Studio 2022 or later and compile:

Dependencies
============

An API key is required for this library to function.

Go to https://www.mailboxvalidator.com/plans#api to sign up for a FREE API plan and you'll be given an API key.

Usage for validating emails
===========================

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
```

Functions
=========

### SingleValidation(api_key)

Creates a new instance of the MailboxValidator object with the API key.

### ValidateEmailAsync(email_address)

Performs email validation on the supplied email address.

Result Fields
=============

### email_address

The input email address.

### domain

The domain of the email address.

### is_free

Whether the email address is from a free email provider like Gmail or Hotmail.

Return values: True, False

### is_syntax

Whether the email address is syntactically correct.

Return values: True, False

### is_domain

Whether the email address has a valid MX record in its DNS entries.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_smtp

Whether the mail servers specified in the MX records are responding to connections.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_verified

Whether the mail server confirms that the email address actually exist.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_server_down

Whether the mail server is currently down or unresponsive.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_greylisted

Whether the mail server employs greylisting where an email has to be sent a second time at a later time.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_disposable

Whether the email address is a temporary one from a disposable email provider.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_suppressed

Whether the email address is in our blacklist.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_role

Whether the email address is a role-based email address like admin@example.net or webmaster@example.net.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_high_risk

Whether the email address contains high risk keywords.

Return values: True, False, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### is_catchall

Whether the email address is a catch-all address.

Return values: True, False, Unknown, -&nbsp;&nbsp;&nbsp;(- means not applicable)

### mailboxvalidator_score

Email address reputation score.

Score > 0.70 means good; score > 0.40 means fair; score <= 0.40 means poor.

### time_taken

The time taken to get the results in seconds.

### status

Whether our system think the email address is valid based on all the previous fields.

Return values: True, False

### credits_available

The number of credits left to perform validations.


Usage for checking if an email is from a disposable email provider
==================================================================

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

Functions
=========

### SingleValidation(api_key)

Creates a new instance of the MailboxValidator object with the API key.

### DisposableEmailAsync(email_address)

Check if the supplied email address is from a disposable email provider.

Result Fields
=============

### email_address

The input email address.

### is_disposable

Whether the email address is a temporary one from a disposable email provider.

Return values: True, False

### credits_available

The number of credits left to perform validations.


Usage for checking if an email is from a free email provider
============================================================

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

Functions
=========

### SingleValidation(api_key)

Creates a new instance of the MailboxValidator object with the API key.

### FreeEmailAsync(email_address)

Check if the supplied email address is from a free email provider.

Result Fields
=============

### email_address

The input email address.

### is_free

Whether the email address is from a free email provider like Gmail or Hotmail.

Return values: True, False

### credits_available

The number of credits left to perform validations.


Copyright
=========

Copyright (C) 2023 by MailboxValidator.com, support@mailboxvalidator.com
