﻿using System;
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

                results = "";

                MBVResult rec2 = mbv.DisposableEmail("example@example.com");

                if (rec2.ErrorCode == "")
                {
                    results += "email_address: " + rec2.EmailAddress + "\n";
                    results += "is_disposable: " + rec2.IsDisposable + "\n";
                    results += "credits_available: " + rec2.CreditsAvailable + "\n";
                }
                else
                {
                    results += "error_code: " + rec2.ErrorCode + "\n";
                    results += "error_message: " + rec2.ErrorMessage + "\n";
                }

                results += "version: " + rec2.Version + "\n";
                MessageBox.Show(results);

                results = "";

                MBVResult rec3 = mbv.FreeEmail("example@example.com");

                if (rec3.ErrorCode == "")
                {
                    results += "email_address: " + rec3.EmailAddress + "\n";
                    results += "is_free: " + rec3.IsFree + "\n";
                    results += "credits_available: " + rec3.CreditsAvailable + "\n";
                }
                else
                {
                    results += "error_code: " + rec3.ErrorCode + "\n";
                    results += "error_message: " + rec3.ErrorMessage + "\n";
                }

                results += "version: " + rec3.Version + "\n";
                MessageBox.Show(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
