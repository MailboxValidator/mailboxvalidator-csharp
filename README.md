MailboxValidator C# Libary
==========================

This C# library provides an easy way to call the MailboxValidator API which validates if an email address is a valid one.

This library can be used in many types of projects such as:

 - validating a user's email during sign up
 - cleaning your mailing list prior to an email marketing campaign
 - a form of fraud check

Compilation
===========

Just open the solution file in Visual Studio 2012 or later and compile:

Dependencies
============

An API key is required for this library to function.

Go to http://www.mailboxvalidator.com/plans#api to sign up for a FREE API plan and you'll be given an API key.

Sample Usage
============

```csharp
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using MailboxValidator;

namespace TestMailboxValidatorCSharp
{
    [TestClass]
    public class TestMailboxValidatorCSharp
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mbv = new SingleValidation("PASTE_YOUR_API_KEY_HERE");
            String results = "";
            try
            {
                MBVResult rec = mbv.ValidateEmail("example@example.com");

                if (rec.ErrorCode == "")
                {
                    results += "email_address: " + rec.EmailAddress + "\n";
                    results += "domain: " + rec.Domain + "\n";
                    results += "is_free: " + rec.IsFree + "\n";
                    results += "is_syntax: " + rec.IsSyntax + "\n";
                    results += "is_domain: " + rec.IsDomain + "\n";
                    results += "is_smtp: " + rec.IsSMTP + "\n";
                    results += "is_verified: " + rec.IsVerified + "\n";
                    results += "is_server_down: " + rec.IsServerDown + "\n";
                    results += "is_greylisted: " + rec.IsGreylisted + "\n";
                    results += "is_disposable: " + rec.IsDisposable + "\n";
                    results += "is_suppressed: " + rec.IsSuppressed + "\n";
                    results += "is_role: " + rec.IsRole + "\n";
                    results += "is_high_risk: " + rec.IsHighRisk + "\n";
                    results += "is_catchall: " + rec.IsCatchall + "\n";
                    results += "mailboxvalidator_score: " + rec.MailboxValidatorScore + "\n";
                    results += "time_taken: " + rec.TimeTaken + "\n";
                    results += "status: " + rec.Status + "\n";
                    results += "credits_available: " + rec.CreditsAvailable + "\n";
                }
                else
                {
                    results += "error_code: " + rec.ErrorCode + "\n";
                    results += "error_message: " + rec.ErrorMessage + "\n";
                }

                results += "version: " + rec.Version + "\n";
                MessageBox.Show(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
```

Copyright
=========

Copyright (C) 2017 by MailboxValidator.com, support@mailboxvalidator.com
