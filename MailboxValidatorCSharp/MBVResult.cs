using System;

namespace MailboxValidator
{
    public class MBVResult
    {
        private String _email_address;
        private String _domain;
        private String _is_free;
        private String _is_syntax;
        private String _is_domain;
        private String _is_smtp;
        private String _is_verified;
        private String _is_server_down;
        private String _is_greylisted;
        private String _is_disposable;
        private String _is_suppressed;
        private String _is_role;
        private String _is_high_risk;
        private String _is_catchall;
        private Single _mailboxvalidator_score;
        private Single _time_taken;
        private String _status;
        private UInt32 _credits_available;
        private String _error_code;
        private String _error_message;

        public MBVResult(String email)
        {
            _email_address = email;
        }

        public string EmailAddress { get { return _email_address; } }
        public string Domain { get { return _domain; } set { _domain = value; } }
        public string IsFree { get { return _is_free; } set { _is_free = value; } }
        public string IsSyntax { get { return _is_syntax; } set { _is_syntax = value; } }
        public string IsDomain { get { return _is_domain; } set { _is_domain = value; } }
        public string IsSMTP { get { return _is_smtp; } set { _is_smtp = value; } }
        public string IsVerified { get { return _is_verified; } set { _is_verified = value; } }
        public string IsServerDown { get { return _is_server_down; } set { _is_server_down = value; } }
        public string IsGreylisted { get { return _is_greylisted; } set { _is_greylisted = value; } }
        public string IsDisposable { get { return _is_disposable; } set { _is_disposable = value; } }
        public string IsSuppressed { get { return _is_suppressed; } set { _is_suppressed = value; } }
        public string IsRole { get { return _is_role; } set { _is_role = value; } }
        public string IsHighRisk { get { return _is_high_risk; } set { _is_high_risk = value; } }
        public string IsCatchall { get { return _is_catchall; } set { _is_catchall = value; } }
        public Single MailboxValidatorScore { get { return _mailboxvalidator_score; } set { _mailboxvalidator_score = value; } }
        public Single TimeTaken { get { return _time_taken; } set { _time_taken = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public UInt32 CreditsAvailable { get { return _credits_available; } set { _credits_available = value; } }
        public string ErrorCode { get { return _error_code; } set { _error_code = value; } }
        public string ErrorMessage { get { return _error_message; } set { _error_message = value; } }

        public string Version
        {
            get
            {
                var Ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                return Ver.Major + "." + Ver.Minor + "." + Ver.Build;
            }
        }
    }
}
